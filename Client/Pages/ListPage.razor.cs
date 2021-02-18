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
        IEnumerable<IStory> Stories { get; set; }

        string prevStyling => Page == 1 ? "hidden" : "text-gray-800";
        string nextStyling => Page == maxPage ? "hidden" : "text-gray-800";

        protected override async Task OnParametersSetAsync()
        {
            // Get first page by default
            Page = Page ?? 1;
            // Get news by default
            Category = Category ?? "news";
            // Redirect to news for incorrect categories
            string[] categories = { "news", "newest", "ask", "show", "jobs" };
            // TODO: check if the relative URL works here
            if(!categories.Contains(Category))
                NavigationManager.NavigateTo("news/1");
            else
            {
                if(Category == "jobs")
                    maxPage = 2;
                if(Page < 1)
                    NavigationManager.NavigateTo(Category + "/1");
                if(Page > maxPage)
                    NavigationManager.NavigateTo(Category + "/" + maxPage);
                Stories = await ApiService.GetList(Category, (int)Page);
            }
        }
    }
}