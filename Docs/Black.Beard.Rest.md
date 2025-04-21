<a name='assembly'></a>
# Black.Beard.Rest

## Contents

- [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument')
  - [#ctor(value,name)](#M-Bb-Curls-Argument-#ctor-System-String,System-String- 'Bb.Curls.Argument.#ctor(System.String,System.String)')
  - [Name](#P-Bb-Curls-Argument-Name 'Bb.Curls.Argument.Name')
  - [Value](#P-Bb-Curls-Argument-Value 'Bb.Curls.Argument.Value')
  - [ToString()](#M-Bb-Curls-Argument-ToString 'Bb.Curls.Argument.ToString')
- [ArgumentList](#T-Bb-Curls-ArgumentList 'Bb.Curls.ArgumentList')
  - [#ctor()](#M-Bb-Curls-ArgumentList-#ctor 'Bb.Curls.ArgumentList.#ctor')
  - [#ctor(arguments)](#M-Bb-Curls-ArgumentList-#ctor-Bb-Curls-Argument[]- 'Bb.Curls.ArgumentList.#ctor(Bb.Curls.Argument[])')
  - [_arguments](#P-Bb-Curls-ArgumentList-_arguments 'Bb.Curls.ArgumentList._arguments')
  - [Add(argument)](#M-Bb-Curls-ArgumentList-Add-Bb-Curls-Argument- 'Bb.Curls.ArgumentList.Add(Bb.Curls.Argument)')
  - [GetEnumerator()](#M-Bb-Curls-ArgumentList-GetEnumerator 'Bb.Curls.ArgumentList.GetEnumerator')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-Bb-Curls-ArgumentList-System#Collections#IEnumerable#GetEnumerator 'Bb.Curls.ArgumentList.System#Collections#IEnumerable#GetEnumerator')
  - [op_Implicit(arguments)](#M-Bb-Curls-ArgumentList-op_Implicit-Bb-Curls-Argument[]-~Bb-Curls-ArgumentList 'Bb.Curls.ArgumentList.op_Implicit(Bb.Curls.Argument[])~Bb.Curls.ArgumentList')
- [ArgumentSource](#T-Bb-Curls-ArgumentSource 'Bb.Curls.ArgumentSource')
  - [#ctor(arguments)](#M-Bb-Curls-ArgumentSource-#ctor-System-String[]- 'Bb.Curls.ArgumentSource.#ctor(System.String[])')
  - [CanRead](#P-Bb-Curls-ArgumentSource-CanRead 'Bb.Curls.ArgumentSource.CanRead')
  - [Current](#P-Bb-Curls-ArgumentSource-Current 'Bb.Curls.ArgumentSource.Current')
  - [FailMessage](#P-Bb-Curls-ArgumentSource-FailMessage 'Bb.Curls.ArgumentSource.FailMessage')
  - [IsFailed](#P-Bb-Curls-ArgumentSource-IsFailed 'Bb.Curls.ArgumentSource.IsFailed')
  - [Failed(failMessage)](#M-Bb-Curls-ArgumentSource-Failed-System-String- 'Bb.Curls.ArgumentSource.Failed(System.String)')
  - [GetArgument()](#M-Bb-Curls-ArgumentSource-GetArgument 'Bb.Curls.ArgumentSource.GetArgument')
  - [ReadNext()](#M-Bb-Curls-ArgumentSource-ReadNext 'Bb.Curls.ArgumentSource.ReadNext')
- [Bag\`1](#T-Bb-Services-Bag`1 'Bb.Services.Bag`1')
  - [#ctor()](#M-Bb-Services-Bag`1-#ctor 'Bb.Services.Bag`1.#ctor')
  - [Value](#P-Bb-Services-Bag`1-Value 'Bb.Services.Bag`1.Value')
- [ClientRestOption](#T-Bb-Services-ClientRestOption 'Bb.Services.ClientRestOption')
  - [#ctor()](#M-Bb-Services-ClientRestOption-#ctor 'Bb.Services.ClientRestOption.#ctor')
  - [AllowMultipleDefaultParametersWithSameName](#P-Bb-Services-ClientRestOption-AllowMultipleDefaultParametersWithSameName 'Bb.Services.ClientRestOption.AllowMultipleDefaultParametersWithSameName')
  - [AutomaticDecompression](#P-Bb-Services-ClientRestOption-AutomaticDecompression 'Bb.Services.ClientRestOption.AutomaticDecompression')
  - [Debug](#P-Bb-Services-ClientRestOption-Debug 'Bb.Services.ClientRestOption.Debug')
  - [DisableCharset](#P-Bb-Services-ClientRestOption-DisableCharset 'Bb.Services.ClientRestOption.DisableCharset')
  - [Expect100Continue](#P-Bb-Services-ClientRestOption-Expect100Continue 'Bb.Services.ClientRestOption.Expect100Continue')
  - [FailOnDeserializationError](#P-Bb-Services-ClientRestOption-FailOnDeserializationError 'Bb.Services.ClientRestOption.FailOnDeserializationError')
  - [FollowRedirects](#P-Bb-Services-ClientRestOption-FollowRedirects 'Bb.Services.ClientRestOption.FollowRedirects')
  - [MaxRedirects](#P-Bb-Services-ClientRestOption-MaxRedirects 'Bb.Services.ClientRestOption.MaxRedirects')
  - [PreAuthenticate](#P-Bb-Services-ClientRestOption-PreAuthenticate 'Bb.Services.ClientRestOption.PreAuthenticate')
  - [ThrowOnAnyError](#P-Bb-Services-ClientRestOption-ThrowOnAnyError 'Bb.Services.ClientRestOption.ThrowOnAnyError')
  - [ThrowOnDeSerializationError](#P-Bb-Services-ClientRestOption-ThrowOnDeSerializationError 'Bb.Services.ClientRestOption.ThrowOnDeSerializationError')
  - [Timeout](#P-Bb-Services-ClientRestOption-Timeout 'Bb.Services.ClientRestOption.Timeout')
  - [Trace](#P-Bb-Services-ClientRestOption-Trace 'Bb.Services.ClientRestOption.Trace')
  - [UseDefaultCredentials](#P-Bb-Services-ClientRestOption-UseDefaultCredentials 'Bb.Services.ClientRestOption.UseDefaultCredentials')
- [CommonExtensions](#T-Bb-Urls-CommonExtensions 'Bb.Urls.CommonExtensions')
  - [IsIP()](#M-Bb-Urls-CommonExtensions-IsIP-System-String- 'Bb.Urls.CommonExtensions.IsIP(System.String)')
  - [Merge\`\`2()](#M-Bb-Urls-CommonExtensions-Merge``2-System-Collections-Generic-IDictionary{``0,``1},System-Collections-Generic-IDictionary{``0,``1}- 'Bb.Urls.CommonExtensions.Merge``2(System.Collections.Generic.IDictionary{``0,``1},System.Collections.Generic.IDictionary{``0,``1})')
  - [SplitOnFirstOccurrence(s,separator)](#M-Bb-Urls-CommonExtensions-SplitOnFirstOccurrence-System-String,System-String- 'Bb.Urls.CommonExtensions.SplitOnFirstOccurrence(System.String,System.String)')
  - [StripQuotes()](#M-Bb-Urls-CommonExtensions-StripQuotes-System-String- 'Bb.Urls.CommonExtensions.StripQuotes(System.String)')
  - [ToInvariantString()](#M-Bb-Urls-CommonExtensions-ToInvariantString-System-Object- 'Bb.Urls.CommonExtensions.ToInvariantString(System.Object)')
  - [ToKeyValuePairs(obj)](#M-Bb-Urls-CommonExtensions-ToKeyValuePairs-System-Object- 'Bb.Urls.CommonExtensions.ToKeyValuePairs(System.Object)')
- [ContentTypes](#T-Bb-Util-ContentTypes 'Bb.Util.ContentTypes')
  - [ApplicationJson](#P-Bb-Util-ContentTypes-ApplicationJson 'Bb.Util.ContentTypes.ApplicationJson')
  - [ApplicationxWwwFormUrlencoded](#P-Bb-Util-ContentTypes-ApplicationxWwwFormUrlencoded 'Bb.Util.ContentTypes.ApplicationxWwwFormUrlencoded')
  - [CharsetUtf8](#P-Bb-Util-ContentTypes-CharsetUtf8 'Bb.Util.ContentTypes.CharsetUtf8')
- [Curl](#T-Bb-Curls-Curl 'Bb.Curls.Curl')
  - [#ctor(factory)](#M-Bb-Curls-Curl-#ctor-Bb-Interfaces-IRestClientFactory- 'Bb.Curls.Curl.#ctor(Bb.Interfaces.IRestClientFactory)')
  - [CallAsync()](#M-Bb-Curls-Curl-CallAsync 'Bb.Curls.Curl.CallAsync')
  - [CallAsync\`\`1()](#M-Bb-Curls-Curl-CallAsync``1 'Bb.Curls.Curl.CallAsync``1')
  - [CallStreamAsync()](#M-Bb-Curls-Curl-CallStreamAsync 'Bb.Curls.Curl.CallStreamAsync')
  - [GetArgument()](#M-Bb-Curls-Curl-GetArgument 'Bb.Curls.Curl.GetArgument')
  - [LastChance(resolveVariables)](#M-Bb-Curls-Curl-LastChance-System-Func{System-String,System-Object}- 'Bb.Curls.Curl.LastChance(System.Func{System.String,System.Object})')
  - [WithCancellation(cancellationTokenSource)](#M-Bb-Curls-Curl-WithCancellation-System-Threading-CancellationTokenSource- 'Bb.Curls.Curl.WithCancellation(System.Threading.CancellationTokenSource)')
  - [WithCommand(command)](#M-Bb-Curls-Curl-WithCommand-System-String- 'Bb.Curls.Curl.WithCommand(System.String)')
  - [WithConfig(configureRequest)](#M-Bb-Curls-Curl-WithConfig-System-Action{RestSharp-RestRequest}- 'Bb.Curls.Curl.WithConfig(System.Action{RestSharp.RestRequest})')
  - [WithMap(name,value)](#M-Bb-Curls-Curl-WithMap-System-String,System-Object- 'Bb.Curls.Curl.WithMap(System.String,System.Object)')
- [CurlContext](#T-Bb-Curls-CurlContext 'Bb.Curls.CurlContext')
  - [#ctor()](#M-Bb-Curls-CurlContext-#ctor 'Bb.Curls.CurlContext.#ctor')
  - [Headers](#P-Bb-Curls-CurlContext-Headers 'Bb.Curls.CurlContext.Headers')
  - [Request](#P-Bb-Curls-CurlContext-Request 'Bb.Curls.CurlContext.Request')
  - [Url](#P-Bb-Curls-CurlContext-Url 'Bb.Curls.CurlContext.Url')
- [CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter')
  - [#ctor(arguments)](#M-Bb-Curls-CurlInterpreter-#ctor-System-String[]- 'Bb.Curls.CurlInterpreter.#ctor(System.String[])')
  - [ConfigureRequest](#P-Bb-Curls-CurlInterpreter-ConfigureRequest 'Bb.Curls.CurlInterpreter.ConfigureRequest')
  - [IsFailed](#P-Bb-Curls-CurlInterpreter-IsFailed 'Bb.Curls.CurlInterpreter.IsFailed')
  - [ResultMessage](#P-Bb-Curls-CurlInterpreter-ResultMessage 'Bb.Curls.CurlInterpreter.ResultMessage')
- [CurlInterpreterAction](#T-Bb-Curls-CurlInterpreterAction 'Bb.Curls.CurlInterpreterAction')
  - [#ctor(configureAction,arguments)](#M-Bb-Curls-CurlInterpreterAction-#ctor-System-Action{Bb-Curls-CurlInterpreterAction,Bb-Curls-CurlContext},Bb-Curls-Argument[]- 'Bb.Curls.CurlInterpreterAction.#ctor(System.Action{Bb.Curls.CurlInterpreterAction,Bb.Curls.CurlContext},Bb.Curls.Argument[])')
  - [Arguments](#P-Bb-Curls-CurlInterpreterAction-Arguments 'Bb.Curls.CurlInterpreterAction.Arguments')
  - [First](#P-Bb-Curls-CurlInterpreterAction-First 'Bb.Curls.CurlInterpreterAction.First')
  - [FirstValue](#P-Bb-Curls-CurlInterpreterAction-FirstValue 'Bb.Curls.CurlInterpreterAction.FirstValue')
  - [Priority](#P-Bb-Curls-CurlInterpreterAction-Priority 'Bb.Curls.CurlInterpreterAction.Priority')
  - [Exists(name)](#M-Bb-Curls-CurlInterpreterAction-Exists-System-String- 'Bb.Curls.CurlInterpreterAction.Exists(System.String)')
  - [Get(name)](#M-Bb-Curls-CurlInterpreterAction-Get-System-String- 'Bb.Curls.CurlInterpreterAction.Get(System.String)')
  - [Get(test)](#M-Bb-Curls-CurlInterpreterAction-Get-System-Func{Bb-Curls-Argument,System-Boolean}- 'Bb.Curls.CurlInterpreterAction.Get(System.Func{Bb.Curls.Argument,System.Boolean})')
- [CurlLexer](#T-Bb-Curls-CurlLexer 'Bb.Curls.CurlLexer')
  - [#ctor(args)](#M-Bb-Curls-CurlLexer-#ctor-System-String- 'Bb.Curls.CurlLexer.#ctor(System.String)')
  - [Current](#P-Bb-Curls-CurlLexer-Current 'Bb.Curls.CurlLexer.Current')
  - [CurrentPosition](#P-Bb-Curls-CurlLexer-CurrentPosition 'Bb.Curls.CurlLexer.CurrentPosition')
  - [Next()](#M-Bb-Curls-CurlLexer-Next 'Bb.Curls.CurlLexer.Next')
  - [ParseTextChain(charset)](#M-Bb-Curls-CurlLexer-ParseTextChain-System-Char- 'Bb.Curls.CurlLexer.ParseTextChain(System.Char)')
- [CurlParserExtension](#T-Bb-Curls-CurlParserExtension 'Bb.Curls.CurlParserExtension')
  - [#cctor()](#M-Bb-Curls-CurlParserExtension-#cctor 'Bb.Curls.CurlParserExtension.#cctor')
  - [AsCurl(self,factory)](#M-Bb-Curls-CurlParserExtension-AsCurl-System-String,Bb-Interfaces-IRestClientFactory- 'Bb.Curls.CurlParserExtension.AsCurl(System.String,Bb.Interfaces.IRestClientFactory)')
  - [IsUrl(self)](#M-Bb-Curls-CurlParserExtension-IsUrl-System-String- 'Bb.Curls.CurlParserExtension.IsUrl(System.String)')
  - [ParseCurlLine(lineArg)](#M-Bb-Curls-CurlParserExtension-ParseCurlLine-System-String- 'Bb.Curls.CurlParserExtension.ParseCurlLine(System.String)')
- [GlobalSettings](#T-Bb-GlobalSettings 'Bb.GlobalSettings')
  - [#ctor()](#M-Bb-GlobalSettings-#ctor 'Bb.GlobalSettings.#ctor')
  - [CreateFactory](#P-Bb-GlobalSettings-CreateFactory 'Bb.GlobalSettings.CreateFactory')
  - [OptionFactory](#P-Bb-GlobalSettings-OptionFactory 'Bb.GlobalSettings.OptionFactory')
  - [ServiceProvider](#P-Bb-GlobalSettings-ServiceProvider 'Bb.GlobalSettings.ServiceProvider')
  - [UrlClientFactory](#P-Bb-GlobalSettings-UrlClientFactory 'Bb.GlobalSettings.UrlClientFactory')
- [Headers](#T-Bb-Curls-Headers 'Bb.Curls.Headers')
  - [Add(header,value)](#M-Bb-Curls-Headers-Add-System-String,System-String- 'Bb.Curls.Headers.Add(System.String,System.String)')
  - [AddOrReplace(header,value)](#M-Bb-Curls-Headers-AddOrReplace-System-String,System-String- 'Bb.Curls.Headers.AddOrReplace(System.String,System.String)')
  - [Contains(header)](#M-Bb-Curls-Headers-Contains-System-String- 'Bb.Curls.Headers.Contains(System.String)')
  - [TryGetFirst(header,result)](#M-Bb-Curls-Headers-TryGetFirst-System-String,System-String@- 'Bb.Curls.Headers.TryGetFirst(System.String,System.String@)')
- [IFactory](#T-Bb-Interfaces-IFactory 'Bb.Interfaces.IFactory')
- [INameValueListBase\`1](#T-Bb-Urls-INameValueListBase`1 'Bb.Urls.INameValueListBase`1')
  - [Contains()](#M-Bb-Urls-INameValueListBase`1-Contains-System-String- 'Bb.Urls.INameValueListBase`1.Contains(System.String)')
  - [Contains()](#M-Bb-Urls-INameValueListBase`1-Contains-System-String,`0- 'Bb.Urls.INameValueListBase`1.Contains(System.String,`0)')
  - [FirstOrDefault()](#M-Bb-Urls-INameValueListBase`1-FirstOrDefault-System-String- 'Bb.Urls.INameValueListBase`1.FirstOrDefault(System.String)')
  - [GetAll()](#M-Bb-Urls-INameValueListBase`1-GetAll-System-String- 'Bb.Urls.INameValueListBase`1.GetAll(System.String)')
  - [TryGetFirst()](#M-Bb-Urls-INameValueListBase`1-TryGetFirst-System-String,`0@- 'Bb.Urls.INameValueListBase`1.TryGetFirst(System.String,`0@)')
- [INameValueList\`1](#T-Bb-Urls-INameValueList`1 'Bb.Urls.INameValueList`1')
  - [Add()](#M-Bb-Urls-INameValueList`1-Add-System-String,`0- 'Bb.Urls.INameValueList`1.Add(System.String,`0)')
  - [AddOrReplace()](#M-Bb-Urls-INameValueList`1-AddOrReplace-System-String,`0- 'Bb.Urls.INameValueList`1.AddOrReplace(System.String,`0)')
  - [Remove()](#M-Bb-Urls-INameValueList`1-Remove-System-String- 'Bb.Urls.INameValueList`1.Remove(System.String)')
- [INamedFactory\`2](#T-Bb-Interfaces-INamedFactory`2 'Bb.Interfaces.INamedFactory`2')
  - [Create(name)](#M-Bb-Interfaces-INamedFactory`2-Create-`0- 'Bb.Interfaces.INamedFactory`2.Create(`0)')
- [IOptionClientFactory](#T-Bb-Interfaces-IOptionClientFactory 'Bb.Interfaces.IOptionClientFactory')
  - [Interceptor](#P-Bb-Interfaces-IOptionClientFactory-Interceptor 'Bb.Interfaces.IOptionClientFactory.Interceptor')
- [IReadOnlyNameValueList\`1](#T-Bb-Urls-IReadOnlyNameValueList`1 'Bb.Urls.IReadOnlyNameValueList`1')
- [IRestClientFactory](#T-Bb-Interfaces-IRestClientFactory 'Bb.Interfaces.IRestClientFactory')
- [LocalLogger](#T-Bb-Services-LocalLogger 'Bb.Services.LocalLogger')
  - [#ctor(categoryName)](#M-Bb-Services-LocalLogger-#ctor-System-String- 'Bb.Services.LocalLogger.#ctor(System.String)')
  - [#ctor(categoryName,writer)](#M-Bb-Services-LocalLogger-#ctor-System-String,System-IO-TextWriter- 'Bb.Services.LocalLogger.#ctor(System.String,System.IO.TextWriter)')
  - [Level](#P-Bb-Services-LocalLogger-Level 'Bb.Services.LocalLogger.Level')
  - [BeginScope\`\`1(state)](#M-Bb-Services-LocalLogger-BeginScope``1-``0- 'Bb.Services.LocalLogger.BeginScope``1(``0)')
  - [GetLogLevelString(logLevel)](#M-Bb-Services-LocalLogger-GetLogLevelString-Microsoft-Extensions-Logging-LogLevel- 'Bb.Services.LocalLogger.GetLogLevelString(Microsoft.Extensions.Logging.LogLevel)')
  - [IsEnabled(logLevel)](#M-Bb-Services-LocalLogger-IsEnabled-Microsoft-Extensions-Logging-LogLevel- 'Bb.Services.LocalLogger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)')
  - [Log\`\`1(logLevel,eventId,state,exception,formatter)](#M-Bb-Services-LocalLogger-Log``1-Microsoft-Extensions-Logging-LogLevel,Microsoft-Extensions-Logging-EventId,``0,System-Exception,System-Func{``0,System-Exception,System-String}- 'Bb.Services.LocalLogger.Log``1(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,``0,System.Exception,System.Func{``0,System.Exception,System.String})')
- [LocalLogger\`1](#T-Bb-Services-LocalLogger`1 'Bb.Services.LocalLogger`1')
  - [#ctor()](#M-Bb-Services-LocalLogger`1-#ctor 'Bb.Services.LocalLogger`1.#ctor')
  - [#ctor(writer)](#M-Bb-Services-LocalLogger`1-#ctor-System-IO-TextWriter- 'Bb.Services.LocalLogger`1.#ctor(System.IO.TextWriter)')
- [LogConfigurationExtension](#T-Bb-Helpers-LogConfigurationExtension 'Bb.Helpers.LogConfigurationExtension')
  - [LogAll(self)](#M-Bb-Helpers-LogConfigurationExtension-LogAll-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}- 'Bb.Helpers.LogConfigurationExtension.LogAll(Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage})')
  - [LogAll(self)](#M-Bb-Helpers-LogConfigurationExtension-LogAll-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage}- 'Bb.Helpers.LogConfigurationExtension.LogAll(Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage})')
  - [LogBody(self)](#M-Bb-Helpers-LogConfigurationExtension-LogBody-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}- 'Bb.Helpers.LogConfigurationExtension.LogBody(Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage})')
  - [LogBody(self)](#M-Bb-Helpers-LogConfigurationExtension-LogBody-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage}- 'Bb.Helpers.LogConfigurationExtension.LogBody(Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage})')
  - [LogHeader(self)](#M-Bb-Helpers-LogConfigurationExtension-LogHeader-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}- 'Bb.Helpers.LogConfigurationExtension.LogHeader(Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage})')
  - [LogHeader(self)](#M-Bb-Helpers-LogConfigurationExtension-LogHeader-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage}- 'Bb.Helpers.LogConfigurationExtension.LogHeader(Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage})')
  - [LogStart(self)](#M-Bb-Helpers-LogConfigurationExtension-LogStart-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}- 'Bb.Helpers.LogConfigurationExtension.LogStart(Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage})')
- [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1')
  - [#ctor()](#M-Bb-Interceptors-LogConfiguration`1-#ctor 'Bb.Interceptors.LogConfiguration`1.#ctor')
  - [_rules](#F-Bb-Interceptors-LogConfiguration`1-_rules 'Bb.Interceptors.LogConfiguration`1._rules')
  - [HasRule](#P-Bb-Interceptors-LogConfiguration`1-HasRule 'Bb.Interceptors.LogConfiguration`1.HasRule')
  - [AddRule(rule)](#M-Bb-Interceptors-LogConfiguration`1-AddRule-System-Func{`0,System-Text-StringBuilder,System-Threading-CancellationToken,System-Threading-Tasks-ValueTask}- 'Bb.Interceptors.LogConfiguration`1.AddRule(System.Func{`0,System.Text.StringBuilder,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask})')
  - [Log(message,logger,cancellationToken)](#M-Bb-Interceptors-LogConfiguration`1-Log-`0,System-Text-StringBuilder,System-Threading-CancellationToken- 'Bb.Interceptors.LogConfiguration`1.Log(`0,System.Text.StringBuilder,System.Threading.CancellationToken)')
- [LogInterceptor](#T-Bb-Interceptors-LogInterceptor 'Bb.Interceptors.LogInterceptor')
  - [#ctor(configurationRequest,configurationResponse,logger)](#M-Bb-Interceptors-LogInterceptor-#ctor-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage},Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage},Microsoft-Extensions-Logging-ILogger- 'Bb.Interceptors.LogInterceptor.#ctor(Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage},Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage},Microsoft.Extensions.Logging.ILogger)')
  - [CurrentLogger](#P-Bb-Interceptors-LogInterceptor-CurrentLogger 'Bb.Interceptors.LogInterceptor.CurrentLogger')
  - [AfterHttpRequest(responseMessage,cancellationToken)](#M-Bb-Interceptors-LogInterceptor-AfterHttpRequest-System-Net-Http-HttpResponseMessage,System-Threading-CancellationToken- 'Bb.Interceptors.LogInterceptor.AfterHttpRequest(System.Net.Http.HttpResponseMessage,System.Threading.CancellationToken)')
  - [BeforeHttpRequest(requestMessage,cancellationToken)](#M-Bb-Interceptors-LogInterceptor-BeforeHttpRequest-System-Net-Http-HttpRequestMessage,System-Threading-CancellationToken- 'Bb.Interceptors.LogInterceptor.BeforeHttpRequest(System.Net.Http.HttpRequestMessage,System.Threading.CancellationToken)')
  - [CreateLogger()](#M-Bb-Interceptors-LogInterceptor-CreateLogger 'Bb.Interceptors.LogInterceptor.CreateLogger')
- [MissingVariableException](#T-Bb-Exceptions-MissingVariableException 'Bb.Exceptions.MissingVariableException')
  - [#ctor()](#M-Bb-Exceptions-MissingVariableException-#ctor 'Bb.Exceptions.MissingVariableException.#ctor')
  - [#ctor(message)](#M-Bb-Exceptions-MissingVariableException-#ctor-System-String- 'Bb.Exceptions.MissingVariableException.#ctor(System.String)')
  - [#ctor(message,inner)](#M-Bb-Exceptions-MissingVariableException-#ctor-System-String,System-Exception- 'Bb.Exceptions.MissingVariableException.#ctor(System.String,System.Exception)')
- [NameValueList\`1](#T-Bb-Urls-NameValueList`1 'Bb.Urls.NameValueList`1')
  - [#ctor(caseSensitiveNames)](#M-Bb-Urls-NameValueList`1-#ctor-System-Boolean- 'Bb.Urls.NameValueList`1.#ctor(System.Boolean)')
  - [#ctor(items,caseSensitiveNames)](#M-Bb-Urls-NameValueList`1-#ctor-System-Collections-Generic-IEnumerable{System-ValueTuple{System-String,`0}},System-Boolean- 'Bb.Urls.NameValueList`1.#ctor(System.Collections.Generic.IEnumerable{System.ValueTuple{System.String,`0}},System.Boolean)')
  - [Add(name,value)](#M-Bb-Urls-NameValueList`1-Add-System-String,`0- 'Bb.Urls.NameValueList`1.Add(System.String,`0)')
  - [AddOrReplace(name,value)](#M-Bb-Urls-NameValueList`1-AddOrReplace-System-String,`0- 'Bb.Urls.NameValueList`1.AddOrReplace(System.String,`0)')
  - [Contains(name)](#M-Bb-Urls-NameValueList`1-Contains-System-String- 'Bb.Urls.NameValueList`1.Contains(System.String)')
  - [Contains(name,value)](#M-Bb-Urls-NameValueList`1-Contains-System-String,`0- 'Bb.Urls.NameValueList`1.Contains(System.String,`0)')
  - [FirstOrDefault(name)](#M-Bb-Urls-NameValueList`1-FirstOrDefault-System-String- 'Bb.Urls.NameValueList`1.FirstOrDefault(System.String)')
  - [GetAll(name)](#M-Bb-Urls-NameValueList`1-GetAll-System-String- 'Bb.Urls.NameValueList`1.GetAll(System.String)')
  - [Remove(name)](#M-Bb-Urls-NameValueList`1-Remove-System-String- 'Bb.Urls.NameValueList`1.Remove(System.String)')
  - [TryGetFirst(name,value)](#M-Bb-Urls-NameValueList`1-TryGetFirst-System-String,`0@- 'Bb.Urls.NameValueList`1.TryGetFirst(System.String,`0@)')
- [NoopDisposable](#T-Bb-Services-LocalLogger-NoopDisposable 'Bb.Services.LocalLogger.NoopDisposable')
- [NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling')
  - [Ignore](#F-Bb-NullValueHandling-Ignore 'Bb.NullValueHandling.Ignore')
  - [NameOnly](#F-Bb-NullValueHandling-NameOnly 'Bb.NullValueHandling.NameOnly')
  - [Remove](#F-Bb-NullValueHandling-Remove 'Bb.NullValueHandling.Remove')
- [OptionClientFactory](#T-Bb-Services-OptionClientFactory 'Bb.Services.OptionClientFactory')
  - [#ctor()](#M-Bb-Services-OptionClientFactory-#ctor 'Bb.Services.OptionClientFactory.#ctor')
  - [#ctor(serviceProvider)](#M-Bb-Services-OptionClientFactory-#ctor-System-IServiceProvider- 'Bb.Services.OptionClientFactory.#ctor(System.IServiceProvider)')
  - [#ctor(configuration)](#M-Bb-Services-OptionClientFactory-#ctor-Microsoft-Extensions-Options-IOptions{Bb-Services-ClientRestOption}- 'Bb.Services.OptionClientFactory.#ctor(Microsoft.Extensions.Options.IOptions{Bb.Services.ClientRestOption})')
  - [Interceptor](#P-Bb-Services-OptionClientFactory-Interceptor 'Bb.Services.OptionClientFactory.Interceptor')
  - [Configure(url,action)](#M-Bb-Services-OptionClientFactory-Configure-Bb-Urls-Url,System-Action{RestSharp-RestClientOptions}- 'Bb.Services.OptionClientFactory.Configure(Bb.Urls.Url,System.Action{RestSharp.RestClientOptions})')
  - [Configure(uri,action)](#M-Bb-Services-OptionClientFactory-Configure-System-Uri,System-Action{RestSharp-RestClientOptions}- 'Bb.Services.OptionClientFactory.Configure(System.Uri,System.Action{RestSharp.RestClientOptions})')
  - [Configure(name,action)](#M-Bb-Services-OptionClientFactory-Configure-System-String,System-Action{RestSharp-RestClientOptions}- 'Bb.Services.OptionClientFactory.Configure(System.String,System.Action{RestSharp.RestClientOptions})')
  - [Create(name)](#M-Bb-Services-OptionClientFactory-Create-System-String- 'Bb.Services.OptionClientFactory.Create(System.String)')
  - [TraceLog(options)](#M-Bb-Services-OptionClientFactory-TraceLog-RestSharp-RestClientOptions- 'Bb.Services.OptionClientFactory.TraceLog(RestSharp.RestClientOptions)')
- [QueryParamCollection](#T-Bb-Urls-QueryParamCollection 'Bb.Urls.QueryParamCollection')
  - [#ctor(query)](#M-Bb-Urls-QueryParamCollection-#ctor-System-String- 'Bb.Urls.QueryParamCollection.#ctor(System.String)')
  - [Count](#P-Bb-Urls-QueryParamCollection-Count 'Bb.Urls.QueryParamCollection.Count')
  - [Item](#P-Bb-Urls-QueryParamCollection-Item-System-Int32- 'Bb.Urls.QueryParamCollection.Item(System.Int32)')
  - [Add(name,value,nullValueHandling)](#M-Bb-Urls-QueryParamCollection-Add-System-String,System-Object,Bb-NullValueHandling- 'Bb.Urls.QueryParamCollection.Add(System.String,System.Object,Bb.NullValueHandling)')
  - [AddOrReplace(name,value,nullValueHandling)](#M-Bb-Urls-QueryParamCollection-AddOrReplace-System-String,System-Object,Bb-NullValueHandling- 'Bb.Urls.QueryParamCollection.AddOrReplace(System.String,System.Object,Bb.NullValueHandling)')
  - [Clear()](#M-Bb-Urls-QueryParamCollection-Clear 'Bb.Urls.QueryParamCollection.Clear')
  - [Contains()](#M-Bb-Urls-QueryParamCollection-Contains-System-String- 'Bb.Urls.QueryParamCollection.Contains(System.String)')
  - [Contains()](#M-Bb-Urls-QueryParamCollection-Contains-System-String,Bb-Urls-QueryParamValue- 'Bb.Urls.QueryParamCollection.Contains(System.String,Bb.Urls.QueryParamValue)')
  - [FirstOrDefault()](#M-Bb-Urls-QueryParamCollection-FirstOrDefault-System-String- 'Bb.Urls.QueryParamCollection.FirstOrDefault(System.String)')
  - [GetAll()](#M-Bb-Urls-QueryParamCollection-GetAll-System-String- 'Bb.Urls.QueryParamCollection.GetAll(System.String)')
  - [GetEnumerator()](#M-Bb-Urls-QueryParamCollection-GetEnumerator 'Bb.Urls.QueryParamCollection.GetEnumerator')
  - [Remove()](#M-Bb-Urls-QueryParamCollection-Remove-System-String- 'Bb.Urls.QueryParamCollection.Remove(System.String)')
  - [ToString()](#M-Bb-Urls-QueryParamCollection-ToString 'Bb.Urls.QueryParamCollection.ToString')
  - [ToString()](#M-Bb-Urls-QueryParamCollection-ToString-System-Boolean- 'Bb.Urls.QueryParamCollection.ToString(System.Boolean)')
  - [TryGetFirst()](#M-Bb-Urls-QueryParamCollection-TryGetFirst-System-String,Bb-Urls-QueryParamValue@- 'Bb.Urls.QueryParamCollection.TryGetFirst(System.String,Bb.Urls.QueryParamValue@)')
  - [op_Implicit(query)](#M-Bb-Urls-QueryParamCollection-op_Implicit-Bb-Urls-QueryParamCollection-~System-String 'Bb.Urls.QueryParamCollection.op_Implicit(Bb.Urls.QueryParamCollection)~System.String')
- [QueryParamValue](#T-Bb-Urls-QueryParamValue 'Bb.Urls.QueryParamValue')
  - [#ctor(value)](#M-Bb-Urls-QueryParamValue-#ctor-System-Object- 'Bb.Urls.QueryParamValue.#ctor(System.Object)')
  - [#ctor(value)](#M-Bb-Urls-QueryParamValue-#ctor-System-String- 'Bb.Urls.QueryParamValue.#ctor(System.String)')
  - [HasValue](#P-Bb-Urls-QueryParamValue-HasValue 'Bb.Urls.QueryParamValue.HasValue')
  - [IsVariable](#P-Bb-Urls-QueryParamValue-IsVariable 'Bb.Urls.QueryParamValue.IsVariable')
  - [Value](#P-Bb-Urls-QueryParamValue-Value 'Bb.Urls.QueryParamValue.Value')
  - [EncodedValue()](#M-Bb-Urls-QueryParamValue-EncodedValue-System-Boolean- 'Bb.Urls.QueryParamValue.EncodedValue(System.Boolean)')
  - [ToString()](#M-Bb-Urls-QueryParamValue-ToString 'Bb.Urls.QueryParamValue.ToString')
  - [op_Implicit(value)](#M-Bb-Urls-QueryParamValue-op_Implicit-Bb-Urls-QueryParamValue-~System-String 'Bb.Urls.QueryParamValue.op_Implicit(Bb.Urls.QueryParamValue)~System.String')
- [RequestMessageInterceptor](#T-Bb-Interceptors-RequestMessageInterceptor 'Bb.Interceptors.RequestMessageInterceptor')
  - [#ctor(action)](#M-Bb-Interceptors-RequestMessageInterceptor-#ctor-System-Action{System-Net-Http-HttpRequestMessage}- 'Bb.Interceptors.RequestMessageInterceptor.#ctor(System.Action{System.Net.Http.HttpRequestMessage})')
  - [_action](#F-Bb-Interceptors-RequestMessageInterceptor-_action 'Bb.Interceptors.RequestMessageInterceptor._action')
  - [AfterHttpRequest(responseMessage,cancellationToken)](#M-Bb-Interceptors-RequestMessageInterceptor-AfterHttpRequest-System-Net-Http-HttpResponseMessage,System-Threading-CancellationToken- 'Bb.Interceptors.RequestMessageInterceptor.AfterHttpRequest(System.Net.Http.HttpResponseMessage,System.Threading.CancellationToken)')
  - [BeforeHttpRequest(requestMessage,cancellationToken)](#M-Bb-Interceptors-RequestMessageInterceptor-BeforeHttpRequest-System-Net-Http-HttpRequestMessage,System-Threading-CancellationToken- 'Bb.Interceptors.RequestMessageInterceptor.BeforeHttpRequest(System.Net.Http.HttpRequestMessage,System.Threading.CancellationToken)')
- [ResponseMessageInterceptor](#T-Bb-Interceptors-ResponseMessageInterceptor 'Bb.Interceptors.ResponseMessageInterceptor')
  - [#ctor(action)](#M-Bb-Interceptors-ResponseMessageInterceptor-#ctor-System-Action{System-Net-Http-HttpResponseMessage}- 'Bb.Interceptors.ResponseMessageInterceptor.#ctor(System.Action{System.Net.Http.HttpResponseMessage})')
  - [_action](#F-Bb-Interceptors-ResponseMessageInterceptor-_action 'Bb.Interceptors.ResponseMessageInterceptor._action')
  - [AfterHttpRequest(responseMessage,cancellationToken)](#M-Bb-Interceptors-ResponseMessageInterceptor-AfterHttpRequest-System-Net-Http-HttpResponseMessage,System-Threading-CancellationToken- 'Bb.Interceptors.ResponseMessageInterceptor.AfterHttpRequest(System.Net.Http.HttpResponseMessage,System.Threading.CancellationToken)')
- [RestClientExtension](#T-Bb-Helpers-RestClientExtension 'Bb.Helpers.RestClientExtension')
  - [GetTokenAsync(self,path,client_id,client_secret,userName,password)](#M-Bb-Helpers-RestClientExtension-GetTokenAsync-RestSharp-RestClient,System-String,System-String,System-String,System-String,System-String- 'Bb.Helpers.RestClientExtension.GetTokenAsync(RestSharp.RestClient,System.String,System.String,System.String,System.String,System.String)')
- [RestClientFactory](#T-Bb-Services-RestClientFactory 'Bb.Services.RestClientFactory')
  - [#ctor(optionFactory,factory)](#M-Bb-Services-RestClientFactory-#ctor-Bb-Interfaces-IOptionClientFactory,System-Net-Http-IHttpClientFactory- 'Bb.Services.RestClientFactory.#ctor(Bb.Interfaces.IOptionClientFactory,System.Net.Http.IHttpClientFactory)')
  - [Create(baseUrl)](#M-Bb-Services-RestClientFactory-Create-System-Uri- 'Bb.Services.RestClientFactory.Create(System.Uri)')
  - [Create(name)](#M-Bb-Services-RestClientFactory-Create-System-String- 'Bb.Services.RestClientFactory.Create(System.String)')
  - [Create(name)](#M-Bb-Services-RestClientFactory-Create-Bb-Urls-Url- 'Bb.Services.RestClientFactory.Create(Bb.Urls.Url)')
- [RestOptionExtension](#T-Bb-Helpers-RestOptionExtension 'Bb.Helpers.RestOptionExtension')
  - [InterceptCookies(self,bag)](#M-Bb-Helpers-RestOptionExtension-InterceptCookies-RestSharp-RestClientOptions,Bb-Services-Bag{System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{System-String,System-Collections-Generic-IEnumerable{System-String}}}}@- 'Bb.Helpers.RestOptionExtension.InterceptCookies(RestSharp.RestClientOptions,Bb.Services.Bag{System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{System.String,System.Collections.Generic.IEnumerable{System.String}}}}@)')
  - [InterceptRequest(self,interceptor)](#M-Bb-Helpers-RestOptionExtension-InterceptRequest-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpRequestMessage}- 'Bb.Helpers.RestOptionExtension.InterceptRequest(RestSharp.RestClientOptions,System.Action{System.Net.Http.HttpRequestMessage})')
  - [InterceptResponse(self,interceptor)](#M-Bb-Helpers-RestOptionExtension-InterceptResponse-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpResponseMessage}- 'Bb.Helpers.RestOptionExtension.InterceptResponse(RestSharp.RestClientOptions,System.Action{System.Net.Http.HttpResponseMessage})')
  - [WithAuth1(self,consumerKey,consumerSecret)](#M-Bb-Helpers-RestOptionExtension-WithAuth1-RestSharp-RestClientOptions,System-String,System-String- 'Bb.Helpers.RestOptionExtension.WithAuth1(RestSharp.RestClientOptions,System.String,System.String)')
  - [WithBasicHttp(self,userName,password)](#M-Bb-Helpers-RestOptionExtension-WithBasicHttp-RestSharp-RestClientOptions,System-String,System-String- 'Bb.Helpers.RestOptionExtension.WithBasicHttp(RestSharp.RestClientOptions,System.String,System.String)')
  - [WithJwt(self,accessToken)](#M-Bb-Helpers-RestOptionExtension-WithJwt-RestSharp-RestClientOptions,System-String- 'Bb.Helpers.RestOptionExtension.WithJwt(RestSharp.RestClientOptions,System.String)')
  - [WithLog(self,logger)](#M-Bb-Helpers-RestOptionExtension-WithLog-RestSharp-RestClientOptions,Microsoft-Extensions-Logging-ILogger- 'Bb.Helpers.RestOptionExtension.WithLog(RestSharp.RestClientOptions,Microsoft.Extensions.Logging.ILogger)')
  - [WithLog(self,requestAction,logger)](#M-Bb-Helpers-RestOptionExtension-WithLog-RestSharp-RestClientOptions,System-Action{Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}},Microsoft-Extensions-Logging-ILogger- 'Bb.Helpers.RestOptionExtension.WithLog(RestSharp.RestClientOptions,System.Action{Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}},Microsoft.Extensions.Logging.ILogger)')
  - [WithLog(self,requestAction,responseAction,logger)](#M-Bb-Helpers-RestOptionExtension-WithLog-RestSharp-RestClientOptions,System-Action{Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}},System-Action{Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage}},Microsoft-Extensions-Logging-ILogger- 'Bb.Helpers.RestOptionExtension.WithLog(RestSharp.RestClientOptions,System.Action{Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}},System.Action{Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage}},Microsoft.Extensions.Logging.ILogger)')
  - [WithOAuth2(self,accessToken)](#M-Bb-Helpers-RestOptionExtension-WithOAuth2-RestSharp-RestClientOptions,System-String- 'Bb.Helpers.RestOptionExtension.WithOAuth2(RestSharp.RestClientOptions,System.String)')
- [RestRequestExtension](#T-Bb-Helpers-RestRequestExtension 'Bb.Helpers.RestRequestExtension')
  - [InterceptCookies(self,bag)](#M-Bb-Helpers-RestRequestExtension-InterceptCookies-RestSharp-RestClientOptions,Bb-Services-Bag{System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{System-String,System-Collections-Generic-IEnumerable{System-String}}}}@- 'Bb.Helpers.RestRequestExtension.InterceptCookies(RestSharp.RestClientOptions,Bb.Services.Bag{System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{System.String,System.Collections.Generic.IEnumerable{System.String}}}}@)')
  - [InterceptRequest(self,interceptor)](#M-Bb-Helpers-RestRequestExtension-InterceptRequest-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpRequestMessage}- 'Bb.Helpers.RestRequestExtension.InterceptRequest(RestSharp.RestClientOptions,System.Action{System.Net.Http.HttpRequestMessage})')
  - [InterceptResponse(self,interceptor)](#M-Bb-Helpers-RestRequestExtension-InterceptResponse-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpResponseMessage}- 'Bb.Helpers.RestRequestExtension.InterceptResponse(RestSharp.RestClientOptions,System.Action{System.Net.Http.HttpResponseMessage})')
  - [NewRequest(method,path,format)](#M-Bb-Helpers-RestRequestExtension-NewRequest-RestSharp-Method,System-String,System-Nullable{RestSharp-DataFormat}- 'Bb.Helpers.RestRequestExtension.NewRequest(RestSharp.Method,System.String,System.Nullable{RestSharp.DataFormat})')
  - [WithBasicHttp(self,userName,password)](#M-Bb-Helpers-RestRequestExtension-WithBasicHttp-RestSharp-RestClientOptions,System-String,System-String- 'Bb.Helpers.RestRequestExtension.WithBasicHttp(RestSharp.RestClientOptions,System.String,System.String)')
  - [WithBearer(self,token)](#M-Bb-Helpers-RestRequestExtension-WithBearer-RestSharp-RestRequest,Bb-Http-TokenResponse- 'Bb.Helpers.RestRequestExtension.WithBearer(RestSharp.RestRequest,Bb.Http.TokenResponse)')
  - [WithContentType(self,contentType)](#M-Bb-Helpers-RestRequestExtension-WithContentType-RestSharp-RestRequest,RestSharp-ContentType- 'Bb.Helpers.RestRequestExtension.WithContentType(RestSharp.RestRequest,RestSharp.ContentType)')
- [Segment](#T-Bb-Urls-Segment 'Bb.Urls.Segment')
  - [#ctor(segment)](#M-Bb-Urls-Segment-#ctor-System-String- 'Bb.Urls.Segment.#ctor(System.String)')
  - [EncodedValue](#P-Bb-Urls-Segment-EncodedValue 'Bb.Urls.Segment.EncodedValue')
  - [IsMalicious](#P-Bb-Urls-Segment-IsMalicious 'Bb.Urls.Segment.IsMalicious')
  - [IsVariable](#P-Bb-Urls-Segment-IsVariable 'Bb.Urls.Segment.IsVariable')
  - [Value](#P-Bb-Urls-Segment-Value 'Bb.Urls.Segment.Value')
  - [Map(value)](#M-Bb-Urls-Segment-Map-System-String- 'Bb.Urls.Segment.Map(System.String)')
  - [ToString()](#M-Bb-Urls-Segment-ToString 'Bb.Urls.Segment.ToString')
  - [op_Implicit(segment)](#M-Bb-Urls-Segment-op_Implicit-Bb-Urls-Segment-~System-String 'Bb.Urls.Segment.op_Implicit(Bb.Urls.Segment)~System.String')
- [TokenResponse](#T-Bb-Http-TokenResponse 'Bb.Http.TokenResponse')
  - [AccessToken](#P-Bb-Http-TokenResponse-AccessToken 'Bb.Http.TokenResponse.AccessToken')
  - [ExpiresIn](#P-Bb-Http-TokenResponse-ExpiresIn 'Bb.Http.TokenResponse.ExpiresIn')
  - [NotBeforePolicy](#P-Bb-Http-TokenResponse-NotBeforePolicy 'Bb.Http.TokenResponse.NotBeforePolicy')
  - [RefreshExpiresIn](#P-Bb-Http-TokenResponse-RefreshExpiresIn 'Bb.Http.TokenResponse.RefreshExpiresIn')
  - [RefreshToken](#P-Bb-Http-TokenResponse-RefreshToken 'Bb.Http.TokenResponse.RefreshToken')
  - [Scope](#P-Bb-Http-TokenResponse-Scope 'Bb.Http.TokenResponse.Scope')
  - [SessionState](#P-Bb-Http-TokenResponse-SessionState 'Bb.Http.TokenResponse.SessionState')
  - [TokenType](#P-Bb-Http-TokenResponse-TokenType 'Bb.Http.TokenResponse.TokenType')
- [Url](#T-Bb-Urls-Url 'Bb.Urls.Url')
  - [#ctor()](#M-Bb-Urls-Url-#ctor 'Bb.Urls.Url.#ctor')
  - [#ctor(builder,uri)](#M-Bb-Urls-Url-#ctor-System-UriBuilder,System-Uri- 'Bb.Urls.Url.#ctor(System.UriBuilder,System.Uri)')
  - [#ctor(uri)](#M-Bb-Urls-Url-#ctor-System-Uri- 'Bb.Urls.Url.#ctor(System.Uri)')
  - [#ctor(url)](#M-Bb-Urls-Url-#ctor-System-String- 'Bb.Urls.Url.#ctor(System.String)')
  - [#ctor(uri,paths)](#M-Bb-Urls-Url-#ctor-System-Uri,System-String[]- 'Bb.Urls.Url.#ctor(System.Uri,System.String[])')
  - [#ctor(scheme,host,port,userInfo,paths)](#M-Bb-Urls-Url-#ctor-System-String,System-String,System-Nullable{System-Int32},System-String,System-String[]- 'Bb.Urls.Url.#ctor(System.String,System.String,System.Nullable{System.Int32},System.String,System.String[])')
  - [#ctor(scheme,host,port)](#M-Bb-Urls-Url-#ctor-System-String,System-String,System-Nullable{System-Int32}- 'Bb.Urls.Url.#ctor(System.String,System.String,System.Nullable{System.Int32})')
  - [#ctor(scheme,host)](#M-Bb-Urls-Url-#ctor-System-String,System-String- 'Bb.Urls.Url.#ctor(System.String,System.String)')
  - [#ctor(host,port)](#M-Bb-Urls-Url-#ctor-System-String,System-Int32- 'Bb.Urls.Url.#ctor(System.String,System.Int32)')
  - [DEFAULT_HOST](#F-Bb-Urls-Url-DEFAULT_HOST 'Bb.Urls.Url.DEFAULT_HOST')
  - [DEFAULT_PORT](#F-Bb-Urls-Url-DEFAULT_PORT 'Bb.Urls.Url.DEFAULT_PORT')
  - [DEFAULT_SCHEME](#F-Bb-Urls-Url-DEFAULT_SCHEME 'Bb.Urls.Url.DEFAULT_SCHEME')
  - [DEFAULT_SECURED_SCHEME](#F-Bb-Urls-Url-DEFAULT_SECURED_SCHEME 'Bb.Urls.Url.DEFAULT_SECURED_SCHEME')
  - [BaseAddress](#P-Bb-Urls-Url-BaseAddress 'Bb.Urls.Url.BaseAddress')
  - [Fragment](#P-Bb-Urls-Url-Fragment 'Bb.Urls.Url.Fragment')
  - [Host](#P-Bb-Urls-Url-Host 'Bb.Urls.Url.Host')
  - [Password](#P-Bb-Urls-Url-Password 'Bb.Urls.Url.Password')
  - [Path](#P-Bb-Urls-Url-Path 'Bb.Urls.Url.Path')
  - [PathAndQuery](#P-Bb-Urls-Url-PathAndQuery 'Bb.Urls.Url.PathAndQuery')
  - [PathSegments](#P-Bb-Urls-Url-PathSegments 'Bb.Urls.Url.PathSegments')
  - [Port](#P-Bb-Urls-Url-Port 'Bb.Urls.Url.Port')
  - [Query](#P-Bb-Urls-Url-Query 'Bb.Urls.Url.Query')
  - [QueryParams](#P-Bb-Urls-Url-QueryParams 'Bb.Urls.Url.QueryParams')
  - [Root](#P-Bb-Urls-Url-Root 'Bb.Urls.Url.Root')
  - [RootAddress](#P-Bb-Urls-Url-RootAddress 'Bb.Urls.Url.RootAddress')
  - [Scheme](#P-Bb-Urls-Url-Scheme 'Bb.Urls.Url.Scheme')
  - [UserName](#P-Bb-Urls-Url-UserName 'Bb.Urls.Url.UserName')
  - [Clone()](#M-Bb-Urls-Url-Clone 'Bb.Urls.Url.Clone')
  - [CombinePath(paths)](#M-Bb-Urls-Url-CombinePath-System-Collections-Generic-IEnumerable{Bb-Urls-Segment}- 'Bb.Urls.Url.CombinePath(System.Collections.Generic.IEnumerable{Bb.Urls.Segment})')
  - [CombinePath(paths)](#M-Bb-Urls-Url-CombinePath-System-String[]- 'Bb.Urls.Url.CombinePath(System.String[])')
  - [Decode(s,interpretPlusAsSpace)](#M-Bb-Urls-Url-Decode-System-String,System-Boolean- 'Bb.Urls.Url.Decode(System.String,System.Boolean)')
  - [Encode(str,encodeSpaceAsPlus)](#M-Bb-Urls-Url-Encode-System-String,System-Boolean- 'Bb.Urls.Url.Encode(System.String,System.Boolean)')
  - [EncodeIllegalCharacters(s,encodeSpaceAsPlus)](#M-Bb-Urls-Url-EncodeIllegalCharacters-System-String,System-Boolean- 'Bb.Urls.Url.EncodeIllegalCharacters(System.String,System.Boolean)')
  - [Map(values)](#M-Bb-Urls-Url-Map-System-ValueTuple{System-String,System-String}[]- 'Bb.Urls.Url.Map(System.ValueTuple{System.String,System.String}[])')
  - [Map(name,value)](#M-Bb-Urls-Url-Map-System-String,System-String- 'Bb.Urls.Url.Map(System.String,System.String)')
  - [ParsePathSegment(paths)](#M-Bb-Urls-Url-ParsePathSegment-System-String[]- 'Bb.Urls.Url.ParsePathSegment(System.String[])')
  - [RemoveFragment()](#M-Bb-Urls-Url-RemoveFragment 'Bb.Urls.Url.RemoveFragment')
  - [RemoveLastPathSegment()](#M-Bb-Urls-Url-RemoveLastPathSegment 'Bb.Urls.Url.RemoveLastPathSegment')
  - [RemovePath()](#M-Bb-Urls-Url-RemovePath 'Bb.Urls.Url.RemovePath')
  - [RemoveQuery()](#M-Bb-Urls-Url-RemoveQuery 'Bb.Urls.Url.RemoveQuery')
  - [RemoveQueryParam(name)](#M-Bb-Urls-Url-RemoveQueryParam-System-String- 'Bb.Urls.Url.RemoveQueryParam(System.String)')
  - [RemoveQueryParam(names)](#M-Bb-Urls-Url-RemoveQueryParam-System-String[]- 'Bb.Urls.Url.RemoveQueryParam(System.String[])')
  - [RemoveQueryParam(names)](#M-Bb-Urls-Url-RemoveQueryParam-System-Collections-Generic-IEnumerable{System-String}- 'Bb.Urls.Url.RemoveQueryParam(System.Collections.Generic.IEnumerable{System.String})')
  - [Reset()](#M-Bb-Urls-Url-Reset 'Bb.Urls.Url.Reset')
  - [ResetToRoot()](#M-Bb-Urls-Url-ResetToRoot 'Bb.Urls.Url.ResetToRoot')
  - [SetFragment(fragment)](#M-Bb-Urls-Url-SetFragment-System-String- 'Bb.Urls.Url.SetFragment(System.String)')
  - [ToString()](#M-Bb-Urls-Url-ToString 'Bb.Urls.Url.ToString')
  - [ToUri()](#M-Bb-Urls-Url-ToUri 'Bb.Urls.Url.ToUri')
  - [WithPathSegment(pathSegments)](#M-Bb-Urls-Url-WithPathSegment-System-String[]- 'Bb.Urls.Url.WithPathSegment(System.String[])')
  - [WithPathSegment(pathSegments)](#M-Bb-Urls-Url-WithPathSegment-System-Collections-Generic-IEnumerable{System-String}- 'Bb.Urls.Url.WithPathSegment(System.Collections.Generic.IEnumerable{System.String})')
  - [WithQueryParam(name,value,nullValueHandling)](#M-Bb-Urls-Url-WithQueryParam-System-String,System-Object,Bb-NullValueHandling- 'Bb.Urls.Url.WithQueryParam(System.String,System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(name,value,isEncoded,nullValueHandling)](#M-Bb-Urls-Url-WithQueryParam-System-String,System-String,System-Boolean,Bb-NullValueHandling- 'Bb.Urls.Url.WithQueryParam(System.String,System.String,System.Boolean,Bb.NullValueHandling)')
  - [WithQueryParam(name)](#M-Bb-Urls-Url-WithQueryParam-System-String- 'Bb.Urls.Url.WithQueryParam(System.String)')
  - [WithQueryParam(values,nullValueHandling)](#M-Bb-Urls-Url-WithQueryParam-System-Object,Bb-NullValueHandling- 'Bb.Urls.Url.WithQueryParam(System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(names)](#M-Bb-Urls-Url-WithQueryParam-System-Collections-Generic-IEnumerable{System-String}- 'Bb.Urls.Url.WithQueryParam(System.Collections.Generic.IEnumerable{System.String})')
  - [WithQueryParam(names)](#M-Bb-Urls-Url-WithQueryParam-System-String[]- 'Bb.Urls.Url.WithQueryParam(System.String[])')
  - [op_Implicit(url)](#M-Bb-Urls-Url-op_Implicit-Bb-Urls-Url-~System-Uri 'Bb.Urls.Url.op_Implicit(Bb.Urls.Url)~System.Uri')
  - [op_Implicit(uri)](#M-Bb-Urls-Url-op_Implicit-System-Uri-~Bb-Urls-Url 'Bb.Urls.Url.op_Implicit(System.Uri)~Bb.Urls.Url')
  - [op_Implicit(url)](#M-Bb-Urls-Url-op_Implicit-Bb-Urls-Url-~System-String 'Bb.Urls.Url.op_Implicit(Bb.Urls.Url)~System.String')
  - [op_Implicit(url)](#M-Bb-Urls-Url-op_Implicit-System-String-~Bb-Urls-Url 'Bb.Urls.Url.op_Implicit(System.String)~Bb.Urls.Url')
- [UrlExtension](#T-Bb-Urls-UrlExtension 'Bb.Urls.UrlExtension')
  - [CallAsync(self,method,format)](#M-Bb-Urls-UrlExtension-CallAsync-Bb-Urls-Url,RestSharp-Method,System-Nullable{RestSharp-DataFormat}- 'Bb.Urls.UrlExtension.CallAsync(Bb.Urls.Url,RestSharp.Method,System.Nullable{RestSharp.DataFormat})')
  - [CallAsync(self,method,initializer)](#M-Bb-Urls-UrlExtension-CallAsync-Bb-Urls-Url,RestSharp-Method,System-Action{RestSharp-RestRequest}- 'Bb.Urls.UrlExtension.CallAsync(Bb.Urls.Url,RestSharp.Method,System.Action{RestSharp.RestRequest})')
  - [CallAsync(self,method,format,initializer)](#M-Bb-Urls-UrlExtension-CallAsync-Bb-Urls-Url,RestSharp-Method,System-Nullable{RestSharp-DataFormat},System-Action{RestSharp-RestRequest}- 'Bb.Urls.UrlExtension.CallAsync(Bb.Urls.Url,RestSharp.Method,System.Nullable{RestSharp.DataFormat},System.Action{RestSharp.RestRequest})')
  - [CombineUrl(urls)](#M-Bb-Urls-UrlExtension-CombineUrl-System-Collections-Generic-IEnumerable{Bb-Urls-Url}- 'Bb.Urls.UrlExtension.CombineUrl(System.Collections.Generic.IEnumerable{Bb.Urls.Url})')
  - [CombineUrl(sb,urls)](#M-Bb-Urls-UrlExtension-CombineUrl-System-Text-StringBuilder,System-Collections-Generic-IEnumerable{Bb-Urls-Url}- 'Bb.Urls.UrlExtension.CombineUrl(System.Text.StringBuilder,System.Collections.Generic.IEnumerable{Bb.Urls.Url})')
  - [GetTokenAsync(self,client_id,client_secret,userName,password)](#M-Bb-Urls-UrlExtension-GetTokenAsync-Bb-Urls-Url,System-String,System-String,System-String,System-String- 'Bb.Urls.UrlExtension.GetTokenAsync(Bb.Urls.Url,System.String,System.String,System.String,System.String)')
  - [Map(self,variable,value)](#M-Bb-Urls-UrlExtension-Map-System-String,System-String,System-String- 'Bb.Urls.UrlExtension.Map(System.String,System.String,System.String)')
  - [RemoveFragment(url)](#M-Bb-Urls-UrlExtension-RemoveFragment-System-String- 'Bb.Urls.UrlExtension.RemoveFragment(System.String)')
  - [RemoveLastPathSegment(url)](#M-Bb-Urls-UrlExtension-RemoveLastPathSegment-System-String- 'Bb.Urls.UrlExtension.RemoveLastPathSegment(System.String)')
  - [RemovePath(url)](#M-Bb-Urls-UrlExtension-RemovePath-System-String- 'Bb.Urls.UrlExtension.RemovePath(System.String)')
  - [RemoveQuery(url)](#M-Bb-Urls-UrlExtension-RemoveQuery-System-String- 'Bb.Urls.UrlExtension.RemoveQuery(System.String)')
  - [RemoveQueryParam(url,name)](#M-Bb-Urls-UrlExtension-RemoveQueryParam-System-String,System-String- 'Bb.Urls.UrlExtension.RemoveQueryParam(System.String,System.String)')
  - [RemoveQueryParam(url,names)](#M-Bb-Urls-UrlExtension-RemoveQueryParam-System-String,System-String[]- 'Bb.Urls.UrlExtension.RemoveQueryParam(System.String,System.String[])')
  - [RemoveQueryParam(url,names)](#M-Bb-Urls-UrlExtension-RemoveQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Urls.UrlExtension.RemoveQueryParam(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [ResetToRoot(url)](#M-Bb-Urls-UrlExtension-ResetToRoot-System-String- 'Bb.Urls.UrlExtension.ResetToRoot(System.String)')
  - [RestClient(url)](#M-Bb-Urls-UrlExtension-RestClient-Bb-Urls-Url- 'Bb.Urls.UrlExtension.RestClient(Bb.Urls.Url)')
  - [SetFragment(url,fragment)](#M-Bb-Urls-UrlExtension-SetFragment-System-String,System-String- 'Bb.Urls.UrlExtension.SetFragment(System.String,System.String)')
  - [SetQueryParam(url,name,value,nullValueHandling)](#M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-String,System-Object,Bb-NullValueHandling- 'Bb.Urls.UrlExtension.SetQueryParam(System.String,System.String,System.Object,Bb.NullValueHandling)')
  - [SetQueryParam(url,name,value,isEncoded,nullValueHandling)](#M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-String,System-String,System-Boolean,Bb-NullValueHandling- 'Bb.Urls.UrlExtension.SetQueryParam(System.String,System.String,System.String,System.Boolean,Bb.NullValueHandling)')
  - [SetQueryParam(url,name)](#M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-String- 'Bb.Urls.UrlExtension.SetQueryParam(System.String,System.String)')
  - [SetQueryParam(url,values,nullValueHandling)](#M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-Object,Bb-NullValueHandling- 'Bb.Urls.UrlExtension.SetQueryParam(System.String,System.Object,Bb.NullValueHandling)')
  - [SetQueryParam(url,names)](#M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Urls.UrlExtension.SetQueryParam(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [SetQueryParam(url,names)](#M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-String[]- 'Bb.Urls.UrlExtension.SetQueryParam(System.String,System.String[])')
  - [WithFragment(uri,fragment)](#M-Bb-Urls-UrlExtension-WithFragment-System-Uri,System-String- 'Bb.Urls.UrlExtension.WithFragment(System.Uri,System.String)')
  - [WithHTTPS(self)](#M-Bb-Urls-UrlExtension-WithHTTPS-Bb-Urls-Url- 'Bb.Urls.UrlExtension.WithHTTPS(Bb.Urls.Url)')
  - [WithHost(self,host)](#M-Bb-Urls-UrlExtension-WithHost-Bb-Urls-Url,System-String- 'Bb.Urls.UrlExtension.WithHost(Bb.Urls.Url,System.String)')
  - [WithHttp(self)](#M-Bb-Urls-UrlExtension-WithHttp-Bb-Urls-Url- 'Bb.Urls.UrlExtension.WithHttp(Bb.Urls.Url)')
  - [WithPathSegment(url,segment)](#M-Bb-Urls-UrlExtension-WithPathSegment-System-String,System-String- 'Bb.Urls.UrlExtension.WithPathSegment(System.String,System.String)')
  - [WithPathSegment(url,segments)](#M-Bb-Urls-UrlExtension-WithPathSegment-System-String,System-String[]- 'Bb.Urls.UrlExtension.WithPathSegment(System.String,System.String[])')
  - [WithPathSegment(url,segments)](#M-Bb-Urls-UrlExtension-WithPathSegment-System-String,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Urls.UrlExtension.WithPathSegment(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [WithPathSegment(uri,segment)](#M-Bb-Urls-UrlExtension-WithPathSegment-System-Uri,System-String- 'Bb.Urls.UrlExtension.WithPathSegment(System.Uri,System.String)')
  - [WithPathSegment(uri,segments)](#M-Bb-Urls-UrlExtension-WithPathSegment-System-Uri,System-String[]- 'Bb.Urls.UrlExtension.WithPathSegment(System.Uri,System.String[])')
  - [WithPathSegment(uri,segments)](#M-Bb-Urls-UrlExtension-WithPathSegment-System-Uri,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Urls.UrlExtension.WithPathSegment(System.Uri,System.Collections.Generic.IEnumerable{System.String})')
  - [WithPort(self,port)](#M-Bb-Urls-UrlExtension-WithPort-Bb-Urls-Url,System-Int32- 'Bb.Urls.UrlExtension.WithPort(Bb.Urls.Url,System.Int32)')
  - [WithQueryParam(uri,name,value,nullValueHandling)](#M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-String,System-Object,Bb-NullValueHandling- 'Bb.Urls.UrlExtension.WithQueryParam(System.Uri,System.String,System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(uri,name,value,isEncoded,nullValueHandling)](#M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-String,System-String,System-Boolean,Bb-NullValueHandling- 'Bb.Urls.UrlExtension.WithQueryParam(System.Uri,System.String,System.String,System.Boolean,Bb.NullValueHandling)')
  - [WithQueryParam(uri,name)](#M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-String- 'Bb.Urls.UrlExtension.WithQueryParam(System.Uri,System.String)')
  - [WithQueryParam(uri,values,nullValueHandling)](#M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-Object,Bb-NullValueHandling- 'Bb.Urls.UrlExtension.WithQueryParam(System.Uri,System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(uri,names)](#M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Urls.UrlExtension.WithQueryParam(System.Uri,System.Collections.Generic.IEnumerable{System.String})')
  - [WithQueryParam(uri,names)](#M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-String[]- 'Bb.Urls.UrlExtension.WithQueryParam(System.Uri,System.String[])')
  - [WithRemoveFragment(uri)](#M-Bb-Urls-UrlExtension-WithRemoveFragment-System-Uri- 'Bb.Urls.UrlExtension.WithRemoveFragment(System.Uri)')
  - [WithRemovePath(uri)](#M-Bb-Urls-UrlExtension-WithRemovePath-System-Uri- 'Bb.Urls.UrlExtension.WithRemovePath(System.Uri)')
  - [WithRemovePathSegment(uri)](#M-Bb-Urls-UrlExtension-WithRemovePathSegment-System-Uri- 'Bb.Urls.UrlExtension.WithRemovePathSegment(System.Uri)')
  - [WithRemoveQuery(uri)](#M-Bb-Urls-UrlExtension-WithRemoveQuery-System-Uri- 'Bb.Urls.UrlExtension.WithRemoveQuery(System.Uri)')
  - [WithRemoveQueryParam(uri,name)](#M-Bb-Urls-UrlExtension-WithRemoveQueryParam-System-Uri,System-String- 'Bb.Urls.UrlExtension.WithRemoveQueryParam(System.Uri,System.String)')
  - [WithRemoveQueryParam(uri,names)](#M-Bb-Urls-UrlExtension-WithRemoveQueryParam-System-Uri,System-String[]- 'Bb.Urls.UrlExtension.WithRemoveQueryParam(System.Uri,System.String[])')
  - [WithRemoveQueryParam(uri,names)](#M-Bb-Urls-UrlExtension-WithRemoveQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Urls.UrlExtension.WithRemoveQueryParam(System.Uri,System.Collections.Generic.IEnumerable{System.String})')
  - [WithResetToRoot(uri)](#M-Bb-Urls-UrlExtension-WithResetToRoot-System-Uri- 'Bb.Urls.UrlExtension.WithResetToRoot(System.Uri)')
  - [WithUserInfo(self,userInfo)](#M-Bb-Urls-UrlExtension-WithUserInfo-Bb-Urls-Url,System-String- 'Bb.Urls.UrlExtension.WithUserInfo(Bb.Urls.Url,System.String)')

<a name='T-Bb-Curls-Argument'></a>
## Argument `type`

##### Namespace

Bb.Curls

##### Summary

Represents a command-line argument with an optional name and value.

##### Remarks

This class is used to encapsulate a single argument, which may include a name and a value.

<a name='M-Bb-Curls-Argument-#ctor-System-String,System-String-'></a>
### #ctor(value,name) `constructor`

##### Summary

Initializes a new instance of the [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value of the argument. Must not be null. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The optional name of the argument. Can be null. |

##### Example

```C#
var argument = new Argument("value", "name");
Console.WriteLine(argument.Name);  // Output: name
Console.WriteLine(argument.Value); // Output: value
```

##### Remarks

The constructor allows creating an argument with a value and an optional name.

<a name='P-Bb-Curls-Argument-Name'></a>
### Name `property`

##### Summary

Gets the name of the argument.

<a name='P-Bb-Curls-Argument-Value'></a>
### Value `property`

##### Summary

Gets the value of the argument.

<a name='M-Bb-Curls-Argument-ToString'></a>
### ToString() `method`

##### Summary

Returns the string representation of the argument.

##### Returns

The value of the argument as a string.

##### Parameters

This method has no parameters.

##### Example

```C#
var argument = new Argument("value");
Console.WriteLine(argument.ToString()); // Output: value
```

##### Remarks

This method overrides [ToString](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object.ToString 'System.Object.ToString') to return the value of the argument.

<a name='T-Bb-Curls-ArgumentList'></a>
## ArgumentList `type`

##### Namespace

Bb.Curls

##### Summary

Represents a collection of [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') objects that can be enumerated and manipulated.

##### Remarks

This class provides methods to add arguments to the list and supports enumeration through the [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') interface.

<a name='M-Bb-Curls-ArgumentList-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ArgumentList](#T-Bb-Curls-ArgumentList 'Bb.Curls.ArgumentList') class.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor creates an empty list of arguments.

<a name='M-Bb-Curls-ArgumentList-#ctor-Bb-Curls-Argument[]-'></a>
### #ctor(arguments) `constructor`

##### Summary

Initializes a new instance of the [ArgumentList](#T-Bb-Curls-ArgumentList 'Bb.Curls.ArgumentList') class with the specified arguments.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| arguments | [Bb.Curls.Argument[]](#T-Bb-Curls-Argument[] 'Bb.Curls.Argument[]') | An array of [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') objects to initialize the list with. Must not be null. |

##### Example

```C#
var arguments = new Argument[] { new Argument("key1", "value1"), new Argument("key2", "value2") };
var argumentList = new ArgumentList(arguments);
```

##### Remarks

This constructor populates the list with the provided arguments.

<a name='P-Bb-Curls-ArgumentList-_arguments'></a>
### _arguments `property`

##### Summary

Gets the internal list of arguments.

##### Remarks

This property holds the collection of arguments managed by the [ArgumentList](#T-Bb-Curls-ArgumentList 'Bb.Curls.ArgumentList').

<a name='M-Bb-Curls-ArgumentList-Add-Bb-Curls-Argument-'></a>
### Add(argument) `method`

##### Summary

Adds an [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') to the list.

##### Returns

The updated [ArgumentList](#T-Bb-Curls-ArgumentList 'Bb.Curls.ArgumentList') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| argument | [Bb.Curls.Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') | The [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') to add. Must not be null. |

##### Example

```C#
var argumentList = new ArgumentList();
argumentList.Add(new Argument("key", "value"));
```

##### Remarks

This method appends the specified argument to the list.

<a name='M-Bb-Curls-ArgumentList-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through the [ArgumentList](#T-Bb-Curls-ArgumentList 'Bb.Curls.ArgumentList').

##### Returns

An enumerator of [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') objects.

##### Parameters

This method has no parameters.

##### Example

```C#
var argumentList = new ArgumentList();
foreach (var argument in argumentList)
{
    Console.WriteLine(argument.Key);
}
```

##### Remarks

This method allows enumeration of the arguments in the list.

<a name='M-Bb-Curls-ArgumentList-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

Returns an enumerator that iterates through the [ArgumentList](#T-Bb-Curls-ArgumentList 'Bb.Curls.ArgumentList').

##### Returns

An enumerator of [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') objects.

##### Parameters

This method has no parameters.

##### Remarks

This method is an explicit implementation of the non-generic [IEnumerable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.IEnumerable 'System.Collections.IEnumerable') interface.

<a name='M-Bb-Curls-ArgumentList-op_Implicit-Bb-Curls-Argument[]-~Bb-Curls-ArgumentList'></a>
### op_Implicit(arguments) `method`

##### Summary

Implicitly converts an array of [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') objects to an [ArgumentList](#T-Bb-Curls-ArgumentList 'Bb.Curls.ArgumentList').

##### Returns

An [ArgumentList](#T-Bb-Curls-ArgumentList 'Bb.Curls.ArgumentList') containing the specified arguments.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| arguments | [Bb.Curls.Argument[])~Bb.Curls.ArgumentList](#T-Bb-Curls-Argument[]-~Bb-Curls-ArgumentList 'Bb.Curls.Argument[])~Bb.Curls.ArgumentList') | An array of [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') objects to convert. Must not be null. |

##### Example

```C#
Argument[] arguments = { new Argument("key1", "value1"), new Argument("key2", "value2") };
ArgumentList argumentList = arguments;
```

##### Remarks

This operator allows seamless conversion from an array of arguments to an [ArgumentList](#T-Bb-Curls-ArgumentList 'Bb.Curls.ArgumentList').

<a name='T-Bb-Curls-ArgumentSource'></a>
## ArgumentSource `type`

##### Namespace

Bb.Curls

##### Summary

Represents a source of command-line arguments that can be read sequentially.

##### Remarks

This class provides methods to read arguments one by one and track the current state of the reading process.

<a name='M-Bb-Curls-ArgumentSource-#ctor-System-String[]-'></a>
### #ctor(arguments) `constructor`

##### Summary

Initializes a new instance of the [ArgumentSource](#T-Bb-Curls-ArgumentSource 'Bb.Curls.ArgumentSource') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| arguments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | An array of arguments to initialize the source with. Must not be null. |

##### Example

```C#
var source = new ArgumentSource(new[] { "arg1", "arg2" });
while (source.ReadNext())
{
    Console.WriteLine(source.Current);
}
```

##### Remarks

The constructor sets up the argument source with the provided array of arguments.

<a name='P-Bb-Curls-ArgumentSource-CanRead'></a>
### CanRead `property`

##### Summary

Gets a value indicating whether more arguments can be read.

##### Remarks

This property checks if the reading process has not failed and there are more arguments to read.

<a name='P-Bb-Curls-ArgumentSource-Current'></a>
### Current `property`

##### Summary

Gets the current argument in the source.

##### Remarks

This property returns the argument at the current index in the source.

<a name='P-Bb-Curls-ArgumentSource-FailMessage'></a>
### FailMessage `property`

##### Summary

Gets the failure message if the reading process has failed.

<a name='P-Bb-Curls-ArgumentSource-IsFailed'></a>
### IsFailed `property`

##### Summary

Gets a value indicating whether the reading process has failed.

<a name='M-Bb-Curls-ArgumentSource-Failed-System-String-'></a>
### Failed(failMessage) `method`

##### Summary

Marks the reading process as failed with a specified message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| failMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The failure message. Must not be null. |

##### Remarks

This method sets the failure state and message for the argument source.

<a name='M-Bb-Curls-ArgumentSource-GetArgument'></a>
### GetArgument() `method`

##### Summary

Creates an [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') instance from the current argument.

##### Returns

A new [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') instance containing the current argument value.

##### Parameters

This method has no parameters.

##### Example

```C#
var source = new ArgumentSource(new[] { "arg1" });
source.ReadNext();
var argument = source.GetArgument();
Console.WriteLine(argument.Value); // Output: arg1
```

##### Remarks

This method wraps the current argument in an [Argument](#T-Bb-Curls-Argument 'Bb.Curls.Argument') object.

<a name='M-Bb-Curls-ArgumentSource-ReadNext'></a>
### ReadNext() `method`

##### Summary

Advances to the next argument in the source.

##### Returns

`true` if the next argument is available; otherwise, `false`.

##### Parameters

This method has no parameters.

##### Example

```C#
var source = new ArgumentSource(new[] { "arg1", "arg2" });
while (source.ReadNext())
{
    Console.WriteLine(source.Current);
}
```

##### Remarks

This method increments the index to point to the next argument in the source.

<a name='T-Bb-Services-Bag`1'></a>
## Bag\`1 `type`

##### Namespace

Bb.Services

##### Summary

Represents a container for storing a value of type `T`.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the value to store in the bag. |

##### Remarks

This class provides a simple container for holding a value of type `T`. 
It is typically used to pass or store values in scenarios where mutability is required.

<a name='M-Bb-Services-Bag`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [Bag\`1](#T-Bb-Services-Bag`1 'Bb.Services.Bag`1') class.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor creates an empty bag with no initial value.

<a name='P-Bb-Services-Bag`1-Value'></a>
### Value `property`

##### Summary

Gets or sets the value stored in the bag.

##### Remarks

The value can be accessed or modified internally within the assembly.

<a name='T-Bb-Services-ClientRestOption'></a>
## ClientRestOption `type`

##### Namespace

Bb.Services

##### Summary

Represents options for configuring a REST client.

<a name='M-Bb-Services-ClientRestOption-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ClientRestOption](#T-Bb-Services-ClientRestOption 'Bb.Services.ClientRestOption') class.

##### Parameters

This constructor has no parameters.

##### Remarks

Sets the [Debug](#P-Bb-Services-ClientRestOption-Debug 'Bb.Services.ClientRestOption.Debug') property to `true` if a debugger is attached.

<a name='P-Bb-Services-ClientRestOption-AllowMultipleDefaultParametersWithSameName'></a>
### AllowMultipleDefaultParametersWithSameName `property`

##### Summary

Gets or sets a value indicating whether multiple default parameters with the same name are allowed.

<a name='P-Bb-Services-ClientRestOption-AutomaticDecompression'></a>
### AutomaticDecompression `property`

##### Summary

Gets or sets the decompression methods to use for automatic decompression of response content.

<a name='P-Bb-Services-ClientRestOption-Debug'></a>
### Debug `property`

##### Summary

Gets or sets a value indicating whether debug mode is enabled.

##### Remarks

When debug mode is enabled, additional logging is performed.

<a name='P-Bb-Services-ClientRestOption-DisableCharset'></a>
### DisableCharset `property`

##### Summary

Gets or sets a value indicating whether to disable the charset in requests.

<a name='P-Bb-Services-ClientRestOption-Expect100Continue'></a>
### Expect100Continue `property`

##### Summary

Gets or sets a value indicating whether to expect a 100-Continue response from the server.

<a name='P-Bb-Services-ClientRestOption-FailOnDeserializationError'></a>
### FailOnDeserializationError `property`

##### Summary

Gets or sets a value indicating whether to fail silently on deserialization errors.

<a name='P-Bb-Services-ClientRestOption-FollowRedirects'></a>
### FollowRedirects `property`

##### Summary

Gets or sets a value indicating whether to follow HTTP redirects.

##### Remarks

When set to `true`, the client will automatically follow HTTP 3xx redirect responses.

<a name='P-Bb-Services-ClientRestOption-MaxRedirects'></a>
### MaxRedirects `property`

##### Summary

Gets or sets the maximum number of redirects to follow.

##### Remarks

This property is used to limit the number of HTTP 3xx redirects the client will follow.

<a name='P-Bb-Services-ClientRestOption-PreAuthenticate'></a>
### PreAuthenticate `property`

##### Summary

Gets or sets a value indicating whether to pre-authenticate requests.

<a name='P-Bb-Services-ClientRestOption-ThrowOnAnyError'></a>
### ThrowOnAnyError `property`

##### Summary

Gets or sets a value indicating whether to throw an exception on any error.

##### Remarks

When set to `true`, any error during the request will result in an exception.

<a name='P-Bb-Services-ClientRestOption-ThrowOnDeSerializationError'></a>
### ThrowOnDeSerializationError `property`

##### Summary

Gets or sets a value indicating whether to throw an exception on deserialization errors.

<a name='P-Bb-Services-ClientRestOption-Timeout'></a>
### Timeout `property`

##### Summary

Gets or sets the timeout duration for requests, in seconds.

<a name='P-Bb-Services-ClientRestOption-Trace'></a>
### Trace `property`

##### Summary

Gets or sets a value indicating whether trace mode is enabled.

##### Remarks

When trace and log mode is enabled, additional logging is performed.

<a name='P-Bb-Services-ClientRestOption-UseDefaultCredentials'></a>
### UseDefaultCredentials `property`

##### Summary

Gets or sets a value indicating whether to use default credentials for requests.

<a name='T-Bb-Urls-CommonExtensions'></a>
## CommonExtensions `type`

##### Namespace

Bb.Urls

##### Summary

CommonExtensions for objects.

<a name='M-Bb-Urls-CommonExtensions-IsIP-System-String-'></a>
### IsIP() `method`

##### Summary

True if the given string is a valid IPv4 address.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-CommonExtensions-Merge``2-System-Collections-Generic-IDictionary{``0,``1},System-Collections-Generic-IDictionary{``0,``1}-'></a>
### Merge\`\`2() `method`

##### Summary

Merges the key/value pairs from d2 into d1, without overwriting those already set in d1.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-CommonExtensions-SplitOnFirstOccurrence-System-String,System-String-'></a>
### SplitOnFirstOccurrence(s,separator) `method`

##### Summary

Splits at the first occurrence of the given separator.

##### Returns

Array of at most 2 strings. (1 if separator is not found.)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to split. |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The separator to split on. |

<a name='M-Bb-Urls-CommonExtensions-StripQuotes-System-String-'></a>
### StripQuotes() `method`

##### Summary

Strips any single quotes or double quotes from the beginning and end of a string.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-CommonExtensions-ToInvariantString-System-Object-'></a>
### ToInvariantString() `method`

##### Summary

Returns a string that represents the current object, using CultureInfo.InvariantCulture where possible.
Dates are represented in IS0 8601.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-CommonExtensions-ToKeyValuePairs-System-Object-'></a>
### ToKeyValuePairs(obj) `method`

##### Summary

Returns a key-value-pairs representation of the object.
For strings, URL query string format assumed and pairs are parsed from that.
For objects that already implement IEnumerable<KeyValuePair>, the object itself is simply returned.
For all other objects, all publicly readable properties are extracted and returned as pairs.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to parse into key-value pairs |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `obj` is `null`. |

<a name='T-Bb-Util-ContentTypes'></a>
## ContentTypes `type`

##### Namespace

Bb.Util

##### Summary

Provides predefined content types for use in HTTP requests.

##### Remarks

This class contains commonly used content types such as JSON and URL-encoded forms. 
These constants can be used to set the "Content-Type" header in HTTP requests.

<a name='P-Bb-Util-ContentTypes-ApplicationJson'></a>
### ApplicationJson `property`

##### Summary

Represents the content type for JSON data.

##### Example

```C#
var request = new RestRequest("api/resource", Method.POST);
request.AddHeader("Content-Type", ContentTypes.ApplicationJson);
```

<a name='P-Bb-Util-ContentTypes-ApplicationxWwwFormUrlencoded'></a>
### ApplicationxWwwFormUrlencoded `property`

##### Summary

Represents the content type for URL-encoded forms.

##### Example

```C#
var request = new RestRequest("api/resource", Method.POST);
request.AddHeader("Content-Type", ContentTypes.ApplicationxWwwFormUrlencoded);
```

<a name='P-Bb-Util-ContentTypes-CharsetUtf8'></a>
### CharsetUtf8 `property`

##### Summary

Contains common content types used in HTTP headers.

<a name='T-Bb-Curls-Curl'></a>
## Curl `type`

##### Namespace

Bb.Curls

##### Summary

Convert curl syntax in rest call

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| factory | [T:Bb.Curls.Curl](#T-T-Bb-Curls-Curl 'T:Bb.Curls.Curl') |  |

##### Remarks

Initializes a new instance of the [Curl](#T-Bb-Curls-Curl 'Bb.Curls.Curl') class with an optional factory.

<a name='M-Bb-Curls-Curl-#ctor-Bb-Interfaces-IRestClientFactory-'></a>
### #ctor(factory) `constructor`

##### Summary

Convert curl syntax in rest call

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| factory | [Bb.Interfaces.IRestClientFactory](#T-Bb-Interfaces-IRestClientFactory 'Bb.Interfaces.IRestClientFactory') |  |

##### Remarks

Initializes a new instance of the [Curl](#T-Bb-Curls-Curl 'Bb.Curls.Curl') class with an optional factory.

<a name='M-Bb-Curls-Curl-CallAsync'></a>
### CallAsync() `method`

##### Summary

Executes a REST call based on the cURL command represented by the string.

##### Returns

A task that represents the asynchronous operation. The task result contains the [RestResponse](#T-RestSharp-RestResponse 'RestSharp.RestResponse').

##### Parameters

This method has no parameters.

##### Example

```C#
string curlCommand = "curl -X GET https://api.example.com/resource".AsCurl();
var response = await curlCommand.CallRestAsync();
Console.WriteLine(response?.Content);
```

##### Remarks

This method interprets the string as a cURL command and executes it using the default REST client.

<a name='M-Bb-Curls-Curl-CallAsync``1'></a>
### CallAsync\`\`1() `method`

##### Summary

Executes a REST call based on the cURL command and returns a typed response.

##### Returns

A task that represents the asynchronous operation. The task result contains the [RestResponse\`1](#T-RestSharp-RestResponse`1 'RestSharp.RestResponse`1').

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the response content. |

##### Example

```C#
string curlCommand = "curl -X GET https://api.example.com/resource".AsCurl();
var response = await curlCommand.CallAsync&lt;MyResponseType&gt;();
Console.WriteLine(response?.Data);
```

##### Remarks

This method interprets the string as a cURL command and executes it using the default REST client.

<a name='M-Bb-Curls-Curl-CallStreamAsync'></a>
### CallStreamAsync() `method`

##### Summary

Executes the cURL command asynchronously and returns the response as a stream.

##### Returns

A task representing the asynchronous operation, with a result of [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream').

##### Parameters

This method has no parameters.

##### Example

```C#
string curlCommand = "curl -X GET https://api.example.com/resource".AsCurl();
using var stream = await curlCommand.CallStreamAsync();
```

##### Remarks

This method interprets the string as a cURL command and executes it using the default REST client, returning the response as a stream.

<a name='M-Bb-Curls-Curl-GetArgument'></a>
### GetArgument() `method`

##### Summary

Prepares the arguments required to execute the cURL command.

##### Returns

A tuple containing the [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient'), [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest'), and [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken'), or `null` if the request could not be prepared.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Bb.Exceptions.MissingVariableException](#T-Bb-Exceptions-MissingVariableException 'Bb.Exceptions.MissingVariableException') | Thrown if required variables are missing in the command. |

##### Remarks

This method resolves the cURL command, maps variables, and prepares the HTTP client and request for execution.

<a name='M-Bb-Curls-Curl-LastChance-System-Func{System-String,System-Object}-'></a>
### LastChance(resolveVariables) `method`

##### Summary

Sets the function to resolve variables for the cURL command if the variable is not yet known.

##### Returns

fluent syntax

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resolveVariables | [System.Func{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.String,System.Object}') | function to resolve the value for replace |

<a name='M-Bb-Curls-Curl-WithCancellation-System-Threading-CancellationTokenSource-'></a>
### WithCancellation(cancellationTokenSource) `method`

##### Summary

Sets the cancellation token source for the cURL command.

##### Returns

The current [Curl](#T-Bb-Curls-Curl 'Bb.Curls.Curl') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationTokenSource | [System.Threading.CancellationTokenSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationTokenSource 'System.Threading.CancellationTokenSource') | The cancellation token source to use. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the cancellation token source is null. |

<a name='M-Bb-Curls-Curl-WithCommand-System-String-'></a>
### WithCommand(command) `method`

##### Summary

Sets the cURL command to be executed.

##### Returns

Fluent syntax

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | command to set |

<a name='M-Bb-Curls-Curl-WithConfig-System-Action{RestSharp-RestRequest}-'></a>
### WithConfig(configureRequest) `method`

##### Summary

Sets the function to configure the request before executing it.

##### Returns

Fluent syntax

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configureRequest | [System.Action{RestSharp.RestRequest}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{RestSharp.RestRequest}') | is an action of [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | throw an exception if the configuration action is null. |

<a name='M-Bb-Curls-Curl-WithMap-System-String,System-Object-'></a>
### WithMap(name,value) `method`

##### Summary

Adds or updates a mapping for variable substitution in the command.

##### Returns

The current [Curl](#T-Bb-Curls-Curl 'Bb.Curls.Curl') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the variable. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to substitute for the variable. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the value is null. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the value is empty. |

<a name='T-Bb-Curls-CurlContext'></a>
## CurlContext `type`

##### Namespace

Bb.Curls

##### Summary

Represents the context of a cURL request.

<a name='M-Bb-Curls-CurlContext-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [CurlContext](#T-Bb-Curls-CurlContext 'Bb.Curls.CurlContext') class.

##### Parameters

This constructor has no parameters.

<a name='P-Bb-Curls-CurlContext-Headers'></a>
### Headers `property`

##### Summary

return the list of headers

<a name='P-Bb-Curls-CurlContext-Request'></a>
### Request `property`

##### Summary

Gets or sets the HTTP request to be executed.

<a name='P-Bb-Curls-CurlContext-Url'></a>
### Url `property`

##### Summary

Gets or sets the URL to be used for the HTTP request.

<a name='T-Bb-Curls-CurlInterpreter'></a>
## CurlInterpreter `type`

##### Namespace

Bb.Curls

##### Summary

Convert curl syntax to http request

<a name='M-Bb-Curls-CurlInterpreter-#ctor-System-String[]-'></a>
### #ctor(arguments) `constructor`

##### Summary

Initializes a new instance of the [CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| arguments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The arguments. |

<a name='P-Bb-Curls-CurlInterpreter-ConfigureRequest'></a>
### ConfigureRequest `property`

##### Summary

Gets or sets the action to configure the [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest').

<a name='P-Bb-Curls-CurlInterpreter-IsFailed'></a>
### IsFailed `property`

##### Summary

Gets a value indicating whether the parsing or execution of the curl command has failed.

<a name='P-Bb-Curls-CurlInterpreter-ResultMessage'></a>
### ResultMessage `property`

##### Summary

Gets the result message if the parsing or execution has failed.

<a name='T-Bb-Curls-CurlInterpreterAction'></a>
## CurlInterpreterAction `type`

##### Namespace

Bb.Curls

##### Summary

Represents an action to be executed in the cURL interpreter context.

<a name='M-Bb-Curls-CurlInterpreterAction-#ctor-System-Action{Bb-Curls-CurlInterpreterAction,Bb-Curls-CurlContext},Bb-Curls-Argument[]-'></a>
### #ctor(configureAction,arguments) `constructor`

##### Summary

create a new instance of [CurlInterpreterAction](#T-Bb-Curls-CurlInterpreterAction 'Bb.Curls.CurlInterpreterAction')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configureAction | [System.Action{Bb.Curls.CurlInterpreterAction,Bb.Curls.CurlContext}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Curls.CurlInterpreterAction,Bb.Curls.CurlContext}') |  |
| arguments | [Bb.Curls.Argument[]](#T-Bb-Curls-Argument[] 'Bb.Curls.Argument[]') |  |

<a name='P-Bb-Curls-CurlInterpreterAction-Arguments'></a>
### Arguments `property`

##### Summary

return the list of arguments

<a name='P-Bb-Curls-CurlInterpreterAction-First'></a>
### First `property`

##### Summary

Get the first argument in the list

<a name='P-Bb-Curls-CurlInterpreterAction-FirstValue'></a>
### FirstValue `property`

##### Summary

Get the first value in the list of arguments

<a name='P-Bb-Curls-CurlInterpreterAction-Priority'></a>
### Priority `property`

##### Summary

Get or set the next action to be executed

<a name='M-Bb-Curls-CurlInterpreterAction-Exists-System-String-'></a>
### Exists(name) `method`

##### Summary

Get argument by specified name

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-Curls-CurlInterpreterAction-Get-System-String-'></a>
### Get(name) `method`

##### Summary

Get or set arguments

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-Curls-CurlInterpreterAction-Get-System-Func{Bb-Curls-Argument,System-Boolean}-'></a>
### Get(test) `method`

##### Summary

Get or set arguments

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| test | [System.Func{Bb.Curls.Argument,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Bb.Curls.Argument,System.Boolean}') |  |

<a name='T-Bb-Curls-CurlLexer'></a>
## CurlLexer `type`

##### Namespace

Bb.Curls

##### Summary

Lexer that tokenize a cURL command line.

<a name='M-Bb-Curls-CurlLexer-#ctor-System-String-'></a>
### #ctor(args) `constructor`

##### Summary

Initializes a new instance of the [CurlLexer](#T-Bb-Curls-CurlLexer 'Bb.Curls.CurlLexer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The cURL command line arguments to tokenize. |

<a name='P-Bb-Curls-CurlLexer-Current'></a>
### Current `property`

##### Summary

Gets the current token from the command line.

<a name='P-Bb-Curls-CurlLexer-CurrentPosition'></a>
### CurrentPosition `property`

##### Summary

Gets the current position in the command line being tokenized.

<a name='M-Bb-Curls-CurlLexer-Next'></a>
### Next() `method`

##### Summary

Advances to the next token in the cURL command line.

##### Returns

`true` if a token is available; otherwise, `false`.

##### Parameters

This method has no parameters.

##### Example

```C#
var lexer = new CurlLexer("curl -X GET 'https://api.example.com'");
while (lexer.Next())
{
    Console.WriteLine(lexer.Current);
}
```

##### Remarks

This method reads the next token from the command line, handling quoted strings and escaped characters.

<a name='M-Bb-Curls-CurlLexer-ParseTextChain-System-Char-'></a>
### ParseTextChain(charset) `method`

##### Summary

Parses a quoted text chain from the command line.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| charset | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character used to delimit the quoted text (e.g., single or double quotes). |

##### Remarks

This method handles escaped characters within the quoted text.

<a name='T-Bb-Curls-CurlParserExtension'></a>
## CurlParserExtension `type`

##### Namespace

Bb.Curls

##### Summary

Specialized curl command parser

<a name='M-Bb-Curls-CurlParserExtension-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes the [CurlParserExtension](#T-Bb-Curls-CurlParserExtension 'Bb.Curls.CurlParserExtension') class.

##### Parameters

This method has no parameters.

<a name='M-Bb-Curls-CurlParserExtension-AsCurl-System-String,Bb-Interfaces-IRestClientFactory-'></a>
### AsCurl(self,factory) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| factory | [Bb.Interfaces.IRestClientFactory](#T-Bb-Interfaces-IRestClientFactory 'Bb.Interfaces.IRestClientFactory') |  |

<a name='M-Bb-Curls-CurlParserExtension-IsUrl-System-String-'></a>
### IsUrl(self) `method`

##### Summary

Determines whether this instance is an URL.

##### Returns

`true` if the specified self is URL; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The self text to test. |

<a name='M-Bb-Curls-CurlParserExtension-ParseCurlLine-System-String-'></a>
### ParseCurlLine(lineArg) `method`

##### Summary

Parses the curl line.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lineArg | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The line argument. |

<a name='T-Bb-GlobalSettings'></a>
## GlobalSettings `type`

##### Namespace

Bb

##### Summary

Provides global settings and factories for creating REST client instances and options.

##### Remarks

This class manages the creation and configuration of REST client factories and option factories. 
It provides static properties to access and modify these factories globally.

<a name='M-Bb-GlobalSettings-#ctor'></a>
### #ctor() `constructor`

##### Summary



##### Parameters

This constructor has no parameters.

<a name='P-Bb-GlobalSettings-CreateFactory'></a>
### CreateFactory `property`

##### Summary

Gets or sets the factory function for creating [IRestClientFactory](#T-Bb-Interfaces-IRestClientFactory 'Bb.Interfaces.IRestClientFactory') instances.

##### Example

```C#
GlobalSettings.CreateFactory = () =&gt; new CustomRestClientFactory();
var factory = GlobalSettings.CreateFactory();
```

##### Remarks

By default, this property is initialized to create a new [RestClientFactory](#T-Bb-Services-RestClientFactory 'Bb.Services.RestClientFactory') using the [OptionFactory](#P-Bb-GlobalSettings-OptionFactory 'Bb.GlobalSettings.OptionFactory').

<a name='P-Bb-GlobalSettings-OptionFactory'></a>
### OptionFactory `property`

##### Summary

Gets or sets the global [IOptionClientFactory](#T-Bb-Interfaces-IOptionClientFactory 'Bb.Interfaces.IOptionClientFactory') instance.

##### Example

```C#
var optionFactory = GlobalSettings.OptionFactory;
var options = optionFactory.CreateOptions();
```

##### Remarks

If the factory is not already set, it is initialized with a default [OptionClientFactory](#T-Bb-Services-OptionClientFactory 'Bb.Services.OptionClientFactory') instance.

<a name='P-Bb-GlobalSettings-ServiceProvider'></a>
### ServiceProvider `property`

##### Summary

Gets or sets the global [IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') instance.

<a name='P-Bb-GlobalSettings-UrlClientFactory'></a>
### UrlClientFactory `property`

##### Summary

Gets or sets the global [IRestClientFactory](#T-Bb-Interfaces-IRestClientFactory 'Bb.Interfaces.IRestClientFactory') instance.

##### Example

```C#
var factory = GlobalSettings.UrlClientFactory;
var client = factory.CreateClient();
```

##### Remarks

If the factory is not already set, it is created using the [CreateFactory](#P-Bb-GlobalSettings-CreateFactory 'Bb.GlobalSettings.CreateFactory') function.

<a name='T-Bb-Curls-Headers'></a>
## Headers `type`

##### Namespace

Bb.Curls

##### Summary

Represents a collection of HTTP headers.

<a name='M-Bb-Curls-Headers-Add-System-String,System-String-'></a>
### Add(header,value) `method`

##### Summary

Add the header in the collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| header | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | header name |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | header value |

<a name='M-Bb-Curls-Headers-AddOrReplace-System-String,System-String-'></a>
### AddOrReplace(header,value) `method`

##### Summary

Add or replace a header in the collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| header | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | header name |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | header value |

<a name='M-Bb-Curls-Headers-Contains-System-String-'></a>
### Contains(header) `method`

##### Summary

evaluate if the header is present in the collection

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| header | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | header name |

<a name='M-Bb-Curls-Headers-TryGetFirst-System-String,System-String@-'></a>
### TryGetFirst(header,result) `method`

##### Summary

try to resolve header by name of the name

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| header | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | header name |
| result | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') |  |

<a name='T-Bb-Interfaces-IFactory'></a>
## IFactory `type`

##### Namespace

Bb.Interfaces

##### Summary

Represents a generic factory interface for creating objects.

##### Remarks

This interface serves as a marker for factory implementations that are responsible for creating objects.

<a name='T-Bb-Urls-INameValueListBase`1'></a>
## INameValueListBase\`1 `type`

##### Namespace

Bb.Urls

##### Summary

Defines common methods for INameValueList and IReadOnlyNameValueList.

<a name='M-Bb-Urls-INameValueListBase`1-Contains-System-String-'></a>
### Contains() `method`

##### Summary

True if any items with the given Name exist.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-INameValueListBase`1-Contains-System-String,`0-'></a>
### Contains() `method`

##### Summary

True if any item with the given Name and Value exists.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-INameValueListBase`1-FirstOrDefault-System-String-'></a>
### FirstOrDefault() `method`

##### Summary

Returns the first Value of the given Name if one exists, otherwise null or default value.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-INameValueListBase`1-GetAll-System-String-'></a>
### GetAll() `method`

##### Summary

Gets all Values of the given Name.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-INameValueListBase`1-TryGetFirst-System-String,`0@-'></a>
### TryGetFirst() `method`

##### Summary

Gets the first Value of the given Name, if one exists.

##### Returns

true if any item of the given name is found, otherwise false.

##### Parameters

This method has no parameters.

<a name='T-Bb-Urls-INameValueList`1'></a>
## INameValueList\`1 `type`

##### Namespace

Bb.Urls

##### Summary

Defines an ordered collection of Name/Value pairs where duplicate names are allowed but aren't typical.

<a name='M-Bb-Urls-INameValueList`1-Add-System-String,`0-'></a>
### Add() `method`

##### Summary

Adds a new Name/Value pair.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-INameValueList`1-AddOrReplace-System-String,`0-'></a>
### AddOrReplace() `method`

##### Summary

Replaces the first occurrence of the given Name with the given Value and removes any others,
or adds a new Name/Value pair if none exist.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-INameValueList`1-Remove-System-String-'></a>
### Remove() `method`

##### Summary

Removes all items of the given Name.

##### Returns

true if any item of the given name is found, otherwise false.

##### Parameters

This method has no parameters.

<a name='T-Bb-Interfaces-INamedFactory`2'></a>
## INamedFactory\`2 `type`

##### Namespace

Bb.Interfaces

##### Summary

Represents a factory interface for creating objects of type `TResult` using a key of type `TKey`.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey | The type of the key used to create objects. |
| TResult | The type of object that the factory creates. |

##### Example

```C#
public class MyNamedFactory : INamedFactory&lt;string, MyClass&gt;
{
    public MyClass Create(string name)
    {
        return new MyClass { Name = name };
    }
}
```

##### Remarks

This interface defines a method for creating objects based on a provided key.

<a name='M-Bb-Interfaces-INamedFactory`2-Create-`0-'></a>
### Create(name) `method`

##### Summary

Creates an instance of type `TResult` using the specified key.

##### Returns

An instance of `TResult`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [\`0](#T-`0 '`0') | The key used to create the object. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `name` is null. |

##### Remarks

This method is responsible for creating and returning an object of the specified type based on the provided key.

<a name='T-Bb-Interfaces-IOptionClientFactory'></a>
## IOptionClientFactory `type`

##### Namespace

Bb.Interfaces

##### Summary

Represents a factory interface for creating [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instances using a string key.

##### Example

```C#
public class OptionClientFactory : IOptionClientFactory
{
    public RestClientOptions Create(string name)
    {
        // Example implementation
        return new RestClientOptions { BaseUrl = new Uri($"https://api.example.com/{name}") };
    }
}
```

##### Remarks

This interface extends [INamedFactory\`2](#T-Bb-Interfaces-INamedFactory`2 'Bb.Interfaces.INamedFactory`2') to provide a mechanism for creating [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') based on a string key.

<a name='P-Bb-Interfaces-IOptionClientFactory-Interceptor'></a>
### Interceptor `property`

##### Summary

Gets or sets an interceptor for modifying the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') before use.

<a name='T-Bb-Urls-IReadOnlyNameValueList`1'></a>
## IReadOnlyNameValueList\`1 `type`

##### Namespace

Bb.Urls

##### Summary

Defines a read-only ordered collection of Name/Value pairs where duplicate names are allowed but aren't typical.

<a name='T-Bb-Interfaces-IRestClientFactory'></a>
## IRestClientFactory `type`

##### Namespace

Bb.Interfaces

##### Summary

Represents a factory interface for creating [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instances.

##### Example

```C#
 public class RestClientFactory : IRestClientFactory
 {
     public RestClient Create(Uri uri)
     {
         return new RestClient(uri);
     }
     public RestClient Create(string name)
     {
         return new RestClient(new Uri($"https://api.example.com/{name}"));
     }
     public RestClient Create(Url url)
     {
         return new RestClient(url.Root);
     }
 }
 
```

##### Remarks

This interface extends multiple [INamedFactory\`2](#T-Bb-Interfaces-INamedFactory`2 'Bb.Interfaces.INamedFactory`2') interfaces to provide mechanisms for creating [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instances 
 based on different types of keys, such as [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri'), [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), and [Url](#T-Bb-Urls-Url 'Bb.Urls.Url').

<a name='T-Bb-Services-LocalLogger'></a>
## LocalLogger `type`

##### Namespace

Bb.Services

<a name='M-Bb-Services-LocalLogger-#ctor-System-String-'></a>
### #ctor(categoryName) `constructor`

##### Summary

Initializes a new instance of the [LocalLogger](#T-Bb-Services-LocalLogger 'Bb.Services.LocalLogger') class with the specified category name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| categoryName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The category name for the logger. Default is "LogInterceptor". |

##### Remarks

This constructor initializes the logger with a default output writer set to the console.

<a name='M-Bb-Services-LocalLogger-#ctor-System-String,System-IO-TextWriter-'></a>
### #ctor(categoryName,writer) `constructor`

##### Summary

Initializes a new instance of the [LocalLogger](#T-Bb-Services-LocalLogger 'Bb.Services.LocalLogger') class with the specified category name and writer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| categoryName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The category name for the logger. Must not be null. |
| writer | [System.IO.TextWriter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextWriter 'System.IO.TextWriter') | The [TextWriter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextWriter 'System.IO.TextWriter') instance to use for logging output. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `writer` is null. |

##### Remarks

This constructor initializes the logger with a custom output writer.

<a name='P-Bb-Services-LocalLogger-Level'></a>
### Level `property`

##### Summary

Gets or sets the log level for the logger.

<a name='M-Bb-Services-LocalLogger-BeginScope``1-``0-'></a>
### BeginScope\`\`1(state) `method`

##### Summary

Begins a logical operation scope.

##### Returns

An [IDisposable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IDisposable 'System.IDisposable') that ends the logical operation scope on disposal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| state | [\`\`0](#T-``0 '``0') | The state object to associate with the scope. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TState | The type of the state object to associate with the scope. |

##### Remarks

This method returns a no-operation disposable object as the logger does not support scoped logging.

<a name='M-Bb-Services-LocalLogger-GetLogLevelString-Microsoft-Extensions-Logging-LogLevel-'></a>
### GetLogLevelString(logLevel) `method`

##### Summary

Converts the log level to its string representation.

##### Returns

A string representing the log level.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logLevel | [Microsoft.Extensions.Logging.LogLevel](#T-Microsoft-Extensions-Logging-LogLevel 'Microsoft.Extensions.Logging.LogLevel') | The log level to convert. |

##### Remarks

This method maps the [LogLevel](#T-Microsoft-Extensions-Logging-LogLevel 'Microsoft.Extensions.Logging.LogLevel') enumeration to its corresponding string representation.

<a name='M-Bb-Services-LocalLogger-IsEnabled-Microsoft-Extensions-Logging-LogLevel-'></a>
### IsEnabled(logLevel) `method`

##### Summary

Checks if the specified log level is enabled.

##### Returns

`true` if the specified log level is enabled; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logLevel | [Microsoft.Extensions.Logging.LogLevel](#T-Microsoft-Extensions-Logging-LogLevel 'Microsoft.Extensions.Logging.LogLevel') | The log level to check. |

##### Remarks

By default, all log levels except [None](#F-Microsoft-Extensions-Logging-LogLevel-None 'Microsoft.Extensions.Logging.LogLevel.None') are enabled.

<a name='M-Bb-Services-LocalLogger-Log``1-Microsoft-Extensions-Logging-LogLevel,Microsoft-Extensions-Logging-EventId,``0,System-Exception,System-Func{``0,System-Exception,System-String}-'></a>
### Log\`\`1(logLevel,eventId,state,exception,formatter) `method`

##### Summary

Logs a message with the specified log level and event data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logLevel | [Microsoft.Extensions.Logging.LogLevel](#T-Microsoft-Extensions-Logging-LogLevel 'Microsoft.Extensions.Logging.LogLevel') | The log level of the message. |
| eventId | [Microsoft.Extensions.Logging.EventId](#T-Microsoft-Extensions-Logging-EventId 'Microsoft.Extensions.Logging.EventId') | The event ID associated with the log message. |
| state | [\`\`0](#T-``0 '``0') | The state object to log. Must not be null. |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception to log, if any. Can be null. |
| formatter | [System.Func{\`\`0,System.Exception,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{``0,System.Exception,System.String}') | The function to format the log message. Must not be null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TState | The type of the state object to log. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `state` or `formatter` is null. |

##### Example

```C#
var logger = new LocalLogger("MyCategory");
logger.Log(LogLevel.Information, new EventId(1), "This is a log message.", null, (state, ex) =&gt; state.ToString());
```

##### Remarks

This method formats and writes the log message to the configured output writer and the trace listeners, if any.

<a name='T-Bb-Services-LocalLogger`1'></a>
## LocalLogger\`1 `type`

##### Namespace

Bb.Services

##### Summary

A generic logger that implements LocalLogger{TCategoryName} and inherits from LocalLogger.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TCategoryName | The category type for the logger. |

<a name='M-Bb-Services-LocalLogger`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [LocalLogger\`1](#T-Bb-Services-LocalLogger`1 'Bb.Services.LocalLogger`1') class.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Services-LocalLogger`1-#ctor-System-IO-TextWriter-'></a>
### #ctor(writer) `constructor`

##### Summary

Initializes a new instance of the [LocalLogger\`1](#T-Bb-Services-LocalLogger`1 'Bb.Services.LocalLogger`1') class with a custom writer.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| writer | [System.IO.TextWriter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextWriter 'System.IO.TextWriter') | The [TextWriter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextWriter 'System.IO.TextWriter') instance to use for logging output. |

<a name='T-Bb-Helpers-LogConfigurationExtension'></a>
## LogConfigurationExtension `type`

##### Namespace

Bb.Helpers

##### Summary

Log extensions for HTTP requests and responses.

<a name='M-Bb-Helpers-LogConfigurationExtension-LogAll-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}-'></a>
### LogAll(self) `method`

##### Summary

Logs all details of an HTTP request, including headers and body.

##### Returns

The configured [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}](#T-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage} 'Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}') | The [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance to configure. Must not be null. |

##### Example

```C#
var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
logConfig.LogAll();
```

##### Remarks

This method adds logging rules to log both the headers and body of an HTTP request.

<a name='M-Bb-Helpers-LogConfigurationExtension-LogAll-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage}-'></a>
### LogAll(self) `method`

##### Summary

Logs all details of an HTTP response, including headers and body.

##### Returns

The configured [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage}](#T-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage} 'Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage}') | The [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance to configure. Must not be null. |

##### Example

```C#
var logConfig = new LogConfiguration&lt;HttpResponseMessage&gt;();
logConfig.LogAll();
```

##### Remarks

This method adds logging rules to log both the headers and body of an HTTP response.

<a name='M-Bb-Helpers-LogConfigurationExtension-LogBody-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}-'></a>
### LogBody(self) `method`

##### Summary

Logs the body of an HTTP request.

##### Returns

The configured [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}](#T-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage} 'Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}') | The [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance to configure. Must not be null. |

##### Example

```C#
var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
logConfig.LogBody();
```

##### Remarks

This method adds a logging rule to log the body of an HTTP request.

<a name='M-Bb-Helpers-LogConfigurationExtension-LogBody-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage}-'></a>
### LogBody(self) `method`

##### Summary

Logs the body of an HTTP response.

##### Returns

The configured [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage}](#T-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage} 'Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage}') | The [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance to configure. Must not be null. |

##### Example

```C#
var logConfig = new LogConfiguration&lt;HttpResponseMessage&gt;();
logConfig.LogBody();
```

##### Remarks

This method adds a logging rule to log the body of an HTTP response.

<a name='M-Bb-Helpers-LogConfigurationExtension-LogHeader-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}-'></a>
### LogHeader(self) `method`

##### Summary

Logs the headers of an HTTP request.

##### Returns

The configured [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}](#T-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage} 'Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}') | The [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance to configure. Must not be null. |

##### Example

```C#
var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
logConfig.LogHeader();
```

##### Remarks

This method adds a logging rule to log the headers of an HTTP request.

<a name='M-Bb-Helpers-LogConfigurationExtension-LogHeader-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage}-'></a>
### LogHeader(self) `method`

##### Summary

Logs the headers of an HTTP response.

##### Returns

The configured [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage}](#T-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage} 'Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage}') | The [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance to configure. Must not be null. |

##### Example

```C#
var logConfig = new LogConfiguration&lt;HttpResponseMessage&gt;();
logConfig.LogHeader();
```

##### Remarks

This method adds a logging rule to log the headers of an HTTP response.

<a name='M-Bb-Helpers-LogConfigurationExtension-LogStart-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}-'></a>
### LogStart(self) `method`

##### Summary

Logs the start of an HTTP request.

##### Returns

The configured [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}](#T-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage} 'Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}') | The [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance to configure. Must not be null. |

##### Example

```C#
var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
logConfig.LogStart();
```

##### Remarks

This method adds a logging rule to log the HTTP request method and URI at the start of the request.

<a name='T-Bb-Interceptors-LogConfiguration`1'></a>
## LogConfiguration\`1 `type`

##### Namespace

Bb.Interceptors

##### Summary

Represents a configuration for logging messages of type `T`.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-Bb-Interceptors-LogConfiguration`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') class.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor initializes the list of logging rules for the specified type `T`.

<a name='F-Bb-Interceptors-LogConfiguration`1-_rules'></a>
### _rules `constants`

##### Summary

The list of logging rules for messages of type `T`.

<a name='P-Bb-Interceptors-LogConfiguration`1-HasRule'></a>
### HasRule `property`

##### Summary

Gets a value indicating whether any logging rules are configured.

##### Remarks

This property indicates whether the [LogConfiguration\`1](#T-Bb-Interceptors-LogConfiguration`1 'Bb.Interceptors.LogConfiguration`1') instance has any rules defined.

<a name='M-Bb-Interceptors-LogConfiguration`1-AddRule-System-Func{`0,System-Text-StringBuilder,System-Threading-CancellationToken,System-Threading-Tasks-ValueTask}-'></a>
### AddRule(rule) `method`

##### Summary

Adds a logging rule to the configuration.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rule | [System.Func{\`0,System.Text.StringBuilder,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0,System.Text.StringBuilder,System.Threading.CancellationToken,System.Threading.Tasks.ValueTask}') | The rule to add, represented as a function that processes a message of type `T`. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `rule` is null. |

##### Example

```C#
var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
logConfig.AddRule(async (message, logger, cancellationToken) =&gt;
{
    logger.AppendLine($"Request: {message.Method} {message.RequestUri}");
    await Task.CompletedTask;
});
```

##### Remarks

This method allows adding custom logging rules that define how messages of type `T` should be logged.

<a name='M-Bb-Interceptors-LogConfiguration`1-Log-`0,System-Text-StringBuilder,System-Threading-CancellationToken-'></a>
### Log(message,logger,cancellationToken) `method`

##### Summary

Logs a message using the configured rules.

##### Returns

A [ValueTask](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask') representing the asynchronous logging operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`0](#T-`0 '`0') | The message of type `T` to log. Must not be null. |
| logger | [System.Text.StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') | The [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') instance to append log messages to. Must not be null. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to observe while logging. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `message` or `logger` is null. |

##### Example

```C#
var logConfig = new LogConfiguration&lt;HttpRequestMessage&gt;();
var logger = new StringBuilder();
await logConfig.Log(requestMessage, logger, CancellationToken.None);
Console.WriteLine(logger.ToString());
```

##### Remarks

This method iterates through all configured logging rules and applies them to the provided message.

<a name='T-Bb-Interceptors-LogInterceptor'></a>
## LogInterceptor `type`

##### Namespace

Bb.Interceptors

##### Summary

Represents class for intercept and log

<a name='M-Bb-Interceptors-LogInterceptor-#ctor-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage},Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage},Microsoft-Extensions-Logging-ILogger-'></a>
### #ctor(configurationRequest,configurationResponse,logger) `constructor`

##### Summary

Initializes a new instance of the [LogInterceptor](#T-Bb-Interceptors-LogInterceptor 'Bb.Interceptors.LogInterceptor') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configurationRequest | [Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}](#T-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage} 'Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}') | The logging configuration for HTTP requests. Must not be null. |
| configurationResponse | [Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage}](#T-Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage} 'Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage}') | The logging configuration for HTTP responses. Must not be null. |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | The logger instance to use for logging. Can be null. |

##### Remarks

This constructor sets up the interceptor with the provided logging configurations and logger.

<a name='P-Bb-Interceptors-LogInterceptor-CurrentLogger'></a>
### CurrentLogger `property`

##### Summary

Gets or sets the logger instance used for logging.

##### Remarks

If no logger is explicitly set, a default local logger is created.

<a name='M-Bb-Interceptors-LogInterceptor-AfterHttpRequest-System-Net-Http-HttpResponseMessage,System-Threading-CancellationToken-'></a>
### AfterHttpRequest(responseMessage,cancellationToken) `method`

##### Summary

Executes after an HTTP request is completed.

##### Returns

A [ValueTask](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| responseMessage | [System.Net.Http.HttpResponseMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage') | The HTTP response message to log. Must not be null. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to observe while logging. |

##### Example

```C#
var interceptor = new LogInterceptor(requestConfig, responseConfig, logger);
await interceptor.AfterHttpRequest(responseMessage, CancellationToken.None);
```

##### Remarks

This method logs the HTTP response details, including status code, reason phrase, and elapsed time, if logging rules are configured.

<a name='M-Bb-Interceptors-LogInterceptor-BeforeHttpRequest-System-Net-Http-HttpRequestMessage,System-Threading-CancellationToken-'></a>
### BeforeHttpRequest(requestMessage,cancellationToken) `method`

##### Summary

Executes before an HTTP request is sent.

##### Returns

A [ValueTask](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestMessage | [System.Net.Http.HttpRequestMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestMessage 'System.Net.Http.HttpRequestMessage') | The HTTP request message to log. Must not be null. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to observe while logging. |

##### Example

```C#
var interceptor = new LogInterceptor(requestConfig, responseConfig, logger);
await interceptor.BeforeHttpRequest(requestMessage, CancellationToken.None);
```

##### Remarks

This method logs the HTTP request details if logging rules are configured and starts a stopwatch to measure the request duration.

<a name='M-Bb-Interceptors-LogInterceptor-CreateLogger'></a>
### CreateLogger() `method`

##### Summary

Creates a default local logger instance.

##### Returns

An [ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') instance with a default configuration.

##### Parameters

This method has no parameters.

##### Remarks

This method creates a logger with the name "http client" if no logger is provided.

<a name='T-Bb-Exceptions-MissingVariableException'></a>
## MissingVariableException `type`

##### Namespace

Bb.Exceptions

##### Summary

Represents an exception that is thrown when a required variable is missing.

<a name='M-Bb-Exceptions-MissingVariableException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [MissingVariableException](#T-Bb-Exceptions-MissingVariableException 'Bb.Exceptions.MissingVariableException') class.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor creates an exception without any additional context or message.

<a name='M-Bb-Exceptions-MissingVariableException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Initializes a new instance of the [MissingVariableException](#T-Bb-Exceptions-MissingVariableException 'Bb.Exceptions.MissingVariableException') class with a specified error message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | List of variable not found. |

##### Example

```C#
throw new MissingVariableException("The required variable 'X' is missing.");
```

##### Remarks

Use this constructor to provide a custom error message when throwing the exception.

<a name='M-Bb-Exceptions-MissingVariableException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,inner) `constructor`

##### Summary

Initializes a new instance of the [MissingVariableException](#T-Bb-Exceptions-MissingVariableException 'Bb.Exceptions.MissingVariableException') class with a specified error message and a reference to the inner exception that is the cause of this exception.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message that describes the error. |
| inner | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception that is the cause of the current exception. |

##### Example

```C#
try
{
    // Some operation that causes an exception
}
catch (Exception ex)
{
    throw new MissingVariableException("A required variable is missing.", ex);
}
```

##### Remarks

Use this constructor to provide additional context by including an inner exception.

<a name='T-Bb-Urls-NameValueList`1'></a>
## NameValueList\`1 `type`

##### Namespace

Bb.Urls

##### Summary

Represents an ordered collection of Name/Value pairs where duplicate names are allowed but aren't typical.
Useful for scenarios where a dictionary would work great if not for edge cases (e.g., headers, cookies).

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | The type of the value associated with each name. |

<a name='M-Bb-Urls-NameValueList`1-#ctor-System-Boolean-'></a>
### #ctor(caseSensitiveNames) `constructor`

##### Summary

Instantiates a new empty [NameValueList\`1](#T-Bb-Urls-NameValueList`1 'Bb.Urls.NameValueList`1').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| caseSensitiveNames | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicates whether name comparisons should be case-sensitive. |

<a name='M-Bb-Urls-NameValueList`1-#ctor-System-Collections-Generic-IEnumerable{System-ValueTuple{System-String,`0}},System-Boolean-'></a>
### #ctor(items,caseSensitiveNames) `constructor`

##### Summary

Instantiates a new [NameValueList\`1](#T-Bb-Urls-NameValueList`1 'Bb.Urls.NameValueList`1') with the provided Name/Value pairs.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.IEnumerable{System.ValueTuple{System.String,\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.ValueTuple{System.String,`0}}') | The initial collection of Name/Value pairs. |
| caseSensitiveNames | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicates whether name comparisons should be case-sensitive. |

<a name='M-Bb-Urls-NameValueList`1-Add-System-String,`0-'></a>
### Add(name,value) `method`

##### Summary

Adds a new Name/Value pair to the list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the pair. |
| value | [\`0](#T-`0 '`0') | The value associated with the name. |

##### Example

```C#
var list = new NameValueList&lt;string&gt;(true);
list.Add("Key", "Value");
```

<a name='M-Bb-Urls-NameValueList`1-AddOrReplace-System-String,`0-'></a>
### AddOrReplace(name,value) `method`

##### Summary

Adds a new Name/Value pair or replaces the value of an existing name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the pair. |
| value | [\`0](#T-`0 '`0') | The value to associate with the name. |

##### Example

```C#
var list = new NameValueList&lt;string&gt;(true);
list.AddOrReplace("Key", "Value1");
list.AddOrReplace("Key", "Value2"); // Replaces "Value1" with "Value2".
```

##### Remarks

If the name already exists, its value is replaced. If the name appears multiple times, all but the first occurrence are removed.

<a name='M-Bb-Urls-NameValueList`1-Contains-System-String-'></a>
### Contains(name) `method`

##### Summary

Determines whether the list contains a Name/Value pair with the specified name.

##### Returns

`true` if the name exists; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name to search for. |

##### Example

```C#
var list = new NameValueList&lt;string&gt;(true);
list.Add("Key", "Value");
var exists = list.Contains("Key"); // Returns true.
```

<a name='M-Bb-Urls-NameValueList`1-Contains-System-String,`0-'></a>
### Contains(name,value) `method`

##### Summary

Determines whether the list contains a specific Name/Value pair.

##### Returns

`true` if the Name/Value pair exists; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name to search for. |
| value | [\`0](#T-`0 '`0') | The value to search for. |

##### Example

```C#
var list = new NameValueList&lt;string&gt;(true);
list.Add("Key", "Value");
var exists = list.Contains("Key", "Value"); // Returns true.
```

<a name='M-Bb-Urls-NameValueList`1-FirstOrDefault-System-String-'></a>
### FirstOrDefault(name) `method`

##### Summary

Returns the first value associated with the specified name, or `null` if none exist.

##### Returns

The first value associated with the name, or `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name to search for. |

##### Example

```C#
var list = new NameValueList&lt;string&gt;(true);
list.Add("Key", "Value");
var value = list.FirstOrDefault("Key"); // Returns "Value".
```

<a name='M-Bb-Urls-NameValueList`1-GetAll-System-String-'></a>
### GetAll(name) `method`

##### Summary

Retrieves all values associated with the specified name.

##### Returns

An enumerable collection of values associated with the name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name to search for. |

##### Example

```C#
var list = new NameValueList&lt;string&gt;(true);
list.Add("Key", "Value1");
list.Add("Key", "Value2");
var values = list.GetAll("Key"); // Returns ["Value1", "Value2"].
```

<a name='M-Bb-Urls-NameValueList`1-Remove-System-String-'></a>
### Remove(name) `method`

##### Summary

Removes all Name/Value pairs with the specified name.

##### Returns

`true` if at least one pair was removed; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name to remove. |

##### Example

```C#
var list = new NameValueList&lt;string&gt;(true);
list.Add("Key", "Value");
list.Remove("Key"); // Removes the pair with name "Key".
```

<a name='M-Bb-Urls-NameValueList`1-TryGetFirst-System-String,`0@-'></a>
### TryGetFirst(name,value) `method`

##### Summary

Attempts to retrieve the first value associated with the specified name.

##### Returns

`true` if a value was found; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name to search for. |
| value | [\`0@](#T-`0@ '`0@') | When this method returns, contains the first value associated with the name, if found; otherwise, the default value for `TValue`. |

##### Example

```C#
var list = new NameValueList&lt;string&gt;(true);
list.Add("Key", "Value");
if (list.TryGetFirst("Key", out var value))
{
    Console.WriteLine(value); // Outputs "Value".
}
```

<a name='T-Bb-Services-LocalLogger-NoopDisposable'></a>
## NoopDisposable `type`

##### Namespace

Bb.Services.LocalLogger

##### Summary

Represents a no-operation disposable object.

<a name='T-Bb-NullValueHandling'></a>
## NullValueHandling `type`

##### Namespace

Bb

##### Summary

Describes how to handle null values in query parameters.

<a name='F-Bb-NullValueHandling-Ignore'></a>
### Ignore `constants`

##### Summary

Don't add to query string, but leave any existing value unchanged.

<a name='F-Bb-NullValueHandling-NameOnly'></a>
### NameOnly `constants`

##### Summary

Set as name without value in query string.

<a name='F-Bb-NullValueHandling-Remove'></a>
### Remove `constants`

##### Summary

Don't add to query string, remove any existing value.

<a name='T-Bb-Services-OptionClientFactory'></a>
## OptionClientFactory `type`

##### Namespace

Bb.Services

##### Summary

Factory class for creating and configuring [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instances.

<a name='M-Bb-Services-OptionClientFactory-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [OptionClientFactory](#T-Bb-Services-OptionClientFactory 'Bb.Services.OptionClientFactory') class using a service provider.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor initializes the factory with a default configuration and sets the debug mode based on whether a debugger is attached.

<a name='M-Bb-Services-OptionClientFactory-#ctor-System-IServiceProvider-'></a>
### #ctor(serviceProvider) `constructor`

##### Summary

Initializes a new instance of the [OptionClientFactory](#T-Bb-Services-OptionClientFactory 'Bb.Services.OptionClientFactory') class using a service provider.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | The [IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') instance to resolve dependencies. Must not be null. |

##### Remarks

This constructor initializes the factory with a default configuration and sets the debug mode based on whether a debugger is attached.

<a name='M-Bb-Services-OptionClientFactory-#ctor-Microsoft-Extensions-Options-IOptions{Bb-Services-ClientRestOption}-'></a>
### #ctor(configuration) `constructor`

##### Summary

Initializes a new instance of the [OptionClientFactory](#T-Bb-Services-OptionClientFactory 'Bb.Services.OptionClientFactory') class using configuration options.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Options.IOptions{Bb.Services.ClientRestOption}](#T-Microsoft-Extensions-Options-IOptions{Bb-Services-ClientRestOption} 'Microsoft.Extensions.Options.IOptions{Bb.Services.ClientRestOption}') | The [IOptions\`1](#T-Microsoft-Extensions-Options-IOptions`1 'Microsoft.Extensions.Options.IOptions`1') instance containing the client configuration. Can be null. |

##### Remarks

This constructor initializes the factory with the provided configuration or a default configuration if none is provided.

<a name='P-Bb-Services-OptionClientFactory-Interceptor'></a>
### Interceptor `property`

##### Summary

Gets or sets the interceptor for the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions').

<a name='M-Bb-Services-OptionClientFactory-Configure-Bb-Urls-Url,System-Action{RestSharp-RestClientOptions}-'></a>
### Configure(url,action) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') for a specific URL.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') instance to configure. Must not be null. |
| action | [System.Action{RestSharp.RestClientOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{RestSharp.RestClientOptions}') | The action to configure the options. Must not be null. |

##### Example

```C#
factory.Configure(new Url("https://example.com"), options =&gt; options.Timeout = TimeSpan.FromSeconds(30));
```

##### Remarks

This method associates a configuration action with a specific URL.

<a name='M-Bb-Services-OptionClientFactory-Configure-System-Uri,System-Action{RestSharp-RestClientOptions}-'></a>
### Configure(uri,action) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') for a specific URI.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') instance to configure. Must not be null. |
| action | [System.Action{RestSharp.RestClientOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{RestSharp.RestClientOptions}') | The action to configure the options. Must not be null. |

##### Example

```C#
factory.Configure(new Uri("https://example.com"), options =&gt; options.Timeout = TimeSpan.FromSeconds(30));
```

##### Remarks

This method associates a configuration action with a specific URI.

<a name='M-Bb-Services-OptionClientFactory-Configure-System-String,System-Action{RestSharp-RestClientOptions}-'></a>
### Configure(name,action) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') for a specific name or URL.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name or URL to configure. Must not be null or empty. |
| action | [System.Action{RestSharp.RestClientOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{RestSharp.RestClientOptions}') | The action to configure the options. Must not be null. |

##### Example

```C#
factory.Configure("https://example.com", options =&gt; options.Timeout = TimeSpan.FromSeconds(30));
```

##### Remarks

This method associates a configuration action with a specific name or URL.

<a name='M-Bb-Services-OptionClientFactory-Create-System-String-'></a>
### Create(name) `method`

##### Summary

Creates a [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance based on the specified name.

##### Returns

A configured [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name or URL used to create the client options. Must not be null or empty. |

##### Example

```C#
var factory = new OptionClientFactory(serviceProvider);
var options = factory.Create("https://example.com");
```

##### Remarks

This method creates and configures a [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance using the provided name or URL. 
If debug mode is enabled, the options are logged.

<a name='M-Bb-Services-OptionClientFactory-TraceLog-RestSharp-RestClientOptions-'></a>
### TraceLog(options) `method`

##### Summary

Logs the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') if a logger is available.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | The [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance to log. Must not be null. |

##### Remarks

This method logs the client options using the configured logger, if available.

<a name='T-Bb-Urls-QueryParamCollection'></a>
## QueryParamCollection `type`

##### Namespace

Bb.Urls

##### Summary

Represents a URL query as a collection of name/value pairs. Insertion order is preserved.

<a name='M-Bb-Urls-QueryParamCollection-#ctor-System-String-'></a>
### #ctor(query) `constructor`

##### Summary

Returns a new instance of QueryParamCollection

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional query string to parse. |

<a name='P-Bb-Urls-QueryParamCollection-Count'></a>
### Count `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Urls-QueryParamCollection-Item-System-Int32-'></a>
### Item `property`

##### Summary

*Inherit from parent.*

<a name='M-Bb-Urls-QueryParamCollection-Add-System-String,System-Object,Bb-NullValueHandling-'></a>
### Add(name,value,nullValueHandling) `method`

##### Summary

Appends a query parameter. If value is a collection type (array, IEnumerable, etc.), multiple parameters are added, i.e. x=1&x=2.
To overwrite existing parameters of the same name, use AddOrReplace instead.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the parameter. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Value of the parameter. If it's a collection, multiple parameters of the same name are added. |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Describes how to handle null values. |

<a name='M-Bb-Urls-QueryParamCollection-AddOrReplace-System-String,System-Object,Bb-NullValueHandling-'></a>
### AddOrReplace(name,value,nullValueHandling) `method`

##### Summary

Replaces existing query parameter(s) or appends to the end. If value is a collection type (array, IEnumerable, etc.),
multiple parameters are added, i.e. x=1&x=2. If any of the same name already exist, they are overwritten one by one
(preserving order) and any remaining are appended to the end. If fewer values are specified than already exist,
remaining existing values are removed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the parameter. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Value of the parameter. If it's a collection, multiple parameters of the same name are added/replaced. |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Describes how to handle null values. |

<a name='M-Bb-Urls-QueryParamCollection-Clear'></a>
### Clear() `method`

##### Summary

Clears all query parameters from this collection.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-QueryParamCollection-Contains-System-String-'></a>
### Contains() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-QueryParamCollection-Contains-System-String,Bb-Urls-QueryParamValue-'></a>
### Contains() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-QueryParamCollection-FirstOrDefault-System-String-'></a>
### FirstOrDefault() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-QueryParamCollection-GetAll-System-String-'></a>
### GetAll() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-QueryParamCollection-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-QueryParamCollection-Remove-System-String-'></a>
### Remove() `method`

##### Summary

Removes all query parameters of the given name.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-QueryParamCollection-ToString'></a>
### ToString() `method`

##### Summary

Returns serialized, encoded query string. Insertion order is preserved.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-QueryParamCollection-ToString-System-Boolean-'></a>
### ToString() `method`

##### Summary

Returns serialized, encoded query string. Insertion order is preserved.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-QueryParamCollection-TryGetFirst-System-String,Bb-Urls-QueryParamValue@-'></a>
### TryGetFirst() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-QueryParamCollection-op_Implicit-Bb-Urls-QueryParamCollection-~System-String'></a>
### op_Implicit(query) `method`

##### Summary

implicit conversion from QueryParamCollection to string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [Bb.Urls.QueryParamCollection)~System.String](#T-Bb-Urls-QueryParamCollection-~System-String 'Bb.Urls.QueryParamCollection)~System.String') |  |

<a name='T-Bb-Urls-QueryParamValue'></a>
## QueryParamValue `type`

##### Namespace

Bb.Urls

##### Summary

Represents a query parameter value with the ability to track whether it was already encoded when created.

<a name='M-Bb-Urls-QueryParamValue-#ctor-System-Object-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a new instance of [QueryParamValue](#T-Bb-Urls-QueryParamValue 'Bb.Urls.QueryParamValue') with the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-Bb-Urls-QueryParamValue-#ctor-System-String-'></a>
### #ctor(value) `constructor`

##### Summary

Creates a new instance of [QueryParamValue](#T-Bb-Urls-QueryParamValue 'Bb.Urls.QueryParamValue') with the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Bb-Urls-QueryParamValue-HasValue'></a>
### HasValue `property`

##### Summary

Indicates whether the object has been initialized with a value.

<a name='P-Bb-Urls-QueryParamValue-IsVariable'></a>
### IsVariable `property`

##### Summary

Indicates whether the value is a variable (enclosed in curly braces).

<a name='P-Bb-Urls-QueryParamValue-Value'></a>
### Value `property`

##### Summary

Return true if the object has been initialized with a value.

<a name='M-Bb-Urls-QueryParamValue-EncodedValue-System-Boolean-'></a>
### EncodedValue() `method`

##### Summary

Gets the encoded value of the segment.

##### Parameters

This method has no parameters.

##### Remarks

If the segment is a variable, it is returned in the format "{variableName}". Otherwise, the raw value is returned.

<a name='M-Bb-Urls-QueryParamValue-ToString'></a>
### ToString() `method`

##### Summary

Returns the string representation of the segment.

##### Returns

A string representing the segment value.

##### Parameters

This method has no parameters.

##### Example

```C#
var segment = new Segment("example");
Console.WriteLine(segment.ToString()); // Output: example
```

##### Remarks

This method returns the raw value of the segment.

<a name='M-Bb-Urls-QueryParamValue-op_Implicit-Bb-Urls-QueryParamValue-~System-String'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a [QueryParamValue](#T-Bb-Urls-QueryParamValue 'Bb.Urls.QueryParamValue') to a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Bb.Urls.QueryParamValue)~System.String](#T-Bb-Urls-QueryParamValue-~System-String 'Bb.Urls.QueryParamValue)~System.String') |  |

<a name='T-Bb-Interceptors-RequestMessageInterceptor'></a>
## RequestMessageInterceptor `type`

##### Namespace

Bb.Interceptors

##### Summary

Represents an interceptor that allows you to execute custom logic before sending an HTTP request.

<a name='M-Bb-Interceptors-RequestMessageInterceptor-#ctor-System-Action{System-Net-Http-HttpRequestMessage}-'></a>
### #ctor(action) `constructor`

##### Summary

Initializes a new instance of the [RequestMessageInterceptor](#T-Bb-Interceptors-RequestMessageInterceptor 'Bb.Interceptors.RequestMessageInterceptor') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action{System.Net.Http.HttpRequestMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.HttpRequestMessage}') | The action to execute before sending the HTTP request. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `action` is null. |

##### Example

```C#
var interceptor = new RequestMessageInterceptor(request =&gt;
{
    Console.WriteLine($"Request URI: {request.RequestUri}");
});
```

##### Remarks

This constructor sets up the interceptor with the specified action to be executed before the HTTP request is sent.

<a name='F-Bb-Interceptors-RequestMessageInterceptor-_action'></a>
### _action `constants`

##### Summary

The action to execute before sending the HTTP request.

<a name='M-Bb-Interceptors-RequestMessageInterceptor-AfterHttpRequest-System-Net-Http-HttpResponseMessage,System-Threading-CancellationToken-'></a>
### AfterHttpRequest(responseMessage,cancellationToken) `method`

##### Summary

Executes after the HTTP request is completed.

##### Returns

A [ValueTask](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| responseMessage | [System.Net.Http.HttpResponseMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage') | The HTTP response message to process. Must not be null. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to observe while processing the response. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `responseMessage` is null. |

##### Example

```C#
var interceptor = new RequestMessageInterceptor(request =&gt; { });
await interceptor.AfterHttpRequest(responseMessage, CancellationToken.None);
```

##### Remarks

This method is called after the HTTP request is completed. By default, it invokes the base implementation.

<a name='M-Bb-Interceptors-RequestMessageInterceptor-BeforeHttpRequest-System-Net-Http-HttpRequestMessage,System-Threading-CancellationToken-'></a>
### BeforeHttpRequest(requestMessage,cancellationToken) `method`

##### Summary

Executes the configured action before the HTTP request is sent.

##### Returns

A [ValueTask](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| requestMessage | [System.Net.Http.HttpRequestMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestMessage 'System.Net.Http.HttpRequestMessage') | The HTTP request message to process. Must not be null. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to observe while processing the request. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `requestMessage` is null. |

##### Example

```C#
var interceptor = new RequestMessageInterceptor(request =&gt;
{
    Console.WriteLine($"Request Method: {request.Method}");
});
await interceptor.BeforeHttpRequest(requestMessage, CancellationToken.None);
```

##### Remarks

This method invokes the configured action on the HTTP request message before it is sent.

<a name='T-Bb-Interceptors-ResponseMessageInterceptor'></a>
## ResponseMessageInterceptor `type`

##### Namespace

Bb.Interceptors

##### Summary

Interceptor for handling HTTP response messages in RestSharp.

<a name='M-Bb-Interceptors-ResponseMessageInterceptor-#ctor-System-Action{System-Net-Http-HttpResponseMessage}-'></a>
### #ctor(action) `constructor`

##### Summary

Initializes a new instance of the [ResponseMessageInterceptor](#T-Bb-Interceptors-ResponseMessageInterceptor 'Bb.Interceptors.ResponseMessageInterceptor') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.HttpResponseMessage}') | The action to execute after receiving the HTTP response. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `action` is null. |

##### Example

```C#
var interceptor = new ResponseMessageInterceptor(response =&gt;
{
    Console.WriteLine($"Response Status: {response.StatusCode}");
});
```

##### Remarks

This constructor sets up the interceptor with the specified action to be executed after the HTTP response is received.

<a name='F-Bb-Interceptors-ResponseMessageInterceptor-_action'></a>
### _action `constants`

##### Summary

The action to execute after receiving the HTTP response.

<a name='M-Bb-Interceptors-ResponseMessageInterceptor-AfterHttpRequest-System-Net-Http-HttpResponseMessage,System-Threading-CancellationToken-'></a>
### AfterHttpRequest(responseMessage,cancellationToken) `method`

##### Summary

Executes the configured action after the HTTP request is completed.

##### Returns

A [ValueTask](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| responseMessage | [System.Net.Http.HttpResponseMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage') | The HTTP response message to process. Must not be null. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | A [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') to observe while processing the response. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `responseMessage` is null. |

##### Example

```C#
var interceptor = new ResponseMessageInterceptor(response =&gt;
{
    Console.WriteLine($"Response Content: {response.Content.ReadAsStringAsync().Result}");
});
await interceptor.AfterHttpRequest(responseMessage, CancellationToken.None);
```

##### Remarks

This method invokes the configured action on the HTTP response message after it is received.

<a name='T-Bb-Helpers-RestClientExtension'></a>
## RestClientExtension `type`

##### Namespace

Bb.Helpers

##### Summary

Extension methods for the [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') class.

<a name='M-Bb-Helpers-RestClientExtension-GetTokenAsync-RestSharp-RestClient,System-String,System-String,System-String,System-String,System-String-'></a>
### GetTokenAsync(self,path,client_id,client_secret,userName,password) `method`

##### Summary

Retrieves an authentication token asynchronously using the specified credentials.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the asynchronous operation, with a result of [TokenResponse](#T-Bb-Http-TokenResponse 'Bb.Http.TokenResponse') containing the token details.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') | The [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instance to use for the request. Must not be null. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The endpoint path for the token request. Must not be null or empty. |
| client_id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The client ID for authentication. Must not be null or empty. |
| client_secret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The client secret for authentication. Can be null or empty. |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The userName for authentication. Must not be null or empty. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password for authentication. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `self`, `path`, `client_id`, `userName`, or `password` is null or empty. |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the token request fails or the response is not successful. |

##### Example

```C#
var client = new RestClient("https://example.com");
var tokenResponse = await client.GetTokenAsync("/token", "myClientId", "myClientSecret", "myUsername", "myPassword");
```

##### Remarks

This method sends a POST request to the specified endpoint to retrieve an authentication token using the provided credentials.

<a name='T-Bb-Services-RestClientFactory'></a>
## RestClientFactory `type`

##### Namespace

Bb.Services

##### Summary

Factory class for creating instances of [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') with a specified base URL.

<a name='M-Bb-Services-RestClientFactory-#ctor-Bb-Interfaces-IOptionClientFactory,System-Net-Http-IHttpClientFactory-'></a>
### #ctor(optionFactory,factory) `constructor`

##### Summary

Initializes a new instance of the [RestClientFactory](#T-Bb-Services-RestClientFactory 'Bb.Services.RestClientFactory') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| optionFactory | [Bb.Interfaces.IOptionClientFactory](#T-Bb-Interfaces-IOptionClientFactory 'Bb.Interfaces.IOptionClientFactory') | The [IOptionClientFactory](#T-Bb-Interfaces-IOptionClientFactory 'Bb.Interfaces.IOptionClientFactory') instance used to create client options. Must not be null. |
| factory | [System.Net.Http.IHttpClientFactory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.IHttpClientFactory 'System.Net.Http.IHttpClientFactory') | The [IHttpClientFactory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.IHttpClientFactory 'System.Net.Http.IHttpClientFactory') instance used to create client http. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | Thrown if `optionFactory` is null. |

##### Remarks

This constructor initializes the factory with the specified option factory for creating [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions').

<a name='M-Bb-Services-RestClientFactory-Create-System-Uri-'></a>
### Create(baseUrl) `method`

##### Summary

Creates a [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instance using the specified base URL.

##### Returns

A [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instance configured with the specified base URL.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| baseUrl | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The base URL for the REST client. Must not be null. |

##### Example

```C#
var factory = new RestClientFactory(optionFactory);
var client = factory.Create(new Uri("https://example.com"));
```

##### Remarks

This method retrieves or creates a [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instance for the specified base URL. 
If a client for the URL already exists, it is reused.

<a name='M-Bb-Services-RestClientFactory-Create-System-String-'></a>
### Create(name) `method`

##### Summary

Creates a [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instance using the specified name or URL.

##### Returns

A [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instance configured with the specified name or URL.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name or URL for the REST client. Must not be null or empty. |

##### Example

```C#
var factory = new RestClientFactory(optionFactory);
var client = factory.Create("https://example.com");
```

##### Remarks

This method retrieves or creates a [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instance for the specified name or URL. 
If a client for the URL already exists, it is reused.

<a name='M-Bb-Services-RestClientFactory-Create-Bb-Urls-Url-'></a>
### Create(name) `method`

##### Summary

Creates a [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instance using the specified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url').

##### Returns

A [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instance configured with the specified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') instance for the REST client. Must not be null. |

##### Example

```C#
var factory = new RestClientFactory(optionFactory);
var client = factory.Create(new Url("https://example.com"));
```

##### Remarks

This method retrieves or creates a [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instance for the specified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url'). 
If a client for the URL already exists, it is reused.

<a name='T-Bb-Helpers-RestOptionExtension'></a>
## RestOptionExtension `type`

##### Namespace

Bb.Helpers

##### Summary

Extension methods for configuring RestClientOptions in the BlackBeard library.

<a name='M-Bb-Helpers-RestOptionExtension-InterceptCookies-RestSharp-RestClientOptions,Bb-Services-Bag{System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{System-String,System-Collections-Generic-IEnumerable{System-String}}}}@-'></a>
### InterceptCookies(self,bag) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') to intercept cookies from HTTP responses.

##### Returns

The configured [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | The [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance to configure. Must not be null. |
| bag | [Bb.Services.Bag{System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{System.String,System.Collections.Generic.IEnumerable{System.String}}}}@](#T-Bb-Services-Bag{System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{System-String,System-Collections-Generic-IEnumerable{System-String}}}}@ 'Bb.Services.Bag{System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{System.String,System.Collections.Generic.IEnumerable{System.String}}}}@') | An output parameter to store intercepted cookies. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | Thrown if the interceptor cannot be added. |

##### Example

```C#
var options = new RestClientOptions();
options.InterceptCookies(out var cookies);
```

##### Remarks

This method adds an interceptor to capture cookies from HTTP response headers.

<a name='M-Bb-Helpers-RestOptionExtension-InterceptRequest-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpRequestMessage}-'></a>
### InterceptRequest(self,interceptor) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') to intercept HTTP requests.

##### Returns

The configured [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | The [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance to configure. Must not be null. |
| interceptor | [System.Action{System.Net.Http.HttpRequestMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.HttpRequestMessage}') | The action to execute for intercepting HTTP requests. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | Thrown if `interceptor` is null. |

##### Example

```C#
var options = new RestClientOptions();
options.InterceptRequest(request =&gt; Console.WriteLine(request.Method));
```

##### Remarks

This method adds an interceptor to handle HTTP requests before they are sent.

<a name='M-Bb-Helpers-RestOptionExtension-InterceptResponse-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpResponseMessage}-'></a>
### InterceptResponse(self,interceptor) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') to intercept HTTP responses.

##### Returns

The configured [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | The [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance to configure. Must not be null. |
| interceptor | [System.Action{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.HttpResponseMessage}') | The action to execute for intercepting HTTP responses. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | Thrown if `interceptor` is null. |

##### Example

```C#
var options = new RestClientOptions();
options.InterceptResponse(response =&gt; Console.WriteLine(response.StatusCode));
```

##### Remarks

This method adds an interceptor to handle HTTP responses after they are received.

<a name='M-Bb-Helpers-RestOptionExtension-WithAuth1-RestSharp-RestClientOptions,System-String,System-String-'></a>
### WithAuth1(self,consumerKey,consumerSecret) `method`

##### Summary

Use authentication Oauth1

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') |
| consumerKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| consumerSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-Helpers-RestOptionExtension-WithBasicHttp-RestSharp-RestClientOptions,System-String,System-String-'></a>
### WithBasicHttp(self,userName,password) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') to use basic HTTP authentication.

##### Returns

The configured [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | The [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance to configure. Must not be null. |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The userName for authentication. Must not be null or empty. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password for authentication. Must not be null or empty. |

##### Example

```C#
var options = new RestClientOptions();
options.WithBasicHttp("userName", "password");
```

##### Remarks

This method sets up basic HTTP authentication for the REST client.

<a name='M-Bb-Helpers-RestOptionExtension-WithJwt-RestSharp-RestClientOptions,System-String-'></a>
### WithJwt(self,accessToken) `method`

##### Summary

Use jwt token

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-Helpers-RestOptionExtension-WithLog-RestSharp-RestClientOptions,Microsoft-Extensions-Logging-ILogger-'></a>
### WithLog(self,logger) `method`

##### Summary

Adds logging capabilities to the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | logger to use |

<a name='M-Bb-Helpers-RestOptionExtension-WithLog-RestSharp-RestClientOptions,System-Action{Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}},Microsoft-Extensions-Logging-ILogger-'></a>
### WithLog(self,requestAction,logger) `method`

##### Summary

Adds logging capabilities to the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') |
| requestAction | [System.Action{Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}}') | Request action |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | logger to use |

<a name='M-Bb-Helpers-RestOptionExtension-WithLog-RestSharp-RestClientOptions,System-Action{Bb-Interceptors-LogConfiguration{System-Net-Http-HttpRequestMessage}},System-Action{Bb-Interceptors-LogConfiguration{System-Net-Http-HttpResponseMessage}},Microsoft-Extensions-Logging-ILogger-'></a>
### WithLog(self,requestAction,responseAction,logger) `method`

##### Summary

Adds logging capabilities to the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') |
| requestAction | [System.Action{Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Interceptors.LogConfiguration{System.Net.Http.HttpRequestMessage}}') | Request action |
| responseAction | [System.Action{Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Interceptors.LogConfiguration{System.Net.Http.HttpResponseMessage}}') |  |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | logger to use |

<a name='M-Bb-Helpers-RestOptionExtension-WithOAuth2-RestSharp-RestClientOptions,System-String-'></a>
### WithOAuth2(self,accessToken) `method`

##### Summary

Use authentication Oauth2

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | access token to use |

<a name='T-Bb-Helpers-RestRequestExtension'></a>
## RestRequestExtension `type`

##### Namespace

Bb.Helpers

##### Summary

Provides extension methods for configuring and enhancing [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') and [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions').

<a name='M-Bb-Helpers-RestRequestExtension-InterceptCookies-RestSharp-RestClientOptions,Bb-Services-Bag{System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{System-String,System-Collections-Generic-IEnumerable{System-String}}}}@-'></a>
### InterceptCookies(self,bag) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') to intercept cookies from HTTP responses.

##### Returns

The configured [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | The [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance to configure. Must not be null. |
| bag | [Bb.Services.Bag{System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{System.String,System.Collections.Generic.IEnumerable{System.String}}}}@](#T-Bb-Services-Bag{System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{System-String,System-Collections-Generic-IEnumerable{System-String}}}}@ 'Bb.Services.Bag{System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{System.String,System.Collections.Generic.IEnumerable{System.String}}}}@') | An output parameter to store intercepted cookies. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | Thrown if the interceptor cannot be added. |

##### Example

```C#
var options = new RestClientOptions();
options.InterceptCookies(out var cookies);
```

##### Remarks

This method adds an interceptor to capture cookies from HTTP response headers.

<a name='M-Bb-Helpers-RestRequestExtension-InterceptRequest-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpRequestMessage}-'></a>
### InterceptRequest(self,interceptor) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') to intercept HTTP requests.

##### Returns

The configured [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | The [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance to configure. Must not be null. |
| interceptor | [System.Action{System.Net.Http.HttpRequestMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.HttpRequestMessage}') | The action to execute for intercepting HTTP requests. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | Thrown if `interceptor` is null. |

##### Example

```C#
var options = new RestClientOptions();
options.InterceptRequest(request =&gt; Console.WriteLine(request.Method));
```

##### Remarks

This method adds an interceptor to handle HTTP requests before they are sent.

<a name='M-Bb-Helpers-RestRequestExtension-InterceptResponse-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpResponseMessage}-'></a>
### InterceptResponse(self,interceptor) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') to intercept HTTP responses.

##### Returns

The configured [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | The [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance to configure. Must not be null. |
| interceptor | [System.Action{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.HttpResponseMessage}') | The action to execute for intercepting HTTP responses. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | Thrown if `interceptor` is null. |

##### Example

```C#
var options = new RestClientOptions();
options.InterceptResponse(response =&gt; Console.WriteLine(response.StatusCode));
```

##### Remarks

This method adds an interceptor to handle HTTP responses after they are received.

<a name='M-Bb-Helpers-RestRequestExtension-NewRequest-RestSharp-Method,System-String,System-Nullable{RestSharp-DataFormat}-'></a>
### NewRequest(method,path,format) `method`

##### Summary

Creates a new [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') with the specified method, path, and optional data format.

##### Returns

A new [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| method | [RestSharp.Method](#T-RestSharp-Method 'RestSharp.Method') | The HTTP method for the request. Must not be null. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The resource path for the request. Must not be null or empty. |
| format | [System.Nullable{RestSharp.DataFormat}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{RestSharp.DataFormat}') | The optional [DataFormat](#T-RestSharp-DataFormat 'RestSharp.DataFormat') for the request. Defaults to JSON if not specified. |

##### Example

```C#
var request = Method.GET.NewRequest("api/resource");
```

##### Remarks

This method simplifies the creation of a new REST request with the specified parameters.

<a name='M-Bb-Helpers-RestRequestExtension-WithBasicHttp-RestSharp-RestClientOptions,System-String,System-String-'></a>
### WithBasicHttp(self,userName,password) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') to use basic HTTP authentication.

##### Returns

The configured [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | The [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance to configure. Must not be null. |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The userName for authentication. Must not be null or empty. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password for authentication. Must not be null or empty. |

##### Example

```C#
var options = new RestClientOptions();
options.WithBasicHttp("username", "password");
```

##### Remarks

This method sets up basic HTTP authentication for the REST client.

<a name='M-Bb-Helpers-RestRequestExtension-WithBearer-RestSharp-RestRequest,Bb-Http-TokenResponse-'></a>
### WithBearer(self,token) `method`

##### Summary

Adds a bearer token to the request headers.

##### Returns

The configured [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') | The [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') instance to configure. Must not be null. |
| token | [Bb.Http.TokenResponse](#T-Bb-Http-TokenResponse 'Bb.Http.TokenResponse') | The [TokenResponse](#T-Bb-Http-TokenResponse 'Bb.Http.TokenResponse') containing the access token. Must not be null. |

##### Example

```C#
var request = new RestRequest("api/resource", Method.GET);
request.WithBearer(new TokenResponse { AccessToken = "your-token" });
```

##### Remarks

This method adds an "Authorization" header with the bearer token to the request.

<a name='M-Bb-Helpers-RestRequestExtension-WithContentType-RestSharp-RestRequest,RestSharp-ContentType-'></a>
### WithContentType(self,contentType) `method`

##### Summary

Adds a "Content-Type" header to the request.

##### Returns

The configured [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') | The [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') instance to configure. Must not be null. |
| contentType | [RestSharp.ContentType](#T-RestSharp-ContentType 'RestSharp.ContentType') | The [ContentType](#T-RestSharp-ContentType 'RestSharp.ContentType') to set. Must not be null. |

##### Example

```C#
var request = new RestRequest("api/resource", Method.POST);
request.WithContentType(ContentType.Json);
```

##### Remarks

This method sets the "Content-Type" header for the request.

<a name='T-Bb-Urls-Segment'></a>
## Segment `type`

##### Namespace

Bb.Urls

##### Summary

Represents a segment of a URL or path.

<a name='M-Bb-Urls-Segment-#ctor-System-String-'></a>
### #ctor(segment) `constructor`

##### Summary

Initializes a new instance of the [Segment](#T-Bb-Urls-Segment 'Bb.Urls.Segment') struct.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| segment | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The segment string. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `segment` is null. |

##### Remarks

This constructor initializes the segment and determines if it represents a variable. 
Variables are identified by being enclosed in "%7B" and "%7D".

<a name='P-Bb-Urls-Segment-EncodedValue'></a>
### EncodedValue `property`

##### Summary

Gets the encoded value of the segment.

##### Remarks

If the segment is a variable, it is returned in the format "{variableName}". Otherwise, the raw value is returned.

<a name='P-Bb-Urls-Segment-IsMalicious'></a>
### IsMalicious `property`

##### Summary

Gets a value indicating whether the segment is considered malicious.

<a name='P-Bb-Urls-Segment-IsVariable'></a>
### IsVariable `property`

##### Summary

Gets a value indicating whether the segment is a variable.

##### Remarks

A segment is considered a variable if it is enclosed in "%7B" and "%7D".

<a name='P-Bb-Urls-Segment-Value'></a>
### Value `property`

##### Summary

Gets the value of the segment.

##### Remarks

If the segment is a variable, this property contains the variable name without the enclosing "%7B" and "%7D".

<a name='M-Bb-Urls-Segment-Map-System-String-'></a>
### Map(value) `method`

##### Summary

Maps a value to the segment if it is a variable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value to map to the segment. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the segment is not a variable. |

##### Example

```C#
var segment = new Segment("%7Bvariable%7D");
segment.Map("mappedValue");
Console.WriteLine(segment.Value); // Output: mappedValue
```

##### Remarks

This method replaces the variable name in the segment with the provided value.

<a name='M-Bb-Urls-Segment-ToString'></a>
### ToString() `method`

##### Summary

Returns the string representation of the segment.

##### Returns

A string representing the segment value.

##### Parameters

This method has no parameters.

##### Example

```C#
var segment = new Segment("example");
Console.WriteLine(segment.ToString()); // Output: example
```

##### Remarks

This method returns the raw value of the segment.

<a name='M-Bb-Urls-Segment-op_Implicit-Bb-Urls-Segment-~System-String'></a>
### op_Implicit(segment) `method`

##### Summary

Implicitly converts a [Segment](#T-Bb-Urls-Segment 'Bb.Urls.Segment') to a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| segment | [Bb.Urls.Segment)~System.String](#T-Bb-Urls-Segment-~System-String 'Bb.Urls.Segment)~System.String') |  |

<a name='T-Bb-Http-TokenResponse'></a>
## TokenResponse `type`

##### Namespace

Bb.Http

##### Summary

Represents the response containing token information from an authentication server.

##### Remarks

This object is typically used to deserialize the JSON response from an OAuth2 or OpenID Connect token endpoint.

<a name='P-Bb-Http-TokenResponse-AccessToken'></a>
### AccessToken `property`

##### Summary

Gets the access token issued by the authorization server.

##### Remarks

This token is used to authenticate API requests.

<a name='P-Bb-Http-TokenResponse-ExpiresIn'></a>
### ExpiresIn `property`

##### Summary

Gets the duration in seconds for which the access token is valid.

##### Remarks

After this duration, the access token will expire and a new one must be obtained.

<a name='P-Bb-Http-TokenResponse-NotBeforePolicy'></a>
### NotBeforePolicy `property`

##### Summary

Gets the "not-before" policy timestamp.

##### Remarks

This indicates the time before which the token must not be accepted.

<a name='P-Bb-Http-TokenResponse-RefreshExpiresIn'></a>
### RefreshExpiresIn `property`

##### Summary

Gets the duration in seconds for which the refresh token is valid.

##### Remarks

After this duration, the refresh token will expire and a new one must be obtained.

<a name='P-Bb-Http-TokenResponse-RefreshToken'></a>
### RefreshToken `property`

##### Summary

Gets the refresh token issued by the authorization server.

##### Remarks

This token can be used to obtain a new access token without requiring user authentication.

<a name='P-Bb-Http-TokenResponse-Scope'></a>
### Scope `property`

##### Summary

Gets the scope of the access token.

##### Remarks

This defines the permissions granted by the token.

<a name='P-Bb-Http-TokenResponse-SessionState'></a>
### SessionState `property`

##### Summary

Gets the session state identifier.

##### Remarks

This is used to track the session state of the user.

<a name='P-Bb-Http-TokenResponse-TokenType'></a>
### TokenType `property`

##### Summary

Gets the type of the token issued.

##### Remarks

Typically, this is "Bearer".

<a name='T-Bb-Urls-Url'></a>
## Url `type`

##### Namespace

Bb.Urls

##### Summary

Represents a URL with various components such as scheme, host, port, user info, path segments, query parameters, and fragment.

<a name='M-Bb-Urls-Url-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a new instance of the Url class.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Urls-Url-#ctor-System-UriBuilder,System-Uri-'></a>
### #ctor(builder,uri) `constructor`

##### Summary

Creates a new instance of the Url class with the specified UriBuilder and Uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [System.UriBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UriBuilder 'System.UriBuilder') | UriBuilder to use for create url |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | root uri |

<a name='M-Bb-Urls-Url-#ctor-System-Uri-'></a>
### #ctor(uri) `constructor`

##### Summary

Creates a new instance of the Url class with the specified Uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | root uri |

<a name='M-Bb-Urls-Url-#ctor-System-String-'></a>
### #ctor(url) `constructor`

##### Summary

Creates a new instance of the Url class with the specified URL string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | string uri |

<a name='M-Bb-Urls-Url-#ctor-System-Uri,System-String[]-'></a>
### #ctor(uri,paths) `constructor`

##### Summary

Creates a new instance of the Url class with the specified Uri and path segments.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | root uri |
| paths | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | path to specify after host |

<a name='M-Bb-Urls-Url-#ctor-System-String,System-String,System-Nullable{System-Int32},System-String,System-String[]-'></a>
### #ctor(scheme,host,port,userInfo,paths) `constructor`

##### Summary

Creates a new instance of the Url class with the specified scheme, host, port, user info, and path segments.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Scheme to use. by default the value is http |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | host of the server |
| port | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | server's port |
| userInfo | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | user info like user:password |
| paths | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | path to specify after host |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='M-Bb-Urls-Url-#ctor-System-String,System-String,System-Nullable{System-Int32}-'></a>
### #ctor(scheme,host,port) `constructor`

##### Summary

Creates a new instance of the Url class with the specified scheme, host, port, and user info.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Scheme to use. by default the value is http |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | host of the server |
| port | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | server's port |

<a name='M-Bb-Urls-Url-#ctor-System-String,System-String-'></a>
### #ctor(scheme,host) `constructor`

##### Summary

Creates a new instance of the Url class with the specified scheme, host, and port.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Scheme to use. by default the value is http |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | host of the server |

<a name='M-Bb-Urls-Url-#ctor-System-String,System-Int32-'></a>
### #ctor(host,port) `constructor`

##### Summary

Creates a new instance of the Url class with the specified host and port.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | host of the server |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | server's port |

<a name='F-Bb-Urls-Url-DEFAULT_HOST'></a>
### DEFAULT_HOST `constants`

##### Summary

Default host for URLs is localhost.

<a name='F-Bb-Urls-Url-DEFAULT_PORT'></a>
### DEFAULT_PORT `constants`

##### Summary

Default port for HTTP URLs is 80.

<a name='F-Bb-Urls-Url-DEFAULT_SCHEME'></a>
### DEFAULT_SCHEME `constants`

##### Summary

Default scheme for HTTP URLs.

<a name='F-Bb-Urls-Url-DEFAULT_SECURED_SCHEME'></a>
### DEFAULT_SECURED_SCHEME `constants`

##### Summary

Default secured scheme for HTTP URLs.

<a name='P-Bb-Urls-Url-BaseAddress'></a>
### BaseAddress `property`

##### Summary

Returns the base address of the URL, excluding the path and query string.

<a name='P-Bb-Urls-Url-Fragment'></a>
### Fragment `property`

##### Summary

Returns the fragment as a string. This is a lazy-loaded property, meaning it will only be initialized when accessed.

<a name='P-Bb-Urls-Url-Host'></a>
### Host `property`

##### Summary

Returns the host as a string. This is a lazy-loaded property, meaning it will only be initialized when accessed.

<a name='P-Bb-Urls-Url-Password'></a>
### Password `property`

##### Summary

Returns the password as a string. This is a lazy-loaded property, meaning it will only be initialized when accessed.

<a name='P-Bb-Urls-Url-Path'></a>
### Path `property`

##### Summary

Returns the path as a string. This is a lazy-loaded property, meaning it will only be initialized when accessed.

<a name='P-Bb-Urls-Url-PathAndQuery'></a>
### PathAndQuery `property`

##### Summary

Returns the URL as a string, including the scheme, host, port, path, query parameters, and fragment.

<a name='P-Bb-Urls-Url-PathSegments'></a>
### PathSegments `property`

##### Summary

Returns the path segments as a collection. This is a lazy-loaded property, meaning it will only be initialized when accessed.

<a name='P-Bb-Urls-Url-Port'></a>
### Port `property`

##### Summary

Returns the port as an integer. This is a lazy-loaded property, meaning it will only be initialized when accessed.

<a name='P-Bb-Urls-Url-Query'></a>
### Query `property`

##### Summary

Returns the query string as a string. This is a lazy-loaded property, meaning it will only be initialized when accessed.

<a name='P-Bb-Urls-Url-QueryParams'></a>
### QueryParams `property`

##### Summary

Returns the query parameters as a collection. This is a lazy-loaded property, meaning it will only be initialized when accessed.

<a name='P-Bb-Urls-Url-Root'></a>
### Root `property`

##### Summary

i.e. "https://www.site.com:8080" in "https://www.site.com:8080/path" (everything before the path).

<a name='P-Bb-Urls-Url-RootAddress'></a>
### RootAddress `property`

##### Summary

i.e. "https://www.site.com:8080" in "https://www.site.com:8080/path" (everything before the path).

<a name='P-Bb-Urls-Url-Scheme'></a>
### Scheme `property`

##### Summary

Default scheme for the URL. Defaults to "http".

<a name='P-Bb-Urls-Url-UserName'></a>
### UserName `property`

##### Summary

Returns the userName as a string. This is a lazy-loaded property, meaning it will only be initialized when accessed.

<a name='M-Bb-Urls-Url-Clone'></a>
### Clone() `method`

##### Summary

Creates a new instance of the Url class with the same properties as the current instance.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-Url-CombinePath-System-Collections-Generic-IEnumerable{Bb-Urls-Segment}-'></a>
### CombinePath(paths) `method`

##### Summary

Combines multiple path segments into the URL.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paths | [System.Collections.Generic.IEnumerable{Bb.Urls.Segment}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Bb.Urls.Segment}') |  |

<a name='M-Bb-Urls-Url-CombinePath-System-String[]-'></a>
### CombinePath(paths) `method`

##### Summary

Combines multiple path segments into the URL.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paths | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-Bb-Urls-Url-Decode-System-String,System-Boolean-'></a>
### Decode(s,interpretPlusAsSpace) `method`

##### Summary

Decodes a URL-encoded string.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') representing the decoded URL.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL-encoded string to decode. Must not be null. |
| interpretPlusAsSpace | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, "+" characters will be interpreted as spaces. |

##### Example

```C#
var decoded = Url.Decode("key%3Dvalue%26key2%3Dvalue2", false);
Console.WriteLine(decoded); // Output: key=value&amp;key2=value2
```

##### Remarks

This method decodes a URL-encoded string, converting encoded characters back to their original form.

<a name='M-Bb-Urls-Url-Encode-System-String,System-Boolean-'></a>
### Encode(str,encodeSpaceAsPlus) `method`

##### Summary

URL-encodes a string, including reserved characters such as '/' and '?'.

##### Returns

The encoded URL.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to encode. Must not be null. |
| encodeSpaceAsPlus | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, spaces will be encoded as + signs. Otherwise, they'll be encoded as %20. |

##### Example

```C#
var encoded = Url.Encode("key=value&amp;key2=value2");
Console.WriteLine(encoded); // Output: key%3Dvalue%26key2%3Dvalue2
```

##### Remarks

This method ensures that the string is properly encoded for use in a URL, including handling long strings by splitting them into smaller parts.

<a name='M-Bb-Urls-Url-EncodeIllegalCharacters-System-String,System-Boolean-'></a>
### EncodeIllegalCharacters(s,encodeSpaceAsPlus) `method`

##### Summary

URL-encodes characters in a string that are neither reserved nor unreserved. Avoids encoding reserved characters such as '/' and '?'. Avoids encoding '%' if it begins a %-hex-hex sequence (i.e. avoids double-encoding).

##### Returns

The encoded URL.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to encode. |
| encodeSpaceAsPlus | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, spaces will be encoded as + signs. Otherwise, they'll be encoded as %20. |

<a name='M-Bb-Urls-Url-Map-System-ValueTuple{System-String,System-String}[]-'></a>
### Map(values) `method`

##### Summary

Maps variables in the URL path and query parameters to specified values.

##### Returns

The modified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object with the variables replaced.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.ValueTuple{System.String,System.String}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{System.String,System.String}[]') | An array of key-value pairs representing the variables and their corresponding values. Must not be null. |

##### Example

```C#
var url = new Url("https://example.com/{id}?name={name}");
url.Map(("id", "123"), ("name", "John"));
Console.WriteLine(url.ToString()); // Output: https://example.com/123?name=John
```

##### Remarks

This method replaces variables in the URL path and query parameters with the provided values.

<a name='M-Bb-Urls-Url-Map-System-String,System-String-'></a>
### Map(name,value) `method`

##### Summary

Maps a single variable in the URL path or query parameters to a specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the variable to replace. Must not be null or empty. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value to replace the variable with. Must not be null or empty. |

##### Example

```C#
var url = new Url("https://example.com/{id}");
url.Map("id", "123");
Console.WriteLine(url.ToString()); // Output: https://example.com/123
```

##### Remarks

This method replaces a single variable in the URL path or query parameters with the provided value.

<a name='M-Bb-Urls-Url-ParsePathSegment-System-String[]-'></a>
### ParsePathSegment(paths) `method`

##### Summary

Parses a path segment string into a list of segments.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| paths | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-Bb-Urls-Url-RemoveFragment'></a>
### RemoveFragment() `method`

##### Summary

Removes the URL fragment including the #.

##### Returns

The Url object with the fragment removed

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-Url-RemoveLastPathSegment'></a>
### RemoveLastPathSegment() `method`

##### Summary

Removes the last path segment from the URL.

##### Returns

The Url object.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-Url-RemovePath'></a>
### RemovePath() `method`

##### Summary

Removes the entire path component of the URL, including the leading slash.

##### Returns

The Url object.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-Url-RemoveQuery'></a>
### RemoveQuery() `method`

##### Summary

Removes the entire query component of the URL.

##### Returns

The Url object.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-Url-RemoveQueryParam-System-String-'></a>
### RemoveQueryParam(name) `method`

##### Summary

Removes a name/value pair from the query by name.

##### Returns

The Url object with the query parameter removed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Query string parameter name to remove |

<a name='M-Bb-Urls-Url-RemoveQueryParam-System-String[]-'></a>
### RemoveQueryParam(names) `method`

##### Summary

Removes multiple name/value pairs from the query by name.

##### Returns

The Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Query string parameter names to remove |

<a name='M-Bb-Urls-Url-RemoveQueryParam-System-Collections-Generic-IEnumerable{System-String}-'></a>
### RemoveQueryParam(names) `method`

##### Summary

Removes multiple name/value pairs from the query by name.

##### Returns

The Url object with the query parameters removed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| names | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Query string parameter names to remove |

<a name='M-Bb-Urls-Url-Reset'></a>
### Reset() `method`

##### Summary

Resets the URL to its original state as set in the constructor.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-Url-ResetToRoot'></a>
### ResetToRoot() `method`

##### Summary

Resets the URL to its root, including the scheme, any user info, host, and port (if specified).

##### Returns

The Url object trimmed to its root.

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-Url-SetFragment-System-String-'></a>
### SetFragment(fragment) `method`

##### Summary

Set the URL fragment fluently.

##### Returns

The Url object with the new fragment set

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fragment | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The part of the URL after # |

<a name='M-Bb-Urls-Url-ToString'></a>
### ToString() `method`

##### Summary

Returns a string representation of the URL, including the scheme, host, port, path, query parameters, and fragment.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-Url-ToUri'></a>
### ToUri() `method`

##### Summary

Returns the URL as a Uri object.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-Url-WithPathSegment-System-String[]-'></a>
### WithPathSegment(pathSegments) `method`

##### Summary

Sets the URL fragment fluently.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathSegments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-Bb-Urls-Url-WithPathSegment-System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithPathSegment(pathSegments) `method`

##### Summary

Adds multiple path segments to the URL.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathSegments | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') |  |

<a name='M-Bb-Urls-Url-WithQueryParam-System-String,System-Object,Bb-NullValueHandling-'></a>
### WithQueryParam(name,value,nullValueHandling) `method`

##### Summary

Adds a parameter to the query, overwriting the value if name exists.

##### Returns

The Url object with the query parameter added

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Value of query parameter |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing) |

<a name='M-Bb-Urls-Url-WithQueryParam-System-String,System-String,System-Boolean,Bb-NullValueHandling-'></a>
### WithQueryParam(name,value,isEncoded,nullValueHandling) `method`

##### Summary

Adds a parameter to the query, overwriting the value if name exists.

##### Returns

The Url object with the query parameter added

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value of query parameter |
| isEncoded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to true to indicate the value is already URL-encoded |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `name` is `null`. |

<a name='M-Bb-Urls-Url-WithQueryParam-System-String-'></a>
### WithQueryParam(name) `method`

##### Summary

Adds a parameter without a value to the query, removing any existing value.

##### Returns

The Url object with the query parameter added

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |

<a name='M-Bb-Urls-Url-WithQueryParam-System-Object,Bb-NullValueHandling-'></a>
### WithQueryParam(values,nullValueHandling) `method`

##### Summary

Parses values (usually an anonymous object or dictionary) into name/value pairs and adds them to the query, overwriting any that already exist.

##### Returns

The Url object with the query parameters added

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Typically an anonymous object, ie: new { x = 1, y = 2 } |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing) |

<a name='M-Bb-Urls-Url-WithQueryParam-System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithQueryParam(names) `method`

##### Summary

Adds multiple parameters without values to the query.

##### Returns

The Url object with the query parameter added

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| names | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Names of query parameters. |

<a name='M-Bb-Urls-Url-WithQueryParam-System-String[]-'></a>
### WithQueryParam(names) `method`

##### Summary

Adds multiple parameters without values to the query.

##### Returns

The Url object with the query parameter added.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Names of query parameters |

<a name='M-Bb-Urls-Url-op_Implicit-Bb-Urls-Url-~System-Uri'></a>
### op_Implicit(url) `method`

##### Summary

Implicitly converts a Url object to a Uri object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Urls.Url)~System.Uri](#T-Bb-Urls-Url-~System-Uri 'Bb.Urls.Url)~System.Uri') | url to convert to uri |

<a name='M-Bb-Urls-Url-op_Implicit-System-Uri-~Bb-Urls-Url'></a>
### op_Implicit(uri) `method`

##### Summary

Implicitly converts a Url object to a Uri object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri)~Bb.Urls.Url](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri)~Bb.Urls.Url 'System.Uri)~Bb.Urls.Url') | uri to convert to url |

<a name='M-Bb-Urls-Url-op_Implicit-Bb-Urls-Url-~System-String'></a>
### op_Implicit(url) `method`

##### Summary

Implicitly converts a Url object to a string representation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Urls.Url)~System.String](#T-Bb-Urls-Url-~System-String 'Bb.Urls.Url)~System.String') | url to convert to string |

<a name='M-Bb-Urls-Url-op_Implicit-System-String-~Bb-Urls-Url'></a>
### op_Implicit(url) `method`

##### Summary

Implicitly converts a string to a Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String)~Bb.Urls.Url](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String)~Bb.Urls.Url 'System.String)~Bb.Urls.Url') | string to convert to Url |

<a name='T-Bb-Urls-UrlExtension'></a>
## UrlExtension `type`

##### Namespace

Bb.Urls

##### Summary

Provides extension methods for fluently configuring and modifying [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') objects.

##### Example

```C#
var url = new Url("https://example.com")
    .WithUserInfo("user:pass")
    .WithHost("example.org")
    .WithPort(8080)
    .WithHttps();
Console.WriteLine(url.ToString()); // Output: https://user:pass@example.org:8080
```

##### Remarks

The [UrlExtension](#T-Bb-Urls-UrlExtension 'Bb.Urls.UrlExtension') class contains helper methods for setting various components of a [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object, such as user information, host, port, and scheme. These methods enable a fluent API for constructing and modifying URLs.

<a name='M-Bb-Urls-UrlExtension-CallAsync-Bb-Urls-Url,RestSharp-Method,System-Nullable{RestSharp-DataFormat}-'></a>
### CallAsync(self,method,format) `method`

##### Summary

Executes a REST call asynchronously using the specified HTTP method and optional data format.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the asynchronous operation, with a result of [RestResponse](#T-RestSharp-RestResponse 'RestSharp.RestResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') instance representing the endpoint. Must not be null. |
| method | [RestSharp.Method](#T-RestSharp-Method 'RestSharp.Method') | The HTTP method to use for the request. Must not be null. |
| format | [System.Nullable{RestSharp.DataFormat}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{RestSharp.DataFormat}') | The optional [DataFormat](#T-RestSharp-DataFormat 'RestSharp.DataFormat') for the request. Defaults to JSON if not specified. |

##### Example

```C#
var url = new Url("https://example.com/resource");
var response = await url.CallAsync(Method.GET);
Console.WriteLine(response?.Content);
```

##### Remarks

This method sends a REST request to the specified URL using the provided HTTP method and data format.

<a name='M-Bb-Urls-UrlExtension-CallAsync-Bb-Urls-Url,RestSharp-Method,System-Action{RestSharp-RestRequest}-'></a>
### CallAsync(self,method,initializer) `method`

##### Summary

Executes a REST call asynchronously using the specified HTTP method and request initializer.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the asynchronous operation, with a result of [RestResponse](#T-RestSharp-RestResponse 'RestSharp.RestResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') instance representing the endpoint. Must not be null. |
| method | [RestSharp.Method](#T-RestSharp-Method 'RestSharp.Method') | The HTTP method to use for the request. Must not be null. |
| initializer | [System.Action{RestSharp.RestRequest}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{RestSharp.RestRequest}') | An action to initialize the [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest'). Must not be null. |

##### Example

```C#
var url = new Url("https://example.com/resource");
var response = await url.CallAsync(Method.POST, request =&gt; request.AddJsonBody(new { key = "value" }));
Console.WriteLine(response?.Content);
```

##### Remarks

This method sends a REST request to the specified URL using the provided HTTP method and allows customization of the request.

<a name='M-Bb-Urls-UrlExtension-CallAsync-Bb-Urls-Url,RestSharp-Method,System-Nullable{RestSharp-DataFormat},System-Action{RestSharp-RestRequest}-'></a>
### CallAsync(self,method,format,initializer) `method`

##### Summary

Executes a REST call asynchronously using the specified HTTP method, data format, and request initializer.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the asynchronous operation, with a result of [RestResponse](#T-RestSharp-RestResponse 'RestSharp.RestResponse').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') instance representing the endpoint. Must not be null. |
| method | [RestSharp.Method](#T-RestSharp-Method 'RestSharp.Method') | The HTTP method to use for the request. Must not be null. |
| format | [System.Nullable{RestSharp.DataFormat}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{RestSharp.DataFormat}') | The optional [DataFormat](#T-RestSharp-DataFormat 'RestSharp.DataFormat') for the request. Defaults to JSON if not specified. |
| initializer | [System.Action{RestSharp.RestRequest}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{RestSharp.RestRequest}') | An action to initialize the [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest'). Must not be null. |

##### Example

```C#
var url = new Url("https://example.com/resource");
var response = await url.CallAsync(Method.PUT, DataFormat.Json, request =&gt; request.AddJsonBody(new { key = "value" }));
Console.WriteLine(response?.Content);
```

##### Remarks

This method sends a REST request to the specified URL using the provided HTTP method, data format, and allows customization of the request.

<a name='M-Bb-Urls-UrlExtension-CombineUrl-System-Collections-Generic-IEnumerable{Bb-Urls-Url}-'></a>
### CombineUrl(urls) `method`

##### Summary

Concatenates a collection of URLs into a single [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') separated by semicolons.

##### Returns

A [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') containing the concatenated URLs.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urls | [System.Collections.Generic.IEnumerable{Bb.Urls.Url}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Bb.Urls.Url}') | The collection of [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') instances to concatenate. Must not be null. |

##### Example

```C#
var urls = new List&lt;Url&gt; { new Url("https://example1.com"), new Url("https://example2.com") };
var result = urls.ConcatUrl();
Console.WriteLine(result); // Output: https://example1.com;https://example2.com
```

##### Remarks

This method combines multiple URLs into a single string, separated by semicolons.

<a name='M-Bb-Urls-UrlExtension-CombineUrl-System-Text-StringBuilder,System-Collections-Generic-IEnumerable{Bb-Urls-Url}-'></a>
### CombineUrl(sb,urls) `method`

##### Summary

Concatenates a collection of URLs into the provided [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') separated by semicolons.

##### Returns

The [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') containing the concatenated URLs.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sb | [System.Text.StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') | The [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') to append the URLs to. If null, a new instance is created. |
| urls | [System.Collections.Generic.IEnumerable{Bb.Urls.Url}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Bb.Urls.Url}') | The collection of [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') instances to concatenate. Must not be null. |

##### Example

```C#
var sb = new StringBuilder();
var urls = new List&lt;Url&gt; { new Url("https://example1.com"), new Url("https://example2.com") };
sb.ConcatUrl(urls);
Console.WriteLine(sb); // Output: https://example1.com;https://example2.com
```

##### Remarks

This method appends multiple URLs to the provided [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder'), separated by semicolons.

<a name='M-Bb-Urls-UrlExtension-GetTokenAsync-Bb-Urls-Url,System-String,System-String,System-String,System-String-'></a>
### GetTokenAsync(self,client_id,client_secret,userName,password) `method`

##### Summary

Retrieves an authentication token asynchronously using the specified credentials.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the asynchronous operation, with a result of [TokenResponse](#T-Bb-Http-TokenResponse 'Bb.Http.TokenResponse') containing the token details.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The URL on the server. Must not be null. |
| client_id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The client ID for authentication. Must not be null or empty. |
| client_secret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The client secret for authentication. Can be null or empty. |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The userName for authentication. Must not be null or empty. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password for authentication. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the token request fails or the response is not successful. |

##### Example

```C#
var url = new Url("https://example.com/token");
var tokenResponse = await url.GetTokenAsync("myClientId", "myClientSecret", "myUsername", "myPassword");
Console.WriteLine(tokenResponse?.AccessToken);
```

##### Remarks

This method sends a POST request to the specified endpoint to retrieve an authentication token using the provided credentials.

<a name='M-Bb-Urls-UrlExtension-Map-System-String,System-String,System-String-'></a>
### Map(self,variable,value) `method`

##### Summary

Maps a variable in the URL to a specified value.

##### Returns

A new [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') instance with the variable replaced by the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL string to map. Must not be null or empty. |
| variable | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The variable name to replace in the URL. Must not be null or empty. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value to replace the variable with. Must not be null or empty. |

##### Example

```C#
var url = "https://example.com/{id}".Map("id", "123");
Console.WriteLine(url); // Output: https://example.com/123
```

##### Remarks

This method replaces a variable in the URL with the provided value.

<a name='M-Bb-Urls-UrlExtension-RemoveFragment-System-String-'></a>
### RemoveFragment(url) `method`

##### Summary

Removes the URL fragment including the #.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Urls-UrlExtension-RemoveLastPathSegment-System-String-'></a>
### RemoveLastPathSegment(url) `method`

##### Summary

Removes the last path segment from the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Urls-UrlExtension-RemovePath-System-String-'></a>
### RemovePath(url) `method`

##### Summary

Removes the entire path component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Urls-UrlExtension-RemoveQuery-System-String-'></a>
### RemoveQuery(url) `method`

##### Summary

Removes the entire query component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Urls-UrlExtension-RemoveQueryParam-System-String,System-String-'></a>
### RemoveQueryParam(url,name) `method`

##### Summary

Creates a new Url object from the string and removes a name/value pair from the query by name.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Query string parameter name to remove |

<a name='M-Bb-Urls-UrlExtension-RemoveQueryParam-System-String,System-String[]-'></a>
### RemoveQueryParam(url,names) `method`

##### Summary

Creates a new Url object from the string and removes multiple name/value pairs from the query by name.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Query string parameter names to remove |

<a name='M-Bb-Urls-UrlExtension-RemoveQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### RemoveQueryParam(url,names) `method`

##### Summary

Creates a new Url object from the string and removes multiple name/value pairs from the query by name.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| names | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Query string parameter names to remove |

<a name='M-Bb-Urls-UrlExtension-ResetToRoot-System-String-'></a>
### ResetToRoot(url) `method`

##### Summary

Trims the URL to its root, including the scheme, any user info, host, and port (if specified).

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Urls-UrlExtension-RestClient-Bb-Urls-Url-'></a>
### RestClient(url) `method`

##### Summary

Creates a new [RestClient](#M-Bb-Urls-UrlExtension-RestClient-Bb-Urls-Url- 'Bb.Urls.UrlExtension.RestClient(Bb.Urls.Url)') instance using the specified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url').

##### Returns

A new [RestClient](#M-Bb-Urls-UrlExtension-RestClient-Bb-Urls-Url- 'Bb.Urls.UrlExtension.RestClient(Bb.Urls.Url)') instance configured with the root URL.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') instance to use for creating the client. Must not be null. |

##### Example

```C#
var url = new Url("https://example.com");
var client = url.RestClient();
```

##### Remarks

This method initializes a REST client using the root URL of the provided [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') instance.

<a name='M-Bb-Urls-UrlExtension-SetFragment-System-String,System-String-'></a>
### SetFragment(url,fragment) `method`

##### Summary

Set the URL fragment fluently.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| fragment | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The part of the URL after # |

<a name='M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-String,System-Object,Bb-NullValueHandling-'></a>
### SetQueryParam(url,name,value,nullValueHandling) `method`

##### Summary

Creates a new Url object from the string and adds a parameter to the query, overwriting the value if name exists.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Value of query parameter |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing) |

<a name='M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-String,System-String,System-Boolean,Bb-NullValueHandling-'></a>
### SetQueryParam(url,name,value,isEncoded,nullValueHandling) `method`

##### Summary

Creates a new Url object from the string and adds a parameter to the query, overwriting the value if name exists.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value of query parameter |
| isEncoded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to true to indicate the value is already URL-encoded. Defaults to false. |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing). |

<a name='M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-String-'></a>
### SetQueryParam(url,name) `method`

##### Summary

Creates a new Url object from the string and adds a parameter without a value to the query, removing any existing value.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |

<a name='M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-Object,Bb-NullValueHandling-'></a>
### SetQueryParam(url,values,nullValueHandling) `method`

##### Summary

Creates a new Url object from the string, parses values object into name/value pairs, and adds them to the query, overwriting any that already exist.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Typically an anonymous object, ie: new { x = 1, y = 2 } |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing) |

<a name='M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### SetQueryParam(url,names) `method`

##### Summary

Creates a new Url object from the string and adds multiple parameters without values to the query.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| names | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Names of query parameters. |

<a name='M-Bb-Urls-UrlExtension-SetQueryParam-System-String,System-String[]-'></a>
### SetQueryParam(url,names) `method`

##### Summary

Creates a new Url object from the string and adds multiple parameters without values to the query.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Names of query parameters |

<a name='M-Bb-Urls-UrlExtension-WithFragment-System-Uri,System-String-'></a>
### WithFragment(uri,fragment) `method`

##### Summary

Set the URL fragment fluently.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| fragment | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The part of the URL after # |

<a name='M-Bb-Urls-UrlExtension-WithHTTPS-Bb-Urls-Url-'></a>
### WithHTTPS(self) `method`

##### Summary

Sets the scheme of the specified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object to "https".

##### Returns

The modified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object to modify. Must not be null. |

##### Example

```C#
var url = new Url("http://example.com").WithHTTPS();
Console.WriteLine(url.ToString()); // Output: https://example.com
```

##### Remarks

This method sets the scheme of the URL to "https".

<a name='M-Bb-Urls-UrlExtension-WithHost-Bb-Urls-Url,System-String-'></a>
### WithHost(self,host) `method`

##### Summary

Sets the host for the specified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object.

##### Returns

The modified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object to modify. Must not be null. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host to set, such as "example.org". Must not be null or empty. |

##### Example

```C#
var url = new Url("https://example.com").WithHost("example.org");
Console.WriteLine(url.ToString()); // Output: https://example.org
```

##### Remarks

This method sets the host part of the URL.

<a name='M-Bb-Urls-UrlExtension-WithHttp-Bb-Urls-Url-'></a>
### WithHttp(self) `method`

##### Summary

Sets the scheme of the specified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object to "http".

##### Returns

The modified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object to modify. Must not be null. |

##### Example

```C#
var url = new Url("https://example.com").WithHttp();
Console.WriteLine(url.ToString()); // Output: http://example.com
```

##### Remarks

This method sets the scheme of the URL to "http".

<a name='M-Bb-Urls-UrlExtension-WithPathSegment-System-String,System-String-'></a>
### WithPathSegment(url,segment) `method`

##### Summary

Creates a new Url object from the string and appends a segment to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| segment | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The segment to append |

<a name='M-Bb-Urls-UrlExtension-WithPathSegment-System-String,System-String[]-'></a>
### WithPathSegment(url,segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The segments to append |

<a name='M-Bb-Urls-UrlExtension-WithPathSegment-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithPathSegment(url,segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| segments | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The segments to append |

<a name='M-Bb-Urls-UrlExtension-WithPathSegment-System-Uri,System-String-'></a>
### WithPathSegment(uri,segment) `method`

##### Summary

Creates a new Url object from the string and appends a segment to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| segment | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The segment to append |

<a name='M-Bb-Urls-UrlExtension-WithPathSegment-System-Uri,System-String[]-'></a>
### WithPathSegment(uri,segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The segments to append |

<a name='M-Bb-Urls-UrlExtension-WithPathSegment-System-Uri,System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithPathSegment(uri,segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| segments | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The segments to append |

<a name='M-Bb-Urls-UrlExtension-WithPort-Bb-Urls-Url,System-Int32-'></a>
### WithPort(self,port) `method`

##### Summary

Sets the port for the specified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object.

##### Returns

The modified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object to modify. Must not be null. |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The port to set, such as 8080. Must be a valid port number. |

##### Example

```C#
var url = new Url("https://example.com").WithPort(8080);
Console.WriteLine(url.ToString()); // Output: https://example.com:8080
```

##### Remarks

This method sets the port part of the URL.

<a name='M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-String,System-Object,Bb-NullValueHandling-'></a>
### WithQueryParam(uri,name,value,nullValueHandling) `method`

##### Summary

Creates a new Url object from the string and adds a parameter to the query, overwriting the value if name exists.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Value of query parameter |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing) |

<a name='M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-String,System-String,System-Boolean,Bb-NullValueHandling-'></a>
### WithQueryParam(uri,name,value,isEncoded,nullValueHandling) `method`

##### Summary

Creates a new Url object from the string and adds a parameter to the query, overwriting the value if name exists.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value of query parameter |
| isEncoded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to true to indicate the value is already URL-encoded. Defaults to false. |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing). |

<a name='M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-String-'></a>
### WithQueryParam(uri,name) `method`

##### Summary

Creates a new Url object from the string and adds a parameter without a value to the query, removing any existing value.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |

<a name='M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-Object,Bb-NullValueHandling-'></a>
### WithQueryParam(uri,values,nullValueHandling) `method`

##### Summary

Creates a new Url object from the string, parses values object into name/value pairs, and adds them to the query, overwriting any that already exist.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Typically an anonymous object, ie: new { x = 1, y = 2 } |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing) |

<a name='M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithQueryParam(uri,names) `method`

##### Summary

Creates a new Url object from the string and adds multiple parameters without values to the query.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| names | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Names of query parameters. |

<a name='M-Bb-Urls-UrlExtension-WithQueryParam-System-Uri,System-String[]-'></a>
### WithQueryParam(uri,names) `method`

##### Summary

Creates a new Url object from the string and adds multiple parameters without values to the query.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Names of query parameters |

<a name='M-Bb-Urls-UrlExtension-WithRemoveFragment-System-Uri-'></a>
### WithRemoveFragment(uri) `method`

##### Summary

Removes the URL fragment including the #.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Urls-UrlExtension-WithRemovePath-System-Uri-'></a>
### WithRemovePath(uri) `method`

##### Summary

Removes the entire path component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Urls-UrlExtension-WithRemovePathSegment-System-Uri-'></a>
### WithRemovePathSegment(uri) `method`

##### Summary

Removes the last path segment from the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Urls-UrlExtension-WithRemoveQuery-System-Uri-'></a>
### WithRemoveQuery(uri) `method`

##### Summary

Removes the entire query component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Urls-UrlExtension-WithRemoveQueryParam-System-Uri,System-String-'></a>
### WithRemoveQueryParam(uri,name) `method`

##### Summary

Creates a new Url object from the string and removes a name/value pair from the query by name.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Query string parameter name to remove |

<a name='M-Bb-Urls-UrlExtension-WithRemoveQueryParam-System-Uri,System-String[]-'></a>
### WithRemoveQueryParam(uri,names) `method`

##### Summary

Creates a new Url object from the string and removes multiple name/value pairs from the query by name.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Query string parameter names to remove |

<a name='M-Bb-Urls-UrlExtension-WithRemoveQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithRemoveQueryParam(uri,names) `method`

##### Summary

Creates a new Url object from the string and removes multiple name/value pairs from the query by name.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| names | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Query string parameter names to remove |

<a name='M-Bb-Urls-UrlExtension-WithResetToRoot-System-Uri-'></a>
### WithResetToRoot(uri) `method`

##### Summary

Trims the URL to its root, including the scheme, any user info, host, and port (if specified).

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Urls-UrlExtension-WithUserInfo-Bb-Urls-Url,System-String-'></a>
### WithUserInfo(self,userInfo) `method`

##### Summary

Sets the user information for the specified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object.

##### Returns

The modified [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object to modify. Must not be null. |
| userInfo | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user information to set, such as "user:pass". Must not be null or empty. |

##### Example

```C#
var url = new Url("https://example.com").WithUserInfo("user:pass");
Console.WriteLine(url.ToString()); // Output: https://user:pass@example.com
```

##### Remarks

This method sets the "user:pass" part of the URL.
