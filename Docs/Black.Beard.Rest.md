<a name='assembly'></a>
# Black.Beard.Rest

## Contents

- [CommonExtensions](#T-Bb-Util-CommonExtensions 'Bb.Util.CommonExtensions')
  - [IsIP()](#M-Bb-Util-CommonExtensions-IsIP-System-String- 'Bb.Util.CommonExtensions.IsIP(System.String)')
  - [Merge\`\`2()](#M-Bb-Util-CommonExtensions-Merge``2-System-Collections-Generic-IDictionary{``0,``1},System-Collections-Generic-IDictionary{``0,``1}- 'Bb.Util.CommonExtensions.Merge``2(System.Collections.Generic.IDictionary{``0,``1},System.Collections.Generic.IDictionary{``0,``1})')
  - [SplitOnFirstOccurence(s,separator)](#M-Bb-Util-CommonExtensions-SplitOnFirstOccurence-System-String,System-String- 'Bb.Util.CommonExtensions.SplitOnFirstOccurence(System.String,System.String)')
  - [StripQuotes()](#M-Bb-Util-CommonExtensions-StripQuotes-System-String- 'Bb.Util.CommonExtensions.StripQuotes(System.String)')
  - [ToInvariantString()](#M-Bb-Util-CommonExtensions-ToInvariantString-System-Object- 'Bb.Util.CommonExtensions.ToInvariantString(System.Object)')
  - [ToKeyValuePairs(obj)](#M-Bb-Util-CommonExtensions-ToKeyValuePairs-System-Object- 'Bb.Util.CommonExtensions.ToKeyValuePairs(System.Object)')
- [CurlContext](#T-Bb-Curls-CurlContext 'Bb.Curls.CurlContext')
  - [#ctor(cancellationTokenSource)](#M-Bb-Curls-CurlContext-#ctor-System-Threading-CancellationTokenSource- 'Bb.Curls.CurlContext.#ctor(System.Threading.CancellationTokenSource)')
- [CurlInterpreter](#T-Bb-Curls-CurlInterpreter 'Bb.Curls.CurlInterpreter')
  - [#ctor(arguments)](#M-Bb-Curls-CurlInterpreter-#ctor-System-String[]- 'Bb.Curls.CurlInterpreter.#ctor(System.String[])')
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
- [QueryParamCollection](#T-Bb-Util-QueryParamCollection 'Bb.Util.QueryParamCollection')
  - [#ctor(query)](#M-Bb-Util-QueryParamCollection-#ctor-System-String- 'Bb.Util.QueryParamCollection.#ctor(System.String)')
  - [Count](#P-Bb-Util-QueryParamCollection-Count 'Bb.Util.QueryParamCollection.Count')
  - [Item](#P-Bb-Util-QueryParamCollection-Item-System-Int32- 'Bb.Util.QueryParamCollection.Item(System.Int32)')
  - [Add(name,value,isEncoded,nullValueHandling)](#M-Bb-Util-QueryParamCollection-Add-System-String,System-Object,System-Boolean,Bb-NullValueHandling- 'Bb.Util.QueryParamCollection.Add(System.String,System.Object,System.Boolean,Bb.NullValueHandling)')
  - [AddOrReplace(name,value,isEncoded,nullValueHandling)](#M-Bb-Util-QueryParamCollection-AddOrReplace-System-String,System-Object,System-Boolean,Bb-NullValueHandling- 'Bb.Util.QueryParamCollection.AddOrReplace(System.String,System.Object,System.Boolean,Bb.NullValueHandling)')
  - [Clear()](#M-Bb-Util-QueryParamCollection-Clear 'Bb.Util.QueryParamCollection.Clear')
  - [Contains()](#M-Bb-Util-QueryParamCollection-Contains-System-String- 'Bb.Util.QueryParamCollection.Contains(System.String)')
  - [Contains()](#M-Bb-Util-QueryParamCollection-Contains-System-String,Bb-Util-QueryParamValue- 'Bb.Util.QueryParamCollection.Contains(System.String,Bb.Util.QueryParamValue)')
  - [FirstOrDefault()](#M-Bb-Util-QueryParamCollection-FirstOrDefault-System-String- 'Bb.Util.QueryParamCollection.FirstOrDefault(System.String)')
  - [GetAll()](#M-Bb-Util-QueryParamCollection-GetAll-System-String- 'Bb.Util.QueryParamCollection.GetAll(System.String)')
  - [GetEnumerator()](#M-Bb-Util-QueryParamCollection-GetEnumerator 'Bb.Util.QueryParamCollection.GetEnumerator')
  - [Remove()](#M-Bb-Util-QueryParamCollection-Remove-System-String- 'Bb.Util.QueryParamCollection.Remove(System.String)')
  - [ToString()](#M-Bb-Util-QueryParamCollection-ToString 'Bb.Util.QueryParamCollection.ToString')
  - [ToString()](#M-Bb-Util-QueryParamCollection-ToString-System-Boolean- 'Bb.Util.QueryParamCollection.ToString(System.Boolean)')
  - [TryGetFirst()](#M-Bb-Util-QueryParamCollection-TryGetFirst-System-String,Bb-Util-QueryParamValue@- 'Bb.Util.QueryParamCollection.TryGetFirst(System.String,Bb.Util.QueryParamValue@)')
  - [op_Implicit(query)](#M-Bb-Util-QueryParamCollection-op_Implicit-Bb-Util-QueryParamCollection-~System-String 'Bb.Util.QueryParamCollection.op_Implicit(Bb.Util.QueryParamCollection)~System.String')
- [QueryParamValue](#T-Bb-Util-QueryParamValue 'Bb.Util.QueryParamValue')
- [Url](#T-Bb-Url 'Bb.Url')
  - [#ctor(scheme,host,port,segments)](#M-Bb-Url-#ctor-System-String,System-String,System-Int32,System-String[]- 'Bb.Url.#ctor(System.String,System.String,System.Int32,System.String[])')
  - [#ctor(baseUrl)](#M-Bb-Url-#ctor-System-String- 'Bb.Url.#ctor(System.String)')
  - [#ctor(baseUrl)](#M-Bb-Url-#ctor-System-String,System-Nullable{System-Int32}- 'Bb.Url.#ctor(System.String,System.Nullable{System.Int32})')
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
  - [Encode(str,encodeSpaceAsPlus)](#M-Bb-Url-Encode-System-String,System-Boolean- 'Bb.Url.Encode(System.String,System.Boolean)')
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
- [UrlExtension](#T-Bb-Helpers-UrlExtension 'Bb.Helpers.UrlExtension')
  - [ConcatUrl(urls)](#M-Bb-Helpers-UrlExtension-ConcatUrl-System-Collections-Generic-IEnumerable{Bb-Url}- 'Bb.Helpers.UrlExtension.ConcatUrl(System.Collections.Generic.IEnumerable{Bb.Url})')
  - [ConcatUrl(sb,urls)](#M-Bb-Helpers-UrlExtension-ConcatUrl-System-Text-StringBuilder,System-Collections-Generic-IEnumerable{Bb-Url}- 'Bb.Helpers.UrlExtension.ConcatUrl(System.Text.StringBuilder,System.Collections.Generic.IEnumerable{Bb.Url})')
  - [RemoveFragment(url)](#M-Bb-Helpers-UrlExtension-RemoveFragment-System-String- 'Bb.Helpers.UrlExtension.RemoveFragment(System.String)')
  - [RemovePath(url)](#M-Bb-Helpers-UrlExtension-RemovePath-System-String- 'Bb.Helpers.UrlExtension.RemovePath(System.String)')
  - [RemovePathSegment(url)](#M-Bb-Helpers-UrlExtension-RemovePathSegment-System-String- 'Bb.Helpers.UrlExtension.RemovePathSegment(System.String)')
  - [RemoveQuery(url)](#M-Bb-Helpers-UrlExtension-RemoveQuery-System-String- 'Bb.Helpers.UrlExtension.RemoveQuery(System.String)')
  - [RemoveQueryParam(url,name)](#M-Bb-Helpers-UrlExtension-RemoveQueryParam-System-String,System-String- 'Bb.Helpers.UrlExtension.RemoveQueryParam(System.String,System.String)')
  - [RemoveQueryParam(url,names)](#M-Bb-Helpers-UrlExtension-RemoveQueryParam-System-String,System-String[]- 'Bb.Helpers.UrlExtension.RemoveQueryParam(System.String,System.String[])')
  - [RemoveQueryParam(url,names)](#M-Bb-Helpers-UrlExtension-RemoveQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Helpers.UrlExtension.RemoveQueryParam(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [ResetToRoot(url)](#M-Bb-Helpers-UrlExtension-ResetToRoot-System-String- 'Bb.Helpers.UrlExtension.ResetToRoot(System.String)')
  - [SetFragment(url,fragment)](#M-Bb-Helpers-UrlExtension-SetFragment-System-String,System-String- 'Bb.Helpers.UrlExtension.SetFragment(System.String,System.String)')
  - [SetQueryParam(url,name,value,nullValueHandling)](#M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-String,System-Object,Bb-NullValueHandling- 'Bb.Helpers.UrlExtension.SetQueryParam(System.String,System.String,System.Object,Bb.NullValueHandling)')
  - [SetQueryParam(url,name,value,isEncoded,nullValueHandling)](#M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-String,System-String,System-Boolean,Bb-NullValueHandling- 'Bb.Helpers.UrlExtension.SetQueryParam(System.String,System.String,System.String,System.Boolean,Bb.NullValueHandling)')
  - [SetQueryParam(url,name)](#M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-String- 'Bb.Helpers.UrlExtension.SetQueryParam(System.String,System.String)')
  - [SetQueryParam(url,values,nullValueHandling)](#M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-Object,Bb-NullValueHandling- 'Bb.Helpers.UrlExtension.SetQueryParam(System.String,System.Object,Bb.NullValueHandling)')
  - [SetQueryParam(url,names)](#M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Helpers.UrlExtension.SetQueryParam(System.String,System.Collections.Generic.IEnumerable{System.String})')
  - [SetQueryParam(url,names)](#M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-String[]- 'Bb.Helpers.UrlExtension.SetQueryParam(System.String,System.String[])')
  - [WithFragment(uri,fragment)](#M-Bb-Helpers-UrlExtension-WithFragment-System-Uri,System-String- 'Bb.Helpers.UrlExtension.WithFragment(System.Uri,System.String)')
  - [WithPathSegment(url,segment,fullyEncode)](#M-Bb-Helpers-UrlExtension-WithPathSegment-System-String,System-Object,System-Boolean- 'Bb.Helpers.UrlExtension.WithPathSegment(System.String,System.Object,System.Boolean)')
  - [WithPathSegment(url,segments)](#M-Bb-Helpers-UrlExtension-WithPathSegment-System-String,System-Object[]- 'Bb.Helpers.UrlExtension.WithPathSegment(System.String,System.Object[])')
  - [WithPathSegment(url,segments)](#M-Bb-Helpers-UrlExtension-WithPathSegment-System-String,System-Collections-Generic-IEnumerable{System-Object}- 'Bb.Helpers.UrlExtension.WithPathSegment(System.String,System.Collections.Generic.IEnumerable{System.Object})')
  - [WithPathSegment(uri,segment,fullyEncode)](#M-Bb-Helpers-UrlExtension-WithPathSegment-System-Uri,System-Object,System-Boolean- 'Bb.Helpers.UrlExtension.WithPathSegment(System.Uri,System.Object,System.Boolean)')
  - [WithPathSegment(uri,segments)](#M-Bb-Helpers-UrlExtension-WithPathSegment-System-Uri,System-Object[]- 'Bb.Helpers.UrlExtension.WithPathSegment(System.Uri,System.Object[])')
  - [WithPathSegment(uri,segments)](#M-Bb-Helpers-UrlExtension-WithPathSegment-System-Uri,System-Collections-Generic-IEnumerable{System-Object}- 'Bb.Helpers.UrlExtension.WithPathSegment(System.Uri,System.Collections.Generic.IEnumerable{System.Object})')
  - [WithQueryParam(uri,name,value,nullValueHandling)](#M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-String,System-Object,Bb-NullValueHandling- 'Bb.Helpers.UrlExtension.WithQueryParam(System.Uri,System.String,System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(uri,name,value,isEncoded,nullValueHandling)](#M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-String,System-String,System-Boolean,Bb-NullValueHandling- 'Bb.Helpers.UrlExtension.WithQueryParam(System.Uri,System.String,System.String,System.Boolean,Bb.NullValueHandling)')
  - [WithQueryParam(uri,name)](#M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-String- 'Bb.Helpers.UrlExtension.WithQueryParam(System.Uri,System.String)')
  - [WithQueryParam(uri,values,nullValueHandling)](#M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-Object,Bb-NullValueHandling- 'Bb.Helpers.UrlExtension.WithQueryParam(System.Uri,System.Object,Bb.NullValueHandling)')
  - [WithQueryParam(uri,names)](#M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Helpers.UrlExtension.WithQueryParam(System.Uri,System.Collections.Generic.IEnumerable{System.String})')
  - [WithQueryParam(uri,names)](#M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-String[]- 'Bb.Helpers.UrlExtension.WithQueryParam(System.Uri,System.String[])')
  - [WithRemoveFragment(uri)](#M-Bb-Helpers-UrlExtension-WithRemoveFragment-System-Uri- 'Bb.Helpers.UrlExtension.WithRemoveFragment(System.Uri)')
  - [WithRemovePath(uri)](#M-Bb-Helpers-UrlExtension-WithRemovePath-System-Uri- 'Bb.Helpers.UrlExtension.WithRemovePath(System.Uri)')
  - [WithRemovePathSegment(uri)](#M-Bb-Helpers-UrlExtension-WithRemovePathSegment-System-Uri- 'Bb.Helpers.UrlExtension.WithRemovePathSegment(System.Uri)')
  - [WithRemoveQuery(uri)](#M-Bb-Helpers-UrlExtension-WithRemoveQuery-System-Uri- 'Bb.Helpers.UrlExtension.WithRemoveQuery(System.Uri)')
  - [WithRemoveQueryParam(uri,name)](#M-Bb-Helpers-UrlExtension-WithRemoveQueryParam-System-Uri,System-String- 'Bb.Helpers.UrlExtension.WithRemoveQueryParam(System.Uri,System.String)')
  - [WithRemoveQueryParam(uri,names)](#M-Bb-Helpers-UrlExtension-WithRemoveQueryParam-System-Uri,System-String[]- 'Bb.Helpers.UrlExtension.WithRemoveQueryParam(System.Uri,System.String[])')
  - [WithRemoveQueryParam(uri,names)](#M-Bb-Helpers-UrlExtension-WithRemoveQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}- 'Bb.Helpers.UrlExtension.WithRemoveQueryParam(System.Uri,System.Collections.Generic.IEnumerable{System.String})')
  - [WithResetToRoot(uri)](#M-Bb-Helpers-UrlExtension-WithResetToRoot-System-Uri- 'Bb.Helpers.UrlExtension.WithResetToRoot(System.Uri)')

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

<a name='M-Bb-Util-QueryParamCollection-Contains-System-String,Bb-Util-QueryParamValue-'></a>
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

<a name='M-Bb-Util-QueryParamCollection-TryGetFirst-System-String,Bb-Util-QueryParamValue@-'></a>
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

<a name='M-Bb-Url-#ctor-System-String,System-Nullable{System-Int32}-'></a>
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
### Encode(str,encodeSpaceAsPlus) `method`

##### Summary

URL-encodes a string, including reserved characters such as '/' and '?'.

##### Returns

The encoded URL.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to encode. |
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

<a name='T-Bb-Helpers-UrlExtension'></a>
## UrlExtension `type`

##### Namespace

Bb.Helpers

<a name='M-Bb-Helpers-UrlExtension-ConcatUrl-System-Collections-Generic-IEnumerable{Bb-Url}-'></a>
### ConcatUrl(urls) `method`

##### Summary

return a [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') with Concatenated url separated by ';'.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urls | [System.Collections.Generic.IEnumerable{Bb.Url}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Bb.Url}') | [Url](#T-Bb-Url 'Bb.Url') |

<a name='M-Bb-Helpers-UrlExtension-ConcatUrl-System-Text-StringBuilder,System-Collections-Generic-IEnumerable{Bb-Url}-'></a>
### ConcatUrl(sb,urls) `method`

##### Summary

return a [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') with Concatenated url separated by ';'.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sb | [System.Text.StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') | [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') |
| urls | [System.Collections.Generic.IEnumerable{Bb.Url}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Bb.Url}') | [Url](#T-Bb-Url 'Bb.Url') |

<a name='M-Bb-Helpers-UrlExtension-RemoveFragment-System-String-'></a>
### RemoveFragment(url) `method`

##### Summary

Removes the URL fragment including the #.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Helpers-UrlExtension-RemovePath-System-String-'></a>
### RemovePath(url) `method`

##### Summary

Removes the entire path component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Helpers-UrlExtension-RemovePathSegment-System-String-'></a>
### RemovePathSegment(url) `method`

##### Summary

Removes the last path segment from the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Helpers-UrlExtension-RemoveQuery-System-String-'></a>
### RemoveQuery(url) `method`

##### Summary

Removes the entire query component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Helpers-UrlExtension-RemoveQueryParam-System-String,System-String-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-RemoveQueryParam-System-String,System-String[]-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-RemoveQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-ResetToRoot-System-String-'></a>
### ResetToRoot(url) `method`

##### Summary

Trims the URL to its root, including the scheme, any user info, host, and port (if specified).

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This URL. |

<a name='M-Bb-Helpers-UrlExtension-SetFragment-System-String,System-String-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-String,System-Object,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-String,System-String,System-Boolean,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-String-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-Object,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-SetQueryParam-System-String,System-String[]-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithFragment-System-Uri,System-String-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithPathSegment-System-String,System-Object,System-Boolean-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithPathSegment-System-String,System-Object[]-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithPathSegment-System-String,System-Collections-Generic-IEnumerable{System-Object}-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithPathSegment-System-Uri,System-Object,System-Boolean-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithPathSegment-System-Uri,System-Object[]-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithPathSegment-System-Uri,System-Collections-Generic-IEnumerable{System-Object}-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-String,System-Object,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-String,System-String,System-Boolean,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-String-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-Object,Bb-NullValueHandling-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithQueryParam-System-Uri,System-String[]-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithRemoveFragment-System-Uri-'></a>
### WithRemoveFragment(uri) `method`

##### Summary

Removes the URL fragment including the #.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Helpers-UrlExtension-WithRemovePath-System-Uri-'></a>
### WithRemovePath(uri) `method`

##### Summary

Removes the entire path component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Helpers-UrlExtension-WithRemovePathSegment-System-Uri-'></a>
### WithRemovePathSegment(uri) `method`

##### Summary

Removes the last path segment from the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Helpers-UrlExtension-WithRemoveQuery-System-Uri-'></a>
### WithRemoveQuery(uri) `method`

##### Summary

Removes the entire query component of the URL.

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |

<a name='M-Bb-Helpers-UrlExtension-WithRemoveQueryParam-System-Uri,System-String-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithRemoveQueryParam-System-Uri,System-String[]-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithRemoveQueryParam-System-Uri,System-Collections-Generic-IEnumerable{System-String}-'></a>
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

<a name='M-Bb-Helpers-UrlExtension-WithResetToRoot-System-Uri-'></a>
### WithResetToRoot(uri) `method`

##### Summary

Trims the URL to its root, including the scheme, any user info, host, and port (if specified).

##### Returns

A new Url object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uri | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | This System.Uri. |
