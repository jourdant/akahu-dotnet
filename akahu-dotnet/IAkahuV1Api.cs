using Akahu.Api.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Akahu.Api
{
    public interface IAkahuV1Api
    {
        #region Accounts
        [Get("/v1/accounts")]
        Task<AkahuListResponse<Account>> GetAccountsAsync();

        [Get("/v1/accounts/{accountId}")]
        Task<AkahuResponse<Account>> GetAccountAsync(string accountId); 
        #endregion


        #region Categories
        [Get("/v1/categories")]
        Task<AkahuListResponse<Category>> GetCategoriesAsync();

        [Get("/v1/categories/{categoryId}")]
        Task<AkahuResponse<Category>> GetCategoryAsync(string categoryId); 
        #endregion


        #region Connections
        [Get("/v1/connections")]
        Task<AkahuListResponse<Connection>> GetConnectionsAsync();

        [Get("/v1/connections/{connectionId}")]
        Task<AkahuResponse<Connection>> GetConnectionAsync(string connectionId); 
        #endregion


        #region Refresh
        [Post("/v1/refresh")]
        Task<AkahuResponseBase> RefreshAllAccountsAsync();

        [Post("/v1/refresh/{accountOrConnectionId}")]
        Task<AkahuResponseBase> RefreshAccountAsync(string accountOrConnectionId);
        #endregion


        #region Merchants
        [Get("/v1/merchants")]
        Task<AkahuListResponse<Merchant>> GetMerchantsAsync();

        [Get("/v1/merchants/{merchantId}")]
        Task<AkahuResponse<Merchant>> GetMerchantAsync(string merchantId);
        #endregion


        #region Payments
        [Get("v1/payments")]
        Task<AkahuListResponse<Payment>> GetPaymentsAsync();

        [Get("v1/payments")]
        Task<AkahuListResponse<Payment>> GetPaymentsAsync([Query][AliasAs("start")]DateTimeOffset startDate, [Query][AliasAs("end")]DateTimeOffset endDate);
        
        [Post("v1/payments")]
        Task<AkahuListResponse<Payment>> CreatePayment(PaymentRequest paymentRequest);
        #endregion


        #region Standing Orders
        [Get("v1/standing-orders")]
        Task<AkahuListResponse<StandingOrder>> GetStandingOrdersAsync();
        #endregion


        #region Statements
        [Get("/v1/statements")]
        Task<AkahuListResponse<Statement>> GetStatementsAsync();

        [Get("/v1/statements/{statementId}")]
        Task<AkahuResponse<Statement>> GetStatementAsync(string statementId);
        #endregion
    }
}
