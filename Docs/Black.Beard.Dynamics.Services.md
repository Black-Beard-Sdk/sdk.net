<a name='assembly'></a>
# Black.Beard.Dynamics.Services

## Contents

- [ApiKeyGenerator](#T-Bb-Services-ApiKeyGenerator 'Bb.Services.ApiKeyGenerator')
  - [GenerateApiKey(length)](#M-Bb-Services-ApiKeyGenerator-GenerateApiKey-System-Int32- 'Bb.Services.ApiKeyGenerator.GenerateApiKey(System.Int32)')
  - [GenerateIdentifiers(apiKey,salt,loginLength,passwordLength)](#M-Bb-Services-ApiKeyGenerator-GenerateIdentifiers-System-String,System-Int32,System-Int32,System-String- 'Bb.Services.ApiKeyGenerator.GenerateIdentifiers(System.String,System.Int32,System.Int32,System.String)')
  - [GeneratePassword(rawData,lengthPassword,salt)](#M-Bb-Services-ApiKeyGenerator-GeneratePassword-System-String,System-Int32,System-String- 'Bb.Services.ApiKeyGenerator.GeneratePassword(System.String,System.Int32,System.String)')
  - [ResolveLogin(rawData,lengthLogin,salt)](#M-Bb-Services-ApiKeyGenerator-ResolveLogin-System-String,System-Int32,System-String- 'Bb.Services.ApiKeyGenerator.ResolveLogin(System.String,System.Int32,System.String)')
- [ApikeyExtension](#T-Bb-Extensions-ApikeyExtension 'Bb.Extensions.ApikeyExtension')
  - [AddRestClient(services)](#M-Bb-Extensions-ApikeyExtension-AddRestClient-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Bb.Extensions.ApikeyExtension.AddRestClient(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddTokenProvider(services)](#M-Bb-Extensions-ApikeyExtension-AddTokenProvider-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Bb.Extensions.ApikeyExtension.AddTokenProvider(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [WithApiKeyAuthentication(application)](#M-Bb-Extensions-ApikeyExtension-WithApiKeyAuthentication-Microsoft-AspNetCore-Builder-WebApplication- 'Bb.Extensions.ApikeyExtension.WithApiKeyAuthentication(Microsoft.AspNetCore.Builder.WebApplication)')
- [Assemblies](#T-Bb-Loaders-Extensions-Assemblies 'Bb.Loaders.Extensions.Assemblies')
  - [AdditionalAssemblies](#P-Bb-Loaders-Extensions-Assemblies-AdditionalAssemblies 'Bb.Loaders.Extensions.Assemblies.AdditionalAssemblies')
  - [WebAssemblies](#P-Bb-Loaders-Extensions-Assemblies-WebAssemblies 'Bb.Loaders.Extensions.Assemblies.WebAssemblies')
  - [ContainPage(assembly)](#M-Bb-Loaders-Extensions-Assemblies-ContainPage-System-Reflection-Assembly- 'Bb.Loaders.Extensions.Assemblies.ContainPage(System.Reflection.Assembly)')
- [BearerOption](#T-Bb-Models-BearerOption 'Bb.Models.BearerOption')
  - [IssuerSigningKey](#P-Bb-Models-BearerOption-IssuerSigningKey 'Bb.Models.BearerOption.IssuerSigningKey')
  - [Name](#P-Bb-Models-BearerOption-Name 'Bb.Models.BearerOption.Name')
  - [ValidAudience](#P-Bb-Models-BearerOption-ValidAudience 'Bb.Models.BearerOption.ValidAudience')
  - [ValidIssuer](#P-Bb-Models-BearerOption-ValidIssuer 'Bb.Models.BearerOption.ValidIssuer')
  - [ValidateAudience](#P-Bb-Models-BearerOption-ValidateAudience 'Bb.Models.BearerOption.ValidateAudience')
  - [ValidateIssuer](#P-Bb-Models-BearerOption-ValidateIssuer 'Bb.Models.BearerOption.ValidateIssuer')
  - [ValidateIssuerSigningKey](#P-Bb-Models-BearerOption-ValidateIssuerSigningKey 'Bb.Models.BearerOption.ValidateIssuerSigningKey')
  - [ValidateLifetime](#P-Bb-Models-BearerOption-ValidateLifetime 'Bb.Models.BearerOption.ValidateLifetime')
- [BlazorBuilderInitializer](#T-Bb-Loaders-BlazorBuilderInitializer 'Bb.Loaders.BlazorBuilderInitializer')
  - [#ctor()](#M-Bb-Loaders-BlazorBuilderInitializer-#ctor 'Bb.Loaders.BlazorBuilderInitializer.#ctor')
  - [Initialize](#P-Bb-Loaders-BlazorBuilderInitializer-Initialize 'Bb.Loaders.BlazorBuilderInitializer.Initialize')
  - [CanExecute(context)](#M-Bb-Loaders-BlazorBuilderInitializer-CanExecute-System-Object- 'Bb.Loaders.BlazorBuilderInitializer.CanExecute(System.Object)')
  - [Execute(builder)](#M-Bb-Loaders-BlazorBuilderInitializer-Execute-Microsoft-AspNetCore-Builder-WebApplicationBuilder- 'Bb.Loaders.BlazorBuilderInitializer.Execute(Microsoft.AspNetCore.Builder.WebApplicationBuilder)')
- [Certificate](#T-Bb-Models-Certificate 'Bb.Models.Certificate')
  - [Password](#P-Bb-Models-Certificate-Password 'Bb.Models.Certificate.Password')
  - [SourcePath](#P-Bb-Models-Certificate-SourcePath 'Bb.Models.Certificate.SourcePath')
  - [TypeSource](#P-Bb-Models-Certificate-TypeSource 'Bb.Models.Certificate.TypeSource')
- [CertificateHelpers](#T-Bb-Services-CertificateHelpers 'Bb.Services.CertificateHelpers')
  - [CreateSelfSignedCertificate(subjectName,password)](#M-Bb-Services-CertificateHelpers-CreateSelfSignedCertificate-System-String,System-String- 'Bb.Services.CertificateHelpers.CreateSelfSignedCertificate(System.String,System.String)')
  - [LoadCertificateFromFile(certPath,certPassword)](#M-Bb-Services-CertificateHelpers-LoadCertificateFromFile-System-IO-FileInfo,System-String- 'Bb.Services.CertificateHelpers.LoadCertificateFromFile(System.IO.FileInfo,System.String)')
  - [LoadCertificateFromStore(subjectName)](#M-Bb-Services-CertificateHelpers-LoadCertificateFromStore-System-String- 'Bb.Services.CertificateHelpers.LoadCertificateFromStore(System.String)')
  - [SaveCertificateToFile(certificate,filePath,password)](#M-Bb-Services-CertificateHelpers-SaveCertificateToFile-System-Security-Cryptography-X509Certificates-X509Certificate2,System-String,System-String- 'Bb.Services.CertificateHelpers.SaveCertificateToFile(System.Security.Cryptography.X509Certificates.X509Certificate2,System.String,System.String)')
  - [StoreCertificate(certificate)](#M-Bb-Services-CertificateHelpers-StoreCertificate-System-Security-Cryptography-X509Certificates-X509Certificate2- 'Bb.Services.CertificateHelpers.StoreCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2)')
- [CertificateNotFoundException](#T-Bb-Exceptions-CertificateNotFoundException 'Bb.Exceptions.CertificateNotFoundException')
  - [#ctor()](#M-Bb-Exceptions-CertificateNotFoundException-#ctor 'Bb.Exceptions.CertificateNotFoundException.#ctor')
  - [#ctor(message)](#M-Bb-Exceptions-CertificateNotFoundException-#ctor-System-String- 'Bb.Exceptions.CertificateNotFoundException.#ctor(System.String)')
  - [#ctor(message,inner)](#M-Bb-Exceptions-CertificateNotFoundException-#ctor-System-String,System-Exception- 'Bb.Exceptions.CertificateNotFoundException.#ctor(System.String,System.Exception)')
- [ClientOptionConfiguration](#T-Bb-Models-ClientOptionConfiguration 'Bb.Models.ClientOptionConfiguration')
  - [Name](#P-Bb-Models-ClientOptionConfiguration-Name 'Bb.Models.ClientOptionConfiguration.Name')
- [ConfigurationExtension](#T-Bb-Extensions-ConfigurationExtension 'Bb.Extensions.ConfigurationExtension')
  - [LoadConfiguration(builder,filter,pattern)](#M-Bb-Extensions-ConfigurationExtension-LoadConfiguration-Microsoft-AspNetCore-Builder-WebApplicationBuilder,System-Func{System-IO-FileInfo,System-Boolean},System-String- 'Bb.Extensions.ConfigurationExtension.LoadConfiguration(Microsoft.AspNetCore.Builder.WebApplicationBuilder,System.Func{System.IO.FileInfo,System.Boolean},System.String)')
  - [LoadConfiguration(builder,filter,pattern)](#M-Bb-Extensions-ConfigurationExtension-LoadConfiguration-Microsoft-Extensions-Configuration-IConfigurationBuilder,System-Func{System-IO-FileInfo,System-Boolean},System-String- 'Bb.Extensions.ConfigurationExtension.LoadConfiguration(Microsoft.Extensions.Configuration.IConfigurationBuilder,System.Func{System.IO.FileInfo,System.Boolean},System.String)')
- [ConfigurationFile](#T-Bb-Services-ConfigurationFile 'Bb.Services.ConfigurationFile')
  - [Environment](#F-Bb-Services-ConfigurationFile-Environment 'Bb.Services.ConfigurationFile.Environment')
  - [FileInfo](#F-Bb-Services-ConfigurationFile-FileInfo 'Bb.Services.ConfigurationFile.FileInfo')
  - [Name](#F-Bb-Services-ConfigurationFile-Name 'Bb.Services.ConfigurationFile.Name')
- [ConfigurationLoader](#T-Bb-Loaders-ConfigurationLoader 'Bb.Loaders.ConfigurationLoader')
- [ConfigurationLoader](#T-Bb-Services-ConfigurationLoader 'Bb.Services.ConfigurationLoader')
  - [#ctor()](#M-Bb-Loaders-ConfigurationLoader-#ctor 'Bb.Loaders.ConfigurationLoader.#ctor')
  - [#ctor(pattern,filter)](#M-Bb-Services-ConfigurationLoader-#ctor-System-String,System-Func{System-IO-FileInfo,System-Boolean}- 'Bb.Services.ConfigurationLoader.#ctor(System.String,System.Func{System.IO.FileInfo,System.Boolean})')
  - [Configuration](#P-Bb-Loaders-ConfigurationLoader-Configuration 'Bb.Loaders.ConfigurationLoader.Configuration')
  - [ConfigurationPath](#P-Bb-Loaders-ConfigurationLoader-ConfigurationPath 'Bb.Loaders.ConfigurationLoader.ConfigurationPath')
  - [Execute(context)](#M-Bb-Loaders-ConfigurationLoader-Execute-Microsoft-AspNetCore-Builder-WebApplicationBuilder- 'Bb.Loaders.ConfigurationLoader.Execute(Microsoft.AspNetCore.Builder.WebApplicationBuilder)')
  - [AddFolders(paths)](#M-Bb-Services-ConfigurationLoader-AddFolders-System-String[]- 'Bb.Services.ConfigurationLoader.AddFolders(System.String[])')
  - [ComputeEnvironmentName(name)](#M-Bb-Services-ConfigurationLoader-ComputeEnvironmentName-System-String- 'Bb.Services.ConfigurationLoader.ComputeEnvironmentName(System.String)')
  - [ComputeName(name)](#M-Bb-Services-ConfigurationLoader-ComputeName-System-String- 'Bb.Services.ConfigurationLoader.ComputeName(System.String)')
  - [GetEnumerator()](#M-Bb-Services-ConfigurationLoader-GetEnumerator 'Bb.Services.ConfigurationLoader.GetEnumerator')
  - [GetFiles(filter,item,pattern)](#M-Bb-Services-ConfigurationLoader-GetFiles-System-Func{System-IO-FileInfo,System-Boolean},System-IO-DirectoryInfo,System-String- 'Bb.Services.ConfigurationLoader.GetFiles(System.Func{System.IO.FileInfo,System.Boolean},System.IO.DirectoryInfo,System.String)')
- [HttpContextExtension](#T-Bb-Extensions-HttpContextExtension 'Bb.Extensions.HttpContextExtension')
  - [IsDebug](#P-Bb-Extensions-HttpContextExtension-IsDebug 'Bb.Extensions.HttpContextExtension.IsDebug')
  - [SetResponse(context,data)](#M-Bb-Extensions-HttpContextExtension-SetResponse-Microsoft-AspNetCore-Http-HttpContext,System-Object- 'Bb.Extensions.HttpContextExtension.SetResponse(Microsoft.AspNetCore.Http.HttpContext,System.Object)')
  - [SetResponse(context,contentType,data)](#M-Bb-Extensions-HttpContextExtension-SetResponse-Microsoft-AspNetCore-Http-HttpContext,RestSharp-ContentType,System-String- 'Bb.Extensions.HttpContextExtension.SetResponse(Microsoft.AspNetCore.Http.HttpContext,RestSharp.ContentType,System.String)')
- [HttpInfoLoggerMiddleware](#T-Bb-Middleware-HttpInfoLoggerMiddleware 'Bb.Middleware.HttpInfoLoggerMiddleware')
  - [#ctor(next,logger)](#M-Bb-Middleware-HttpInfoLoggerMiddleware-#ctor-Microsoft-AspNetCore-Http-RequestDelegate,Microsoft-Extensions-Logging-ILogger{Bb-Middleware-HttpInfoLoggerMiddleware}- 'Bb.Middleware.HttpInfoLoggerMiddleware.#ctor(Microsoft.AspNetCore.Http.RequestDelegate,Microsoft.Extensions.Logging.ILogger{Bb.Middleware.HttpInfoLoggerMiddleware})')
  - [InvokeAsync(context)](#M-Bb-Middleware-HttpInfoLoggerMiddleware-InvokeAsync-Microsoft-AspNetCore-Http-HttpContext- 'Bb.Middleware.HttpInfoLoggerMiddleware.InvokeAsync(Microsoft.AspNetCore.Http.HttpContext)')
  - [LogRequest(context)](#M-Bb-Middleware-HttpInfoLoggerMiddleware-LogRequest-Microsoft-AspNetCore-Http-HttpContext- 'Bb.Middleware.HttpInfoLoggerMiddleware.LogRequest(Microsoft.AspNetCore.Http.HttpContext)')
  - [LogResponse(context)](#M-Bb-Middleware-HttpInfoLoggerMiddleware-LogResponse-Microsoft-AspNetCore-Http-HttpContext- 'Bb.Middleware.HttpInfoLoggerMiddleware.LogResponse(Microsoft.AspNetCore.Http.HttpContext)')
  - [TraceRequest(r)](#M-Bb-Middleware-HttpInfoLoggerMiddleware-TraceRequest-Microsoft-AspNetCore-Http-HttpRequest- 'Bb.Middleware.HttpInfoLoggerMiddleware.TraceRequest(Microsoft.AspNetCore.Http.HttpRequest)')
  - [TraceResponse(r)](#M-Bb-Middleware-HttpInfoLoggerMiddleware-TraceResponse-Microsoft-AspNetCore-Http-HttpResponse- 'Bb.Middleware.HttpInfoLoggerMiddleware.TraceResponse(Microsoft.AspNetCore.Http.HttpResponse)')
  - [TryToGetForm(r)](#M-Bb-Middleware-HttpInfoLoggerMiddleware-TryToGetForm-Microsoft-AspNetCore-Http-HttpRequest- 'Bb.Middleware.HttpInfoLoggerMiddleware.TryToGetForm(Microsoft.AspNetCore.Http.HttpRequest)')
- [HttpInfoLoggerMiddlewareExtensions](#T-Bb-Extensions-HttpInfoLoggerMiddlewareExtensions 'Bb.Extensions.HttpInfoLoggerMiddlewareExtensions')
  - [UseHttpExceptionInterceptor\`\`1(builder)](#M-Bb-Extensions-HttpInfoLoggerMiddlewareExtensions-UseHttpExceptionInterceptor``1-``0- 'Bb.Extensions.HttpInfoLoggerMiddlewareExtensions.UseHttpExceptionInterceptor``1(``0)')
  - [UseHttpInfoLogger\`\`1(builder)](#M-Bb-Extensions-HttpInfoLoggerMiddlewareExtensions-UseHttpInfoLogger``1-``0- 'Bb.Extensions.HttpInfoLoggerMiddlewareExtensions.UseHttpInfoLogger``1(``0)')
- [IRequestResponseLogModelCreator](#T-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator 'Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator')
  - [LogModel](#P-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator-LogModel 'Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator.LogModel')
  - [LogString()](#M-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator-LogString 'Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator.LogString')
- [IRequestResponseLogger](#T-Bb-Middleware-EntryFullLogger-IRequestResponseLogger 'Bb.Middleware.EntryFullLogger.IRequestResponseLogger')
  - [Log(logCreator)](#M-Bb-Middleware-EntryFullLogger-IRequestResponseLogger-Log-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator- 'Bb.Middleware.EntryFullLogger.IRequestResponseLogger.Log(Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator)')
- [IVaultSecretResolver](#T-Bb-Interfaces-IVaultSecretResolver 'Bb.Interfaces.IVaultSecretResolver')
  - [GetSecret(path)](#M-Bb-Interfaces-IVaultSecretResolver-GetSecret-System-String[]- 'Bb.Interfaces.IVaultSecretResolver.GetSecret(System.String[])')
- [InitializerExtension](#T-Bb-Extensions-InitializerExtension 'Bb.Extensions.InitializerExtension')
  - [AppendFoldersToDiscovers(paths,startupConfiguration)](#M-Bb-Extensions-InitializerExtension-AppendFoldersToDiscovers-System-String[],Bb-Models-StartupConfiguration- 'Bb.Extensions.InitializerExtension.AppendFoldersToDiscovers(System.String[],Bb.Models.StartupConfiguration)')
  - [Initialize(self)](#M-Bb-Extensions-InitializerExtension-Initialize-Microsoft-AspNetCore-Builder-WebApplicationBuilder- 'Bb.Extensions.InitializerExtension.Initialize(Microsoft.AspNetCore.Builder.WebApplicationBuilder)')
  - [Initialize(self)](#M-Bb-Extensions-InitializerExtension-Initialize-Microsoft-AspNetCore-Builder-WebApplication- 'Bb.Extensions.InitializerExtension.Initialize(Microsoft.AspNetCore.Builder.WebApplication)')
  - [LoadAssemblies(paths)](#M-Bb-Extensions-InitializerExtension-LoadAssemblies-System-String[]- 'Bb.Extensions.InitializerExtension.LoadAssemblies(System.String[])')
  - [LoadAssemblies(startupConfiguration)](#M-Bb-Extensions-InitializerExtension-LoadAssemblies-Bb-Models-StartupConfiguration- 'Bb.Extensions.InitializerExtension.LoadAssemblies(Bb.Models.StartupConfiguration)')
  - [LoadPackages(startupConfiguration)](#M-Bb-Extensions-InitializerExtension-LoadPackages-Bb-Models-StartupConfiguration- 'Bb.Extensions.InitializerExtension.LoadPackages(Bb.Models.StartupConfiguration)')
  - [ResolveConfiguration()](#M-Bb-Extensions-InitializerExtension-ResolveConfiguration 'Bb.Extensions.InitializerExtension.ResolveConfiguration')
- [IocAutoDiscoverExtension](#T-Bb-Extensions-IocAutoDiscoverExtension 'Bb.Extensions.IocAutoDiscoverExtension')
  - [BindConfiguration(self,type,configuration)](#M-Bb-Extensions-IocAutoDiscoverExtension-BindConfiguration-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Type,Microsoft-Extensions-Configuration-IConfiguration- 'Bb.Extensions.IocAutoDiscoverExtension.BindConfiguration(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Type,Microsoft.Extensions.Configuration.IConfiguration)')
  - [DiscoverTypeExposedByAttribute(contextKey,action)](#M-Bb-Extensions-IocAutoDiscoverExtension-DiscoverTypeExposedByAttribute-System-String,System-Action{System-Type}- 'Bb.Extensions.IocAutoDiscoverExtension.DiscoverTypeExposedByAttribute(System.String,System.Action{System.Type})')
  - [GetExposedTypes(contextName)](#M-Bb-Extensions-IocAutoDiscoverExtension-GetExposedTypes-System-String- 'Bb.Extensions.IocAutoDiscoverExtension.GetExposedTypes(System.String)')
  - [GetExposedTypes(filter)](#M-Bb-Extensions-IocAutoDiscoverExtension-GetExposedTypes-System-Func{Bb-ComponentModel-Attributes-ExposeClassAttribute,System-Boolean}- 'Bb.Extensions.IocAutoDiscoverExtension.GetExposedTypes(System.Func{Bb.ComponentModel.Attributes.ExposeClassAttribute,System.Boolean})')
  - [ResolveConfiguration(configuration,type,action)](#M-Bb-Extensions-IocAutoDiscoverExtension-ResolveConfiguration-Microsoft-Extensions-Configuration-IConfiguration,System-Type,System-Action{System-Type,System-String,Microsoft-Extensions-Configuration-IConfigurationSection}- 'Bb.Extensions.IocAutoDiscoverExtension.ResolveConfiguration(Microsoft.Extensions.Configuration.IConfiguration,System.Type,System.Action{System.Type,System.String,Microsoft.Extensions.Configuration.IConfigurationSection})')
  - [UseTypeExposedByAttribute(services,configuration,contextKey,filter,action)](#M-Bb-Extensions-IocAutoDiscoverExtension-UseTypeExposedByAttribute-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration,System-String,System-Func{System-Type,System-String,System-Boolean},System-Action{System-Type}- 'Bb.Extensions.IocAutoDiscoverExtension.UseTypeExposedByAttribute(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration,System.String,System.Func{System.Type,System.String,System.Boolean},System.Action{System.Type})')
- [LoggingBuilderInitializer](#T-Bb-Loaders-LoggingBuilderInitializer 'Bb.Loaders.LoggingBuilderInitializer')
  - [Execute(context)](#M-Bb-Loaders-LoggingBuilderInitializer-Execute-Microsoft-Extensions-Logging-ILoggingBuilder- 'Bb.Loaders.LoggingBuilderInitializer.Execute(Microsoft.Extensions.Logging.ILoggingBuilder)')
- [LoggingExtension](#T-Bb-Extensions-LoggingExtension 'Bb.Extensions.LoggingExtension')
  - [ConfigureTrace(builder)](#M-Bb-Extensions-LoggingExtension-ConfigureTrace-Microsoft-AspNetCore-Builder-WebApplicationBuilder- 'Bb.Extensions.LoggingExtension.ConfigureTrace(Microsoft.AspNetCore.Builder.WebApplicationBuilder)')
- [OptionsEnum](#T-Bb-Loaders-Extensions-OptionsEnum 'Bb.Loaders.Extensions.OptionsEnum')
  - [Configuration](#F-Bb-Loaders-Extensions-OptionsEnum-Configuration 'Bb.Loaders.Extensions.OptionsEnum.Configuration')
- [OptionsServices](#T-Bb-Loaders-Extensions-OptionsServices 'Bb.Loaders.Extensions.OptionsServices')
  - [#ctor(services)](#M-Bb-Loaders-Extensions-OptionsServices-#ctor-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Bb.Loaders.Extensions.OptionsServices.#ctor(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [Items(services,option)](#M-Bb-Loaders-Extensions-OptionsServices-Items-System-IServiceProvider,Bb-Loaders-Extensions-OptionsEnum- 'Bb.Loaders.Extensions.OptionsServices.Items(System.IServiceProvider,Bb.Loaders.Extensions.OptionsEnum)')
- [Package](#T-Bb-Models-Package 'Bb.Models.Package')
  - [#ctor()](#M-Bb-Models-Package-#ctor 'Bb.Models.Package.#ctor')
  - [Id](#P-Bb-Models-Package-Id 'Bb.Models.Package.Id')
  - [Version](#P-Bb-Models-Package-Version 'Bb.Models.Package.Version')
  - [op_Implicit(value)](#M-Bb-Models-Package-op_Implicit-System-String-~Bb-Models-Package 'Bb.Models.Package.op_Implicit(System.String)~Bb.Models.Package')
- [PackageManager](#T-Bb-Services-PackageManager 'Bb.Services.PackageManager')
  - [#ctor(logger)](#M-Bb-Services-PackageManager-#ctor-Microsoft-Extensions-Logging-ILogger{Bb-Services-PackageManager}- 'Bb.Services.PackageManager.#ctor(Microsoft.Extensions.Logging.ILogger{Bb.Services.PackageManager})')
  - [Assemblies](#P-Bb-Services-PackageManager-Assemblies 'Bb.Services.PackageManager.Assemblies')
  - [Resolve(packages)](#M-Bb-Services-PackageManager-Resolve-Bb-Models-Packages- 'Bb.Services.PackageManager.Resolve(Bb.Models.Packages)')
  - [Resolve(package)](#M-Bb-Services-PackageManager-Resolve-Bb-Models-Package- 'Bb.Services.PackageManager.Resolve(Bb.Models.Package)')
  - [Resolve(packageId,version)](#M-Bb-Services-PackageManager-Resolve-System-String,System-Version- 'Bb.Services.PackageManager.Resolve(System.String,System.Version)')
  - [SetTarget(path)](#M-Bb-Services-PackageManager-SetTarget-System-String- 'Bb.Services.PackageManager.SetTarget(System.String)')
  - [WithReference(type)](#M-Bb-Services-PackageManager-WithReference-System-Type- 'Bb.Services.PackageManager.WithReference(System.Type)')
- [Packages](#T-Bb-Models-Packages 'Bb.Models.Packages')
  - [op_Implicit(packages)](#M-Bb-Models-Packages-op_Implicit-Bb-Models-Package[]-~Bb-Models-Packages 'Bb.Models.Packages.op_Implicit(Bb.Models.Package[])~Bb.Models.Packages')
- [PolicyExtension](#T-Bb-Extensions-PolicyExtension 'Bb.Extensions.PolicyExtension')
  - [AddPolicy(builder,filePath,filter,configureAction)](#M-Bb-Extensions-PolicyExtension-AddPolicy-Microsoft-AspNetCore-Builder-WebApplicationBuilder,System-String,System-Func{Bb-Policies-Asts-PolicyRule,System-Boolean},System-Action{Microsoft-AspNetCore-Authorization-AuthorizationOptions}- 'Bb.Extensions.PolicyExtension.AddPolicy(Microsoft.AspNetCore.Builder.WebApplicationBuilder,System.String,System.Func{Bb.Policies.Asts.PolicyRule,System.Boolean},System.Action{Microsoft.AspNetCore.Authorization.AuthorizationOptions})')
  - [ConfigurePolicy(application)](#M-Bb-Extensions-PolicyExtension-ConfigurePolicy-Microsoft-AspNetCore-Builder-WebApplication- 'Bb.Extensions.PolicyExtension.ConfigurePolicy(Microsoft.AspNetCore.Builder.WebApplication)')
  - [GetAuthorizePoliciesFromAssemblies()](#M-Bb-Extensions-PolicyExtension-GetAuthorizePoliciesFromAssemblies 'Bb.Extensions.PolicyExtension.GetAuthorizePoliciesFromAssemblies')
- [RequestResponseLogModel](#T-Bb-Middleware-EntryFullLogger-RequestResponseLogModel 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel')
  - [#ctor()](#M-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-#ctor 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.#ctor')
  - [ClientIp](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ClientIp 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.ClientIp')
  - [ExceptionMessage](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ExceptionMessage 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.ExceptionMessage')
  - [ExceptionStackTrace](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ExceptionStackTrace 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.ExceptionStackTrace')
  - [IsExceptionActionLevel](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-IsExceptionActionLevel 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.IsExceptionActionLevel')
  - [LogId](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-LogId 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.LogId')
  - [Node](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-Node 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.Node')
  - [RequestBody](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestBody 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.RequestBody')
  - [RequestContentType](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestContentType 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.RequestContentType')
  - [RequestDateTimeUtc](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestDateTimeUtc 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.RequestDateTimeUtc')
  - [RequestDateTimeUtcActionLevel](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestDateTimeUtcActionLevel 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.RequestDateTimeUtcActionLevel')
  - [RequestHeaders](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestHeaders 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.RequestHeaders')
  - [RequestHost](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestHost 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.RequestHost')
  - [RequestMethod](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestMethod 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.RequestMethod')
  - [RequestPath](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestPath 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.RequestPath')
  - [RequestQueries](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestQueries 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.RequestQueries')
  - [RequestQuery](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestQuery 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.RequestQuery')
  - [RequestScheme](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestScheme 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.RequestScheme')
  - [ResponseBody](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseBody 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.ResponseBody')
  - [ResponseContentType](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseContentType 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.ResponseContentType')
  - [ResponseDateTimeUtc](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseDateTimeUtc 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.ResponseDateTimeUtc')
  - [ResponseDateTimeUtcActionLevel](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseDateTimeUtcActionLevel 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.ResponseDateTimeUtcActionLevel')
  - [ResponseHeaders](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseHeaders 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.ResponseHeaders')
  - [ResponseStatus](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseStatus 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.ResponseStatus')
  - [TraceId](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-TraceId 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel.TraceId')
- [RequestResponseLogModelCreator](#T-Bb-Middleware-EntryFullLogger-RequestResponseLogModelCreator 'Bb.Middleware.EntryFullLogger.RequestResponseLogModelCreator')
  - [#ctor()](#M-Bb-Middleware-EntryFullLogger-RequestResponseLogModelCreator-#ctor 'Bb.Middleware.EntryFullLogger.RequestResponseLogModelCreator.#ctor')
  - [LogModel](#P-Bb-Middleware-EntryFullLogger-RequestResponseLogModelCreator-LogModel 'Bb.Middleware.EntryFullLogger.RequestResponseLogModelCreator.LogModel')
  - [LogString()](#M-Bb-Middleware-EntryFullLogger-RequestResponseLogModelCreator-LogString 'Bb.Middleware.EntryFullLogger.RequestResponseLogModelCreator.LogString')
- [RequestResponseLogger](#T-Bb-Middleware-EntryFullLogger-RequestResponseLogger 'Bb.Middleware.EntryFullLogger.RequestResponseLogger')
  - [#ctor(logger)](#M-Bb-Middleware-EntryFullLogger-RequestResponseLogger-#ctor-Microsoft-Extensions-Logging-ILogger{Bb-Middleware-EntryFullLogger-RequestResponseLogger}- 'Bb.Middleware.EntryFullLogger.RequestResponseLogger.#ctor(Microsoft.Extensions.Logging.ILogger{Bb.Middleware.EntryFullLogger.RequestResponseLogger})')
  - [Log(logCreator)](#M-Bb-Middleware-EntryFullLogger-RequestResponseLogger-Log-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator- 'Bb.Middleware.EntryFullLogger.RequestResponseLogger.Log(Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator)')
- [RequestResponseLoggerMiddleware](#T-Bb-Middleware-RequestResponseLoggerMiddleware 'Bb.Middleware.RequestResponseLoggerMiddleware')
  - [#ctor(next,options,logger)](#M-Bb-Middleware-RequestResponseLoggerMiddleware-#ctor-Microsoft-AspNetCore-Http-RequestDelegate,Microsoft-Extensions-Options-IOptions{Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption},Bb-Middleware-EntryFullLogger-IRequestResponseLogger- 'Bb.Middleware.RequestResponseLoggerMiddleware.#ctor(Microsoft.AspNetCore.Http.RequestDelegate,Microsoft.Extensions.Options.IOptions{Bb.Middleware.EntryFullLogger.RequestResponseLoggerOption},Bb.Middleware.EntryFullLogger.IRequestResponseLogger)')
  - [FormatHeaders(headers)](#M-Bb-Middleware-RequestResponseLoggerMiddleware-FormatHeaders-Microsoft-AspNetCore-Http-IHeaderDictionary- 'Bb.Middleware.RequestResponseLoggerMiddleware.FormatHeaders(Microsoft.AspNetCore.Http.IHeaderDictionary)')
  - [FormatQueries(queryString)](#M-Bb-Middleware-RequestResponseLoggerMiddleware-FormatQueries-System-String- 'Bb.Middleware.RequestResponseLoggerMiddleware.FormatQueries(System.String)')
  - [InvokeAsync(httpContext,logCreator)](#M-Bb-Middleware-RequestResponseLoggerMiddleware-InvokeAsync-Microsoft-AspNetCore-Http-HttpContext,Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator- 'Bb.Middleware.RequestResponseLoggerMiddleware.InvokeAsync(Microsoft.AspNetCore.Http.HttpContext,Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator)')
  - [LogError(log,exception)](#M-Bb-Middleware-RequestResponseLoggerMiddleware-LogError-Bb-Middleware-EntryFullLogger-RequestResponseLogModel,System-Exception- 'Bb.Middleware.RequestResponseLoggerMiddleware.LogError(Bb.Middleware.EntryFullLogger.RequestResponseLogModel,System.Exception)')
  - [ReadBodyFromRequest(request)](#M-Bb-Middleware-RequestResponseLoggerMiddleware-ReadBodyFromRequest-Microsoft-AspNetCore-Http-HttpRequest- 'Bb.Middleware.RequestResponseLoggerMiddleware.ReadBodyFromRequest(Microsoft.AspNetCore.Http.HttpRequest)')
- [RequestResponseLoggerOption](#T-Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption 'Bb.Middleware.EntryFullLogger.RequestResponseLoggerOption')
  - [#ctor()](#M-Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption-#ctor 'Bb.Middleware.EntryFullLogger.RequestResponseLoggerOption.#ctor')
  - [DateTimeFormat](#P-Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption-DateTimeFormat 'Bb.Middleware.EntryFullLogger.RequestResponseLoggerOption.DateTimeFormat')
  - [IsEnabled](#P-Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption-IsEnabled 'Bb.Middleware.EntryFullLogger.RequestResponseLoggerOption.IsEnabled')
  - [Name](#P-Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption-Name 'Bb.Middleware.EntryFullLogger.RequestResponseLoggerOption.Name')
- [RestClientFactoryExtension](#T-Bb-Extensions-RestClientFactoryExtension 'Bb.Extensions.RestClientFactoryExtension')
  - [AddRestClientFactory(services)](#M-Bb-Extensions-RestClientFactoryExtension-AddRestClientFactory-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Bb.Extensions.RestClientFactoryExtension.AddRestClientFactory(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [RestClientOptions](#T-Bb-Models-RestClientOptions 'Bb.Models.RestClientOptions')
  - [#ctor()](#M-Bb-Models-RestClientOptions-#ctor 'Bb.Models.RestClientOptions.#ctor')
  - [ClientActivated](#P-Bb-Models-RestClientOptions-ClientActivated 'Bb.Models.RestClientOptions.ClientActivated')
  - [Options](#P-Bb-Models-RestClientOptions-Options 'Bb.Models.RestClientOptions.Options')
  - [TokenClientId](#P-Bb-Models-RestClientOptions-TokenClientId 'Bb.Models.RestClientOptions.TokenClientId')
  - [TokenClientSecret](#P-Bb-Models-RestClientOptions-TokenClientSecret 'Bb.Models.RestClientOptions.TokenClientSecret')
  - [TokenUrl](#P-Bb-Models-RestClientOptions-TokenUrl 'Bb.Models.RestClientOptions.TokenUrl')
  - [UseApiKey](#P-Bb-Models-RestClientOptions-UseApiKey 'Bb.Models.RestClientOptions.UseApiKey')
- [RouteListingMiddleware](#T-Bb-Middleware-RouteListingMiddleware 'Bb.Middleware.RouteListingMiddleware')
  - [#ctor(next,logger)](#M-Bb-Middleware-RouteListingMiddleware-#ctor-Microsoft-AspNetCore-Http-RequestDelegate,Microsoft-Extensions-Logging-ILogger{Bb-Middleware-RouteListingMiddleware}- 'Bb.Middleware.RouteListingMiddleware.#ctor(Microsoft.AspNetCore.Http.RequestDelegate,Microsoft.Extensions.Logging.ILogger{Bb.Middleware.RouteListingMiddleware})')
  - [InvokeAsync(context,endpointDataSource)](#M-Bb-Middleware-RouteListingMiddleware-InvokeAsync-Microsoft-AspNetCore-Http-HttpContext,Microsoft-AspNetCore-Routing-EndpointDataSource- 'Bb.Middleware.RouteListingMiddleware.InvokeAsync(Microsoft.AspNetCore.Http.HttpContext,Microsoft.AspNetCore.Routing.EndpointDataSource)')
- [RouteListingMiddlewareExtensions](#T-Bb-Extensions-RouteListingMiddlewareExtensions 'Bb.Extensions.RouteListingMiddlewareExtensions')
  - [UseRouteListing(builder)](#M-Bb-Extensions-RouteListingMiddlewareExtensions-UseRouteListing-Microsoft-AspNetCore-Builder-IApplicationBuilder- 'Bb.Extensions.RouteListingMiddlewareExtensions.UseRouteListing(Microsoft.AspNetCore.Builder.IApplicationBuilder)')
- [SchemaGenerator](#T-Site-Services-SchemaGenerator 'Site.Services.SchemaGenerator')
  - [#ctor(path,idTemplate)](#M-Site-Services-SchemaGenerator-#ctor-System-String,System-String- 'Site.Services.SchemaGenerator.#ctor(System.String,System.String)')
  - [_idTemplate](#F-Site-Services-SchemaGenerator-_idTemplate 'Site.Services.SchemaGenerator._idTemplate')
  - [_instance](#F-Site-Services-SchemaGenerator-_instance 'Site.Services.SchemaGenerator._instance')
  - [_path](#F-Site-Services-SchemaGenerator-_path 'Site.Services.SchemaGenerator._path')
  - [GenerateSchema(type)](#M-Site-Services-SchemaGenerator-GenerateSchema-System-Type- 'Site.Services.SchemaGenerator.GenerateSchema(System.Type)')
  - [GenerateSchemaImpl(type)](#M-Site-Services-SchemaGenerator-GenerateSchemaImpl-System-Type- 'Site.Services.SchemaGenerator.GenerateSchemaImpl(System.Type)')
  - [GetFilename(name)](#M-Site-Services-SchemaGenerator-GetFilename-System-String- 'Site.Services.SchemaGenerator.GetFilename(System.String)')
  - [Initialize(path,idTemplate)](#M-Site-Services-SchemaGenerator-Initialize-System-String,System-String- 'Site.Services.SchemaGenerator.Initialize(System.String,System.String)')
- [SourceCertificate](#T-Bb-Models-SourceCertificate 'Bb.Models.SourceCertificate')
  - [File](#F-Bb-Models-SourceCertificate-File 'Bb.Models.SourceCertificate.File')
  - [Store](#F-Bb-Models-SourceCertificate-Store 'Bb.Models.SourceCertificate.Store')
- [Startup](#T-Bb-Extensions-Startup 'Bb.Extensions.Startup')
  - [#ctor(configuration,service)](#M-Bb-Extensions-Startup-#ctor-Microsoft-Extensions-Configuration-IConfiguration,Bb-Services-WebService- 'Bb.Extensions.Startup.#ctor(Microsoft.Extensions.Configuration.IConfiguration,Bb.Services.WebService)')
  - [_configuration](#F-Bb-Extensions-Startup-_configuration 'Bb.Extensions.Startup._configuration')
  - [_service](#F-Bb-Extensions-Startup-_service 'Bb.Extensions.Startup._service')
  - [Configuration](#P-Bb-Extensions-Startup-Configuration 'Bb.Extensions.Startup.Configuration')
  - [Configure(application,environment)](#M-Bb-Extensions-Startup-Configure-Microsoft-AspNetCore-Builder-WebApplication,Microsoft-AspNetCore-Hosting-IWebHostEnvironment- 'Bb.Extensions.Startup.Configure(Microsoft.AspNetCore.Builder.WebApplication,Microsoft.AspNetCore.Hosting.IWebHostEnvironment)')
  - [ConfigureServices(builder,services)](#M-Bb-Extensions-Startup-ConfigureServices-Microsoft-AspNetCore-Builder-WebApplicationBuilder,Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Bb.Extensions.Startup.ConfigureServices(Microsoft.AspNetCore.Builder.WebApplicationBuilder,Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [LoadCertificate()](#M-Bb-Extensions-Startup-LoadCertificate 'Bb.Extensions.Startup.LoadCertificate')
  - [LoadFromFile(certificate)](#M-Bb-Extensions-Startup-LoadFromFile-Bb-Models-Certificate- 'Bb.Extensions.Startup.LoadFromFile(Bb.Models.Certificate)')
  - [LoadFromFile2(certificate)](#M-Bb-Extensions-Startup-LoadFromFile2-Bb-Models-Certificate- 'Bb.Extensions.Startup.LoadFromFile2(Bb.Models.Certificate)')
  - [ManageBearer(services)](#M-Bb-Extensions-Startup-ManageBearer-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Bb.Extensions.Startup.ManageBearer(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [ManageCertificate(webHost)](#M-Bb-Extensions-Startup-ManageCertificate-Microsoft-AspNetCore-Builder-ConfigureWebHostBuilder- 'Bb.Extensions.Startup.ManageCertificate(Microsoft.AspNetCore.Builder.ConfigureWebHostBuilder)')
- [StartupConfiguration](#T-Bb-Models-StartupConfiguration 'Bb.Models.StartupConfiguration')
  - [#ctor()](#M-Bb-Models-StartupConfiguration-#ctor 'Bb.Models.StartupConfiguration.#ctor')
  - [AssemblyNames](#P-Bb-Models-StartupConfiguration-AssemblyNames 'Bb.Models.StartupConfiguration.AssemblyNames')
  - [BearerOptions](#P-Bb-Models-StartupConfiguration-BearerOptions 'Bb.Models.StartupConfiguration.BearerOptions')
  - [Folders](#P-Bb-Models-StartupConfiguration-Folders 'Bb.Models.StartupConfiguration.Folders')
  - [HTTPSCertificate](#P-Bb-Models-StartupConfiguration-HTTPSCertificate 'Bb.Models.StartupConfiguration.HTTPSCertificate')
  - [LogExceptions](#P-Bb-Models-StartupConfiguration-LogExceptions 'Bb.Models.StartupConfiguration.LogExceptions')
  - [LogInfo](#P-Bb-Models-StartupConfiguration-LogInfo 'Bb.Models.StartupConfiguration.LogInfo')
  - [MapBlazorHub](#P-Bb-Models-StartupConfiguration-MapBlazorHub 'Bb.Models.StartupConfiguration.MapBlazorHub')
  - [MapFallbackToPage](#P-Bb-Models-StartupConfiguration-MapFallbackToPage 'Bb.Models.StartupConfiguration.MapFallbackToPage')
  - [Packages](#P-Bb-Models-StartupConfiguration-Packages 'Bb.Models.StartupConfiguration.Packages')
  - [PolicyFiles](#P-Bb-Models-StartupConfiguration-PolicyFiles 'Bb.Models.StartupConfiguration.PolicyFiles')
  - [RestClient](#P-Bb-Models-StartupConfiguration-RestClient 'Bb.Models.StartupConfiguration.RestClient')
  - [UseRouting](#P-Bb-Models-StartupConfiguration-UseRouting 'Bb.Models.StartupConfiguration.UseRouting')
  - [UseStaticFiles](#P-Bb-Models-StartupConfiguration-UseStaticFiles 'Bb.Models.StartupConfiguration.UseStaticFiles')
- [StartupExtensions](#T-Bb-Extensions-StartupExtensions 'Bb.Extensions.StartupExtensions')
  - [ResolveParameters(serviceProvider,configureServicesMethod)](#M-Bb-Extensions-StartupExtensions-ResolveParameters-Bb-ComponentModel-Factories-LocalServiceProvider,System-Reflection-MethodInfo- 'Bb.Extensions.StartupExtensions.ResolveParameters(Bb.ComponentModel.Factories.LocalServiceProvider,System.Reflection.MethodInfo)')
  - [TestExist\`\`1(self)](#M-Bb-Extensions-StartupExtensions-TestExist``1-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Bb.Extensions.StartupExtensions.TestExist``1(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [UseStartupConfigure\`\`1(application,startup,serviceProvider)](#M-Bb-Extensions-StartupExtensions-UseStartupConfigure``1-Microsoft-AspNetCore-Builder-WebApplication,``0,Bb-ComponentModel-Factories-LocalServiceProvider- 'Bb.Extensions.StartupExtensions.UseStartupConfigure``1(Microsoft.AspNetCore.Builder.WebApplication,``0,Bb.ComponentModel.Factories.LocalServiceProvider)')
  - [UseStartup\`\`1(builder,startup,serviceProvider)](#M-Bb-Extensions-StartupExtensions-UseStartup``1-Microsoft-AspNetCore-Builder-WebApplicationBuilder,``0,Bb-ComponentModel-Factories-LocalServiceProvider- 'Bb.Extensions.StartupExtensions.UseStartup``1(Microsoft.AspNetCore.Builder.WebApplicationBuilder,``0,Bb.ComponentModel.Factories.LocalServiceProvider)')
- [TokenProvider](#T-Bb-Services-TokenProvider 'Bb.Services.TokenProvider')
  - [#ctor(cache,resolver)](#M-Bb-Services-TokenProvider-#ctor-Microsoft-Extensions-Caching-Memory-IMemoryCache,Bb-Services-TokenResolver- 'Bb.Services.TokenProvider.#ctor(Microsoft.Extensions.Caching.Memory.IMemoryCache,Bb.Services.TokenResolver)')
  - [Fetch(apiKey)](#M-Bb-Services-TokenProvider-Fetch-System-String- 'Bb.Services.TokenProvider.Fetch(System.String)')
  - [GetTokenAsync(apiKey)](#M-Bb-Services-TokenProvider-GetTokenAsync-System-String- 'Bb.Services.TokenProvider.GetTokenAsync(System.String)')
  - [ValidateToken(token,secretKey,validIssuer,validAudience)](#M-Bb-Services-TokenProvider-ValidateToken-System-String,System-String,System-String,System-String- 'Bb.Services.TokenProvider.ValidateToken(System.String,System.String,System.String,System.String)')
- [TokenResolver](#T-Bb-Services-TokenResolver 'Bb.Services.TokenResolver')
  - [#ctor(restFactory,configuration)](#M-Bb-Services-TokenResolver-#ctor-Bb-Interfaces-IRestClientFactory,Bb-Models-StartupConfiguration- 'Bb.Services.TokenResolver.#ctor(Bb.Interfaces.IRestClientFactory,Bb.Models.StartupConfiguration)')
  - [GeTokenAsync(userName,password)](#M-Bb-Services-TokenResolver-GeTokenAsync-System-String,System-String- 'Bb.Services.TokenResolver.GeTokenAsync(System.String,System.String)')
  - [Initialize()](#M-Bb-Services-TokenResolver-Initialize 'Bb.Services.TokenResolver.Initialize')
- [TypesExtension](#T-Bb-Extensions-TypesExtension 'Bb.Extensions.TypesExtension')
  - [AppendConfiguration(configuration,serviceProvider)](#M-Bb-Extensions-TypesExtension-AppendConfiguration-Microsoft-Extensions-Configuration-ConfigurationManager,Bb-ComponentModel-Factories-LocalServiceProvider- 'Bb.Extensions.TypesExtension.AppendConfiguration(Microsoft.Extensions.Configuration.ConfigurationManager,Bb.ComponentModel.Factories.LocalServiceProvider)')
  - [SetAllIoc(builder,filter)](#M-Bb-Extensions-TypesExtension-SetAllIoc-Microsoft-AspNetCore-Builder-WebApplicationBuilder,System-Func{System-Type,System-String,System-Boolean}- 'Bb.Extensions.TypesExtension.SetAllIoc(Microsoft.AspNetCore.Builder.WebApplicationBuilder,System.Func{System.Type,System.String,System.Boolean})')
- [Unix](#T-Bb-Services-CertificateHelpers-Unix 'Bb.Services.CertificateHelpers.Unix')
  - [LoadCertificateFromUnixStore(subjectName)](#M-Bb-Services-CertificateHelpers-Unix-LoadCertificateFromUnixStore-System-String- 'Bb.Services.CertificateHelpers.Unix.LoadCertificateFromUnixStore(System.String)')
  - [SetCertificateInStore(certificate)](#M-Bb-Services-CertificateHelpers-Unix-SetCertificateInStore-System-Security-Cryptography-X509Certificates-X509Certificate2- 'Bb.Services.CertificateHelpers.Unix.SetCertificateInStore(System.Security.Cryptography.X509Certificates.X509Certificate2)')
- [VaultEas256Resolver](#T-Bb-Services-VaultEas256Resolver 'Bb.Services.VaultEas256Resolver')
  - [#ctor(configuration)](#M-Bb-Services-VaultEas256Resolver-#ctor-Microsoft-Extensions-Configuration-IConfiguration- 'Bb.Services.VaultEas256Resolver.#ctor(Microsoft.Extensions.Configuration.IConfiguration)')
  - [_secret](#F-Bb-Services-VaultEas256Resolver-_secret 'Bb.Services.VaultEas256Resolver._secret')
  - [_secretNameConfiguration](#F-Bb-Services-VaultEas256Resolver-_secretNameConfiguration 'Bb.Services.VaultEas256Resolver._secretNameConfiguration')
  - [GetSecret(path)](#M-Bb-Services-VaultEas256Resolver-GetSecret-System-String[]- 'Bb.Services.VaultEas256Resolver.GetSecret(System.String[])')
- [WebApplicationBuilderIocInitializer](#T-Bb-Loaders-WebApplicationBuilderIocInitializer 'Bb.Loaders.WebApplicationBuilderIocInitializer')
  - [Execute(builder)](#M-Bb-Loaders-WebApplicationBuilderIocInitializer-Execute-Microsoft-AspNetCore-Builder-WebApplicationBuilder- 'Bb.Loaders.WebApplicationBuilderIocInitializer.Execute(Microsoft.AspNetCore.Builder.WebApplicationBuilder)')
- [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService')
  - [#ctor(args)](#M-Bb-Services-WebService-#ctor-System-String[]- 'Bb.Services.WebService.#ctor(System.String[])')
  - [Build(configure)](#M-Bb-Services-WebService-Build-System-Action{Microsoft-AspNetCore-Builder-WebApplication}- 'Bb.Services.WebService.Build(System.Action{Microsoft.AspNetCore.Builder.WebApplication})')
  - [Configure(configure)](#M-Bb-Services-WebService-Configure-System-Action{Microsoft-AspNetCore-Builder-WebApplication}- 'Bb.Services.WebService.Configure(System.Action{Microsoft.AspNetCore.Builder.WebApplication})')
  - [Configure\`\`1(configure)](#M-Bb-Services-WebService-Configure``1-System-Action{``0}- 'Bb.Services.WebService.Configure``1(System.Action{``0})')
  - [Dispose(disposing)](#M-Bb-Services-WebService-Dispose-System-Boolean- 'Bb.Services.WebService.Dispose(System.Boolean)')
  - [Dispose()](#M-Bb-Services-WebService-Dispose 'Bb.Services.WebService.Dispose')
  - [GetApplication()](#M-Bb-Services-WebService-GetApplication 'Bb.Services.WebService.GetApplication')
  - [GetService(serviceType)](#M-Bb-Services-WebService-GetService-System-Type- 'Bb.Services.WebService.GetService(System.Type)')
  - [GetService\`\`1()](#M-Bb-Services-WebService-GetService``1 'Bb.Services.WebService.GetService``1')
  - [Prepare(configure)](#M-Bb-Services-WebService-Prepare-System-Action{Microsoft-AspNetCore-Builder-WebApplicationBuilder}- 'Bb.Services.WebService.Prepare(System.Action{Microsoft.AspNetCore.Builder.WebApplicationBuilder})')
  - [Prepare\`\`1(configure)](#M-Bb-Services-WebService-Prepare``1-System-Action{``0}- 'Bb.Services.WebService.Prepare``1(System.Action{``0})')
  - [Resolve\`\`1()](#M-Bb-Services-WebService-Resolve``1 'Bb.Services.WebService.Resolve``1')
  - [Run()](#M-Bb-Services-WebService-Run 'Bb.Services.WebService.Run')
  - [RunAsync()](#M-Bb-Services-WebService-RunAsync-System-Boolean- 'Bb.Services.WebService.RunAsync(System.Boolean)')
  - [UseStartup\`\`1(action)](#M-Bb-Services-WebService-UseStartup``1-System-Action{``0}- 'Bb.Services.WebService.UseStartup``1(System.Action{``0})')
  - [WithDynamicHTTP()](#M-Bb-Services-WebService-WithDynamicHTTP 'Bb.Services.WebService.WithDynamicHTTP')
  - [WithDynamicHTTP(host)](#M-Bb-Services-WebService-WithDynamicHTTP-System-String- 'Bb.Services.WebService.WithDynamicHTTP(System.String)')
  - [WithDynamicHTTPS()](#M-Bb-Services-WebService-WithDynamicHTTPS 'Bb.Services.WebService.WithDynamicHTTPS')
  - [WithDynamicHTTPS(host)](#M-Bb-Services-WebService-WithDynamicHTTPS-System-String- 'Bb.Services.WebService.WithDynamicHTTPS(System.String)')
  - [WithHTTP(port)](#M-Bb-Services-WebService-WithHTTP-System-Nullable{System-Int32}- 'Bb.Services.WebService.WithHTTP(System.Nullable{System.Int32})')
  - [WithHTTP(host,port)](#M-Bb-Services-WebService-WithHTTP-System-String,System-Nullable{System-Int32}- 'Bb.Services.WebService.WithHTTP(System.String,System.Nullable{System.Int32})')
  - [WithHTTPS(port)](#M-Bb-Services-WebService-WithHTTPS-System-Nullable{System-Int32}- 'Bb.Services.WebService.WithHTTPS(System.Nullable{System.Int32})')
  - [WithHTTPS(host,port)](#M-Bb-Services-WebService-WithHTTPS-System-String,System-Nullable{System-Int32}- 'Bb.Services.WebService.WithHTTPS(System.String,System.Nullable{System.Int32})')
- [Windows](#T-Bb-Services-CertificateHelpers-Windows 'Bb.Services.CertificateHelpers.Windows')
  - [LoadCertificateFromWindowsStore(subjectName)](#M-Bb-Services-CertificateHelpers-Windows-LoadCertificateFromWindowsStore-System-String- 'Bb.Services.CertificateHelpers.Windows.LoadCertificateFromWindowsStore(System.String)')
  - [SetCertificateInStore(certificate)](#M-Bb-Services-CertificateHelpers-Windows-SetCertificateInStore-System-Security-Cryptography-X509Certificates-X509Certificate2- 'Bb.Services.CertificateHelpers.Windows.SetCertificateInStore(System.Security.Cryptography.X509Certificates.X509Certificate2)')

<a name='T-Bb-Services-ApiKeyGenerator'></a>
## ApiKeyGenerator `type`

##### Namespace

Bb.Services

##### Summary

Provides methods for generating API keys and security identifiers.

<a name='M-Bb-Services-ApiKeyGenerator-GenerateApiKey-System-Int32-'></a>
### GenerateApiKey(length) `method`

##### Summary

Generates a random API key of the specified length.

##### Returns

A random API key string of the specified length.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the API key to generate. Must be greater than 0. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when length is less than or equal to 0. |

##### Example

```C#
// Generate a 32-character API key
string apiKey = ApiKeyGenerator.GenerateApiKey(32);
Console.WriteLine($"Generated API key: {apiKey}");
```

##### Remarks

This method creates a random string using a mix of alphanumeric and special characters.
The randomness is based on the standard .NET Random class.

<a name='M-Bb-Services-ApiKeyGenerator-GenerateIdentifiers-System-String,System-Int32,System-Int32,System-String-'></a>
### GenerateIdentifiers(apiKey,salt,loginLength,passwordLength) `method`

##### Summary

Generates a login and password pair based on the provided raw data.

##### Returns

A tuple containing the generated login and password.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw data to use as seed for generating identifiers. Must not be null or empty. |
| salt | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | third part for concatenate to rawData before generate login and password |
| loginLength | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | after hash is computed select only length character for login |
| passwordLength | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | after hash is computed select only length character for password |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when rawData is null. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown when rawData is empty. |

##### Example

```C#
// Generate login and password from user email
string email = "user@example.com";
var cnx = ApiKeyGenerator.GenerateIdentifiers(email, "mysalt");
Console.WriteLine($"Generated apikey: {cnx[0]}");
Console.WriteLine($"Generated login: {{cnx[1]}");
Console.WriteLine($"Generated password: {{cnx[2]}");
```

##### Remarks

This method first generates a login by hashing the raw data using SHA256.
Then it generates a password by hashing the login.

<a name='M-Bb-Services-ApiKeyGenerator-GeneratePassword-System-String,System-Int32,System-String-'></a>
### GeneratePassword(rawData,lengthPassword,salt) `method`

##### Summary

Generates a password by hashing the provided raw data.

##### Returns

A hexadecimal string representation of the SHA256 hash of the raw data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rawData | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw data to hash. Must not be null. |
| lengthPassword | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | string length of the password. Must be upper of 15 characters |
| salt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | third part for concatenate to rawData before generate password |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when rawData is null. |

##### Remarks

This method computes the SHA1 hash of the raw data and returns it as a hexadecimal string.

<a name='M-Bb-Services-ApiKeyGenerator-ResolveLogin-System-String,System-Int32,System-String-'></a>
### ResolveLogin(rawData,lengthLogin,salt) `method`

##### Summary

Generates a login identifier by hashing the provided raw data using SHA256.

##### Returns

A hexadecimal string representation of the SHA256 hash of the raw data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rawData | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw data to hash. Must not be null. |
| lengthLogin | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | string length of the login. Must be upper of 15 characters |
| salt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | third part for concatenate to rawData before generate login |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when rawData is null. |

##### Remarks

This method computes the SHA256 hash of the raw data and returns it as a hexadecimal string.

<a name='T-Bb-Extensions-ApikeyExtension'></a>
## ApikeyExtension `type`

##### Namespace

Bb.Extensions

##### Summary

Class containing extension methods for configuring API key authentication and REST client services in a web application.

<a name='M-Bb-Extensions-ApikeyExtension-AddRestClient-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddRestClient(services) `method`

##### Summary

Adds a REST client factory to the dependency injection container.

##### Returns

The updated [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to add the service to. Must not be null. |

##### Example

```C#
var services = new ServiceCollection();
services.AddRestClient();
var serviceProvider = services.BuildServiceProvider();
var restClientFactory = serviceProvider.GetRequiredService&lt;IRestClientFactory&gt;();
```

##### Remarks

This method registers the REST client factory and its configuration, allowing for the creation of REST clients with specific options.

<a name='M-Bb-Extensions-ApikeyExtension-AddTokenProvider-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddTokenProvider(services) `method`

##### Summary

Adds the token provider service to the dependency injection container.

##### Returns

The updated [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to add the service to. Must not be null. |

##### Example

```C#
var services = new ServiceCollection();
services.AddTokenProvider();
var serviceProvider = services.BuildServiceProvider();
```

##### Remarks

This method registers the necessary services for token management, including memory caching and token resolution.

<a name='M-Bb-Extensions-ApikeyExtension-WithApiKeyAuthentication-Microsoft-AspNetCore-Builder-WebApplication-'></a>
### WithApiKeyAuthentication(application) `method`

##### Summary

Adds API key authentication middleware to the application.

##### Returns

The configured [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| application | [Microsoft.AspNetCore.Builder.WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') | The [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') instance to configure. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown if the provided API key is invalid. |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if an unexpected error occurs during authentication. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.WithApiKeyAuthentication();
app.Run();
```

##### Remarks

This method adds middleware to validate API key authentication. If the API key is valid, it adds an authorization header to the request.

<a name='T-Bb-Loaders-Extensions-Assemblies'></a>
## Assemblies `type`

##### Namespace

Bb.Loaders.Extensions

##### Summary

Provides methods for managing assemblies in a web application.

<a name='P-Bb-Loaders-Extensions-Assemblies-AdditionalAssemblies'></a>
### AdditionalAssemblies `property`

##### Summary

Gets the additional assemblies to include for route discovery.

##### Returns

An enumerable of [Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly 'System.Reflection.Assembly') objects representing the additional assemblies.

##### Example

```C#
var assemblies = Assemblies.AdditionalAssemblies;
foreach (var assembly in assemblies)
{
    Console.WriteLine($"Assembly: {assembly.FullName}");
}
```

##### Remarks

This property returns all assemblies in the current application domain, excluding the executing assembly, that are relevant for route discovery.

<a name='P-Bb-Loaders-Extensions-Assemblies-WebAssemblies'></a>
### WebAssemblies `property`

##### Summary

Gets all assemblies that contain types with route attributes.

##### Returns

An enumerable of [Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly 'System.Reflection.Assembly') objects representing the assemblies containing route attributes.

##### Example

```C#
var webAssemblies = Assemblies.WebAssemblies;
foreach (var assembly in webAssemblies)
{
    Console.WriteLine($"Web Assembly: {assembly.FullName}");
}
```

##### Remarks

This property scans all assemblies in the current application domain and includes those that contain types decorated with route attributes.

<a name='M-Bb-Loaders-Extensions-Assemblies-ContainPage-System-Reflection-Assembly-'></a>
### ContainPage(assembly) `method`

##### Summary

Determines if the specified assembly contains types with route attributes.

##### Returns

`true` if the assembly contains types with route attributes; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assembly | [System.Reflection.Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly 'System.Reflection.Assembly') | The [Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly 'System.Reflection.Assembly') to check. Must not be null. |

##### Example

```C#
var assembly = Assembly.GetExecutingAssembly();
bool containsRoutes = assembly.ContainPage();
Console.WriteLine($"Contains routes: {containsRoutes}");
```

##### Remarks

This method checks if the assembly references "Microsoft.AspNetCore.Components" and contains types decorated with [RouteAttribute](#T-Microsoft-AspNetCore-Components-RouteAttribute 'Microsoft.AspNetCore.Components.RouteAttribute').

<a name='T-Bb-Models-BearerOption'></a>
## BearerOption `type`

##### Namespace

Bb.Models

##### Summary

Represents the options for configuring bearer token authentication.

<a name='P-Bb-Models-BearerOption-IssuerSigningKey'></a>
### IssuerSigningKey `property`

##### Summary

Gets or sets the issuer signing key for the token.

##### Example

```C#
var bearerOption = new BearerOption();
bearerOption.IssuerSigningKey = "my-signing-key";
Console.WriteLine($"Issuer Signing Key: {bearerOption.IssuerSigningKey}");
```

##### Remarks

This property specifies the key used to validate the token's signature.

<a name='P-Bb-Models-BearerOption-Name'></a>
### Name `property`

##### Summary

Gets or sets the name of the bearer option configuration.

##### Example

```C#
var bearerOption = new BearerOption();
bearerOption.Name = "MyBearerOption";
Console.WriteLine($"Bearer Option Name: {bearerOption.Name}");
```

##### Remarks

This property is used to identify the specific bearer option configuration in the application.

<a name='P-Bb-Models-BearerOption-ValidAudience'></a>
### ValidAudience `property`

##### Summary

Gets or sets the valid audience for the token.

##### Example

```C#
var bearerOption = new BearerOption();
bearerOption.ValidAudience = "https://myaudience.com";
Console.WriteLine($"Valid Audience: {bearerOption.ValidAudience}");
```

##### Remarks

This property specifies the expected audience of the token during validation.

<a name='P-Bb-Models-BearerOption-ValidIssuer'></a>
### ValidIssuer `property`

##### Summary

Gets or sets the valid issuer for the token.

##### Example

```C#
var bearerOption = new BearerOption();
bearerOption.ValidIssuer = "https://myissuer.com";
Console.WriteLine($"Valid Issuer: {bearerOption.ValidIssuer}");
```

##### Remarks

This property specifies the expected issuer of the token during validation.

<a name='P-Bb-Models-BearerOption-ValidateAudience'></a>
### ValidateAudience `property`

##### Summary

Gets or sets a value indicating whether the audience should be validated.

##### Example

```C#
var bearerOption = new BearerOption();
bearerOption.ValidateAudience = true;
Console.WriteLine($"Validate Audience: {bearerOption.ValidateAudience}");
```

##### Remarks

This property determines whether the token's audience is validated during authentication.

<a name='P-Bb-Models-BearerOption-ValidateIssuer'></a>
### ValidateIssuer `property`

##### Summary

Gets or sets a value indicating whether the issuer should be validated.

##### Example

```C#
var bearerOption = new BearerOption();
bearerOption.ValidateIssuer = true;
Console.WriteLine($"Validate Issuer: {bearerOption.ValidateIssuer}");
```

##### Remarks

This property determines whether the token's issuer is validated during authentication.

<a name='P-Bb-Models-BearerOption-ValidateIssuerSigningKey'></a>
### ValidateIssuerSigningKey `property`

##### Summary

Gets or sets a value indicating whether the issuer signing key should be validated.

##### Example

```C#
var bearerOption = new BearerOption();
bearerOption.ValidateIssuerSigningKey = true;
Console.WriteLine($"Validate Issuer Signing Key: {bearerOption.ValidateIssuerSigningKey}");
```

##### Remarks

This property determines whether the token's signing key is validated during authentication.

<a name='P-Bb-Models-BearerOption-ValidateLifetime'></a>
### ValidateLifetime `property`

##### Summary

Gets or sets a value indicating whether the token's lifetime should be validated.

##### Example

```C#
var bearerOption = new BearerOption();
bearerOption.ValidateLifetime = true;
Console.WriteLine($"Validate Lifetime: {bearerOption.ValidateLifetime}");
```

##### Remarks

This property determines whether the token's expiration time is validated during authentication.

<a name='T-Bb-Loaders-BlazorBuilderInitializer'></a>
## BlazorBuilderInitializer `type`

##### Namespace

Bb.Loaders

##### Summary

Initializes the web application builder for Blazor components.

<a name='M-Bb-Loaders-BlazorBuilderInitializer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [BlazorBuilderInitializer](#T-Bb-Loaders-BlazorBuilderInitializer 'Bb.Loaders.BlazorBuilderInitializer') class.

##### Parameters

This constructor has no parameters.

<a name='P-Bb-Loaders-BlazorBuilderInitializer-Initialize'></a>
### Initialize `property`

##### Summary

Gets or sets a value indicating whether Blazor initialization is enabled.

##### Example

```C#
var initializer = new BlazorBuilderInitializer();
Console.WriteLine($"Initialize Blazor: {initializer.Initialize}");
```

##### Remarks

This property is injected by the IoC container and determines whether Blazor initialization should be performed.

<a name='M-Bb-Loaders-BlazorBuilderInitializer-CanExecute-System-Object-'></a>
### CanExecute(context) `method`

##### Summary

Determines whether the builder can execute in the given context.

##### Returns

`true` if the builder can execute in the given context; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The context in which the builder is being executed. Must not be null. |

##### Example

```C#
var initializer = new BlazorBuilderInitializer();
bool canExecute = initializer.CanExecute(context);
Console.WriteLine($"Can execute: {canExecute}");
```

##### Remarks

This method checks if the builder is allowed to execute based on the provided context.

<a name='M-Bb-Loaders-BlazorBuilderInitializer-Execute-Microsoft-AspNetCore-Builder-WebApplicationBuilder-'></a>
### Execute(builder) `method`

##### Summary

Executes the builder to configure the web application builder for Blazor.

##### Returns

`null` after configuring the builder.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') | The [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance to configure. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var initializer = new BlazorBuilderInitializer();
initializer.Execute(builder);
var app = builder.Build();
app.Run();
```

##### Remarks

This method configures the web application builder by adding Razor components, interactive server components, Razor pages, and server-side Blazor support.

<a name='T-Bb-Models-Certificate'></a>
## Certificate `type`

##### Namespace

Bb.Models

##### Summary

Represents a certificate used for authentication or encryption.

<a name='P-Bb-Models-Certificate-Password'></a>
### Password `property`

##### Summary

Gets or sets the password for the certificate.

##### Example

```C#
var certificate = new Certificate();
certificate.Password = "my-secure-password";
Console.WriteLine($"Certificate Password: {certificate.Password}");
```

##### Remarks

This property is used to provide the password required to load the certificate from the specified source.

<a name='P-Bb-Models-Certificate-SourcePath'></a>
### SourcePath `property`

##### Summary

Gets or sets the source path of the certificate.

##### Example

```C#
var certificate = new Certificate();
certificate.SourcePath = "path/to/certificate.pfx";
Console.WriteLine($"Certificate Source Path: {certificate.SourcePath}");
```

##### Remarks

This property specifies the location of the certificate file, which can be used for authentication or encryption purposes.

<a name='P-Bb-Models-Certificate-TypeSource'></a>
### TypeSource `property`

##### Summary

Gets or sets the type of the certificate source.

##### Example

```C#
var certificate = new Certificate();
certificate.TypeSource = SourceCertificate.File;
Console.WriteLine($"Certificate Source Type: {certificate.TypeSource}");
```

##### Remarks

This property indicates whether the certificate is loaded from a file, a store, or another source.

<a name='T-Bb-Services-CertificateHelpers'></a>
## CertificateHelpers `type`

##### Namespace

Bb.Services

##### Summary

Provides helper methods for managing X.509 certificates, including loading, saving, creating, and storing certificates.

<a name='M-Bb-Services-CertificateHelpers-CreateSelfSignedCertificate-System-String,System-String-'></a>
### CreateSelfSignedCertificate(subjectName,password) `method`

##### Summary

Creates a self-signed certificate.

##### Returns

The created [X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| subjectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subject name for the certificate. Must not be null or empty. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password to protect the certificate. Must not be null or empty. |

##### Example

```C#
var certificate = CertificateHelpers.CreateSelfSignedCertificate("MyCertificate", "password");
```

##### Remarks

This method generates a self-signed certificate with a validity of 5 years.

<a name='M-Bb-Services-CertificateHelpers-LoadCertificateFromFile-System-IO-FileInfo,System-String-'></a>
### LoadCertificateFromFile(certPath,certPassword) `method`

##### Summary

Loads a certificate from a file.

##### Returns

The loaded [X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| certPath | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file path of the certificate. Must not be null. |
| certPassword | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password for the certificate. Must not be null or empty. |

##### Example

```C#
var certificate = CertificateHelpers.LoadCertificateFromFile(new FileInfo("path/to/cert.pfx"), "password");
```

##### Remarks

This method loads a certificate from the specified file path using the provided password.

<a name='M-Bb-Services-CertificateHelpers-LoadCertificateFromStore-System-String-'></a>
### LoadCertificateFromStore(subjectName) `method`

##### Summary

Loads a certificate from the store by subject name.

##### Returns

The loaded [X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| subjectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subject name of the certificate. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.PlatformNotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.PlatformNotSupportedException 'System.PlatformNotSupportedException') | Thrown if the current platform is not supported. |

##### Example

```C#
var certificate = CertificateHelpers.LoadCertificateFromStore("MyCertificate");
```

##### Remarks

This method retrieves a certificate from the certificate store based on the subject name.

<a name='M-Bb-Services-CertificateHelpers-SaveCertificateToFile-System-Security-Cryptography-X509Certificates-X509Certificate2,System-String,System-String-'></a>
### SaveCertificateToFile(certificate,filePath,password) `method`

##### Summary

Saves a certificate to a file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| certificate | [System.Security.Cryptography.X509Certificates.X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') | The certificate to save. Must not be null. |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file path where the certificate will be saved. Must not be null or empty. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password to protect the certificate. Must not be null or empty. |

##### Example

```C#
CertificateHelpers.SaveCertificateToFile(certificate, "path/to/cert.pfx", "password");
```

##### Remarks

This method exports the certificate to a file in PFX format.

<a name='M-Bb-Services-CertificateHelpers-StoreCertificate-System-Security-Cryptography-X509Certificates-X509Certificate2-'></a>
### StoreCertificate(certificate) `method`

##### Summary

Stores a certificate in the certificate store.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| certificate | [System.Security.Cryptography.X509Certificates.X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') | The certificate to store. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.PlatformNotSupportedException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.PlatformNotSupportedException 'System.PlatformNotSupportedException') | Thrown if the current platform is not supported for storing certificates. |

##### Example

```C#
CertificateHelpers.StoreCertificate(certificate);
```

##### Remarks

This method adds the certificate to the appropriate certificate store based on the platform.

<a name='T-Bb-Exceptions-CertificateNotFoundException'></a>
## CertificateNotFoundException `type`

##### Namespace

Bb.Exceptions

##### Summary

Represents an exception that is thrown when a required certificate cannot be found.

##### Remarks

This exception is used to indicate issues related to missing certificates in the application.

<a name='M-Bb-Exceptions-CertificateNotFoundException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [CertificateNotFoundException](#T-Bb-Exceptions-CertificateNotFoundException 'Bb.Exceptions.CertificateNotFoundException') class.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Exceptions-CertificateNotFoundException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the [CertificateNotFoundException](#T-Bb-Exceptions-CertificateNotFoundException 'Bb.Exceptions.CertificateNotFoundException') class with a specified error message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |

##### Example

```C#
throw new CertificateNotFoundException("Certificate with ID 1234 not found.");
```

##### Remarks

Use this constructor to provide a custom error message when the exception is thrown.

<a name='M-Bb-Exceptions-CertificateNotFoundException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,inner) `constructor`

##### Summary

Initializes a new instance of the [CertificateNotFoundException](#T-Bb-Exceptions-CertificateNotFoundException 'Bb.Exceptions.CertificateNotFoundException') class with a specified error message and a reference to the inner exception that is the cause of this exception.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |
| inner | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `message` is null. |

##### Example

```C#
try
{
    // Some operation that may fail
}
catch (Exception ex)
{
    throw new CertificateNotFoundException("Certificate operation failed.", ex);
}
```

##### Remarks

Use this constructor to provide additional context about the error by including an inner exception.

<a name='T-Bb-Models-ClientOptionConfiguration'></a>
## ClientOptionConfiguration `type`

##### Namespace

Bb.Models

##### Summary

Represents a client option configuration for REST clients.

<a name='P-Bb-Models-ClientOptionConfiguration-Name'></a>
### Name `property`

##### Summary

Gets or sets the name of the client option configuration.

##### Example

```C#
var clientOption = new ClientOptionConfiguration();
clientOption.Name = "MyClientOption";
Console.WriteLine($"Client Option Name: {clientOption.Name}");
```

##### Remarks

This property is used to identify the specific client option configuration in the application.

<a name='T-Bb-Extensions-ConfigurationExtension'></a>
## ConfigurationExtension `type`

##### Namespace

Bb.Extensions

##### Summary

Extension methods for configuring types in a web application.

<a name='M-Bb-Extensions-ConfigurationExtension-LoadConfiguration-Microsoft-AspNetCore-Builder-WebApplicationBuilder,System-Func{System-IO-FileInfo,System-Boolean},System-String-'></a>
### LoadConfiguration(builder,filter,pattern) `method`

##### Summary

Load configuration and discover all methods for loading configuration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') | [IConfigurationBuilder](#T-Microsoft-Extensions-Configuration-IConfigurationBuilder 'Microsoft.Extensions.Configuration.IConfigurationBuilder') |
| filter | [System.Func{System.IO.FileInfo,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.IO.FileInfo,System.Boolean}') | filter to validate files |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | pattern globing |

##### Example

```Csharp
var builder = WebApplication.CreateBuilder(args).LoadConfiguration();
```

If you want adding configuration, append a new class with the attribute [ExposeClassAttribute](#T-Bb-ComponentModel-Attributes-ExposeClassAttribute 'Bb.ComponentModel.Attributes.ExposeClassAttribute') and implement 
the interface [IInjectBuilder\`1](#T-Bb-ComponentModel-IInjectBuilder`1 'Bb.ComponentModel.IInjectBuilder`1')

```Csharp
[ExposeClass(ConstantsCore.Initialization, ExposedType = typeof(IInjectBuilder&lt;IConfigurationBuilder&gt;), LifeCycle = IocScopeEnum.Transiant)]
public class ConfigurationInitializer : IInjectBuilder&lt;IConfigurationBuilder&gt;
{
    public string FriendlyName =&gt; typeof(ConfigurationInitializer).Name;
    public Type Type =&gt; typeof(ConfigurationInitializer);
    public object Execute(object context)
    {
        return Execute((IConfigurationBuilder) context);
    }
    
    public bool CanExecute(object context)
    {
        return CanExecute((IConfigurationBuilder)context);
    }
    public bool CanExecute(IConfigurationBuilder context)
    {
        var builtConfig = context.Build();
        var canExecute = builtConfig["Initializer:" + FriendlyName];
        if (canExecute != null)
            if (!Convert.ToBoolean(canExecute))
                return false;
        // place your code here
        return true;
    }
    public object Execute(IConfigurationBuilder context)
    {
        // place your code here
        return context;
    }
    
}
```

If you want deactivate a configuration loader, you can add a key in your configuration file like appsettings.json

```json
"Initializer": {
  "ConfigurationGitBuilderInitializer": true,
  "ConfigurationVaultBuilderInitializer": true,
},
```

<a name='M-Bb-Extensions-ConfigurationExtension-LoadConfiguration-Microsoft-Extensions-Configuration-IConfigurationBuilder,System-Func{System-IO-FileInfo,System-Boolean},System-String-'></a>
### LoadConfiguration(builder,filter,pattern) `method`

##### Summary

Load configurations file, secret keys, environment variables, ...

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.Extensions.Configuration.IConfigurationBuilder](#T-Microsoft-Extensions-Configuration-IConfigurationBuilder 'Microsoft.Extensions.Configuration.IConfigurationBuilder') | application builder |
| filter | [System.Func{System.IO.FileInfo,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.IO.FileInfo,System.Boolean}') | filter to validate files |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | pattern globing |

<a name='T-Bb-Services-ConfigurationFile'></a>
## ConfigurationFile `type`

##### Namespace

Bb.Services

##### Summary

Represents a configuration file with its associated properties.

##### Remarks

This structure holds information about a configuration file, including its name, file information, and associated environment.

<a name='F-Bb-Services-ConfigurationFile-Environment'></a>
### Environment `constants`

##### Summary

Gets or sets the environment associated with the configuration file.

##### Remarks

The environment is extracted from the file's name, if available.

<a name='F-Bb-Services-ConfigurationFile-FileInfo'></a>
### FileInfo `constants`

##### Summary

Gets or sets the file information of the configuration file.

##### Remarks

This property provides access to the file's metadata and path.

<a name='F-Bb-Services-ConfigurationFile-Name'></a>
### Name `constants`

##### Summary

Gets or sets the name of the configuration file.

##### Remarks

The name is computed based on the file's base name.

<a name='T-Bb-Loaders-ConfigurationLoader'></a>
## ConfigurationLoader `type`

##### Namespace

Bb.Loaders

##### Summary

Download configuration form git repository and load the configuration

<a name='T-Bb-Services-ConfigurationLoader'></a>
## ConfigurationLoader `type`

##### Namespace

Bb.Services

##### Summary

Provides functionality to load and manage configuration files grouped by their names.

##### Remarks

This class allows loading configuration files from specified directories, filtering them based on patterns and conditions, 
and grouping them by their names for easy access.

<a name='M-Bb-Loaders-ConfigurationLoader-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ConfigurationLoader](#T-Bb-Loaders-ConfigurationLoader 'Bb.Loaders.ConfigurationLoader') class.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Services-ConfigurationLoader-#ctor-System-String,System-Func{System-IO-FileInfo,System-Boolean}-'></a>
### #ctor(pattern,filter) `constructor`

##### Summary

Initializes a new instance of the [ConfigurationLoader](#T-Bb-Services-ConfigurationLoader 'Bb.Services.ConfigurationLoader') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file pattern to search for. Defaults to "*.json" if null or empty. |
| filter | [System.Func{System.IO.FileInfo,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.IO.FileInfo,System.Boolean}') | A filter function to apply to files. Can be null. |

##### Example

```C#
var loader = new ConfigurationLoader("*.config", file =&gt; file.Length &gt; 0);
```

##### Remarks

This constructor sets up the loader with a specified file pattern and optional filter for selecting files.

<a name='P-Bb-Loaders-ConfigurationLoader-Configuration'></a>
### Configuration `property`

##### Summary

Gets or sets the application configuration.

##### Example

```C#
var loader = new ConfigurationLoader();
var config = loader.Configuration;
Console.WriteLine($"Configuration: {config}");
```

##### Remarks

This property is injected by the IoC container and provides access to the application's configuration settings.

<a name='P-Bb-Loaders-ConfigurationLoader-ConfigurationPath'></a>
### ConfigurationPath `property`

##### Summary

Gets or sets the configuration path dictionary used for Git repository settings.

##### Example

```C#
var loader = new ConfigurationLoader();
var configPath = loader.ConfigurationPath;
Console.WriteLine($"Git URL: {configPath["url"]}");
```

##### Remarks

This property is injected by the IoC container and contains keys such as "url", "user", "email", "branch", and "folder" for configuring the Git repository.

<a name='M-Bb-Loaders-ConfigurationLoader-Execute-Microsoft-AspNetCore-Builder-WebApplicationBuilder-'></a>
### Execute(context) `method`

##### Summary

Executes the configuration loader to download and load configurations from a Git repository.

##### Returns

`null` after executing the configuration loader.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') | The [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance to configure. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var loader = new ConfigurationLoader();
loader.Execute(builder);
var app = builder.Build();
app.Run();
```

##### Remarks

This method downloads configuration files from a Git repository based on the provided configuration path and loads them into the application context.

<a name='M-Bb-Services-ConfigurationLoader-AddFolders-System-String[]-'></a>
### AddFolders(paths) `method`

##### Summary

Adds folders to the configuration loader and loads matching files.

##### Returns

The updated [ConfigurationLoader](#T-Bb-Services-ConfigurationLoader 'Bb.Services.ConfigurationLoader') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paths | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | An array of folder paths to add. Can be null. |

##### Example

```C#
var loader = new ConfigurationLoader("*.json");
loader.AddFolders("C:\\Configs", "D:\\MoreConfigs");
```

##### Remarks

This method scans the specified folders for configuration files matching the loader's pattern and filter, and adds them to the internal collection.

<a name='M-Bb-Services-ConfigurationLoader-ComputeEnvironmentName-System-String-'></a>
### ComputeEnvironmentName(name) `method`

##### Summary

Computes the environment name from a configuration file's filename.

##### Returns

The environment name if present; otherwise, `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The filename to process. Must not be null or empty. |

##### Remarks

This method extracts the environment name from the second segment of the filename, if available.

<a name='M-Bb-Services-ConfigurationLoader-ComputeName-System-String-'></a>
### ComputeName(name) `method`

##### Summary

Computes the name of a configuration file based on its filename.

##### Returns

The computed name of the file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The filename to process. Must not be null or empty. |

##### Remarks

This method extracts the base name of the file by splitting it on the '.' character.

<a name='M-Bb-Services-ConfigurationLoader-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through the grouped configuration files.

##### Returns

An enumerator of [IGrouping\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IGrouping`2 'System.Linq.IGrouping`2') where TKey is a string and TElement is [ConfigurationFile](#T-Bb-Services-ConfigurationFile 'Bb.Services.ConfigurationFile').

##### Parameters

This method has no parameters.

##### Example

```C#
var loader = new ConfigurationLoader("*.json");
foreach (var group in loader)
{
    Console.WriteLine($"Group: {group.Key}");
    foreach (var file in group)
    {
        Console.WriteLine($"File: {file.FileInfo.FullName}");
    }
}
```

##### Remarks

This method groups the configuration files by their names and provides an enumerator for iteration.

<a name='M-Bb-Services-ConfigurationLoader-GetFiles-System-Func{System-IO-FileInfo,System-Boolean},System-IO-DirectoryInfo,System-String-'></a>
### GetFiles(filter,item,pattern) `method`

##### Summary

Retrieves a list of configuration files from the specified directory that match the given pattern and filter.

##### Returns

A list of [ConfigurationFile](#T-Bb-Services-ConfigurationFile 'Bb.Services.ConfigurationFile') objects that match the criteria.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.Func{System.IO.FileInfo,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.IO.FileInfo,System.Boolean}') | A filter function to apply to files. Can be null. |
| item | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The directory to search for files. Must not be null. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file pattern to search for. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the directory or pattern is null. |

##### Remarks

This method scans the specified directory for files matching the given pattern and filter, and includes only files relevant to the current environment.

<a name='T-Bb-Extensions-HttpContextExtension'></a>
## HttpContextExtension `type`

##### Namespace

Bb.Extensions

##### Summary

Extension methods for [HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') to facilitate setting HTTP responses.

<a name='P-Bb-Extensions-HttpContextExtension-IsDebug'></a>
### IsDebug `property`

##### Summary

Indicates whether the application is running in debug mode.

##### Remarks

This property checks the "ASPNETCORE_ENVIRONMENT" environment variable to determine if the application is in the "Development" environment.

<a name='M-Bb-Extensions-HttpContextExtension-SetResponse-Microsoft-AspNetCore-Http-HttpContext,System-Object-'></a>
### SetResponse(context,data) `method`

##### Summary

Sets the HTTP response with the specified data serialized as JSON.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | The [HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') to set the response for. Must not be null. |
| data | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to serialize and include in the response. Must not be null. |

##### Example

```C#
var context = new DefaultHttpContext();
var data = new { Message = "Hello, World!" };
await context.SetResponse(data);
```

##### Remarks

This method serializes the provided data into JSON format and sets it as the HTTP response content.

<a name='M-Bb-Extensions-HttpContextExtension-SetResponse-Microsoft-AspNetCore-Http-HttpContext,RestSharp-ContentType,System-String-'></a>
### SetResponse(context,contentType,data) `method`

##### Summary

Sets the HTTP response with the specified content type and data.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | The [HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') to set the response for. Must not be null. |
| contentType | [RestSharp.ContentType](#T-RestSharp-ContentType 'RestSharp.ContentType') | The content type of the response. Must not be null or empty. |
| data | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string data to include in the response. Must not be null. |

##### Example

```C#
var context = new DefaultHttpContext();
await context.SetResponse(ContentTypes.ApplicationJson, "{\"Message\":\"Hello, World!\"}");
```

##### Remarks

This method sets the HTTP response content type and writes the provided string data to the response.

<a name='T-Bb-Middleware-HttpInfoLoggerMiddleware'></a>
## HttpInfoLoggerMiddleware `type`

##### Namespace

Bb.Middleware

<a name='M-Bb-Middleware-HttpInfoLoggerMiddleware-#ctor-Microsoft-AspNetCore-Http-RequestDelegate,Microsoft-Extensions-Logging-ILogger{Bb-Middleware-HttpInfoLoggerMiddleware}-'></a>
### #ctor(next,logger) `constructor`

##### Summary

Initializes a new instance of the [HttpInfoLoggerMiddleware](#T-Bb-Middleware-HttpInfoLoggerMiddleware 'Bb.Middleware.HttpInfoLoggerMiddleware') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| next | [Microsoft.AspNetCore.Http.RequestDelegate](#T-Microsoft-AspNetCore-Http-RequestDelegate 'Microsoft.AspNetCore.Http.RequestDelegate') | The next middleware in the pipeline. Must not be null. |
| logger | [Microsoft.Extensions.Logging.ILogger{Bb.Middleware.HttpInfoLoggerMiddleware}](#T-Microsoft-Extensions-Logging-ILogger{Bb-Middleware-HttpInfoLoggerMiddleware} 'Microsoft.Extensions.Logging.ILogger{Bb.Middleware.HttpInfoLoggerMiddleware}') | The [ILogger\`1](#T-Microsoft-Extensions-Logging-ILogger`1 'Microsoft.Extensions.Logging.ILogger`1') instance used for logging. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `next` or `logger` is null. |

##### Remarks

This constructor sets up the middleware to log HTTP request and response details.

<a name='M-Bb-Middleware-HttpInfoLoggerMiddleware-InvokeAsync-Microsoft-AspNetCore-Http-HttpContext-'></a>
### InvokeAsync(context) `method`

##### Summary

Processes an HTTP request and logs its details, along with the response details.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') that represents the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | The [HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') representing the current HTTP request. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseMiddleware&lt;HttpInfoLoggerMiddleware&gt;();
app.Run();
```

##### Remarks

This method logs the HTTP request and response details, including headers, cookies, and form data, if available.

<a name='M-Bb-Middleware-HttpInfoLoggerMiddleware-LogRequest-Microsoft-AspNetCore-Http-HttpContext-'></a>
### LogRequest(context) `method`

##### Summary

Logs the details of the HTTP request.

##### Returns

A [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') containing the logged request details.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | The [HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') representing the current HTTP request. Must not be null. |

##### Remarks

This method captures details such as the HTTP method, URL, headers, cookies, and form data.

<a name='M-Bb-Middleware-HttpInfoLoggerMiddleware-LogResponse-Microsoft-AspNetCore-Http-HttpContext-'></a>
### LogResponse(context) `method`

##### Summary

Logs the details of the HTTP response.

##### Returns

A [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') containing the logged response details.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | The [HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') representing the current HTTP response. Must not be null. |

##### Remarks

This method captures details such as the status code and response headers.

<a name='M-Bb-Middleware-HttpInfoLoggerMiddleware-TraceRequest-Microsoft-AspNetCore-Http-HttpRequest-'></a>
### TraceRequest(r) `method`

##### Summary

Captures the details of an HTTP request.

##### Returns

A [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') containing the captured request details.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| r | [Microsoft.AspNetCore.Http.HttpRequest](#T-Microsoft-AspNetCore-Http-HttpRequest 'Microsoft.AspNetCore.Http.HttpRequest') | The [HttpRequest](#T-Microsoft-AspNetCore-Http-HttpRequest 'Microsoft.AspNetCore.Http.HttpRequest') to capture details from. Must not be null. |

##### Remarks

This method captures details such as the HTTP method, URL, headers, cookies, and form data.

<a name='M-Bb-Middleware-HttpInfoLoggerMiddleware-TraceResponse-Microsoft-AspNetCore-Http-HttpResponse-'></a>
### TraceResponse(r) `method`

##### Summary

Captures the details of an HTTP response.

##### Returns

A [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') containing the captured response details.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| r | [Microsoft.AspNetCore.Http.HttpResponse](#T-Microsoft-AspNetCore-Http-HttpResponse 'Microsoft.AspNetCore.Http.HttpResponse') | The [HttpResponse](#T-Microsoft-AspNetCore-Http-HttpResponse 'Microsoft.AspNetCore.Http.HttpResponse') to capture details from. Must not be null. |

##### Remarks

This method captures details such as the status code and response headers.

<a name='M-Bb-Middleware-HttpInfoLoggerMiddleware-TryToGetForm-Microsoft-AspNetCore-Http-HttpRequest-'></a>
### TryToGetForm(r) `method`

##### Summary

Attempts to retrieve the form data from an HTTP request.

##### Returns

An [IFormCollection](#T-Microsoft-AspNetCore-Http-IFormCollection 'Microsoft.AspNetCore.Http.IFormCollection') containing the form data, or `null` if the form data is not available.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| r | [Microsoft.AspNetCore.Http.HttpRequest](#T-Microsoft-AspNetCore-Http-HttpRequest 'Microsoft.AspNetCore.Http.HttpRequest') | The [HttpRequest](#T-Microsoft-AspNetCore-Http-HttpRequest 'Microsoft.AspNetCore.Http.HttpRequest') to retrieve form data from. Must not be null. |

##### Remarks

This method safely attempts to retrieve form data from the request, handling any exceptions that may occur.

<a name='T-Bb-Extensions-HttpInfoLoggerMiddlewareExtensions'></a>
## HttpInfoLoggerMiddlewareExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Extension methods for configuring HTTP information logging middleware in a web application.

<a name='M-Bb-Extensions-HttpInfoLoggerMiddlewareExtensions-UseHttpExceptionInterceptor``1-``0-'></a>
### UseHttpExceptionInterceptor\`\`1(builder) `method`

##### Summary

Adds the HTTP exception interceptor middleware to the application's request pipeline.

##### Returns

The configured [IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [\`\`0](#T-``0 '``0') | The application builder to configure. Must not be null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the application builder, which must implement [IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder'). |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpExceptionInterceptor();
app.Run();
```

##### Remarks

This middleware intercepts HTTP requests and responses to log exceptions and other relevant information.

<a name='M-Bb-Extensions-HttpInfoLoggerMiddlewareExtensions-UseHttpInfoLogger``1-``0-'></a>
### UseHttpInfoLogger\`\`1(builder) `method`

##### Summary

Adds the HTTP information logger middleware to the application's request pipeline.

##### Returns

The configured [IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [\`\`0](#T-``0 '``0') | The application builder to configure. Must not be null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the application builder, which must implement [IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder'). |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpInfoLogger();
app.Run();
```

##### Remarks

This middleware logs HTTP request and response information for debugging and monitoring purposes.

<a name='T-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator'></a>
## IRequestResponseLogModelCreator `type`

##### Namespace

Bb.Middleware.EntryFullLogger

##### Summary

Interface for creating a log model that contains details of HTTP requests and responses.

<a name='P-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator-LogModel'></a>
### LogModel `property`

##### Summary

Gets the log model containing the details of the request and response.

##### Example

```C#
var logCreator = new MyRequestResponseLogModelCreator();
var logModel = logCreator.LogModel;
Console.WriteLine($"Request: {logModel.Request}, Response: {logModel.Response}");
```

##### Remarks

This property provides access to the log model that encapsulates the details of the HTTP request and response.

<a name='M-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator-LogString'></a>
### LogString() `method`

##### Summary

Generates a string representation of the log model.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the serialized log details.

##### Parameters

This method has no parameters.

##### Example

```C#
var logCreator = new MyRequestResponseLogModelCreator();
string logString = logCreator.LogString();
Console.WriteLine($"Log: {logString}");
```

##### Remarks

This method converts the log model into a string format for logging or debugging purposes.

<a name='T-Bb-Middleware-EntryFullLogger-IRequestResponseLogger'></a>
## IRequestResponseLogger `type`

##### Namespace

Bb.Middleware.EntryFullLogger

##### Summary

Interface for logging HTTP request and response details.

<a name='M-Bb-Middleware-EntryFullLogger-IRequestResponseLogger-Log-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator-'></a>
### Log(logCreator) `method`

##### Summary

Logs the request and response details using the provided log model creator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logCreator | [Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator](#T-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator 'Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator') | An instance of [IRequestResponseLogModelCreator](#T-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator 'Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator') used to create the log model. Must not be null. |

##### Example

```C#
var logger = new MyRequestResponseLogger();
var logCreator = new MyLogModelCreator();
logger.Log(logCreator);
```

##### Remarks

This method captures and logs the details of HTTP requests and responses by utilizing the provided log model creator.

<a name='T-Bb-Interfaces-IVaultSecretResolver'></a>
## IVaultSecretResolver `type`

##### Namespace

Bb.Interfaces

##### Summary

Interface for resolving and retrieving secrets from a vault or secure storage.

<a name='M-Bb-Interfaces-IVaultSecretResolver-GetSecret-System-String[]-'></a>
### GetSecret(path) `method`

##### Summary

Retrieves a secret value based on the provided names.

##### Returns

The secret value as a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | An array of strings representing the names or keys to locate the secret. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the provided `path` is null or empty. |

##### Example

```C#
IVaultSecretResolver resolver = new MyVaultSecretResolver();
string secret = resolver.GetSecret("Database", "ConnectionString");
Console.WriteLine($"Retrieved secret: {secret}");
```

##### Remarks

This method resolves and retrieves a secret value from a vault or secure storage using the provided names or keys.

<a name='T-Bb-Extensions-InitializerExtension'></a>
## InitializerExtension `type`

##### Namespace

Bb.Extensions

##### Summary

Provides extension methods for initializing and configuring the application.

<a name='M-Bb-Extensions-InitializerExtension-AppendFoldersToDiscovers-System-String[],Bb-Models-StartupConfiguration-'></a>
### AppendFoldersToDiscovers(paths,startupConfiguration) `method`

##### Summary

Appends folders to the assembly discovery process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paths | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | An array of folder paths to add. Can be null. |
| startupConfiguration | [Bb.Models.StartupConfiguration](#T-Bb-Models-StartupConfiguration 'Bb.Models.StartupConfiguration') | The startup configuration containing additional folders. Must not be null. |

##### Remarks

This method adds the specified paths and folders from the startup configuration to the assembly directory resolver.

<a name='M-Bb-Extensions-InitializerExtension-Initialize-Microsoft-AspNetCore-Builder-WebApplicationBuilder-'></a>
### Initialize(self) `method`

##### Summary

Initializes the application builder with custom configurations.

##### Returns

The configured [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') | The [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance to initialize. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
builder.Initialize();
var app = builder.Build();
app.Run();
```

##### Remarks

This method sets up schema generation, auto-configuration, and trace configuration for the application builder.

<a name='M-Bb-Extensions-InitializerExtension-Initialize-Microsoft-AspNetCore-Builder-WebApplication-'></a>
### Initialize(self) `method`

##### Summary

Initializes the web application with custom configurations.

##### Returns

The configured [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Microsoft.AspNetCore.Builder.WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') | The [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') instance to initialize. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Initialize();
app.Run();
```

##### Remarks

This method sets up auto-configuration for the web application.

<a name='M-Bb-Extensions-InitializerExtension-LoadAssemblies-System-String[]-'></a>
### LoadAssemblies(paths) `method`

##### Summary

Loads assemblies and packages based on the provided paths and configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paths | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | An array of folder paths to search for assemblies. Can be null. |

##### Example

```C#
InitializerExtension.LoadAssemblies("C:\\MyAssemblies", "D:\\MoreAssemblies");
```

##### Remarks

This method resolves the startup configuration, appends folders to the discovery process, and loads assemblies and packages.

<a name='M-Bb-Extensions-InitializerExtension-LoadAssemblies-Bb-Models-StartupConfiguration-'></a>
### LoadAssemblies(startupConfiguration) `method`

##### Summary

Loads assemblies specified in the startup configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| startupConfiguration | [Bb.Models.StartupConfiguration](#T-Bb-Models-StartupConfiguration 'Bb.Models.StartupConfiguration') | The startup configuration containing assembly names. Must not be null. |

##### Remarks

This method loads assemblies by their names as specified in the startup configuration.

<a name='M-Bb-Extensions-InitializerExtension-LoadPackages-Bb-Models-StartupConfiguration-'></a>
### LoadPackages(startupConfiguration) `method`

##### Summary

Loads packages specified in the startup configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| startupConfiguration | [Bb.Models.StartupConfiguration](#T-Bb-Models-StartupConfiguration 'Bb.Models.StartupConfiguration') | The startup configuration containing package information. Must not be null. |

##### Remarks

This method resolves and loads packages using the package manager and ensures that all required assemblies are loaded.

<a name='M-Bb-Extensions-InitializerExtension-ResolveConfiguration'></a>
### ResolveConfiguration() `method`

##### Summary

Resolves the startup configuration from the global configuration.

##### Returns

A [StartupConfiguration](#T-Bb-Models-StartupConfiguration 'Bb.Models.StartupConfiguration') object containing the resolved configuration.

##### Parameters

This method has no parameters.

##### Example

```C#
var config = InitializerExtension.ResolveConfiguration();
Console.WriteLine($"Configuration loaded: {config}");
```

##### Remarks

This method retrieves the startup configuration document from the global configuration or creates a new one if not found.

<a name='T-Bb-Extensions-IocAutoDiscoverExtension'></a>
## IocAutoDiscoverExtension `type`

##### Namespace

Bb.Extensions

##### Summary

Provides extension methods for discovering and registering types exposed by attributes in the context of dependency injection.

<a name='M-Bb-Extensions-IocAutoDiscoverExtension-BindConfiguration-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Type,Microsoft-Extensions-Configuration-IConfiguration-'></a>
### BindConfiguration(self,type,configuration) `method`

##### Summary

Binds a configuration section to a specified options type.

##### Returns

The updated [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to bind the configuration to. Must not be null. |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type of the options to bind. Must not be null. |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The application configuration. Must not be null. |

##### Example

```C#
var services = new ServiceCollection();
services.BindConfiguration(typeof(MyOptions), configuration);
```

##### Remarks

This method binds a configuration section to a specified options type and validates the data annotations.

<a name='M-Bb-Extensions-IocAutoDiscoverExtension-DiscoverTypeExposedByAttribute-System-String,System-Action{System-Type}-'></a>
### DiscoverTypeExposedByAttribute(contextKey,action) `method`

##### Summary

Discovers types exposed by attributes in the specified context and applies an action to each type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| contextKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The context key used to filter exposed types. Must not be null. |
| action | [System.Action{System.Type}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Type}') | An optional action to apply to each discovered type. Can be null. |

##### Example

```C#
"MyContext".DiscoverTypeExposedByAttribute(type =&gt; Console.WriteLine(type.Name));
```

##### Remarks

This method retrieves all types exposed by attributes in the specified context and optionally applies a user-defined action to each type.

<a name='M-Bb-Extensions-IocAutoDiscoverExtension-GetExposedTypes-System-String-'></a>
### GetExposedTypes(contextName) `method`

##### Summary

Gets the exposed types in loaded assemblies filtered by a context name.

##### Returns

An enumerable of [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') objects representing the exposed types.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| contextName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the context to filter exposed types. Must not be null. |

##### Example

```C#
var types = IocAutoDiscoverExtension.GetExposedTypes("MyContext");
foreach (var type in types)
{
    Console.WriteLine(type.Name);
}
```

##### Remarks

This method retrieves all types in loaded assemblies that are exposed by the [ExposeClassAttribute](#T-Bb-ComponentModel-Attributes-ExposeClassAttribute 'Bb.ComponentModel.Attributes.ExposeClassAttribute') and match the specified context name.

<a name='M-Bb-Extensions-IocAutoDiscoverExtension-GetExposedTypes-System-Func{Bb-ComponentModel-Attributes-ExposeClassAttribute,System-Boolean}-'></a>
### GetExposedTypes(filter) `method`

##### Summary

Gets the exposed types in loaded assemblies filtered by a custom filter function.

##### Returns

An enumerable of [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') objects representing the exposed types.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.Func{Bb.ComponentModel.Attributes.ExposeClassAttribute,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Bb.ComponentModel.Attributes.ExposeClassAttribute,System.Boolean}') | A filter function to apply to the [ExposeClassAttribute](#T-Bb-ComponentModel-Attributes-ExposeClassAttribute 'Bb.ComponentModel.Attributes.ExposeClassAttribute'). Must not be null. |

##### Example

```C#
var types = IocAutoDiscoverExtension.GetExposedTypes(attr =&gt; attr.Context == "MyContext");
foreach (var type in types)
{
    Console.WriteLine(type.Name);
}
```

##### Remarks

This method retrieves all types in loaded assemblies that are exposed by the [ExposeClassAttribute](#T-Bb-ComponentModel-Attributes-ExposeClassAttribute 'Bb.ComponentModel.Attributes.ExposeClassAttribute') and match the specified filter.

<a name='M-Bb-Extensions-IocAutoDiscoverExtension-ResolveConfiguration-Microsoft-Extensions-Configuration-IConfiguration,System-Type,System-Action{System-Type,System-String,Microsoft-Extensions-Configuration-IConfigurationSection}-'></a>
### ResolveConfiguration(configuration,type,action) `method`

##### Summary

Resolves a configuration section for a specified type and applies an action to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | configuration that provide the section for resolve the mapping |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| action | [System.Action{System.Type,System.String,Microsoft.Extensions.Configuration.IConfigurationSection}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Type,System.String,Microsoft.Extensions.Configuration.IConfigurationSection}') |  |

<a name='M-Bb-Extensions-IocAutoDiscoverExtension-UseTypeExposedByAttribute-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration,System-String,System-Func{System-Type,System-String,System-Boolean},System-Action{System-Type}-'></a>
### UseTypeExposedByAttribute(services,configuration,contextKey,filter,action) `method`

##### Summary

Registers types exposed by attributes in the specified context into the service collection.

##### Returns

The updated [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to register the types into. Must not be null. |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The application configuration. Must not be null. |
| contextKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The context key used to filter exposed types. Must not be null. |
| filter | [System.Func{System.Type,System.String,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Type,System.String,System.Boolean}') | A filter function to determine which types to register. Can be null. |
| action | [System.Action{System.Type}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Type}') | An optional action to apply to each registered type. Can be null. |

##### Example

```C#
var services = new ServiceCollection();
services.UseTypeExposedByAttribute(configuration, "MyContext", (type, context) =&gt; true, type =&gt; Console.WriteLine($"Registered: {type.Name}"));
```

##### Remarks

This method discovers types exposed by attributes in the specified context, applies an optional filter, and registers them into the service collection.

<a name='T-Bb-Loaders-LoggingBuilderInitializer'></a>
## LoggingBuilderInitializer `type`

##### Namespace

Bb.Loaders

##### Summary

Initializes the logging builder for a web application.

<a name='M-Bb-Loaders-LoggingBuilderInitializer-Execute-Microsoft-Extensions-Logging-ILoggingBuilder-'></a>
### Execute(context) `method`

##### Summary

Executes the logging builder initializer to configure logging providers and levels.

##### Returns

The configured [ILoggingBuilder](#T-Microsoft-Extensions-Logging-ILoggingBuilder 'Microsoft.Extensions.Logging.ILoggingBuilder') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.Extensions.Logging.ILoggingBuilder](#T-Microsoft-Extensions-Logging-ILoggingBuilder 'Microsoft.Extensions.Logging.ILoggingBuilder') | The [ILoggingBuilder](#T-Microsoft-Extensions-Logging-ILoggingBuilder 'Microsoft.Extensions.Logging.ILoggingBuilder') instance to configure. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var loggingBuilder = builder.Logging;
var initializer = new LoggingBuilderInitializer();
initializer.Execute(loggingBuilder);
```

##### Remarks

This method clears existing logging providers, sets the minimum logging level to [Trace](#F-Microsoft-Extensions-Logging-LogLevel-Trace 'Microsoft.Extensions.Logging.LogLevel.Trace'), and adds console and debug logging providers. Debug logging is only added if a debugger is attached.

<a name='T-Bb-Extensions-LoggingExtension'></a>
## LoggingExtension `type`

##### Namespace

Bb.Extensions

##### Summary

Extension methods for configuring logging and tracing in a web application.

<a name='M-Bb-Extensions-LoggingExtension-ConfigureTrace-Microsoft-AspNetCore-Builder-WebApplicationBuilder-'></a>
### ConfigureTrace(builder) `method`

##### Summary

Configures logging and tracing for the web application builder.

##### Returns

The configured [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') | The [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance to configure. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
builder.ConfigureTrace();
var application = builder.Build();
application.Run();
```

##### Remarks

This method sets up logging for the web application by using the builder's services to auto-configure logging providers.

<a name='T-Bb-Loaders-Extensions-OptionsEnum'></a>
## OptionsEnum `type`

##### Namespace

Bb.Loaders.Extensions

##### Summary

Enumeration representing different options for configuration settings.

<a name='F-Bb-Loaders-Extensions-OptionsEnum-Configuration'></a>
### Configuration `constants`

##### Summary

Represents options related to configuration settings.

<a name='T-Bb-Loaders-Extensions-OptionsServices'></a>
## OptionsServices `type`

##### Namespace

Bb.Loaders.Extensions

##### Summary

Represents a service for managing options in a service collection.

<a name='M-Bb-Loaders-Extensions-OptionsServices-#ctor-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### #ctor(services) `constructor`

##### Summary

Initializes a new instance of the [OptionsServices](#T-Bb-Loaders-Extensions-OptionsServices 'Bb.Loaders.Extensions.OptionsServices') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to manage options services. Must not be null. |

##### Remarks

This constructor sets up the options services manager with the provided service collection.

<a name='M-Bb-Loaders-Extensions-OptionsServices-Items-System-IServiceProvider,Bb-Loaders-Extensions-OptionsEnum-'></a>
### Items(services,option) `method`

##### Summary

Retrieves a collection of types based on the specified options enumeration.

##### Returns

An enumerable of [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') objects representing the filtered types.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | The [IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') used to resolve service instances. Must not be null. |
| option | [Bb.Loaders.Extensions.OptionsEnum](#T-Bb-Loaders-Extensions-OptionsEnum 'Bb.Loaders.Extensions.OptionsEnum') | The [OptionsEnum](#T-Bb-Loaders-Extensions-OptionsEnum 'Bb.Loaders.Extensions.OptionsEnum') value to filter the types. Must not be null. |

##### Example

```C#
var services = new ServiceCollection();
var optionsServices = new OptionsServices(services);
var types = optionsServices.Items(serviceProvider, OptionsEnum.Configuration);
foreach (var type in types)
{
    Console.WriteLine($"Type: {type.FullName}");
}
```

##### Remarks

This method discovers and filters types exposed by the [ExposeClassAttribute](#T-Bb-ComponentModel-Attributes-ExposeClassAttribute 'Bb.ComponentModel.Attributes.ExposeClassAttribute') and registered as options in the service collection.

<a name='T-Bb-Models-Package'></a>
## Package `type`

##### Namespace

Bb.Models

##### Summary

Represents a package with an identifier and version.

<a name='M-Bb-Models-Package-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [Package](#T-Bb-Models-Package 'Bb.Models.Package') class.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor initializes a new package instance with default values.

<a name='P-Bb-Models-Package-Id'></a>
### Id `property`

##### Summary

Gets or sets the unique identifier of the package.

##### Example

```C#
var package = new Package();
package.Id = "MyPackage";
Console.WriteLine($"Package ID: {package.Id}");
```

##### Remarks

This property is used to uniquely identify a package within the application.

<a name='P-Bb-Models-Package-Version'></a>
### Version `property`

##### Summary

Gets or sets the version of the package.

##### Example

```C#
var package = new Package();
package.Version = "1.0.0";
Console.WriteLine($"Package Version: {package.Version}");
```

##### Remarks

This property specifies the version of the package, which can be used for version control or dependency management.

<a name='M-Bb-Models-Package-op_Implicit-System-String-~Bb-Models-Package'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') to a [Package](#T-Bb-Models-Package 'Bb.Models.Package') instance.

##### Returns

A new [Package](#T-Bb-Models-Package 'Bb.Models.Package') instance with the [Id](#P-Bb-Models-Package-Id 'Bb.Models.Package.Id') property set to the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String)~Bb.Models.Package](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String)~Bb.Models.Package 'System.String)~Bb.Models.Package') | A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') representing the package identifier. Must not be null or empty. |

##### Example

```C#
Package package = "MyPackage";
Console.WriteLine($"Package ID: {package.Id}");
```

##### Remarks

This operator allows a string to be implicitly converted into a [Package](#T-Bb-Models-Package 'Bb.Models.Package') object, simplifying initialization.

<a name='T-Bb-Services-PackageManager'></a>
## PackageManager `type`

##### Namespace

Bb.Services

##### Summary

manage downloading of nuget packages

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [T:Bb.Services.PackageManager](#T-T-Bb-Services-PackageManager 'T:Bb.Services.PackageManager') |  |

<a name='M-Bb-Services-PackageManager-#ctor-Microsoft-Extensions-Logging-ILogger{Bb-Services-PackageManager}-'></a>
### #ctor(logger) `constructor`

##### Summary

manage downloading of nuget packages

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger{Bb.Services.PackageManager}](#T-Microsoft-Extensions-Logging-ILogger{Bb-Services-PackageManager} 'Microsoft.Extensions.Logging.ILogger{Bb.Services.PackageManager}') |  |

<a name='P-Bb-Services-PackageManager-Assemblies'></a>
### Assemblies `property`

##### Summary

Gets the resolved assemblies.

##### Remarks

This property provides access to the assemblies that have been resolved during the package resolution process.

<a name='M-Bb-Services-PackageManager-Resolve-Bb-Models-Packages-'></a>
### Resolve(packages) `method`

##### Summary

Resolves a collection of packages by downloading and processing them.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packages | [Bb.Models.Packages](#T-Bb-Models-Packages 'Bb.Models.Packages') | The collection of packages to resolve. Must not be null. |

##### Example

```C#
var packages = new Packages { new Package("PackageA"), new Package("PackageB") };
await packageManager.Resolve(packages);
```

##### Remarks

This method processes each package in the collection by downloading and resolving its dependencies.

<a name='M-Bb-Services-PackageManager-Resolve-Bb-Models-Package-'></a>
### Resolve(package) `method`

##### Summary

Resolves a single package by downloading and processing it.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| package | [Bb.Models.Package](#T-Bb-Models-Package 'Bb.Models.Package') | The package to resolve. Must not be null. |

##### Example

```C#
var package = new Package("PackageA");
await packageManager.Resolve(package);
```

##### Remarks

This method downloads the specified package and resolves its dependencies.

<a name='M-Bb-Services-PackageManager-Resolve-System-String,System-Version-'></a>
### Resolve(packageId,version) `method`

##### Summary

Resolves a NuGet package by its ID and optional version.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packageId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The ID of the package to resolve. Must not be null or empty. |
| version | [System.Version](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Version 'System.Version') | The optional version of the package. If null, the latest version is used. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `packageId` is null or empty. |

##### Example

```C#
await packageManager.Resolve("Newtonsoft.Json", new Version("13.0.1"));
```

##### Remarks

This method downloads the specified NuGet package by its ID and resolves its dependencies.

<a name='M-Bb-Services-PackageManager-SetTarget-System-String-'></a>
### SetTarget(path) `method`

##### Summary

Set the root directory for storing nuget packages

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-Services-PackageManager-WithReference-System-Type-'></a>
### WithReference(type) `method`

##### Summary

add the type to looking for in assemblies

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='T-Bb-Models-Packages'></a>
## Packages `type`

##### Namespace

Bb.Models

##### Summary

Represents a collection of [Package](#T-Bb-Models-Package 'Bb.Models.Package') objects.

<a name='M-Bb-Models-Packages-op_Implicit-Bb-Models-Package[]-~Bb-Models-Packages'></a>
### op_Implicit(packages) `method`

##### Summary

Implicitly converts an array of [Package](#T-Bb-Models-Package 'Bb.Models.Package') objects to a [Packages](#T-Bb-Models-Packages 'Bb.Models.Packages') instance.

##### Returns

A new [Packages](#T-Bb-Models-Packages 'Bb.Models.Packages') instance containing the specified packages.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| packages | [Bb.Models.Package[])~Bb.Models.Packages](#T-Bb-Models-Package[]-~Bb-Models-Packages 'Bb.Models.Package[])~Bb.Models.Packages') | An array of [Package](#T-Bb-Models-Package 'Bb.Models.Package') objects to convert. Must not be null. |

##### Example

```C#
Package[] packageArray = { new Package { Id = "Package1" }, new Package { Id = "Package2" } };
Packages packages = packageArray;
Console.WriteLine($"Number of packages: {packages.Count}");
```

##### Remarks

This operator allows an array of [Package](#T-Bb-Models-Package 'Bb.Models.Package') objects to be implicitly converted into a [Packages](#T-Bb-Models-Packages 'Bb.Models.Packages') collection, simplifying initialization.

<a name='T-Bb-Extensions-PolicyExtension'></a>
## PolicyExtension `type`

##### Namespace

Bb.Extensions

##### Summary

Extension methods for configuring policies in a web application.

<a name='M-Bb-Extensions-PolicyExtension-AddPolicy-Microsoft-AspNetCore-Builder-WebApplicationBuilder,System-String,System-Func{Bb-Policies-Asts-PolicyRule,System-Boolean},System-Action{Microsoft-AspNetCore-Authorization-AuthorizationOptions}-'></a>
### AddPolicy(builder,filePath,filter,configureAction) `method`

##### Summary

Appends policies from the specified file.

##### Returns

The configured [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') | The [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance to configure. Must not be null. |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path to the policy file. Must not be null or empty. |
| filter | [System.Func{Bb.Policies.Asts.PolicyRule,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Bb.Policies.Asts.PolicyRule,System.Boolean}') | An optional filter function to apply to policy rules. Can be null. |
| configureAction | [System.Action{Microsoft.AspNetCore.Authorization.AuthorizationOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Microsoft.AspNetCore.Authorization.AuthorizationOptions}') | An optional action to configure authorization options. Can be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `filePath` is null. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the specified policy file does not exist. |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the policy file fails to evaluate successfully. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
builder.AddPolicy("policies.json", rule =&gt; rule.Name.StartsWith("Admin"), options =&gt; options.InvokeHandlersAfterFailure = true);
var application = builder.Build();
application.Run();
```

##### Remarks

This method parses a policy file, evaluates its rules, and registers them into the application's authorization system.

<a name='M-Bb-Extensions-PolicyExtension-ConfigurePolicy-Microsoft-AspNetCore-Builder-WebApplication-'></a>
### ConfigurePolicy(application) `method`

##### Summary

Configures the policy evaluator service.

##### Returns

The configured [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| application | [Microsoft.AspNetCore.Builder.WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') | The [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') instance to configure. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.ConfigurePolicy();
app.Run();
```

##### Remarks

This method sets up the policy evaluator service and enables authentication and authorization middleware in the application.

<a name='M-Bb-Extensions-PolicyExtension-GetAuthorizePoliciesFromAssemblies'></a>
### GetAuthorizePoliciesFromAssemblies() `method`

##### Summary

Retrieves all policy names from [AuthorizeAttribute](#T-Microsoft-AspNetCore-Authorization-AuthorizeAttribute 'Microsoft.AspNetCore.Authorization.AuthorizeAttribute') across all loaded assemblies.

##### Returns

A list of unique policy names.

##### Parameters

This method has no parameters.

##### Example

```C#
var policies = PolicyExtension.GetAuthorizePoliciesFromAssemblies();
foreach (var policy in policies)
{
    Console.WriteLine($"Policy: {policy}");
}
```

##### Remarks

This method scans all loaded assemblies for [AuthorizeAttribute](#T-Microsoft-AspNetCore-Authorization-AuthorizeAttribute 'Microsoft.AspNetCore.Authorization.AuthorizeAttribute') applied to types, methods, and properties, and collects their policy names.

<a name='T-Bb-Middleware-EntryFullLogger-RequestResponseLogModel'></a>
## RequestResponseLogModel `type`

##### Namespace

Bb.Middleware.EntryFullLogger

##### Summary

Represents a model for logging HTTP request and response details.

<a name='M-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [RequestResponseLogModel](#T-Bb-Middleware-EntryFullLogger-RequestResponseLogModel 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel') class.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor initializes the log model with a unique identifier for each request and response log entry.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ClientIp'></a>
### ClientIp `property`

##### Summary

Gets or sets the client IP address associated with the request.

##### Example

```C#
var logModel = new RequestResponseLogModel();
logModel.ClientIp = "192.168.1.1";
Console.WriteLine($"Client IP: {logModel.ClientIp}");
```

##### Remarks

This property captures the IP address of the client making the HTTP request.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ExceptionMessage'></a>
### ExceptionMessage `property`

##### Summary

Gets or sets the exception message if an error occurred during the request or response.

##### Example

```C#
var logModel = new RequestResponseLogModel();
logModel.ExceptionMessage = "An error occurred.";
Console.WriteLine($"Exception: {logModel.ExceptionMessage}");
```

##### Remarks

This property captures the error message if an exception occurred during the processing of the request or response.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ExceptionStackTrace'></a>
### ExceptionStackTrace `property`

##### Summary

Gets or sets the stack trace of the exception if an error occurred.

##### Example

```C#
var logModel = new RequestResponseLogModel();
logModel.ExceptionStackTrace = "StackTrace details...";
Console.WriteLine($"Stack Trace: {logModel.ExceptionStackTrace}");
```

##### Remarks

This property captures the stack trace of the exception for debugging purposes.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-IsExceptionActionLevel'></a>
### IsExceptionActionLevel `property`

##### Summary

Gets or sets a value indicating whether the request was successful.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-LogId'></a>
### LogId `property`

##### Summary

Gets or sets the unique identifier for the log entry.

##### Example

```C#
var logModel = new RequestResponseLogModel();
Console.WriteLine($"Log ID: {logModel.LogId}");
```

##### Remarks

This property is automatically initialized with a new GUID when the log model is created.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-Node'></a>
### Node `property`

##### Summary

Gets or sets the name of the node or project associated with the log entry.

##### Example

```C#
var logModel = new RequestResponseLogModel();
logModel.Node = "MyProject";
Console.WriteLine($"Node: {logModel.Node}");
```

##### Remarks

This property is used to identify the source of the log entry, such as the project or application name.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestBody'></a>
### RequestBody `property`

##### Summary

Gets or sets the body of the HTTP request.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestContentType'></a>
### RequestContentType `property`

##### Summary

Gets or sets the content type of the HTTP request.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestDateTimeUtc'></a>
### RequestDateTimeUtc `property`

##### Summary

Gets or sets the UTC timestamp of when the request was received.

##### Example

```C#
var logModel = new RequestResponseLogModel();
logModel.RequestDateTimeUtc = DateTime.UtcNow;
Console.WriteLine($"Request Time: {logModel.RequestDateTimeUtc}");
```

##### Remarks

This property records the time the HTTP request was received by the server.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestDateTimeUtcActionLevel'></a>
### RequestDateTimeUtcActionLevel `property`

##### Summary

Gets or sets the UTC timestamp of when the request was received at the action level.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestHeaders'></a>
### RequestHeaders `property`

##### Summary

Gets or sets the port of the request.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestHost'></a>
### RequestHost `property`

##### Summary

Gets or sets the host of the request (e.g., example.com).

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestMethod'></a>
### RequestMethod `property`

##### Summary

Gets or sets the HTTP method used for the request (e.g., GET, POST).

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestPath'></a>
### RequestPath `property`

##### Summary

Gets or sets the path of the HTTP request.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestQueries'></a>
### RequestQueries `property`

##### Summary

Gets or sets the list of query parameters for the HTTP request.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestQuery'></a>
### RequestQuery `property`

##### Summary

Gets or sets the query string of the HTTP request.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-RequestScheme'></a>
### RequestScheme `property`

##### Summary

Gets or sets the scheme used for the request (e.g., HTTP, HTTPS).

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseBody'></a>
### ResponseBody `property`

##### Summary

Gets or sets the body of the HTTP response.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseContentType'></a>
### ResponseContentType `property`

##### Summary

Gets or sets the content type of the HTTP response.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseDateTimeUtc'></a>
### ResponseDateTimeUtc `property`

##### Summary

Gets or sets the UTC timestamp of when the response was sent.

##### Example

```C#
var logModel = new RequestResponseLogModel();
logModel.ResponseDateTimeUtc = DateTime.UtcNow;
Console.WriteLine($"Response Time: {logModel.ResponseDateTimeUtc}");
```

##### Remarks

This property records the time the HTTP response was sent by the server.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseDateTimeUtcActionLevel'></a>
### ResponseDateTimeUtcActionLevel `property`

##### Summary

Gets or sets the UTC timestamp of when the response was sent at the action level.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseHeaders'></a>
### ResponseHeaders `property`

##### Summary

Gets or sets the status code of the HTTP response at the action level.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-ResponseStatus'></a>
### ResponseStatus `property`

##### Summary

Gets or sets the status code of the HTTP response.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModel-TraceId'></a>
### TraceId `property`

##### Summary

Gets or sets the trace identifier for the request.

##### Example

```C#
var logModel = new RequestResponseLogModel();
logModel.TraceId = "abc123";
Console.WriteLine($"Trace ID: {logModel.TraceId}");
```

##### Remarks

This property is typically populated with the `HttpContext.TraceIdentifier` value to correlate logs with specific requests.

<a name='T-Bb-Middleware-EntryFullLogger-RequestResponseLogModelCreator'></a>
## RequestResponseLogModelCreator `type`

##### Namespace

Bb.Middleware.EntryFullLogger

##### Summary

Represents a factory for creating request and response log models.

<a name='M-Bb-Middleware-EntryFullLogger-RequestResponseLogModelCreator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [RequestResponseLogModelCreator](#T-Bb-Middleware-EntryFullLogger-RequestResponseLogModelCreator 'Bb.Middleware.EntryFullLogger.RequestResponseLogModelCreator') class.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor initializes the log model creator with a new instance of [RequestResponseLogModel](#T-Bb-Middleware-EntryFullLogger-RequestResponseLogModel 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel') to capture request and response details.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLogModelCreator-LogModel'></a>
### LogModel `property`

##### Summary

Gets the log model containing the details of the request and response.

##### Example

```C#
var logModelCreator = new RequestResponseLogModelCreator();
var logModel = logModelCreator.LogModel;
Console.WriteLine($"Log ID: {logModel.LogId}");
```

##### Remarks

This property provides access to the log model that encapsulates the details of the HTTP request and response.

<a name='M-Bb-Middleware-EntryFullLogger-RequestResponseLogModelCreator-LogString'></a>
### LogString() `method`

##### Summary

Generates a string representation of the log model.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the serialized log details.

##### Parameters

This method has no parameters.

##### Example

```C#
var logModelCreator = new RequestResponseLogModelCreator();
string logString = logModelCreator.LogString();
Console.WriteLine($"Serialized Log: {logString}");
```

##### Remarks

This method serializes the log model into a JSON string for logging or debugging purposes.

<a name='T-Bb-Middleware-EntryFullLogger-RequestResponseLogger'></a>
## RequestResponseLogger `type`

##### Namespace

Bb.Middleware.EntryFullLogger

##### Summary

Represents a logger for HTTP request and response details.

<a name='M-Bb-Middleware-EntryFullLogger-RequestResponseLogger-#ctor-Microsoft-Extensions-Logging-ILogger{Bb-Middleware-EntryFullLogger-RequestResponseLogger}-'></a>
### #ctor(logger) `constructor`

##### Summary

Initializes a new instance of the [RequestResponseLogger](#T-Bb-Middleware-EntryFullLogger-RequestResponseLogger 'Bb.Middleware.EntryFullLogger.RequestResponseLogger') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger{Bb.Middleware.EntryFullLogger.RequestResponseLogger}](#T-Microsoft-Extensions-Logging-ILogger{Bb-Middleware-EntryFullLogger-RequestResponseLogger} 'Microsoft.Extensions.Logging.ILogger{Bb.Middleware.EntryFullLogger.RequestResponseLogger}') | The [ILogger\`1](#T-Microsoft-Extensions-Logging-ILogger`1 'Microsoft.Extensions.Logging.ILogger`1') instance used for logging. Must not be null. |

##### Remarks

This constructor sets up the logger for capturing and logging request and response details.

<a name='M-Bb-Middleware-EntryFullLogger-RequestResponseLogger-Log-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator-'></a>
### Log(logCreator) `method`

##### Summary

Logs the request and response details using the provided log model creator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logCreator | [Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator](#T-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator 'Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator') | An instance of [IRequestResponseLogModelCreator](#T-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator 'Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator') used to create the log model. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `logCreator` is null. |

##### Example

```C#
var logger = new RequestResponseLogger(new LoggerFactory().CreateLogger&lt;RequestResponseLogger&gt;());
var logCreator = new MyRequestResponseLogModelCreator();
logger.Log(logCreator);
```

##### Remarks

This method captures the log details from the provided log model creator and logs them at the critical level.

<a name='T-Bb-Middleware-RequestResponseLoggerMiddleware'></a>
## RequestResponseLoggerMiddleware `type`

##### Namespace

Bb.Middleware

##### Summary

Middleware for logging HTTP request and response details.

<a name='M-Bb-Middleware-RequestResponseLoggerMiddleware-#ctor-Microsoft-AspNetCore-Http-RequestDelegate,Microsoft-Extensions-Options-IOptions{Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption},Bb-Middleware-EntryFullLogger-IRequestResponseLogger-'></a>
### #ctor(next,options,logger) `constructor`

##### Summary

Initializes a new instance of the [RequestResponseLoggerMiddleware](#T-Bb-Middleware-RequestResponseLoggerMiddleware 'Bb.Middleware.RequestResponseLoggerMiddleware') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| next | [Microsoft.AspNetCore.Http.RequestDelegate](#T-Microsoft-AspNetCore-Http-RequestDelegate 'Microsoft.AspNetCore.Http.RequestDelegate') | The next middleware in the pipeline. Must not be null. |
| options | [Microsoft.Extensions.Options.IOptions{Bb.Middleware.EntryFullLogger.RequestResponseLoggerOption}](#T-Microsoft-Extensions-Options-IOptions{Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption} 'Microsoft.Extensions.Options.IOptions{Bb.Middleware.EntryFullLogger.RequestResponseLoggerOption}') | The [IOptions\`1](#T-Microsoft-Extensions-Options-IOptions`1 'Microsoft.Extensions.Options.IOptions`1') instance containing configuration options. Must not be null. |
| logger | [Bb.Middleware.EntryFullLogger.IRequestResponseLogger](#T-Bb-Middleware-EntryFullLogger-IRequestResponseLogger 'Bb.Middleware.EntryFullLogger.IRequestResponseLogger') | The [IRequestResponseLogger](#T-Bb-Middleware-EntryFullLogger-IRequestResponseLogger 'Bb.Middleware.EntryFullLogger.IRequestResponseLogger') instance used for logging. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `next`, `options`, or `logger` is null. |

##### Remarks

This constructor sets up the middleware to log HTTP request and response details based on the provided options.

<a name='M-Bb-Middleware-RequestResponseLoggerMiddleware-FormatHeaders-Microsoft-AspNetCore-Http-IHeaderDictionary-'></a>
### FormatHeaders(headers) `method`

##### Summary

Formats HTTP headers into a dictionary.

##### Returns

A [Dictionary\`2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary`2 'System.Collections.Generic.Dictionary`2') containing the formatted headers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| headers | [Microsoft.AspNetCore.Http.IHeaderDictionary](#T-Microsoft-AspNetCore-Http-IHeaderDictionary 'Microsoft.AspNetCore.Http.IHeaderDictionary') | The [IHeaderDictionary](#T-Microsoft-AspNetCore-Http-IHeaderDictionary 'Microsoft.AspNetCore.Http.IHeaderDictionary') containing the HTTP headers. Must not be null. |

##### Example

```C#
var headers = httpContext.Request.Headers;
var formattedHeaders = FormatHeaders(headers);
Console.WriteLine($"Headers: {string.Join(", ", formattedHeaders)}");
```

##### Remarks

This method converts the HTTP headers into a key-value pair dictionary for logging purposes.

<a name='M-Bb-Middleware-RequestResponseLoggerMiddleware-FormatQueries-System-String-'></a>
### FormatQueries(queryString) `method`

##### Summary

Formats query string parameters into a list of key-value pairs.

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of key-value pairs representing the query parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The query string to format. Must not be null or empty. |

##### Example

```C#
var queryString = "?key1=value1&amp;key2=value2";
var formattedQueries = FormatQueries(queryString);
foreach (var query in formattedQueries)
{
    Console.WriteLine($"Key: {query.Key}, Value: {query.Value}");
```

##### Remarks

This method parses the query string and converts it into a list of key-value pairs for logging purposes.

<a name='M-Bb-Middleware-RequestResponseLoggerMiddleware-InvokeAsync-Microsoft-AspNetCore-Http-HttpContext,Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator-'></a>
### InvokeAsync(httpContext,logCreator) `method`

##### Summary

Processes an HTTP request and logs its details, along with the response details.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') that represents the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpContext | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | The [HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') representing the current HTTP request. Must not be null. |
| logCreator | [Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator](#T-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator 'Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator') | The [IRequestResponseLogModelCreator](#T-Bb-Middleware-EntryFullLogger-IRequestResponseLogModelCreator 'Bb.Middleware.EntryFullLogger.IRequestResponseLogModelCreator') instance used to create the log model. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseMiddleware&lt;RequestResponseLoggerMiddleware&gt;();
app.Run();
```

##### Remarks

This method captures and logs details of the HTTP request and response, including headers, body, and exceptions, if any.

<a name='M-Bb-Middleware-RequestResponseLoggerMiddleware-LogError-Bb-Middleware-EntryFullLogger-RequestResponseLogModel,System-Exception-'></a>
### LogError(log,exception) `method`

##### Summary

Logs an exception and updates the log model with exception details.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| log | [Bb.Middleware.EntryFullLogger.RequestResponseLogModel](#T-Bb-Middleware-EntryFullLogger-RequestResponseLogModel 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel') | The [RequestResponseLogModel](#T-Bb-Middleware-EntryFullLogger-RequestResponseLogModel 'Bb.Middleware.EntryFullLogger.RequestResponseLogModel') instance to update with exception details. Must not be null. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') instance representing the error. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `log` or `exception` is null. |

##### Remarks

This method captures the exception message and stack trace and updates the log model accordingly.

<a name='M-Bb-Middleware-RequestResponseLoggerMiddleware-ReadBodyFromRequest-Microsoft-AspNetCore-Http-HttpRequest-'></a>
### ReadBodyFromRequest(request) `method`

##### Summary

Reads the body of an HTTP request.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the asynchronous operation, with a result of the request body as a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Microsoft.AspNetCore.Http.HttpRequest](#T-Microsoft-AspNetCore-Http-HttpRequest 'Microsoft.AspNetCore.Http.HttpRequest') | The [HttpRequest](#T-Microsoft-AspNetCore-Http-HttpRequest 'Microsoft.AspNetCore.Http.HttpRequest') instance to read the body from. Must not be null. |

##### Example

```C#
var requestBody = await ReadBodyFromRequest(httpContext.Request);
Console.WriteLine($"Request Body: {requestBody}");
```

##### Remarks

This method reads the body of the HTTP request and resets the stream position for subsequent middleware in the pipeline.

<a name='T-Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption'></a>
## RequestResponseLoggerOption `type`

##### Namespace

Bb.Middleware.EntryFullLogger

##### Summary

Represents the options for configuring the request and response logger.

<a name='M-Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [RequestResponseLoggerOption](#T-Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption 'Bb.Middleware.EntryFullLogger.RequestResponseLoggerOption') class.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor initializes the default settings for the request and response logger options.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption-DateTimeFormat'></a>
### DateTimeFormat `property`

##### Summary

Gets or sets the date and time format used in the logs.

##### Example

```C#
var options = new RequestResponseLoggerOption();
options.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
Console.WriteLine($"DateTime Format: {options.DateTimeFormat}");
```

##### Remarks

This property specifies the format in which date and time values are logged.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption-IsEnabled'></a>
### IsEnabled `property`

##### Summary

Gets or sets a value indicating whether the request and response logging is enabled.

##### Example

```C#
var options = new RequestResponseLoggerOption();
options.IsEnabled = true;
Console.WriteLine($"Logging enabled: {options.IsEnabled}");
```

##### Remarks

This property determines whether the request and response logging functionality is active.

<a name='P-Bb-Middleware-EntryFullLogger-RequestResponseLoggerOption-Name'></a>
### Name `property`

##### Summary

Gets or sets the name associated with the logger.

##### Example

```C#
var options = new RequestResponseLoggerOption();
options.Name = "RequestLogger";
Console.WriteLine($"Logger Name: {options.Name}");
```

##### Remarks

This property specifies the name used to identify the logger in logs or configurations.

<a name='T-Bb-Extensions-RestClientFactoryExtension'></a>
## RestClientFactoryExtension `type`

##### Namespace

Bb.Extensions

##### Summary

Extension methods for configuring the REST client factory in the BlackBeard library.

<a name='M-Bb-Extensions-RestClientFactoryExtension-AddRestClientFactory-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddRestClientFactory(services) `method`

##### Summary

Adds the REST client factory services to the dependency injection container.

##### Returns

The updated [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to add the services to. Must not be null. |

##### Example

```C#
var services = new ServiceCollection();
services.AddRestClientFactory();
var serviceProvider = services.BuildServiceProvider();
var restClientFactory = serviceProvider.GetRequiredService&lt;IRestClientFactory&gt;();
```

##### Remarks

This method registers the [IOptionClientFactory](#T-Bb-Interfaces-IOptionClientFactory 'Bb.Interfaces.IOptionClientFactory') and [IRestClientFactory](#T-Bb-Interfaces-IRestClientFactory 'Bb.Interfaces.IRestClientFactory') as singleton services in the dependency injection container.

<a name='T-Bb-Models-RestClientOptions'></a>
## RestClientOptions `type`

##### Namespace

Bb.Models

##### Summary

Represents the options for configuring a REST client.

<a name='M-Bb-Models-RestClientOptions-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [RestClientOptions](#T-Bb-Models-RestClientOptions 'Bb.Models.RestClientOptions') class.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor initializes the RestClientOptions with default values, including an empty list of client option configurations.

<a name='P-Bb-Models-RestClientOptions-ClientActivated'></a>
### ClientActivated `property`

##### Summary

Gets or sets a value indicating whether the client is activated.

##### Example

```C#
var options = new RestClientOptions();
options.ClientActivated = true;
Console.WriteLine($"Client Activated: {options.ClientActivated}");
```

##### Remarks

This property determines whether the client is enabled and can make requests.

<a name='P-Bb-Models-RestClientOptions-Options'></a>
### Options `property`

##### Summary

Gets or sets the list of client option configurations.

##### Example

```C#
var options = new RestClientOptions();
options.Options.Add(new ClientOptionConfiguration { Name = "Client1" });
Console.WriteLine($"Number of client options: {options.Options.Count}");
```

##### Remarks

This property contains the configurations for multiple clients that can be used by the RestClient.

<a name='P-Bb-Models-RestClientOptions-TokenClientId'></a>
### TokenClientId `property`

##### Summary

Gets or sets the client ID used for token authentication.

##### Example

```C#
var options = new RestClientOptions();
options.TokenClientId = "my-client-id";
Console.WriteLine($"Token Client ID: {options.TokenClientId}");
```

##### Remarks

This property specifies the client ID required to authenticate with the token endpoint.

<a name='P-Bb-Models-RestClientOptions-TokenClientSecret'></a>
### TokenClientSecret `property`

##### Summary

Gets or sets the client secret used for token authentication.

##### Example

```C#
var options = new RestClientOptions();
options.TokenClientSecret = "my-client-secret";
Console.WriteLine($"Token Client Secret: {options.TokenClientSecret}");
```

##### Remarks

This property specifies the client secret required to authenticate with the token endpoint.

<a name='P-Bb-Models-RestClientOptions-TokenUrl'></a>
### TokenUrl `property`

##### Summary

Gets or sets the URL used to obtain a token for authentication.

##### Example

```C#
var options = new RestClientOptions();
options.TokenUrl = "https://example.com/token";
Console.WriteLine($"Token URL: {options.TokenUrl}");
```

##### Remarks

This property specifies the endpoint used to retrieve an authentication token for the client.

<a name='P-Bb-Models-RestClientOptions-UseApiKey'></a>
### UseApiKey `property`

##### Summary

Gets or sets a value indicating whether an API key should be used for authentication.

##### Example

```C#
var options = new RestClientOptions();
options.UseApiKey = true;
Console.WriteLine($"Use API Key: {options.UseApiKey}");
```

##### Remarks

This property determines whether the client will use an API key for authentication when making requests.

<a name='T-Bb-Middleware-RouteListingMiddleware'></a>
## RouteListingMiddleware `type`

##### Namespace

Bb.Middleware

##### Summary

Middleware that logs all registered routes in the application.

<a name='M-Bb-Middleware-RouteListingMiddleware-#ctor-Microsoft-AspNetCore-Http-RequestDelegate,Microsoft-Extensions-Logging-ILogger{Bb-Middleware-RouteListingMiddleware}-'></a>
### #ctor(next,logger) `constructor`

##### Summary

Initializes a new instance of the [RouteListingMiddleware](#T-Bb-Middleware-RouteListingMiddleware 'Bb.Middleware.RouteListingMiddleware') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| next | [Microsoft.AspNetCore.Http.RequestDelegate](#T-Microsoft-AspNetCore-Http-RequestDelegate 'Microsoft.AspNetCore.Http.RequestDelegate') | The next middleware in the pipeline. Must not be null. |
| logger | [Microsoft.Extensions.Logging.ILogger{Bb.Middleware.RouteListingMiddleware}](#T-Microsoft-Extensions-Logging-ILogger{Bb-Middleware-RouteListingMiddleware} 'Microsoft.Extensions.Logging.ILogger{Bb.Middleware.RouteListingMiddleware}') | The [ILogger\`1](#T-Microsoft-Extensions-Logging-ILogger`1 'Microsoft.Extensions.Logging.ILogger`1') instance used for logging. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `next` or `logger` is null. |

##### Remarks

This constructor sets up the middleware to log all registered routes in the application.

<a name='M-Bb-Middleware-RouteListingMiddleware-InvokeAsync-Microsoft-AspNetCore-Http-HttpContext,Microsoft-AspNetCore-Routing-EndpointDataSource-'></a>
### InvokeAsync(context,endpointDataSource) `method`

##### Summary

Processes an HTTP request and logs all registered routes in the application.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') that represents the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | The [HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') representing the current HTTP request. Must not be null. |
| endpointDataSource | [Microsoft.AspNetCore.Routing.EndpointDataSource](#T-Microsoft-AspNetCore-Routing-EndpointDataSource 'Microsoft.AspNetCore.Routing.EndpointDataSource') | The [EndpointDataSource](#T-Microsoft-AspNetCore-Routing-EndpointDataSource 'Microsoft.AspNetCore.Routing.EndpointDataSource') containing the registered endpoints. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseMiddleware&lt;RouteListingMiddleware&gt;();
app.Run();
```

##### Remarks

This method iterates through all registered endpoints in the application and logs their route patterns.

<a name='T-Bb-Extensions-RouteListingMiddlewareExtensions'></a>
## RouteListingMiddlewareExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Extension methods for configuring the route listing middleware in ASP.NET Core applications.

<a name='M-Bb-Extensions-RouteListingMiddlewareExtensions-UseRouteListing-Microsoft-AspNetCore-Builder-IApplicationBuilder-'></a>
### UseRouteListing(builder) `method`

##### Summary

Adds the route listing middleware to the application's request pipeline.

##### Returns

The configured [IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Builder.IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') | The [IApplicationBuilder](#T-Microsoft-AspNetCore-Builder-IApplicationBuilder 'Microsoft.AspNetCore.Builder.IApplicationBuilder') instance to configure. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseRouteListing();
app.Run();
```

##### Remarks

This middleware provides a mechanism to list all registered routes in the application, which can be useful for debugging and documentation purposes.

<a name='T-Site-Services-SchemaGenerator'></a>
## SchemaGenerator `type`

##### Namespace

Site.Services

##### Summary

Generates JSON schema for specified types and saves them to a directory.

<a name='M-Site-Services-SchemaGenerator-#ctor-System-String,System-String-'></a>
### #ctor(path,idTemplate) `constructor`

##### Summary

Initializes a new instance of the [SchemaGenerator](#T-Site-Services-SchemaGenerator 'Site.Services.SchemaGenerator') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory path where schema will be saved. Must not be null or empty. |
| idTemplate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The template for generating schema IDs. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `path` or `idTemplate` is null or empty. |

##### Remarks

This constructor sets up the schema generator by creating the specified directory if it does not exist.

<a name='F-Site-Services-SchemaGenerator-_idTemplate'></a>
### _idTemplate `constants`

##### Summary

The template for generating schema IDs.

<a name='F-Site-Services-SchemaGenerator-_instance'></a>
### _instance `constants`

##### Summary

The singleton instance of the [SchemaGenerator](#T-Site-Services-SchemaGenerator 'Site.Services.SchemaGenerator') class.

<a name='F-Site-Services-SchemaGenerator-_path'></a>
### _path `constants`

##### Summary

The directory path where schemas are saved.

<a name='M-Site-Services-SchemaGenerator-GenerateSchema-System-Type-'></a>
### GenerateSchema(type) `method`

##### Summary

Generates a schema for the specified type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type for which to generate the schema. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `type` is null. |

##### Example

```C#
SchemaGenerator.GenerateSchema(typeof(MyClass));
```

##### Remarks

This method generates a JSON schema for the specified type and saves it to the configured directory.

<a name='M-Site-Services-SchemaGenerator-GenerateSchemaImpl-System-Type-'></a>
### GenerateSchemaImpl(type) `method`

##### Summary

Generates a schema for the specified type and saves it to a file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type for which to generate the schema. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `type` is null. |

##### Remarks

This method retrieves metadata from the type, generates a schema, and saves it to a file in the configured directory.

<a name='M-Site-Services-SchemaGenerator-GetFilename-System-String-'></a>
### GetFilename(name) `method`

##### Summary

Gets the file path for the schema file based on the type name.

##### Returns

A [FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') object representing the schema file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the type. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `name` is null or empty. |

##### Remarks

This method constructs the file path for the schema file and ensures that any existing file is deleted.

<a name='M-Site-Services-SchemaGenerator-Initialize-System-String,System-String-'></a>
### Initialize(path,idTemplate) `method`

##### Summary

Initializes the schema generator with the specified path and ID template.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory path where schemas will be saved. Must not be null or empty. |
| idTemplate | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The template for generating schema IDs. Must not be null or empty. |

##### Example

```C#
SchemaGenerator.Initialize("C:\\Schemas", "http://example.com/schemas/{0}");
```

##### Remarks

This method creates a singleton instance of the [SchemaGenerator](#T-Site-Services-SchemaGenerator 'Site.Services.SchemaGenerator') class.

<a name='T-Bb-Models-SourceCertificate'></a>
## SourceCertificate `type`

##### Namespace

Bb.Models

##### Summary

Specifies the source type of a certificate.

##### Remarks

This enumeration defines the possible sources from which a certificate can be loaded, such as a file or a certificate store.

<a name='F-Bb-Models-SourceCertificate-File'></a>
### File `constants`

##### Summary

Indicates that the certificate is loaded from a file.

##### Example

```C#
var certificate = new Certificate();
certificate.TypeSource = SourceCertificate.File;
Console.WriteLine($"Certificate Source: {certificate.TypeSource}");
```

<a name='F-Bb-Models-SourceCertificate-Store'></a>
### Store `constants`

##### Summary

Indicates that the certificate is loaded from a certificate store.

##### Example

```C#
var certificate = new Certificate();
certificate.TypeSource = SourceCertificate.Store;
Console.WriteLine($"Certificate Source: {certificate.TypeSource}");
```

<a name='T-Bb-Extensions-Startup'></a>
## Startup `type`

##### Namespace

Bb.Extensions

##### Summary

Represents the startup configuration for a web application.

##### Remarks

This class is responsible for configuring services, middleware, and the HTTP request pipeline for the application.

<a name='M-Bb-Extensions-Startup-#ctor-Microsoft-Extensions-Configuration-IConfiguration,Bb-Services-WebService-'></a>
### #ctor(configuration,service) `constructor`

##### Summary

Initializes a new instance of the [Startup](#T-Bb-Extensions-Startup 'Bb.Extensions.Startup') class with the specified configuration and web service.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | configuration object |
| service | [Bb.Services.WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') | service to initialize |

<a name='F-Bb-Extensions-Startup-_configuration'></a>
### _configuration `constants`

##### Summary

The configuration object for the application.

<a name='F-Bb-Extensions-Startup-_service'></a>
### _service `constants`

##### Summary

service

<a name='P-Bb-Extensions-Startup-Configuration'></a>
### Configuration `property`

##### Summary

Gets the startup configuration for the application.

<a name='M-Bb-Extensions-Startup-Configure-Microsoft-AspNetCore-Builder-WebApplication,Microsoft-AspNetCore-Hosting-IWebHostEnvironment-'></a>
### Configure(application,environment) `method`

##### Summary

Configures the HTTP request pipeline for the web application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| application | [Microsoft.AspNetCore.Builder.WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') | The [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') instance to configure. Must not be null. |
| environment | [Microsoft.AspNetCore.Hosting.IWebHostEnvironment](#T-Microsoft-AspNetCore-Hosting-IWebHostEnvironment 'Microsoft.AspNetCore.Hosting.IWebHostEnvironment') | The [IWebHostEnvironment](#T-Microsoft-AspNetCore-Hosting-IWebHostEnvironment 'Microsoft.AspNetCore.Hosting.IWebHostEnvironment') representing the hosting environment. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var application = builder.Build();
var startup = new Startup(builder.Configuration, new WebService());
startup.Configure(application, builder.Environment);
application.Run();
```

##### Remarks

This method sets up middleware such as exception handling, HTTPS redirection, static files, routing, authentication, and authorization.

<a name='M-Bb-Extensions-Startup-ConfigureServices-Microsoft-AspNetCore-Builder-WebApplicationBuilder,Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureServices(builder,services) `method`

##### Summary

Configures services for the web application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') | The [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance to configure. Must not be null. |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to add services to. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration, new WebService());
startup.ConfigureServices(builder, builder.Services);
var app = builder.Build();
app.Run();
```

##### Remarks

This method configures various services such as HTTPS, REST clients, bearer authentication, and policies based on the startup configuration.

<a name='M-Bb-Extensions-Startup-LoadCertificate'></a>
### LoadCertificate() `method`

##### Summary

Loads the server certificate for HTTPS.

##### Returns

The loaded [X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') instance.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the certificate file is not found. |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the certificate cannot be loaded or created. |

##### Example

```C#
var certificate = LoadCertificate();
Console.WriteLine($"Certificate loaded: {certificate.Subject}");
```

##### Remarks

This method attempts to load the certificate from the specified path or creates a self-signed certificate if none is found.

<a name='M-Bb-Extensions-Startup-LoadFromFile-Bb-Models-Certificate-'></a>
### LoadFromFile(certificate) `method`

##### Summary

Loads a certificate from a specified file or store.

##### Returns

The loaded [X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| certificate | [Bb.Models.Certificate](#T-Bb-Models-Certificate 'Bb.Models.Certificate') | The [Certificate](#T-Bb-Models-Certificate 'Bb.Models.Certificate') object containing certificate details. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown if the specified file does not exist. |

##### Remarks

This method loads a certificate from a file or the certificate store based on the specified source type.

<a name='M-Bb-Extensions-Startup-LoadFromFile2-Bb-Models-Certificate-'></a>
### LoadFromFile2(certificate) `method`

##### Summary

Loads a certificate from a file or creates a self-signed certificate if no file is found.

##### Returns

The loaded or created [X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| certificate | [Bb.Models.Certificate](#T-Bb-Models-Certificate 'Bb.Models.Certificate') | The [Certificate](#T-Bb-Models-Certificate 'Bb.Models.Certificate') object containing certificate details. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the certificate cannot be created. |

##### Remarks

This method checks for existing certificate files in a folder and creates a self-signed certificate if none are found.

<a name='M-Bb-Extensions-Startup-ManageBearer-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ManageBearer(services) `method`

##### Summary

Manages bearer authentication for the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to configure authentication for. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the configuration for bearer options is null. |

##### Remarks

This method configures JWT bearer authentication using the options specified in the startup configuration.

<a name='M-Bb-Extensions-Startup-ManageCertificate-Microsoft-AspNetCore-Builder-ConfigureWebHostBuilder-'></a>
### ManageCertificate(webHost) `method`

##### Summary

Configures HTTPS settings for the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| webHost | [Microsoft.AspNetCore.Builder.ConfigureWebHostBuilder](#T-Microsoft-AspNetCore-Builder-ConfigureWebHostBuilder 'Microsoft.AspNetCore.Builder.ConfigureWebHostBuilder') | The [ConfigureWebHostBuilder](#T-Microsoft-AspNetCore-Builder-ConfigureWebHostBuilder 'Microsoft.AspNetCore.Builder.ConfigureWebHostBuilder') to configure HTTPS for. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the certificate cannot be loaded. |

##### Remarks

This method sets up HTTPS defaults and loads the server certificate.

<a name='T-Bb-Models-StartupConfiguration'></a>
## StartupConfiguration `type`

##### Namespace

Bb.Models

##### Summary

Represents the startup configuration for the application.

<a name='M-Bb-Models-StartupConfiguration-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [StartupConfiguration](#T-Bb-Models-StartupConfiguration 'Bb.Models.StartupConfiguration') class.

##### Parameters

This constructor has no parameters.

<a name='P-Bb-Models-StartupConfiguration-AssemblyNames'></a>
### AssemblyNames `property`

##### Summary

Gets or sets the collection of assembly names.

##### Remarks

This property holds the names of assemblies used by the application.

<a name='P-Bb-Models-StartupConfiguration-BearerOptions'></a>
### BearerOptions `property`

##### Summary

Gets or sets the list of bearer token options.

##### Remarks

This property contains the configuration for bearer token authentication.

<a name='P-Bb-Models-StartupConfiguration-Folders'></a>
### Folders `property`

##### Summary

Gets or sets the collection of folder paths.

##### Remarks

This property contains the paths to folders used by the application.

<a name='P-Bb-Models-StartupConfiguration-HTTPSCertificate'></a>
### HTTPSCertificate `property`

##### Summary

Gets or sets the HTTPS certificate configuration.

##### Remarks

This property holds the configuration for the HTTPS certificate used by the application.

<a name='P-Bb-Models-StartupConfiguration-LogExceptions'></a>
### LogExceptions `property`

##### Summary

Gets or sets a value indicating whether exceptions should be logged.

##### Remarks

This property determines if exceptions encountered during application execution should be logged.

<a name='P-Bb-Models-StartupConfiguration-LogInfo'></a>
### LogInfo `property`

##### Summary

Gets or sets a value indicating whether informational messages should be logged.

##### Remarks

This property determines if informational messages should be logged during application execution.

<a name='P-Bb-Models-StartupConfiguration-MapBlazorHub'></a>
### MapBlazorHub `property`

##### Summary

Gets or sets a value indicating whether the Blazor hub should be mapped.

##### Remarks

This property determines if the application should map the Blazor hub for SignalR communication.

<a name='P-Bb-Models-StartupConfiguration-MapFallbackToPage'></a>
### MapFallbackToPage `property`

##### Summary

Gets or sets the fallback page for routing.

##### Remarks

This property specifies the fallback page to use when no other route matches.

<a name='P-Bb-Models-StartupConfiguration-Packages'></a>
### Packages `property`

##### Summary

Gets or sets the collection of NuGet package configurations.

##### Remarks

This property holds the configuration for NuGet packages used by the application.

<a name='P-Bb-Models-StartupConfiguration-PolicyFiles'></a>
### PolicyFiles `property`

##### Summary

Gets or sets the collection of policy file paths.

##### Remarks

This property holds the paths to policy files used for application configuration.

<a name='P-Bb-Models-StartupConfiguration-RestClient'></a>
### RestClient `property`

##### Summary

Gets or sets the REST client options.

##### Remarks

This property contains the configuration options for REST client usage.

<a name='P-Bb-Models-StartupConfiguration-UseRouting'></a>
### UseRouting `property`

##### Summary

Gets or sets a value indicating whether routing is enabled.

##### Remarks

This property determines if the application should use routing for request handling.

<a name='P-Bb-Models-StartupConfiguration-UseStaticFiles'></a>
### UseStaticFiles `property`

##### Summary

Gets or sets a value indicating whether static files should be served.

##### Remarks

This property determines if the application should serve static files.

<a name='T-Bb-Extensions-StartupExtensions'></a>
## StartupExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Extension methods for configuring the startup process of a web application.

<a name='M-Bb-Extensions-StartupExtensions-ResolveParameters-Bb-ComponentModel-Factories-LocalServiceProvider,System-Reflection-MethodInfo-'></a>
### ResolveParameters(serviceProvider,configureServicesMethod) `method`

##### Summary

Resolves the parameters required by a method using the local service provider.

##### Returns

An array of resolved parameter objects.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [Bb.ComponentModel.Factories.LocalServiceProvider](#T-Bb-ComponentModel-Factories-LocalServiceProvider 'Bb.ComponentModel.Factories.LocalServiceProvider') | The local service provider to resolve dependencies. Must not be null. |
| configureServicesMethod | [System.Reflection.MethodInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.MethodInfo 'System.Reflection.MethodInfo') | The method whose parameters need to be resolved. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if a required service cannot be resolved. |

##### Remarks

This method resolves the parameters of a method by retrieving the required services from the local service provider.

<a name='M-Bb-Extensions-StartupExtensions-TestExist``1-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### TestExist\`\`1(self) `method`

##### Summary

Checks if a specific service type exists in the service collection.

##### Returns

`true` if the service type exists; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | The [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to check. Must not be null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the service to check for. |

##### Example

```C#
var services = new ServiceCollection();
bool exists = services.TestExist&lt;IMyService&gt;();
Console.WriteLine($"Service exists: {exists}");
```

##### Remarks

This method iterates through the service collection to determine if a specific service type has been registered.

<a name='M-Bb-Extensions-StartupExtensions-UseStartupConfigure``1-Microsoft-AspNetCore-Builder-WebApplication,``0,Bb-ComponentModel-Factories-LocalServiceProvider-'></a>
### UseStartupConfigure\`\`1(application,startup,serviceProvider) `method`

##### Summary

Configures the web application using a specified startup class.

##### Returns

The configured [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| application | [Microsoft.AspNetCore.Builder.WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') | The [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') instance to configure. Must not be null. |
| startup | [\`\`0](#T-``0 '``0') | The instance of the startup class. Must not be null. |
| serviceProvider | [Bb.ComponentModel.Factories.LocalServiceProvider](#T-Bb-ComponentModel-Factories-LocalServiceProvider 'Bb.ComponentModel.Factories.LocalServiceProvider') | The local service provider to resolve dependencies. Must not be null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStartup | The type of the startup class. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var application = builder.Build();
var startup = new MyStartup();
application.UseStartupConfigure(startup, new LocalServiceProvider());
application.Run();
```

##### Remarks

This method invokes the "Configure" method of the specified startup class to configure the application's request pipeline.

<a name='M-Bb-Extensions-StartupExtensions-UseStartup``1-Microsoft-AspNetCore-Builder-WebApplicationBuilder,``0,Bb-ComponentModel-Factories-LocalServiceProvider-'></a>
### UseStartup\`\`1(builder,startup,serviceProvider) `method`

##### Summary

Configures the web application builder using a specified startup class.

##### Returns

The configured [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') | The [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance to configure. Must not be null. |
| startup | [\`\`0](#T-``0 '``0') | The instance of the startup class. Must not be null. |
| serviceProvider | [Bb.ComponentModel.Factories.LocalServiceProvider](#T-Bb-ComponentModel-Factories-LocalServiceProvider 'Bb.ComponentModel.Factories.LocalServiceProvider') | The local service provider to resolve dependencies. Must not be null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TStartup | The type of the startup class. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var startup = new MyStartup();
builder.UseStartup(startup, new LocalServiceProvider());
var app = builder.Build();
app.Run();
```

##### Remarks

This method invokes the "ConfigureServices" method of the specified startup class to configure services for the application.

<a name='T-Bb-Services-TokenProvider'></a>
## TokenProvider `type`

##### Namespace

Bb.Services

##### Summary

Provides methods for validating JWT tokens and retrieving tokens based on API keys.

<a name='M-Bb-Services-TokenProvider-#ctor-Microsoft-Extensions-Caching-Memory-IMemoryCache,Bb-Services-TokenResolver-'></a>
### #ctor(cache,resolver) `constructor`

##### Summary

Initializes a new instance of the [TokenProvider](#T-Bb-Services-TokenProvider 'Bb.Services.TokenProvider') class with the specified cache and token resolver.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cache | [Microsoft.Extensions.Caching.Memory.IMemoryCache](#T-Microsoft-Extensions-Caching-Memory-IMemoryCache 'Microsoft.Extensions.Caching.Memory.IMemoryCache') |  |
| resolver | [Bb.Services.TokenResolver](#T-Bb-Services-TokenResolver 'Bb.Services.TokenResolver') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='M-Bb-Services-TokenProvider-Fetch-System-String-'></a>
### Fetch(apiKey) `method`

##### Summary

Fetches a token from the token resolver for the specified API key.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the asynchronous operation, with a result of the token as a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The API key for which to fetch the token. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown if the API key is invalid. |

##### Remarks

This method generates credentials from the API key, retrieves the token from the token resolver, and caches it.

<a name='M-Bb-Services-TokenProvider-GetTokenAsync-System-String-'></a>
### GetTokenAsync(apiKey) `method`

##### Summary

Retrieves a token asynchronously for the specified API key.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the asynchronous operation, with a result of the token as a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The API key for which to retrieve the token. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown if the API key is invalid. |

##### Example

```C#
var tokenProvider = new TokenProvider(memoryCache, tokenResolver);
var token = await tokenProvider.GetTokenAsync("myApiKey");
```

##### Remarks

This method retrieves a token from the cache if available, or fetches it from the token resolver if not.

<a name='M-Bb-Services-TokenProvider-ValidateToken-System-String,System-String,System-String,System-String-'></a>
### ValidateToken(token,secretKey,validIssuer,validAudience) `method`

##### Summary

Validates a JWT token and returns the associated principal.

##### Returns

An [IPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Principal.IPrincipal 'System.Security.Principal.IPrincipal') representing the validated token's claims, or null if validation fails.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The JWT token to validate. Must not be null or empty. |
| secretKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The secret key used to validate the token signature. Must not be null or empty. |
| validIssuer | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The expected issuer of the token. Must not be null or empty. |
| validAudience | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The expected audience of the token. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if any of the parameters are null or empty. |

##### Example

```C#
var principal = TokenProvider.ValidateToken("jwtToken", "mySecretKey", "myIssuer", "myAudience");
if (principal != null)
{
    // Token is valid
}
else
{
    // Token is invalid
}
```

##### Remarks

This method validates the provided JWT token using the specified secret key, issuer, and audience.

<a name='T-Bb-Services-TokenResolver'></a>
## TokenResolver `type`

##### Namespace

Bb.Services

##### Summary

Provides functionality to resolve and retrieve authentication tokens.

<a name='M-Bb-Services-TokenResolver-#ctor-Bb-Interfaces-IRestClientFactory,Bb-Models-StartupConfiguration-'></a>
### #ctor(restFactory,configuration) `constructor`

##### Summary

Initializes a new instance of the [TokenResolver](#T-Bb-Services-TokenResolver 'Bb.Services.TokenResolver') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| restFactory | [Bb.Interfaces.IRestClientFactory](#T-Bb-Interfaces-IRestClientFactory 'Bb.Interfaces.IRestClientFactory') | The factory to create REST clients. Must not be null. |
| configuration | [Bb.Models.StartupConfiguration](#T-Bb-Models-StartupConfiguration 'Bb.Models.StartupConfiguration') | The startup configuration containing REST client options. Must not be null. |

##### Remarks

This constructor sets up the token resolver with the necessary REST client factory and configuration.

<a name='M-Bb-Services-TokenResolver-GeTokenAsync-System-String,System-String-'></a>
### GeTokenAsync(userName,password) `method`

##### Summary

Retrieves a token asynchronously using the provided userName and password.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the asynchronous operation, with a result of [TokenResponse](#T-Bb-Http-TokenResponse 'Bb.Http.TokenResponse') containing the token details.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The userName for authentication. Must not be null or empty. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password for authentication. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the token cannot be fetched or if the configuration is invalid. |

##### Example

```C#
var tokenResolver = new TokenResolver(restClientFactory, startupConfiguration);
var tokenResponse = await tokenResolver.GeTokenAsync("userName", "password");
```

##### Remarks

This method fetches a token from the configured token URL using the provided credentials.

<a name='M-Bb-Services-TokenResolver-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the REST client for token retrieval.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the token URL or client ID is not defined in the configuration. |

##### Remarks

This method sets up the REST client using the configured token URL and client ID.

<a name='T-Bb-Extensions-TypesExtension'></a>
## TypesExtension `type`

##### Namespace

Bb.Extensions

##### Summary

Extension methods for configuring types in a web application.

<a name='M-Bb-Extensions-TypesExtension-AppendConfiguration-Microsoft-Extensions-Configuration-ConfigurationManager,Bb-ComponentModel-Factories-LocalServiceProvider-'></a>
### AppendConfiguration(configuration,serviceProvider) `method`

##### Summary

Appends configuration settings by discovering types exposed by attributes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.ConfigurationManager](#T-Microsoft-Extensions-Configuration-ConfigurationManager 'Microsoft.Extensions.Configuration.ConfigurationManager') | The [ConfigurationManager](#T-Microsoft-Extensions-Configuration-ConfigurationManager 'Microsoft.Extensions.Configuration.ConfigurationManager') instance to append configuration to. Must not be null. |
| serviceProvider | [Bb.ComponentModel.Factories.LocalServiceProvider](#T-Bb-ComponentModel-Factories-LocalServiceProvider 'Bb.ComponentModel.Factories.LocalServiceProvider') | The [LocalServiceProvider](#T-Bb-ComponentModel-Factories-LocalServiceProvider 'Bb.ComponentModel.Factories.LocalServiceProvider') used to resolve dependencies. Must not be null. |

##### Example

```C#
var configuration = new ConfigurationManager();
var serviceProvider = new LocalServiceProvider();
configuration.AppendConfiguration(serviceProvider);
```

##### Remarks

This method discovers types exposed by attributes and resolves their configurations using the provided service provider.

<a name='M-Bb-Extensions-TypesExtension-SetAllIoc-Microsoft-AspNetCore-Builder-WebApplicationBuilder,System-Func{System-Type,System-String,System-Boolean}-'></a>
### SetAllIoc(builder,filter) `method`

##### Summary

Configures the web application builder by setting up dependency injection for all discovered types.

##### Returns

The configured [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') | The [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance to configure. Must not be null. |
| filter | [System.Func{System.Type,System.String,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Type,System.String,System.Boolean}') | A filter function to determine which types to register. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
builder.SetAllIoc((type, context) =&gt; true);
var app = builder.Build();
app.Run();
```

##### Remarks

This method discovers all types with the `[ExposeClass]` attribute, binds their configurations, and registers them in the dependency injection container.

<a name='T-Bb-Services-CertificateHelpers-Unix'></a>
## Unix `type`

##### Namespace

Bb.Services.CertificateHelpers

##### Summary

Provides platform-specific methods for managing certificates on Unix-based systems.

<a name='M-Bb-Services-CertificateHelpers-Unix-LoadCertificateFromUnixStore-System-String-'></a>
### LoadCertificateFromUnixStore(subjectName) `method`

##### Summary

Loads a certificate from the Unix certificate store by subject name.

##### Returns

The loaded [X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| subjectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subject name of the certificate. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the certificate with the specified subject name is not found. |

##### Example

```C#
var certificate = CertificateHelpers.Unix.LoadCertificateFromStore("MyCertificate");
```

##### Remarks

This method retrieves a certificate from the Unix certificate store based on the subject name.

<a name='M-Bb-Services-CertificateHelpers-Unix-SetCertificateInStore-System-Security-Cryptography-X509Certificates-X509Certificate2-'></a>
### SetCertificateInStore(certificate) `method`

##### Summary

Stores a certificate in the Unix certificate store.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| certificate | [System.Security.Cryptography.X509Certificates.X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') | The certificate to store. Must not be null. |

##### Example

```C#
CertificateHelpers.Unix.StoreCertificate(certificate);
```

##### Remarks

This method adds the certificate to the Unix certificate store.

<a name='T-Bb-Services-VaultEas256Resolver'></a>
## VaultEas256Resolver `type`

##### Namespace

Bb.Services

##### Summary

Initializer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [T:Bb.Services.VaultEas256Resolver](#T-T-Bb-Services-VaultEas256Resolver 'T:Bb.Services.VaultEas256Resolver') |  |

<a name='M-Bb-Services-VaultEas256Resolver-#ctor-Microsoft-Extensions-Configuration-IConfiguration-'></a>
### #ctor(configuration) `constructor`

##### Summary

Initializer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') |  |

<a name='F-Bb-Services-VaultEas256Resolver-_secret'></a>
### _secret `constants`

##### Summary

Gets the secret value from the configuration.

##### Remarks

This field holds the secret value retrieved from the configuration using the key [_secretNameConfiguration](#F-Bb-Services-VaultEas256Resolver-_secretNameConfiguration 'Bb.Services.VaultEas256Resolver._secretNameConfiguration').

<a name='F-Bb-Services-VaultEas256Resolver-_secretNameConfiguration'></a>
### _secretNameConfiguration `constants`

##### Summary

Gets the configuration key used to retrieve the secret.

##### Remarks

This property provides the name of the configuration key used to initialize the secret.

<a name='M-Bb-Services-VaultEas256Resolver-GetSecret-System-String[]-'></a>
### GetSecret(path) `method`

##### Summary

Retrieves a secret from the vault using the specified path.

##### Returns

The decrypted secret as a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The path segments used to locate the secret. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the secret is not initialized. |

##### Example

```C#
var resolver = new VaultEas256Resolver(configuration);
var secret = resolver.GetSecret("path", "to", "secret");
```

##### Remarks

This method retrieves a secret from the vault by combining the provided path segments and decrypting the result using AES-256 encryption.

<a name='T-Bb-Loaders-WebApplicationBuilderIocInitializer'></a>
## WebApplicationBuilderIocInitializer `type`

##### Namespace

Bb.Loaders

##### Summary

Initializer

<a name='M-Bb-Loaders-WebApplicationBuilderIocInitializer-Execute-Microsoft-AspNetCore-Builder-WebApplicationBuilder-'></a>
### Execute(builder) `method`

##### Summary

Executes the IoC initializer for the web application builder.

##### Returns

`null` after configuring the builder.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') | The [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') instance to configure. Must not be null. |

##### Example

```C#
var builder = WebApplication.CreateBuilder(args);
var initializer = new WebApplicationBuilderIocInitializer();
initializer.Execute(builder);
var app = builder.Build();
app.Run();
```

##### Remarks

This method configures the web application builder by setting up dependency injection for all discovered types using the IoC container.

<a name='T-Bb-Services-WebService'></a>
## WebService `type`

##### Namespace

Bb.Services

##### Summary

Initializes and configures a web service using ASP.NET Core.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [T:Bb.Services.WebService](#T-T-Bb-Services-WebService 'T:Bb.Services.WebService') | An array of strings representing the command-line arguments. Must not be null. |

##### Example

```C#
var webService = new WebService(args);
webService.WithHttp(5000).Build().Run();
```

##### Remarks

Initializes a new instance of the [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') class.

<a name='M-Bb-Services-WebService-#ctor-System-String[]-'></a>
### #ctor(args) `constructor`

##### Summary

Initializes and configures a web service using ASP.NET Core.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | An array of strings representing the command-line arguments. Must not be null. |

##### Example

```C#
var webService = new WebService(args);
webService.WithHttp(5000).Build().Run();
```

##### Remarks

Initializes a new instance of the [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') class.

<a name='M-Bb-Services-WebService-Build-System-Action{Microsoft-AspNetCore-Builder-WebApplication}-'></a>
### Build(configure) `method`

##### Summary

Builds the web application and applies all configured actions.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configure | [System.Action{Microsoft.AspNetCore.Builder.WebApplication}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Microsoft.AspNetCore.Builder.WebApplication}') | An optional action to configure the [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') after it is built. Can be null. |

##### Example

```C#
webService.Build(app =&gt; app.UseEndpoints(endpoints =&gt; endpoints.MapControllers()));
```

##### Remarks

This method builds the web application by applying all prepared actions and configurations.

<a name='M-Bb-Services-WebService-Configure-System-Action{Microsoft-AspNetCore-Builder-WebApplication}-'></a>
### Configure(configure) `method`

##### Summary

Configures the web application with the specified action.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configure | [System.Action{Microsoft.AspNetCore.Builder.WebApplication}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Microsoft.AspNetCore.Builder.WebApplication}') | An action to configure the [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication'). Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `configure` is null. |

##### Example

```C#
webService.Configure(app =&gt; app.UseRouting());
```

##### Remarks

This method allows custom configuration of the web application after it has been built.

<a name='M-Bb-Services-WebService-Configure``1-System-Action{``0}-'></a>
### Configure\`\`1(configure) `method`

##### Summary

Configures the web application with the specified action.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configure | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | An action to configure the [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication'). Must not be null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TInjectBuilder | inject Builder |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='M-Bb-Services-WebService-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Disposes the web application and releases resources.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if the call come from dispose or not |

<a name='M-Bb-Services-WebService-Dispose'></a>
### Dispose() `method`

##### Summary

Disposes the web application and releases resources.

##### Parameters

This method has no parameters.

##### Remarks

This method disposes of the web application asynchronously and ensures proper cleanup of resources.

<a name='M-Bb-Services-WebService-GetApplication'></a>
### GetApplication() `method`

##### Summary

Retrieves the built web application instance.

##### Returns

The configured [WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') instance.

##### Parameters

This method has no parameters.

##### Example

```C#
var app = webService.GetApplication();
```

##### Remarks

This method provides access to the underlying web application instance for further customization or inspection.

<a name='M-Bb-Services-WebService-GetService-System-Type-'></a>
### GetService(serviceType) `method`

##### Summary

Retrieves a service object of the specified type from the service provider.

##### Returns

An object of the specified type, or null if the service is not available.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | The type of the service object to retrieve. Must not be null. |

##### Example

```C#
var service = webService.GetService(typeof(IMyService));
```

##### Remarks

This method resolves a service from the application's service provider.

<a name='M-Bb-Services-WebService-GetService``1'></a>
### GetService\`\`1() `method`

##### Summary

Retrieves a service object of the specified generic type from the service provider.

##### Returns

An object of the specified type, or null if the service is not available.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the service object to retrieve. |

##### Example

```C#
var myService = webService.GetService&lt;IMyService&gt;();
```

##### Remarks

This method resolves a service from the application's service provider using a generic type parameter.

<a name='M-Bb-Services-WebService-Prepare-System-Action{Microsoft-AspNetCore-Builder-WebApplicationBuilder}-'></a>
### Prepare(configure) `method`

##### Summary

Prepares the web application builder with the specified configuration action.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configure | [System.Action{Microsoft.AspNetCore.Builder.WebApplicationBuilder}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Microsoft.AspNetCore.Builder.WebApplicationBuilder}') | An action to configure the [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder'). Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `configure` is null. |

##### Example

```C#
webService.Prepare(builder =&gt; builder.Services.AddControllers());
```

##### Remarks

This method allows custom configuration of the web application builder before building the application.

<a name='M-Bb-Services-WebService-Prepare``1-System-Action{``0}-'></a>
### Prepare\`\`1(configure) `method`

##### Summary

Prepares the web application builder with a specified configuration action.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configure | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | An action to configure the `T` instance. Must not be null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the configuration builder. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `configure` is null. |

##### Example

```C#
webService.Prepare(builder =&gt; builder.AddCustomConfiguration());
```

##### Remarks

This method allows custom configuration of the web application builder using a specific builder type.

<a name='M-Bb-Services-WebService-Resolve``1'></a>
### Resolve\`\`1() `method`

##### Summary

Resolves an instance of the specified type from the service provider.

##### Returns

An instance of the specified type.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the instance to resolve. |

##### Example

```C#
var instance = webService.Resolve&lt;MyService&gt;();
```

##### Remarks

This method retrieves an instance of the specified type from the service provider, caching it for future use.

<a name='M-Bb-Services-WebService-Run'></a>
### Run() `method`

##### Summary

Runs the web application.

##### Parameters

This method has no parameters.

##### Example

```C#
webService.Run();
```

##### Remarks

This method starts the web application and blocks the calling thread until the application is stopped.

<a name='M-Bb-Services-WebService-RunAsync-System-Boolean-'></a>
### RunAsync() `method`

##### Summary

Runs the web application asynchronously.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

This method has no parameters.

##### Example

```C#
await webService.RunAsync();
```

##### Remarks

This method starts the web application and returns a task that completes when the application is stopped.

<a name='M-Bb-Services-WebService-UseStartup``1-System-Action{``0}-'></a>
### UseStartup\`\`1(action) `method`

##### Summary

Configures the web service to use a specified startup class.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{``0}') | An optional action to configure the startup instance. Can be null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the startup class. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the startup class does not contain the required methods. |

##### Example

```C#
var webService = new WebService(args);
webService.UseStartup&lt;Startup&gt;();
```

##### Remarks

This method ensures that the specified startup class contains the required "ConfigureServices" and "Configure" methods, and registers it for dependency injection.

<a name='M-Bb-Services-WebService-WithDynamicHTTP'></a>
### WithDynamicHTTP() `method`

##### Summary

Configures the web service to use HTTP dynamically with the default host.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

This method has no parameters.

##### Example

```C#
var webService = new WebService(args);
webService.WithDynamicHttp();
```

##### Remarks

This method adds a dynamic HTTP host configuration to the web service, allowing it to listen on the default host without specifying a port.

<a name='M-Bb-Services-WebService-WithDynamicHTTP-System-String-'></a>
### WithDynamicHTTP(host) `method`

##### Summary

Configures the web service to use HTTP dynamically with a specified host.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name for the dynamic HTTP configuration. Must not be null or empty. |

##### Example

```C#
var webService = new WebService(args);
webService.WithDynamicHttp("example.com");
```

##### Remarks

This method adds a dynamic HTTP host configuration to the web service, allowing it to listen on the specified host without specifying a port.

<a name='M-Bb-Services-WebService-WithDynamicHTTPS'></a>
### WithDynamicHTTPS() `method`

##### Summary

Configures the web service to use HTTPS dynamically with the default host.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

This method has no parameters.

##### Example

```C#
var webService = new WebService(args);
webService.WithDynamicHttps();
```

##### Remarks

This method adds a dynamic HTTPS host configuration to the web service, allowing it to listen on the default host without specifying a port.

<a name='M-Bb-Services-WebService-WithDynamicHTTPS-System-String-'></a>
### WithDynamicHTTPS(host) `method`

##### Summary

Configures the web service to use HTTPS dynamically with a specified host.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name for the dynamic HTTPS configuration. Must not be null or empty. |

##### Example

```C#
var webService = new WebService(args);
webService.WithDynamicHttps("example.com");
```

##### Remarks

This method adds a dynamic HTTPS host configuration to the web service, allowing it to listen on the specified host without specifying a port.

<a name='M-Bb-Services-WebService-WithHTTP-System-Nullable{System-Int32}-'></a>
### WithHTTP(port) `method`

##### Summary

Configures the web service to use HTTP with an optional port.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| port | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The port number for HTTP. Defaults to 80 if not specified. |

##### Example

```C#
webService.WithHttp(5000);
```

##### Remarks

This method adds an HTTP host configuration to the web service.

<a name='M-Bb-Services-WebService-WithHTTP-System-String,System-Nullable{System-Int32}-'></a>
### WithHTTP(host,port) `method`

##### Summary

Configures the web service to use HTTP with a specified host and optional port.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name for the HTTP configuration. Must not be null or empty. |
| port | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The port number for HTTP. Defaults to 80 if not specified. |

##### Example

```C#
var webService = new WebService(args);
webService.WithHttp("localhost", 5000);
```

##### Remarks

This method adds an HTTP host configuration to the web service, allowing it to listen on the specified host and port.

<a name='M-Bb-Services-WebService-WithHTTPS-System-Nullable{System-Int32}-'></a>
### WithHTTPS(port) `method`

##### Summary

Configures the web service to use HTTPS with an optional port.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| port | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The port number for HTTPS. Defaults to 443 if not specified. |

##### Example

```C#
webService.WithHttps(5001);
```

##### Remarks

This method adds an HTTPS host configuration to the web service.

<a name='M-Bb-Services-WebService-WithHTTPS-System-String,System-Nullable{System-Int32}-'></a>
### WithHTTPS(host,port) `method`

##### Summary

Configures the web service to use HTTPS with a specified host and optional port.

##### Returns

The configured [WebService](#T-Bb-Services-WebService 'Bb.Services.WebService') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name for the HTTPS configuration. Must not be null or empty. |
| port | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The port number for HTTPS. Defaults to 443 if not specified. |

##### Example

```C#
var webService = new WebService(args);
webService.WithHttps("localhost", 5001);
```

##### Remarks

This method adds an HTTPS host configuration to the web service, allowing it to listen on the specified host and port.

<a name='T-Bb-Services-CertificateHelpers-Windows'></a>
## Windows `type`

##### Namespace

Bb.Services.CertificateHelpers

##### Summary

Provides platform-specific methods for managing certificates on Windows.

<a name='M-Bb-Services-CertificateHelpers-Windows-LoadCertificateFromWindowsStore-System-String-'></a>
### LoadCertificateFromWindowsStore(subjectName) `method`

##### Summary

Loads a certificate from the Windows certificate store by subject name.

##### Returns

The loaded [X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| subjectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The subject name of the certificate. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the certificate with the specified subject name is not found. |

##### Example

```C#
var certificate = CertificateHelpers.Windows.LoadCertificateFromStore("MyCertificate");
```

##### Remarks

This method retrieves a certificate from the Windows certificate store based on the subject name.

<a name='M-Bb-Services-CertificateHelpers-Windows-SetCertificateInStore-System-Security-Cryptography-X509Certificates-X509Certificate2-'></a>
### SetCertificateInStore(certificate) `method`

##### Summary

Stores a certificate in the Windows certificate store.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| certificate | [System.Security.Cryptography.X509Certificates.X509Certificate2](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.X509Certificates.X509Certificate2 'System.Security.Cryptography.X509Certificates.X509Certificate2') | The certificate to store. Must not be null. |

##### Example

```C#
CertificateHelpers.Windows.StoreCertificate(certificate);
```

##### Remarks

This method adds the certificate to the Windows certificate store.
