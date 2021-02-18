using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Hnpwa.Client.Services;
using Hnpwa.Shared;
using Microsoft.AspNetCore.Components;

namespace Hnpwa.Client.Pages
{
    public partial class ItemPage
    {
        [Inject]
        public ApiService ApiService { get; set; }
        [Parameter]
        public int Id { get; set; }

        Item? Item { get; set; }
        IEnumerable<IPollOption> PollOptions { get; set; } = new List<IPollOption>();

        protected override async Task OnParametersSetAsync()
        {
            Item = await ApiService.GetItem(Id);
            if(Item.Poll.Count > 0)
                PollOptions = await ApiService.GetPollOptions(Item.Id, Item.Poll.Count);
        }
    }
}