﻿using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Akahu.Api
{
    public static class AkahuV1ApiFactory
    {
        /// <summary>
        /// AkahuV1ApiFactory instantiates a class from IAkahuV1Api with the correct properties configured.
        /// </summary>
        public static IAkahuV1Api GetApiClient(string apiBaseUrl, string apiAppAccessToken, string apiUserAccessToken)
        {
            //set up HttpClient with correct auth headers
            var apiHttpClient = new HttpClient();
            apiHttpClient.BaseAddress = new Uri(apiBaseUrl);
            apiHttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiUserAccessToken);
            apiHttpClient.DefaultRequestHeaders.Add("X-Akahu-ID", apiAppAccessToken);

            //set refit client settings
            var refitSettings = new RefitSettings()
            {
                ContentSerializer = new SystemTextJsonContentSerializer(new System.Text.Json.JsonSerializerOptions
                {
                    IgnoreNullValues = true,
                    PropertyNameCaseInsensitive = true
                })
            };

            //set up api client
            var api = RestService.For<IAkahuV1Api>(apiHttpClient, refitSettings);
            return api;
        }
    }
}
