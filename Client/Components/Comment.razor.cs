using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Hnpwa.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Hnpwa.Client.Components
{
    public partial class Comment
    {
        [Parameter]
        public IComment Item { get; set; }

        bool show = true;
        string toggleIndicator => show ? "-" : Item.Comments.Count + " more";

        void Toggle(MouseEventArgs e)
        {
            show = !show;
        }
    }
}