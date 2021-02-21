using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HnpwaBlazor.Services;
using HnpwaBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace HnpwaBlazor.Pages
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
        List<Item>? Stories { get; set; }

        string titleBase = "Blazor HN";

        public string GetPageTitle()
        {
            switch(Category)
            {
                case "news":
                    return "Top stories | " + titleBase;
                case "newest":
                    return "New stories | " + titleBase;
                case "ask":
                    return "Ask | " + titleBase;
                case "jobs":
                    return "Jobs | " + titleBase;
                case "show":
                    return "Show | " + titleBase;
                default:
                    return titleBase;
            }
        }

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