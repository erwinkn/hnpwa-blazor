using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using HnpwaBlazor.Shared.Models;

namespace HnpwaBlazor.Shared.Services
{
    // API service for the unofficial API, since the official one is basically unusable
    // https://github.com/cheeaun/node-hnapi
    public class ApiService : IApiService
    {
        private HttpClient HttpClient { get; }
        private IPrerenderCache Cache { get; }

        public ApiService(IPrerenderCache cache)
        {
            HttpClient = new HttpClient { BaseAddress = new Uri("https://api.hackerwebapp.com/") };
            Cache = cache;
        }

        public async Task<List<Item>> GetList(string category, int pageNb=1)
        {
            if(pageNb > 10)
                throw new ArgumentOutOfRangeException("Can only go up to page 10");

            List<Item> items;
            if(Cache.LoadingFinished)
                items = await HttpClient.GetFromJsonAsync<List<Item>>(category + "?page=" + pageNb);
            else
                items = await Cache.GetOrAdd(category + pageNb, () => HttpClient.GetFromJsonAsync<List<Item>>(category + "?page=" + pageNb));
            
            if(items == null)
                throw new NullReferenceException("Could not read stories from API response");
            return items;
        }

        public async Task<Item> GetItem(int id)
        {
            Item item;
            if(Cache.LoadingFinished)
                item = await HttpClient.GetFromJsonAsync<Item>("item/" + id);
            else
                item = await Cache.GetOrAdd("item" + id, () => HttpClient.GetFromJsonAsync<Item>("item/" + id));
            if(item == null)
                throw new NullReferenceException("Could not read item from API response");
            return item;
        }

        // TODO: add support for serializing poll options
        public async Task<List<IPollOption>> GetPollOptions(int pollId, int nbOptions)
        {
            List<IPollOption> options = new List<IPollOption>();
            for(int i = 1; i < nbOptions; i++)
            {
                var opt = await HttpClient.GetFromJsonAsync<Item>($"item/{pollId + i}");
                if(opt == null)
                    throw new NullReferenceException("Could not read poll option from API response");
                options.Add(opt);
            }
            return options;
        }

        // We don't handle users since support was dropped from the unofficial API
        // and using the official one would require dozens or hundreds of calls per user page
    }
}