using Bb.CommandLines;
using Bb.CommandLines.Ins;
using Bb.CommandLines.Outs;
using Bb.CommandLines.Validators;
using Bb.Sdk.Net.Mails;
using Bb.Sdk.Net.Mails.Configurations;
using Bb.Sdk.Net.Mails.Models;
using Bb.Sdk.Net.Mails.Renderer;
using Black.Beard.Sdk.Net.Mails;
using Microsoft.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;

namespace Bb.Mails.Commands
{


    /*
     
    // render models
    .\mail.exe generate rendering debug "D:\Src\Sdk\sdk.net\src\Tests" "D:\Src\Sdk\sdk.net\src\Tests\model.json"

    // Generate schemas
    .\mail.exe generate schemas "D:\Src\Sdk\sdk.net\src\Tests"


    */


    /// <summary>
    /// 
    /// </summary>
    public static partial class Command
    {

        public static CommandLineApplication CommandExport(this CommandLineApplication app)
        {

            // json template 

            var cmd = app.Command("generate", config =>
            {

                config.Description = "generate processors";
                config.HelpOption(HelpFlag);

            });

            cmd.Command("rendering", config =>
            {

                config.Description = "run template transformation with the specified template";
                config.HelpOption(HelpFlag);

                var validator = new GroupArgument(config);

                var argsmtpName = validator.Argument("<Smtp profile>", "Smtp profile in the configuration file"
                    , ValidatorExtension.EvaluateDirectoryPathIsValid
                    , ValidatorExtension.EvaluateRequired
                    );

                var argTemplatePath = validator.Argument("<source template directory path>", "template direnctory path"
                    , ValidatorExtension.EvaluateDirectoryPathIsValid
                    , ValidatorExtension.EvaluateRequired
                    );

                var argModelPath = validator.Argument("<source datas model>", "model path"
                    , ValidatorExtension.EvaluateDirectoryPathIsValid
                    , ValidatorExtension.EvaluateRequired
                    );

                //var argtarget = validator.Argument("<target folder>", "json target path that contains data source"
                //     , ValidatorExtension.EvaluateRequired
                //     );

                var argconfig = validator.Option("--config", "json configuration file path");


                config.OnExecute(() =>
                {

                    if (!validator.Evaluate(out int errorNum))
                        return errorNum;

                    // load config
                    var sourceDir = new DirectoryInfo(argTemplatePath.Value);
                    LoadConfiguration(argconfig, sourceDir);


                    // load model
                    var model = argModelPath.Value
                                            .LoadContentFromFile()
                                            .Deserialize<DataModel>();

                    // init render
                    //var targetDir = new DirectoryInfo(argtarget.Value.TrimPath());




                    RazorMessageRenderer render = new RazorMessageRenderer()
                    {
                        MessageLoader = new FolderMessageLoader(sourceDir)
                    };

                    MailNotificationService service = new MailNotificationService(argsmtpName.Value, render)
                    {
                        
                    };

                    service.MailEvents += (sender, e) =>
                    {

                    };

                    foreach (var item in model.GetDatas())
                    {
                       service.Send(item);
                    }

                    return 0;

                });

            });


            cmd.Command("schemas", config =>
            {

                config.Description = "run template transformation with the specified template";
                config.HelpOption(HelpFlag);

                var validator = new GroupArgument(config);

                var argtarget = validator.Argument("<target folder>", "json target path that contains data source"
                     , ValidatorExtension.EvaluateRequired
                     );

                var argSource = validator.Option("--source", "json source file path that contains data source. if option is missing source is readed from stdin stream");

                config.OnExecute(() =>
                {

                    if (!validator.Evaluate(out int errorNum))
                        return errorNum;

                    var targetDir = new DirectoryInfo(argtarget.Value.TrimPath());

                    if (!targetDir.Exists)
                        targetDir.Create();


                    var setting = new NJsonSchema.Generation.JsonSchemaGeneratorSettings();
                    setting.GenerateEnumMappingDescription = true;
                    setting.ActualSerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());


                    NJsonSchema.JsonSchema.FromType<Bb.Sdk.Net.Mails.Configurations.Configuration>(setting)
                        .AllowAdditionalProperties()
                        .ToJson()
                        .Save(Path.Combine(targetDir.FullName, "Configuration.schema.json"));


                    NJsonSchema.JsonSchema.FromType<DataModel>(setting)
                        .AllowAdditionalProperties()
                        .ToJson()
                        .Save(Path.Combine(targetDir.FullName, "MailModel.schema.json"));


                    return 0;

                });

            });



            return app;

        }


        private static void LoadConfiguration(CommandOption argconfig, DirectoryInfo sourceDir)
        {
            if (argconfig.HasValue())
            {
                var file = new FileInfo(argconfig.Value());
                if (file.Exists)
                    Configuration.InitializeConfiguration(file.FullName);
            }

            if (!Configuration.Initialized)
            {

                var file = new FileInfo(Path.Combine(sourceDir.FullName, "config.json"));
                file.Refresh();
                if (file.Exists)
                    Configuration.InitializeConfiguration(file.FullName);
                else
                    Configuration.TryToInitialiseFromDirectoryWork();

            }

            if (!Configuration.Initialized)
            {

            }
        }
    }

    public static class JsonSchemaExtension
    {

        public static NJsonSchema.JsonSchema AllowAdditionalProperties(this NJsonSchema.JsonSchema self)
        {
            self.AllowAdditionalProperties = true;
            return self;

        }

    }

}
