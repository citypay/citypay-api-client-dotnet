# CityPayAPI.Api.ReportingApi

All URIs are relative to *https://api.citypay.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchedTransactionReportRequest**](ReportingApi.md#batchedtransactionreportrequest) | **POST** /v6/merchant-batch/{merchantid}/{batch_no}/transactions | Batch Transaction Report Request |
| [**MerchantBatchReportRequest**](ReportingApi.md#merchantbatchreportrequest) | **POST** /v6/merchant-batch/report | Merchant Batch Report Request |
| [**MerchantBatchRequest**](ReportingApi.md#merchantbatchrequest) | **GET** /v6/merchant-batch/{merchantid}/{batch_no} | Merchant Batch Request |
| [**RemittanceRangeReport**](ReportingApi.md#remittancerangereport) | **POST** /v6/remittance/report/{clientid} | Remittance Report Request |
| [**RemittanceReportRequest**](ReportingApi.md#remittancereportrequest) | **GET** /v6/remittance/report/{clientid}/{date} | Remittance Date Report Request |

<a id="batchedtransactionreportrequest"></a>
# **BatchedTransactionReportRequest**
> BatchTransactionReportResponse BatchedTransactionReportRequest (int merchantid, string batchNo, BatchTransactionReportRequest batchTransactionReportRequest)

Batch Transaction Report Request

Retrieves transactions available on a given batch.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class BatchedTransactionReportRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new ReportingApi(config);
            var merchantid = 56;  // int | A merchant ID (MID) for which data is requested. This field allows for filtering of the request by a specific merchant account.
            var batchNo = "batchNo_example";  // string | The batch number that is being requested.
            var batchTransactionReportRequest = new BatchTransactionReportRequest(); // BatchTransactionReportRequest | 

            try
            {
                // Batch Transaction Report Request
                BatchTransactionReportResponse result = apiInstance.BatchedTransactionReportRequest(merchantid, batchNo, batchTransactionReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.BatchedTransactionReportRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchedTransactionReportRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Batch Transaction Report Request
    ApiResponse<BatchTransactionReportResponse> response = apiInstance.BatchedTransactionReportRequestWithHttpInfo(merchantid, batchNo, batchTransactionReportRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingApi.BatchedTransactionReportRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **merchantid** | **int** | A merchant ID (MID) for which data is requested. This field allows for filtering of the request by a specific merchant account. |  |
| **batchNo** | **string** | The batch number that is being requested. |  |
| **batchTransactionReportRequest** | [**BatchTransactionReportRequest**](BatchTransactionReportRequest.md) |  |  |

### Return type

[**BatchTransactionReportResponse**](BatchTransactionReportResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A report of the transactions listed on batches. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="merchantbatchreportrequest"></a>
# **MerchantBatchReportRequest**
> MerchantBatchReportResponse MerchantBatchReportRequest (MerchantBatchReportRequest merchantBatchReportRequest)

Merchant Batch Report Request

Retrieves a report of merchant batches within a specified date range.  Batches, which aggregate daily processing activities, are typically generated at `00:00` each day.  These batches play a crucial role in the settlement of funds by summarising daily transactions. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class MerchantBatchReportRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new ReportingApi(config);
            var merchantBatchReportRequest = new MerchantBatchReportRequest(); // MerchantBatchReportRequest | 

            try
            {
                // Merchant Batch Report Request
                MerchantBatchReportResponse result = apiInstance.MerchantBatchReportRequest(merchantBatchReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.MerchantBatchReportRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MerchantBatchReportRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Merchant Batch Report Request
    ApiResponse<MerchantBatchReportResponse> response = apiInstance.MerchantBatchReportRequestWithHttpInfo(merchantBatchReportRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingApi.MerchantBatchReportRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **merchantBatchReportRequest** | [**MerchantBatchReportRequest**](MerchantBatchReportRequest.md) |  |  |

### Return type

[**MerchantBatchReportResponse**](MerchantBatchReportResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A report of the batches generated. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="merchantbatchrequest"></a>
# **MerchantBatchRequest**
> MerchantBatchResponse MerchantBatchRequest (int merchantid, string batchNo)

Merchant Batch Request

Retrieves a report of merchant a merchant batch for a specified batch number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class MerchantBatchRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new ReportingApi(config);
            var merchantid = 56;  // int | A merchant ID (MID) for which data is requested. This field allows for filtering of the request by a specific merchant account.
            var batchNo = "batchNo_example";  // string | The batch number that is being requested.

            try
            {
                // Merchant Batch Request
                MerchantBatchResponse result = apiInstance.MerchantBatchRequest(merchantid, batchNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.MerchantBatchRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MerchantBatchRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Merchant Batch Request
    ApiResponse<MerchantBatchResponse> response = apiInstance.MerchantBatchRequestWithHttpInfo(merchantid, batchNo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingApi.MerchantBatchRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **merchantid** | **int** | A merchant ID (MID) for which data is requested. This field allows for filtering of the request by a specific merchant account. |  |
| **batchNo** | **string** | The batch number that is being requested. |  |

### Return type

[**MerchantBatchResponse**](MerchantBatchResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A report of a single batch. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="remittancerangereport"></a>
# **RemittanceRangeReport**
> RemittanceReportResponse RemittanceRangeReport (string clientid, RemittanceReportRequest remittanceReportRequest)

Remittance Report Request

Fetches remittance reports for financial transactions within a specified date range, covering all client-related activities. This report consolidates all batches disbursed to a client, with each remittance summarising the aggregation of batches leading up to settlement. Additionally, the net remittance amount presented in the final settlement will reflect any deductions made by the acquirer. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class RemittanceRangeReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new ReportingApi(config);
            var clientid = "clientid_example";  // string | A client Id for which data is requested.
            var remittanceReportRequest = new RemittanceReportRequest(); // RemittanceReportRequest | 

            try
            {
                // Remittance Report Request
                RemittanceReportResponse result = apiInstance.RemittanceRangeReport(clientid, remittanceReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.RemittanceRangeReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemittanceRangeReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remittance Report Request
    ApiResponse<RemittanceReportResponse> response = apiInstance.RemittanceRangeReportWithHttpInfo(clientid, remittanceReportRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingApi.RemittanceRangeReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientid** | **string** | A client Id for which data is requested. |  |
| **remittanceReportRequest** | [**RemittanceReportRequest**](RemittanceReportRequest.md) |  |  |

### Return type

[**RemittanceReportResponse**](RemittanceReportResponse.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A report of financial remittance data for a range of dates. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="remittancereportrequest"></a>
# **RemittanceReportRequest**
> RemittedClientData RemittanceReportRequest (string clientid, string date)

Remittance Date Report Request

Fetches remittance reports for financial transactions for a given date,  covering all client-related activities. This report consolidates all batches disbursed to a  client, with each remittance summarising the aggregation of batches leading up to settlement.  Additionally, the net remittance amount presented in the final settlement will reflect any  deductions made by the acquirer.  The process also supports the notion of *today* deferring the date to today's date or *latest* reflecting the latest remittance date available. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CityPayAPI.Api;
using CityPayAPI.Client;
using CityPayAPI.Model;

namespace Example
{
    public class RemittanceReportRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.citypay.com";
            // Create a temporal ApiKey using your client id and licence key
            config.AddApiKey("cp-api-key", new ApiKey("CLIENT_ID", "LICENCE_KEY").GenerateKey());

            var apiInstance = new ReportingApi(config);
            var clientid = "clientid_example";  // string | A client Id for which data is requested.
            var date = "date_example";  // string | Date (YYYY-MM-DD) to filter the request for.

            try
            {
                // Remittance Date Report Request
                RemittedClientData result = apiInstance.RemittanceReportRequest(clientid, date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.RemittanceReportRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemittanceReportRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remittance Date Report Request
    ApiResponse<RemittedClientData> response = apiInstance.RemittanceReportRequestWithHttpInfo(clientid, date);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportingApi.RemittanceReportRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientid** | **string** | A client Id for which data is requested. |  |
| **date** | **string** | Date (YYYY-MM-DD) to filter the request for. |  |

### Return type

[**RemittedClientData**](RemittedClientData.md)

### Authorization

[cp-api-key](../README.md#cp-api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A report of the financial remittance data for a given date. |  -  |
| **400** | Bad Request. Should the incoming data not be validly determined. |  -  |
| **401** | Unauthorized. No api key has been provided and is required for this operation. |  -  |
| **403** | Forbidden. The api key was provided and understood but is either incorrect or does not have permission to access the account provided on the request. |  -  |
| **422** | Unprocessable Entity. Should a failure occur that prevents processing of the API call. |  -  |
| **500** | Server Error. The server was unable to complete the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

