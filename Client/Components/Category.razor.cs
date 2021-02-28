using System.Collections.Generic;
using System.Threading.Tasks;
using HnpwaBlazor.Shared.Services;
using HnpwaBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace HnpwaBlazor.Client.Components
{
    public partial class Category
    {
        [Inject]
        public IApiService ApiService { get; set; }

        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public int Page { get; set; }
        [Parameter]
        public int MaxPage { get; set; }

        List<Item> Stories { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            Stories = await ApiService.GetList(Name, (int)Page);
        }
    }
}