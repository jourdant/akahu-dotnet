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
        [Get("/v1/accounts")]
        Task<AkahuListResponse<Account>> GetAccountsAsync();

        [Get("/v1/accounts/{accountId}")]
        Task<AkahuResponse<Account>> GetAccountAsync(string accountId);

        [Get("/v1/categories")]
        Task<AkahuListResponse<Category>> GetCategoriesAsync();

        [Get("/v1/categories/{categoryId}")]
        Task<AkahuResponse<Category>> GetCategoryAsync(string categoryId);

        [Get("/v1/connections")]
        Task<AkahuListResponse<Connection>> GetConnectionsAsync();

        [Get("/v1/connections/{connectionId}")]
        Task<AkahuResponse<Connection>> GetConnectionAsync(string connectionId);

        [Post("/v1/refresh")]
        Task<AkahuResponseBase> RefreshAllAccounts();

        [Post("/v1/refresh/{accountOrConnectionId}")]
        Task<AkahuResponseBase> RefreshAccount(string accountOrConnectionId);

        [Get("/v1/merchants")]
        Task<AkahuListResponse<Merchant>> GetMerchantsAsync();

        [Get("/v1/merchants/{merchantId}")]
        Task<AkahuResponse<Merchant>> GetMerchantAsync(string merchantId);
    }
}
