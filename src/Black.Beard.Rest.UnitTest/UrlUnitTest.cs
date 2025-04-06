using Bb.Urls;
using System;
using System.Collections.Generic;
using Bb.Urls;
using System;
using Xunit;

namespace Black.Beard.Rest.UnitTest
{


    namespace Black.Beard.Rest.UnitTest
    {
        public class UrlUnitTest
        {

            [Fact]
            public void TestHttpScheme()
            {
                var url = new Url(Url.DEFAULT_SCHEME, "example.com", 80);
                Assert.Equal(Url.DEFAULT_SCHEME, url.Scheme);
                Assert.Equal("example.com", url.Host);
                Assert.Equal(80, url.Port);
            }

            [Fact]
            public void TestHttpsScheme()
            {
                var url = new Url(Url.DEFAULT_SECURED_SCHEME, "example.com", 443);
                Assert.Equal(Url.DEFAULT_SECURED_SCHEME, url.Scheme);
                Assert.Equal("example.com", url.Host);
                Assert.Equal(443, url.Port);
            }

            [Fact]
            public void TestUserInfo()
            {
                var url = new Url("https://user:pass@example.com");
                Assert.Equal("user", url.UserName);
                Assert.Equal("pass", url.Password);
                Assert.Equal("example.com", url.Host);
            }

            [Fact]
            public void TestPath()
            {
                var url = new Url("https://example.com/path/to/resource");
                Assert.Equal("path/to/resource", url.Path);
            }

            [Fact]
            public void TestQuery()
            {
                var url = new Url("https://example.com?key=value&another=param");
                Assert.Equal("key=value&another=param", url.Query);
            }

            [Fact]
            public void TestFragment()
            {
                var url = new Url("https://example.com#section");
                Assert.Equal("#section", url.Fragment);
            }

            [Fact]
            public void TestCombinePath()
            {
                var url = new Url("https://example.com")
                    .CombinePath("path", "to", "resource");
                Assert.Equal(@"path/to/resource", url.Path);
            }

            [Fact]
            public void TestWithQueryParam()
            {
                var url = new Url("https://example.com")
                    .WithQueryParam("key", "value")
                    .WithQueryParam("another", "param");
                Assert.Equal("key=value&another=param", url.Query);
            }

            [Fact]
            public void TestSetFragment()
            {
                var url = new Url("https://example.com")
                    .SetFragment("section");
                Assert.Equal("#section", url.Fragment);
            }

            [Fact]
            public void TestToString()
            {
                var url = new Url("https://example.com/path/to/resource?key=value#section");
                Assert.Equal("https://example.com:443/path/to/resource?key=value#section", url.ToString());
            }

            [Fact]
            public void TestToUri()
            {
                var url = new Url("https://example.com/path/to/resource?key=value#section");
                var uri = url.ToUri();
                Assert.Equal(new Uri("https://example.com/path/to/resource?key=value#section"), uri);
            }

            [Fact]
            public void TestRemoveLastPathSegment()
            {
                var url = new Url("https://example.com/path/to/resource")
                    .RemoveLastPathSegment();
                Assert.Equal("path/to", url.Path);
            }

            [Fact]
            public void TestRemovePath()
            {
                var url = new Url("https://example.com/path/to/resource")
                    .RemovePath();
                Assert.Equal(string.Empty, url.Path);
            }

            [Fact]
            public void TestWithPathSegment()
            {
                var url = new Url("https://example.com")
                    .WithPathSegment("path", "to", "resource");
                Assert.Equal("path/to/resource", url.Path);
            }

            [Fact]
            public void TestRemoveQueryParam()
            {
                var url = new Url("https://example.com?key=value&another=param")
                    .RemoveQueryParam("key");
                Assert.Equal("another=param", url.Query);
            }

            [Fact]
            public void TestRemoveQuery()
            {
                var url = new Url("https://example.com?key=value&another=param")
                    .RemoveQuery();
                Assert.Equal(string.Empty, url.Query);
            }

