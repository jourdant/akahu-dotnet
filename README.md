# akahu-dotnet
A .NET Standard implementation of the Akahu.io v1 REST API. More information here: https://api-developers.akahu.io/.

## Example
```csharp
//get api client
var apiClient = AkahuV1ApiFactory.GetApiClient(appToken, userToken);

//test api
var accounts = await apiClient.GetAccountsAsync();
accounts.ForEach(x => Console.WriteLine(x.Name));
```
