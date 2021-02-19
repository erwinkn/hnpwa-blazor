using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hnpwa.Client.Services;
using Hnpwa.Shared;
using Microsoft.AspNetCore.Components;

namespace Hnpwa.Client.Pages
{
    public partial class ListPage
    {
        [Inject]
        ApiService ApiService { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string? Category { get; set; }
        [Parameter]
        public int? Page { get; set; }

        int maxPage = 10;
        IEnumerable<IStory>? Stories { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            // Get news by default or redirect to it for incorrect categories
            string[] categories = { "news", "newest", "ask", "show", "jobs" };
            if(Category == null || !categories.Contains(Category))
                NavigationManager.NavigateTo("news/1");
            else
            {
                // Get first page if not specified
                Page = Page ?? 1;
                maxPage = Category == "news" || Category == "newest" ? 10 : Category == "ask" ? 3 : 2;
                if(Page < 1)
                    NavigationManager.NavigateTo(Category + "/1");
                if(Page > maxPage)
                    NavigationManager.NavigateTo(Category + "/" + maxPage);
                Stories = await ApiService.GetList(Category, (int)Page);
            }
        }
    }
}