

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
        .ReceiveObject<Person>();

```

string are implicit converted in Url

```CSHARP
    Url url = "https://user:pass@www.mysite.com:1234/with/path?x=1&y=2#foo";
```


Create an Url object with segment
```CSHARP
    var url = new Url("https://api.com", "segment");        
```

