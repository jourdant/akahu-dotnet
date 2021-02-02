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
        Task<Account> GetAccountAsync(string accountId);
    }
}
