


## Url

Create a Url object with segment
```CSHARP

    using Bb;

    Url url1 = new Url("https://api.fr");
    Url url2 = "https://api.fr";
    Assert.AreEqual(url1.ToString(), url2.ToString());

    Url url3 = url2.AppendPathSegment("adfs/oauth2/token");
    Url url4 = new Url(new Uri("https://api.fr:80"), "adfs","oauth2","token");
    Assert.AreEqual(url2.ToString(), url3.ToString());

```CSHARP


## Post

```CSHARP

    var person = await "https://api.com"
        .AppendPathSegment("person")
        .SetQueryParams(new { a = 1, b = 2 })
        .WithOAuthBearerToken("my_oauth_token")
        .PostObjectAsync(new
        {
            first_name = "Claire",
            last_name = "Underwood"
        })
        .MapJson<Person>();

```

### Methods
    
```CSHARP
    
    var person = await "https://api.com"
        .AppendPathSegment("person")                        // Append segment in url
        .SetQueryParams(new { a = 1, b = 2 })               // Add query parameter
        .WithAutoRedirect(false)                            // Cancel redirect
        .WithOAuthBearerToken("my_oauth_token")             // Add token Authorization Bearer <token>
        .WithBasicAuth("@{client_id}", "@{client_secret}")  // Add basic auth
    
        .WithTimeout(30)                                    // Set timeout in seconds
    
        .WithCookie("cookie1", "value1")                    // add cookie
        .WithCookies(new Dictionary<string, string>         // add cookies
            { 
                { "cookie2", "value2" } 
            }
        )
        .WithCookies(new                                    // add cookies
        {
            cookie3 = "value3"
        })
    
        .WithHeader("header1", "value1")                    // add header
        .WithHeaders(new Dictionary<string, string>         // add headers
            { 
                { "header2", "value2" } 
            }
        )
        .WithHeaders(new                                    // add headers
        {
            header3 = "value3"
        })

        .AllowAnyHttpStatus()                               // Consider all status code as success
        .AllowHttpStatus(HttpStatusCode.OK)                 // Consider only status code as success
        .AllowHttpStatus(HttpStatusCode.Unused)             // additional status code as success

        .PostObjectAsync(new                                // Post object like json
        {
            first_name = "Claire",
            last_name = "Underwood"
        })
        .MapJson<Person>();                                 // and map result to Person
   
 ```

## variables

Store variable in environment and use syntax for resolve variable    
```CSHARP
    Environment.SetEnvironmentVariable("client_id", "???");
    var client_id = "@{client_id}";
```


## POST
Create a post on adfs server for a token JWT
```CSHARP

    Environment.SetEnvironmentVariable("client_id", "???");
    Environment.SetEnvironmentVariable("client_secret", "???");
    Environment.SetEnvironmentVariable("username", "g.beard@???.fr");
    Environment.SetEnvironmentVariable("password", "???");

    var adfsUrl = "https://sts.server.fr";

    var token = adfsUrl.AppendPathSegment("adfs/oauth2/token")
    .PostUrlEncodedAsync(new
    {
        grant_type = "password",
        username = "@{username}",
        password = "@{password}",
        client_id = "@{client_id}",
        client_secret = "@{client_secret}",
        scope="email"
    })
    .MapJson<Oauth2Token>()
    .Result;

    public class Oauth2Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string resource { get; set; }
        public string refresh_token { get; set; }
        public int refresh_token_expires_in { get; set; }
        public string id_token { get; set; }
    }

```

Make a post with a body in json
```CSHARP
    .PostAsync(new
    {
        grant_type = "password",
        username = "@{username}",
        password = "@{password}",
        client_id = "@{client_id}",
        client_secret = "@{client_secret}",
        scope="email"
    })
```

Make a post with a body which will be serialized to a URL-encoded string. : var1=value1&var2=value2

```CSHARP
    .PostUrlEncodedAsync(new
    {
        grant_type = "password",
        username = "@{username}",
        password = "@{password}",
        client_id = "@{client_id}",
        client_secret = "@{client_secret}",
        scope="email"
    })
```CSHARP
    .PostAsync(new
    {
        grant_type = "password",
        username = "@{username}",
        password = "@{password}",
        client_id = "@{client_id}",
        client_secret = "@{client_secret}",
        scope="email"
    })
```

## GET

Make a get with a query parameter
```CSHARP
    var person = await "https://api.com"
        .AppendPathSegment("person")
        .SetQueryParams(new { a = 1, b = 2 })
        .WithOAuthBearerToken("my_oauth_token")
        .GetJsonAsync<Person>();
```


## DELETE

Make a delete with a query parameter
```CSHARP
    var person = await "https://api.com"
        .AppendPathSegment("person")
        .SetQueryParams(new { a = 1, b = 2 })
        .WithOAuthBearerToken("my_oauth_token")
        .DeleteAsync();
```

## PUT

Make a put with a query parameter
```CSHARP
    var person = await "https://api.com"
        .AppendPathSegment("person")
        .SetQueryParams(new { a = 1, b = 2 })
        .WithOAuthBearerToken("my_oauth_token")
        .PutAsync(new
        {
            first_name = "Claire",
            last_name = "Underwood"
        })
        .MapJson<Person>();
```


## PATCH

Make a patch with a query parameter
```CSHARP
    var person = await "https://api.com"
        .AppendPathSegment("person")
        .SetQueryParams(new { a = 1, b = 2 })
        .WithOAuthBearerToken("my_oauth_token")
        .PatchAsync(new
        {
            first_name = "Claire",
            last_name = "Underwood"
        })
        .MapJson<Person>();
```

## HEAD

Make a head with a query parameter
```CSHARP
    var person = await "https://api.com"
        .AppendPathSegment("person")
        .SetQueryParams(new { a = 1, b = 2 })
        .WithOAuthBearerToken("my_oauth_token")
        .HeadAsync();
```

## OPTIONS

Make a options with a query parameter
```CSHARP
    var person = await "https://api.com"
        .AppendPathSegment("person")
        .SetQueryParams(new { a = 1, b = 2 })
        .WithOAuthBearerToken("my_oauth_token")
        .OptionsAsync();
```

## Dwonload file

Download a file
```CSHARP
    var file = await "https://api.com"
        .AppendPathSegment("file")
        .WithOAuthBearerToken("my_oauth_token")
        .DownloadAsync("file.txt");
```