            [Fact]
            public void TestResetToRoot()
            {
                var url = new Url("https://example.com/path/to/resource?key=value#section")
                    .ResetToRoot();
                var txt = url.ToString();
                Assert.Equal(@"https://example.com:443/", txt);
            }

            [Fact]
            public void TestReset()
            {
                var url = new Url("https://example.com/path/to/resource?key=value#section")
                    .Reset();
                var txt = url.ToString();
                Assert.Equal(@"/", txt);
            }

            [Fact]
            public void TestMapVariables()
            {
                var url = new Url("https://example.com/{id}?name={name}")
                    .Map(("id", "123"), ("name", "John"));
                var txt = url.ToString();
                Assert.Equal("https://example.com:443/123?name=John", txt);
            }

            #region Segments

            [Fact]
            public void TestSegmentInitialization()
            {
                var segment = new Segment("example");
                Assert.Equal("example", segment.Value);
                Assert.False(segment.IsVariable);
            }

            [Fact]
            public void TestSegmentInitializationWithVariable()
            {
                var segment = new Segment("%7Bvariable%7D");
                Assert.Equal("variable", segment.Value);
                Assert.True(segment.IsVariable);
            }

            [Fact]
            public void TestSegmentInitializationWithNull()
            {
                Assert.Throws<ArgumentNullException>(() => new Segment(null));
            }

            [Fact]
            public void TestEncodedValue()
            {
                var segment = new Segment("example");
                Assert.Equal("example", segment.EncodedValue);

                var variableSegment = new Segment("%7Bvariable%7D");
                Assert.Equal("{variable}", variableSegment.EncodedValue);
            }

            [Fact]
            public void TestMapVariable()
            {
                var segment = new Segment("%7Bvariable%7D");
                segment.Map("mappedValue");
                Assert.Equal("mappedValue", segment.Value);
                Assert.False(segment.IsVariable);
            }

            [Fact]
            public void TestMapNonVariable()
            {
                var segment = new Segment("example");
                Assert.Throws<InvalidOperationException>(() => segment.Map("mappedValue"));
            }

            #endregion Segments

            #region query

            [Fact]
            public void TestInitializationWithString()
            {
                var param = new QueryParamValue("value");
                Assert.Equal("value", param.Value);
                Assert.True(param.HasValue);
            }

            [Fact]
            public void TestInitializationWithObject()
            {
                var param = new QueryParamValue(123);
                Assert.Equal("123", param.Value);
                Assert.True(param.HasValue);
            }

            [Fact]
            public void TestInitializationWithNull()
            {
                var param = new QueryParamValue(null);
                Assert.Null(param.Value);
                Assert.True(param.HasValue);
            }

            [Fact]
            public void TestEncodeValue()
            {
                var param = new QueryParamValue("value with spaces");
                var encodedValue = param.EncodedValue();
                Assert.Equal("value%20with%20spaces", encodedValue);
            }

            [Fact]
            public void TestEncodeValueWithPlus()
            {
                var param = new QueryParamValue("value with spaces");
                var encodedValue = param.EncodedValue(true);
                Assert.Equal("value+with+spaces", encodedValue);
            }

            [Fact]
            public void TestInitializationWithQueryString()
            {
                var queryParams = new QueryParamCollection("key=value&another=param");
                Assert.Equal("value", queryParams.FirstOrDefault("key"));
                Assert.Equal("param", queryParams.FirstOrDefault("another"));
            }

            [Fact]
            public void TestAddQueryParam()
            {
                var queryParams = new QueryParamCollection();
                queryParams.Add("key", "value");
                Assert.Equal("value", queryParams.FirstOrDefault("key"));
            }

