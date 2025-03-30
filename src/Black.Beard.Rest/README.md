# sdk.net

## Black beard rest sdk

the http client is based on RestSharp.


Url managed with the Url class
```csharp

Url url = "http://localhost:8080";

Url url = new Url("http://localhost:8080");

Url url = "http://localhost:8080/{res}/path"
            .Map("res", "master");

```


Create a client
```csharp

string root = "http://localhost:8080";
string urlStr = "/{res}/path";
Url urlStr = url.Map("res", "master");


var options = new RestClientOptions(root)
    .WithLog(c => c.LogAll, c => c.LogAll)
    ;

var client = new RestClient(options);

client.ExecuteAsync
(
    Method.GET
        .NewRequest(urlStr)
);

```


With Ioc
```csharp




```
