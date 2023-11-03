using System;
using Microsoft.AspNetCore.Components;

namespace JBWebsite.Pages
{
	public class AboutMeBase : ComponentBase
    { 

        public string? JoeString { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            JoeString = "test base class";
        }

    }
}