            [Fact]
            public void TestAddOrReplaceQueryParam()
            {
                var queryParams = new QueryParamCollection();
                queryParams.Add("key", "value");
                queryParams.AddOrReplace("key", "newValue");
                Assert.Equal("newValue", queryParams.FirstOrDefault("key"));
            }

            [Fact]
            public void TestRemoveQueryParamCollection()
            {
                var queryParams = new QueryParamCollection("key=value&another=param");
                queryParams.Remove("key");
                var p = queryParams.FirstOrDefault("key");
                Assert.False(p.HasValue);
                p = queryParams.FirstOrDefault("another");
                Assert.Equal("param", p.EncodedValue());
            }

            [Fact]
            public void TestClearQueryParams()
            {
                var queryParams = new QueryParamCollection("key=value&another=param");
                queryParams.Clear();
                Assert.False(queryParams.FirstOrDefault("key").HasValue);
                Assert.False(queryParams.FirstOrDefault("another").HasValue);
            }

            [Fact]
            public void TestQueryParamCollectionToString()
            {
                var queryParams = new QueryParamCollection();
                queryParams.Add("key", "value");
                queryParams.Add("another", "param");
                Assert.Equal("key=value&another=param", queryParams.ToString());
            }

            [Fact]
            public void TestToStringWithEncodedValues()
            {
                var queryParams = new QueryParamCollection();
                queryParams.Add("key", "value with spaces");
                queryParams.Add("another", "param");
                Assert.Equal("key=value%20with%20spaces&another=param", queryParams.ToString());
            }

            [Fact]
            public void TestContainsQueryParam()
            {
                var queryParams = new QueryParamCollection("key=value&another=param");
                Assert.True(queryParams.Contains("key"));
                Assert.False(queryParams.Contains("nonexistent"));
            }

            [Fact]
            public void TestGetAllQueryParams()
            {
                var queryParams = new QueryParamCollection("key=value&key=anotherValue");
                var values = queryParams.GetAll("key").Select(c => c.EncodedValue());
                Assert.Contains("value", values);
                Assert.Contains("anotherValue", values);
            }

            [Fact]
            public void TestTryGetFirstQueryParam()
            {
                var queryParams = new QueryParamCollection("key=value&another=param");
                Assert.True(queryParams.TryGetFirst("key", out var value));
                Assert.Equal("value", value);
                Assert.False(queryParams.TryGetFirst("nonexistent", out _));
            }


            #endregion query

            #region malicious

            [Fact]
            public void TestInjectionInPath()
            {
                var url = new Url("https://example.com")
                        .WithPathSegment("path", "to", "resource<script>alert('xss')</script>");
                var encodedPath = url.Path;
                Assert.DoesNotContain("<script>", encodedPath);
                Assert.DoesNotContain("alert('xss')", encodedPath);
            }

            [Fact]
            public void TestInjectionInQueryParam()
            {
                var url = new Url("https://example.com")
                    .WithQueryParam("key", "value<script>alert('xss')</script>");
                var encodedQuery = url.Query;
                Assert.DoesNotContain("<script>", encodedQuery);
                Assert.DoesNotContain("alert('xss')", encodedQuery);
            }

            [Fact]
            public void TestInjectionInFragment()
            {
                var url = new Url("https://example.com")
                    .SetFragment("section<script>alert('xss')</script>");
                var encodedFragment = url.Fragment;
                Assert.DoesNotContain("<script>", encodedFragment);
                Assert.DoesNotContain("alert('xss')", encodedFragment);
            }

            [Fact]
            public void TestInjectionInUserInfo()
            {
                Assert.Throws<UriFormatException>(() =>
                {
                    var url = new Url("https://user<script>alert('xss')</script>:pass@example.com");
                });
            }

            [Fact]
            public void TestInjectionInHost()
            {
                Assert.Throws<UriFormatException>(() =>
                {
                    var url = new Url("https://example<script>alert('xss')</script>.com");
                });
            }

