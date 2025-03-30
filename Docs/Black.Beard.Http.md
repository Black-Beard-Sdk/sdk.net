<a name='assembly'></a>
# Black.Beard.Http

## Contents

- [CommonExtensions](#T-Bb-Util-CommonExtensions 'Bb.Util.CommonExtensions')
  - [IsIP()](#M-Bb-Util-CommonExtensions-IsIP-System-String- 'Bb.Util.CommonExtensions.IsIP(System.String)')
  - [Merge\`\`2()](#M-Bb-Util-CommonExtensions-Merge``2-System-Collections-Generic-IDictionary{``0,``1},System-Collections-Generic-IDictionary{``0,``1}- 'Bb.Util.CommonExtensions.Merge``2(System.Collections.Generic.IDictionary{``0,``1},System.Collections.Generic.IDictionary{``0,``1})')
  - [SplitOnFirstOccurence(s,separator)](#M-Bb-Util-CommonExtensions-SplitOnFirstOccurence-System-String,System-String- 'Bb.Util.CommonExtensions.SplitOnFirstOccurence(System.String,System.String)')
  - [StripQuotes()](#M-Bb-Util-CommonExtensions-StripQuotes-System-String- 'Bb.Util.CommonExtensions.StripQuotes(System.String)')
  - [ToInvariantString()](#M-Bb-Util-CommonExtensions-ToInvariantString-System-Object- 'Bb.Util.CommonExtensions.ToInvariantString(System.Object)')
  - [ToKeyValuePairs(obj)](#M-Bb-Util-CommonExtensions-ToKeyValuePairs-System-Object- 'Bb.Util.CommonExtensions.ToKeyValuePairs(System.Object)')
- [ContentType](#T-Bb-Http-ContentType 'Bb.Http.ContentType')
  - [#ctor(contentType)](#M-Bb-Http-ContentType-#ctor-System-String- 'Bb.Http.ContentType.#ctor(System.String)')
  - [ApplicationJson](#F-Bb-Http-ContentType-ApplicationJson 'Bb.Http.ContentType.ApplicationJson')
  - [ApplicationxWwwFormUrlencoded](#F-Bb-Http-ContentType-ApplicationxWwwFormUrlencoded 'Bb.Http.ContentType.ApplicationxWwwFormUrlencoded')
  - [ToString()](#M-Bb-Http-ContentType-ToString 'Bb.Http.ContentType.ToString')
- [CookieCutter](#T-Bb-Http-CookieCutter 'Bb.Http.CookieCutter')
  - [GetPairs()](#M-Bb-Http-CookieCutter-GetPairs-System-String- 'Bb.Http.CookieCutter.GetPairs(System.String)')
  - [IsExpired()](#M-Bb-Http-CookieCutter-IsExpired-Bb-Http-UrlCookie,System-String@- 'Bb.Http.CookieCutter.IsExpired(Bb.Http.UrlCookie,System.String@)')
  - [IsValid()](#M-Bb-Http-CookieCutter-IsValid-Bb-Http-UrlCookie,System-String@- 'Bb.Http.CookieCutter.IsValid(Bb.Http.UrlCookie,System.String@)')
  - [ParseRequestHeader(headerValue)](#M-Bb-Http-CookieCutter-ParseRequestHeader-System-String- 'Bb.Http.CookieCutter.ParseRequestHeader(System.String)')
  - [ParseResponseHeader(url,headerValue)](#M-Bb-Http-CookieCutter-ParseResponseHeader-System-String,System-String- 'Bb.Http.CookieCutter.ParseResponseHeader(System.String,System.String)')
  - [ShouldSendTo()](#M-Bb-Http-CookieCutter-ShouldSendTo-Bb-Http-UrlCookie,Bb-Url,System-String@- 'Bb.Http.CookieCutter.ShouldSendTo(Bb.Http.UrlCookie,Bb.Url,System.String@)')
  - [ToRequestHeader()](#M-Bb-Http-CookieCutter-ToRequestHeader-System-Collections-Generic-IEnumerable{System-ValueTuple{System-String,System-String}}- 'Bb.Http.CookieCutter.ToRequestHeader(System.Collections.Generic.IEnumerable{System.ValueTuple{System.String,System.String}})')
- [CookieExtensions](#T-Bb-Extensions-CookieExtensions 'Bb.Extensions.CookieExtensions')
  - [WithCookie(request,name,value)](#M-Bb-Extensions-CookieExtensions-WithCookie-Bb-Http-IUrlRequest,System-String,System-Object- 'Bb.Extensions.CookieExtensions.WithCookie(Bb.Http.IUrlRequest,System.String,System.Object)')
  - [WithCookies(request,values)](#M-Bb-Extensions-CookieExtensions-WithCookies-Bb-Http-IUrlRequest,System-Object- 'Bb.Extensions.CookieExtensions.WithCookies(Bb.Http.IUrlRequest,System.Object)')
  - [WithCookies(request,cookieJar)](#M-Bb-Extensions-CookieExtensions-WithCookies-Bb-Http-IUrlRequest,Bb-Http-CookieJar- 'Bb.Extensions.CookieExtensions.WithCookies(Bb.Http.IUrlRequest,Bb.Http.CookieJar)')
  - [WithCookies(request,cookieJar)](#M-Bb-Extensions-CookieExtensions-WithCookies-Bb-Http-IUrlRequest,Bb-Http-CookieJar@- 'Bb.Extensions.CookieExtensions.WithCookies(Bb.Http.IUrlRequest,Bb.Http.CookieJar@)')
- [CookieJar](#T-Bb-Http-CookieJar 'Bb.Http.CookieJar')
  - [Count](#P-Bb-Http-CookieJar-Count 'Bb.Http.CookieJar.Count')
  - [AddOrReplace(name,value,originUrl,dateReceived)](#M-Bb-Http-CookieJar-AddOrReplace-System-String,System-Object,System-String,System-Nullable{System-DateTimeOffset}- 'Bb.Http.CookieJar.AddOrReplace(System.String,System.Object,System.String,System.Nullable{System.DateTimeOffset})')
  - [AddOrReplace()](#M-Bb-Http-CookieJar-AddOrReplace-Bb-Http-UrlCookie- 'Bb.Http.CookieJar.AddOrReplace(Bb.Http.UrlCookie)')
  - [Clear()](#M-Bb-Http-CookieJar-Clear 'Bb.Http.CookieJar.Clear')
  - [GetEnumerator()](#M-Bb-Http-CookieJar-GetEnumerator 'Bb.Http.CookieJar.GetEnumerator')
  - [Remove()](#M-Bb-Http-CookieJar-Remove-System-Func{Bb-Http-UrlCookie,System-Boolean}- 'Bb.Http.CookieJar.Remove(System.Func{Bb.Http.UrlCookie,System.Boolean})')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-Bb-Http-CookieJar-System#Collections#IEnumerable#GetEnumerator 'Bb.Http.CookieJar.System#Collections#IEnumerable#GetEnumerator')
  - [TryAddOrReplace()](#M-Bb-Http-CookieJar-TryAddOrReplace-Bb-Http-UrlCookie,System-String@- 'Bb.Http.CookieJar.TryAddOrReplace(Bb.Http.UrlCookie,System.String@)')
- [CookieSession](#T-Bb-Http-CookieSession 'Bb.Http.CookieSession')
  - [#ctor()](#M-Bb-Http-CookieSession-#ctor-System-String- 'Bb.Http.CookieSession.#ctor(System.String)')
  - [#ctor()](#M-Bb-Http-CookieSession-#ctor-Bb-Http-IUrlClient- 'Bb.Http.CookieSession.#ctor(Bb.Http.IUrlClient)')
  - [Cookies](#P-Bb-Http-CookieSession-Cookies 'Bb.Http.CookieSession.Cookies')
  - [Dispose()](#M-Bb-Http-CookieSession-Dispose 'Bb.Http.CookieSession.Dispose')
  - [Request(urlSegments)](#M-Bb-Http-CookieSession-Request-System-Object[]- 'Bb.Http.CookieSession.Request(System.Object[])')
- [CurlContext](#T-Bb-Curls-CurlContext 'Bb.Curls.CurlContext')
  - [#ctor(cancellationTokenSource)](#M-Bb-Curls-CurlContext-#ctor-System-Threading-CancellationTokenSource- 'Bb.Curls.CurlContext.#ctor(System.Threading.CancellationTokenSource)')
  - [CallAsync()](#M-Bb-Curls-CurlContext-CallAsync-Bb-Http-Configuration-IUrlClientFactory- 'Bb.Curls.CurlContext.CallAsync(Bb.Http.Configuration.IUrlClientFactory)')
- [CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter')
  - [#ctor(arguments)](#M-Bb-Curls-CurlInterpreter-#ctor-System-String[]- 'Bb.Curls.CurlInterpreter.#ctor(System.String[])')
  - [CallAsync(source,ensureSuccessStatusCode)](#M-Bb-Curls-CurlInterpreter-CallAsync-System-Boolean,System-Threading-CancellationTokenSource- 'Bb.Curls.CurlInterpreter.CallAsync(System.Boolean,System.Threading.CancellationTokenSource)')
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
  - [CallToByteArray(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-CallToByteArray-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.CallToByteArray(System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage},System.Boolean,System.Threading.CancellationToken)')
  - [CallToByteArrayAsync(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-CallToByteArrayAsync-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.CallToByteArrayAsync(Bb.Curls.CurlInterpreter,System.Boolean,System.Threading.CancellationToken)')
  - [CallToObjectAsync(self,type,ensureSuccessStatusCode,options,cancellationToken)](#M-Bb-Curls-CurlParserExtension-CallToObjectAsync-Bb-Curls-CurlInterpreter,System-Type,System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.CallToObjectAsync(Bb.Curls.CurlInterpreter,System.Type,System.Boolean,System.Text.Json.JsonSerializerOptions,System.Threading.CancellationToken)')
  - [CallToObjectAsync\`\`1(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-CallToObjectAsync``1-Bb-Curls-CurlInterpreter,System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.CallToObjectAsync``1(Bb.Curls.CurlInterpreter,System.Boolean,System.Text.Json.JsonSerializerOptions,System.Threading.CancellationToken)')
  - [CallToStream(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-CallToStream-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.CallToStream(System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage},System.Boolean,System.Threading.CancellationToken)')
  - [CallToStreamAsync(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-CallToStreamAsync-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.CallToStreamAsync(Bb.Curls.CurlInterpreter,System.Boolean,System.Threading.CancellationToken)')
  - [CallToStringAsync(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-CallToStringAsync-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.CallToStringAsync(Bb.Curls.CurlInterpreter,System.Boolean,System.Threading.CancellationToken)')
  - [IsUrl(self)](#M-Bb-Curls-CurlParserExtension-IsUrl-System-String- 'Bb.Curls.CurlParserExtension.IsUrl(System.String)')
  - [ParseCurlLine(lineArg)](#M-Bb-Curls-CurlParserExtension-ParseCurlLine-System-String- 'Bb.Curls.CurlParserExtension.ParseCurlLine(System.String)')
  - [Precompile(lineArg)](#M-Bb-Curls-CurlParserExtension-Precompile-System-String- 'Bb.Curls.CurlParserExtension.Precompile(System.String)')
  - [ResultToByteArrayAsync(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToByteArrayAsync-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToByteArrayAsync(System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage},System.Boolean,System.Threading.CancellationToken)')
  - [ResultToJson(self,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToJson-Bb-Curls-CurlInterpreter,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToJson(Bb.Curls.CurlInterpreter,System.Threading.CancellationToken)')
  - [ResultToJson(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToJson-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToJson(Bb.Curls.CurlInterpreter,System.Boolean,System.Threading.CancellationToken)')
  - [ResultToJson(self,ensureSuccessStatusCode,cancellationToken,options)](#M-Bb-Curls-CurlParserExtension-ResultToJson-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken,System-Text-Json-JsonDocumentOptions- 'Bb.Curls.CurlParserExtension.ResultToJson(Bb.Curls.CurlInterpreter,System.Boolean,System.Threading.CancellationToken,System.Text.Json.JsonDocumentOptions)')
  - [ResultToJson(self,type,ensureSuccessStatusCode,options,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToJson-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Type,System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToJson(System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage},System.Type,System.Boolean,System.Text.Json.JsonSerializerOptions,System.Threading.CancellationToken)')
  - [ResultToJsonAsync(self,type,ensureSuccessStatusCode,options,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToJsonAsync-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Type,System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToJsonAsync(System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage},System.Type,System.Boolean,System.Text.Json.JsonSerializerOptions,System.Threading.CancellationToken)')
  - [ResultToJsonAsync\`\`1(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToJsonAsync``1-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToJsonAsync``1(System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage},System.Boolean,System.Text.Json.JsonSerializerOptions,System.Threading.CancellationToken)')
  - [ResultToJson\`\`1(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToJson``1-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToJson``1(System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage},System.Boolean,System.Text.Json.JsonSerializerOptions,System.Threading.CancellationToken)')
  - [ResultToObject\`\`1(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToObject``1-Bb-Curls-CurlInterpreter,System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToObject``1(Bb.Curls.CurlInterpreter,System.Boolean,System.Text.Json.JsonSerializerOptions,System.Threading.CancellationToken)')
  - [ResultToStream(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToStream-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToStream(Bb.Curls.CurlInterpreter,System.Boolean,System.Threading.CancellationToken)')
  - [ResultToStreamAsync(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToStreamAsync-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToStreamAsync(System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage},System.Boolean,System.Threading.CancellationToken)')
  - [ResultToString(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToString-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToString(Bb.Curls.CurlInterpreter,System.Boolean,System.Threading.CancellationToken)')
  - [ResultToString(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToString-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToString(System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage},System.Boolean,System.Threading.CancellationToken)')
  - [ResultToStringAsync(self,ensureSuccessStatusCode,cancellationToken)](#M-Bb-Curls-CurlParserExtension-ResultToStringAsync-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken- 'Bb.Curls.CurlParserExtension.ResultToStringAsync(System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage},System.Boolean,System.Threading.CancellationToken)')
- [DefaultJsonSerializer](#T-Bb-Http-Configuration-DefaultJsonSerializer 'Bb.Http.Configuration.DefaultJsonSerializer')
  - [#ctor(options)](#M-Bb-Http-Configuration-DefaultJsonSerializer-#ctor-System-Text-Json-JsonSerializerOptions- 'Bb.Http.Configuration.DefaultJsonSerializer.#ctor(System.Text.Json.JsonSerializerOptions)')
  - [Deserializes\`\`1(s)](#M-Bb-Http-Configuration-DefaultJsonSerializer-Deserializes``1-System-String- 'Bb.Http.Configuration.DefaultJsonSerializer.Deserializes``1(System.String)')
  - [Deserializes\`\`1(stream)](#M-Bb-Http-Configuration-DefaultJsonSerializer-Deserializes``1-System-IO-Stream- 'Bb.Http.Configuration.DefaultJsonSerializer.Deserializes``1(System.IO.Stream)')
  - [Serialize(obj)](#M-Bb-Http-Configuration-DefaultJsonSerializer-Serialize-System-Object- 'Bb.Http.Configuration.DefaultJsonSerializer.Serialize(System.Object)')
- [DefaultUrlClientFactory](#T-Bb-Http-Configuration-DefaultUrlClientFactory 'Bb.Http.Configuration.DefaultUrlClientFactory')
  - [GetCacheKey(url)](#M-Bb-Http-Configuration-DefaultUrlClientFactory-GetCacheKey-Bb-Url- 'Bb.Http.Configuration.DefaultUrlClientFactory.GetCacheKey(Bb.Url)')
- [DefaultUrlEncodedSerializer](#T-Bb-Http-Configuration-DefaultUrlEncodedSerializer 'Bb.Http.Configuration.DefaultUrlEncodedSerializer')
  - [Deserializes\`\`1()](#M-Bb-Http-Configuration-DefaultUrlEncodedSerializer-Deserializes``1-System-String- 'Bb.Http.Configuration.DefaultUrlEncodedSerializer.Deserializes``1(System.String)')
  - [Deserializes\`\`1()](#M-Bb-Http-Configuration-DefaultUrlEncodedSerializer-Deserializes``1-System-IO-Stream- 'Bb.Http.Configuration.DefaultUrlEncodedSerializer.Deserializes``1(System.IO.Stream)')
  - [Serialize()](#M-Bb-Http-Configuration-DefaultUrlEncodedSerializer-Serialize-System-Object- 'Bb.Http.Configuration.DefaultUrlEncodedSerializer.Serialize(System.Object)')
- [DownloadExtensions](#T-Bb-Extensions-DownloadExtensions 'Bb.Extensions.DownloadExtensions')
  - [DownloadFileAsync(request,localFolderPath,localFileName,bufferSize,completionOption,cancellationToken)](#M-Bb-Extensions-DownloadExtensions-DownloadFileAsync-Bb-Http-IUrlRequest,System-String,System-String,System-Int32,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.DownloadExtensions.DownloadFileAsync(Bb.Http.IUrlRequest,System.String,System.String,System.Int32,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
- [FileUtil](#T-Bb-Http-FileUtil 'Bb.Http.FileUtil')
  - [MakeValidName()](#M-Bb-Http-FileUtil-MakeValidName-System-String- 'Bb.Http.FileUtil.MakeValidName(System.String)')
- [FilteredHttpTestSetup](#T-Bb-Http-Testing-FilteredHttpTestSetup 'Bb.Http.Testing.FilteredHttpTestSetup')
  - [#ctor(settings,urlPatterns)](#M-Bb-Http-Testing-FilteredHttpTestSetup-#ctor-Bb-Http-Configuration-UrlHttpSettings,System-String[]- 'Bb.Http.Testing.FilteredHttpTestSetup.#ctor(Bb.Http.Configuration.UrlHttpSettings,System.String[])')
  - [IsMatch()](#M-Bb-Http-Testing-FilteredHttpTestSetup-IsMatch-Bb-Http-UrlCall- 'Bb.Http.Testing.FilteredHttpTestSetup.IsMatch(Bb.Http.UrlCall)')
  - [With()](#M-Bb-Http-Testing-FilteredHttpTestSetup-With-System-Func{Bb-Http-UrlCall,System-Boolean}- 'Bb.Http.Testing.FilteredHttpTestSetup.With(System.Func{Bb.Http.UrlCall,System.Boolean})')
  - [WithAnyQueryParam()](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithAnyQueryParam-System-String[]- 'Bb.Http.Testing.FilteredHttpTestSetup.WithAnyQueryParam(System.String[])')
  - [WithHeader()](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithHeader-System-String,System-String- 'Bb.Http.Testing.FilteredHttpTestSetup.WithHeader(System.String,System.String)')
  - [WithQueryParam()](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithQueryParam-System-String,System-Object- 'Bb.Http.Testing.FilteredHttpTestSetup.WithQueryParam(System.String,System.Object)')
  - [WithQueryParam()](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithQueryParam-System-String[]- 'Bb.Http.Testing.FilteredHttpTestSetup.WithQueryParam(System.String[])')
  - [WithQueryParam(values)](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithQueryParam-System-Object- 'Bb.Http.Testing.FilteredHttpTestSetup.WithQueryParam(System.Object)')
  - [WithRequestBody()](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithRequestBody-System-String- 'Bb.Http.Testing.FilteredHttpTestSetup.WithRequestBody(System.String)')
  - [WithRequestJson()](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithRequestJson-System-Object- 'Bb.Http.Testing.FilteredHttpTestSetup.WithRequestJson(System.Object)')
  - [WithVerb()](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithVerb-System-Net-Http-HttpMethod[]- 'Bb.Http.Testing.FilteredHttpTestSetup.WithVerb(System.Net.Http.HttpMethod[])')
  - [WithVerb()](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithVerb-System-String[]- 'Bb.Http.Testing.FilteredHttpTestSetup.WithVerb(System.String[])')
  - [Without()](#M-Bb-Http-Testing-FilteredHttpTestSetup-Without-System-Func{Bb-Http-UrlCall,System-Boolean}- 'Bb.Http.Testing.FilteredHttpTestSetup.Without(System.Func{Bb.Http.UrlCall,System.Boolean})')
  - [WithoutHeader()](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithoutHeader-System-String,System-String- 'Bb.Http.Testing.FilteredHttpTestSetup.WithoutHeader(System.String,System.String)')
  - [WithoutQueryParam()](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithoutQueryParam-System-String,System-Object- 'Bb.Http.Testing.FilteredHttpTestSetup.WithoutQueryParam(System.String,System.Object)')
  - [WithoutQueryParam()](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithoutQueryParam-System-String[]- 'Bb.Http.Testing.FilteredHttpTestSetup.WithoutQueryParam(System.String[])')
  - [WithoutQueryParam(values)](#M-Bb-Http-Testing-FilteredHttpTestSetup-WithoutQueryParam-System-Object- 'Bb.Http.Testing.FilteredHttpTestSetup.WithoutQueryParam(System.Object)')
- [GlobalUrlHttpSettings](#T-Bb-Http-Configuration-GlobalUrlHttpSettings 'Bb.Http.Configuration.GlobalUrlHttpSettings')
  - [Defaults](#P-Bb-Http-Configuration-GlobalUrlHttpSettings-Defaults 'Bb.Http.Configuration.GlobalUrlHttpSettings.Defaults')
  - [UrlClientFactory](#P-Bb-Http-Configuration-GlobalUrlHttpSettings-UrlClientFactory 'Bb.Http.Configuration.GlobalUrlHttpSettings.UrlClientFactory')
  - [ResetDefaults()](#M-Bb-Http-Configuration-GlobalUrlHttpSettings-ResetDefaults 'Bb.Http.Configuration.GlobalUrlHttpSettings.ResetDefaults')
- [HeaderExtensions](#T-Bb-Extensions-HeaderExtensions 'Bb.Extensions.HeaderExtensions')
  - [WithBasicAuth\`\`1(clientOrRequest,userName,password)](#M-Bb-Extensions-HeaderExtensions-WithBasicAuth``1-``0,System-String,System-String- 'Bb.Extensions.HeaderExtensions.WithBasicAuth``1(``0,System.String,System.String)')
  - [WithHeader\`\`1(clientOrRequest,name,value)](#M-Bb-Extensions-HeaderExtensions-WithHeader``1-``0,System-String,System-Object- 'Bb.Extensions.HeaderExtensions.WithHeader``1(``0,System.String,System.Object)')
  - [WithHeader\`\`1(clientOrRequest,name,value)](#M-Bb-Extensions-HeaderExtensions-WithHeader``1-``0,System-String,Bb-Http-ContentType- 'Bb.Extensions.HeaderExtensions.WithHeader``1(``0,System.String,Bb.Http.ContentType)')
  - [WithHeaders\`\`1(clientOrRequest,headers,replaceUnderscoreWithHyphen)](#M-Bb-Extensions-HeaderExtensions-WithHeaders``1-``0,System-Object,System-Boolean- 'Bb.Extensions.HeaderExtensions.WithHeaders``1(``0,System.Object,System.Boolean)')
  - [WithOAuthBearerToken\`\`1(clientOrRequest,token)](#M-Bb-Extensions-HeaderExtensions-WithOAuthBearerToken``1-``0,System-String- 'Bb.Extensions.HeaderExtensions.WithOAuthBearerToken``1(``0,System.String)')
- [HttpCallAssertion](#T-Bb-Http-Testing-HttpCallAssertion 'Bb.Http.Testing.HttpCallAssertion')
  - [#ctor(loggedCalls,negate)](#M-Bb-Http-Testing-HttpCallAssertion-#ctor-System-Collections-Generic-IEnumerable{Bb-Http-UrlCall},System-Boolean- 'Bb.Http.Testing.HttpCallAssertion.#ctor(System.Collections.Generic.IEnumerable{Bb.Http.UrlCall},System.Boolean)')
  - [Times(expectedCount)](#M-Bb-Http-Testing-HttpCallAssertion-Times-System-Int32- 'Bb.Http.Testing.HttpCallAssertion.Times(System.Int32)')
  - [With(match,descrip)](#M-Bb-Http-Testing-HttpCallAssertion-With-System-Func{Bb-Http-UrlCall,System-Boolean},System-String- 'Bb.Http.Testing.HttpCallAssertion.With(System.Func{Bb.Http.UrlCall,System.Boolean},System.String)')
  - [WithAnyCookie()](#M-Bb-Http-Testing-HttpCallAssertion-WithAnyCookie-System-String[]- 'Bb.Http.Testing.HttpCallAssertion.WithAnyCookie(System.String[])')
  - [WithAnyHeader()](#M-Bb-Http-Testing-HttpCallAssertion-WithAnyHeader-System-String[]- 'Bb.Http.Testing.HttpCallAssertion.WithAnyHeader(System.String[])')
  - [WithAnyQueryParam()](#M-Bb-Http-Testing-HttpCallAssertion-WithAnyQueryParam-System-String[]- 'Bb.Http.Testing.HttpCallAssertion.WithAnyQueryParam(System.String[])')
  - [WithBasicAuth()](#M-Bb-Http-Testing-HttpCallAssertion-WithBasicAuth-System-String,System-String- 'Bb.Http.Testing.HttpCallAssertion.WithBasicAuth(System.String,System.String)')
  - [WithContentType()](#M-Bb-Http-Testing-HttpCallAssertion-WithContentType-System-String- 'Bb.Http.Testing.HttpCallAssertion.WithContentType(System.String)')
  - [WithCookie()](#M-Bb-Http-Testing-HttpCallAssertion-WithCookie-System-String,System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithCookie(System.String,System.Object)')
  - [WithCookies()](#M-Bb-Http-Testing-HttpCallAssertion-WithCookies-System-String[]- 'Bb.Http.Testing.HttpCallAssertion.WithCookies(System.String[])')
  - [WithCookies(values)](#M-Bb-Http-Testing-HttpCallAssertion-WithCookies-System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithCookies(System.Object)')
  - [WithHeader()](#M-Bb-Http-Testing-HttpCallAssertion-WithHeader-System-String,System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithHeader(System.String,System.Object)')
  - [WithHeaders()](#M-Bb-Http-Testing-HttpCallAssertion-WithHeaders-System-String[]- 'Bb.Http.Testing.HttpCallAssertion.WithHeaders(System.String[])')
  - [WithHeaders(values)](#M-Bb-Http-Testing-HttpCallAssertion-WithHeaders-System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithHeaders(System.Object)')
  - [WithOAuthBearerToken()](#M-Bb-Http-Testing-HttpCallAssertion-WithOAuthBearerToken-System-String- 'Bb.Http.Testing.HttpCallAssertion.WithOAuthBearerToken(System.String)')
  - [WithQueryParam()](#M-Bb-Http-Testing-HttpCallAssertion-WithQueryParam-System-String,System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithQueryParam(System.String,System.Object)')
  - [WithQueryParam()](#M-Bb-Http-Testing-HttpCallAssertion-WithQueryParam-System-String[]- 'Bb.Http.Testing.HttpCallAssertion.WithQueryParam(System.String[])')
  - [WithQueryParam(values)](#M-Bb-Http-Testing-HttpCallAssertion-WithQueryParam-System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithQueryParam(System.Object)')
  - [WithRequestBody()](#M-Bb-Http-Testing-HttpCallAssertion-WithRequestBody-System-String- 'Bb.Http.Testing.HttpCallAssertion.WithRequestBody(System.String)')
  - [WithRequestJson()](#M-Bb-Http-Testing-HttpCallAssertion-WithRequestJson-System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithRequestJson(System.Object)')
  - [WithRequestUrlEncoded()](#M-Bb-Http-Testing-HttpCallAssertion-WithRequestUrlEncoded-System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithRequestUrlEncoded(System.Object)')
  - [WithUrlPattern(urlPattern)](#M-Bb-Http-Testing-HttpCallAssertion-WithUrlPattern-System-String- 'Bb.Http.Testing.HttpCallAssertion.WithUrlPattern(System.String)')
  - [WithVerb()](#M-Bb-Http-Testing-HttpCallAssertion-WithVerb-System-Net-Http-HttpMethod[]- 'Bb.Http.Testing.HttpCallAssertion.WithVerb(System.Net.Http.HttpMethod[])')
  - [WithVerb()](#M-Bb-Http-Testing-HttpCallAssertion-WithVerb-System-String[]- 'Bb.Http.Testing.HttpCallAssertion.WithVerb(System.String[])')
  - [Without(match,descrip)](#M-Bb-Http-Testing-HttpCallAssertion-Without-System-Func{Bb-Http-UrlCall,System-Boolean},System-String- 'Bb.Http.Testing.HttpCallAssertion.Without(System.Func{Bb.Http.UrlCall,System.Boolean},System.String)')
  - [WithoutCookie()](#M-Bb-Http-Testing-HttpCallAssertion-WithoutCookie-System-String,System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithoutCookie(System.String,System.Object)')
  - [WithoutCookies()](#M-Bb-Http-Testing-HttpCallAssertion-WithoutCookies-System-String[]- 'Bb.Http.Testing.HttpCallAssertion.WithoutCookies(System.String[])')
  - [WithoutCookies(values)](#M-Bb-Http-Testing-HttpCallAssertion-WithoutCookies-System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithoutCookies(System.Object)')
  - [WithoutHeader()](#M-Bb-Http-Testing-HttpCallAssertion-WithoutHeader-System-String,System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithoutHeader(System.String,System.Object)')
  - [WithoutHeaders()](#M-Bb-Http-Testing-HttpCallAssertion-WithoutHeaders-System-String[]- 'Bb.Http.Testing.HttpCallAssertion.WithoutHeaders(System.String[])')
  - [WithoutHeaders(values)](#M-Bb-Http-Testing-HttpCallAssertion-WithoutHeaders-System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithoutHeaders(System.Object)')
  - [WithoutQueryParam()](#M-Bb-Http-Testing-HttpCallAssertion-WithoutQueryParam-System-String,System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithoutQueryParam(System.String,System.Object)')
  - [WithoutQueryParam()](#M-Bb-Http-Testing-HttpCallAssertion-WithoutQueryParam-System-String[]- 'Bb.Http.Testing.HttpCallAssertion.WithoutQueryParam(System.String[])')
  - [WithoutQueryParam(values)](#M-Bb-Http-Testing-HttpCallAssertion-WithoutQueryParam-System-Object- 'Bb.Http.Testing.HttpCallAssertion.WithoutQueryParam(System.Object)')
- [HttpMessage](#T-Bb-Extensions-HttpMessageExtensions-HttpMessage 'Bb.Extensions.HttpMessageExtensions.HttpMessage')
- [HttpMessageExtensions](#T-Bb-Extensions-HttpMessageExtensions 'Bb.Extensions.HttpMessageExtensions')
  - [SetHeader(request,name,value,createContentIfNecessary)](#M-Bb-Extensions-HttpMessageExtensions-SetHeader-System-Net-Http-HttpRequestMessage,System-String,System-Object,System-Boolean- 'Bb.Extensions.HttpMessageExtensions.SetHeader(System.Net.Http.HttpRequestMessage,System.String,System.Object,System.Boolean)')
  - [SetHeader(response,name,value,createContentIfNecessary)](#M-Bb-Extensions-HttpMessageExtensions-SetHeader-System-Net-Http-HttpResponseMessage,System-String,System-Object,System-Boolean- 'Bb.Extensions.HttpMessageExtensions.SetHeader(System.Net.Http.HttpResponseMessage,System.String,System.Object,System.Boolean)')
- [HttpStatusRangeParser](#T-Bb-Http-HttpStatusRangeParser 'Bb.Http.HttpStatusRangeParser')
  - [IsMatch(pattern,value)](#M-Bb-Http-HttpStatusRangeParser-IsMatch-System-String,System-Net-HttpStatusCode- 'Bb.Http.HttpStatusRangeParser.IsMatch(System.String,System.Net.HttpStatusCode)')
  - [IsMatch(pattern,value)](#M-Bb-Http-HttpStatusRangeParser-IsMatch-System-String,System-Int32- 'Bb.Http.HttpStatusRangeParser.IsMatch(System.String,System.Int32)')
- [HttpTest](#T-Bb-Http-Testing-HttpTest 'Bb.Http.Testing.HttpTest')
  - [#ctor()](#M-Bb-Http-Testing-HttpTest-#ctor 'Bb.Http.Testing.HttpTest.#ctor')
  - [CallLog](#P-Bb-Http-Testing-HttpTest-CallLog 'Bb.Http.Testing.HttpTest.CallLog')
  - [Current](#P-Bb-Http-Testing-HttpTest-Current 'Bb.Http.Testing.HttpTest.Current')
  - [Configure(action)](#M-Bb-Http-Testing-HttpTest-Configure-System-Action{Bb-Http-Configuration-UrlHttpSettings}- 'Bb.Http.Testing.HttpTest.Configure(System.Action{Bb.Http.Configuration.UrlHttpSettings})')
  - [Dispose()](#M-Bb-Http-Testing-HttpTest-Dispose 'Bb.Http.Testing.HttpTest.Dispose')
  - [ForCallsTo()](#M-Bb-Http-Testing-HttpTest-ForCallsTo-System-String[]- 'Bb.Http.Testing.HttpTest.ForCallsTo(System.String[])')
  - [ShouldHaveCalled(urlPattern)](#M-Bb-Http-Testing-HttpTest-ShouldHaveCalled-System-String- 'Bb.Http.Testing.HttpTest.ShouldHaveCalled(System.String)')
  - [ShouldHaveMadeACall()](#M-Bb-Http-Testing-HttpTest-ShouldHaveMadeACall 'Bb.Http.Testing.HttpTest.ShouldHaveMadeACall')
  - [ShouldNotHaveCalled(urlPattern)](#M-Bb-Http-Testing-HttpTest-ShouldNotHaveCalled-System-String- 'Bb.Http.Testing.HttpTest.ShouldNotHaveCalled(System.String)')
  - [ShouldNotHaveMadeACall()](#M-Bb-Http-Testing-HttpTest-ShouldNotHaveMadeACall 'Bb.Http.Testing.HttpTest.ShouldNotHaveMadeACall')
- [HttpTestException](#T-Bb-Http-Testing-HttpTestException 'Bb.Http.Testing.HttpTestException')
  - [#ctor(conditions,expectedCalls,actualCalls)](#M-Bb-Http-Testing-HttpTestException-#ctor-System-Collections-Generic-IList{System-String},System-Nullable{System-Int32},System-Int32- 'Bb.Http.Testing.HttpTestException.#ctor(System.Collections.Generic.IList{System.String},System.Nullable{System.Int32},System.Int32)')
- [HttpTestSetup](#T-Bb-Http-Testing-HttpTestSetup 'Bb.Http.Testing.HttpTestSetup')
  - [#ctor(settings)](#M-Bb-Http-Testing-HttpTestSetup-#ctor-Bb-Http-Configuration-UrlHttpSettings- 'Bb.Http.Testing.HttpTestSetup.#ctor(Bb.Http.Configuration.UrlHttpSettings)')
  - [Settings](#P-Bb-Http-Testing-HttpTestSetup-Settings 'Bb.Http.Testing.HttpTestSetup.Settings')
  - [AllowRealHttp()](#M-Bb-Http-Testing-HttpTestSetup-AllowRealHttp 'Bb.Http.Testing.HttpTestSetup.AllowRealHttp')
  - [RespondWith(body,status,headers,cookies,replaceUnderscoreWithHyphen)](#M-Bb-Http-Testing-HttpTestSetup-RespondWith-System-String,System-Int32,System-Object,System-Object,System-Boolean- 'Bb.Http.Testing.HttpTestSetup.RespondWith(System.String,System.Int32,System.Object,System.Object,System.Boolean)')
  - [RespondWith(buildContent,status,headers,cookies,replaceUnderscoreWithHyphen)](#M-Bb-Http-Testing-HttpTestSetup-RespondWith-System-Func{System-Net-Http-HttpContent},System-Int32,System-Object,System-Object,System-Boolean- 'Bb.Http.Testing.HttpTestSetup.RespondWith(System.Func{System.Net.Http.HttpContent},System.Int32,System.Object,System.Object,System.Boolean)')
  - [RespondWithJson(body,status,headers,cookies,replaceUnderscoreWithHyphen)](#M-Bb-Http-Testing-HttpTestSetup-RespondWithJson-System-Object,System-Int32,System-Object,System-Object,System-Boolean- 'Bb.Http.Testing.HttpTestSetup.RespondWithJson(System.Object,System.Int32,System.Object,System.Object,System.Boolean)')
  - [SimulateException(exception)](#M-Bb-Http-Testing-HttpTestSetup-SimulateException-System-Exception- 'Bb.Http.Testing.HttpTestSetup.SimulateException(System.Exception)')
  - [SimulateTimeout()](#M-Bb-Http-Testing-HttpTestSetup-SimulateTimeout 'Bb.Http.Testing.HttpTestSetup.SimulateTimeout')
- [IHttpSettingsContainer](#T-Bb-Http-IHttpSettingsContainer 'Bb.Http.IHttpSettingsContainer')
  - [Headers](#P-Bb-Http-IHttpSettingsContainer-Headers 'Bb.Http.IHttpSettingsContainer.Headers')
  - [Settings](#P-Bb-Http-IHttpSettingsContainer-Settings 'Bb.Http.IHttpSettingsContainer.Settings')
- [INameValueListBase\`1](#T-Bb-Util-INameValueListBase`1 'Bb.Util.INameValueListBase`1')
  - [Contains()](#M-Bb-Util-INameValueListBase`1-Contains-System-String- 'Bb.Util.INameValueListBase`1.Contains(System.String)')
  - [Contains()](#M-Bb-Util-INameValueListBase`1-Contains-System-String,`0- 'Bb.Util.INameValueListBase`1.Contains(System.String,`0)')
  - [FirstOrDefault()](#M-Bb-Util-INameValueListBase`1-FirstOrDefault-System-String- 'Bb.Util.INameValueListBase`1.FirstOrDefault(System.String)')
  - [GetAll()](#M-Bb-Util-INameValueListBase`1-GetAll-System-String- 'Bb.Util.INameValueListBase`1.GetAll(System.String)')
  - [TryGetFirst()](#M-Bb-Util-INameValueListBase`1-TryGetFirst-System-String,`0@- 'Bb.Util.INameValueListBase`1.TryGetFirst(System.String,`0@)')
- [INameValueList\`1](#T-Bb-Util-INameValueList`1 'Bb.Util.INameValueList`1')
  - [Add()](#M-Bb-Util-INameValueList`1-Add-System-String,`0- 'Bb.Util.INameValueList`1.Add(System.String,`0)')
  - [AddOrReplace()](#M-Bb-Util-INameValueList`1-AddOrReplace-System-String,`0- 'Bb.Util.INameValueList`1.AddOrReplace(System.String,`0)')
  - [Remove()](#M-Bb-Util-INameValueList`1-Remove-System-String- 'Bb.Util.INameValueList`1.Remove(System.String)')
- [IReadOnlyNameValueList\`1](#T-Bb-Util-IReadOnlyNameValueList`1 'Bb.Util.IReadOnlyNameValueList`1')
- [ISerializer](#T-Bb-Http-Configuration-ISerializer 'Bb.Http.Configuration.ISerializer')
  - [Deserializes\`\`1()](#M-Bb-Http-Configuration-ISerializer-Deserializes``1-System-String- 'Bb.Http.Configuration.ISerializer.Deserializes``1(System.String)')
  - [Deserializes\`\`1()](#M-Bb-Http-Configuration-ISerializer-Deserializes``1-System-IO-Stream- 'Bb.Http.Configuration.ISerializer.Deserializes``1(System.IO.Stream)')
  - [Serialize()](#M-Bb-Http-Configuration-ISerializer-Serialize-System-Object- 'Bb.Http.Configuration.ISerializer.Serialize(System.Object)')
- [IUrlClient](#T-Bb-Http-IUrlClient 'Bb.Http.IUrlClient')
  - [BaseUrl](#P-Bb-Http-IUrlClient-BaseUrl 'Bb.Http.IUrlClient.BaseUrl')
  - [HttpClient](#P-Bb-Http-IUrlClient-HttpClient 'Bb.Http.IUrlClient.HttpClient')
  - [IsDisposed](#P-Bb-Http-IUrlClient-IsDisposed 'Bb.Http.IUrlClient.IsDisposed')
  - [Request(urlSegments)](#M-Bb-Http-IUrlClient-Request-System-Object[]- 'Bb.Http.IUrlClient.Request(System.Object[])')
  - [SendAsync(request,cancellationToken,completionOption)](#M-Bb-Http-IUrlClient-SendAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Http.IUrlClient.SendAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
- [IUrlClientFactory](#T-Bb-Http-Configuration-IUrlClientFactory 'Bb.Http.Configuration.IUrlClientFactory')
  - [CreateHttpClient(handler)](#M-Bb-Http-Configuration-IUrlClientFactory-CreateHttpClient-System-Net-Http-HttpMessageHandler- 'Bb.Http.Configuration.IUrlClientFactory.CreateHttpClient(System.Net.Http.HttpMessageHandler)')
  - [CreateMessageHandler()](#M-Bb-Http-Configuration-IUrlClientFactory-CreateMessageHandler 'Bb.Http.Configuration.IUrlClientFactory.CreateMessageHandler')
  - [Get(url)](#M-Bb-Http-Configuration-IUrlClientFactory-Get-Bb-Url- 'Bb.Http.Configuration.IUrlClientFactory.Get(Bb.Url)')
- [IUrlExtensions](#T-Bb-Extensions-IUrlExtensions 'Bb.Extensions.IUrlExtensions')
  - [AllowAnyHttpStatus(url)](#M-Bb-Extensions-IUrlExtensions-AllowAnyHttpStatus-Bb-Url- 'Bb.Extensions.IUrlExtensions.AllowAnyHttpStatus(Bb.Url)')
  - [AllowAnyHttpStatus(url)](#M-Bb-Extensions-IUrlExtensions-AllowAnyHttpStatus-System-String- 'Bb.Extensions.IUrlExtensions.AllowAnyHttpStatus(System.String)')
  - [AllowHttpStatus(url,pattern)](#M-Bb-Extensions-IUrlExtensions-AllowHttpStatus-Bb-Url,System-String- 'Bb.Extensions.IUrlExtensions.AllowHttpStatus(Bb.Url,System.String)')
  - [AllowHttpStatus(url,statusCodes)](#M-Bb-Extensions-IUrlExtensions-AllowHttpStatus-Bb-Url,System-Net-HttpStatusCode[]- 'Bb.Extensions.IUrlExtensions.AllowHttpStatus(Bb.Url,System.Net.HttpStatusCode[])')
  - [AllowHttpStatus(url,pattern)](#M-Bb-Extensions-IUrlExtensions-AllowHttpStatus-System-String,System-String- 'Bb.Extensions.IUrlExtensions.AllowHttpStatus(System.String,System.String)')
  - [AllowHttpStatus(url,statusCodes)](#M-Bb-Extensions-IUrlExtensions-AllowHttpStatus-System-String,System-Net-HttpStatusCode[]- 'Bb.Extensions.IUrlExtensions.AllowHttpStatus(System.String,System.Net.HttpStatusCode[])')
  - [ConfigureRequest(url,action)](#M-Bb-Extensions-IUrlExtensions-ConfigureRequest-Bb-Url,System-Action{Bb-Http-IUrlRequest}- 'Bb.Extensions.IUrlExtensions.ConfigureRequest(Bb.Url,System.Action{Bb.Http.IUrlRequest})')
  - [ConfigureRequest(url,action)](#M-Bb-Extensions-IUrlExtensions-ConfigureRequest-System-String,System-Action{Bb-Http-IUrlRequest}- 'Bb.Extensions.IUrlExtensions.ConfigureRequest(System.String,System.Action{Bb.Http.IUrlRequest})')
  - [DeleteAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-DeleteAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.DeleteAsync(Bb.Url,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [DeleteAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-DeleteAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.DeleteAsync(System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [DownloadFileAsync(url,localFolderPath,localFileName,bufferSize,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-DownloadFileAsync-Bb-Url,System-String,System-String,System-Int32,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.DownloadFileAsync(Bb.Url,System.String,System.String,System.Int32,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [DownloadFileAsync(url,localFolderPath,localFileName,bufferSize,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-DownloadFileAsync-System-String,System-String,System-String,System-Int32,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.DownloadFileAsync(System.String,System.String,System.String,System.Int32,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-GetAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.GetAsync(System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetBytesAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-GetBytesAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.GetBytesAsync(System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetObjectAsync\`\`1(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-GetObjectAsync``1-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.GetObjectAsync``1(System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetStreamAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-GetStreamAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.GetStreamAsync(System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetStringAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-GetStringAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.GetStringAsync(System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [HeadAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-HeadAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.HeadAsync(Bb.Url,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [HeadAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-HeadAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.HeadAsync(System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [OptionsAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-OptionsAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.OptionsAsync(Bb.Url,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [OptionsAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-OptionsAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.OptionsAsync(System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchAsync(url,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PatchAsync-System-String,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PatchAsync(System.String,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchJsonAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PatchJsonAsync-System-String,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PatchJsonAsync(System.String,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchStringAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PatchStringAsync-System-String,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PatchStringAsync(System.String,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostAsync(url,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PostAsync-System-String,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PostAsync(System.String,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostJsonAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PostJsonAsync-System-String,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PostJsonAsync(System.String,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostMultipartAsync(url,buildContent,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PostMultipartAsync-Bb-Url,System-Action{System-Net-Http-MultipartFormDataContent},System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PostMultipartAsync(Bb.Url,System.Action{System.Net.Http.MultipartFormDataContent},System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostMultipartAsync(url,buildContent,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PostMultipartAsync-System-String,System-Action{System-Net-Http-MultipartFormDataContent},System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PostMultipartAsync(System.String,System.Action{System.Net.Http.MultipartFormDataContent},System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostStringAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PostStringAsync-System-String,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PostStringAsync(System.String,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostUrlEncodedAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PostUrlEncodedAsync-System-String,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PostUrlEncodedAsync(System.String,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutAsync(url,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PutAsync-System-String,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PutAsync(System.String,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutJsonAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PutJsonAsync-System-String,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PutJsonAsync(System.String,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutStringAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-PutStringAsync-System-String,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.PutStringAsync(System.String,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [Request(url)](#M-Bb-Extensions-IUrlExtensions-Request-Bb-Url- 'Bb.Extensions.IUrlExtensions.Request(Bb.Url)')
  - [SendAsync(url,verb,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-SendAsync-System-String,System-Net-Http-HttpMethod,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.SendAsync(System.String,System.Net.Http.HttpMethod,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendJsonAsync(url,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-SendJsonAsync-System-String,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.SendJsonAsync(System.String,System.Net.Http.HttpMethod,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendStringAsync(url,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-SendStringAsync-System-String,System-Net-Http-HttpMethod,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.SendStringAsync(System.String,System.Net.Http.HttpMethod,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendUrlEncodedAsync(url,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlExtensions-SendUrlEncodedAsync-System-String,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlExtensions.SendUrlEncodedAsync(System.String,System.Net.Http.HttpMethod,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [WithAutoRedirect(url,enabled)](#M-Bb-Extensions-IUrlExtensions-WithAutoRedirect-Bb-Url,System-Boolean- 'Bb.Extensions.IUrlExtensions.WithAutoRedirect(Bb.Url,System.Boolean)')
  - [WithAutoRedirect(url,enabled)](#M-Bb-Extensions-IUrlExtensions-WithAutoRedirect-System-String,System-Boolean- 'Bb.Extensions.IUrlExtensions.WithAutoRedirect(System.String,System.Boolean)')
  - [WithBasicAuth(url,userName,password)](#M-Bb-Extensions-IUrlExtensions-WithBasicAuth-Bb-Url,System-String,System-String- 'Bb.Extensions.IUrlExtensions.WithBasicAuth(Bb.Url,System.String,System.String)')
  - [WithBasicAuth(url,userName,password)](#M-Bb-Extensions-IUrlExtensions-WithBasicAuth-System-String,System-String,System-String- 'Bb.Extensions.IUrlExtensions.WithBasicAuth(System.String,System.String,System.String)')
  - [WithContentType(url,contentType)](#M-Bb-Extensions-IUrlExtensions-WithContentType-Bb-Url,Bb-Http-ContentType- 'Bb.Extensions.IUrlExtensions.WithContentType(Bb.Url,Bb.Http.ContentType)')
  - [WithContentType(url,contentType)](#M-Bb-Extensions-IUrlExtensions-WithContentType-Bb-Url,System-String- 'Bb.Extensions.IUrlExtensions.WithContentType(Bb.Url,System.String)')
  - [WithCookie(url,name,value)](#M-Bb-Extensions-IUrlExtensions-WithCookie-Bb-Url,System-String,System-Object- 'Bb.Extensions.IUrlExtensions.WithCookie(Bb.Url,System.String,System.Object)')
  - [WithCookie(url,name,value)](#M-Bb-Extensions-IUrlExtensions-WithCookie-System-String,System-String,System-Object- 'Bb.Extensions.IUrlExtensions.WithCookie(System.String,System.String,System.Object)')
  - [WithCookies(url,values)](#M-Bb-Extensions-IUrlExtensions-WithCookies-Bb-Url,System-Object- 'Bb.Extensions.IUrlExtensions.WithCookies(Bb.Url,System.Object)')
  - [WithCookies(url,cookieJar)](#M-Bb-Extensions-IUrlExtensions-WithCookies-Bb-Url,Bb-Http-CookieJar- 'Bb.Extensions.IUrlExtensions.WithCookies(Bb.Url,Bb.Http.CookieJar)')
  - [WithCookies(url,cookieJar)](#M-Bb-Extensions-IUrlExtensions-WithCookies-Bb-Url,Bb-Http-CookieJar@- 'Bb.Extensions.IUrlExtensions.WithCookies(Bb.Url,Bb.Http.CookieJar@)')
  - [WithCookies(url,values)](#M-Bb-Extensions-IUrlExtensions-WithCookies-System-String,System-Object- 'Bb.Extensions.IUrlExtensions.WithCookies(System.String,System.Object)')
  - [WithCookies(url,cookieJar)](#M-Bb-Extensions-IUrlExtensions-WithCookies-System-String,Bb-Http-CookieJar- 'Bb.Extensions.IUrlExtensions.WithCookies(System.String,Bb.Http.CookieJar)')
  - [WithCookies(url,cookieJar)](#M-Bb-Extensions-IUrlExtensions-WithCookies-System-String,Bb-Http-CookieJar@- 'Bb.Extensions.IUrlExtensions.WithCookies(System.String,Bb.Http.CookieJar@)')
  - [WithHeader(url,name,value)](#M-Bb-Extensions-IUrlExtensions-WithHeader-System-String,System-String,System-Object- 'Bb.Extensions.IUrlExtensions.WithHeader(System.String,System.String,System.Object)')
  - [WithHeaders(url,headers,replaceUnderscoreWithHyphen)](#M-Bb-Extensions-IUrlExtensions-WithHeaders-Bb-Url,System-Object,System-Boolean- 'Bb.Extensions.IUrlExtensions.WithHeaders(Bb.Url,System.Object,System.Boolean)')
  - [WithHeaders(url,headers,replaceUnderscoreWithHyphen)](#M-Bb-Extensions-IUrlExtensions-WithHeaders-System-String,System-Object,System-Boolean- 'Bb.Extensions.IUrlExtensions.WithHeaders(System.String,System.Object,System.Boolean)')
  - [WithOAuthBearerToken(url,token)](#M-Bb-Extensions-IUrlExtensions-WithOAuthBearerToken-Bb-Url,System-String- 'Bb.Extensions.IUrlExtensions.WithOAuthBearerToken(Bb.Url,System.String)')
  - [WithOAuthBearerToken(url,token)](#M-Bb-Extensions-IUrlExtensions-WithOAuthBearerToken-System-String,System-String- 'Bb.Extensions.IUrlExtensions.WithOAuthBearerToken(System.String,System.String)')
  - [WithTimeout(url,timespan)](#M-Bb-Extensions-IUrlExtensions-WithTimeout-Bb-Url,System-TimeSpan- 'Bb.Extensions.IUrlExtensions.WithTimeout(Bb.Url,System.TimeSpan)')
  - [WithTimeout(url,seconds)](#M-Bb-Extensions-IUrlExtensions-WithTimeout-Bb-Url,System-Int32- 'Bb.Extensions.IUrlExtensions.WithTimeout(Bb.Url,System.Int32)')
  - [WithTimeout(url,timespan)](#M-Bb-Extensions-IUrlExtensions-WithTimeout-System-String,System-TimeSpan- 'Bb.Extensions.IUrlExtensions.WithTimeout(System.String,System.TimeSpan)')
  - [WithTimeout(url,seconds)](#M-Bb-Extensions-IUrlExtensions-WithTimeout-System-String,System-Int32- 'Bb.Extensions.IUrlExtensions.WithTimeout(System.String,System.Int32)')
- [IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest')
  - [Client](#P-Bb-Http-IUrlRequest-Client 'Bb.Http.IUrlRequest.Client')
  - [Content](#P-Bb-Http-IUrlRequest-Content 'Bb.Http.IUrlRequest.Content')
  - [CookieJar](#P-Bb-Http-IUrlRequest-CookieJar 'Bb.Http.IUrlRequest.CookieJar')
  - [Cookies](#P-Bb-Http-IUrlRequest-Cookies 'Bb.Http.IUrlRequest.Cookies')
  - [EnsureSuccessStatusCode](#P-Bb-Http-IUrlRequest-EnsureSuccessStatusCode 'Bb.Http.IUrlRequest.EnsureSuccessStatusCode')
  - [RedirectedFrom](#P-Bb-Http-IUrlRequest-RedirectedFrom 'Bb.Http.IUrlRequest.RedirectedFrom')
  - [Url](#P-Bb-Http-IUrlRequest-Url 'Bb.Http.IUrlRequest.Url')
  - [Verb](#P-Bb-Http-IUrlRequest-Verb 'Bb.Http.IUrlRequest.Verb')
  - [SendAsync(cancellationToken,completionOption)](#M-Bb-Http-IUrlRequest-SendAsync-System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Http.IUrlRequest.SendAsync(System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendAsync(verb,cancellationToken,completionOption)](#M-Bb-Http-IUrlRequest-SendAsync-System-Net-Http-HttpMethod,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Http.IUrlRequest.SendAsync(System.Net.Http.HttpMethod,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendAsync(verb,content,cancellationToken,completionOption)](#M-Bb-Http-IUrlRequest-SendAsync-System-Net-Http-HttpMethod,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Http.IUrlRequest.SendAsync(System.Net.Http.HttpMethod,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
- [IUrlRequestExtensions](#T-Bb-Extensions-IUrlRequestExtensions 'Bb.Extensions.IUrlRequestExtensions')
  - [AllowAnyHttpStatus(uri)](#M-Bb-Extensions-IUrlRequestExtensions-AllowAnyHttpStatus-System-Uri- 'Bb.Extensions.IUrlRequestExtensions.AllowAnyHttpStatus(System.Uri)')
  - [AllowHttpStatus(uri,pattern)](#M-Bb-Extensions-IUrlRequestExtensions-AllowHttpStatus-System-Uri,System-String- 'Bb.Extensions.IUrlRequestExtensions.AllowHttpStatus(System.Uri,System.String)')
  - [AllowHttpStatus(uri,statusCodes)](#M-Bb-Extensions-IUrlRequestExtensions-AllowHttpStatus-System-Uri,System-Net-HttpStatusCode[]- 'Bb.Extensions.IUrlRequestExtensions.AllowHttpStatus(System.Uri,System.Net.HttpStatusCode[])')
  - [ConfigureRequest(uri,action)](#M-Bb-Extensions-IUrlRequestExtensions-ConfigureRequest-System-Uri,System-Action{Bb-Http-IUrlRequest}- 'Bb.Extensions.IUrlRequestExtensions.ConfigureRequest(System.Uri,System.Action{Bb.Http.IUrlRequest})')
  - [DeleteAsync(request,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-DeleteAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.DeleteAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [DeleteAsync(uri,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-DeleteAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.DeleteAsync(System.Uri,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [DownloadFileAsync(uri,localFolderPath,localFileName,bufferSize,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-DownloadFileAsync-System-Uri,System-String,System-String,System-Int32,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.DownloadFileAsync(System.Uri,System.String,System.String,System.Int32,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetAsync(request,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetAsync(uri,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetAsync(System.Uri,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetAsync(Bb.Url,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetBytesAsync(request,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetBytesAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetBytesAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetBytesAsync(uri,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetBytesAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetBytesAsync(System.Uri,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetBytesAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetBytesAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetBytesAsync(Bb.Url,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetJsonAsync\`\`1(uri,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetJsonAsync``1-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetJsonAsync``1(System.Uri,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetObjectAsync\`\`1(request,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetObjectAsync``1-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetObjectAsync``1(Bb.Http.IUrlRequest,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetObjectAsync\`\`1(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetObjectAsync``1-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetObjectAsync``1(Bb.Url,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetStreamAsync(request,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetStreamAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetStreamAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetStreamAsync(uri,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetStreamAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetStreamAsync(System.Uri,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetStreamAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetStreamAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetStreamAsync(Bb.Url,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetStringAsync(request,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetStringAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetStringAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetStringAsync(uri,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetStringAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetStringAsync(System.Uri,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [GetStringAsync(url,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-GetStringAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.GetStringAsync(Bb.Url,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [HeadAsync(request,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-HeadAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.HeadAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [HeadAsync(uri,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-HeadAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.HeadAsync(System.Uri,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [OptionsAsync(request,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-OptionsAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.OptionsAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [OptionsAsync(uri,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-OptionsAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.OptionsAsync(System.Uri,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchAsync(request,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PatchAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PatchAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchAsync(uri,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PatchAsync-System-Uri,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PatchAsync(System.Uri,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchAsync(url,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PatchAsync-Bb-Url,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PatchAsync(Bb.Url,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchObjectAsync(request,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PatchObjectAsync-Bb-Http-IUrlRequest,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PatchObjectAsync(Bb.Http.IUrlRequest,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchObjectAsync(uri,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PatchObjectAsync-System-Uri,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PatchObjectAsync(System.Uri,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchObjectAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PatchObjectAsync-Bb-Url,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PatchObjectAsync(Bb.Url,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchStringAsync(request,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PatchStringAsync-Bb-Http-IUrlRequest,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PatchStringAsync(Bb.Http.IUrlRequest,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchStringAsync(uri,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PatchStringAsync-System-Uri,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PatchStringAsync(System.Uri,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PatchStringAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PatchStringAsync-Bb-Url,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PatchStringAsync(Bb.Url,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostAsync(request,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostAsync(request,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Http-IUrlRequest,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostAsync(Bb.Http.IUrlRequest,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostAsync(request,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Http-IUrlRequest,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostAsync(Bb.Http.IUrlRequest,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostAsync(uri,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostAsync-System-Uri,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostAsync(System.Uri,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostAsync(url,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Url,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostAsync(Bb.Url,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Url,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostAsync(Bb.Url,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Url,Bb-Util-QueryParamCollection,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostAsync(Bb.Url,Bb.Util.QueryParamCollection,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Url,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostAsync(Bb.Url,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostMultipartAsync(uri,buildContent,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostMultipartAsync-System-Uri,System-Action{System-Net-Http-MultipartFormDataContent},System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostMultipartAsync(System.Uri,System.Action{System.Net.Http.MultipartFormDataContent},System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostObjectAsync(uri,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostObjectAsync-System-Uri,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostObjectAsync(System.Uri,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostStringAsync(uri,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostStringAsync-System-Uri,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostStringAsync(System.Uri,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostUrlEncodedAsync(request,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostUrlEncodedAsync-Bb-Http-IUrlRequest,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostUrlEncodedAsync(Bb.Http.IUrlRequest,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostUrlEncodedAsync(uri,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostUrlEncodedAsync-System-Uri,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostUrlEncodedAsync(System.Uri,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PostUrlEncodedAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PostUrlEncodedAsync-Bb-Url,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PostUrlEncodedAsync(Bb.Url,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutAsync(request,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PutAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PutAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutAsync(uri,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PutAsync-System-Uri,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PutAsync(System.Uri,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutAsync(url,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PutAsync-Bb-Url,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PutAsync(Bb.Url,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutJsonAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PutJsonAsync-Bb-Url,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PutJsonAsync(Bb.Url,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutObjectAsync(request,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PutObjectAsync-Bb-Http-IUrlRequest,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PutObjectAsync(Bb.Http.IUrlRequest,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutObjectAsync(uri,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PutObjectAsync-System-Uri,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PutObjectAsync(System.Uri,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutStringAsync(request,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PutStringAsync-Bb-Http-IUrlRequest,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PutStringAsync(Bb.Http.IUrlRequest,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutStringAsync(uri,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PutStringAsync-System-Uri,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PutStringAsync(System.Uri,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutStringAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PutStringAsync-Bb-Url,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PutStringAsync(Bb.Url,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutUrlEncodedAsync(request,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PutUrlEncodedAsync-Bb-Http-IUrlRequest,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PutUrlEncodedAsync(Bb.Http.IUrlRequest,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [PutUrlEncodedAsync(url,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-PutUrlEncodedAsync-Bb-Url,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.PutUrlEncodedAsync(Bb.Url,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendAsync(uri,verb,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-SendAsync-System-Uri,System-Net-Http-HttpMethod,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.SendAsync(System.Uri,System.Net.Http.HttpMethod,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendAsync(url,verb,content,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-SendAsync-Bb-Url,System-Net-Http-HttpMethod,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.SendAsync(Bb.Url,System.Net.Http.HttpMethod,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendObjectAsync(request,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-SendObjectAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.SendObjectAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpMethod,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendObjectAsync(uri,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-SendObjectAsync-System-Uri,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.SendObjectAsync(System.Uri,System.Net.Http.HttpMethod,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendObjectAsync(url,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-SendObjectAsync-Bb-Url,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.SendObjectAsync(Bb.Url,System.Net.Http.HttpMethod,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendStringAsync(request,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-SendStringAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpMethod,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.SendStringAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpMethod,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendStringAsync(uri,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-SendStringAsync-System-Uri,System-Net-Http-HttpMethod,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.SendStringAsync(System.Uri,System.Net.Http.HttpMethod,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendStringAsync(url,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-SendStringAsync-Bb-Url,System-Net-Http-HttpMethod,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.SendStringAsync(Bb.Url,System.Net.Http.HttpMethod,System.String,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendUrlEncodedAsync(request,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-SendUrlEncodedAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.SendUrlEncodedAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpMethod,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendUrlEncodedAsync(uri,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-SendUrlEncodedAsync-System-Uri,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.SendUrlEncodedAsync(System.Uri,System.Net.Http.HttpMethod,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendUrlEncodedAsync(url,verb,body,completionOption,cancellationToken)](#M-Bb-Extensions-IUrlRequestExtensions-SendUrlEncodedAsync-Bb-Url,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.IUrlRequestExtensions.SendUrlEncodedAsync(Bb.Url,System.Net.Http.HttpMethod,System.Object,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [Serialize(self,body)](#M-Bb-Extensions-IUrlRequestExtensions-Serialize-Bb-Http-IUrlRequest,System-Object- 'Bb.Extensions.IUrlRequestExtensions.Serialize(Bb.Http.IUrlRequest,System.Object)')
  - [WithAutoRedirect(uri,enabled)](#M-Bb-Extensions-IUrlRequestExtensions-WithAutoRedirect-System-Uri,System-Boolean- 'Bb.Extensions.IUrlRequestExtensions.WithAutoRedirect(System.Uri,System.Boolean)')
  - [WithBasicAuth(uri,userName,password)](#M-Bb-Extensions-IUrlRequestExtensions-WithBasicAuth-System-Uri,System-String,System-String- 'Bb.Extensions.IUrlRequestExtensions.WithBasicAuth(System.Uri,System.String,System.String)')
  - [WithCookie(uri,name,value)](#M-Bb-Extensions-IUrlRequestExtensions-WithCookie-System-Uri,System-String,System-Object- 'Bb.Extensions.IUrlRequestExtensions.WithCookie(System.Uri,System.String,System.Object)')
  - [WithCookies(uri,values)](#M-Bb-Extensions-IUrlRequestExtensions-WithCookies-System-Uri,System-Object- 'Bb.Extensions.IUrlRequestExtensions.WithCookies(System.Uri,System.Object)')
  - [WithCookies(uri,cookieJar)](#M-Bb-Extensions-IUrlRequestExtensions-WithCookies-System-Uri,Bb-Http-CookieJar- 'Bb.Extensions.IUrlRequestExtensions.WithCookies(System.Uri,Bb.Http.CookieJar)')
  - [WithCookies(uri,cookieJar)](#M-Bb-Extensions-IUrlRequestExtensions-WithCookies-System-Uri,Bb-Http-CookieJar@- 'Bb.Extensions.IUrlRequestExtensions.WithCookies(System.Uri,Bb.Http.CookieJar@)')
  - [WithHeader(uri,name,value)](#M-Bb-Extensions-IUrlRequestExtensions-WithHeader-System-Uri,System-String,System-Object- 'Bb.Extensions.IUrlRequestExtensions.WithHeader(System.Uri,System.String,System.Object)')
  - [WithHeaders(uri,headers,replaceUnderscoreWithHyphen)](#M-Bb-Extensions-IUrlRequestExtensions-WithHeaders-System-Uri,System-Object,System-Boolean- 'Bb.Extensions.IUrlRequestExtensions.WithHeaders(System.Uri,System.Object,System.Boolean)')
  - [WithOAuthBearerToken(uri,token)](#M-Bb-Extensions-IUrlRequestExtensions-WithOAuthBearerToken-System-Uri,System-String- 'Bb.Extensions.IUrlRequestExtensions.WithOAuthBearerToken(System.Uri,System.String)')
  - [WithTimeout(uri,timespan)](#M-Bb-Extensions-IUrlRequestExtensions-WithTimeout-System-Uri,System-TimeSpan- 'Bb.Extensions.IUrlRequestExtensions.WithTimeout(System.Uri,System.TimeSpan)')
  - [WithTimeout(uri,seconds)](#M-Bb-Extensions-IUrlRequestExtensions-WithTimeout-System-Uri,System-Int32- 'Bb.Extensions.IUrlRequestExtensions.WithTimeout(System.Uri,System.Int32)')
- [IUrlResponse](#T-Bb-Http-IUrlResponse 'Bb.Http.IUrlResponse')
  - [Cookies](#P-Bb-Http-IUrlResponse-Cookies 'Bb.Http.IUrlResponse.Cookies')
  - [Headers](#P-Bb-Http-IUrlResponse-Headers 'Bb.Http.IUrlResponse.Headers')
  - [IsSuccessStatusCode](#P-Bb-Http-IUrlResponse-IsSuccessStatusCode 'Bb.Http.IUrlResponse.IsSuccessStatusCode')
  - [ResponseMessage](#P-Bb-Http-IUrlResponse-ResponseMessage 'Bb.Http.IUrlResponse.ResponseMessage')
  - [StatusCode](#P-Bb-Http-IUrlResponse-StatusCode 'Bb.Http.IUrlResponse.StatusCode')
  - [EnsureSuccessStatusCode()](#M-Bb-Http-IUrlResponse-EnsureSuccessStatusCode 'Bb.Http.IUrlResponse.EnsureSuccessStatusCode')
  - [GetBytesAsync()](#M-Bb-Http-IUrlResponse-GetBytesAsync 'Bb.Http.IUrlResponse.GetBytesAsync')
  - [GetObjectAsync\`\`1()](#M-Bb-Http-IUrlResponse-GetObjectAsync``1 'Bb.Http.IUrlResponse.GetObjectAsync``1')
  - [GetStreamAsync()](#M-Bb-Http-IUrlResponse-GetStreamAsync 'Bb.Http.IUrlResponse.GetStreamAsync')
  - [GetStringAsync()](#M-Bb-Http-IUrlResponse-GetStringAsync 'Bb.Http.IUrlResponse.GetStringAsync')
- [InvalidCookieException](#T-Bb-Http-InvalidCookieException 'Bb.Http.InvalidCookieException')
  - [#ctor()](#M-Bb-Http-InvalidCookieException-#ctor-System-String- 'Bb.Http.InvalidCookieException.#ctor(System.String)')
- [MultipartExtensions](#T-Bb-Extensions-MultipartExtensions 'Bb.Extensions.MultipartExtensions')
  - [AddFile(self,name,filename,contentType)](#M-Bb-Extensions-MultipartExtensions-AddFile-System-Net-Http-MultipartFormDataContent,System-String,System-String,System-String- 'Bb.Extensions.MultipartExtensions.AddFile(System.Net.Http.MultipartFormDataContent,System.String,System.String,System.String)')
  - [AddJson(self,name,data)](#M-Bb-Extensions-MultipartExtensions-AddJson-System-Net-Http-MultipartFormDataContent,System-String,System-String- 'Bb.Extensions.MultipartExtensions.AddJson(System.Net.Http.MultipartFormDataContent,System.String,System.String)')
  - [AddString(self,name,data,contentType)](#M-Bb-Extensions-MultipartExtensions-AddString-System-Net-Http-MultipartFormDataContent,System-String,System-String,System-String- 'Bb.Extensions.MultipartExtensions.AddString(System.Net.Http.MultipartFormDataContent,System.String,System.String,System.String)')
  - [AddStringParts(self,name,data,contentType)](#M-Bb-Extensions-MultipartExtensions-AddStringParts-System-Net-Http-MultipartFormDataContent,System-String,System-Object,System-String- 'Bb.Extensions.MultipartExtensions.AddStringParts(System.Net.Http.MultipartFormDataContent,System.String,System.Object,System.String)')
  - [AddUrlEncoded(self,name,data)](#M-Bb-Extensions-MultipartExtensions-AddUrlEncoded-System-Net-Http-MultipartFormDataContent,System-String,System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{System-String,System-String}}- 'Bb.Extensions.MultipartExtensions.AddUrlEncoded(System.Net.Http.MultipartFormDataContent,System.String,System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{System.String,System.String}})')
  - [PostMultipartAsync(buildContent,request,completionOption,cancellationToken)](#M-Bb-Extensions-MultipartExtensions-PostMultipartAsync-Bb-Http-IUrlRequest,System-Action{System-Net-Http-MultipartFormDataContent},System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Extensions.MultipartExtensions.PostMultipartAsync(Bb.Http.IUrlRequest,System.Action{System.Net.Http.MultipartFormDataContent},System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [WithContentType\`\`1(self,contentType)](#M-Bb-Extensions-MultipartExtensions-WithContentType``1-``0,Bb-Http-ContentType- 'Bb.Extensions.MultipartExtensions.WithContentType``1(``0,Bb.Http.ContentType)')
- [NameValueList\`1](#T-Bb-Util-NameValueList`1 'Bb.Util.NameValueList`1')
  - [#ctor()](#M-Bb-Util-NameValueList`1-#ctor-System-Boolean- 'Bb.Util.NameValueList`1.#ctor(System.Boolean)')
  - [#ctor()](#M-Bb-Util-NameValueList`1-#ctor-System-Collections-Generic-IEnumerable{System-ValueTuple{System-String,`0}},System-Boolean- 'Bb.Util.NameValueList`1.#ctor(System.Collections.Generic.IEnumerable{System.ValueTuple{System.String,`0}},System.Boolean)')
  - [Add()](#M-Bb-Util-NameValueList`1-Add-System-String,`0- 'Bb.Util.NameValueList`1.Add(System.String,`0)')
  - [AddOrReplace()](#M-Bb-Util-NameValueList`1-AddOrReplace-System-String,`0- 'Bb.Util.NameValueList`1.AddOrReplace(System.String,`0)')
  - [Contains()](#M-Bb-Util-NameValueList`1-Contains-System-String- 'Bb.Util.NameValueList`1.Contains(System.String)')
  - [Contains()](#M-Bb-Util-NameValueList`1-Contains-System-String,`0- 'Bb.Util.NameValueList`1.Contains(System.String,`0)')
  - [FirstOrDefault()](#M-Bb-Util-NameValueList`1-FirstOrDefault-System-String- 'Bb.Util.NameValueList`1.FirstOrDefault(System.String)')
  - [GetAll()](#M-Bb-Util-NameValueList`1-GetAll-System-String- 'Bb.Util.NameValueList`1.GetAll(System.String)')
  - [Remove()](#M-Bb-Util-NameValueList`1-Remove-System-String- 'Bb.Util.NameValueList`1.Remove(System.String)')
  - [TryGetFirst()](#M-Bb-Util-NameValueList`1-TryGetFirst-System-String,`0@- 'Bb.Util.NameValueList`1.TryGetFirst(System.String,`0@)')
- [NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling')
  - [Ignore](#F-Bb-NullValueHandling-Ignore 'Bb.NullValueHandling.Ignore')
  - [NameOnly](#F-Bb-NullValueHandling-NameOnly 'Bb.NullValueHandling.NameOnly')
  - [Remove](#F-Bb-NullValueHandling-Remove 'Bb.NullValueHandling.Remove')
- [PerBaseUrlClientFactory](#T-Bb-Http-Configuration-PerBaseUrlClientFactory 'Bb.Http.Configuration.PerBaseUrlClientFactory')
  - [Create(url)](#M-Bb-Http-Configuration-PerBaseUrlClientFactory-Create-Bb-Url- 'Bb.Http.Configuration.PerBaseUrlClientFactory.Create(Bb.Url)')
  - [GetCacheKey(url)](#M-Bb-Http-Configuration-PerBaseUrlClientFactory-GetCacheKey-Bb-Url- 'Bb.Http.Configuration.PerBaseUrlClientFactory.GetCacheKey(Bb.Url)')
- [QueryParamCollection](#T-Bb-Util-QueryParamCollection 'Bb.Util.QueryParamCollection')
  - [#ctor(query)](#M-Bb-Util-QueryParamCollection-#ctor-System-String- 'Bb.Util.QueryParamCollection.#ctor(System.String)')
  - [Count](#P-Bb-Util-QueryParamCollection-Count 'Bb.Util.QueryParamCollection.Count')
  - [Item](#P-Bb-Util-QueryParamCollection-Item-System-Int32- 'Bb.Util.QueryParamCollection.Item(System.Int32)')
  - [Add(name,value,isEncoded,nullValueHandling)](#M-Bb-Util-QueryParamCollection-Add-System-String,System-Object,System-Boolean,Bb-NullValueHandling- 'Bb.Util.QueryParamCollection.Add(System.String,System.Object,System.Boolean,Bb.NullValueHandling)')
  - [AddOrReplace(name,value,isEncoded,nullValueHandling)](#M-Bb-Util-QueryParamCollection-AddOrReplace-System-String,System-Object,System-Boolean,Bb-NullValueHandling- 'Bb.Util.QueryParamCollection.AddOrReplace(System.String,System.Object,System.Boolean,Bb.NullValueHandling)')
  - [Clear()](#M-Bb-Util-QueryParamCollection-Clear 'Bb.Util.QueryParamCollection.Clear')
  - [Contains()](#M-Bb-Util-QueryParamCollection-Contains-System-String- 'Bb.Util.QueryParamCollection.Contains(System.String)')
  - [Contains()](#M-Bb-Util-QueryParamCollection-Contains-System-String,System-Object- 'Bb.Util.QueryParamCollection.Contains(System.String,System.Object)')
  - [FirstOrDefault()](#M-Bb-Util-QueryParamCollection-FirstOrDefault-System-String- 'Bb.Util.QueryParamCollection.FirstOrDefault(System.String)')
  - [GetAll()](#M-Bb-Util-QueryParamCollection-GetAll-System-String- 'Bb.Util.QueryParamCollection.GetAll(System.String)')
  - [GetEnumerator()](#M-Bb-Util-QueryParamCollection-GetEnumerator 'Bb.Util.QueryParamCollection.GetEnumerator')
  - [Remove()](#M-Bb-Util-QueryParamCollection-Remove-System-String- 'Bb.Util.QueryParamCollection.Remove(System.String)')
  - [ToString()](#M-Bb-Util-QueryParamCollection-ToString 'Bb.Util.QueryParamCollection.ToString')
  - [ToString()](#M-Bb-Util-QueryParamCollection-ToString-System-Boolean- 'Bb.Util.QueryParamCollection.ToString(System.Boolean)')
  - [TryGetFirst()](#M-Bb-Util-QueryParamCollection-TryGetFirst-System-String,System-Object@- 'Bb.Util.QueryParamCollection.TryGetFirst(System.String,System.Object@)')
  - [op_Implicit(query)](#M-Bb-Util-QueryParamCollection-op_Implicit-Bb-Util-QueryParamCollection-~System-String 'Bb.Util.QueryParamCollection.op_Implicit(Bb.Util.QueryParamCollection)~System.String')
- [QueryParamValue](#T-Bb-Util-QueryParamValue 'Bb.Util.QueryParamValue')
- [RedirectSettings](#T-Bb-Http-Configuration-RedirectSettings 'Bb.Http.Configuration.RedirectSettings')
  - [#ctor()](#M-Bb-Http-Configuration-RedirectSettings-#ctor-Bb-Http-Configuration-UrlHttpSettings- 'Bb.Http.Configuration.RedirectSettings.#ctor(Bb.Http.Configuration.UrlHttpSettings)')
  - [AllowSecureToInsecure](#P-Bb-Http-Configuration-RedirectSettings-AllowSecureToInsecure 'Bb.Http.Configuration.RedirectSettings.AllowSecureToInsecure')
  - [Enabled](#P-Bb-Http-Configuration-RedirectSettings-Enabled 'Bb.Http.Configuration.RedirectSettings.Enabled')
  - [ForwardAuthorizationHeader](#P-Bb-Http-Configuration-RedirectSettings-ForwardAuthorizationHeader 'Bb.Http.Configuration.RedirectSettings.ForwardAuthorizationHeader')
  - [ForwardHeaders](#P-Bb-Http-Configuration-RedirectSettings-ForwardHeaders 'Bb.Http.Configuration.RedirectSettings.ForwardHeaders')
  - [MaxAutoRedirects](#P-Bb-Http-Configuration-RedirectSettings-MaxAutoRedirects 'Bb.Http.Configuration.RedirectSettings.MaxAutoRedirects')
- [ResponseExtensions](#T-Bb-Extensions-ResponseExtensions 'Bb.Extensions.ResponseExtensions')
  - [AsBytes(response,actionInterceptMessage)](#M-Bb-Extensions-ResponseExtensions-AsBytes-System-Threading-Tasks-Task{Bb-Http-IUrlResponse},System-Action{Bb-Http-IUrlResponse}- 'Bb.Extensions.ResponseExtensions.AsBytes(System.Threading.Tasks.Task{Bb.Http.IUrlResponse},System.Action{Bb.Http.IUrlResponse})')
  - [AsStream(response,actionInterceptMessage)](#M-Bb-Extensions-ResponseExtensions-AsStream-System-Threading-Tasks-Task{Bb-Http-IUrlResponse},System-Action{Bb-Http-IUrlResponse}- 'Bb.Extensions.ResponseExtensions.AsStream(System.Threading.Tasks.Task{Bb.Http.IUrlResponse},System.Action{Bb.Http.IUrlResponse})')
  - [AsString(response,actionInterceptMessage)](#M-Bb-Extensions-ResponseExtensions-AsString-System-Threading-Tasks-Task{Bb-Http-IUrlResponse},System-Action{Bb-Http-IUrlResponse}- 'Bb.Extensions.ResponseExtensions.AsString(System.Threading.Tasks.Task{Bb.Http.IUrlResponse},System.Action{Bb.Http.IUrlResponse})')
  - [As\`\`1(response,actionInterceptMessage)](#M-Bb-Extensions-ResponseExtensions-As``1-System-Threading-Tasks-Task{Bb-Http-IUrlResponse},System-Action{Bb-Http-IUrlResponse}- 'Bb.Extensions.ResponseExtensions.As``1(System.Threading.Tasks.Task{Bb.Http.IUrlResponse},System.Action{Bb.Http.IUrlResponse})')
- [SameSite](#T-Bb-Http-SameSite 'Bb.Http.SameSite')
  - [Lax](#F-Bb-Http-SameSite-Lax 'Bb.Http.SameSite.Lax')
  - [None](#F-Bb-Http-SameSite-None 'Bb.Http.SameSite.None')
  - [Strict](#F-Bb-Http-SameSite-Strict 'Bb.Http.SameSite.Strict')
- [SettingsExtensions](#T-Bb-Extensions-SettingsExtensions 'Bb.Extensions.SettingsExtensions')
  - [AfterCall\`\`1()](#M-Bb-Extensions-SettingsExtensions-AfterCall``1-``0,System-Action{Bb-Http-UrlCall}- 'Bb.Extensions.SettingsExtensions.AfterCall``1(``0,System.Action{Bb.Http.UrlCall})')
  - [AfterCall\`\`1()](#M-Bb-Extensions-SettingsExtensions-AfterCall``1-``0,System-Func{Bb-Http-UrlCall,System-Threading-Tasks-Task}- 'Bb.Extensions.SettingsExtensions.AfterCall``1(``0,System.Func{Bb.Http.UrlCall,System.Threading.Tasks.Task})')
  - [AllowAnyHttpStatus\`\`1(obj)](#M-Bb-Extensions-SettingsExtensions-AllowAnyHttpStatus``1-``0- 'Bb.Extensions.SettingsExtensions.AllowAnyHttpStatus``1(``0)')
  - [AllowHttpStatus\`\`1(obj,pattern)](#M-Bb-Extensions-SettingsExtensions-AllowHttpStatus``1-``0,System-String- 'Bb.Extensions.SettingsExtensions.AllowHttpStatus``1(``0,System.String)')
  - [AllowHttpStatus\`\`1(obj,statusCodes)](#M-Bb-Extensions-SettingsExtensions-AllowHttpStatus``1-``0,System-Net-HttpStatusCode[]- 'Bb.Extensions.SettingsExtensions.AllowHttpStatus``1(``0,System.Net.HttpStatusCode[])')
  - [BeforeCall\`\`1()](#M-Bb-Extensions-SettingsExtensions-BeforeCall``1-``0,System-Action{Bb-Http-UrlCall}- 'Bb.Extensions.SettingsExtensions.BeforeCall``1(``0,System.Action{Bb.Http.UrlCall})')
  - [BeforeCall\`\`1()](#M-Bb-Extensions-SettingsExtensions-BeforeCall``1-``0,System-Func{Bb-Http-UrlCall,System-Threading-Tasks-Task}- 'Bb.Extensions.SettingsExtensions.BeforeCall``1(``0,System.Func{Bb.Http.UrlCall,System.Threading.Tasks.Task})')
  - [Configure(client,action)](#M-Bb-Extensions-SettingsExtensions-Configure-Bb-Http-IUrlClient,System-Action{Bb-Http-Configuration-UrlHttpSettings}- 'Bb.Extensions.SettingsExtensions.Configure(Bb.Http.IUrlClient,System.Action{Bb.Http.Configuration.UrlHttpSettings})')
  - [ConfigureRequest(request,action)](#M-Bb-Extensions-SettingsExtensions-ConfigureRequest-Bb-Http-IUrlRequest,System-Action{Bb-Http-IUrlRequest}- 'Bb.Extensions.SettingsExtensions.ConfigureRequest(Bb.Http.IUrlRequest,System.Action{Bb.Http.IUrlRequest})')
  - [OnError\`\`1()](#M-Bb-Extensions-SettingsExtensions-OnError``1-``0,System-Action{Bb-Http-UrlCall}- 'Bb.Extensions.SettingsExtensions.OnError``1(``0,System.Action{Bb.Http.UrlCall})')
  - [OnError\`\`1()](#M-Bb-Extensions-SettingsExtensions-OnError``1-``0,System-Func{Bb-Http-UrlCall,System-Threading-Tasks-Task}- 'Bb.Extensions.SettingsExtensions.OnError``1(``0,System.Func{Bb.Http.UrlCall,System.Threading.Tasks.Task})')
  - [OnRedirect\`\`1()](#M-Bb-Extensions-SettingsExtensions-OnRedirect``1-``0,System-Action{Bb-Http-UrlCall}- 'Bb.Extensions.SettingsExtensions.OnRedirect``1(``0,System.Action{Bb.Http.UrlCall})')
  - [OnRedirect\`\`1()](#M-Bb-Extensions-SettingsExtensions-OnRedirect``1-``0,System-Func{Bb-Http-UrlCall,System-Threading-Tasks-Task}- 'Bb.Extensions.SettingsExtensions.OnRedirect``1(``0,System.Func{Bb.Http.UrlCall,System.Threading.Tasks.Task})')
  - [WithAutoRedirect\`\`1(obj,enabled)](#M-Bb-Extensions-SettingsExtensions-WithAutoRedirect``1-``0,System-Boolean- 'Bb.Extensions.SettingsExtensions.WithAutoRedirect``1(``0,System.Boolean)')
  - [WithTimeout\`\`1(obj,timespan)](#M-Bb-Extensions-SettingsExtensions-WithTimeout``1-``0,System-TimeSpan- 'Bb.Extensions.SettingsExtensions.WithTimeout``1(``0,System.TimeSpan)')
  - [WithTimeout\`\`1(obj,seconds)](#M-Bb-Extensions-SettingsExtensions-WithTimeout``1-``0,System-Int32- 'Bb.Extensions.SettingsExtensions.WithTimeout``1(``0,System.Int32)')
- [Url](#T-Bb-Url 'Bb.Url')
  - [#ctor(scheme,host,port,segments)](#M-Bb-Url-#ctor-System-String,System-String,System-Int32,System-String[]- 'Bb.Url.#ctor(System.String,System.String,System.Int32,System.String[])')
  - [#ctor(baseUrl)](#M-Bb-Url-#ctor-System-String- 'Bb.Url.#ctor(System.String)')
  - [#ctor(uri)](#M-Bb-Url-#ctor-System-Uri,System-String[]- 'Bb.Url.#ctor(System.Uri,System.String[])')
  - [Authority](#P-Bb-Url-Authority 'Bb.Url.Authority')
  - [Fragment](#P-Bb-Url-Fragment 'Bb.Url.Fragment')
  - [Host](#P-Bb-Url-Host 'Bb.Url.Host')
  - [IsRelative](#P-Bb-Url-IsRelative 'Bb.Url.IsRelative')
  - [IsSecureScheme](#P-Bb-Url-IsSecureScheme 'Bb.Url.IsSecureScheme')
  - [Path](#P-Bb-Url-Path 'Bb.Url.Path')
  - [PathSegments](#P-Bb-Url-PathSegments 'Bb.Url.PathSegments')
  - [Port](#P-Bb-Url-Port 'Bb.Url.Port')
  - [Query](#P-Bb-Url-Query 'Bb.Url.Query')
  - [QueryParams](#P-Bb-Url-QueryParams 'Bb.Url.QueryParams')
  - [Root](#P-Bb-Url-Root 'Bb.Url.Root')
  - [Scheme](#P-Bb-Url-Scheme 'Bb.Url.Scheme')
  - [UserInfo](#P-Bb-Url-UserInfo 'Bb.Url.UserInfo')
  - [Clone()](#M-Bb-Url-Clone 'Bb.Url.Clone')
  - [Combine(parts)](#M-Bb-Url-Combine-System-String[]- 'Bb.Url.Combine(System.String[])')
  - [Decode(s,interpretPlusAsSpace)](#M-Bb-Url-Decode-System-String,System-Boolean- 'Bb.Url.Decode(System.String,System.Boolean)')
  - [Encode(s,encodeSpaceAsPlus)](#M-Bb-Url-Encode-System-String,System-Boolean- 'Bb.Url.Encode(System.String,System.Boolean)')
  - [EncodeIllegalCharacters(s,encodeSpaceAsPlus)](#M-Bb-Url-EncodeIllegalCharacters-System-String,System-Boolean- 'Bb.Url.EncodeIllegalCharacters(System.String,System.Boolean)')
  - [Equals(obj)](#M-Bb-Url-Equals-System-Object- 'Bb.Url.Equals(System.Object)')
  - [GetHashCode()](#M-Bb-Url-GetHashCode 'Bb.Url.GetHashCode')
  - [IsValid(url)](#M-Bb-Url-IsValid-System-String- 'Bb.Url.IsValid(System.String)')
  - [Parse()](#M-Bb-Url-Parse-System-String- 'Bb.Url.Parse(System.String)')
  - [ParsePathSegment(path)](#M-Bb-Url-ParsePathSegment-System-String- 'Bb.Url.ParsePathSegment(System.String)')
  - [ParseQueryParam(query)](#M-Bb-Url-ParseQueryParam-System-String- 'Bb.Url.ParseQueryParam(System.String)')
  - [RemoveFragment()](#M-Bb-Url-RemoveFragment 'Bb.Url.RemoveFragment')
  - [RemovePath()](#M-Bb-Url-RemovePath 'Bb.Url.RemovePath')
  - [RemovePathSegment()](#M-Bb-Url-RemovePathSegment 'Bb.Url.RemovePathSegment')
  - [RemoveQuery()](#M-Bb-Url-RemoveQuery 'Bb.Url.RemoveQuery')
  - [RemoveQueryParam(name)](#M-Bb-Url-RemoveQueryParam-System-String- 'Bb.Url.RemoveQueryParam(System.String)')
  - [RemoveQueryParam(names)](#M-Bb-Url-RemoveQueryParam-System-String[]- 'Bb.Url.RemoveQueryParam(System.String[])')
  - [RemoveQueryParam(names)](#M-Bb-Url-RemoveQueryParam-System-Collections-Generic-IEnumerable{System-String}- 'Bb.Url.RemoveQueryParam(System.Collections.Generic.IEnumerable{System.String})')
  - [Reset()](#M-Bb-Url-Reset 'Bb.Url.Reset')
  - [ResetToRoot()](#M-Bb-Url-ResetToRoot 'Bb.Url.ResetToRoot')
  - [SetFragment(fragment)](#M-Bb-Url-SetFragment-System-String- 'Bb.Url.SetFragment(System.String)')
  - [ToString(encodeSpaceAsPlus)](#M-Bb-Url-ToString-System-Boolean- 'Bb.Url.ToString(System.Boolean)')
  - [ToString()](#M-Bb-Url-ToString 'Bb.Url.ToString')
  - [ToUri()](#M-Bb-Url-ToUri 'Bb.Url.ToUri')
  - [WithPathSegment(segment,fullyEncode)](#M-Bb-Url-WithPathSegment-System-Object,System-Boolean- 'Bb.Url.WithPathSegment(System.Object,System.Boolean)')
  - [WithPathSegment(segments)](#M-Bb-Url-WithPathSegment-System-Object[]- 'Bb.Url.WithPathSegment(System.Object[])')
  - [WithPathSegment(segments)](#M-Bb-Url-WithPathSegment-System-Collections-Generic-IEnumerable{System-Object}- 'Bb.Url.WithPathSegment(System.Collections.Generic.IEnumerable{System.Object})')
  - [WithQueryParam(name,value,nullValueHandling)](#M-Bb-Url-WithQueryParam-System-String,System-Object,Bb-NullValueHandling- 'Bb.Url.WithQueryParam(System.String,System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(name,value,isEncoded,nullValueHandling)](#M-Bb-Url-WithQueryParam-System-String,System-String,System-Boolean,Bb-NullValueHandling- 'Bb.Url.WithQueryParam(System.String,System.String,System.Boolean,Bb.NullValueHandling)')
  - [WithQueryParam(name)](#M-Bb-Url-WithQueryParam-System-String- 'Bb.Url.WithQueryParam(System.String)')
  - [WithQueryParam(values,nullValueHandling)](#M-Bb-Url-WithQueryParam-System-Object,Bb-NullValueHandling- 'Bb.Url.WithQueryParam(System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(names)](#M-Bb-Url-WithQueryParam-System-Collections-Generic-IEnumerable{System-String}- 'Bb.Url.WithQueryParam(System.Collections.Generic.IEnumerable{System.String})')
  - [WithQueryParam(names)](#M-Bb-Url-WithQueryParam-System-String[]- 'Bb.Url.WithQueryParam(System.String[])')
  - [op_Implicit(url)](#M-Bb-Url-op_Implicit-Bb-Url-~System-Uri 'Bb.Url.op_Implicit(Bb.Url)~System.Uri')
  - [op_Implicit()](#M-Bb-Url-op_Implicit-System-Uri-~Bb-Url 'Bb.Url.op_Implicit(System.Uri)~Bb.Url')
  - [op_Implicit(url)](#M-Bb-Url-op_Implicit-Bb-Url-~System-String 'Bb.Url.op_Implicit(Bb.Url)~System.String')
  - [op_Implicit(url)](#M-Bb-Url-op_Implicit-System-String-~Bb-Url 'Bb.Url.op_Implicit(System.String)~Bb.Url')
- [UrlBuilderExtensions](#T-Bb-Extensions-UrlBuilderExtensions 'Bb.Extensions.UrlBuilderExtensions')
  - [AppendPathSegment(request,segment,fullyEncode)](#M-Bb-Extensions-UrlBuilderExtensions-AppendPathSegment-Bb-Http-IUrlRequest,System-Object,System-Boolean- 'Bb.Extensions.UrlBuilderExtensions.AppendPathSegment(Bb.Http.IUrlRequest,System.Object,System.Boolean)')
  - [AppendPathSegment(request,segments)](#M-Bb-Extensions-UrlBuilderExtensions-AppendPathSegment-Bb-Http-IUrlRequest,System-Object[]- 'Bb.Extensions.UrlBuilderExtensions.AppendPathSegment(Bb.Http.IUrlRequest,System.Object[])')
  - [AppendPathSegment(request,segments)](#M-Bb-Extensions-UrlBuilderExtensions-AppendPathSegment-Bb-Http-IUrlRequest,System-Collections-Generic-IEnumerable{System-Object}- 'Bb.Extensions.UrlBuilderExtensions.AppendPathSegment(Bb.Http.IUrlRequest,System.Collections.Generic.IEnumerable{System.Object})')
  - [QueryParam(request,name,value,nullValueHandling)](#M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-String,System-Object,Bb-NullValueHandling- 'Bb.Extensions.UrlBuilderExtensions.QueryParam(Bb.Http.IUrlRequest,System.String,System.Object,Bb.NullValueHandling)')
  - [QueryParam(request,name,value,isEncoded,nullValueHandling)](#M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-String,System-String,System-Boolean,Bb-NullValueHandling- 'Bb.Extensions.UrlBuilderExtensions.QueryParam(Bb.Http.IUrlRequest,System.String,System.String,System.Boolean,Bb.NullValueHandling)')
  - [QueryParam(request,name)](#M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-String- 'Bb.Extensions.UrlBuilderExtensions.QueryParam(Bb.Http.IUrlRequest,System.String)')
  - [QueryParam(request,values,nullValueHandling)](#M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-Object,Bb-NullValueHandling- 'Bb.Extensions.UrlBuilderExtensions.QueryParam(Bb.Http.IUrlRequest,System.Object,Bb.NullValueHandling)')
  - [QueryParam(request,names)](#M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Extensions.UrlBuilderExtensions.QueryParam(Bb.Http.IUrlRequest,System.Collections.Generic.IEnumerable{System.String})')
  - [QueryParam(request,names)](#M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-String[]- 'Bb.Extensions.UrlBuilderExtensions.QueryParam(Bb.Http.IUrlRequest,System.String[])')
  - [RemoveFragment(request)](#M-Bb-Extensions-UrlBuilderExtensions-RemoveFragment-Bb-Http-IUrlRequest- 'Bb.Extensions.UrlBuilderExtensions.RemoveFragment(Bb.Http.IUrlRequest)')
  - [RemoveQueryParam(request,name)](#M-Bb-Extensions-UrlBuilderExtensions-RemoveQueryParam-Bb-Http-IUrlRequest,System-String- 'Bb.Extensions.UrlBuilderExtensions.RemoveQueryParam(Bb.Http.IUrlRequest,System.String)')
  - [RemoveQueryParam(request,names)](#M-Bb-Extensions-UrlBuilderExtensions-RemoveQueryParam-Bb-Http-IUrlRequest,System-String[]- 'Bb.Extensions.UrlBuilderExtensions.RemoveQueryParam(Bb.Http.IUrlRequest,System.String[])')
  - [RemoveQueryParam(request,names)](#M-Bb-Extensions-UrlBuilderExtensions-RemoveQueryParam-Bb-Http-IUrlRequest,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Extensions.UrlBuilderExtensions.RemoveQueryParam(Bb.Http.IUrlRequest,System.Collections.Generic.IEnumerable{System.String})')
  - [SetFragment(request,fragment)](#M-Bb-Extensions-UrlBuilderExtensions-SetFragment-Bb-Http-IUrlRequest,System-String- 'Bb.Extensions.UrlBuilderExtensions.SetFragment(Bb.Http.IUrlRequest,System.String)')
- [UrlCall](#T-Bb-Http-UrlCall 'Bb.Http.UrlCall')
  - [_time](#F-Bb-Http-UrlCall-_time 'Bb.Http.UrlCall._time')
  - [Completed](#P-Bb-Http-UrlCall-Completed 'Bb.Http.UrlCall.Completed')
  - [Exception](#P-Bb-Http-UrlCall-Exception 'Bb.Http.UrlCall.Exception')
  - [ExceptionHandled](#P-Bb-Http-UrlCall-ExceptionHandled 'Bb.Http.UrlCall.ExceptionHandled')
  - [HttpRequestMessage](#P-Bb-Http-UrlCall-HttpRequestMessage 'Bb.Http.UrlCall.HttpRequestMessage')
  - [HttpResponseMessage](#P-Bb-Http-UrlCall-HttpResponseMessage 'Bb.Http.UrlCall.HttpResponseMessage')
  - [Redirect](#P-Bb-Http-UrlCall-Redirect 'Bb.Http.UrlCall.Redirect')
  - [Request](#P-Bb-Http-UrlCall-Request 'Bb.Http.UrlCall.Request')
  - [RequestBody](#P-Bb-Http-UrlCall-RequestBody 'Bb.Http.UrlCall.RequestBody')
  - [Response](#P-Bb-Http-UrlCall-Response 'Bb.Http.UrlCall.Response')
  - [StartedUtc](#P-Bb-Http-UrlCall-StartedUtc 'Bb.Http.UrlCall.StartedUtc')
  - [Succeeded](#P-Bb-Http-UrlCall-Succeeded 'Bb.Http.UrlCall.Succeeded')
  - [Time](#P-Bb-Http-UrlCall-Time 'Bb.Http.UrlCall.Time')
  - [ToString()](#M-Bb-Http-UrlCall-ToString 'Bb.Http.UrlCall.ToString')
- [UrlClient](#T-Bb-Http-UrlClient 'Bb.Http.UrlClient')
  - [#ctor(baseUrl)](#M-Bb-Http-UrlClient-#ctor-System-String- 'Bb.Http.UrlClient.#ctor(System.String)')
  - [#ctor(httpClient,baseUrl)](#M-Bb-Http-UrlClient-#ctor-System-Net-Http-HttpClient,System-String- 'Bb.Http.UrlClient.#ctor(System.Net.Http.HttpClient,System.String)')
  - [BaseUrl](#P-Bb-Http-UrlClient-BaseUrl 'Bb.Http.UrlClient.BaseUrl')
  - [Headers](#P-Bb-Http-UrlClient-Headers 'Bb.Http.UrlClient.Headers')
  - [HttpClient](#P-Bb-Http-UrlClient-HttpClient 'Bb.Http.UrlClient.HttpClient')
  - [IsDisposed](#P-Bb-Http-UrlClient-IsDisposed 'Bb.Http.UrlClient.IsDisposed')
  - [Settings](#P-Bb-Http-UrlClient-Settings 'Bb.Http.UrlClient.Settings')
  - [Dispose()](#M-Bb-Http-UrlClient-Dispose 'Bb.Http.UrlClient.Dispose')
  - [Request()](#M-Bb-Http-UrlClient-Request-System-Object[]- 'Bb.Http.UrlClient.Request(System.Object[])')
  - [SendAsync()](#M-Bb-Http-UrlClient-SendAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Http.UrlClient.SendAsync(Bb.Http.IUrlRequest,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
- [UrlClientFactoryBase](#T-Bb-Http-Configuration-UrlClientFactoryBase 'Bb.Http.Configuration.UrlClientFactoryBase')
  - [Create(url)](#M-Bb-Http-Configuration-UrlClientFactoryBase-Create-Bb-Url- 'Bb.Http.Configuration.UrlClientFactoryBase.Create(Bb.Url)')
  - [CreateHttpClient()](#M-Bb-Http-Configuration-UrlClientFactoryBase-CreateHttpClient-System-Net-Http-HttpMessageHandler- 'Bb.Http.Configuration.UrlClientFactoryBase.CreateHttpClient(System.Net.Http.HttpMessageHandler)')
  - [CreateMessageHandler()](#M-Bb-Http-Configuration-UrlClientFactoryBase-CreateMessageHandler 'Bb.Http.Configuration.UrlClientFactoryBase.CreateMessageHandler')
  - [Dispose()](#M-Bb-Http-Configuration-UrlClientFactoryBase-Dispose 'Bb.Http.Configuration.UrlClientFactoryBase.Dispose')
  - [Get(url)](#M-Bb-Http-Configuration-UrlClientFactoryBase-Get-Bb-Url- 'Bb.Http.Configuration.UrlClientFactoryBase.Get(Bb.Url)')
  - [GetCacheKey(url)](#M-Bb-Http-Configuration-UrlClientFactoryBase-GetCacheKey-Bb-Url- 'Bb.Http.Configuration.UrlClientFactoryBase.GetCacheKey(Bb.Url)')
- [UrlClientFactoryExtensions](#T-Bb-Extensions-UrlClientFactoryExtensions 'Bb.Extensions.UrlClientFactoryExtensions')
  - [ConfigureClient(factory,url,configAction)](#M-Bb-Extensions-UrlClientFactoryExtensions-ConfigureClient-Bb-Http-Configuration-IUrlClientFactory,System-String,System-Action{Bb-Http-IUrlClient}- 'Bb.Extensions.UrlClientFactoryExtensions.ConfigureClient(Bb.Http.Configuration.IUrlClientFactory,System.String,System.Action{Bb.Http.IUrlClient})')
  - [CreateHttpClient()](#M-Bb-Extensions-UrlClientFactoryExtensions-CreateHttpClient-Bb-Http-Configuration-IUrlClientFactory- 'Bb.Extensions.UrlClientFactoryExtensions.CreateHttpClient(Bb.Http.Configuration.IUrlClientFactory)')
- [UrlCookie](#T-Bb-Http-UrlCookie 'Bb.Http.UrlCookie')
  - [#ctor(name,value,originUrl,dateReceived)](#M-Bb-Http-UrlCookie-#ctor-System-String,System-String,System-String,System-Nullable{System-DateTimeOffset}- 'Bb.Http.UrlCookie.#ctor(System.String,System.String,System.String,System.Nullable{System.DateTimeOffset})')
  - [DateReceived](#P-Bb-Http-UrlCookie-DateReceived 'Bb.Http.UrlCookie.DateReceived')
  - [Domain](#P-Bb-Http-UrlCookie-Domain 'Bb.Http.UrlCookie.Domain')
  - [Expires](#P-Bb-Http-UrlCookie-Expires 'Bb.Http.UrlCookie.Expires')
  - [HttpOnly](#P-Bb-Http-UrlCookie-HttpOnly 'Bb.Http.UrlCookie.HttpOnly')
  - [MaxAge](#P-Bb-Http-UrlCookie-MaxAge 'Bb.Http.UrlCookie.MaxAge')
  - [Name](#P-Bb-Http-UrlCookie-Name 'Bb.Http.UrlCookie.Name')
  - [OriginUrl](#P-Bb-Http-UrlCookie-OriginUrl 'Bb.Http.UrlCookie.OriginUrl')
  - [Path](#P-Bb-Http-UrlCookie-Path 'Bb.Http.UrlCookie.Path')
  - [SameSite](#P-Bb-Http-UrlCookie-SameSite 'Bb.Http.UrlCookie.SameSite')
  - [Secure](#P-Bb-Http-UrlCookie-Secure 'Bb.Http.UrlCookie.Secure')
  - [Value](#P-Bb-Http-UrlCookie-Value 'Bb.Http.UrlCookie.Value')
  - [GetKey()](#M-Bb-Http-UrlCookie-GetKey 'Bb.Http.UrlCookie.GetKey')
  - [Lock()](#M-Bb-Http-UrlCookie-Lock 'Bb.Http.UrlCookie.Lock')
- [UrlExtension](#T-Bb-UrlExtension 'Bb.UrlExtension')
  - [ConcatUrl(urls)](#M-Bb-UrlExtension-ConcatUrl-System-Collections-Generic-IEnumerable{Bb-Url}- 'Bb.UrlExtension.ConcatUrl(System.Collections.Generic.IEnumerable{Bb.Url})')
  - [ConcatUrl(sb,urls)](#M-Bb-UrlExtension-ConcatUrl-System-Text-StringBuilder,System-Collections-Generic-IEnumerable{Bb-Url}- 'Bb.UrlExtension.ConcatUrl(System.Text.StringBuilder,System.Collections.Generic.IEnumerable{Bb.Url})')
- [UrlExtensions](#T-Bb-Extensions-UrlExtensions 'Bb.Extensions.UrlExtensions')
  - [RemoveFragment(url)](#M-Bb-Extensions-UrlExtensions-RemoveFragment-System-String- 'Bb.Extensions.UrlExtensions.RemoveFragment(System.String)')
  - [RemovePath(url)](#M-Bb-Extensions-UrlExtensions-RemovePath-System-String- 'Bb.Extensions.UrlExtensions.RemovePath(System.String)')
  - [RemovePathSegment(url)](#M-Bb-Extensions-UrlExtensions-RemovePathSegment-System-String- 'Bb.Extensions.UrlExtensions.RemovePathSegment(System.String)')
  - [RemoveQuery(url)](#M-Bb-Extensions-UrlExtensions-RemoveQuery-System-String- 'Bb.Extensions.UrlExtensions.RemoveQuery(System.String)')
  - [RemoveQueryParam(url,name)](#M-Bb-Extensions-UrlExtensions-RemoveQueryParam-System-String,System-String- 'Bb.Extensions.UrlExtensions.RemoveQueryParam(System.String,System.String)')
  - [RemoveQueryParam(url,names)](#M-Bb-Extensions-UrlExtensions-RemoveQueryParam-System-String,System-String[]- 'Bb.Extensions.UrlExtensions.RemoveQueryParam(System.String,System.String[])')
  - [RemoveQueryParam(url,names)](#M-Bb-Extensions-UrlExtensions-RemoveQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Extensions.UrlExtensions.RemoveQueryParam(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [ResetToRoot(url)](#M-Bb-Extensions-UrlExtensions-ResetToRoot-System-String- 'Bb.Extensions.UrlExtensions.ResetToRoot(System.String)')
  - [SetFragment(url,fragment)](#M-Bb-Extensions-UrlExtensions-SetFragment-System-String,System-String- 'Bb.Extensions.UrlExtensions.SetFragment(System.String,System.String)')
  - [SetQueryParam(url,name,value,nullValueHandling)](#M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-String,System-Object,Bb-NullValueHandling- 'Bb.Extensions.UrlExtensions.SetQueryParam(System.String,System.String,System.Object,Bb.NullValueHandling)')
  - [SetQueryParam(url,name,value,isEncoded,nullValueHandling)](#M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-String,System-String,System-Boolean,Bb-NullValueHandling- 'Bb.Extensions.UrlExtensions.SetQueryParam(System.String,System.String,System.String,System.Boolean,Bb.NullValueHandling)')
  - [SetQueryParam(url,name)](#M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-String- 'Bb.Extensions.UrlExtensions.SetQueryParam(System.String,System.String)')
  - [SetQueryParam(url,values,nullValueHandling)](#M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-Object,Bb-NullValueHandling- 'Bb.Extensions.UrlExtensions.SetQueryParam(System.String,System.Object,Bb.NullValueHandling)')
  - [SetQueryParam(url,names)](#M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Extensions.UrlExtensions.SetQueryParam(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [SetQueryParam(url,names)](#M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-String[]- 'Bb.Extensions.UrlExtensions.SetQueryParam(System.String,System.String[])')
  - [WithFragment(uri,fragment)](#M-Bb-Extensions-UrlExtensions-WithFragment-System-Uri,System-String- 'Bb.Extensions.UrlExtensions.WithFragment(System.Uri,System.String)')
  - [WithPathSegment(url,segment,fullyEncode)](#M-Bb-Extensions-UrlExtensions-WithPathSegment-System-String,System-Object,System-Boolean- 'Bb.Extensions.UrlExtensions.WithPathSegment(System.String,System.Object,System.Boolean)')
  - [WithPathSegment(url,segments)](#M-Bb-Extensions-UrlExtensions-WithPathSegment-System-String,System-Object[]- 'Bb.Extensions.UrlExtensions.WithPathSegment(System.String,System.Object[])')
  - [WithPathSegment(url,segments)](#M-Bb-Extensions-UrlExtensions-WithPathSegment-System-String,System-Collections-Generic-IEnumerable{System-Object}- 'Bb.Extensions.UrlExtensions.WithPathSegment(System.String,System.Collections.Generic.IEnumerable{System.Object})')
  - [WithPathSegment(uri,segment,fullyEncode)](#M-Bb-Extensions-UrlExtensions-WithPathSegment-System-Uri,System-Object,System-Boolean- 'Bb.Extensions.UrlExtensions.WithPathSegment(System.Uri,System.Object,System.Boolean)')
  - [WithPathSegment(uri,segments)](#M-Bb-Extensions-UrlExtensions-WithPathSegment-System-Uri,System-Object[]- 'Bb.Extensions.UrlExtensions.WithPathSegment(System.Uri,System.Object[])')
  - [WithPathSegment(uri,segments)](#M-Bb-Extensions-UrlExtensions-WithPathSegment-System-Uri,System-Collections-Generic-IEnumerable{System-Object}- 'Bb.Extensions.UrlExtensions.WithPathSegment(System.Uri,System.Collections.Generic.IEnumerable{System.Object})')
  - [WithQueryParam(uri,name,value,nullValueHandling)](#M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-String,System-Object,Bb-NullValueHandling- 'Bb.Extensions.UrlExtensions.WithQueryParam(System.Uri,System.String,System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(uri,name,value,isEncoded,nullValueHandling)](#M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-String,System-String,System-Boolean,Bb-NullValueHandling- 'Bb.Extensions.UrlExtensions.WithQueryParam(System.Uri,System.String,System.String,System.Boolean,Bb.NullValueHandling)')
  - [WithQueryParam(uri,name)](#M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-String- 'Bb.Extensions.UrlExtensions.WithQueryParam(System.Uri,System.String)')
  - [WithQueryParam(uri,values,nullValueHandling)](#M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-Object,Bb-NullValueHandling- 'Bb.Extensions.UrlExtensions.WithQueryParam(System.Uri,System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(uri,names)](#M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Extensions.UrlExtensions.WithQueryParam(System.Uri,System.Collections.Generic.IEnumerable{System.String})')
  - [WithQueryParam(uri,names)](#M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-String[]- 'Bb.Extensions.UrlExtensions.WithQueryParam(System.Uri,System.String[])')
  - [WithRemoveFragment(uri)](#M-Bb-Extensions-UrlExtensions-WithRemoveFragment-System-Uri- 'Bb.Extensions.UrlExtensions.WithRemoveFragment(System.Uri)')
  - [WithRemovePath(uri)](#M-Bb-Extensions-UrlExtensions-WithRemovePath-System-Uri- 'Bb.Extensions.UrlExtensions.WithRemovePath(System.Uri)')
  - [WithRemovePathSegment(uri)](#M-Bb-Extensions-UrlExtensions-WithRemovePathSegment-System-Uri- 'Bb.Extensions.UrlExtensions.WithRemovePathSegment(System.Uri)')
  - [WithRemoveQuery(uri)](#M-Bb-Extensions-UrlExtensions-WithRemoveQuery-System-Uri- 'Bb.Extensions.UrlExtensions.WithRemoveQuery(System.Uri)')
  - [WithRemoveQueryParam(uri,name)](#M-Bb-Extensions-UrlExtensions-WithRemoveQueryParam-System-Uri,System-String- 'Bb.Extensions.UrlExtensions.WithRemoveQueryParam(System.Uri,System.String)')
  - [WithRemoveQueryParam(uri,names)](#M-Bb-Extensions-UrlExtensions-WithRemoveQueryParam-System-Uri,System-String[]- 'Bb.Extensions.UrlExtensions.WithRemoveQueryParam(System.Uri,System.String[])')
  - [WithRemoveQueryParam(uri,names)](#M-Bb-Extensions-UrlExtensions-WithRemoveQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Extensions.UrlExtensions.WithRemoveQueryParam(System.Uri,System.Collections.Generic.IEnumerable{System.String})')
  - [WithResetToRoot(uri)](#M-Bb-Extensions-UrlExtensions-WithResetToRoot-System-Uri- 'Bb.Extensions.UrlExtensions.WithResetToRoot(System.Uri)')
- [UrlHttp](#T-Bb-Http-UrlHttp 'Bb.Http.UrlHttp')
  - [GlobalSettings](#P-Bb-Http-UrlHttp-GlobalSettings 'Bb.Http.UrlHttp.GlobalSettings')
  - [Configure(configAction)](#M-Bb-Http-UrlHttp-Configure-System-Action{Bb-Http-Configuration-GlobalUrlHttpSettings}- 'Bb.Http.UrlHttp.Configure(System.Action{Bb.Http.Configuration.GlobalUrlHttpSettings})')
  - [ConfigureClient(url,configAction)](#M-Bb-Http-UrlHttp-ConfigureClient-System-String,System-Action{Bb-Http-IUrlClient}- 'Bb.Http.UrlHttp.ConfigureClient(System.String,System.Action{Bb.Http.IUrlClient})')
- [UrlHttpException](#T-Bb-Http-UrlHttpException 'Bb.Http.UrlHttpException')
  - [#ctor(call,message,inner)](#M-Bb-Http-UrlHttpException-#ctor-Bb-Http-UrlCall,System-String,System-Exception- 'Bb.Http.UrlHttpException.#ctor(Bb.Http.UrlCall,System.String,System.Exception)')
  - [#ctor(call,inner)](#M-Bb-Http-UrlHttpException-#ctor-Bb-Http-UrlCall,System-Exception- 'Bb.Http.UrlHttpException.#ctor(Bb.Http.UrlCall,System.Exception)')
  - [#ctor(call)](#M-Bb-Http-UrlHttpException-#ctor-Bb-Http-UrlCall- 'Bb.Http.UrlHttpException.#ctor(Bb.Http.UrlCall)')
  - [Call](#P-Bb-Http-UrlHttpException-Call 'Bb.Http.UrlHttpException.Call')
  - [StatusCode](#P-Bb-Http-UrlHttpException-StatusCode 'Bb.Http.UrlHttpException.StatusCode')
  - [GetResponseJsonAsync\`\`1()](#M-Bb-Http-UrlHttpException-GetResponseJsonAsync``1 'Bb.Http.UrlHttpException.GetResponseJsonAsync``1')
  - [GetResponseStringAsync()](#M-Bb-Http-UrlHttpException-GetResponseStringAsync 'Bb.Http.UrlHttpException.GetResponseStringAsync')
- [UrlHttpSettings](#T-Bb-Http-Configuration-UrlHttpSettings 'Bb.Http.Configuration.UrlHttpSettings')
  - [#ctor()](#M-Bb-Http-Configuration-UrlHttpSettings-#ctor 'Bb.Http.Configuration.UrlHttpSettings.#ctor')
  - [AfterCall](#P-Bb-Http-Configuration-UrlHttpSettings-AfterCall 'Bb.Http.Configuration.UrlHttpSettings.AfterCall')
  - [AfterCallAsync](#P-Bb-Http-Configuration-UrlHttpSettings-AfterCallAsync 'Bb.Http.Configuration.UrlHttpSettings.AfterCallAsync')
  - [AllowedHttpStatusRange](#P-Bb-Http-Configuration-UrlHttpSettings-AllowedHttpStatusRange 'Bb.Http.Configuration.UrlHttpSettings.AllowedHttpStatusRange')
  - [BeforeCall](#P-Bb-Http-Configuration-UrlHttpSettings-BeforeCall 'Bb.Http.Configuration.UrlHttpSettings.BeforeCall')
  - [BeforeCallAsync](#P-Bb-Http-Configuration-UrlHttpSettings-BeforeCallAsync 'Bb.Http.Configuration.UrlHttpSettings.BeforeCallAsync')
  - [Defaults](#P-Bb-Http-Configuration-UrlHttpSettings-Defaults 'Bb.Http.Configuration.UrlHttpSettings.Defaults')
  - [JsonSerializer](#P-Bb-Http-Configuration-UrlHttpSettings-JsonSerializer 'Bb.Http.Configuration.UrlHttpSettings.JsonSerializer')
  - [OnError](#P-Bb-Http-Configuration-UrlHttpSettings-OnError 'Bb.Http.Configuration.UrlHttpSettings.OnError')
  - [OnErrorAsync](#P-Bb-Http-Configuration-UrlHttpSettings-OnErrorAsync 'Bb.Http.Configuration.UrlHttpSettings.OnErrorAsync')
  - [OnRedirect](#P-Bb-Http-Configuration-UrlHttpSettings-OnRedirect 'Bb.Http.Configuration.UrlHttpSettings.OnRedirect')
  - [OnRedirectAsync](#P-Bb-Http-Configuration-UrlHttpSettings-OnRedirectAsync 'Bb.Http.Configuration.UrlHttpSettings.OnRedirectAsync')
  - [Redirects](#P-Bb-Http-Configuration-UrlHttpSettings-Redirects 'Bb.Http.Configuration.UrlHttpSettings.Redirects')
  - [Timeout](#P-Bb-Http-Configuration-UrlHttpSettings-Timeout 'Bb.Http.Configuration.UrlHttpSettings.Timeout')
  - [UrlEncodedSerializer](#P-Bb-Http-Configuration-UrlHttpSettings-UrlEncodedSerializer 'Bb.Http.Configuration.UrlHttpSettings.UrlEncodedSerializer')
  - [Get\`\`1()](#M-Bb-Http-Configuration-UrlHttpSettings-Get``1-System-String- 'Bb.Http.Configuration.UrlHttpSettings.Get``1(System.String)')
  - [ResetDefaults()](#M-Bb-Http-Configuration-UrlHttpSettings-ResetDefaults 'Bb.Http.Configuration.UrlHttpSettings.ResetDefaults')
  - [Set\`\`1()](#M-Bb-Http-Configuration-UrlHttpSettings-Set``1-``0,System-String- 'Bb.Http.Configuration.UrlHttpSettings.Set``1(``0,System.String)')
- [UrlHttpTimeoutException](#T-Bb-Http-UrlHttpTimeoutException 'Bb.Http.UrlHttpTimeoutException')
  - [#ctor(call,inner)](#M-Bb-Http-UrlHttpTimeoutException-#ctor-Bb-Http-UrlCall,System-Exception- 'Bb.Http.UrlHttpTimeoutException.#ctor(Bb.Http.UrlCall,System.Exception)')
- [UrlParsingException](#T-Bb-Http-UrlParsingException 'Bb.Http.UrlParsingException')
  - [#ctor(call,expectedFormat,inner)](#M-Bb-Http-UrlParsingException-#ctor-Bb-Http-UrlCall,System-String,System-Exception- 'Bb.Http.UrlParsingException.#ctor(Bb.Http.UrlCall,System.String,System.Exception)')
  - [ExpectedFormat](#P-Bb-Http-UrlParsingException-ExpectedFormat 'Bb.Http.UrlParsingException.ExpectedFormat')
- [UrlRedirect](#T-Bb-Http-UrlRedirect 'Bb.Http.UrlRedirect')
  - [ChangeVerbToGet](#P-Bb-Http-UrlRedirect-ChangeVerbToGet 'Bb.Http.UrlRedirect.ChangeVerbToGet')
  - [Count](#P-Bb-Http-UrlRedirect-Count 'Bb.Http.UrlRedirect.Count')
  - [Follow](#P-Bb-Http-UrlRedirect-Follow 'Bb.Http.UrlRedirect.Follow')
  - [Url](#P-Bb-Http-UrlRedirect-Url 'Bb.Http.UrlRedirect.Url')
- [UrlRequest](#T-Bb-Http-UrlRequest 'Bb.Http.UrlRequest')
  - [#ctor(url)](#M-Bb-Http-UrlRequest-#ctor-Bb-Url- 'Bb.Http.UrlRequest.#ctor(Bb.Url)')
  - [#ctor()](#M-Bb-Http-UrlRequest-#ctor-Bb-Http-IUrlClient,System-Object[]- 'Bb.Http.UrlRequest.#ctor(Bb.Http.IUrlClient,System.Object[])')
  - [#ctor()](#M-Bb-Http-UrlRequest-#ctor-System-String,System-Object[]- 'Bb.Http.UrlRequest.#ctor(System.String,System.Object[])')
  - [Client](#P-Bb-Http-UrlRequest-Client 'Bb.Http.UrlRequest.Client')
  - [Content](#P-Bb-Http-UrlRequest-Content 'Bb.Http.UrlRequest.Content')
  - [CookieJar](#P-Bb-Http-UrlRequest-CookieJar 'Bb.Http.UrlRequest.CookieJar')
  - [Cookies](#P-Bb-Http-UrlRequest-Cookies 'Bb.Http.UrlRequest.Cookies')
  - [EnsureSuccessStatusCode](#P-Bb-Http-UrlRequest-EnsureSuccessStatusCode 'Bb.Http.UrlRequest.EnsureSuccessStatusCode')
  - [Headers](#P-Bb-Http-UrlRequest-Headers 'Bb.Http.UrlRequest.Headers')
  - [RedirectedFrom](#P-Bb-Http-UrlRequest-RedirectedFrom 'Bb.Http.UrlRequest.RedirectedFrom')
  - [Settings](#P-Bb-Http-UrlRequest-Settings 'Bb.Http.UrlRequest.Settings')
  - [Url](#P-Bb-Http-UrlRequest-Url 'Bb.Http.UrlRequest.Url')
  - [Verb](#P-Bb-Http-UrlRequest-Verb 'Bb.Http.UrlRequest.Verb')
  - [SendAsync()](#M-Bb-Http-UrlRequest-SendAsync-System-Net-Http-HttpMethod,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Http.UrlRequest.SendAsync(System.Net.Http.HttpMethod,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
  - [SendAsync()](#M-Bb-Http-UrlRequest-SendAsync-System-Net-Http-HttpMethod,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken- 'Bb.Http.UrlRequest.SendAsync(System.Net.Http.HttpMethod,System.Net.Http.HttpContent,System.Net.Http.HttpCompletionOption,System.Threading.CancellationToken)')
- [UrlResponse](#T-Bb-Http-UrlResponse 'Bb.Http.UrlResponse')
  - [#ctor()](#M-Bb-Http-UrlResponse-#ctor-Bb-Http-UrlCall,Bb-Http-CookieJar- 'Bb.Http.UrlResponse.#ctor(Bb.Http.UrlCall,Bb.Http.CookieJar)')
  - [Cookies](#P-Bb-Http-UrlResponse-Cookies 'Bb.Http.UrlResponse.Cookies')
  - [Headers](#P-Bb-Http-UrlResponse-Headers 'Bb.Http.UrlResponse.Headers')
  - [IsSuccessStatusCode](#P-Bb-Http-UrlResponse-IsSuccessStatusCode 'Bb.Http.UrlResponse.IsSuccessStatusCode')
  - [ResponseMessage](#P-Bb-Http-UrlResponse-ResponseMessage 'Bb.Http.UrlResponse.ResponseMessage')
  - [StatusCode](#P-Bb-Http-UrlResponse-StatusCode 'Bb.Http.UrlResponse.StatusCode')
  - [Dispose()](#M-Bb-Http-UrlResponse-Dispose 'Bb.Http.UrlResponse.Dispose')
  - [GetBytesAsync()](#M-Bb-Http-UrlResponse-GetBytesAsync 'Bb.Http.UrlResponse.GetBytesAsync')
  - [GetObjectAsync\`\`1()](#M-Bb-Http-UrlResponse-GetObjectAsync``1 'Bb.Http.UrlResponse.GetObjectAsync``1')
  - [GetStreamAsync()](#M-Bb-Http-UrlResponse-GetStreamAsync 'Bb.Http.UrlResponse.GetStreamAsync')
  - [GetStringAsync()](#M-Bb-Http-UrlResponse-GetStringAsync 'Bb.Http.UrlResponse.GetStringAsync')
- [Util](#T-Bb-Http-Testing-Util 'Bb.Http.Testing.Util')
  - [HasCookie()](#M-Bb-Http-Testing-Util-HasCookie-Bb-Http-UrlCall,System-String,System-Object- 'Bb.Http.Testing.Util.HasCookie(Bb.Http.UrlCall,System.String,System.Object)')
  - [HasHeader()](#M-Bb-Http-Testing-Util-HasHeader-Bb-Http-UrlCall,System-String,System-Object- 'Bb.Http.Testing.Util.HasHeader(Bb.Http.UrlCall,System.String,System.Object)')
  - [HasQueryParam()](#M-Bb-Http-Testing-Util-HasQueryParam-Bb-Http-UrlCall,System-String,System-Object- 'Bb.Http.Testing.Util.HasQueryParam(Bb.Http.UrlCall,System.String,System.Object)')
  - [MatchesPattern()](#M-Bb-Http-Testing-Util-MatchesPattern-System-String,System-String- 'Bb.Http.Testing.Util.MatchesPattern(System.String,System.String)')
  - [MatchesUrlPattern()](#M-Bb-Http-Testing-Util-MatchesUrlPattern-System-String,System-String- 'Bb.Http.Testing.Util.MatchesUrlPattern(System.String,System.String)')
- [VariableReplacer](#T-Bb-Util-VariableReplacer 'Bb.Util.VariableReplacer')
  - [ReplaceVariables(input)](#M-Bb-Util-VariableReplacer-ReplaceVariables-System-String- 'Bb.Util.VariableReplacer.ReplaceVariables(System.String)')
- [Variables](#T-Bb-Util-Variables 'Bb.Util.Variables')
  - [Root](#P-Bb-Util-Variables-Root 'Bb.Util.Variables.Root')
  - [#cctor()](#M-Bb-Util-Variables-#cctor 'Bb.Util.Variables.#cctor')
  - [AppendFirst(variables)](#M-Bb-Util-Variables-AppendFirst-Bb-Util-Variables- 'Bb.Util.Variables.AppendFirst(Bb.Util.Variables)')
  - [Resolve(name,resultValue)](#M-Bb-Util-Variables-Resolve-System-String,System-String@- 'Bb.Util.Variables.Resolve(System.String,System.String@)')
  - [TryGet(name,resultValue)](#M-Bb-Util-Variables-TryGet-System-String,System-String@- 'Bb.Util.Variables.TryGet(System.String,System.String@)')
- [VariablesDictionary](#T-Bb-Util-VariablesDictionary 'Bb.Util.VariablesDictionary')
  - [Add(name,value)](#M-Bb-Util-VariablesDictionary-Add-System-String,System-String- 'Bb.Util.VariablesDictionary.Add(System.String,System.String)')
  - [TryGet(name,resultValue)](#M-Bb-Util-VariablesDictionary-TryGet-System-String,System-String@- 'Bb.Util.VariablesDictionary.TryGet(System.String,System.String@)')

<a name='T-Bb-Util-CommonExtensions'></a>
## CommonExtensions `type`

##### Namespace

Bb.Util

##### Summary

CommonExtensions for objects.

<a name='M-Bb-Util-CommonExtensions-IsIP-System-String-'></a>
### IsIP() `method`

##### Summary

True if the given string is a valid IPv4 address.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-CommonExtensions-Merge``2-System-Collections-Generic-IDictionary{``0,``1},System-Collections-Generic-IDictionary{``0,``1}-'></a>
### Merge\`\`2() `method`

##### Summary

Merges the key/value pairs from d2 into d1, without overwriting those already set in d1.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-CommonExtensions-SplitOnFirstOccurence-System-String,System-String-'></a>
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

<a name='M-Bb-Util-CommonExtensions-StripQuotes-System-String-'></a>
### StripQuotes() `method`

##### Summary

Strips any single quotes or double quotes from the beginning and end of a string.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-CommonExtensions-ToInvariantString-System-Object-'></a>
### ToInvariantString() `method`

##### Summary

Returns a string that represents the current object, using CultureInfo.InvariantCulture where possible.
Dates are represented in IS0 8601.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-CommonExtensions-ToKeyValuePairs-System-Object-'></a>
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

<a name='T-Bb-Http-ContentType'></a>
## ContentType `type`

##### Namespace

Bb.Http

<a name='M-Bb-Http-ContentType-#ctor-System-String-'></a>
### #ctor(contentType) `constructor`

##### Summary

Creates a new ContentType instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| contentType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='F-Bb-Http-ContentType-ApplicationJson'></a>
### ApplicationJson `constants`

##### Summary

"application/json"

<a name='F-Bb-Http-ContentType-ApplicationxWwwFormUrlencoded'></a>
### ApplicationxWwwFormUrlencoded `constants`

##### Summary

"application/x-www-form-urlencoded"

<a name='M-Bb-Http-ContentType-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-CookieCutter'></a>
## CookieCutter `type`

##### Namespace

Bb.Http

##### Summary

Utility and extension methods for parsing and validating cookies.

<a name='M-Bb-Http-CookieCutter-GetPairs-System-String-'></a>
### GetPairs() `method`

##### Summary

Parses list of semicolon-delimited "name=value" pairs.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-CookieCutter-IsExpired-Bb-Http-UrlCookie,System-String@-'></a>
### IsExpired() `method`

##### Summary

True if this cookie is expired. If true, provides a descriptive reason (Expires or Max-Age).

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-CookieCutter-IsValid-Bb-Http-UrlCookie,System-String@-'></a>
### IsValid() `method`

##### Summary

True if this cookie passes well-accepted rules for the Set-Cookie header. If false, provides a descriptive reason.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-CookieCutter-ParseRequestHeader-System-String-'></a>
### ParseRequestHeader(headerValue) `method`

##### Summary

Parses a Cookie request header to name-value pairs.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| headerValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value of the Cookie request header. |

<a name='M-Bb-Http-CookieCutter-ParseResponseHeader-System-String,System-String-'></a>
### ParseResponseHeader(url,headerValue) `method`

##### Summary

Parses a Set-Cookie response header to a UrlCookie.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL that sent the response. |
| headerValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value of the Set-Cookie header. |

<a name='M-Bb-Http-CookieCutter-ShouldSendTo-Bb-Http-UrlCookie,Bb-Url,System-String@-'></a>
### ShouldSendTo() `method`

##### Summary

True if this cookie should be sent in a request to the given URL. If false, provides a descriptive reason.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-CookieCutter-ToRequestHeader-System-Collections-Generic-IEnumerable{System-ValueTuple{System-String,System-String}}-'></a>
### ToRequestHeader() `method`

##### Summary

Creates a Cookie request header value from a list of cookie name-value pairs.

##### Returns

A header value if cookie values are present, otherwise null.

##### Parameters

This method has no parameters.

<a name='T-Bb-Extensions-CookieExtensions'></a>
## CookieExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Fluent extension methods for working with HTTP cookies.

<a name='M-Bb-Extensions-CookieExtensions-WithCookie-Bb-Http-IUrlRequest,System-String,System-Object-'></a>
### WithCookie(request,name,value) `method`

##### Summary

Adds or updates a name-value pair in this request's Cookie header.
To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.

##### Returns

This IUrlClient instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The cookie name. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The cookie value. |

<a name='M-Bb-Extensions-CookieExtensions-WithCookies-Bb-Http-IUrlRequest,System-Object-'></a>
### WithCookies(request,values) `method`

##### Summary

Adds or updates name-value pairs in this request's Cookie header, based on property names/values
of the provided object, or keys/values if object is a dictionary.
To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.

##### Returns

This IUrlClient.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest. |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Names/values of HTTP cookies to set. Typically an anonymous object or IDictionary. |

<a name='M-Bb-Extensions-CookieExtensions-WithCookies-Bb-Http-IUrlRequest,Bb-Http-CookieJar-'></a>
### WithCookies(request,cookieJar) `method`

##### Summary

Sets the CookieJar associated with this request, which will be updated with any Set-Cookie headers present
in the response and is suitable for reuse in subsequent requests.

##### Returns

This IUrlClient instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest. |
| cookieJar | [Bb.Http.CookieJar](#T-Bb-Http-CookieJar 'Bb.Http.CookieJar') | The CookieJar. |

<a name='M-Bb-Extensions-CookieExtensions-WithCookies-Bb-Http-IUrlRequest,Bb-Http-CookieJar@-'></a>
### WithCookies(request,cookieJar) `method`

##### Summary

Creates a new CookieJar and associates it with this request, which will be updated with any Set-Cookie
headers present in the response and is suitable for reuse in subsequent requests.

##### Returns

This IUrlClient instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest. |
| cookieJar | [Bb.Http.CookieJar@](#T-Bb-Http-CookieJar@ 'Bb.Http.CookieJar@') | The created CookieJar, which can be reused in subsequent requests. |

<a name='T-Bb-Http-CookieJar'></a>
## CookieJar `type`

##### Namespace

Bb.Http

##### Summary

A collection of UrlCookies that can be attached to one or more UrlRequests, either explicitly via WithCookies
or implicitly via a CookieSession. Stores cookies received via Set-Cookie response headers.

<a name='P-Bb-Http-CookieJar-Count'></a>
### Count `property`

##### Summary

*Inherit from parent.*

<a name='M-Bb-Http-CookieJar-AddOrReplace-System-String,System-Object,System-String,System-Nullable{System-DateTimeOffset}-'></a>
### AddOrReplace(name,value,originUrl,dateReceived) `method`

##### Summary

Adds a cookie to the jar or replaces one with the same Name/Domain/Path.
Throws InvalidCookieException if cookie is invalid.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the cookie. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Value of the cookie. |
| originUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | URL of request that sent the original Set-Cookie header. |
| dateReceived | [System.Nullable{System.DateTimeOffset}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTimeOffset}') | Date/time that original Set-Cookie header was received. Defaults to current date/time. Important for Max-Age to be enforced correctly. |

<a name='M-Bb-Http-CookieJar-AddOrReplace-Bb-Http-UrlCookie-'></a>
### AddOrReplace() `method`

##### Summary

Adds a cookie to the jar or replaces one with the same Name/Domain/Path.
Throws InvalidCookieException if cookie is invalid.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-CookieJar-Clear'></a>
### Clear() `method`

##### Summary

Removes all cookies from this CookieJar

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-CookieJar-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-CookieJar-Remove-System-Func{Bb-Http-UrlCookie,System-Boolean}-'></a>
### Remove() `method`

##### Summary

Removes all cookies matching the given predicate.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-CookieJar-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-CookieJar-TryAddOrReplace-Bb-Http-UrlCookie,System-String@-'></a>
### TryAddOrReplace() `method`

##### Summary

Adds a cookie to the jar or updates if one with the same Name/Domain/Path already exists,
but only if it is valid and not expired.

##### Returns

true if cookie is valid and was added or updated. If false, provides descriptive reason.

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-CookieSession'></a>
## CookieSession `type`

##### Namespace

Bb.Http

##### Summary

A context where multiple requests use a common CookieJar.

<a name='M-Bb-Http-CookieSession-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Creates a new CookieSession where all requests are made off the same base URL.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Http-CookieSession-#ctor-Bb-Http-IUrlClient-'></a>
### #ctor() `constructor`

##### Summary

Creates a new CookieSession where all requests are made using the provided IUrlClient

##### Parameters

This constructor has no parameters.

<a name='P-Bb-Http-CookieSession-Cookies'></a>
### Cookies `property`

##### Summary

The CookieJar used by all requests sent with this CookieSession.

<a name='M-Bb-Http-CookieSession-Dispose'></a>
### Dispose() `method`

##### Summary

Not necessary to call. IDisposable is implemented mainly for the syntactic sugar of using statements.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-CookieSession-Request-System-Object[]-'></a>
### Request(urlSegments) `method`

##### Summary

Creates a new IUrlRequest with this session's CookieJar that can be further built and sent fluently.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlSegments | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | The URL or URL segments for the request. |

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

<a name='M-Bb-Curls-CurlContext-CallAsync-Bb-Http-Configuration-IUrlClientFactory-'></a>
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

<a name='M-Bb-Curls-CurlInterpreter-CallAsync-System-Boolean,System-Threading-CancellationTokenSource-'></a>
### CallAsync(source,ensureSuccessStatusCode) `method`

##### Summary

Calls asynchronously.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| ensureSuccessStatusCode | [System.Threading.CancellationTokenSource](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationTokenSource 'System.Threading.CancellationTokenSource') | if true thrown an exception if the result of the call is not 2xx |

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

<a name='M-Bb-Curls-CurlParserExtension-CallToByteArray-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken-'></a>
### CallToByteArray(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to byte array.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-CallToByteArrayAsync-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken-'></a>
### CallToByteArrayAsync(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to byte array asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Curls.CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-CallToObjectAsync-Bb-Curls-CurlInterpreter,System-Type,System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken-'></a>
### CallToObjectAsync(self,type,ensureSuccessStatusCode,options,cancellationToken) `method`

##### Summary

Results to typed object asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Curls.CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') | The self. |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-CallToObjectAsync``1-Bb-Curls-CurlInterpreter,System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken-'></a>
### CallToObjectAsync\`\`1(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to typed object asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Curls.CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-CallToStream-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken-'></a>
### CallToStream(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to stream.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-CallToStreamAsync-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken-'></a>
### CallToStreamAsync(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to stream asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Curls.CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-CallToStringAsync-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken-'></a>
### CallToStringAsync(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to string asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Curls.CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

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

<a name='M-Bb-Curls-CurlParserExtension-ResultToByteArrayAsync-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken-'></a>
### ResultToByteArrayAsync(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to byte array asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToJson-Bb-Curls-CurlInterpreter,System-Threading-CancellationToken-'></a>
### ResultToJson(self,cancellationToken) `method`

##### Summary

Results to Json.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Curls.CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') | The self. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToJson-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken-'></a>
### ResultToJson(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to Json.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Curls.CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToJson-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken,System-Text-Json-JsonDocumentOptions-'></a>
### ResultToJson(self,ensureSuccessStatusCode,cancellationToken,options) `method`

##### Summary

Results to Json.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Curls.CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |
| options | [System.Text.Json.JsonDocumentOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonDocumentOptions 'System.Text.Json.JsonDocumentOptions') | [](#!-CJsonDocumentOptions 'CJsonDocumentOptions') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToJson-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Type,System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken-'></a>
### ResultToJson(self,type,ensureSuccessStatusCode,options,cancellationToken) `method`

##### Summary

Results to json asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}') | The self. |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToJsonAsync-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Type,System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken-'></a>
### ResultToJsonAsync(self,type,ensureSuccessStatusCode,options,cancellationToken) `method`

##### Summary

Results to json asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}') | The self. |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToJsonAsync``1-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken-'></a>
### ResultToJsonAsync\`\`1(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to json asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToJson``1-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken-'></a>
### ResultToJson\`\`1(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to json asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToObject``1-Bb-Curls-CurlInterpreter,System-Boolean,System-Text-Json-JsonSerializerOptions,System-Threading-CancellationToken-'></a>
### ResultToObject\`\`1(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to typed object asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Curls.CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToStream-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken-'></a>
### ResultToStream(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to stream.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Curls.CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToStreamAsync-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken-'></a>
### ResultToStreamAsync(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to stream asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToString-Bb-Curls-CurlInterpreter,System-Boolean,System-Threading-CancellationToken-'></a>
### ResultToString(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Curls.CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToString-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken-'></a>
### ResultToString(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='M-Bb-Curls-CurlParserExtension-ResultToStringAsync-System-Threading-Tasks-Task{System-Net-Http-HttpResponseMessage},System-Boolean,System-Threading-CancellationToken-'></a>
### ResultToStringAsync(self,ensureSuccessStatusCode,cancellationToken) `method`

##### Summary

Results to string asynchronous.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{System.Net.Http.HttpResponseMessage}') | The self. |
| ensureSuccessStatusCode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException'). |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | [CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | if the result is not between 200 and 299 |

<a name='T-Bb-Http-Configuration-DefaultJsonSerializer'></a>
## DefaultJsonSerializer `type`

##### Namespace

Bb.Http.Configuration

##### Summary

ISerializer implementation based on System.Text.Json.
Default serializer used in calls to GetJsonAsync, PostJsonAsync, etc.

<a name='M-Bb-Http-Configuration-DefaultJsonSerializer-#ctor-System-Text-Json-JsonSerializerOptions-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [DefaultJsonSerializer](#T-Bb-Http-Configuration-DefaultJsonSerializer 'Bb.Http.Configuration.DefaultJsonSerializer') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Options to control (de)serialization behavior. |

<a name='M-Bb-Http-Configuration-DefaultJsonSerializer-Deserializes``1-System-String-'></a>
### Deserializes\`\`1(s) `method`

##### Summary

Deserializes the specified JSON string to an object of type T.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The JSON string to deserializes. |

<a name='M-Bb-Http-Configuration-DefaultJsonSerializer-Deserializes``1-System-IO-Stream-'></a>
### Deserializes\`\`1(stream) `method`

##### Summary

Deserializes the specified stream to an object of type T.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | The stream to deserializes. |

<a name='M-Bb-Http-Configuration-DefaultJsonSerializer-Serialize-System-Object-'></a>
### Serialize(obj) `method`

##### Summary

Serializes the specified object to a JSON string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to serialize. |

<a name='T-Bb-Http-Configuration-DefaultUrlClientFactory'></a>
## DefaultUrlClientFactory `type`

##### Namespace

Bb.Http.Configuration

##### Summary

An IUrlClientFactory implementation that caches and reuses the same one instance of
UrlClient per combination of scheme, host, and port. This is the default
implementation used when calls are made fluently off Urls/strings.

<a name='M-Bb-Http-Configuration-DefaultUrlClientFactory-GetCacheKey-Bb-Url-'></a>
### GetCacheKey(url) `method`

##### Summary

Returns a unique cache key based on scheme, host, and port of the given URL.

##### Returns

The cache key

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | The URL. |

<a name='T-Bb-Http-Configuration-DefaultUrlEncodedSerializer'></a>
## DefaultUrlEncodedSerializer `type`

##### Namespace

Bb.Http.Configuration

##### Summary

ISerializer implementation that converts an object representing name/value pairs to a URL-encoded string.
Default serializer used in calls to PostUrlEncodedAsync, etc.

<a name='M-Bb-Http-Configuration-DefaultUrlEncodedSerializer-Deserializes``1-System-String-'></a>
### Deserializes\`\`1() `method`

##### Summary

Deserializing a URL-encoded string is not supported.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Configuration-DefaultUrlEncodedSerializer-Deserializes``1-System-IO-Stream-'></a>
### Deserializes\`\`1() `method`

##### Summary

Deserializing a URL-encoded string is not supported.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Configuration-DefaultUrlEncodedSerializer-Serialize-System-Object-'></a>
### Serialize() `method`

##### Summary

Serializes the specified object to a URL-encoded string.

##### Parameters

This method has no parameters.

<a name='T-Bb-Extensions-DownloadExtensions'></a>
## DownloadExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Fluent extension methods for downloading a file.

<a name='M-Bb-Extensions-DownloadExtensions-DownloadFileAsync-Bb-Http-IUrlRequest,System-String,System-String,System-Int32,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### DownloadFileAsync(request,localFolderPath,localFileName,bufferSize,completionOption,cancellationToken) `method`

##### Summary

Asynchronously downloads a file at the specified URL.

##### Returns

A Task whose result is the local path of the downloaded file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The Url request. |
| localFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path of local folder where file is to be downloaded. |
| localFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of local file. If not specified, the source filename (from Content-Dispostion header, or last segment of the URL) is used. |
| bufferSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Buffer size in bytes. Default is 4096. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='T-Bb-Http-FileUtil'></a>
## FileUtil `type`

##### Namespace

Bb.Http

<a name='M-Bb-Http-FileUtil-MakeValidName-System-String-'></a>
### MakeValidName() `method`

##### Summary

Replaces invalid path characters with underscores.

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-Testing-FilteredHttpTestSetup'></a>
## FilteredHttpTestSetup `type`

##### Namespace

Bb.Http.Testing

##### Summary

Represents a set of request conditions and fake responses for faking HTTP calls in tests.
Usually created fluently via HttpTest.ForCallsTo, rather than instantiated directly.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-#ctor-Bb-Http-Configuration-UrlHttpSettings,System-String[]-'></a>
### #ctor(settings,urlPatterns) `constructor`

##### Summary

Constructs a new instance of FilteredHttpTestSetup.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| settings | [Bb.Http.Configuration.UrlHttpSettings](#T-Bb-Http-Configuration-UrlHttpSettings 'Bb.Http.Configuration.UrlHttpSettings') | UrlHttpSettings used in fake calls. |
| urlPatterns | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | URL(s) or URL pattern(s) that this HttpTestSetup applies to. Can contain * wildcard. |

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-IsMatch-Bb-Http-UrlCall-'></a>
### IsMatch() `method`

##### Summary

Returns true if the given UrlCall matches one of the URL patterns and all other criteria defined for this HttpTestSetup.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-With-System-Func{Bb-Http-UrlCall,System-Boolean}-'></a>
### With() `method`

##### Summary

Defines a condition for which this HttpTestSetup applies.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithAnyQueryParam-System-String[]-'></a>
### WithAnyQueryParam() `method`

##### Summary

Defines query parameter names, ANY of which a call must contain in order for this HttpTestSetup to apply.
If no names are provided, call must contain at least one query parameter with any name.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithHeader-System-String,System-String-'></a>
### WithHeader() `method`

##### Summary

Defines a request header and (optionally) its value that a call must contain in order for this HttpTestSetup to apply.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithQueryParam-System-String,System-Object-'></a>
### WithQueryParam() `method`

##### Summary

Defines a query parameter and (optionally) its value that a call must contain in order for this HttpTestSetup to apply.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithQueryParam-System-String[]-'></a>
### WithQueryParam() `method`

##### Summary

Defines query parameter names, ALL of which a call must contain in order for this HttpTestSetup to apply.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithQueryParam-System-Object-'></a>
### WithQueryParam(values) `method`

##### Summary

Defines query parameters, ALL of which a call must contain in order for this HttpTestSetup to apply.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object (usually anonymous) or dictionary that is parsed to name/value query parameters to check for. Values may contain * wildcard. |

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithRequestBody-System-String-'></a>
### WithRequestBody() `method`

##### Summary

Defines a request body that must exist in order for this HttpTestSetup to apply.
The * wildcard can be used.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithRequestJson-System-Object-'></a>
### WithRequestJson() `method`

##### Summary

Defines an object that, when serialized to JSON, must match the request body in order for this HttpTestSetup to apply.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithVerb-System-Net-Http-HttpMethod[]-'></a>
### WithVerb() `method`

##### Summary

Defines one or more HTTP verbs, any of which a call must match in order for this HttpTestSetup to apply.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithVerb-System-String[]-'></a>
### WithVerb() `method`

##### Summary

Defines one or more HTTP verbs, any of which a call must match in order for this HttpTestSetup to apply.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-Without-System-Func{Bb-Http-UrlCall,System-Boolean}-'></a>
### Without() `method`

##### Summary

Defines a condition for which this HttpTestSetup does NOT apply.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithoutHeader-System-String,System-String-'></a>
### WithoutHeader() `method`

##### Summary

Defines a request header and (optionally) its value that a call must NOT contain in order for this HttpTestSetup to apply.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithoutQueryParam-System-String,System-Object-'></a>
### WithoutQueryParam() `method`

##### Summary

Defines a query parameter and (optionally) its value that a call must NOT contain in order for this HttpTestSetup to apply.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithoutQueryParam-System-String[]-'></a>
### WithoutQueryParam() `method`

##### Summary

Defines query parameter names, NONE of which a call must contain in order for this HttpTestSetup to apply.
If no names are provided, call must not contain any query parameters.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-FilteredHttpTestSetup-WithoutQueryParam-System-Object-'></a>
### WithoutQueryParam(values) `method`

##### Summary

Defines query parameters, NONE of which a call must contain in order for this HttpTestSetup to apply.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object (usually anonymous) or dictionary that is parsed to name/value query parameters to check for. Values may contain * wildcard. |

<a name='T-Bb-Http-Configuration-GlobalUrlHttpSettings'></a>
## GlobalUrlHttpSettings `type`

##### Namespace

Bb.Http.Configuration

##### Summary

Global default settings for Uurl.Http

<a name='P-Bb-Http-Configuration-GlobalUrlHttpSettings-Defaults'></a>
### Defaults `property`

##### Summary

Defaults at the global level do not make sense and will always be null.

<a name='P-Bb-Http-Configuration-GlobalUrlHttpSettings-UrlClientFactory'></a>
### UrlClientFactory `property`

##### Summary

Gets or sets the factory that defines creating, caching, and reusing UrlClient instances and,
by proxy, HttpClient instances.

<a name='M-Bb-Http-Configuration-GlobalUrlHttpSettings-ResetDefaults'></a>
### ResetDefaults() `method`

##### Summary

Resets all global settings to their default values.

##### Parameters

This method has no parameters.

<a name='T-Bb-Extensions-HeaderExtensions'></a>
## HeaderExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Fluent extension methods for working with HTTP request headers.

<a name='M-Bb-Extensions-HeaderExtensions-WithBasicAuth``1-``0,System-String,System-String-'></a>
### WithBasicAuth\`\`1(clientOrRequest,userName,password) `method`

##### Summary

Sets HTTP authorization header according to Basic Authentication protocol to be sent with this IUrlRequest or all requests made with this IUrlClient.

##### Returns

This IUrlClient or IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientOrRequest | [\`\`0](#T-``0 '``0') | The IUrlClient or IUrlRequest. |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User name of authenticating user. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Password of authenticating user. |

<a name='M-Bb-Extensions-HeaderExtensions-WithHeader``1-``0,System-String,System-Object-'></a>
### WithHeader\`\`1(clientOrRequest,name,value) `method`

##### Summary

Sets an HTTP header to be sent with this IUrlRequest or all requests made with this IUrlClient.

##### Returns

This IUrlClient or IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientOrRequest | [\`\`0](#T-``0 '``0') | The IUrlClient or IUrlRequest. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | HTTP header name. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | HTTP header value. |

<a name='M-Bb-Extensions-HeaderExtensions-WithHeader``1-``0,System-String,Bb-Http-ContentType-'></a>
### WithHeader\`\`1(clientOrRequest,name,value) `method`

##### Summary

Sets an HTTP header to be sent with this IUrlRequest or all requests made with this IUrlClient.

##### Returns

This IUrlClient or IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientOrRequest | [\`\`0](#T-``0 '``0') | The IUrlClient or IUrlRequest. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | HTTP header name. |
| value | [Bb.Http.ContentType](#T-Bb-Http-ContentType 'Bb.Http.ContentType') | HTTP header value. |

<a name='M-Bb-Extensions-HeaderExtensions-WithHeaders``1-``0,System-Object,System-Boolean-'></a>
### WithHeaders\`\`1(clientOrRequest,headers,replaceUnderscoreWithHyphen) `method`

##### Summary

Sets HTTP headers based on property names/values of the provided object, or keys/values if object is a dictionary, to be sent with this IUrlRequest or all requests made with this IUrlClient.

##### Returns

This IUrlClient or IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientOrRequest | [\`\`0](#T-``0 '``0') | The IUrlClient or IUrlRequest. |
| headers | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Names/values of HTTP headers to set. Typically an anonymous object or IDictionary. |
| replaceUnderscoreWithHyphen | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, underscores in property names will be replaced by hyphens. Default is true. |

<a name='M-Bb-Extensions-HeaderExtensions-WithOAuthBearerToken``1-``0,System-String-'></a>
### WithOAuthBearerToken\`\`1(clientOrRequest,token) `method`

##### Summary

Sets HTTP authorization header with acquired bearer token according to OAuth 2.0 specification to be sent with this IUrlRequest or all requests made with this IUrlClient.

##### Returns

This IUrlClient or IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| clientOrRequest | [\`\`0](#T-``0 '``0') | The IUrlClient or IUrlRequest. |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The acquired bearer token to pass. |

<a name='T-Bb-Http-Testing-HttpCallAssertion'></a>
## HttpCallAssertion `type`

##### Namespace

Bb.Http.Testing

##### Summary

Provides fluent helpers for asserting against fake HTTP calls. Usually created fluently
via HttpTest.ShouldHaveCalled or HttpTest.ShouldNotHaveCalled, rather than instantiated directly.

<a name='M-Bb-Http-Testing-HttpCallAssertion-#ctor-System-Collections-Generic-IEnumerable{Bb-Http-UrlCall},System-Boolean-'></a>
### #ctor(loggedCalls,negate) `constructor`

##### Summary

Constructs a new instance of HttpCallAssertion.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| loggedCalls | [System.Collections.Generic.IEnumerable{Bb.Http.UrlCall}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Bb.Http.UrlCall}') | Set of calls (usually from HttpTest.CallLog) to assert against. |
| negate | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, assertions pass when calls matching criteria were NOT made. |

<a name='M-Bb-Http-Testing-HttpCallAssertion-Times-System-Int32-'></a>
### Times(expectedCount) `method`

##### Summary

Assert whether calls matching specified criteria were made a specific number of times. (When not specified,
assertions verify whether any calls matching criteria were made.)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expectedCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Exact number of expected calls |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | `expectedCount` must be greater than or equal to 0. |

<a name='M-Bb-Http-Testing-HttpCallAssertion-With-System-Func{Bb-Http-UrlCall,System-Boolean},System-String-'></a>
### With(match,descrip) `method`

##### Summary

Asserts whether calls were made matching the given predicate function.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| match | [System.Func{Bb.Http.UrlCall,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Bb.Http.UrlCall,System.Boolean}') | Predicate (usually a lambda expression) that tests a UrlCall and returns a bool. |
| descrip | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A description of what is being asserted. |

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithAnyCookie-System-String[]-'></a>
### WithAnyCookie() `method`

##### Summary

Asserts whether calls were made containing ANY the given cookies (regardless of their values).
If no names are provided, asserts that calls were made containing at least one cookie with any name.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithAnyHeader-System-String[]-'></a>
### WithAnyHeader() `method`

##### Summary

Asserts whether calls were made containing ANY the given headers (regardless of their values).
If no names are provided, asserts that calls were made containing at least one header with any name.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithAnyQueryParam-System-String[]-'></a>
### WithAnyQueryParam() `method`

##### Summary

Asserts whether calls were made containing ANY the given query parameters (regardless of their values).
If no names are provided, asserts that calls were made containing at least one query parameter with any name.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithBasicAuth-System-String,System-String-'></a>
### WithBasicAuth() `method`

##### Summary

Asserts whether the Authorization header was set with Basic auth and (optionally) the given credentials.
Username and password can contain * wildcard.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithContentType-System-String-'></a>
### WithContentType() `method`

##### Summary

Asserts whether calls were made with a request body of the given content (MIME) type.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithCookie-System-String,System-Object-'></a>
### WithCookie() `method`

##### Summary

Asserts whether calls were made containing the given cookie name and (optionally) value. value may contain * wildcard.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithCookies-System-String[]-'></a>
### WithCookies() `method`

##### Summary

Asserts whether calls were made containing ALL the given cookies (regardless of their values).

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithCookies-System-Object-'></a>
### WithCookies(values) `method`

##### Summary

Asserts whether calls were made containing all of the given cookie values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object (usually anonymous) or dictionary that is parsed to name/value cookies to check for. Values may contain * wildcard. |

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithHeader-System-String,System-Object-'></a>
### WithHeader() `method`

##### Summary

Asserts whether calls were made containing the given header name and (optionally) value. value may contain * wildcard.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithHeaders-System-String[]-'></a>
### WithHeaders() `method`

##### Summary

Asserts whether calls were made containing ALL the given headers (regardless of their values).

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithHeaders-System-Object-'></a>
### WithHeaders(values) `method`

##### Summary

Asserts whether calls were made containing all of the given header values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object (usually anonymous) or dictionary that is parsed to name/value headers to check for. Values may contain * wildcard. |

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithOAuthBearerToken-System-String-'></a>
### WithOAuthBearerToken() `method`

##### Summary

Asserts whether an Authorization header was set with the given Bearer token, or any Bearer token if excluded.
Token can contain * wildcard.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithQueryParam-System-String,System-Object-'></a>
### WithQueryParam() `method`

##### Summary

Asserts whether calls were made containing the given query parameter name and (optionally) value. value may contain * wildcard.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithQueryParam-System-String[]-'></a>
### WithQueryParam() `method`

##### Summary

Asserts whether calls were made containing ALL the given query parameters (regardless of their values).

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithQueryParam-System-Object-'></a>
### WithQueryParam(values) `method`

##### Summary

Asserts whether calls were made containing all of the given query parameter values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object (usually anonymous) or dictionary that is parsed to name/value query parameters to check for. Values may contain * wildcard. |

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithRequestBody-System-String-'></a>
### WithRequestBody() `method`

##### Summary

Asserts whether calls were made containing given request body. body may contain * wildcard.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithRequestJson-System-Object-'></a>
### WithRequestJson() `method`

##### Summary

Asserts whether calls were made containing given JSON-encoded request body. body may contain * wildcard.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithRequestUrlEncoded-System-Object-'></a>
### WithRequestUrlEncoded() `method`

##### Summary

Asserts whether calls were made containing given URL-encoded request body. body may contain * wildcard.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithUrlPattern-System-String-'></a>
### WithUrlPattern(urlPattern) `method`

##### Summary

Asserts whether calls were made matching given URL or URL pattern.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlPattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Can contain * wildcard. |

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithVerb-System-Net-Http-HttpMethod[]-'></a>
### WithVerb() `method`

##### Summary

Asserts whether calls were made with any of the given HTTP verbs.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithVerb-System-String[]-'></a>
### WithVerb() `method`

##### Summary

Asserts whether calls were made with any of the given HTTP verbs.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-Without-System-Func{Bb-Http-UrlCall,System-Boolean},System-String-'></a>
### Without(match,descrip) `method`

##### Summary

Asserts whether calls were made that do NOT match the given predicate function.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| match | [System.Func{Bb.Http.UrlCall,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Bb.Http.UrlCall,System.Boolean}') | Predicate (usually a lambda expression) that tests a UrlCall and returns a bool. |
| descrip | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A description of what is being asserted. |

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithoutCookie-System-String,System-Object-'></a>
### WithoutCookie() `method`

##### Summary

Asserts whether calls were made NOT containing the given cookie and (optionally) value. value may contain * wildcard.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithoutCookies-System-String[]-'></a>
### WithoutCookies() `method`

##### Summary

Asserts whether calls were made NOT containing any of the given cookies.
If no names are provided, asserts no calls were made with any cookies.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithoutCookies-System-Object-'></a>
### WithoutCookies(values) `method`

##### Summary

Asserts whether calls were made NOT containing any of the given cookie values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object (usually anonymous) or dictionary that is parsed to name/value cookies to check for. Values may contain * wildcard. |

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithoutHeader-System-String,System-Object-'></a>
### WithoutHeader() `method`

##### Summary

Asserts whether calls were made NOT containing the given header and (optionally) value. value may contain * wildcard.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithoutHeaders-System-String[]-'></a>
### WithoutHeaders() `method`

##### Summary

Asserts whether calls were made NOT containing any of the given headers.
If no names are provided, asserts no calls were made with any headers.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithoutHeaders-System-Object-'></a>
### WithoutHeaders(values) `method`

##### Summary

Asserts whether calls were made NOT containing any of the given header values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object (usually anonymous) or dictionary that is parsed to name/value headers to check for. Values may contain * wildcard. |

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithoutQueryParam-System-String,System-Object-'></a>
### WithoutQueryParam() `method`

##### Summary

Asserts whether calls were made NOT containing the given query parameter and (optionally) value. value may contain * wildcard.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithoutQueryParam-System-String[]-'></a>
### WithoutQueryParam() `method`

##### Summary

Asserts whether calls were made NOT containing any of the given query parameters.
If no names are provided, asserts no calls were made with any query parameters.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpCallAssertion-WithoutQueryParam-System-Object-'></a>
### WithoutQueryParam(values) `method`

##### Summary

Asserts whether calls were made NOT containing any of the given query parameter values.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Object (usually anonymous) or dictionary that is parsed to name/value query parameters to check for. Values may contain * wildcard. |

<a name='T-Bb-Extensions-HttpMessageExtensions-HttpMessage'></a>
## HttpMessage `type`

##### Namespace

Bb.Extensions.HttpMessageExtensions

##### Summary

Wrapper class for treating HttpRequestMessage and HttpResponseMessage uniformly. (Unfortunately they don't have a common interface.)

<a name='T-Bb-Extensions-HttpMessageExtensions'></a>
## HttpMessageExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Extension methods off HttpRequestMessage and HttpResponseMessage.

<a name='M-Bb-Extensions-HttpMessageExtensions-SetHeader-System-Net-Http-HttpRequestMessage,System-String,System-Object,System-Boolean-'></a>
### SetHeader(request,name,value,createContentIfNecessary) `method`

##### Summary

Set a header on this HttpRequestMessage (default), or its Content property if it's a known content-level header.
No validation. Overwrites any existing value(s) for the header.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [System.Net.Http.HttpRequestMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestMessage 'System.Net.Http.HttpRequestMessage') | The HttpRequestMessage. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The header name. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The header value. |
| createContentIfNecessary | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If it's a content-level header and there is no content, this determines whether to create an empty HttpContent or just ignore the header. |

<a name='M-Bb-Extensions-HttpMessageExtensions-SetHeader-System-Net-Http-HttpResponseMessage,System-String,System-Object,System-Boolean-'></a>
### SetHeader(response,name,value,createContentIfNecessary) `method`

##### Summary

Set a header on this HttpResponseMessage (default), or its Content property if it's a known content-level header.
No validation. Overwrites any existing value(s) for the header.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [System.Net.Http.HttpResponseMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpResponseMessage 'System.Net.Http.HttpResponseMessage') | The HttpResponseMessage. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The header name. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The header value. |
| createContentIfNecessary | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If it's a content-level header and there is no content, this determines whether to create an empty HttpContent or just ignore the header. |

<a name='T-Bb-Http-HttpStatusRangeParser'></a>
## HttpStatusRangeParser `type`

##### Namespace

Bb.Http

##### Summary

The status range parser class.

<a name='M-Bb-Http-HttpStatusRangeParser-IsMatch-System-String,System-Net-HttpStatusCode-'></a>
### IsMatch(pattern,value) `method`

##### Summary

Determines whether the specified pattern is match.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The pattern. |
| value | [System.Net.HttpStatusCode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.HttpStatusCode 'System.Net.HttpStatusCode') | The value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | pattern is invalid. |

<a name='M-Bb-Http-HttpStatusRangeParser-IsMatch-System-String,System-Int32-'></a>
### IsMatch(pattern,value) `method`

##### Summary

Determines whether the specified pattern is match.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The pattern. |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | `pattern` is invalid. |

<a name='T-Bb-Http-Testing-HttpTest'></a>
## HttpTest `type`

##### Namespace

Bb.Http.Testing

##### Summary

An object whose existence puts Url.Http into test mode where actual HTTP calls are faked. Provides a response
queue, call log, and assertion helpers for use in Arrange/Act/Assert style tests.

<a name='M-Bb-Http-Testing-HttpTest-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [HttpTest](#T-Bb-Http-Testing-HttpTest 'Bb.Http.Testing.HttpTest') class.

##### Parameters

This constructor has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | A delegate callback throws an exception. |

<a name='P-Bb-Http-Testing-HttpTest-CallLog'></a>
### CallLog `property`

##### Summary

List of all (fake) HTTP calls made since this HttpTest was created.

<a name='P-Bb-Http-Testing-HttpTest-Current'></a>
### Current `property`

##### Summary

Gets the current HttpTest from the logical (async) call context

<a name='M-Bb-Http-Testing-HttpTest-Configure-System-Action{Bb-Http-Configuration-UrlHttpSettings}-'></a>
### Configure(action) `method`

##### Summary

Change UrlHttpSettings for the scope of this HttpTest.

##### Returns

This HttpTest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| action | [System.Action{Bb.Http.Configuration.UrlHttpSettings}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.Configuration.UrlHttpSettings}') | Action defining the settings changes. |

<a name='M-Bb-Http-Testing-HttpTest-Dispose'></a>
### Dispose() `method`

##### Summary

Releases unmanaged and - optionally - managed resources.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpTest-ForCallsTo-System-String[]-'></a>
### ForCallsTo() `method`

##### Summary

Fluently creates and returns a new request-specific test setup.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpTest-ShouldHaveCalled-System-String-'></a>
### ShouldHaveCalled(urlPattern) `method`

##### Summary

Asserts whether matching URL was called, throwing HttpCallAssertException if it wasn't.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlPattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | URL that should have been called. Can include * wildcard character. |

<a name='M-Bb-Http-Testing-HttpTest-ShouldHaveMadeACall'></a>
### ShouldHaveMadeACall() `method`

##### Summary

Asserts whether any HTTP call was made, throwing HttpCallAssertException if none were.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpTest-ShouldNotHaveCalled-System-String-'></a>
### ShouldNotHaveCalled(urlPattern) `method`

##### Summary

Asserts whether matching URL was NOT called, throwing HttpCallAssertException if it was.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlPattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | URL that should not have been called. Can include * wildcard character. |

<a name='M-Bb-Http-Testing-HttpTest-ShouldNotHaveMadeACall'></a>
### ShouldNotHaveMadeACall() `method`

##### Summary

Asserts whether no HTTP calls were made, throwing HttpCallAssertException if any were.

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-Testing-HttpTestException'></a>
## HttpTestException `type`

##### Namespace

Bb.Http.Testing

##### Summary

An exception thrown by HttpTest's assertion methods to indicate that the assertion failed.

<a name='M-Bb-Http-Testing-HttpTestException-#ctor-System-Collections-Generic-IList{System-String},System-Nullable{System-Int32},System-Int32-'></a>
### #ctor(conditions,expectedCalls,actualCalls) `constructor`

##### Summary

Initializes a new instance of the [HttpTestException](#T-Bb-Http-Testing-HttpTestException 'Bb.Http.Testing.HttpTestException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| conditions | [System.Collections.Generic.IList{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.String}') | The expected call conditions. |
| expectedCalls | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | The expected number of calls. |
| actualCalls | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The actual number calls. |

<a name='T-Bb-Http-Testing-HttpTestSetup'></a>
## HttpTestSetup `type`

##### Namespace

Bb.Http.Testing

##### Summary

Abstract base class class for HttpTest and FilteredHttpTestSetup. Provides fluent methods for building queue of fake responses.

<a name='M-Bb-Http-Testing-HttpTestSetup-#ctor-Bb-Http-Configuration-UrlHttpSettings-'></a>
### #ctor(settings) `constructor`

##### Summary

Constructs a new instance of HttpTestSetup.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| settings | [Bb.Http.Configuration.UrlHttpSettings](#T-Bb-Http-Configuration-UrlHttpSettings 'Bb.Http.Configuration.UrlHttpSettings') | UrlHttpSettings used in fake calls. |

<a name='P-Bb-Http-Testing-HttpTestSetup-Settings'></a>
### Settings `property`

##### Summary

The UrlHttpSettings used in fake calls.

<a name='M-Bb-Http-Testing-HttpTestSetup-AllowRealHttp'></a>
### AllowRealHttp() `method`

##### Summary

Do NOT fake requests for this setup. Typically called on a filtered setup, i.e. HttpTest.ForCallsTo(urlPattern).AllowRealHttp();

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-HttpTestSetup-RespondWith-System-String,System-Int32,System-Object,System-Object,System-Boolean-'></a>
### RespondWith(body,status,headers,cookies,replaceUnderscoreWithHyphen) `method`

##### Summary

Adds a fake HTTP response to the response queue.

##### Returns

The current HttpTest object (so more responses can be chained).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The simulated response body string. |
| status | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The simulated HTTP status. Default is 200. |
| headers | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The simulated response headers (optional). |
| cookies | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The simulated response cookies (optional). |
| replaceUnderscoreWithHyphen | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, underscores in property names of headers will be replaced by hyphens. Default is true. |

<a name='M-Bb-Http-Testing-HttpTestSetup-RespondWith-System-Func{System-Net-Http-HttpContent},System-Int32,System-Object,System-Object,System-Boolean-'></a>
### RespondWith(buildContent,status,headers,cookies,replaceUnderscoreWithHyphen) `method`

##### Summary

Adds a fake HTTP response to the response queue.

##### Returns

The current HttpTest object (so more responses can be chained).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| buildContent | [System.Func{System.Net.Http.HttpContent}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Net.Http.HttpContent}') | A function that builds the simulated response body content. Optional. |
| status | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The simulated HTTP status. Optional. Default is 200. |
| headers | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The simulated response headers. Optional. |
| cookies | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The simulated response cookies. Optional. |
| replaceUnderscoreWithHyphen | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, underscores in property names of headers will be replaced by hyphens. Default is true. |

<a name='M-Bb-Http-Testing-HttpTestSetup-RespondWithJson-System-Object,System-Int32,System-Object,System-Object,System-Boolean-'></a>
### RespondWithJson(body,status,headers,cookies,replaceUnderscoreWithHyphen) `method`

##### Summary

Adds a fake HTTP response to the response queue with the given data serialized to JSON as the content body.

##### Returns

The current HttpTest object (so more responses can be chained).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to be JSON-serialized and used as the simulated response body. |
| status | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The simulated HTTP status. Default is 200. |
| headers | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The simulated response headers (optional). |
| cookies | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The simulated response cookies (optional). |
| replaceUnderscoreWithHyphen | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, underscores in property names of headers will be replaced by hyphens. Default is true. |

<a name='M-Bb-Http-Testing-HttpTestSetup-SimulateException-System-Exception-'></a>
### SimulateException(exception) `method`

##### Summary

Adds the throwing of an exception to the response queue.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The exception to throw when the call is simulated. |

<a name='M-Bb-Http-Testing-HttpTestSetup-SimulateTimeout'></a>
### SimulateTimeout() `method`

##### Summary

Adds a simulated timeout response to the response queue.

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-IHttpSettingsContainer'></a>
## IHttpSettingsContainer `type`

##### Namespace

Bb.Http

##### Summary

Defines state full aspects (headers, cookies, etc) common to both IUrlClient and IUrlRequest

<a name='P-Bb-Http-IHttpSettingsContainer-Headers'></a>
### Headers `property`

##### Summary

Collection of headers sent on this request or all requests using this client.

<a name='P-Bb-Http-IHttpSettingsContainer-Settings'></a>
### Settings `property`

##### Summary

Gets the UrlHttpSettings object used by this client or request.

<a name='T-Bb-Util-INameValueListBase`1'></a>
## INameValueListBase\`1 `type`

##### Namespace

Bb.Util

##### Summary

Defines common methods for INameValueList and IReadOnlyNameValueList.

<a name='M-Bb-Util-INameValueListBase`1-Contains-System-String-'></a>
### Contains() `method`

##### Summary

True if any items with the given Name exist.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-INameValueListBase`1-Contains-System-String,`0-'></a>
### Contains() `method`

##### Summary

True if any item with the given Name and Value exists.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-INameValueListBase`1-FirstOrDefault-System-String-'></a>
### FirstOrDefault() `method`

##### Summary

Returns the first Value of the given Name if one exists, otherwise null or default value.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-INameValueListBase`1-GetAll-System-String-'></a>
### GetAll() `method`

##### Summary

Gets all Values of the given Name.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-INameValueListBase`1-TryGetFirst-System-String,`0@-'></a>
### TryGetFirst() `method`

##### Summary

Gets the first Value of the given Name, if one exists.

##### Returns

true if any item of the given name is found, otherwise false.

##### Parameters

This method has no parameters.

<a name='T-Bb-Util-INameValueList`1'></a>
## INameValueList\`1 `type`

##### Namespace

Bb.Util

##### Summary

Defines an ordered collection of Name/Value pairs where duplicate names are allowed but aren't typical.

<a name='M-Bb-Util-INameValueList`1-Add-System-String,`0-'></a>
### Add() `method`

##### Summary

Adds a new Name/Value pair.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-INameValueList`1-AddOrReplace-System-String,`0-'></a>
### AddOrReplace() `method`

##### Summary

Replaces the first occurrence of the given Name with the given Value and removes any others,
or adds a new Name/Value pair if none exist.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-INameValueList`1-Remove-System-String-'></a>
### Remove() `method`

##### Summary

Removes all items of the given Name.

##### Returns

true if any item of the given name is found, otherwise false.

##### Parameters

This method has no parameters.

<a name='T-Bb-Util-IReadOnlyNameValueList`1'></a>
## IReadOnlyNameValueList\`1 `type`

##### Namespace

Bb.Util

##### Summary

Defines a read-only ordered collection of Name/Value pairs where duplicate names are allowed but aren't typical.

<a name='T-Bb-Http-Configuration-ISerializer'></a>
## ISerializer `type`

##### Namespace

Bb.Http.Configuration

##### Summary

Contract for serializing and deserializes objects.

<a name='M-Bb-Http-Configuration-ISerializer-Deserializes``1-System-String-'></a>
### Deserializes\`\`1() `method`

##### Summary

Deserializes an object from a string representation.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Configuration-ISerializer-Deserializes``1-System-IO-Stream-'></a>
### Deserializes\`\`1() `method`

##### Summary

Deserializes an object from a stream representation.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Configuration-ISerializer-Serialize-System-Object-'></a>
### Serialize() `method`

##### Summary

Serializes an object to a string representation.

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-IUrlClient'></a>
## IUrlClient `type`

##### Namespace

Bb.Http

##### Summary

Interface defining UrlClient's contract (useful for mocking and DI)

<a name='P-Bb-Http-IUrlClient-BaseUrl'></a>
### BaseUrl `property`

##### Summary

Gets or sets the base URL used for all calls made with this client.

<a name='P-Bb-Http-IUrlClient-HttpClient'></a>
### HttpClient `property`

##### Summary

Gets the HttpClient to be used in subsequent HTTP calls. Creation (when necessary) is delegated
to UrlHttp.UrlClientFactory. Reused for the life of the UrlClient.

<a name='P-Bb-Http-IUrlClient-IsDisposed'></a>
### IsDisposed `property`

##### Summary

Gets a value indicating whether this instance (and its underlying HttpClient) has been disposed.

<a name='M-Bb-Http-IUrlClient-Request-System-Object[]-'></a>
### Request(urlSegments) `method`

##### Summary

Creates a new IUrlRequest that can be further built and sent fluently.

##### Returns

A new IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urlSegments | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | The URL or URL segments for the request. If BaseUrl is defined, it is assumed that these are path segments off that base. |

<a name='M-Bb-Http-IUrlClient-SendAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendAsync(request,cancellationToken,completionOption) `method`

##### Summary

Asynchronously sends an HTTP request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest to send. |
| cancellationToken | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The token to monitor for cancellation requests. |
| completionOption | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The HttpCompletionOption used in the request. Optional. |

<a name='T-Bb-Http-Configuration-IUrlClientFactory'></a>
## IUrlClientFactory `type`

##### Namespace

Bb.Http.Configuration

##### Summary

Interface for defining a strategy for creating, caching, and reusing IUrlClient instances and
their underlying HttpClient instances. It is generally preferable to derive from UurlClientFactoryBase
and only override methods as needed, rather than implementing this interface from scratch.

<a name='M-Bb-Http-Configuration-IUrlClientFactory-CreateHttpClient-System-Net-Http-HttpMessageHandler-'></a>
### CreateHttpClient(handler) `method`

##### Summary

Defines how HttpClient should be instantiated and configured by default. Do NOT attempt
to cache/reuse HttpClient instances here - that should be done at the UrlClient level
via a custom UrlClientFactory that gets registered globally.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| handler | [System.Net.Http.HttpMessageHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMessageHandler 'System.Net.Http.HttpMessageHandler') | The HttpMessageHandler used to construct the HttpClient. |

<a name='M-Bb-Http-Configuration-IUrlClientFactory-CreateMessageHandler'></a>
### CreateMessageHandler() `method`

##### Summary

Defines how the HttpMessageHandler used by HttpClients that are created by
this factory should be instantiated and configured.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Configuration-IUrlClientFactory-Get-Bb-Url-'></a>
### Get(url) `method`

##### Summary

Strategy to create a UrlClient or reuse an existing one, based on the URL being called.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | The URL being called. |

<a name='T-Bb-Extensions-IUrlExtensions'></a>
## IUrlExtensions `type`

##### Namespace

Bb.Extensions

<a name='M-Bb-Extensions-IUrlExtensions-AllowAnyHttpStatus-Bb-Url-'></a>
### AllowAnyHttpStatus(url) `method`

##### Summary

Creates a new UrlRequest and configures it to allow any returned HTTP status without throwing a UrlHttpException.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |

<a name='M-Bb-Extensions-IUrlExtensions-AllowAnyHttpStatus-System-String-'></a>
### AllowAnyHttpStatus(url) `method`

##### Summary

Creates a new UrlRequest and configures it to allow any returned HTTP status without throwing a UrlHttpException.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Extensions-IUrlExtensions-AllowHttpStatus-Bb-Url,System-String-'></a>
### AllowHttpStatus(url,pattern) `method`

##### Summary

Creates a new UrlRequest and adds a pattern representing an HTTP status code or range of codes which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Examples: "3xx", "100,300,600", "100-299,6xx" |

<a name='M-Bb-Extensions-IUrlExtensions-AllowHttpStatus-Bb-Url,System-Net-HttpStatusCode[]-'></a>
### AllowHttpStatus(url,statusCodes) `method`

##### Summary

Creates a new UrlRequest and adds an HttpStatusCode which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| statusCodes | [System.Net.HttpStatusCode[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.HttpStatusCode[] 'System.Net.HttpStatusCode[]') | The HttpStatusCode(s) to allow. |

<a name='M-Bb-Extensions-IUrlExtensions-AllowHttpStatus-System-String,System-String-'></a>
### AllowHttpStatus(url,pattern) `method`

##### Summary

Creates a new UrlRequest and adds a pattern representing an HTTP status code or range of codes which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Examples: "3xx", "100,300,600", "100-299,6xx" |

<a name='M-Bb-Extensions-IUrlExtensions-AllowHttpStatus-System-String,System-Net-HttpStatusCode[]-'></a>
### AllowHttpStatus(url,statusCodes) `method`

##### Summary

Creates a new UrlRequest and adds an HttpStatusCode which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| statusCodes | [System.Net.HttpStatusCode[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.HttpStatusCode[] 'System.Net.HttpStatusCode[]') | The HttpStatusCode(s) to allow. |

<a name='M-Bb-Extensions-IUrlExtensions-ConfigureRequest-Bb-Url,System-Action{Bb-Http-IUrlRequest}-'></a>
### ConfigureRequest(url,action) `method`

##### Summary

Creates a new UrlRequest and allows changing its Settings inline.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| action | [System.Action{Bb.Http.IUrlRequest}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.IUrlRequest}') | A delegate defining the Settings changes. |

<a name='M-Bb-Extensions-IUrlExtensions-ConfigureRequest-System-String,System-Action{Bb-Http-IUrlRequest}-'></a>
### ConfigureRequest(url,action) `method`

##### Summary

Creates a new UrlRequest and allows changing its Settings inline.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| action | [System.Action{Bb.Http.IUrlRequest}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.IUrlRequest}') | A delegate defining the Settings changes. |

<a name='M-Bb-Extensions-IUrlExtensions-DeleteAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### DeleteAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous DELETE request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-DeleteAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### DeleteAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous DELETE request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-DownloadFileAsync-Bb-Url,System-String,System-String,System-Int32,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### DownloadFileAsync(url,localFolderPath,localFileName,bufferSize,completionOption,cancellationToken) `method`

##### Summary

Creates a new UrlRequest and asynchronously downloads a file.

##### Returns

A Task whose result is the local path of the downloaded file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| localFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path of local folder where file is to be downloaded. |
| localFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of local file. If not specified, the source filename (last segment of the URL) is used. |
| bufferSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Buffer size in bytes. Default is 4096. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-DownloadFileAsync-System-String,System-String,System-String,System-Int32,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### DownloadFileAsync(url,localFolderPath,localFileName,bufferSize,completionOption,cancellationToken) `method`

##### Summary

Creates a new UrlRequest and asynchronously downloads a file.

##### Returns

A Task whose result is the local path of the downloaded file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| localFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path of local folder where file is to be downloaded. |
| localFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of local file. If not specified, the source filename (last segment of the URL) is used. |
| bufferSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Buffer size in bytes. Default is 4096. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-GetAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-GetBytesAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetBytesAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a byte array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-GetObjectAsync``1-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetObjectAsync\`\`1(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the JSON response body deserialized to an object of type T.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-GetStreamAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetStreamAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a Stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-GetStringAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetStringAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-HeadAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### HeadAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous HEAD request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-HeadAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### HeadAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous HEAD request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-OptionsAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### OptionsAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous OPTIONS request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-OptionsAsync-System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### OptionsAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous OPTIONS request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PatchAsync-System-String,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchAsync(url,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PatchJsonAsync-System-String,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchJsonAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PatchStringAsync-System-String,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchStringAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PostAsync-System-String,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostAsync(url,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PostJsonAsync-System-String,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostJsonAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PostMultipartAsync-Bb-Url,System-Action{System-Net-Http-MultipartFormDataContent},System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostMultipartAsync(url,buildContent,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous multipart/form-data POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| buildContent | [System.Action{System.Net.Http.MultipartFormDataContent}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.MultipartFormDataContent}') | A delegate for building the content parts. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PostMultipartAsync-System-String,System-Action{System-Net-Http-MultipartFormDataContent},System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostMultipartAsync(url,buildContent,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous multipart/form-data POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| buildContent | [System.Action{System.Net.Http.MultipartFormDataContent}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.MultipartFormDataContent}') | A delegate for building the content parts. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PostStringAsync-System-String,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostStringAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PostUrlEncodedAsync-System-String,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostUrlEncodedAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to a URL-encoded string. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PutAsync-System-String,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutAsync(url,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PutJsonAsync-System-String,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutJsonAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-PutStringAsync-System-String,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutStringAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-Request-Bb-Url-'></a>
### Request(url) `method`

##### Summary

Initializes a new instance of the [UrlRequest](#T-Bb-Http-UrlRequest 'Bb.Http.UrlRequest') class.

##### Returns

[UrlRequest](#T-Bb-Http-UrlRequest 'Bb.Http.UrlRequest')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | The URL. |

<a name='M-Bb-Extensions-IUrlExtensions-SendAsync-System-String,System-Net-Http-HttpMethod,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendAsync(url,verb,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-SendJsonAsync-System-String,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendJsonAsync(url,verb,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-SendStringAsync-System-String,System-Net-Http-HttpMethod,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendStringAsync(url,verb,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-SendUrlEncodedAsync-System-String,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendUrlEncodedAsync(url,verb,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to a URL-encoded string. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlExtensions-WithAutoRedirect-Bb-Url,System-Boolean-'></a>
### WithAutoRedirect(url,enabled) `method`

##### Summary

Creates a new UrlRequest and configures whether redirects are automatically followed.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| enabled | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if url should automatically send a new request to the redirect URL, false if it should not. |

<a name='M-Bb-Extensions-IUrlExtensions-WithAutoRedirect-System-String,System-Boolean-'></a>
### WithAutoRedirect(url,enabled) `method`

##### Summary

Creates a new UrlRequest and configures whether redirects are automatically followed.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| enabled | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if url should automatically send a new request to the redirect URL, false if it should not. |

<a name='M-Bb-Extensions-IUrlExtensions-WithBasicAuth-Bb-Url,System-String,System-String-'></a>
### WithBasicAuth(url,userName,password) `method`

##### Summary

Creates a new UrlRequest and sets the Authorization header according to Basic Authentication protocol.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User name of authenticating user. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Password of authenticating user. |

<a name='M-Bb-Extensions-IUrlExtensions-WithBasicAuth-System-String,System-String,System-String-'></a>
### WithBasicAuth(url,userName,password) `method`

##### Summary

Creates a new UrlRequest and sets the Authorization header according to Basic Authentication protocol.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User name of authenticating user. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Password of authenticating user. |

<a name='M-Bb-Extensions-IUrlExtensions-WithContentType-Bb-Url,Bb-Http-ContentType-'></a>
### WithContentType(url,contentType) `method`

##### Summary

Creates a new UrlRequest and sets request headers based on property names/values of the provided object, or keys/values if object is a dictionary, to be sent.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| contentType | [Bb.Http.ContentType](#T-Bb-Http-ContentType 'Bb.Http.ContentType') | Content type value |

<a name='M-Bb-Extensions-IUrlExtensions-WithContentType-Bb-Url,System-String-'></a>
### WithContentType(url,contentType) `method`

##### Summary

Creates a new UrlRequest and sets request headers based on property names/values of the provided object, or keys/values if object is a dictionary, to be sent.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| contentType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Content type value |

<a name='M-Bb-Extensions-IUrlExtensions-WithCookie-Bb-Url,System-String,System-Object-'></a>
### WithCookie(url,name,value) `method`

##### Summary

Creates a new UrlRequest and adds a name-value pair to its Cookie header. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The cookie name. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The cookie value. |

<a name='M-Bb-Extensions-IUrlExtensions-WithCookie-System-String,System-String,System-Object-'></a>
### WithCookie(url,name,value) `method`

##### Summary

Creates a new UrlRequest and adds a name-value pair to its Cookie header. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The cookie name. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The cookie value. |

<a name='M-Bb-Extensions-IUrlExtensions-WithCookies-Bb-Url,System-Object-'></a>
### WithCookies(url,values) `method`

##### Summary

Creates a new UrlRequest and adds name-value pairs to its Cookie header based on property names/values of the provided object, or keys/values if object is a dictionary. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Names/values of HTTP cookies to set. Typically an anonymous object or IDictionary. |

<a name='M-Bb-Extensions-IUrlExtensions-WithCookies-Bb-Url,Bb-Http-CookieJar-'></a>
### WithCookies(url,cookieJar) `method`

##### Summary

Creates a new UrlRequest and sets the CookieJar associated with this request, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| cookieJar | [Bb.Http.CookieJar](#T-Bb-Http-CookieJar 'Bb.Http.CookieJar') | The CookieJar. |

<a name='M-Bb-Extensions-IUrlExtensions-WithCookies-Bb-Url,Bb-Http-CookieJar@-'></a>
### WithCookies(url,cookieJar) `method`

##### Summary

Creates a new UrlRequest and associates it with a new CookieJar, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| cookieJar | [Bb.Http.CookieJar@](#T-Bb-Http-CookieJar@ 'Bb.Http.CookieJar@') | The created CookieJar, which can be reused in subsequent requests. |

<a name='M-Bb-Extensions-IUrlExtensions-WithCookies-System-String,System-Object-'></a>
### WithCookies(url,values) `method`

##### Summary

Creates a new UrlRequest and adds name-value pairs to its Cookie header based on property names/values of the provided object, or keys/values if object is a dictionary. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Names/values of HTTP cookies to set. Typically an anonymous object or IDictionary. |

<a name='M-Bb-Extensions-IUrlExtensions-WithCookies-System-String,Bb-Http-CookieJar-'></a>
### WithCookies(url,cookieJar) `method`

##### Summary

Creates a new UrlRequest and sets the CookieJar associated with this request, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| cookieJar | [Bb.Http.CookieJar](#T-Bb-Http-CookieJar 'Bb.Http.CookieJar') | The CookieJar. |

<a name='M-Bb-Extensions-IUrlExtensions-WithCookies-System-String,Bb-Http-CookieJar@-'></a>
### WithCookies(url,cookieJar) `method`

##### Summary

Creates a new UrlRequest and associates it with a new CookieJar, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| cookieJar | [Bb.Http.CookieJar@](#T-Bb-Http-CookieJar@ 'Bb.Http.CookieJar@') | The created CookieJar, which can be reused in subsequent requests. |

<a name='M-Bb-Extensions-IUrlExtensions-WithHeader-System-String,System-String,System-Object-'></a>
### WithHeader(url,name,value) `method`

##### Summary

Creates a new UrlRequest and sets a request header.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The header name. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The header value. |

<a name='M-Bb-Extensions-IUrlExtensions-WithHeaders-Bb-Url,System-Object,System-Boolean-'></a>
### WithHeaders(url,headers,replaceUnderscoreWithHyphen) `method`

##### Summary

Creates a new UrlRequest and sets request headers based on property names/values of the provided object, or keys/values if object is a dictionary, to be sent.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| headers | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Names/values of HTTP headers to set. Typically an anonymous object or IDictionary. |
| replaceUnderscoreWithHyphen | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, underscores in property names will be replaced by hyphens. Default is true. |

<a name='M-Bb-Extensions-IUrlExtensions-WithHeaders-System-String,System-Object,System-Boolean-'></a>
### WithHeaders(url,headers,replaceUnderscoreWithHyphen) `method`

##### Summary

Creates a new UrlRequest and sets request headers based on property names/values of the provided object, or keys/values if object is a dictionary, to be sent.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| headers | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Names/values of HTTP headers to set. Typically an anonymous object or IDictionary. |
| replaceUnderscoreWithHyphen | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, underscores in property names will be replaced by hyphens. Default is true. |

<a name='M-Bb-Extensions-IUrlExtensions-WithOAuthBearerToken-Bb-Url,System-String-'></a>
### WithOAuthBearerToken(url,token) `method`

##### Summary

Creates a new UrlRequest and sets the Authorization header with a bearer token according to OAuth 2.0 specification.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The acquired oAuth bearer token. |

<a name='M-Bb-Extensions-IUrlExtensions-WithOAuthBearerToken-System-String,System-String-'></a>
### WithOAuthBearerToken(url,token) `method`

##### Summary

Creates a new UrlRequest and sets the Authorization header with a bearer token according to OAuth 2.0 specification.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The acquired oAuth bearer token. |

<a name='M-Bb-Extensions-IUrlExtensions-WithTimeout-Bb-Url,System-TimeSpan-'></a>
### WithTimeout(url,timespan) `method`

##### Summary

Creates a new UrlRequest and sets the request timeout.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| timespan | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Time to wait before the request times out. |

<a name='M-Bb-Extensions-IUrlExtensions-WithTimeout-Bb-Url,System-Int32-'></a>
### WithTimeout(url,seconds) `method`

##### Summary

Creates a new UrlRequest and sets the request timeout.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| seconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Seconds to wait before the request times out. |

<a name='M-Bb-Extensions-IUrlExtensions-WithTimeout-System-String,System-TimeSpan-'></a>
### WithTimeout(url,timespan) `method`

##### Summary

Creates a new UrlRequest and sets the request timeout.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| timespan | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Time to wait before the request times out. |

<a name='M-Bb-Extensions-IUrlExtensions-WithTimeout-System-String,System-Int32-'></a>
### WithTimeout(url,seconds) `method`

##### Summary

Creates a new UrlRequest and sets the request timeout.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| seconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Seconds to wait before the request times out. |

<a name='T-Bb-Http-IUrlRequest'></a>
## IUrlRequest `type`

##### Namespace

Bb.Http

##### Summary

Represents an HTTP request. Can be created explicitly via new UrlRequest(), fluently via Url.Request(),
or implicitly when a call is made via methods like Url.GetAsync().

<a name='P-Bb-Http-IUrlRequest-Client'></a>
### Client `property`

##### Summary

Gets or sets the IUrlClient to use when sending the request.

<a name='P-Bb-Http-IUrlRequest-Content'></a>
### Content `property`

##### Summary

The body content of this request.

<a name='P-Bb-Http-IUrlRequest-CookieJar'></a>
### CookieJar `property`

##### Summary

Gets or sets the collection of HTTP cookies that can be shared between multiple requests. When set, values that
should be sent with this request (based on Domain, Path, and other rules) are immediately copied to the Cookie
request header, and any Set-Cookie headers received in the response will be written to the CookieJar.

<a name='P-Bb-Http-IUrlRequest-Cookies'></a>
### Cookies `property`

##### Summary

Gets Name/Value pairs parsed from the Cookie request header.

<a name='P-Bb-Http-IUrlRequest-EnsureSuccessStatusCode'></a>
### EnsureSuccessStatusCode `property`

##### Summary

If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException')

<a name='P-Bb-Http-IUrlRequest-RedirectedFrom'></a>
### RedirectedFrom `property`

##### Summary

The UrlCall that received a 3xx response and automatically triggered this request.

<a name='P-Bb-Http-IUrlRequest-Url'></a>
### Url `property`

##### Summary

Gets or sets the URL to be called.

<a name='P-Bb-Http-IUrlRequest-Verb'></a>
### Verb `property`

##### Summary

Gets or sets the HTTP method of the request. Normally you don't need to set this explicitly; it will be set
when you call the sending method, such as GetAsync, PostAsync, etc.

<a name='M-Bb-Http-IUrlRequest-SendAsync-System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendAsync(cancellationToken,completionOption) `method`

##### Summary

Asynchronously sends the HTTP request. Mainly used to implement higher-level extension methods (GetJsonAsync, etc).

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The token to monitor for cancellation requests. |
| completionOption | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The HttpCompletionOption used in the request. Optional. |

<a name='M-Bb-Http-IUrlRequest-SendAsync-System-Net-Http-HttpMethod,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendAsync(verb,cancellationToken,completionOption) `method`

##### Summary

Asynchronously sends the HTTP request. Mainly used to implement higher-level extension methods (GetJsonAsync, etc).

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP method used to make the request. |
| cancellationToken | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The token to monitor for cancellation requests. |
| completionOption | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The HttpCompletionOption used in the request. Optional. |

<a name='M-Bb-Http-IUrlRequest-SendAsync-System-Net-Http-HttpMethod,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendAsync(verb,content,cancellationToken,completionOption) `method`

##### Summary

Asynchronously sends the HTTP request. Mainly used to implement higher-level extension methods (GetJsonAsync, etc).

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP method used to make the request. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | Contents of the request body. |
| cancellationToken | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The token to monitor for cancellation requests. |
| completionOption | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The HttpCompletionOption used in the request. Optional. |

<a name='T-Bb-Extensions-IUrlRequestExtensions'></a>
## IUrlRequestExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Fluent extension methods on String, Url, Uri, and IUrlRequest.

<a name='M-Bb-Extensions-IUrlRequestExtensions-AllowAnyHttpStatus-System-Uri-'></a>
### AllowAnyHttpStatus(uri) `method`

##### Summary

Creates a new UrlRequest and configures it to allow any returned HTTP status without throwing a UrlHttpException.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-AllowHttpStatus-System-Uri,System-String-'></a>
### AllowHttpStatus(uri,pattern) `method`

##### Summary

Creates a new UrlRequest and adds a pattern representing an HTTP status code or range of codes which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Examples: "3xx", "100,300,600", "100-299,6xx" |

<a name='M-Bb-Extensions-IUrlRequestExtensions-AllowHttpStatus-System-Uri,System-Net-HttpStatusCode[]-'></a>
### AllowHttpStatus(uri,statusCodes) `method`

##### Summary

Creates a new UrlRequest and adds an HttpStatusCode which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| statusCodes | [System.Net.HttpStatusCode[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.HttpStatusCode[] 'System.Net.HttpStatusCode[]') | The HttpStatusCode(s) to allow. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-ConfigureRequest-System-Uri,System-Action{Bb-Http-IUrlRequest}-'></a>
### ConfigureRequest(uri,action) `method`

##### Summary

Creates a new UrlRequest and allows changing its Settings inline.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| action | [System.Action{Bb.Http.IUrlRequest}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.IUrlRequest}') | A delegate defining the Settings changes. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-DeleteAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### DeleteAsync(request,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous DELETE request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-DeleteAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### DeleteAsync(uri,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous DELETE request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-DownloadFileAsync-System-Uri,System-String,System-String,System-Int32,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### DownloadFileAsync(uri,localFolderPath,localFileName,bufferSize,completionOption,cancellationToken) `method`

##### Summary

Creates a new UrlRequest and asynchronously downloads a file.

##### Returns

A Task whose result is the local path of the downloaded file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| localFolderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path of local folder where file is to be downloaded. |
| localFileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of local file. If not specified, the source filename (last segment of the URL) is used. |
| bufferSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Buffer size in bytes. Default is 4096. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetAsync(request,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous GET request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetAsync(uri,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetBytesAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetBytesAsync(request,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a byte array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetBytesAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetBytesAsync(uri,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a byte array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetBytesAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetBytesAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a byte array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetJsonAsync``1-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetJsonAsync\`\`1(uri,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the JSON response body deserialized to an object of type T.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetObjectAsync``1-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetObjectAsync\`\`1(request,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous GET request.

##### Returns

A Task whose result is the object response body deserialized to an object of type T.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetObjectAsync``1-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetObjectAsync\`\`1(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the JSON response body deserialized to an object of type T.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetStreamAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetStreamAsync(request,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a Stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetStreamAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetStreamAsync(uri,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a Stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetStreamAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetStreamAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a Stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetStringAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetStringAsync(request,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetStringAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetStringAsync(uri,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-GetStringAsync-Bb-Url,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### GetStringAsync(url,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous GET request.

##### Returns

A Task whose result is the response body as a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-HeadAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### HeadAsync(request,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous HEAD request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-HeadAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### HeadAsync(uri,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous HEAD request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-OptionsAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### OptionsAsync(request,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous OPTIONS request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-OptionsAsync-System-Uri,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### OptionsAsync(uri,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous OPTIONS request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PatchAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchAsync(request,content,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PatchAsync-System-Uri,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchAsync(uri,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PatchAsync-Bb-Url,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchAsync(url,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PatchObjectAsync-Bb-Http-IUrlRequest,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchObjectAsync(request,body,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PatchObjectAsync-System-Uri,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchObjectAsync(uri,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PatchObjectAsync-Bb-Url,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchObjectAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PatchStringAsync-Bb-Http-IUrlRequest,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchStringAsync(request,body,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PatchStringAsync-System-Uri,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchStringAsync(uri,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PatchStringAsync-Bb-Url,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PatchStringAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PATCH request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostAsync(request,content,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Http-IUrlRequest,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostAsync(request,body,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to object. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Http-IUrlRequest,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostAsync(request,body,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostAsync-System-Uri,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostAsync(uri,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Url,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostAsync(url,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Url,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Url,Bb-Util-QueryParamCollection,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| body | [Bb.Util.QueryParamCollection](#T-Bb-Util-QueryParamCollection 'Bb.Util.QueryParamCollection') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostAsync-Bb-Url,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostMultipartAsync-System-Uri,System-Action{System-Net-Http-MultipartFormDataContent},System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostMultipartAsync(uri,buildContent,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous multipart/form-data POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| buildContent | [System.Action{System.Net.Http.MultipartFormDataContent}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.MultipartFormDataContent}') | A delegate for building the content parts. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostObjectAsync-System-Uri,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostObjectAsync(uri,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostStringAsync-System-Uri,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostStringAsync(uri,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostUrlEncodedAsync-Bb-Http-IUrlRequest,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostUrlEncodedAsync(request,body,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to a URL-encoded string. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostUrlEncodedAsync-System-Uri,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostUrlEncodedAsync(uri,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to a URL-encoded string. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PostUrlEncodedAsync-Bb-Url,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostUrlEncodedAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to a URL-encoded string. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PutAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutAsync(request,content,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PutAsync-System-Uri,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutAsync(uri,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PutAsync-Bb-Url,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutAsync(url,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PutJsonAsync-Bb-Url,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutJsonAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PutObjectAsync-Bb-Http-IUrlRequest,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutObjectAsync(request,body,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PutObjectAsync-System-Uri,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutObjectAsync(uri,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PutStringAsync-Bb-Http-IUrlRequest,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutStringAsync(request,body,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PutStringAsync-System-Uri,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutStringAsync(uri,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PutStringAsync-Bb-Url,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutStringAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous PUT request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PutUrlEncodedAsync-Bb-Http-IUrlRequest,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutUrlEncodedAsync(request,body,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to a URL-encoded string. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-PutUrlEncodedAsync-Bb-Url,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PutUrlEncodedAsync(url,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to a URL-encoded string. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-SendAsync-System-Uri,System-Net-Http-HttpMethod,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendAsync(uri,verb,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-SendAsync-Bb-Url,System-Net-Http-HttpMethod,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendAsync(url,verb,content,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| content | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') | The request body content. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-SendObjectAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendObjectAsync(request,verb,body,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to object. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-SendObjectAsync-System-Uri,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendObjectAsync(uri,verb,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-SendObjectAsync-Bb-Url,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendObjectAsync(url,verb,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to JSON. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-SendStringAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpMethod,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendStringAsync(request,verb,body,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-SendStringAsync-System-Uri,System-Net-Http-HttpMethod,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendStringAsync(uri,verb,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-SendStringAsync-Bb-Url,System-Net-Http-HttpMethod,System-String,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendStringAsync(url,verb,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The request body. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-SendUrlEncodedAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendUrlEncodedAsync(request,verb,body,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | This IUrlRequest |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to a URL-encoded string. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-SendUrlEncodedAsync-System-Uri,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendUrlEncodedAsync(uri,verb,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to a URL-encoded string. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-SendUrlEncodedAsync-Bb-Url,System-Net-Http-HttpMethod,System-Object,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendUrlEncodedAsync(url,verb,body,completionOption,cancellationToken) `method`

##### Summary

Creates a UrlRequest and sends an asynchronous request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | This Url. |
| verb | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | The HTTP verb used to make the request. |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | An object representing the request body, which will be serialized to a URL-encoded string. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-Serialize-Bb-Http-IUrlRequest,System-Object-'></a>
### Serialize(self,body) `method`

##### Summary

Convert object in a [StringContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.StringContent 'System.Net.Http.StringContent')

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | Request |
| body | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | object to serialize |

<a name='M-Bb-Extensions-IUrlRequestExtensions-WithAutoRedirect-System-Uri,System-Boolean-'></a>
### WithAutoRedirect(uri,enabled) `method`

##### Summary

Creates a new UrlRequest and configures whether redirects are automatically followed.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| enabled | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if Url should automatically send a new request to the redirect URL, false if it should not. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-WithBasicAuth-System-Uri,System-String,System-String-'></a>
### WithBasicAuth(uri,userName,password) `method`

##### Summary

Creates a new UrlRequest and sets the Authorization header according to Basic Authentication protocol.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| userName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | User name of authenticating user. |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Password of authenticating user. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-WithCookie-System-Uri,System-String,System-Object-'></a>
### WithCookie(uri,name,value) `method`

##### Summary

Creates a new UrlRequest and adds a name-value pair to its Cookie header. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The cookie name. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The cookie value. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-WithCookies-System-Uri,System-Object-'></a>
### WithCookies(uri,values) `method`

##### Summary

Creates a new UrlRequest and adds name-value pairs to its Cookie header based on property names/values of the provided object, or keys/values if object is a dictionary. To automatically maintain a cookie "session", consider using a CookieJar or CookieSession instead.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Names/values of HTTP cookies to set. Typically an anonymous object or IDictionary. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-WithCookies-System-Uri,Bb-Http-CookieJar-'></a>
### WithCookies(uri,cookieJar) `method`

##### Summary

Creates a new UrlRequest and sets the CookieJar associated with this request, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| cookieJar | [Bb.Http.CookieJar](#T-Bb-Http-CookieJar 'Bb.Http.CookieJar') | The CookieJar. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-WithCookies-System-Uri,Bb-Http-CookieJar@-'></a>
### WithCookies(uri,cookieJar) `method`

##### Summary

Creates a new UrlRequest and associates it with a new CookieJar, which will be updated with any Set-Cookie headers present in the response and is suitable for reuse in subsequent requests.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| cookieJar | [Bb.Http.CookieJar@](#T-Bb-Http-CookieJar@ 'Bb.Http.CookieJar@') | The created CookieJar, which can be reused in subsequent requests. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-WithHeader-System-Uri,System-String,System-Object-'></a>
### WithHeader(uri,name,value) `method`

##### Summary

Creates a new UrlRequest and sets a request header.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The header name. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The header value. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-WithHeaders-System-Uri,System-Object,System-Boolean-'></a>
### WithHeaders(uri,headers,replaceUnderscoreWithHyphen) `method`

##### Summary

Creates a new UrlRequest and sets request headers based on property names/values of the provided object, or keys/values if object is a dictionary, to be sent.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| headers | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Names/values of HTTP headers to set. Typically an anonymous object or IDictionary. |
| replaceUnderscoreWithHyphen | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, underscores in property names will be replaced by hyphens. Default is true. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-WithOAuthBearerToken-System-Uri,System-String-'></a>
### WithOAuthBearerToken(uri,token) `method`

##### Summary

Creates a new UrlRequest and sets the Authorization header with a bearer token according to OAuth 2.0 specification.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The acquired oAuth bearer token. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-WithTimeout-System-Uri,System-TimeSpan-'></a>
### WithTimeout(uri,timespan) `method`

##### Summary

Creates a new UrlRequest and sets the request timeout.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| timespan | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Time to wait before the request times out. |

<a name='M-Bb-Extensions-IUrlRequestExtensions-WithTimeout-System-Uri,System-Int32-'></a>
### WithTimeout(uri,seconds) `method`

##### Summary

Creates a new UrlRequest and sets the request timeout.

##### Returns

A new IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| seconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Seconds to wait before the request times out. |

<a name='T-Bb-Http-IUrlResponse'></a>
## IUrlResponse `type`

##### Namespace

Bb.Http

##### Summary

Represents an HTTP response.

<a name='P-Bb-Http-IUrlResponse-Cookies'></a>
### Cookies `property`

##### Summary

Gets the collection of HTTP cookies received in this response via Set-Cookie headers.

<a name='P-Bb-Http-IUrlResponse-Headers'></a>
### Headers `property`

##### Summary

Gets the collection of response headers received.

<a name='P-Bb-Http-IUrlResponse-IsSuccessStatusCode'></a>
### IsSuccessStatusCode `property`

##### Summary

Gets a value indicating whether the HTTP response was successful.

<a name='P-Bb-Http-IUrlResponse-ResponseMessage'></a>
### ResponseMessage `property`

##### Summary

Gets the raw HttpResponseMessage that this IUrlResponse wraps.

<a name='P-Bb-Http-IUrlResponse-StatusCode'></a>
### StatusCode `property`

##### Summary

Gets the HTTP status code of the response.

<a name='M-Bb-Http-IUrlResponse-EnsureSuccessStatusCode'></a>
### EnsureSuccessStatusCode() `method`

##### Summary

Throws an exception if the HTTP response status code indicates failure.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-IUrlResponse-GetBytesAsync'></a>
### GetBytesAsync() `method`

##### Summary

Returns HTTP response body as a byte array.

##### Returns

A Task whose result is the response body as a byte array.

##### Parameters

This method has no parameters.

##### Example

bytes = await url.PostAsync(data).GetBytes()

<a name='M-Bb-Http-IUrlResponse-GetObjectAsync``1'></a>
### GetObjectAsync\`\`1() `method`

##### Summary

Deserializes JSON-formatted HTTP response body to object of type T.

##### Returns

A Task whose result is an object containing data in the response body.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | A type whose structure matches the expected JSON response. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Bb.Http.UrlHttpException](#T-Bb-Http-UrlHttpException 'Bb.Http.UrlHttpException') | Condition. |

##### Example

x = await url.PostAsync(data).GetJson<T>()

<a name='M-Bb-Http-IUrlResponse-GetStreamAsync'></a>
### GetStreamAsync() `method`

##### Summary

Returns HTTP response body as a stream.

##### Returns

A Task whose result is the response body as a stream.

##### Parameters

This method has no parameters.

##### Example

stream = await url.PostAsync(data).GetStream()

<a name='M-Bb-Http-IUrlResponse-GetStringAsync'></a>
### GetStringAsync() `method`

##### Summary

Returns HTTP response body as a string.

##### Returns

A Task whose result is the response body as a string.

##### Parameters

This method has no parameters.

##### Example

s = await url.PostAsync(data).GetString()

<a name='T-Bb-Http-InvalidCookieException'></a>
## InvalidCookieException `type`

##### Namespace

Bb.Http

##### Summary

Exception thrown when attempting to add or update an invalid UrlCookie to a CookieJar.

<a name='M-Bb-Http-InvalidCookieException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

Creates a new InvalidCookieException.

##### Parameters

This constructor has no parameters.

<a name='T-Bb-Extensions-MultipartExtensions'></a>
## MultipartExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Fluent extension methods for sending multipart/form-data requests.

<a name='M-Bb-Extensions-MultipartExtensions-AddFile-System-Net-Http-MultipartFormDataContent,System-String,System-String,System-String-'></a>
### AddFile(self,name,filename,contentType) `method`

##### Summary

Add file to the MultipartFormDataContent.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Net.Http.MultipartFormDataContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.MultipartFormDataContent 'System.Net.Http.MultipartFormDataContent') | The content [MultipartFormDataContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.MultipartFormDataContent 'System.Net.Http.MultipartFormDataContent') |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| contentType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-Extensions-MultipartExtensions-AddJson-System-Net-Http-MultipartFormDataContent,System-String,System-String-'></a>
### AddJson(self,name,data) `method`

##### Summary

Add json to the MultipartFormDataContent.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Net.Http.MultipartFormDataContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.MultipartFormDataContent 'System.Net.Http.MultipartFormDataContent') | The content [MultipartFormDataContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.MultipartFormDataContent 'System.Net.Http.MultipartFormDataContent') |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| data | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-Extensions-MultipartExtensions-AddString-System-Net-Http-MultipartFormDataContent,System-String,System-String,System-String-'></a>
### AddString(self,name,data,contentType) `method`

##### Summary

Add string to the MultipartFormDataContent.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Net.Http.MultipartFormDataContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.MultipartFormDataContent 'System.Net.Http.MultipartFormDataContent') | The content [MultipartFormDataContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.MultipartFormDataContent 'System.Net.Http.MultipartFormDataContent') |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| data | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| contentType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-Extensions-MultipartExtensions-AddStringParts-System-Net-Http-MultipartFormDataContent,System-String,System-Object,System-String-'></a>
### AddStringParts(self,name,data,contentType) `method`

##### Summary

Add string parts to the MultipartFormDataContent.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Net.Http.MultipartFormDataContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.MultipartFormDataContent 'System.Net.Http.MultipartFormDataContent') | The content [MultipartFormDataContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.MultipartFormDataContent 'System.Net.Http.MultipartFormDataContent') |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| data | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| contentType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-Extensions-MultipartExtensions-AddUrlEncoded-System-Net-Http-MultipartFormDataContent,System-String,System-Collections-Generic-List{System-Collections-Generic-KeyValuePair{System-String,System-String}}-'></a>
### AddUrlEncoded(self,name,data) `method`

##### Summary

Add datas url encoded to the MultipartFormDataContent.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Net.Http.MultipartFormDataContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.MultipartFormDataContent 'System.Net.Http.MultipartFormDataContent') | The content [MultipartFormDataContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.MultipartFormDataContent 'System.Net.Http.MultipartFormDataContent') |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| data | [System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{System.String,System.String}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Collections.Generic.KeyValuePair{System.String,System.String}}') |  |

<a name='M-Bb-Extensions-MultipartExtensions-PostMultipartAsync-Bb-Http-IUrlRequest,System-Action{System-Net-Http-MultipartFormDataContent},System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### PostMultipartAsync(buildContent,request,completionOption,cancellationToken) `method`

##### Summary

Sends an asynchronous multipart/form-data POST request.

##### Returns

A Task whose result is the received IUrlResponse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| buildContent | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | A delegate for building the content parts. |
| request | [System.Action{System.Net.Http.MultipartFormDataContent}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.MultipartFormDataContent}') | The IUrlRequest. |
| completionOption | [System.Net.Http.HttpCompletionOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpCompletionOption 'System.Net.Http.HttpCompletionOption') | The HttpCompletionOption used in the request. Optional. |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The token to monitor for cancellation requests. |

<a name='M-Bb-Extensions-MultipartExtensions-WithContentType``1-``0,Bb-Http-ContentType-'></a>
### WithContentType\`\`1(self,contentType) `method`

##### Summary

Append a content type to the HttpContent headers.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [\`\`0](#T-``0 '``0') | The content [HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') |
| contentType | [Bb.Http.ContentType](#T-Bb-Http-ContentType 'Bb.Http.ContentType') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-Bb-Util-NameValueList`1'></a>
## NameValueList\`1 `type`

##### Namespace

Bb.Util

##### Summary

An ordered collection of Name/Value pairs where duplicate names are allowed but aren't typical.
Useful for things where a dictionary would work great if not for those pesky edge cases (headers, cookies, etc).

<a name='M-Bb-Util-NameValueList`1-#ctor-System-Boolean-'></a>
### #ctor() `constructor`

##### Summary

Instantiates a new empty NameValueList.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Util-NameValueList`1-#ctor-System-Collections-Generic-IEnumerable{System-ValueTuple{System-String,`0}},System-Boolean-'></a>
### #ctor() `constructor`

##### Summary

Instantiates a new NameValueList with the Name/Value pairs provided.

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Util-NameValueList`1-Add-System-String,`0-'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-NameValueList`1-AddOrReplace-System-String,`0-'></a>
### AddOrReplace() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-NameValueList`1-Contains-System-String-'></a>
### Contains() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-NameValueList`1-Contains-System-String,`0-'></a>
### Contains() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-NameValueList`1-FirstOrDefault-System-String-'></a>
### FirstOrDefault() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-NameValueList`1-GetAll-System-String-'></a>
### GetAll() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-NameValueList`1-Remove-System-String-'></a>
### Remove() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-NameValueList`1-TryGetFirst-System-String,`0@-'></a>
### TryGetFirst() `method`

##### Summary

*Inherit from parent.*

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

<a name='T-Bb-Http-Configuration-PerBaseUrlClientFactory'></a>
## PerBaseUrlClientFactory `type`

##### Namespace

Bb.Http.Configuration

##### Summary

An IUrlClientFactory implementation that caches and reuses the same UrlClient instance
per URL requested, which it assumes is a "base" URL, and sets the IUrlClient.BaseUrl property
to that value. Ideal for use with IoC containers - register as a singleton, inject into a service
that wraps some web service, and use to set a private IUrlClient field in the constructor.

<a name='M-Bb-Http-Configuration-PerBaseUrlClientFactory-Create-Bb-Url-'></a>
### Create(url) `method`

##### Summary

Returns a new new UrlClient with BaseUrl set to the URL passed.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | The URL |

<a name='M-Bb-Http-Configuration-PerBaseUrlClientFactory-GetCacheKey-Bb-Url-'></a>
### GetCacheKey(url) `method`

##### Summary

Returns the entire URL, which is assumed to be some "base" URL for a service.

##### Returns

The cache key

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | The URL. |

<a name='T-Bb-Util-QueryParamCollection'></a>
## QueryParamCollection `type`

##### Namespace

Bb.Util

##### Summary

Represents a URL query as a collection of name/value pairs. Insertion order is preserved.

<a name='M-Bb-Util-QueryParamCollection-#ctor-System-String-'></a>
### #ctor(query) `constructor`

##### Summary

Returns a new instance of QueryParamCollection

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional query string to parse. |

<a name='P-Bb-Util-QueryParamCollection-Count'></a>
### Count `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Util-QueryParamCollection-Item-System-Int32-'></a>
### Item `property`

##### Summary

*Inherit from parent.*

<a name='M-Bb-Util-QueryParamCollection-Add-System-String,System-Object,System-Boolean,Bb-NullValueHandling-'></a>
### Add(name,value,isEncoded,nullValueHandling) `method`

##### Summary

Appends a query parameter. If value is a collection type (array, IEnumerable, etc.), multiple parameters are added, i.e. x=1&x=2.
To overwrite existing parameters of the same name, use AddOrReplace instead.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the parameter. |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Value of the parameter. If it's a collection, multiple parameters of the same name are added. |
| isEncoded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, assume value(s) already URL-encoded. |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Describes how to handle null values. |

<a name='M-Bb-Util-QueryParamCollection-AddOrReplace-System-String,System-Object,System-Boolean,Bb-NullValueHandling-'></a>
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
| isEncoded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, assume value(s) already URL-encoded. |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Describes how to handle null values. |

<a name='M-Bb-Util-QueryParamCollection-Clear'></a>
### Clear() `method`

##### Summary

Clears all query parameters from this collection.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-QueryParamCollection-Contains-System-String-'></a>
### Contains() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-QueryParamCollection-Contains-System-String,System-Object-'></a>
### Contains() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-QueryParamCollection-FirstOrDefault-System-String-'></a>
### FirstOrDefault() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-QueryParamCollection-GetAll-System-String-'></a>
### GetAll() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-QueryParamCollection-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-QueryParamCollection-Remove-System-String-'></a>
### Remove() `method`

##### Summary

Removes all query parameters of the given name.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-QueryParamCollection-ToString'></a>
### ToString() `method`

##### Summary

Returns serialized, encoded query string. Insertion order is preserved.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Util-QueryParamCollection-ToString-System-Boolean-'></a>
### ToString() `method`

##### Summary

Returns serialized, encoded query string. Insertion order is preserved.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Util-QueryParamCollection-TryGetFirst-System-String,System-Object@-'></a>
### TryGetFirst() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-QueryParamCollection-op_Implicit-Bb-Util-QueryParamCollection-~System-String'></a>
### op_Implicit(query) `method`

##### Summary

implicit conversion from QueryParamCollection to string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [Bb.Util.QueryParamCollection)~System.String](#T-Bb-Util-QueryParamCollection-~System-String 'Bb.Util.QueryParamCollection)~System.String') |  |

<a name='T-Bb-Util-QueryParamValue'></a>
## QueryParamValue `type`

##### Namespace

Bb.Util

##### Summary

Represents a query parameter value with the ability to track whether it was already encoded when created.

<a name='T-Bb-Http-Configuration-RedirectSettings'></a>
## RedirectSettings `type`

##### Namespace

Bb.Http.Configuration

##### Summary

A set of properties that affect Url.Http behavior specific to auto-redirecting.

<a name='M-Bb-Http-Configuration-RedirectSettings-#ctor-Bb-Http-Configuration-UrlHttpSettings-'></a>
### #ctor() `constructor`

##### Summary

Creates a new instance of RedirectSettings.

##### Parameters

This constructor has no parameters.

<a name='P-Bb-Http-Configuration-RedirectSettings-AllowSecureToInsecure'></a>
### AllowSecureToInsecure `property`

##### Summary

If true, redirecting from HTTPS to HTTP is allowed. Default is false, as this behavior is considered
insecure.

<a name='P-Bb-Http-Configuration-RedirectSettings-Enabled'></a>
### Enabled `property`

##### Summary

If false, all of Url's mechanisms for handling redirects, including raising the OnRedirect event,
are disabled entirely. This could also impact cookie functionality. Default is true. If you don't
need Url's redirect or cookie functionality, or you are providing an HttpClient whose HttpClientHandler
is providing these services, then it is safe to set this to false.

<a name='P-Bb-Http-Configuration-RedirectSettings-ForwardAuthorizationHeader'></a>
### ForwardAuthorizationHeader `property`

##### Summary

If true, any Authorization header sent in the original request is forwarded in the redirect.
Default is false, as this behavior is considered insecure.

<a name='P-Bb-Http-Configuration-RedirectSettings-ForwardHeaders'></a>
### ForwardHeaders `property`

##### Summary

If true, request-level headers sent in the original request are forwarded in the redirect, with the
exception of Authorization (use ForwardAuthorizationHeader) and Cookie (use a CookieJar). Also, any
headers set on UrlClient are automatically sent with all requests, including redirects. Default is true.

<a name='P-Bb-Http-Configuration-RedirectSettings-MaxAutoRedirects'></a>
### MaxAutoRedirects `property`

##### Summary

Maximum number of redirects that Url will automatically follow in a single request. Default is 10.

<a name='T-Bb-Extensions-ResponseExtensions'></a>
## ResponseExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

ReceiveXXX extension methods off Task<IUrlResponse> that allow chaining off methods like SendAsync
without the need for nested awaits.

<a name='M-Bb-Extensions-ResponseExtensions-AsBytes-System-Threading-Tasks-Task{Bb-Http-IUrlResponse},System-Action{Bb-Http-IUrlResponse}-'></a>
### AsBytes(response,actionInterceptMessage) `method`

##### Summary

Returns HTTP response body as a byte array. Intended to chain off an async call.

##### Returns

A Task whose result is the response body as a byte array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [System.Threading.Tasks.Task{Bb.Http.IUrlResponse}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{Bb.Http.IUrlResponse}') | The response to deserializes. |
| actionInterceptMessage | [System.Action{Bb.Http.IUrlResponse}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.IUrlResponse}') | Method to intercept response if the result is not success status code. |

##### Example

bytes = await url.PostAsync(data).ReceiveBytes()

<a name='M-Bb-Extensions-ResponseExtensions-AsStream-System-Threading-Tasks-Task{Bb-Http-IUrlResponse},System-Action{Bb-Http-IUrlResponse}-'></a>
### AsStream(response,actionInterceptMessage) `method`

##### Summary

Returns HTTP response body as a stream. Intended to chain off an async call.

##### Returns

A Task whose result is the response body as a stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [System.Threading.Tasks.Task{Bb.Http.IUrlResponse}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{Bb.Http.IUrlResponse}') | The response to deserializes. |
| actionInterceptMessage | [System.Action{Bb.Http.IUrlResponse}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.IUrlResponse}') | Method to intercept response if the result is not success status code. |

##### Example

stream = await url.PostAsync(data).ReceiveStream()

<a name='M-Bb-Extensions-ResponseExtensions-AsString-System-Threading-Tasks-Task{Bb-Http-IUrlResponse},System-Action{Bb-Http-IUrlResponse}-'></a>
### AsString(response,actionInterceptMessage) `method`

##### Summary

Returns HTTP response body as a string. Intended to chain off an async call.

##### Returns

A Task whose result is the response body as a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [System.Threading.Tasks.Task{Bb.Http.IUrlResponse}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{Bb.Http.IUrlResponse}') | The response to deserializes. |
| actionInterceptMessage | [System.Action{Bb.Http.IUrlResponse}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.IUrlResponse}') | Method to intercept response if the result is not success status code. |

##### Example

s = await url.PostAsync(data).ReceiveString()

<a name='M-Bb-Extensions-ResponseExtensions-As``1-System-Threading-Tasks-Task{Bb-Http-IUrlResponse},System-Action{Bb-Http-IUrlResponse}-'></a>
### As\`\`1(response,actionInterceptMessage) `method`

##### Summary

Deserializes JSON-formatted HTTP response body to object of type T. Intended to chain off an async HTTP.

##### Returns

A Task whose result is an object containing data in the response body.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [System.Threading.Tasks.Task{Bb.Http.IUrlResponse}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task{Bb.Http.IUrlResponse}') | The response to deserializes. |
| actionInterceptMessage | [System.Action{Bb.Http.IUrlResponse}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.IUrlResponse}') | Method to intercept response if the result is not success status code. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | A type whose structure matches the expected JSON response. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Bb.Http.UrlHttpException](#T-Bb-Http-UrlHttpException 'Bb.Http.UrlHttpException') | Condition. |

##### Example

x = await url.PostAsync(data).ReceiveJson<T>()

<a name='T-Bb-Http-SameSite'></a>
## SameSite `type`

##### Namespace

Bb.Http

##### Summary

Corresponds to the possible values of the SameSite attribute of the Set-Cookie header.

<a name='F-Bb-Http-SameSite-Lax'></a>
### Lax `constants`

##### Summary

Indicates a browser should send cookie for cross-site requests only with top-level navigation.

<a name='F-Bb-Http-SameSite-None'></a>
### None `constants`

##### Summary

Indicates a browser should send cookie for same-site and cross-site requests.

<a name='F-Bb-Http-SameSite-Strict'></a>
### Strict `constants`

##### Summary

Indicates a browser should only send cookie for same-site requests.

<a name='T-Bb-Extensions-SettingsExtensions'></a>
## SettingsExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Fluent extension methods for tweaking UrlHttpSettings

<a name='M-Bb-Extensions-SettingsExtensions-AfterCall``1-``0,System-Action{Bb-Http-UrlCall}-'></a>
### AfterCall\`\`1() `method`

##### Summary

Sets a callback that is invoked immediately after every HTTP response is received.

##### Parameters

This method has no parameters.

<a name='M-Bb-Extensions-SettingsExtensions-AfterCall``1-``0,System-Func{Bb-Http-UrlCall,System-Threading-Tasks-Task}-'></a>
### AfterCall\`\`1() `method`

##### Summary

Sets a callback that is invoked asynchronously immediately after every HTTP response is received.

##### Parameters

This method has no parameters.

<a name='M-Bb-Extensions-SettingsExtensions-AllowAnyHttpStatus``1-``0-'></a>
### AllowAnyHttpStatus\`\`1(obj) `method`

##### Summary

Prevents a UrlHttpException from being thrown on any completed response, regardless of the HTTP status code.

##### Returns

This IUrlClient or IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0](#T-``0 '``0') | The IUrlClient or IUrlRequest. |

<a name='M-Bb-Extensions-SettingsExtensions-AllowHttpStatus``1-``0,System-String-'></a>
### AllowHttpStatus\`\`1(obj,pattern) `method`

##### Summary

Adds a pattern representing an HTTP status code or range of codes which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.

##### Returns

This IUrlClient or IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0](#T-``0 '``0') | The IUrlClient or IUrlRequest. |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Examples: "3xx", "100,300,600", "100-299,6xx" |

<a name='M-Bb-Extensions-SettingsExtensions-AllowHttpStatus``1-``0,System-Net-HttpStatusCode[]-'></a>
### AllowHttpStatus\`\`1(obj,statusCodes) `method`

##### Summary

Adds an [HttpStatusCode](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.HttpStatusCode 'System.Net.HttpStatusCode') which (in addition to 2xx) will NOT result in a UrlHttpException being thrown.

##### Returns

This IUrlClient or IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0](#T-``0 '``0') | The IUrlClient or IUrlRequest. |
| statusCodes | [System.Net.HttpStatusCode[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.HttpStatusCode[] 'System.Net.HttpStatusCode[]') | Examples: HttpStatusCode.NotFound |

<a name='M-Bb-Extensions-SettingsExtensions-BeforeCall``1-``0,System-Action{Bb-Http-UrlCall}-'></a>
### BeforeCall\`\`1() `method`

##### Summary

Sets a callback that is invoked immediately before every HTTP request is sent.

##### Parameters

This method has no parameters.

<a name='M-Bb-Extensions-SettingsExtensions-BeforeCall``1-``0,System-Func{Bb-Http-UrlCall,System-Threading-Tasks-Task}-'></a>
### BeforeCall\`\`1() `method`

##### Summary

Sets a callback that is invoked asynchronously immediately before every HTTP request is sent.

##### Parameters

This method has no parameters.

<a name='M-Bb-Extensions-SettingsExtensions-Configure-Bb-Http-IUrlClient,System-Action{Bb-Http-Configuration-UrlHttpSettings}-'></a>
### Configure(client,action) `method`

##### Summary

Change UrlHttpSettings for this IUrlClient.

##### Returns

The IUrlClient with the modified Settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| client | [Bb.Http.IUrlClient](#T-Bb-Http-IUrlClient 'Bb.Http.IUrlClient') | The IUrlClient. |
| action | [System.Action{Bb.Http.Configuration.UrlHttpSettings}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.Configuration.UrlHttpSettings}') | Action defining the settings changes. |

<a name='M-Bb-Extensions-SettingsExtensions-ConfigureRequest-Bb-Http-IUrlRequest,System-Action{Bb-Http-IUrlRequest}-'></a>
### ConfigureRequest(request,action) `method`

##### Summary

Change UrlHttpSettings for this IUrlRequest.

##### Returns

The IUrlRequest with the modified Settings

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest. |
| action | [System.Action{Bb.Http.IUrlRequest}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.IUrlRequest}') | Action defining the settings changes. |

<a name='M-Bb-Extensions-SettingsExtensions-OnError``1-``0,System-Action{Bb-Http-UrlCall}-'></a>
### OnError\`\`1() `method`

##### Summary

Sets a callback that is invoked when an error occurs during any HTTP call, including when any non-success
HTTP status code is returned in the response. Response should be null-checked if used in the event handler.

##### Parameters

This method has no parameters.

<a name='M-Bb-Extensions-SettingsExtensions-OnError``1-``0,System-Func{Bb-Http-UrlCall,System-Threading-Tasks-Task}-'></a>
### OnError\`\`1() `method`

##### Summary

Sets a callback that is invoked asynchronously when an error occurs during any HTTP call, including when any non-success
HTTP status code is returned in the response. Response should be null-checked if used in the event handler.

##### Parameters

This method has no parameters.

<a name='M-Bb-Extensions-SettingsExtensions-OnRedirect``1-``0,System-Action{Bb-Http-UrlCall}-'></a>
### OnRedirect\`\`1() `method`

##### Summary

Sets a callback that is invoked when any 3xx response with a Location header is received.
You can inspect/manipulate the call.Redirect object to determine what will happen next.
An auto-redirect will only happen if call.Redirect.Follow is true upon exiting the callback.

##### Parameters

This method has no parameters.

<a name='M-Bb-Extensions-SettingsExtensions-OnRedirect``1-``0,System-Func{Bb-Http-UrlCall,System-Threading-Tasks-Task}-'></a>
### OnRedirect\`\`1() `method`

##### Summary

Sets a callback that is invoked asynchronously when any 3xx response with a Location header is received.
You can inspect/manipulate the call.Redirect object to determine what will happen next.
An auto-redirect will only happen if call.Redirect.Follow is true upon exiting the callback.

##### Parameters

This method has no parameters.

<a name='M-Bb-Extensions-SettingsExtensions-WithAutoRedirect``1-``0,System-Boolean-'></a>
### WithAutoRedirect\`\`1(obj,enabled) `method`

##### Summary

Configures whether redirects are automatically followed.

##### Returns

This IUrlClient or IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0](#T-``0 '``0') | The IUrlClient or IUrlRequest. |
| enabled | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if Url should automatically send a new request to the redirect URL, false if it should not. |

<a name='M-Bb-Extensions-SettingsExtensions-WithTimeout``1-``0,System-TimeSpan-'></a>
### WithTimeout\`\`1(obj,timespan) `method`

##### Summary

Sets the timeout for this IUrlRequest or all requests made with this IUrlClient.

##### Returns

This IUrlClient or IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0](#T-``0 '``0') | The IUrlClient or IUrlRequest. |
| timespan | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan 'System.TimeSpan') | Time to wait before the request times out. |

<a name='M-Bb-Extensions-SettingsExtensions-WithTimeout``1-``0,System-Int32-'></a>
### WithTimeout\`\`1(obj,seconds) `method`

##### Summary

Sets the timeout for this IUrlRequest or all requests made with this IUrlClient.

##### Returns

This IUrlClient or IUrlRequest.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`\`0](#T-``0 '``0') | The IUrlClient or IUrlRequest. |
| seconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Seconds to wait before the request times out. |

<a name='T-Bb-Url'></a>
## Url `type`

##### Namespace

Bb

##### Summary

A mutable object for fluently building and parsing URLs.

<a name='M-Bb-Url-#ctor-System-String,System-String,System-Int32,System-String[]-'></a>
### #ctor(scheme,host,port,segments) `constructor`

##### Summary

Constructs a Url object from another Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

##### Example

```csharp
    var url = new Url("api.example.com", 80, "api", "v1");
```

<a name='M-Bb-Url-#ctor-System-String-'></a>
### #ctor(baseUrl) `constructor`

##### Summary

Constructs a Url object from a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| baseUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL to use as a starting point. |

##### Example

```csharp
    var url = new Url("https://api.example.com:80");
```

<a name='M-Bb-Url-#ctor-System-Uri,System-String[]-'></a>
### #ctor(uri) `constructor`

##### Summary

Constructs a Url object from a System.Uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The System.Uri (required) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `uri` is `null`. |

##### Example

```csharp
    var url = new Url(new Uri("http://api.example.com:80"), "api", "v1");
```

<a name='P-Bb-Url-Authority'></a>
### Authority `property`

##### Summary

i.e. "www.site.com:8080" in "https://www.site.com:8080/path". Includes both user info and port, if included.

<a name='P-Bb-Url-Fragment'></a>
### Fragment `property`

##### Summary

i.e. "fragment" in "https://www.site.com/path?x=y#frag". Does not include "#".

<a name='P-Bb-Url-Host'></a>
### Host `property`

##### Summary

i.e. "www.site.com" in "https://www.site.com:8080/path". Does not include user info or port.

<a name='P-Bb-Url-IsRelative'></a>
### IsRelative `property`

##### Summary

True if URL does not start with a non-empty scheme. i.e. false for "https://www.site.com", true for "//www.site.com".

<a name='P-Bb-Url-IsSecureScheme'></a>
### IsSecureScheme `property`

##### Summary

True if Url is absolute and scheme is https or wss.

<a name='P-Bb-Url-Path'></a>
### Path `property`

##### Summary

i.e. "/path" in "https://www.site.com/path". Empty string if not present. Leading and trailing "/" retained exactly as specified by user.

<a name='P-Bb-Url-PathSegments'></a>
### PathSegments `property`

##### Summary

The "/"-delimited segments of the path, not including leading or trailing "/" characters.

<a name='P-Bb-Url-Port'></a>
### Port `property`

##### Summary

Port number of the URL. Null if not explicitly specified.

<a name='P-Bb-Url-Query'></a>
### Query `property`

##### Summary

i.e. "x=1&y=2" in "https://www.site.com/path?x=1&y=2". Does not include "?".

<a name='P-Bb-Url-QueryParams'></a>
### QueryParams `property`

##### Summary

Query parsed to name/value pairs.

<a name='P-Bb-Url-Root'></a>
### Root `property`

##### Summary

i.e. "https://www.site.com:8080" in "https://www.site.com:8080/path" (everything before the path).

<a name='P-Bb-Url-Scheme'></a>
### Scheme `property`

##### Summary

The scheme of the URL, i.e. "http". Does not include ":" delimiter. Empty string if the URL is relative.

<a name='P-Bb-Url-UserInfo'></a>
### UserInfo `property`

##### Summary

i.e. "user:pass" in "https://user:pass@www.site.com". Empty string if not present.

<a name='M-Bb-Url-Clone'></a>
### Clone() `method`

##### Summary

Creates a copy of this Url.

##### Parameters

This method has no parameters.

<a name='M-Bb-Url-Combine-System-String[]-'></a>
### Combine(parts) `method`

##### Summary

Basically a Path.Combine for URLs. Ensures exactly one '/' separates each segment,
and exactly on '&' separates each query parameter.
URL-encodes illegal characters but not reserved characters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parts | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | URL parts to combine. |

<a name='M-Bb-Url-Decode-System-String,System-Boolean-'></a>
### Decode(s,interpretPlusAsSpace) `method`

##### Summary

Decodes a URL-encoded string.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL-encoded string. |
| interpretPlusAsSpace | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, any '+' character will be decoded to a space. |

<a name='M-Bb-Url-Encode-System-String,System-Boolean-'></a>
### Encode(s,encodeSpaceAsPlus) `method`

##### Summary

URL-encodes a string, including reserved characters such as '/' and '?'.

##### Returns

The encoded URL.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to encode. |
| encodeSpaceAsPlus | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, spaces will be encoded as + signs. Otherwise, they'll be encoded as %20. |

<a name='M-Bb-Url-EncodeIllegalCharacters-System-String,System-Boolean-'></a>
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

<a name='M-Bb-Url-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

True if obj is an instance of Url and its string representation is equal to this instance's string representation.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to compare to this instance. |

<a name='M-Bb-Url-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Returns the hash code for this Url.

##### Parameters

This method has no parameters.

<a name='M-Bb-Url-IsValid-System-String-'></a>
### IsValid(url) `method`

##### Summary

Checks if a string is a well-formed absolute URL.

##### Returns

true if the string is a well-formed absolute URL

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to check |

<a name='M-Bb-Url-Parse-System-String-'></a>
### Parse() `method`

##### Summary

Parses a URL string into a Url object.

##### Parameters

This method has no parameters.

<a name='M-Bb-Url-ParsePathSegment-System-String-'></a>
### ParsePathSegment(path) `method`

##### Summary

Splits the given path into segments, encoding illegal characters, "?", and "#".

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path to split. |

<a name='M-Bb-Url-ParseQueryParam-System-String-'></a>
### ParseQueryParam(query) `method`

##### Summary

Parses a URL query to a QueryParamCollection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL query to parse. |

<a name='M-Bb-Url-RemoveFragment'></a>
### RemoveFragment() `method`

##### Summary

Removes the URL fragment including the #.

##### Returns

The Url object with the fragment removed

##### Parameters

This method has no parameters.

<a name='M-Bb-Url-RemovePath'></a>
### RemovePath() `method`

##### Summary

Removes the entire path component of the URL, including the leading slash.

##### Returns

The Url object.

##### Parameters

This method has no parameters.

<a name='M-Bb-Url-RemovePathSegment'></a>
### RemovePathSegment() `method`

##### Summary

Removes the last path segment from the URL.

##### Returns

The Url object.

##### Parameters

This method has no parameters.

<a name='M-Bb-Url-RemoveQuery'></a>
### RemoveQuery() `method`

##### Summary

Removes the entire query component of the URL.

##### Returns

The Url object.

##### Parameters

This method has no parameters.

<a name='M-Bb-Url-RemoveQueryParam-System-String-'></a>
### RemoveQueryParam(name) `method`

##### Summary

Removes a name/value pair from the query by name.

##### Returns

The Url object with the query parameter removed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Query string parameter name to remove |

<a name='M-Bb-Url-RemoveQueryParam-System-String[]-'></a>
### RemoveQueryParam(names) `method`

##### Summary

Removes multiple name/value pairs from the query by name.

##### Returns

The Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Query string parameter names to remove |

<a name='M-Bb-Url-RemoveQueryParam-System-Collections-Generic-IEnumerable{System-String}-'></a>
### RemoveQueryParam(names) `method`

##### Summary

Removes multiple name/value pairs from the query by name.

##### Returns

The Url object with the query parameters removed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| names | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Query string parameter names to remove |

<a name='M-Bb-Url-Reset'></a>
### Reset() `method`

##### Summary

Resets the URL to its original state as set in the constructor.

##### Parameters

This method has no parameters.

<a name='M-Bb-Url-ResetToRoot'></a>
### ResetToRoot() `method`

##### Summary

Resets the URL to its root, including the scheme, any user info, host, and port (if specified).

##### Returns

The Url object trimmed to its root.

##### Parameters

This method has no parameters.

<a name='M-Bb-Url-SetFragment-System-String-'></a>
### SetFragment(fragment) `method`

##### Summary

Set the URL fragment fluently.

##### Returns

The Url object with the new fragment set

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fragment | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The part of the URL after # |

<a name='M-Bb-Url-ToString-System-Boolean-'></a>
### ToString(encodeSpaceAsPlus) `method`

##### Summary

Converts this Url object to its string representation.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encodeSpaceAsPlus | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicates whether to encode spaces with the "+" character instead of "%20" |

<a name='M-Bb-Url-ToString'></a>
### ToString() `method`

##### Summary

Converts this Url object to its string representation.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Bb-Url-ToUri'></a>
### ToUri() `method`

##### Summary

Converts this Url object to System.Uri

##### Returns

The System.Uri object

##### Parameters

This method has no parameters.

<a name='M-Bb-Url-WithPathSegment-System-Object,System-Boolean-'></a>
### WithPathSegment(segment,fullyEncode) `method`

##### Summary

Appends a segment to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

the Url object with the segment appended

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| segment | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The segment to append |
| fullyEncode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, URL-encodes reserved characters such as '/', '+', and '%'. Otherwise, only encodes strictly illegal characters (including '%' but only when not followed by 2 hex characters). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `segment` is `null`. |

<a name='M-Bb-Url-WithPathSegment-System-Object[]-'></a>
### WithPathSegment(segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

the Url object with the segments appended

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| segments | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | The segments to append |

<a name='M-Bb-Url-WithPathSegment-System-Collections-Generic-IEnumerable{System-Object}-'></a>
### WithPathSegment(segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

the Url object with the segments appended

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| segments | [System.Collections.Generic.IEnumerable{System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Object}') | The segments to append |

<a name='M-Bb-Url-WithQueryParam-System-String,System-Object,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Url-WithQueryParam-System-String,System-String,System-Boolean,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Url-WithQueryParam-System-String-'></a>
### WithQueryParam(name) `method`

##### Summary

Adds a parameter without a value to the query, removing any existing value.

##### Returns

The Url object with the query parameter added

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |

<a name='M-Bb-Url-WithQueryParam-System-Object,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Url-WithQueryParam-System-Collections-Generic-IEnumerable{System-String}-'></a>
### WithQueryParam(names) `method`

##### Summary

Adds multiple parameters without values to the query.

##### Returns

The Url object with the query parameter added

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| names | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Names of query parameters. |

<a name='M-Bb-Url-WithQueryParam-System-String[]-'></a>
### WithQueryParam(names) `method`

##### Summary

Adds multiple parameters without values to the query.

##### Returns

The Url object with the query parameter added.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Names of query parameters |

<a name='M-Bb-Url-op_Implicit-Bb-Url-~System-Uri'></a>
### op_Implicit(url) `method`

##### Summary

Implicit conversion from Url to System.Uri.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url)~System.Uri](#T-Bb-Url-~System-Uri 'Bb.Url)~System.Uri') |  |

<a name='M-Bb-Url-op_Implicit-System-Uri-~Bb-Url'></a>
### op_Implicit() `method`

##### Summary

Implicit conversion from System.Uri to Url.

##### Returns

The string

##### Parameters

This method has no parameters.

<a name='M-Bb-Url-op_Implicit-Bb-Url-~System-String'></a>
### op_Implicit(url) `method`

##### Summary

Implicit conversion from Url to String.

##### Returns

The string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url)~System.String](#T-Bb-Url-~System-String 'Bb.Url)~System.String') | The Url object |

<a name='M-Bb-Url-op_Implicit-System-String-~Bb-Url'></a>
### op_Implicit(url) `method`

##### Summary

Implicit conversion from String to Url.

##### Returns

The string

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String)~Bb.Url](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String)~Bb.Url 'System.String)~Bb.Url') | The String representation of the URL |

<a name='T-Bb-Extensions-UrlBuilderExtensions'></a>
## UrlBuilderExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

URL builder extension methods on UrlRequest

<a name='M-Bb-Extensions-UrlBuilderExtensions-AppendPathSegment-Bb-Http-IUrlRequest,System-Object,System-Boolean-'></a>
### AppendPathSegment(request,segment,fullyEncode) `method`

##### Summary

Appends a segment to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| segment | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The segment to append |
| fullyEncode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, URL-encodes reserved characters such as '/', '+', and '%'. Otherwise, only encodes strictly illegal characters (including '%' but only when not followed by 2 hex characters). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `segment` is `null`. |

<a name='M-Bb-Extensions-UrlBuilderExtensions-AppendPathSegment-Bb-Http-IUrlRequest,System-Object[]-'></a>
### AppendPathSegment(request,segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| segments | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | The segments to append |

<a name='M-Bb-Extensions-UrlBuilderExtensions-AppendPathSegment-Bb-Http-IUrlRequest,System-Collections-Generic-IEnumerable{System-Object}-'></a>
### AppendPathSegment(request,segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| segments | [System.Collections.Generic.IEnumerable{System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Object}') | The segments to append |

<a name='M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-String,System-Object,Bb-NullValueHandling-'></a>
### QueryParam(request,name,value,nullValueHandling) `method`

##### Summary

Adds a parameter to the URL query, overwriting the value if name exists.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |
| value | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Value of query parameter |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing) |

<a name='M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-String,System-String,System-Boolean,Bb-NullValueHandling-'></a>
### QueryParam(request,name,value,isEncoded,nullValueHandling) `method`

##### Summary

Adds a parameter to the URL query, overwriting the value if name exists.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value of query parameter |
| isEncoded | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Set to true to indicate the value is already URL-encoded |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | `name` is `null`. |

<a name='M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-String-'></a>
### QueryParam(request,name) `method`

##### Summary

Adds a parameter without a value to the URL query, removing any existing value.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of query parameter |

<a name='M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-Object,Bb-NullValueHandling-'></a>
### QueryParam(request,values,nullValueHandling) `method`

##### Summary

Parses values (usually an anonymous object or dictionary) into name/value pairs and adds them to the URL query, overwriting any that already exist.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| values | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Typically an anonymous object, ie: new { x = 1, y = 2 } |
| nullValueHandling | [Bb.NullValueHandling](#T-Bb-NullValueHandling 'Bb.NullValueHandling') | Indicates how to handle null values. Defaults to Remove (any existing) |

<a name='M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-Collections-Generic-IEnumerable{System-String}-'></a>
### QueryParam(request,names) `method`

##### Summary

Adds multiple parameters without values to the URL query.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| names | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Names of query parameters. |

<a name='M-Bb-Extensions-UrlBuilderExtensions-QueryParam-Bb-Http-IUrlRequest,System-String[]-'></a>
### QueryParam(request,names) `method`

##### Summary

Adds multiple parameters without values to the URL query.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Names of query parameters |

<a name='M-Bb-Extensions-UrlBuilderExtensions-RemoveFragment-Bb-Http-IUrlRequest-'></a>
### RemoveFragment(request) `method`

##### Summary

Removes the URL fragment including the #.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |

<a name='M-Bb-Extensions-UrlBuilderExtensions-RemoveQueryParam-Bb-Http-IUrlRequest,System-String-'></a>
### RemoveQueryParam(request,name) `method`

##### Summary

Removes a name/value pair from the URL query by name.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Query string parameter name to remove |

<a name='M-Bb-Extensions-UrlBuilderExtensions-RemoveQueryParam-Bb-Http-IUrlRequest,System-String[]-'></a>
### RemoveQueryParam(request,names) `method`

##### Summary

Removes multiple name/value pairs from the URL query by name.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Query string parameter names to remove |

<a name='M-Bb-Extensions-UrlBuilderExtensions-RemoveQueryParam-Bb-Http-IUrlRequest,System-Collections-Generic-IEnumerable{System-String}-'></a>
### RemoveQueryParam(request,names) `method`

##### Summary

Removes multiple name/value pairs from the URL query by name.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| names | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | Query string parameter names to remove |

<a name='M-Bb-Extensions-UrlBuilderExtensions-SetFragment-Bb-Http-IUrlRequest,System-String-'></a>
### SetFragment(request,fragment) `method`

##### Summary

Set the URL fragment fluently.

##### Returns

This IUrlRequest

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [Bb.Http.IUrlRequest](#T-Bb-Http-IUrlRequest 'Bb.Http.IUrlRequest') | The IUrlRequest associated with the URL |
| fragment | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The part of the URL afer # |

<a name='T-Bb-Http-UrlCall'></a>
## UrlCall `type`

##### Namespace

Bb.Http

##### Summary

Encapsulates request, response, and other details associated with an HTTP call. Useful for diagnostics and available in
global event handlers and UrlHttpException.Call.

<a name='F-Bb-Http-UrlCall-_time'></a>
### _time `constants`

##### Summary

Total duration of the call if it completed, otherwise null.

<a name='P-Bb-Http-UrlCall-Completed'></a>
### Completed `property`

##### Summary

True if a response was received, regardless of whether it is an error status.

<a name='P-Bb-Http-UrlCall-Exception'></a>
### Exception `property`

##### Summary

Exception that occurred while sending the HttpRequestMessage.

<a name='P-Bb-Http-UrlCall-ExceptionHandled'></a>
### ExceptionHandled `property`

##### Summary

User code should set this to true inside global event handlers (OnError, etc) to indicate
that the exception was handled and should not be propagated further.

<a name='P-Bb-Http-UrlCall-HttpRequestMessage'></a>
### HttpRequestMessage `property`

##### Summary

The raw HttpRequestMessage associated with this call.

<a name='P-Bb-Http-UrlCall-HttpResponseMessage'></a>
### HttpResponseMessage `property`

##### Summary

The raw HttpResponseMessage associated with the call if the call completed, otherwise null.

<a name='P-Bb-Http-UrlCall-Redirect'></a>
### Redirect `property`

##### Summary

If this call has a 3xx response and Location header, contains information about how to handle the redirect.
Otherwise null.

<a name='P-Bb-Http-UrlCall-Request'></a>
### Request `property`

##### Summary

The IUrlRequest associated with this call.

<a name='P-Bb-Http-UrlCall-RequestBody'></a>
### RequestBody `property`

##### Summary

Captured request body. Available ONLY if HttpRequestMessage.Content is a Url.Http.Content.CapturedStringContent.

<a name='P-Bb-Http-UrlCall-Response'></a>
### Response `property`

##### Summary

The IUrlResponse associated with this call if the call completed, otherwise null.

<a name='P-Bb-Http-UrlCall-StartedUtc'></a>
### StartedUtc `property`

##### Summary

DateTime the moment the request was sent.

<a name='P-Bb-Http-UrlCall-Succeeded'></a>
### Succeeded `property`

##### Summary

True if response was received with any success status or a match with AllowedHttpStatusRange setting.

<a name='P-Bb-Http-UrlCall-Time'></a>
### Time `property`

##### Summary

Elapsed time

<a name='M-Bb-Http-UrlCall-ToString'></a>
### ToString() `method`

##### Summary

Returns the verb and absolute URI associated with this call.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Bb-Http-UrlClient'></a>
## UrlClient `type`

##### Namespace

Bb.Http

##### Summary

A reusable object for making HTTP calls.

<a name='M-Bb-Http-UrlClient-#ctor-System-String-'></a>
### #ctor(baseUrl) `constructor`

##### Summary

Initializes a new instance of [UrlClient](#T-Bb-Http-UrlClient 'Bb.Http.UrlClient').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| baseUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base URL associated with this client. |

<a name='M-Bb-Http-UrlClient-#ctor-System-Net-Http-HttpClient,System-String-'></a>
### #ctor(httpClient,baseUrl) `constructor`

##### Summary

Initializes a new instance of [UrlClient](#T-Bb-Http-UrlClient 'Bb.Http.UrlClient'), wrapping an existing HttpClient.
Generally, you should let Url create and manage HttpClient instances for you, but you might, for
example, have an HttpClient instance that was created by a 3rd-party library and you want to use
Url to build and send calls with it. Be aware that if the HttpClient has an underlying
HttpMessageHandler that processes cookies and automatic redirects (as is the case by default),
Url's re-implementation of those features may not work properly.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| httpClient | [System.Net.Http.HttpClient](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpClient 'System.Net.Http.HttpClient') | The instantiated HttpClient instance. |
| baseUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base URL associated with this client. |

<a name='P-Bb-Http-UrlClient-BaseUrl'></a>
### BaseUrl `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlClient-Headers'></a>
### Headers `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlClient-HttpClient'></a>
### HttpClient `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlClient-IsDisposed'></a>
### IsDisposed `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlClient-Settings'></a>
### Settings `property`

##### Summary

*Inherit from parent.*

<a name='M-Bb-Http-UrlClient-Dispose'></a>
### Dispose() `method`

##### Summary

Disposes the underlying HttpClient and HttpMessageHandler.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-UrlClient-Request-System-Object[]-'></a>
### Request() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-UrlClient-SendAsync-Bb-Http-IUrlRequest,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-Configuration-UrlClientFactoryBase'></a>
## UrlClientFactoryBase `type`

##### Namespace

Bb.Http.Configuration

##### Summary

Encapsulates a creation/caching strategy for IUrlClient instances. Custom factories looking to extend
Url's behavior should inherit from this class, rather than implementing IUrlClientFactory directly.

<a name='M-Bb-Http-Configuration-UrlClientFactoryBase-Create-Bb-Url-'></a>
### Create(url) `method`

##### Summary

Creates a new UrlClient

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | The URL (not used) |

<a name='M-Bb-Http-Configuration-UrlClientFactoryBase-CreateHttpClient-System-Net-Http-HttpMessageHandler-'></a>
### CreateHttpClient() `method`

##### Summary

Override in custom factory to customize the creation of HttpClient used in all Url HTTP calls
(except when one is passed explicitly to the UrlClient constructor). In order not to lose
Url.Http functionality, it is recommended to call base.CreateClient and customize the result.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Configuration-UrlClientFactoryBase-CreateMessageHandler'></a>
### CreateMessageHandler() `method`

##### Summary

Override in custom factory to customize the creation of the top-level HttpMessageHandler used in all
Url HTTP calls (except when an HttpClient is passed explicitly to the UrlClient constructor).
In order not to lose Url.Http functionality, it is recommended to call base.CreateMessageHandler, and
either customize the returned HttpClientHandler, or set it as the InnerHandler of a DelegatingHandler.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Configuration-UrlClientFactoryBase-Dispose'></a>
### Dispose() `method`

##### Summary

Disposes all cached IUrlClient instances and clears the cache.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Configuration-UrlClientFactoryBase-Get-Bb-Url-'></a>
### Get(url) `method`

##### Summary

By default, uses a caching strategy of one UrlClient per host. This maximizes reuse of
underlying HttpClient/Handler while allowing things like cookies to be host-specific.

##### Returns

The UrlClient instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | The URL. |

<a name='M-Bb-Http-Configuration-UrlClientFactoryBase-GetCacheKey-Bb-Url-'></a>
### GetCacheKey(url) `method`

##### Summary

Defines a strategy for getting a cache key based on a Url. Default implementation
returns the host part (i.e www.api.com) so that all calls to the same host use the
same UrlClient (and HttpClient/HttpMessageHandler) instance.

##### Returns

The cache key

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | The URL. |

<a name='T-Bb-Extensions-UrlClientFactoryExtensions'></a>
## UrlClientFactoryExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Extension methods on IUrlClientFactory

<a name='M-Bb-Extensions-UrlClientFactoryExtensions-ConfigureClient-Bb-Http-Configuration-IUrlClientFactory,System-String,System-Action{Bb-Http-IUrlClient}-'></a>
### ConfigureClient(factory,url,configAction) `method`

##### Summary

Provides thread-safe access to a specific IUrlClient, typically to configure settings and default headers.
The URL is used to find the client, but keep in mind that the same client will be used in all calls to the same host by default.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| factory | [Bb.Http.Configuration.IUrlClientFactory](#T-Bb-Http-Configuration-IUrlClientFactory 'Bb.Http.Configuration.IUrlClientFactory') | This IUrlClientFactory. |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the URL used to find the IUrlClient. |
| configAction | [System.Action{Bb.Http.IUrlClient}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.IUrlClient}') | the action to perform against the IUrlClient. |

<a name='M-Bb-Extensions-UrlClientFactoryExtensions-CreateHttpClient-Bb-Http-Configuration-IUrlClientFactory-'></a>
### CreateHttpClient() `method`

##### Summary

Creates an HttpClient with the HttpMessageHandler returned from this factory's CreateMessageHandler method.

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-UrlCookie'></a>
## UrlCookie `type`

##### Namespace

Bb.Http

##### Summary

Represents an HTTP cookie. Closely matches Set-Cookie response header.

<a name='M-Bb-Http-UrlCookie-#ctor-System-String,System-String,System-String,System-Nullable{System-DateTimeOffset}-'></a>
### #ctor(name,value,originUrl,dateReceived) `constructor`

##### Summary

Creates a new UrlCookie.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the cookie. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value of the cookie. |
| originUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | URL of request that sent the original Set-Cookie header. |
| dateReceived | [System.Nullable{System.DateTimeOffset}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTimeOffset}') | Date/time that original Set-Cookie header was received. Defaults to current date/time. Important for Max-Age to be enforced correctly. |

<a name='P-Bb-Http-UrlCookie-DateReceived'></a>
### DateReceived `property`

##### Summary

Date and time the cookie was received. Defaults to date/time this UrlCookie was created.
Important for Max-Age to be enforced correctly.

<a name='P-Bb-Http-UrlCookie-Domain'></a>
### Domain `property`

##### Summary

Corresponds to the Domain attribute of the Set-Cookie header.

<a name='P-Bb-Http-UrlCookie-Expires'></a>
### Expires `property`

##### Summary

Corresponds to the Expires attribute of the Set-Cookie header.

<a name='P-Bb-Http-UrlCookie-HttpOnly'></a>
### HttpOnly `property`

##### Summary

Corresponds to the HttpOnly attribute of the Set-Cookie header.

<a name='P-Bb-Http-UrlCookie-MaxAge'></a>
### MaxAge `property`

##### Summary

Corresponds to the Max-Age attribute of the Set-Cookie header.

<a name='P-Bb-Http-UrlCookie-Name'></a>
### Name `property`

##### Summary

The cookie name.

<a name='P-Bb-Http-UrlCookie-OriginUrl'></a>
### OriginUrl `property`

##### Summary

The URL that originally sent the Set-Cookie response header. If adding to a CookieJar, this is required unless
both Domain AND Path are specified.

<a name='P-Bb-Http-UrlCookie-Path'></a>
### Path `property`

##### Summary

Corresponds to the Path attribute of the Set-Cookie header.

<a name='P-Bb-Http-UrlCookie-SameSite'></a>
### SameSite `property`

##### Summary

Corresponds to the SameSite attribute of the Set-Cookie header.

<a name='P-Bb-Http-UrlCookie-Secure'></a>
### Secure `property`

##### Summary

Corresponds to the Secure attribute of the Set-Cookie header.

<a name='P-Bb-Http-UrlCookie-Value'></a>
### Value `property`

##### Summary

The cookie value.

<a name='M-Bb-Http-UrlCookie-GetKey'></a>
### GetKey() `method`

##### Summary

Generates a key based on cookie Name, Domain, and Path (using OriginalUrl in the absence of Domain/Path).
Used by CookieJar to determine whether to add a cookie or update an existing one.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-UrlCookie-Lock'></a>
### Lock() `method`

##### Summary

Makes this cookie immutable. Call when added to a jar.

##### Parameters

This method has no parameters.

<a name='T-Bb-UrlExtension'></a>
## UrlExtension `type`

##### Namespace

Bb

<a name='M-Bb-UrlExtension-ConcatUrl-System-Collections-Generic-IEnumerable{Bb-Url}-'></a>
### ConcatUrl(urls) `method`

##### Summary

return a [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') with Concatenated url separated by ';'.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urls | [System.Collections.Generic.IEnumerable{Bb.Url}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Bb.Url}') | [Url](#T-Bb-Url 'Bb.Url') |

<a name='M-Bb-UrlExtension-ConcatUrl-System-Text-StringBuilder,System-Collections-Generic-IEnumerable{Bb-Url}-'></a>
### ConcatUrl(sb,urls) `method`

##### Summary

return a [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') with Concatenated url separated by ';'.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sb | [System.Text.StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') | [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') |
| urls | [System.Collections.Generic.IEnumerable{Bb.Url}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Bb.Url}') | [Url](#T-Bb-Url 'Bb.Url') |

<a name='T-Bb-Extensions-UrlExtensions'></a>
## UrlExtensions `type`

##### Namespace

Bb.Extensions

##### Summary

Fluent URL-building extension methods on String and Uri.

<a name='M-Bb-Extensions-UrlExtensions-RemoveFragment-System-String-'></a>
### RemoveFragment(url) `method`

##### Summary

Removes the URL fragment including the #.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Extensions-UrlExtensions-RemovePath-System-String-'></a>
### RemovePath(url) `method`

##### Summary

Removes the entire path component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Extensions-UrlExtensions-RemovePathSegment-System-String-'></a>
### RemovePathSegment(url) `method`

##### Summary

Removes the last path segment from the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Extensions-UrlExtensions-RemoveQuery-System-String-'></a>
### RemoveQuery(url) `method`

##### Summary

Removes the entire query component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Extensions-UrlExtensions-RemoveQueryParam-System-String,System-String-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-RemoveQueryParam-System-String,System-String[]-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-RemoveQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-ResetToRoot-System-String-'></a>
### ResetToRoot(url) `method`

##### Summary

Trims the URL to its root, including the scheme, any user info, host, and port (if specified).

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Extensions-UrlExtensions-SetFragment-System-String,System-String-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-String,System-Object,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-String,System-String,System-Boolean,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-String-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-Object,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-SetQueryParam-System-String,System-String[]-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-WithFragment-System-Uri,System-String-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-WithPathSegment-System-String,System-Object,System-Boolean-'></a>
### WithPathSegment(url,segment,fullyEncode) `method`

##### Summary

Creates a new Url object from the string and appends a segment to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| segment | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The segment to append |
| fullyEncode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, URL-encodes reserved characters such as '/', '+', and '%'. Otherwise, only encodes strictly illegal characters (including '%' but only when not followed by 2 hex characters). |

<a name='M-Bb-Extensions-UrlExtensions-WithPathSegment-System-String,System-Object[]-'></a>
### WithPathSegment(url,segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| segments | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | The segments to append |

<a name='M-Bb-Extensions-UrlExtensions-WithPathSegment-System-String,System-Collections-Generic-IEnumerable{System-Object}-'></a>
### WithPathSegment(url,segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |
| segments | [System.Collections.Generic.IEnumerable{System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Object}') | The segments to append |

<a name='M-Bb-Extensions-UrlExtensions-WithPathSegment-System-Uri,System-Object,System-Boolean-'></a>
### WithPathSegment(uri,segment,fullyEncode) `method`

##### Summary

Creates a new Url object from the string and appends a segment to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| segment | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The segment to append |
| fullyEncode | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, URL-encodes reserved characters such as '/', '+', and '%'. Otherwise, only encodes strictly illegal characters (including '%' but only when not followed by 2 hex characters). |

<a name='M-Bb-Extensions-UrlExtensions-WithPathSegment-System-Uri,System-Object[]-'></a>
### WithPathSegment(uri,segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| segments | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | The segments to append |

<a name='M-Bb-Extensions-UrlExtensions-WithPathSegment-System-Uri,System-Collections-Generic-IEnumerable{System-Object}-'></a>
### WithPathSegment(uri,segments) `method`

##### Summary

Appends multiple segments to the URL path, ensuring there is one and only one '/' character as a separator.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
| segments | [System.Collections.Generic.IEnumerable{System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Object}') | The segments to append |

<a name='M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-String,System-Object,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-String,System-String,System-Boolean,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-String-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-Object,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-WithQueryParam-System-Uri,System-String[]-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-WithRemoveFragment-System-Uri-'></a>
### WithRemoveFragment(uri) `method`

##### Summary

Removes the URL fragment including the #.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Extensions-UrlExtensions-WithRemovePath-System-Uri-'></a>
### WithRemovePath(uri) `method`

##### Summary

Removes the entire path component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Extensions-UrlExtensions-WithRemovePathSegment-System-Uri-'></a>
### WithRemovePathSegment(uri) `method`

##### Summary

Removes the last path segment from the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Extensions-UrlExtensions-WithRemoveQuery-System-Uri-'></a>
### WithRemoveQuery(uri) `method`

##### Summary

Removes the entire query component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Extensions-UrlExtensions-WithRemoveQueryParam-System-Uri,System-String-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-WithRemoveQueryParam-System-Uri,System-String[]-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-WithRemoveQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}-'></a>
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

<a name='M-Bb-Extensions-UrlExtensions-WithResetToRoot-System-Uri-'></a>
### WithResetToRoot(uri) `method`

##### Summary

Trims the URL to its root, including the scheme, any user info, host, and port (if specified).

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='T-Bb-Http-UrlHttp'></a>
## UrlHttp `type`

##### Namespace

Bb.Http

##### Summary

A static container for global configuration settings affecting Url.Http behavior.

<a name='P-Bb-Http-UrlHttp-GlobalSettings'></a>
### GlobalSettings `property`

##### Summary

Globally configured Url.Http settings. Should normally be written to by calling UrlHttp.Configure once application at startup.

<a name='M-Bb-Http-UrlHttp-Configure-System-Action{Bb-Http-Configuration-GlobalUrlHttpSettings}-'></a>
### Configure(configAction) `method`

##### Summary

Provides thread-safe access to Url.Http's global configuration settings. Should only be called once at application startup.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configAction | [System.Action{Bb.Http.Configuration.GlobalUrlHttpSettings}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.Configuration.GlobalUrlHttpSettings}') | the action to perform against the GlobalSettings. |

<a name='M-Bb-Http-UrlHttp-ConfigureClient-System-String,System-Action{Bb-Http-IUrlClient}-'></a>
### ConfigureClient(url,configAction) `method`

##### Summary

Provides thread-safe access to a specific IUrlClient, typically to configure settings and default headers.
The URL is used to find the client, but keep in mind that the same client will be used in all calls to the same host by default.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the URL used to find the IUrlClient. |
| configAction | [System.Action{Bb.Http.IUrlClient}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Bb.Http.IUrlClient}') | the action to perform against the IUrlClient. |

<a name='T-Bb-Http-UrlHttpException'></a>
## UrlHttpException `type`

##### Namespace

Bb.Http

##### Summary

An exception that is thrown when an HTTP call made by Url.Http fails, including when the response
indicates an unsuccessful HTTP status code.

<a name='M-Bb-Http-UrlHttpException-#ctor-Bb-Http-UrlCall,System-String,System-Exception-'></a>
### #ctor(call,message,inner) `constructor`

##### Summary

Initializes a new instance of the [UrlHttpException](#T-Bb-Http-UrlHttpException 'Bb.Http.UrlHttpException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| call | [Bb.Http.UrlCall](#T-Bb-Http-UrlCall 'Bb.Http.UrlCall') | The call. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |
| inner | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The inner. |

<a name='M-Bb-Http-UrlHttpException-#ctor-Bb-Http-UrlCall,System-Exception-'></a>
### #ctor(call,inner) `constructor`

##### Summary

Initializes a new instance of the [UrlHttpException](#T-Bb-Http-UrlHttpException 'Bb.Http.UrlHttpException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| call | [Bb.Http.UrlCall](#T-Bb-Http-UrlCall 'Bb.Http.UrlCall') | The call. |
| inner | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The inner. |

<a name='M-Bb-Http-UrlHttpException-#ctor-Bb-Http-UrlCall-'></a>
### #ctor(call) `constructor`

##### Summary

Initializes a new instance of the [UrlHttpException](#T-Bb-Http-UrlHttpException 'Bb.Http.UrlHttpException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| call | [Bb.Http.UrlCall](#T-Bb-Http-UrlCall 'Bb.Http.UrlCall') | The call. |

<a name='P-Bb-Http-UrlHttpException-Call'></a>
### Call `property`

##### Summary

An object containing details about the failed HTTP call

<a name='P-Bb-Http-UrlHttpException-StatusCode'></a>
### StatusCode `property`

##### Summary

Gets the HTTP status code of the response if a response was received, otherwise null.

<a name='M-Bb-Http-UrlHttpException-GetResponseJsonAsync``1'></a>
### GetResponseJsonAsync\`\`1() `method`

##### Summary

Deserializes the JSON response body to an object of the given type.

##### Returns

A task whose result is an object containing data in the response body.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | A type whose structure matches the expected JSON response. |

<a name='M-Bb-Http-UrlHttpException-GetResponseStringAsync'></a>
### GetResponseStringAsync() `method`

##### Summary

Gets the response body of the failed call.

##### Returns

A task whose result is the string contents of the response body.

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-Configuration-UrlHttpSettings'></a>
## UrlHttpSettings `type`

##### Namespace

Bb.Http.Configuration

##### Summary

A set of properties that affect Url.Http behavior

<a name='M-Bb-Http-Configuration-UrlHttpSettings-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a new UrlHttpSettings object.

##### Parameters

This constructor has no parameters.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-AfterCall'></a>
### AfterCall `property`

##### Summary

Gets or sets a callback that is invoked immediately after every HTTP response is received.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-AfterCallAsync'></a>
### AfterCallAsync `property`

##### Summary

Gets or sets a callback that is invoked asynchronously immediately after every HTTP response is received.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-AllowedHttpStatusRange'></a>
### AllowedHttpStatusRange `property`

##### Summary

Gets or sets a pattern representing a range of HTTP status codes which (in addtion to 2xx) will NOT result in Url.Http throwing an Exception.
Examples: "3xx", "100,300,600", "100-299,6xx", "*" (allow everything)
2xx will never throw regardless of this setting.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-BeforeCall'></a>
### BeforeCall `property`

##### Summary

Gets or sets a callback that is invoked immediately before every HTTP request is sent.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-BeforeCallAsync'></a>
### BeforeCallAsync `property`

##### Summary

Gets or sets a callback that is invoked asynchronously immediately before every HTTP request is sent.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-Defaults'></a>
### Defaults `property`

##### Summary

Gets or sets the default values to fall back on when values are not explicitly set on this instance.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-JsonSerializer'></a>
### JsonSerializer `property`

##### Summary

Gets or sets object used to serialize and deserialize JSON. Default implementation uses Newtonsoft Json.NET.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-OnError'></a>
### OnError `property`

##### Summary

Gets or sets a callback that is invoked when an error occurs during any HTTP call, including when any non-success
HTTP status code is returned in the response. Response should be null-checked if used in the event handler.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-OnErrorAsync'></a>
### OnErrorAsync `property`

##### Summary

Gets or sets a callback that is invoked asynchronously when an error occurs during any HTTP call, including when any non-success
HTTP status code is returned in the response. Response should be null-checked if used in the event handler.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-OnRedirect'></a>
### OnRedirect `property`

##### Summary

Gets or sets a callback that is invoked when any 3xx response with a Location header is received.
You can inspect/manipulate the call.Redirect object to determine what will happen next.
An auto-redirect will only happen if call.Redirect.Follow is true upon exiting the callback.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-OnRedirectAsync'></a>
### OnRedirectAsync `property`

##### Summary

Gets or sets a callback that is invoked asynchronously when any 3xx response with a Location header is received.
You can inspect/manipulate the call.Redirect object to determine what will happen next.
An auto-redirect will only happen if call.Redirect.Follow is true upon exiting the callback.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-Redirects'></a>
### Redirects `property`

##### Summary

Gets object whose properties describe how Url.Http should handle redirect (3xx) responses.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-Timeout'></a>
### Timeout `property`

##### Summary

Gets or sets the HTTP request timeout.

<a name='P-Bb-Http-Configuration-UrlHttpSettings-UrlEncodedSerializer'></a>
### UrlEncodedSerializer `property`

##### Summary

Gets or sets object used to serialize URL-encoded data. (Deserialization not supported in default implementation.)

<a name='M-Bb-Http-Configuration-UrlHttpSettings-Get``1-System-String-'></a>
### Get\`\`1() `method`

##### Summary

Gets a settings value from this instance if explicitly set, otherwise from the default settings that back this instance.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Configuration-UrlHttpSettings-ResetDefaults'></a>
### ResetDefaults() `method`

##### Summary

Resets all overridden settings to their default values. For example, on a UrlRequest,
all settings are reset to UrlClient-level settings.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Configuration-UrlHttpSettings-Set``1-``0,System-String-'></a>
### Set\`\`1() `method`

##### Summary

Sets a settings value for this instance.

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-UrlHttpTimeoutException'></a>
## UrlHttpTimeoutException `type`

##### Namespace

Bb.Http

##### Summary

An exception that is thrown when an HTTP call made by Url.Http times out.

<a name='M-Bb-Http-UrlHttpTimeoutException-#ctor-Bb-Http-UrlCall,System-Exception-'></a>
### #ctor(call,inner) `constructor`

##### Summary

Initializes a new instance of the [UrlHttpTimeoutException](#T-Bb-Http-UrlHttpTimeoutException 'Bb.Http.UrlHttpTimeoutException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| call | [Bb.Http.UrlCall](#T-Bb-Http-UrlCall 'Bb.Http.UrlCall') | Details of the HTTP call that caused the exception. |
| inner | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The inner exception. |

<a name='T-Bb-Http-UrlParsingException'></a>
## UrlParsingException `type`

##### Namespace

Bb.Http

##### Summary

An exception that is thrown when an HTTP response could not be parsed to a particular format.

<a name='M-Bb-Http-UrlParsingException-#ctor-Bb-Http-UrlCall,System-String,System-Exception-'></a>
### #ctor(call,expectedFormat,inner) `constructor`

##### Summary

Initializes a new instance of the [UrlParsingException](#T-Bb-Http-UrlParsingException 'Bb.Http.UrlParsingException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| call | [Bb.Http.UrlCall](#T-Bb-Http-UrlCall 'Bb.Http.UrlCall') | Details of the HTTP call that caused the exception. |
| expectedFormat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The format that could not be parsed to, i.e. JSON. |
| inner | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The inner exception. |

<a name='P-Bb-Http-UrlParsingException-ExpectedFormat'></a>
### ExpectedFormat `property`

##### Summary

The format that could not be parsed to, i.e. JSON.

<a name='T-Bb-Http-UrlRedirect'></a>
## UrlRedirect `type`

##### Namespace

Bb.Http

##### Summary

An object containing information about if/how an automatic redirect request will be created and sent.

<a name='P-Bb-Http-UrlRedirect-ChangeVerbToGet'></a>
### ChangeVerbToGet `property`

##### Summary

If true, the redirect request will use the GET verb and will not forward the original request body.
Otherwise, the original verb and body will be preserved in the redirect.

<a name='P-Bb-Http-UrlRedirect-Count'></a>
### Count `property`

##### Summary

The number of auto-redirects that have already occurred since the original call, plus 1 for this one.

<a name='P-Bb-Http-UrlRedirect-Follow'></a>
### Follow `property`

##### Summary

If true, Url will automatically send a redirect request. Set to false to prevent auto-redirect.

<a name='P-Bb-Http-UrlRedirect-Url'></a>
### Url `property`

##### Summary

The URL to redirect to, from the response's Location header.

<a name='T-Bb-Http-UrlRequest'></a>
## UrlRequest `type`

##### Namespace

Bb.Http

##### Summary

*Inherit from parent.*

<a name='M-Bb-Http-UrlRequest-#ctor-Bb-Url-'></a>
### #ctor(url) `constructor`

##### Summary

Initializes a new instance of the [UrlRequest](#T-Bb-Http-UrlRequest 'Bb.Http.UrlRequest') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [Bb.Url](#T-Bb-Url 'Bb.Url') | The URL to call with this UrlRequest instance. |

<a name='M-Bb-Http-UrlRequest-#ctor-Bb-Http-IUrlClient,System-Object[]-'></a>
### #ctor() `constructor`

##### Summary

Used internally by UrlClient.Request

##### Parameters

This constructor has no parameters.

<a name='M-Bb-Http-UrlRequest-#ctor-System-String,System-Object[]-'></a>
### #ctor() `constructor`

##### Summary

Used internally by UrlClient.Request and CookieSession.Request

##### Parameters

This constructor has no parameters.

<a name='P-Bb-Http-UrlRequest-Client'></a>
### Client `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlRequest-Content'></a>
### Content `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlRequest-CookieJar'></a>
### CookieJar `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlRequest-Cookies'></a>
### Cookies `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlRequest-EnsureSuccessStatusCode'></a>
### EnsureSuccessStatusCode `property`

##### Summary

If true and the http result code is not between 200 and 299, throw [HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException')

<a name='P-Bb-Http-UrlRequest-Headers'></a>
### Headers `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlRequest-RedirectedFrom'></a>
### RedirectedFrom `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlRequest-Settings'></a>
### Settings `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlRequest-Url'></a>
### Url `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlRequest-Verb'></a>
### Verb `property`

##### Summary

*Inherit from parent.*

<a name='M-Bb-Http-UrlRequest-SendAsync-System-Net-Http-HttpMethod,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-UrlRequest-SendAsync-System-Net-Http-HttpMethod,System-Net-Http-HttpContent,System-Net-Http-HttpCompletionOption,System-Threading-CancellationToken-'></a>
### SendAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-UrlResponse'></a>
## UrlResponse `type`

##### Namespace

Bb.Http

##### Summary

*Inherit from parent.*

<a name='M-Bb-Http-UrlResponse-#ctor-Bb-Http-UrlCall,Bb-Http-CookieJar-'></a>
### #ctor() `constructor`

##### Summary

Creates a new UrlResponse that wraps the give HttpResponseMessage.

##### Parameters

This constructor has no parameters.

<a name='P-Bb-Http-UrlResponse-Cookies'></a>
### Cookies `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlResponse-Headers'></a>
### Headers `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlResponse-IsSuccessStatusCode'></a>
### IsSuccessStatusCode `property`

##### Summary



<a name='P-Bb-Http-UrlResponse-ResponseMessage'></a>
### ResponseMessage `property`

##### Summary

*Inherit from parent.*

<a name='P-Bb-Http-UrlResponse-StatusCode'></a>
### StatusCode `property`

##### Summary

*Inherit from parent.*

<a name='M-Bb-Http-UrlResponse-Dispose'></a>
### Dispose() `method`

##### Summary

Disposes the underlying HttpResponseMessage.

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-UrlResponse-GetBytesAsync'></a>
### GetBytesAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-UrlResponse-GetObjectAsync``1'></a>
### GetObjectAsync\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-UrlResponse-GetStreamAsync'></a>
### GetStreamAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-UrlResponse-GetStringAsync'></a>
### GetStringAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Bb-Http-Testing-Util'></a>
## Util `type`

##### Namespace

Bb.Http.Testing

##### Summary

Utility methods used by both HttpTestSetup and HttpTestAssertion

<a name='M-Bb-Http-Testing-Util-HasCookie-Bb-Http-UrlCall,System-String,System-Object-'></a>
### HasCookie() `method`

##### Summary

null value means just check for existence by name

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-Util-HasHeader-Bb-Http-UrlCall,System-String,System-Object-'></a>
### HasHeader() `method`

##### Summary

null value means just check for existence by name

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-Util-HasQueryParam-Bb-Http-UrlCall,System-String,System-Object-'></a>
### HasQueryParam() `method`

##### Summary

null value means just check for existence by name

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-Util-MatchesPattern-System-String,System-String-'></a>
### MatchesPattern() `method`

##### Summary

match simple patterns with * wildcard

##### Parameters

This method has no parameters.

<a name='M-Bb-Http-Testing-Util-MatchesUrlPattern-System-String,System-String-'></a>
### MatchesUrlPattern() `method`

##### Summary

same as MatchesPattern, but doesn't require trailing * to ignore query string

##### Parameters

This method has no parameters.

<a name='T-Bb-Util-VariableReplacer'></a>
## VariableReplacer `type`

##### Namespace

Bb.Util

##### Summary

Variable replacer

<a name='M-Bb-Util-VariableReplacer-ReplaceVariables-System-String-'></a>
### ReplaceVariables(input) `method`

##### Summary

replace variables in a string with their values from the environment.

##### Returns

the computed value

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Input text |

<a name='T-Bb-Util-Variables'></a>
## Variables `type`

##### Namespace

Bb.Util

<a name='P-Bb-Util-Variables-Root'></a>
### Root `property`

##### Summary

Singleton instance of Variables

<a name='M-Bb-Util-Variables-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes the Variables class.

##### Parameters

This method has no parameters.

<a name='M-Bb-Util-Variables-AppendFirst-Bb-Util-Variables-'></a>
### AppendFirst(variables) `method`

##### Summary

Append a new Variables instance to the end of the chain.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| variables | [Bb.Util.Variables](#T-Bb-Util-Variables 'Bb.Util.Variables') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='M-Bb-Util-Variables-Resolve-System-String,System-String@-'></a>
### Resolve(name,resultValue) `method`

##### Summary

Resolve a variable by name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| resultValue | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') |  |

<a name='M-Bb-Util-Variables-TryGet-System-String,System-String@-'></a>
### TryGet(name,resultValue) `method`

##### Summary

Resolve a variable by name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| resultValue | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') |  |

<a name='T-Bb-Util-VariablesDictionary'></a>
## VariablesDictionary `type`

##### Namespace

Bb.Util

<a name='M-Bb-Util-VariablesDictionary-Add-System-String,System-String-'></a>
### Add(name,value) `method`

##### Summary

Add a variable by name and value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-Util-VariablesDictionary-TryGet-System-String,System-String@-'></a>
### TryGet(name,resultValue) `method`

##### Summary

Resolve a variable by name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| resultValue | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') |  |
