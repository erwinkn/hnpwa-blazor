using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Linq;
using System.Threading.Tasks;
using HnpwaBlazor.Shared.Services;
using HnpwaBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace HnpwaBlazor.Client.Pages
{
    public partial class ItemPage
    {
        [Inject]
        public IApiService ApiService { get; set; }
        [Inject]
        public IPrerenderCache Cache { get; set; }
        [Parameter]
        public int Id { get; set; }

        Item? Item { get; set; }
        IEnumerable<IPollOption> PollOptions { get; set; } = new List<IPollOption>();
        int maxPollScore;
        string titleBase = "Blazor HN";

        protected override async Task OnParametersSetAsync()
        {
            Item = await ApiService.GetItem(Id);
            if(Item.Poll.Count > 0)
            {
                PollOptions = await ApiService.GetPollOptions(Item.Id, Item.Poll.Count);
                maxPollScore = PollOptions.Max(pollopt => pollopt.Points) ?? 0;
            }
        }
    }
}