            [Fact]
            public void TestInjectionInPort()
            {
                Assert.Throws<UriFormatException>(() =>
                {
                    var url = new Url("https://example.com:80<script>alert('xss')</script>");
                });
            }

            #endregion

            [Fact]
            public void TestConstructorWithValidParameters()
            {
                var url = new Url("https", "example.com", 443, "user:pass", "path", "to", "resource");
                Assert.Equal("https", url.Scheme);
                Assert.Equal("example.com", url.Host);
                Assert.Equal(443, url.Port);
                Assert.Equal("user", url.UserName);
                Assert.Equal("pass", url.Password);
                Assert.Equal("path/to/resource", url.Path);
            }

            [Fact]
            public void TestConstructorWithNullPort()
            {
                var url = new Url("https", "example.com", null, "user:pass", "path", "to", "resource");
                Assert.Equal("https", url.Scheme);
                Assert.Equal("example.com", url.Host);
                Assert.Equal(80, url.Port);
                Assert.Equal("user", url.UserName);
                Assert.Equal("pass", url.Password);
                Assert.Equal("path/to/resource", url.Path);
            }

            [Fact]
            public void TestConstructorWithNullPort1()
            {
                var url = new Url("https", "example.com", null, "user", "path", "to", "resource");
                Assert.Equal("https", url.Scheme);
                Assert.Equal("example.com", url.Host);
                Assert.Equal(443, url.Port);
                Assert.Equal("user", url.UserName);
                Assert.Equal(string.Empty, url.Password);
                Assert.Equal("path/to/resource", url.Path);
            }

            [Fact]
            public void TestConstructorWithNullUserInfo()
            {
                var url = new Url("https", "example.com", 443, null, "path", "to", "resource");
                Assert.Equal("https", url.Scheme);
                Assert.Equal("example.com", url.Host);
                Assert.Equal(443, url.Port);
                Assert.Equal(string.Empty, url.UserName);
                Assert.Equal(string.Empty, url.Password);
                Assert.Equal("path/to/resource", url.Path);
            }

            [Fact]
            public void TestConstructorWithEmptyPaths()
            {
                var url = new Url("https", "example.com", 443, "user:pass");
                Assert.Equal("https", url.Scheme);
                Assert.Equal("example.com", url.Host);
                Assert.Equal(443, url.Port);
                Assert.Equal("user", url.UserName);
                Assert.Equal("pass", url.Password);
                Assert.Equal(string.Empty, url.Path);
            }

            [Fact]
            public void TestConstructorWithNullScheme()
            {
                Assert.Throws<ArgumentNullException>(() => new Url(null, "example.com", 443, "user:pass", "path", "to", "resource"));
            }

            [Fact]
            public void TestConstructorWithNullHost()
            {
                Assert.Throws<ArgumentNullException>(() => new Url("https", null, 443, "user:pass", "path", "to", "resource"));
            }

            [Fact]
            public void TestConstructorWithInvalidPort()
            {

                var u1 = new Url("http", "example.com", -1, "user:pass", "path");
                var txt = u1.ToString();
                Assert.Equal("http://user:pass@example.com/", txt);

                var u2 = new Url("https", "example.com", -1, "user:pass", "path");
                txt = u2.ToString();
                Assert.Equal("https://user:pass@example.com/", txt);

                var u3 = new Url("httpx", "example.com", -1, "user:pass", "path");
                txt = u3.ToString();
                Assert.Equal("httpx://user:pass@example.com/", txt);

            }

            [Fact]
            public void TestConstructorWithInvalidScheme()
            {
                var url = new Url("ftp", "example.com", 21, "user:pass", "path", "to", "resource");
                Assert.Equal("ftp", url.Scheme);
                Assert.Equal("example.com", url.Host);
                Assert.Equal(21, url.Port);
                Assert.Equal("user", url.UserName);
                Assert.Equal("pass", url.Password);
                Assert.Equal(string.Empty, url.Path);
            }

        }
    }
}

