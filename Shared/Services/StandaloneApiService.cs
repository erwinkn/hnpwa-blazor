using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using HnpwaBlazor.Shared.Models;

namespace HnpwaBlazor.Shared.Services
{
    public class StandaloneApiService
    {
        private HttpClient HttpClient { get; }

        public StandaloneApiService()
        {
            HttpClient = new HttpClient { BaseAddress = new Uri("https://api.hackerwebapp.com/") };
        }

        public async Task<List<Item>> GetList(string category, int pageNb=1)
        {
            if(pageNb > 10)
                throw new ArgumentOutOfRangeException("Can only go up to page 10");

            List<Item> items = await HttpClient.GetFromJsonAsync<List<Item>>(category + "?page=" + pageNb);
            
            if(items == null)
                throw new NullReferenceException("Could not read stories from API response");
            return items;
        }

        public async Task<Item> GetItem(int id)
        {
            Item item = await HttpClient.GetFromJsonAsync<Item>("item/" + id);
            
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