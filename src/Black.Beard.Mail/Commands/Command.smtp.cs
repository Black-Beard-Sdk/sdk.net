using Bb.CommandLines;
using Bb.CommandLines.Validators;
using Bb.Sdk.Net.Mails.Configurations;
using Bb.Sdk.Net.Mails.Senders;
using Microsoft.Extensions.CommandLineUtils;
using System.IO;
using System.Linq;

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

        public static CommandLineApplication CommandSmtp(this CommandLineApplication app)
        {

            // json template 

            var cmd = app.Command("profile", config =>
            {
                config.Description = "manage profile configuration";
                config.HelpOption(HelpFlag);
            });

            var set = cmd.Command("set", config =>
            {

            });

            set.Command("smtp", config =>
            {

                config.Description = "run template transformation with the specified template";
                config.HelpOption(HelpFlag);

                var validator = new GroupArgument(config);

                var argfilePath = validator.Argument("<directory configuration path>", "configuration path"
                   , ValidatorExtension.EvaluateDirectoryPathIsValid
                   , ValidatorExtension.EvaluateRequired
                   );

                var argsmtpName = validator.Argument("<Smtp profile name>", "Smtp profile name to add"
                    , ValidatorExtension.EvaluateRequired
                );

                var argsmtpHosname = validator.Argument("<hostname>", "hostname of the smtp server"
                    , ValidatorExtension.EvaluateRequired
                );

                var optUsername = validator.Option("--u", "username for authentication on the smtp server");
                var optPwd = validator.Option("--pwd", "password for authentication on the smtp server");
                var optSsl = validator.OptionNoValue("--nossl", "username for authentication on the smtp server");
                var optPort = validator.Option("--port", "username for authentication on the smtp server");

                var optDebug = validator.OptionNoValue("--debug", "");
                var optDebugMail = validator.Option("--maildebug", "");
                var optBccMail = validator.Option("--bccmail", "");

                var optTimeout = validator.Option("--timeout", "");

                var optsenderMail = validator.Option("--sendermail", "");
                var optsenderName = validator.Option("--sender", "");


                var argconfig = validator.Option("--config", "json configuration file path");


                config.OnExecute(() =>
                {

                    if (!validator.Evaluate(out int errorNum))
                        return errorNum;

                // load config
                var sourceDir = new DirectoryInfo(argfilePath.Value.TrimPath());
                    LoadConfiguration(argconfig, sourceDir);

                    var name = argsmtpName.Value.TrimPath();

                    SmtpProfile profile = null;
                    bool to_add = true;

                    if (Configuration.Instance.Profiles.Any(c => c.Name == name))
                    {
                        var p = Configuration.Instance.Profiles.FirstOrDefault(c => c.Name == name);
                        if (p != null && p is SmtpProfile s)
                        {
                            to_add = false;
                            profile = s;
                        }
                    }

                    profile = new SmtpProfile()
                    {
                        Name = name,
                        DeliveryFormat = System.Net.Mail.SmtpDeliveryFormat.International,
                        DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    // PickupDirectoryLocation = "",
                };

                    profile.HostName = argsmtpHosname.Value.TrimPath();
                    profile.EnabledSsl = !optSsl.HasValue();

                    if (optBccMail.HasValue())
                        profile.BccAddress = optBccMail.Value();

                    if (optsenderMail.HasValue())
                        profile.SenderAddress = optsenderMail.Value();

                    if (optsenderName.HasValue())
                        profile.SenderName = optsenderName.Value();

                    if (optTimeout.HasValue())
                        profile.TimeOut = int.Parse(optTimeout.Value());

                    if (optUsername.HasValue())
                        profile.Username = optUsername.Value();

                    if (optPwd.HasValue())
                        profile.Password = optPwd.Value();


                    if (optPort.HasValue())
                        profile.Port = int.Parse(optPort.Value());

                    if (optDebug.HasValue())
                    {
                        profile.MailDebugTo = optDebugMail.Value();
                        profile.DebugMode = true;
                    }

                    if (to_add)
                        Configuration.Instance.Profiles.Add(profile);

                    Configuration.Instance.Save();

                    return 0;

                });

            });

            return app;

        }



    }


}
