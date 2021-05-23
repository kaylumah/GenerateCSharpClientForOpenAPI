// Copyright (c) Kaylumah, 2021. All rights reserved.
// See LICENSE file in the project root for full license information.

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Kaylumah.GenerateCSharpClientForOpenAPI.Sdks.PetStore.Interface;
using Kaylumah.GenerateCSharpClientForOpenAPI.Sdks.PetStore.Service;

namespace Kaylumah.GenerateCSharpClientForOpenAPI.Client.ApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            //var apiClient = new MyNamespace.Client(httpClient);
            IPetStoreClient apiClient = new PetStoreClient(httpClient);
            var result = await apiClient.GetInventoryAsync();
            Console.WriteLine(string.Join("|", result.Keys));
        }
    }
}
