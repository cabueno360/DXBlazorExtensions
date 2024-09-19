using Microsoft.AspNetCore.Components;

namespace DXBlazorExtensions.Culture
{
    public partial class CultureItem 
    {

        [Parameter]
        public bool Visible { get; set; } = false;


        [Parameter]
        public string Name { get; set; } =string.Empty;

        [Parameter]
        public string Label { get; set; } = string.Empty;

        [Parameter]
        public string AriaLabel { get; set; } = string.Empty;

        [Parameter]
        public string FlagCss { get; set; } = string.Empty;

        private string cultureCss { get; set; } =  $"menu-flag ";

        [Parameter]
        public EventCallback<string> OnCultureChange { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                cultureCss += FlagCss;
                StateHasChanged();
            }
        }

        private Task ChangeCulture()
        {
            return OnCultureChange.InvokeAsync(Name);
        }


    }
}
