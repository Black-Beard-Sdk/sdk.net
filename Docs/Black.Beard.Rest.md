<a name='assembly'></a>
# Black.Beard.Rest

## Contents

- [Bag\`1](#T-Bb-Services-Bag`1 'Bb.Services.Bag`1')
  - [#ctor()](#M-Bb-Services-Bag`1-#ctor 'Bb.Services.Bag`1.#ctor')
  - [Value](#P-Bb-Services-Bag`1-Value 'Bb.Services.Bag`1.Value')
- [ClientRestOption](#T-Bb-Services-ClientRestOption 'Bb.Services.ClientRestOption')
  - [Timeout](#P-Bb-Services-ClientRestOption-Timeout 'Bb.Services.ClientRestOption.Timeout')
- [CommonExtensions](#T-Bb-Urls-CommonExtensions 'Bb.Urls.CommonExtensions')
  - [IsIP()](#M-Bb-Urls-CommonExtensions-IsIP-System-String- 'Bb.Urls.CommonExtensions.IsIP(System.String)')
  - [Merge\`\`2()](#M-Bb-Urls-CommonExtensions-Merge``2-System-Collections-Generic-IDictionary{``0,``1},System-Collections-Generic-IDictionary{``0,``1}- 'Bb.Urls.CommonExtensions.Merge``2(System.Collections.Generic.IDictionary{``0,``1},System.Collections.Generic.IDictionary{``0,``1})')
  - [SplitOnFirstOccurence(s,separator)](#M-Bb-Urls-CommonExtensions-SplitOnFirstOccurence-System-String,System-String- 'Bb.Urls.CommonExtensions.SplitOnFirstOccurence(System.String,System.String)')
  - [StripQuotes()](#M-Bb-Urls-CommonExtensions-StripQuotes-System-String- 'Bb.Urls.CommonExtensions.StripQuotes(System.String)')
  - [ToInvariantString()](#M-Bb-Urls-CommonExtensions-ToInvariantString-System-Object- 'Bb.Urls.CommonExtensions.ToInvariantString(System.Object)')
  - [ToKeyValuePairs(obj)](#M-Bb-Urls-CommonExtensions-ToKeyValuePairs-System-Object- 'Bb.Urls.CommonExtensions.ToKeyValuePairs(System.Object)')
- [CurlContext](#T-Bb-Curls-CurlContext 'Bb.Curls.CurlContext')
  - [#ctor(cancellationTokenSource)](#M-Bb-Curls-CurlContext-#ctor-System-Threading-CancellationTokenSource- 'Bb.Curls.CurlContext.#ctor(System.Threading.CancellationTokenSource)')
  - [CallAsync()](#M-Bb-Curls-CurlContext-CallAsync-RestSharp-RestClient- 'Bb.Curls.CurlContext.CallAsync(RestSharp.RestClient)')
- [CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter')
  - [#ctor(arguments)](#M-Bb-Curls-CurlInterpreter-#ctor-System-String[]- 'Bb.Curls.CurlInterpreter.#ctor(System.String[])')
  - [CallAsync(source)](#M-Bb-Curls-CurlInterpreter-CallAsync-System-Threading-CancellationTokenSource- 'Bb.Curls.CurlInterpreter.CallAsync(System.Threading.CancellationTokenSource)')
  - [CallAsync(source)](#M-Bb-Curls-CurlInterpreter-CallAsync-Bb-Interfaces-IRestClientFactory,System-Threading-CancellationTokenSource- 'Bb.Curls.CurlInterpreter.CallAsync(Bb.Interfaces.IRestClientFactory,System.Threading.CancellationTokenSource)')
  - [op_Implicit(self)](#M-Bb-Curls-CurlInterpreter-op_Implicit-System-String-~Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter.op_Implicit(System.String)~Bb.Curls.CurlInterpreter')
- [CurlInterpreterAction](#T-Bb-Curls-CurlInterpreterAction 'Bb.Curls.CurlInterpreterAction')
  - [#ctor(configureAction,arguments)](#M-Bb-Curls-CurlInterpreterAction-#ctor-System-Action{Bb-Curls-CurlInterpreterAction,Bb-Curls-CurlContext},Bb-Curls-Argument[]- 'Bb.Curls.CurlInterpreterAction.#ctor(System.Action{Bb.Curls.CurlInterpreterAction,Bb.Curls.CurlContext},Bb.Curls.Argument[])')
  - [Exists(name)](#M-Bb-Curls-CurlInterpreterAction-Exists-System-String- 'Bb.Curls.CurlInterpreterAction.Exists(System.String)')
  - [Get(name)](#M-Bb-Curls-CurlInterpreterAction-Get-System-String- 'Bb.Curls.CurlInterpreterAction.Get(System.String)')
  - [Get(test)](#M-Bb-Curls-CurlInterpreterAction-Get-System-Func{Bb-Curls-Argument,System-Boolean}- 'Bb.Curls.CurlInterpreterAction.Get(System.Func{Bb.Curls.Argument,System.Boolean})')
- [CurlLexer](#T-Bb-Curls-CurlLexer 'Bb.Curls.CurlLexer')
  - [#ctor(args)](#M-Bb-Curls-CurlLexer-#ctor-System-String- 'Bb.Curls.CurlLexer.#ctor(System.String)')
  - [Current](#P-Bb-Curls-CurlLexer-Current 'Bb.Curls.CurlLexer.Current')
  - [Next()](#M-Bb-Curls-CurlLexer-Next 'Bb.Curls.CurlLexer.Next')
- [CurlParserExtension](#T-Bb-Curls-CurlParserExtension 'Bb.Curls.CurlParserExtension')
  - [#cctor()](#M-Bb-Curls-CurlParserExtension-#cctor 'Bb.Curls.CurlParserExtension.#cctor')
  - [IsUrl(self)](#M-Bb-Curls-CurlParserExtension-IsUrl-System-String- 'Bb.Curls.CurlParserExtension.IsUrl(System.String)')
  - [ParseCurlLine(lineArg)](#M-Bb-Curls-CurlParserExtension-ParseCurlLine-System-String- 'Bb.Curls.CurlParserExtension.ParseCurlLine(System.String)')
  - [Precompile(lineArg)](#M-Bb-Curls-CurlParserExtension-Precompile-System-String- 'Bb.Curls.CurlParserExtension.Precompile(System.String)')
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
  - [BeginScope\`\`1(state)](#M-Bb-Services-LocalLogger-BeginScope``1-``0- 'Bb.Services.LocalLogger.BeginScope``1(``0)')
  - [GetLogLevelString(logLevel)](#M-Bb-Services-LocalLogger-GetLogLevelString-Microsoft-Extensions-Logging-LogLevel- 'Bb.Services.LocalLogger.GetLogLevelString(Microsoft.Extensions.Logging.LogLevel)')
  - [IsEnabled(logLevel)](#M-Bb-Services-LocalLogger-IsEnabled-Microsoft-Extensions-Logging-LogLevel- 'Bb.Services.LocalLogger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)')
  - [Log\`\`1(logLevel,eventId,state,exception,formatter)](#M-Bb-Services-LocalLogger-Log``1-Microsoft-Extensions-Logging-LogLevel,Microsoft-Extensions-Logging-EventId,``0,System-Exception,System-Func{``0,System-Exception,System-String}- 'Bb.Services.LocalLogger.Log``1(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,``0,System.Exception,System.Func{``0,System.Exception,System.String})')
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
- [NameValueList\`1](#T-Bb-Urls-NameValueList`1 'Bb.Urls.NameValueList`1')
  - [#ctor()](#M-Bb-Urls-NameValueList`1-#ctor-System-Boolean- 'Bb.Urls.NameValueList`1.#ctor(System.Boolean)')
  - [#ctor()](#M-Bb-Urls-NameValueList`1-#ctor-System-Collections-Generic-IEnumerable{System-ValueTuple{System-String,`0}},System-Boolean- 'Bb.Urls.NameValueList`1.#ctor(System.Collections.Generic.IEnumerable{System.ValueTuple{System.String,`0}},System.Boolean)')
  - [Add()](#M-Bb-Urls-NameValueList`1-Add-System-String,`0- 'Bb.Urls.NameValueList`1.Add(System.String,`0)')
  - [AddOrReplace()](#M-Bb-Urls-NameValueList`1-AddOrReplace-System-String,`0- 'Bb.Urls.NameValueList`1.AddOrReplace(System.String,`0)')
  - [Contains()](#M-Bb-Urls-NameValueList`1-Contains-System-String- 'Bb.Urls.NameValueList`1.Contains(System.String)')
  - [Contains()](#M-Bb-Urls-NameValueList`1-Contains-System-String,`0- 'Bb.Urls.NameValueList`1.Contains(System.String,`0)')
  - [FirstOrDefault()](#M-Bb-Urls-NameValueList`1-FirstOrDefault-System-String- 'Bb.Urls.NameValueList`1.FirstOrDefault(System.String)')
  - [GetAll()](#M-Bb-Urls-NameValueList`1-GetAll-System-String- 'Bb.Urls.NameValueList`1.GetAll(System.String)')
  - [Remove()](#M-Bb-Urls-NameValueList`1-Remove-System-String- 'Bb.Urls.NameValueList`1.Remove(System.String)')
  - [TryGetFirst()](#M-Bb-Urls-NameValueList`1-TryGetFirst-System-String,`0@- 'Bb.Urls.NameValueList`1.TryGetFirst(System.String,`0@)')
- [NoopDisposable](#T-Bb-Services-LocalLogger-NoopDisposable 'Bb.Services.LocalLogger.NoopDisposable')
  - [Dispose()](#M-Bb-Services-LocalLogger-NoopDisposable-Dispose 'Bb.Services.LocalLogger.NoopDisposable.Dispose')
- [NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling')
  - [Ignore](#F-Bb-NullValueHandling-Ignore 'Bb.NullValueHandling.Ignore')
  - [NameOnly](#F-Bb-NullValueHandling-NameOnly 'Bb.NullValueHandling.NameOnly')
  - [Remove](#F-Bb-NullValueHandling-Remove 'Bb.NullValueHandling.Remove')
- [OptionClientFactory](#T-Bb-Services-OptionClientFactory 'Bb.Services.OptionClientFactory')
  - [#ctor(serviceProvider)](#M-Bb-Services-OptionClientFactory-#ctor-System-IServiceProvider- 'Bb.Services.OptionClientFactory.#ctor(System.IServiceProvider)')
  - [#ctor(configuration)](#M-Bb-Services-OptionClientFactory-#ctor-Microsoft-Extensions-Options-IOptions{Bb-Services-ClientRestOption}- 'Bb.Services.OptionClientFactory.#ctor(Microsoft.Extensions.Options.IOptions{Bb.Services.ClientRestOption})')
  - [Debug](#P-Bb-Services-OptionClientFactory-Debug 'Bb.Services.OptionClientFactory.Debug')
  - [Interceptor](#P-Bb-Services-OptionClientFactory-Interceptor 'Bb.Services.OptionClientFactory.Interceptor')
  - [Configure(url,action)](#M-Bb-Services-OptionClientFactory-Configure-Bb-Urls-Url,System-Action{RestSharp-RestClientOptions}- 'Bb.Services.OptionClientFactory.Configure(Bb.Urls.Url,System.Action{RestSharp.RestClientOptions})')
  - [Configure(uri,action)](#M-Bb-Services-OptionClientFactory-Configure-System-Uri,System-Action{RestSharp-RestClientOptions}- 'Bb.Services.OptionClientFactory.Configure(System.Uri,System.Action{RestSharp.RestClientOptions})')
  - [Configure(name,action)](#M-Bb-Services-OptionClientFactory-Configure-System-String,System-Action{RestSharp-RestClientOptions}- 'Bb.Services.OptionClientFactory.Configure(System.String,System.Action{RestSharp.RestClientOptions})')
  - [Create(name)](#M-Bb-Services-OptionClientFactory-Create-System-String- 'Bb.Services.OptionClientFactory.Create(System.String)')
  - [Trace(options)](#M-Bb-Services-OptionClientFactory-Trace-RestSharp-RestClientOptions- 'Bb.Services.OptionClientFactory.Trace(RestSharp.RestClientOptions)')
- [QueryParamCollection](#T-Bb-Urls-QueryParamCollection 'Bb.Urls.QueryParamCollection')
  - [#ctor(query)](#M-Bb-Urls-QueryParamCollection-#ctor-System-String- 'Bb.Urls.QueryParamCollection.#ctor(System.String)')
  - [Count](#P-Bb-Urls-QueryParamCollection-Count 'Bb.Urls.QueryParamCollection.Count')
  - [Item](#P-Bb-Urls-QueryParamCollection-Item-System-Int32- 'Bb.Urls.QueryParamCollection.Item(System.Int32)')
  - [Add(name,value,nullValueHandling)](#M-Bb-Urls-QueryParamCollection-Add-System-String,System-Object,Bb-NullValueHandling- 'Bb.Urls.QueryParamCollection.Add(System.String,System.Object,Bb.NullValueHandling)')
  - [AddOrReplace(name,value,isEncoded,nullValueHandling)](#M-Bb-Urls-QueryParamCollection-AddOrReplace-System-String,System-Object,Bb-NullValueHandling- 'Bb.Urls.QueryParamCollection.AddOrReplace(System.String,System.Object,Bb.NullValueHandling)')
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
  - [Value](#P-Bb-Urls-QueryParamValue-Value 'Bb.Urls.QueryParamValue.Value')
  - [EncodedValue()](#M-Bb-Urls-QueryParamValue-EncodedValue-System-Boolean- 'Bb.Urls.QueryParamValue.EncodedValue(System.Boolean)')
  - [ToString()](#M-Bb-Urls-QueryParamValue-ToString 'Bb.Urls.QueryParamValue.ToString')
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
  - [GetTokenAsync(self,path,client_id,client_secret,username,password)](#M-Bb-Helpers-RestClientExtension-GetTokenAsync-RestSharp-RestClient,System-String,System-String,System-String,System-String,System-String- 'Bb.Helpers.RestClientExtension.GetTokenAsync(RestSharp.RestClient,System.String,System.String,System.String,System.String,System.String)')
- [RestClientFactory](#T-Bb-Services-RestClientFactory 'Bb.Services.RestClientFactory')
  - [#ctor(optionFactory)](#M-Bb-Services-RestClientFactory-#ctor-Bb-Interfaces-IOptionClientFactory- 'Bb.Services.RestClientFactory.#ctor(Bb.Interfaces.IOptionClientFactory)')
  - [_clients](#F-Bb-Services-RestClientFactory-_clients 'Bb.Services.RestClientFactory._clients')
  - [_optionFactory](#F-Bb-Services-RestClientFactory-_optionFactory 'Bb.Services.RestClientFactory._optionFactory')
  - [Create(baseUrl)](#M-Bb-Services-RestClientFactory-Create-System-Uri- 'Bb.Services.RestClientFactory.Create(System.Uri)')
  - [Create(name)](#M-Bb-Services-RestClientFactory-Create-System-String- 'Bb.Services.RestClientFactory.Create(System.String)')
  - [Create(name)](#M-Bb-Services-RestClientFactory-Create-Bb-Urls-Url- 'Bb.Services.RestClientFactory.Create(Bb.Urls.Url)')
- [RestOptionExtension](#T-Bb-Helpers-RestOptionExtension 'Bb.Helpers.RestOptionExtension')
  - [InterceptCookies(self,bag)](#M-Bb-Helpers-RestOptionExtension-InterceptCookies-RestSharp-RestClientOptions,Bb-Services-Bag{System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{System-String,System-Collections-Generic-IEnumerable{System-String}}}}@- 'Bb.Helpers.RestOptionExtension.InterceptCookies(RestSharp.RestClientOptions,Bb.Services.Bag{System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{System.String,System.Collections.Generic.IEnumerable{System.String}}}}@)')
  - [InterceptRequest(self,interceptor)](#M-Bb-Helpers-RestOptionExtension-InterceptRequest-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpRequestMessage}- 'Bb.Helpers.RestOptionExtension.InterceptRequest(RestSharp.RestClientOptions,System.Action{System.Net.Http.HttpRequestMessage})')
  - [InterceptResponse(self,interceptor)](#M-Bb-Helpers-RestOptionExtension-InterceptResponse-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpResponseMessage}- 'Bb.Helpers.RestOptionExtension.InterceptResponse(RestSharp.RestClientOptions,System.Action{System.Net.Http.HttpResponseMessage})')
  - [WithBasicHttp(self,username,password)](#M-Bb-Helpers-RestOptionExtension-WithBasicHttp-RestSharp-RestClientOptions,System-String,System-String- 'Bb.Helpers.RestOptionExtension.WithBasicHttp(RestSharp.RestClientOptions,System.String,System.String)')
- [RestRequestExtension](#T-Bb-Helpers-RestRequestExtension 'Bb.Helpers.RestRequestExtension')
  - [InterceptCookies(self,bag)](#M-Bb-Helpers-RestRequestExtension-InterceptCookies-RestSharp-RestClientOptions,Bb-Services-Bag{System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{System-String,System-Collections-Generic-IEnumerable{System-String}}}}@- 'Bb.Helpers.RestRequestExtension.InterceptCookies(RestSharp.RestClientOptions,Bb.Services.Bag{System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{System.String,System.Collections.Generic.IEnumerable{System.String}}}}@)')
  - [InterceptRequest(self,interceptor)](#M-Bb-Helpers-RestRequestExtension-InterceptRequest-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpRequestMessage}- 'Bb.Helpers.RestRequestExtension.InterceptRequest(RestSharp.RestClientOptions,System.Action{System.Net.Http.HttpRequestMessage})')
  - [InterceptResponse(self,interceptor)](#M-Bb-Helpers-RestRequestExtension-InterceptResponse-RestSharp-RestClientOptions,System-Action{System-Net-Http-HttpResponseMessage}- 'Bb.Helpers.RestRequestExtension.InterceptResponse(RestSharp.RestClientOptions,System.Action{System.Net.Http.HttpResponseMessage})')
  - [WithBasicHttp(self,userName,password)](#M-Bb-Helpers-RestRequestExtension-WithBasicHttp-RestSharp-RestClientOptions,System-String,System-String- 'Bb.Helpers.RestRequestExtension.WithBasicHttp(RestSharp.RestClientOptions,System.String,System.String)')
- [Segment](#T-Bb-Urls-Segment 'Bb.Urls.Segment')
  - [#ctor(segment)](#M-Bb-Urls-Segment-#ctor-System-String- 'Bb.Urls.Segment.#ctor(System.String)')
  - [EncodedValue](#P-Bb-Urls-Segment-EncodedValue 'Bb.Urls.Segment.EncodedValue')
  - [IsVariable](#P-Bb-Urls-Segment-IsVariable 'Bb.Urls.Segment.IsVariable')
  - [Value](#P-Bb-Urls-Segment-Value 'Bb.Urls.Segment.Value')
  - [Map(value)](#M-Bb-Urls-Segment-Map-System-String- 'Bb.Urls.Segment.Map(System.String)')
  - [ToString()](#M-Bb-Urls-Segment-ToString 'Bb.Urls.Segment.ToString')
- [Url](#T-Bb-Urls-Url 'Bb.Urls.Url')
  - [Root](#P-Bb-Urls-Url-Root 'Bb.Urls.Url.Root')
  - [EncodeIllegalCharacters(s,encodeSpaceAsPlus)](#M-Bb-Urls-Url-EncodeIllegalCharacters-System-String,System-Boolean- 'Bb.Urls.Url.EncodeIllegalCharacters(System.String,System.Boolean)')
  - [Map(values)](#M-Bb-Urls-Url-Map-System-ValueTuple{System-String,System-String}[]- 'Bb.Urls.Url.Map(System.ValueTuple{System.String,System.String}[])')
  - [Map(name,value)](#M-Bb-Urls-Url-Map-System-String,System-String- 'Bb.Urls.Url.Map(System.String,System.String)')
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
  - [WithQueryParam(name,value,nullValueHandling)](#M-Bb-Urls-Url-WithQueryParam-System-String,System-Object,Bb-NullValueHandling- 'Bb.Urls.Url.WithQueryParam(System.String,System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(name,value,isEncoded,nullValueHandling)](#M-Bb-Urls-Url-WithQueryParam-System-String,System-String,System-Boolean,Bb-NullValueHandling- 'Bb.Urls.Url.WithQueryParam(System.String,System.String,System.Boolean,Bb.NullValueHandling)')
  - [WithQueryParam(name)](#M-Bb-Urls-Url-WithQueryParam-System-String- 'Bb.Urls.Url.WithQueryParam(System.String)')
  - [WithQueryParam(values,nullValueHandling)](#M-Bb-Urls-Url-WithQueryParam-System-Object,Bb-NullValueHandling- 'Bb.Urls.Url.WithQueryParam(System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(names)](#M-Bb-Urls-Url-WithQueryParam-System-Collections-Generic-IEnumerable{System-String}- 'Bb.Urls.Url.WithQueryParam(System.Collections.Generic.IEnumerable{System.String})')
  - [WithQueryParam(names)](#M-Bb-Urls-Url-WithQueryParam-System-String[]- 'Bb.Urls.Url.WithQueryParam(System.String[])')
- [UrlExtension](#T-Bb-Urls-UrlExtension 'Bb.Urls.UrlExtension')
  - [CombineUrl(urls)](#M-Bb-Urls-UrlExtension-CombineUrl-System-Collections-Generic-IEnumerable{Bb-Urls-Url}- 'Bb.Urls.UrlExtension.CombineUrl(System.Collections.Generic.IEnumerable{Bb.Urls.Url})')
  - [CombineUrl(sb,urls)](#M-Bb-Urls-UrlExtension-CombineUrl-System-Text-StringBuilder,System-Collections-Generic-IEnumerable{Bb-Urls-Url}- 'Bb.Urls.UrlExtension.CombineUrl(System.Text.StringBuilder,System.Collections.Generic.IEnumerable{Bb.Urls.Url})')
  - [GetTokenAsync(self,path,client_id,client_secret,username,password)](#M-Bb-Urls-UrlExtension-GetTokenAsync-Bb-Urls-Url,System-String,System-String,System-String,System-String- 'Bb.Urls.UrlExtension.GetTokenAsync(Bb.Urls.Url,System.String,System.String,System.String,System.String)')
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
  - [WithHost(self,host)](#M-Bb-Urls-UrlExtension-WithHost-Bb-Urls-Url,System-String- 'Bb.Urls.UrlExtension.WithHost(Bb.Urls.Url,System.String)')
  - [WithHttp(self)](#M-Bb-Urls-UrlExtension-WithHttp-Bb-Urls-Url- 'Bb.Urls.UrlExtension.WithHttp(Bb.Urls.Url)')
  - [WithHttps(self)](#M-Bb-Urls-UrlExtension-WithHttps-Bb-Urls-Url- 'Bb.Urls.UrlExtension.WithHttps(Bb.Urls.Url)')
  - [WithPathSegment(url,segment,fullyEncode)](#M-Bb-Urls-UrlExtension-WithPathSegment-System-String,System-String- 'Bb.Urls.UrlExtension.WithPathSegment(System.String,System.String)')
  - [WithPathSegment(url,segments)](#M-Bb-Urls-UrlExtension-WithPathSegment-System-String,System-String[]- 'Bb.Urls.UrlExtension.WithPathSegment(System.String,System.String[])')
  - [WithPathSegment(url,segments)](#M-Bb-Urls-UrlExtension-WithPathSegment-System-String,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Urls.UrlExtension.WithPathSegment(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [WithPathSegment(uri,segment,fullyEncode)](#M-Bb-Urls-UrlExtension-WithPathSegment-System-Uri,System-String- 'Bb.Urls.UrlExtension.WithPathSegment(System.Uri,System.String)')
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

<a name='P-Bb-Services-ClientRestOption-Timeout'></a>
### Timeout `property`

##### Summary

Gets or sets the base URL for the REST client.

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

<a name='M-Bb-Urls-CommonExtensions-SplitOnFirstOccurence-System-String,System-String-'></a>
### SplitOnFirstOccurence(s,separator) `method`

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

<a name='T-Bb-Curls-CurlContext'></a>
## CurlContext `type`

##### Namespace

Bb.Curls

<a name='M-Bb-Curls-CurlContext-#ctor-System-Threading-CancellationTokenSource-'></a>
### #ctor(cancellationTokenSource) `constructor`

##### Summary

Initializes a new instance of the [CurlContext](#T-Bb-Curls-CurlContext 'Bb.Curls.CurlContext') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationTokenSource | [System.Threading.CancellationTokenSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationTokenSource 'System.Threading.CancellationTokenSource') | The cancellation token to cancel operation. |

<a name='M-Bb-Curls-CurlContext-CallAsync-RestSharp-RestClient-'></a>
### CallAsync() `method`

##### Summary

Send an HTTP request as an asynchronous operation.

##### Returns



##### Parameters

This method has no parameters.

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

<a name='M-Bb-Curls-CurlInterpreter-CallAsync-System-Threading-CancellationTokenSource-'></a>
### CallAsync(source) `method`

##### Summary

Calls asynchronously.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Threading.CancellationTokenSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationTokenSource 'System.Threading.CancellationTokenSource') |  |

<a name='M-Bb-Curls-CurlInterpreter-CallAsync-Bb-Interfaces-IRestClientFactory,System-Threading-CancellationTokenSource-'></a>
### CallAsync(source) `method`

##### Summary

Calls asynchronously.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [Bb.Interfaces.IRestClientFactory](#T-Bb-Interfaces-IRestClientFactory 'Bb.Interfaces.IRestClientFactory') |  |

<a name='M-Bb-Curls-CurlInterpreter-op_Implicit-System-String-~Bb-Curls-CurlInterpreter'></a>
### op_Implicit(self) `method`

##### Summary

implicit conversion from string to CurlInterpreter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String)~Bb.Curls.CurlInterpreter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String)~Bb.Curls.CurlInterpreter 'System.String)~Bb.Curls.CurlInterpreter') |  |

<a name='T-Bb-Curls-CurlInterpreterAction'></a>
## CurlInterpreterAction `type`

##### Namespace

Bb.Curls

<a name='M-Bb-Curls-CurlInterpreterAction-#ctor-System-Action{Bb-Curls-CurlInterpreterAction,Bb-Curls-CurlContext},Bb-Curls-Argument[]-'></a>
### #ctor(configureAction,arguments) `constructor`

##### Summary

create a new instance of [CurlInterpreterAction](#T-Bb-Curls-CurlInterpreterAction 'Bb.Curls.CurlInterpreterAction')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configureAction | [System.Action{Bb.Curls.CurlInterpreterAction,Bb.Curls.CurlContext}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Curls.CurlInterpreterAction,Bb.Curls.CurlContext}') |  |
| arguments | [Bb.Curls.Argument[]](#T-Bb-Curls-Argument[] 'Bb.Curls.Argument[]') |  |

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

Lexer that tokenize curl command line

<a name='M-Bb-Curls-CurlLexer-#ctor-System-String-'></a>
### #ctor(args) `constructor`

##### Summary

Initializes a new instance of the [CurlLexer](#T-Bb-Curls-CurlLexer 'Bb.Curls.CurlLexer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The arguments. |

<a name='P-Bb-Curls-CurlLexer-Current'></a>
### Current `property`

##### Summary

Gets the current token

<a name='M-Bb-Curls-CurlLexer-Next'></a>
### Next() `method`

##### Summary

return true if the line can read next token

##### Returns



##### Parameters

This method has no parameters.

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

<a name='M-Bb-Curls-CurlParserExtension-Precompile-System-String-'></a>
### Precompile(lineArg) `method`

##### Summary

Pre compiles the specified line argument and build CurlInterpreter.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lineArg | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

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

<a name='T-Bb-Helpers-LogConfigurationExtension'></a>
## LogConfigurationExtension `type`

##### Namespace

Bb.Helpers

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

<a name='T-Bb-Urls-NameValueList`1'></a>
## NameValueList\`1 `type`

##### Namespace

Bb.Urls

##### Summary

An ordered collection of Name/Value pairs where duplicate names are allowed but aren't typical.
Useful for things where a dictionary would work great if not for those pesky edge cases (headers, cookies, etc).

<a name='M-Bb-Urls-NameValueList`1-#ctor-System-Boolean-'></a>
### #ctor() `constructor`

##### Summary

Instantiates a new empty NameValueList.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Urls-NameValueList`1-#ctor-System-Collections-Generic-IEnumerable{System-ValueTuple{System-String,`0}},System-Boolean-'></a>
### #ctor() `constructor`

##### Summary

Instantiates a new NameValueList with the Name/Value pairs provided.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Urls-NameValueList`1-Add-System-String,`0-'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-NameValueList`1-AddOrReplace-System-String,`0-'></a>
### AddOrReplace() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-NameValueList`1-Contains-System-String-'></a>
### Contains() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-NameValueList`1-Contains-System-String,`0-'></a>
### Contains() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-NameValueList`1-FirstOrDefault-System-String-'></a>
### FirstOrDefault() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-NameValueList`1-GetAll-System-String-'></a>
### GetAll() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-NameValueList`1-Remove-System-String-'></a>
### Remove() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Urls-NameValueList`1-TryGetFirst-System-String,`0@-'></a>
### TryGetFirst() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Bb-Services-LocalLogger-NoopDisposable'></a>
## NoopDisposable `type`

##### Namespace

Bb.Services.LocalLogger

##### Summary

Represents a no-operation disposable object.

<a name='M-Bb-Services-LocalLogger-NoopDisposable-Dispose'></a>
### Dispose() `method`

##### Summary

Performs no operation on disposal.

##### Parameters

This method has no parameters.

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

<a name='P-Bb-Services-OptionClientFactory-Debug'></a>
### Debug `property`

##### Summary

Gets or sets a value indicating whether debug mode is enabled.

##### Remarks

When debug mode is enabled, additional logging is performed.

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

<a name='M-Bb-Services-OptionClientFactory-Trace-RestSharp-RestClientOptions-'></a>
### Trace(options) `method`

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
### AddOrReplace(name,value,isEncoded,nullValueHandling) `method`

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
| isEncoded | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | If true, assume value(s) already URL-encoded. |

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

<a name='T-Bb-Interceptors-RequestMessageInterceptor'></a>
## RequestMessageInterceptor `type`

##### Namespace

Bb.Interceptors

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
### GetTokenAsync(self,path,client_id,client_secret,username,password) `method`

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
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The username for authentication. Must not be null or empty. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password for authentication. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `self`, `path`, `client_id`, `username`, or `password` is null or empty. |
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

<a name='M-Bb-Services-RestClientFactory-#ctor-Bb-Interfaces-IOptionClientFactory-'></a>
### #ctor(optionFactory) `constructor`

##### Summary

Initializes a new instance of the [RestClientFactory](#T-Bb-Services-RestClientFactory 'Bb.Services.RestClientFactory') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| optionFactory | [Bb.Interfaces.IOptionClientFactory](#T-Bb-Interfaces-IOptionClientFactory 'Bb.Interfaces.IOptionClientFactory') | The [IOptionClientFactory](#T-Bb-Interfaces-IOptionClientFactory 'Bb.Interfaces.IOptionClientFactory') instance used to create client options. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.NullReferenceException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.NullReferenceException 'System.NullReferenceException') | Thrown if `optionFactory` is null. |

##### Remarks

This constructor initializes the factory with the specified option factory for creating [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions').

<a name='F-Bb-Services-RestClientFactory-_clients'></a>
### _clients `constants`

##### Summary

A thread-safe dictionary for storing and reusing [RestClient](#T-RestSharp-RestClient 'RestSharp.RestClient') instances.

<a name='F-Bb-Services-RestClientFactory-_optionFactory'></a>
### _optionFactory `constants`

##### Summary

The [IOptionClientFactory](#T-Bb-Interfaces-IOptionClientFactory 'Bb.Interfaces.IOptionClientFactory') instance used to create client options.

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

<a name='M-Bb-Helpers-RestOptionExtension-WithBasicHttp-RestSharp-RestClientOptions,System-String,System-String-'></a>
### WithBasicHttp(self,username,password) `method`

##### Summary

Configures the [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') to use basic HTTP authentication.

##### Returns

The configured [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [RestSharp.RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') | The [RestClientOptions](#T-RestSharp-RestClientOptions 'RestSharp.RestClientOptions') instance to configure. Must not be null. |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The username for authentication. Must not be null or empty. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The password for authentication. Must not be null or empty. |

##### Example

```C#
var options = new RestClientOptions();
options.WithBasicHttp("username", "password");
```

##### Remarks

This method sets up basic HTTP authentication for the REST client.

<a name='T-Bb-Helpers-RestRequestExtension'></a>
## RestRequestExtension `type`

##### Namespace

Bb.Helpers

##### Summary

Extension methods for the [RestRequest](#T-RestSharp-RestRequest 'RestSharp.RestRequest') class.

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

<a name='T-Bb-Urls-Url'></a>
## Url `type`

##### Namespace

Bb.Urls

<a name='P-Bb-Urls-Url-Root'></a>
### Root `property`

##### Summary

i.e. "https://www.site.com:8080" in "https://www.site.com:8080/path" (everything before the path).

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

The [](#!-Url2Extension 'Url2Extension') class contains helper methods for setting various components of a [Url](#T-Bb-Urls-Url 'Bb.Urls.Url') object, such as user information, host, port, and scheme. These methods enable a fluent API for constructing and modifying URLs.

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
### GetTokenAsync(self,path,client_id,client_secret,username,password) `method`

##### Summary

Retrieves an authentication token asynchronously using the specified credentials.

##### Returns

A [Task\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task`1 'System.Threading.Tasks.Task`1') representing the asynchronous operation, with a result of [TokenResponse](#T-Bb-Http-TokenResponse 'Bb.Http.TokenResponse') containing the token details.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Urls.Url](#T-Bb-Urls-Url 'Bb.Urls.Url') | The the url on the server. Must not be null. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The endpoint path for the token request. Must not be null or empty. |
| client_id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The client ID for authentication. Must not be null or empty. |
| client_secret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The client secret for authentication. Can be null or empty. |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The username for authentication. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if `self`, `path`, `client_id`, `username`, or `password` is null or empty. |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Thrown if the token request fails or the response is not successful. |

##### Example

```C#
var client = new RestClient("https://example.com");
var tokenResponse = await client.GetTokenAsync("/token", "myClientId", "myClientSecret", "myUsername", "myPassword");
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

<a name='M-Bb-Urls-UrlExtension-WithHttps-Bb-Urls-Url-'></a>
### WithHttps(self) `method`

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
var url = new Url("http://example.com").WithHttps();
Console.WriteLine(url.ToString()); // Output: https://example.com
```

##### Remarks

This method sets the scheme of the URL to "https".

<a name='M-Bb-Urls-UrlExtension-WithPathSegment-System-String,System-String-'></a>
### WithPathSegment(url,segment,fullyEncode) `method`

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
### WithPathSegment(uri,segment,fullyEncode) `method`

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
