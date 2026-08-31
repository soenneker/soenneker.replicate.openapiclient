[![](https://img.shields.io/nuget/v/soenneker.replicate.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.replicate.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.replicate.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.replicate.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.replicate.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.replicate.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.replicate.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.replicate.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Replicate.OpenApiClient

Generated request builders and models for Replicate models, predictions, deployments, trainings, files, search, hardware, collections, account details, and webhook secrets.

## Installation

```bash
dotnet add package Soenneker.Replicate.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Replicate.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://api.replicate.com/v1"
};

var client = new ReplicateOpenApiClient(adapter);
var account = await client.Account.GetAsync(
    cancellationToken: cancellationToken);
```

Replicate API tokens use the bearer scheme. The anonymous Kiota authentication provider is intentional because the supplied `HttpClient` already carries the `Authorization` header.

List operations such as models, predictions, deployments, and trainings are paginated. Follow the response's `next` URL rather than assuming the first page is complete.
