# CityPayAPI.Api.BatchProcessingApi

All URIs are relative to *https://api.citypay.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchProcessRequest**](BatchProcessingApi.md#batchprocessrequest) | **POST** /v6/batch/process | Batch Process Request |
| [**BatchRetrieveRequest**](BatchProcessingApi.md#batchretrieverequest) | **POST** /v6/batch/retrieve | BatchReportRequest |
| [**CheckBatchStatusRequest**](BatchProcessingApi.md#checkbatchstatusrequest) | **POST** /v6/batch/status | CheckBatchStatus |

<a id="batchprocessrequest"></a>
# **BatchProcessRequest**
> ProcessBatchResponse BatchProcessRequest (ProcessBatchRequest processBatchRequest)

Batch Process Request

A batch process request is used to start the batch process workflow by uploading batch
data and initialising a new batch for processing. Once validated the batch will be queued
for processing and further updates can be received by a subsequent call to retrieve the batch
status.


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class BatchProcessRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new BatchProcessingApi(config);
            var processBatchRequest = new ProcessBatchRequest(); // ProcessBatchRequest | 

            try
            {
                // Batch Process Request
                ProcessBatchResponse result = apiInstance.BatchProcessRequest(processBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchProcessingApi.BatchProcessRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchProcessRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Batch Process Request
    ApiResponse<ProcessBatchResponse> response = apiInstance.BatchProcessRequestWithHttpInfo(processBatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchProcessingApi.BatchProcessRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processBatchRequest** | [**ProcessBatchRequest**](ProcessBatchRequest.md) |  |  |

### Return type

[**ProcessBatchResponse**](ProcessBatchResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request to process a batch provided in the request. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="batchretrieverequest"></a>
# **BatchRetrieveRequest**
> BatchReportResponseModel BatchRetrieveRequest (BatchReportRequest batchReportRequest)

BatchReportRequest

The report for a given batch.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class BatchRetrieveRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new BatchProcessingApi(config);
            var batchReportRequest = new BatchReportRequest(); // BatchReportRequest | 

            try
            {
                // BatchReportRequest
                BatchReportResponseModel result = apiInstance.BatchRetrieveRequest(batchReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchProcessingApi.BatchRetrieveRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchRetrieveRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BatchReportRequest
    ApiResponse<BatchReportResponseModel> response = apiInstance.BatchRetrieveRequestWithHttpInfo(batchReportRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchProcessingApi.BatchRetrieveRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchReportRequest** | [**BatchReportRequest**](BatchReportRequest.md) |  |  |

### Return type

[**BatchReportResponseModel**](BatchReportResponseModel.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The report for a given batch. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checkbatchstatusrequest"></a>
# **CheckBatchStatusRequest**
> CheckBatchStatusResponse CheckBatchStatusRequest (CheckBatchStatus checkBatchStatus)

CheckBatchStatus

The operation is used to retrieve the status of a batch process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class CheckBatchStatusRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new BatchProcessingApi(config);
            var checkBatchStatus = new CheckBatchStatus(); // CheckBatchStatus | 

            try
            {
                // CheckBatchStatus
                CheckBatchStatusResponse result = apiInstance.CheckBatchStatusRequest(checkBatchStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchProcessingApi.CheckBatchStatusRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckBatchStatusRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CheckBatchStatus
    ApiResponse<CheckBatchStatusResponse> response = apiInstance.CheckBatchStatusRequestWithHttpInfo(checkBatchStatus);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchProcessingApi.CheckBatchStatusRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **checkBatchStatus** | [**CheckBatchStatus**](CheckBatchStatus.md) |  |  |

### Return type

[**CheckBatchStatusResponse**](CheckBatchStatusResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The status of batches provided in the request. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

