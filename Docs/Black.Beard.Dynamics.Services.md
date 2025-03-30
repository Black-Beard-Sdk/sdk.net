<a name='assembly'></a>
# Black.Beard.Dynamics.Services

## Contents

- [ApiKeyGenerator](#T-Bb-Services-ApiKeyGenerator 'Bb.Services.ApiKeyGenerator')
  - [GenerateApiKey(length)](#M-Bb-Services-ApiKeyGenerator-GenerateApiKey-System-Int32- 'Bb.Services.ApiKeyGenerator.GenerateApiKey(System.Int32)')
  - [GenerateIdentifiers(apiKey,salt)](#M-Bb-Services-ApiKeyGenerator-GenerateIdentifiers-System-String,System-Int32,System-Int32,System-String- 'Bb.Services.ApiKeyGenerator.GenerateIdentifiers(System.String,System.Int32,System.Int32,System.String)')
  - [GeneratePassword(rawData,lengthPassword,salt)](#M-Bb-Services-ApiKeyGenerator-GeneratePassword-System-String,System-Int32,System-String- 'Bb.Services.ApiKeyGenerator.GeneratePassword(System.String,System.Int32,System.String)')
  - [ResolveLogin(rawData,lengthPassword,salt)](#M-Bb-Services-ApiKeyGenerator-ResolveLogin-System-String,System-Int32,System-String- 'Bb.Services.ApiKeyGenerator.ResolveLogin(System.String,System.Int32,System.String)')
- [Assemblies](#T-Bb-Loaders-Extensions-Assemblies 'Bb.Loaders.Extensions.Assemblies')
  - [AdditionalAssemblies](#P-Bb-Loaders-Extensions-Assemblies-AdditionalAssemblies 'Bb.Loaders.Extensions.Assemblies.AdditionalAssemblies')
  - [WebAssemblies](#P-Bb-Loaders-Extensions-Assemblies-WebAssemblies 'Bb.Loaders.Extensions.Assemblies.WebAssemblies')
  - [Resolve()](#M-Bb-Loaders-Extensions-Assemblies-Resolve-System-String,System-String[]- 'Bb.Loaders.Extensions.Assemblies.Resolve(System.String,System.String[])')
- [ConfigurationExtension](#T-Bb-Extensions-ConfigurationExtension 'Bb.Extensions.ConfigurationExtension')
  - [LoadConfiguration(builder)](#M-Bb-Extensions-ConfigurationExtension-LoadConfiguration-Microsoft-AspNetCore-Builder-WebApplicationBuilder,System-String[]- 'Bb.Extensions.ConfigurationExtension.LoadConfiguration(Microsoft.AspNetCore.Builder.WebApplicationBuilder,System.String[])')
- [ConfigurationLoader](#T-Bb-Loaders-ConfigurationLoader 'Bb.Loaders.ConfigurationLoader')
- [IocAutoDiscoverExtension](#T-Bb-Extensions-IocAutoDiscoverExtension 'Bb.Extensions.IocAutoDiscoverExtension')
  - [GetExposedTypes(contextName)](#M-Bb-Extensions-IocAutoDiscoverExtension-GetExposedTypes-System-String- 'Bb.Extensions.IocAutoDiscoverExtension.GetExposedTypes(System.String)')
- [PolicyExtension](#T-Bb-PolicyExtension 'Bb.PolicyExtension')
  - [AddPolicy(builder,filePath,filter,configureAction)](#M-Bb-PolicyExtension-AddPolicy-Microsoft-AspNetCore-Builder-WebApplicationBuilder,System-String,System-Func{Bb-Policies-Asts-PolicyRule,System-Boolean},System-Action{Microsoft-AspNetCore-Authorization-AuthorizationOptions}- 'Bb.PolicyExtension.AddPolicy(Microsoft.AspNetCore.Builder.WebApplicationBuilder,System.String,System.Func{Bb.Policies.Asts.PolicyRule,System.Boolean},System.Action{Microsoft.AspNetCore.Authorization.AuthorizationOptions})')
  - [ConfigurePolicy(app)](#M-Bb-PolicyExtension-ConfigurePolicy-Microsoft-AspNetCore-Builder-WebApplication- 'Bb.PolicyExtension.ConfigurePolicy(Microsoft.AspNetCore.Builder.WebApplication)')
  - [GetAuthorizePoliciesFromAssemblies()](#M-Bb-PolicyExtension-GetAuthorizePoliciesFromAssemblies 'Bb.PolicyExtension.GetAuthorizePoliciesFromAssemblies')

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
### GenerateIdentifiers(apiKey,salt) `method`

##### Summary

Generates a login and password pair based on the provided raw data.

##### Returns

A tuple containing the generated login and password.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw data to use as seed for generating identifiers. Must not be null or empty. |
| salt | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | third part for concatenate to rawData before generate login and password |

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
### ResolveLogin(rawData,lengthPassword,salt) `method`

##### Summary

Generates a login identifier by hashing the provided raw data using SHA256.

##### Returns

A hexadecimal string representation of the SHA256 hash of the raw data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rawData | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw data to hash. Must not be null. |
| lengthPassword | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | string length of the login. Must be upper of 15 characters |
| salt | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | third part for concatenate to rawData before generate login |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when rawData is null. |

##### Remarks

This method computes the SHA256 hash of the raw data and returns it as a hexadecimal string.

<a name='T-Bb-Loaders-Extensions-Assemblies'></a>
## Assemblies `type`

##### Namespace

Bb.Loaders.Extensions

<a name='P-Bb-Loaders-Extensions-Assemblies-AdditionalAssemblies'></a>
### AdditionalAssemblies `property`

##### Summary

Return assembly to add for discover routes

<a name='P-Bb-Loaders-Extensions-Assemblies-WebAssemblies'></a>
### WebAssemblies `property`

##### Summary

Return all assemblies that contain type with route attribute

<a name='M-Bb-Loaders-Extensions-Assemblies-Resolve-System-String,System-String[]-'></a>
### Resolve() `method`

##### Summary

Ensure required assemblies are loaded

##### Parameters

This method has no parameters.

<a name='T-Bb-Extensions-ConfigurationExtension'></a>
## ConfigurationExtension `type`

##### Namespace

Bb.Extensions

<a name='M-Bb-Extensions-ConfigurationExtension-LoadConfiguration-Microsoft-AspNetCore-Builder-WebApplicationBuilder,System-String[]-'></a>
### LoadConfiguration(builder) `method`

##### Summary

Load configuration and discover all methods for loading configuration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') | [WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') |

##### Example

```Csharp
var builder = WebApplication.CreateBuilder(args).LoadConfiguration();
```

If you want adding configuration, append a new class with the attribute [](#!-ExposeClassAttribute 'ExposeClassAttribute') and implement 
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

<a name='T-Bb-Loaders-ConfigurationLoader'></a>
## ConfigurationLoader `type`

##### Namespace

Bb.Loaders

##### Summary

Download configuration form git repository and load the configuration

<a name='T-Bb-Extensions-IocAutoDiscoverExtension'></a>
## IocAutoDiscoverExtension `type`

##### Namespace

Bb.Extensions

<a name='M-Bb-Extensions-IocAutoDiscoverExtension-GetExposedTypes-System-String-'></a>
### GetExposedTypes(contextName) `method`

##### Summary

Gets the exposed types in loaded assemblies.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| contextName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the context. |

<a name='T-Bb-PolicyExtension'></a>
## PolicyExtension `type`

##### Namespace

Bb

<a name='M-Bb-PolicyExtension-AddPolicy-Microsoft-AspNetCore-Builder-WebApplicationBuilder,System-String,System-Func{Bb-Policies-Asts-PolicyRule,System-Boolean},System-Action{Microsoft-AspNetCore-Authorization-AuthorizationOptions}-'></a>
### AddPolicy(builder,filePath,filter,configureAction) `method`

##### Summary

Append policies form specified file

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Builder.WebApplicationBuilder](#T-Microsoft-AspNetCore-Builder-WebApplicationBuilder 'Microsoft.AspNetCore.Builder.WebApplicationBuilder') |  |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| filter | [System.Func{Bb.Policies.Asts.PolicyRule,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{Bb.Policies.Asts.PolicyRule,System.Boolean}') |  |
| configureAction | [System.Action{Microsoft.AspNetCore.Authorization.AuthorizationOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Microsoft.AspNetCore.Authorization.AuthorizationOptions}') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |

<a name='M-Bb-PolicyExtension-ConfigurePolicy-Microsoft-AspNetCore-Builder-WebApplication-'></a>
### ConfigurePolicy(app) `method`

##### Summary

Configures the policy evaluator service.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| app | [Microsoft.AspNetCore.Builder.WebApplication](#T-Microsoft-AspNetCore-Builder-WebApplication 'Microsoft.AspNetCore.Builder.WebApplication') |  |

<a name='M-Bb-PolicyExtension-GetAuthorizePoliciesFromAssemblies'></a>
### GetAuthorizePoliciesFromAssemblies() `method`

##### Summary

Retrieves all policy names from AuthorizeAttribute across all loaded assemblies

##### Returns

A list of unique policy names

##### Parameters

This method has no parameters.
