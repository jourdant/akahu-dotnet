﻿using Akahu.Api.Models;
using Refit;
using System;
using System.Collections.Generic;
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


        #region Data Refresh
        [Post("/v1/refresh")]
        Task<AkahuResponseBase> RefreshAllAccountsAsync();

        [Post("/v1/refresh/{accountOrConnectionId}")]
        Task<AkahuResponseBase> RefreshAccountAsync(string accountOrConnectionId);
        #endregion


        #region Merchants
        [Get("/v1/merchants/{merchantId}")]
        Task<AkahuResponse<Merchant>> GetMerchantAsync(string merchantId);
        #endregion


        #region Payments
        //[Get("/v1/payments")]
        //Task<AkahuListResponse<Payment>> GetPaymentsAsync();

        [Get("/v1/payments")]
        Task<AkahuListResponse<Payment>> GetPaymentsAsync(
            [Query(Format = "yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")][AliasAs("start")]DateTimeOffset startDate,
            [Query(Format = "yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")][AliasAs("end")]DateTimeOffset endDate);
        
        [Post("/v1/payments")]
        Task<AkahuListResponse<Payment>> CreatePayment(PaymentRequest paymentRequest);
        #endregion


        #region Standing Orders
        [Get("/v1/standing-orders")]
        Task<AkahuListResponse<StandingOrder>> GetStandingOrdersAsync();
        #endregion


        #region Statements
        [Get("/v1/statements")]
        Task<AkahuListResponse<Statement>> GetStatementsAsync();

        [Get("/v1/statements/{statementId}")]
        Task<AkahuResponse<Statement>> GetStatementAsync(string statementId);
        #endregion


        #region Transactions
        [Get("/v1/transactions")]
        Task<AkahuListResponse<Transaction>> GetTransactionsAsync(
            [Query(Format = "yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")][AliasAs("start")]DateTimeOffset startDate,
            [Query(Format = "yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")][AliasAs("end")]DateTimeOffset endDate);

        [Get("/v1/accounts/{accountId}/transactions")]
        Task<AkahuListResponse<Transaction>> GetTransactionsByAccountAsync(
            string accountId,
            [Query(Format = "yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")][AliasAs("start")]DateTimeOffset startDate,
            [Query(Format = "yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")][AliasAs("end")]DateTimeOffset endDate);

        [Post("/v1/transactions/ids")]
        Task<AkahuListResponse<Transaction>> GetTransactionsByIdsAsync([Body]List<string> transactionIds);
        #endregion


        #region Transfers
        [Get("/v1/transfers")]
        Task<AkahuListResponse<Transfer>> GetTransfersAsync(
            [Query(Format = "yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")][AliasAs("start")]DateTimeOffset startDate,
            [Query(Format = "yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")][AliasAs("end")]DateTimeOffset endDate);

        [Get("/v1/transfers/{transferId}")]
        Task<AkahuResponse<Transfer>> GetTransferAsync(string transferId);

        [Post("/v1/transfers")]
        Task<AkahuConfirmationResponse> CreateTransfer([Body]TransferRequest transferRequest);
        #endregion


        #region Users
        [Get("/v1/me")]
        Task<AkahuResponse<User>> GetCurrentUserAsync();

        [Get("/v1/me/details")]
        Task<AkahuListResponse<UserProperty>> GetTransfersAsync();
        #endregion


        #region Users
        [Get("/v1/webhooks")]
        Task<AkahuListResponse<Webhook>> GetWebhooksAsync();

        [Post("/v1/webhooks")]
        Task<AkahuListResponse<Webhook>> CreateWebhookAsync(WebhookRequest webhookRequest);

        [Delete("/v1/webhooks/{webhookId}")]
        Task<AkahuResponseBase> DeleteWebhookAsync(string webhookId);

        [Get("/v1/keys/{keyId}")]
        Task<AkahuResponse<string>> GetPublicKeyAsync(string keyId);
        #endregion
    }
}
