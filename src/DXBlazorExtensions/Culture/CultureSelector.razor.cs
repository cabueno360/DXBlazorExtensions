using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Globalization;

namespace DXBlazorExtensions.Culture
{
    public partial class CultureSelector
    {
        [Inject]
        private IJSRuntime JS { get; set; } = default!;

        [Inject]
        private NavigationManager Navigation { get; set; } = default!;

        [Parameter]
        public string AriaLabel { get; set; } = default!;

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        //IconCssClass="@SelectedFlagClass" aria-label="@Localization[TanslationKeys.SelectLanguage]" 

        private string SelectedFlagClass = "menu-flag-fr menu-flag";

        void SetFlag(string flagCode)
        {
            SelectedFlagClass = $"menu-flag-{flagCode} menu-flag";
        }

        private async Task SetSelectedCulture(string cultureCode)
        {
            SelectedCulture = new CultureInfo(cultureCode);
            await ApplySelectedCultureAsync();
        }

        private string GetFlagCode(string cultureName)
        {
            return cultureName switch
            {
                "en-GB" => "gb",
                "pt-PT" => "pt",
                "fr" => "fr",
                "de" => "de",
                "lb" => "lu",
                _ => "fr",
            };
        }


        private CultureInfo[] supportedCultures = new[]
        {
        new CultureInfo("en-GB"),
        new CultureInfo("fr"),
        new CultureInfo("pt-PT"),
        new CultureInfo("de"),
        new CultureInfo("lb"),
    };


        private CultureInfo? selectedCulture;

        [Parameter]

        public CultureInfo? SelectedCulture
        {
            get => selectedCulture;
            set
            {
                if (selectedCulture != value)
                {
                    selectedCulture = value;
                    OnCultureChanged();
                }
            }
        }

        private async void OnCultureChanged()
        {
            if (selectedCulture == null)
                return;

            var flagCode = GetFlagCode(selectedCulture!.ToString());
            SetFlag(flagCode);
            //await ApplySelectedCultureAsync();
        }

        protected override void OnInitialized()
        {
            //SelectedCulture = CultureInfo.CurrentCulture;
        }



        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            OnCultureChanged();
            return base.OnAfterRenderAsync(firstRender);
        }

        private async Task ApplySelectedCultureAsync()
        {
            if (CultureInfo.CurrentCulture != selectedCulture)
            {
                var uri = new Uri(Navigation.Uri)
                    .GetComponents(UriComponents.PathAndQuery, UriFormat.Unescaped);
                var cultureEscaped = Uri.EscapeDataString(selectedCulture.Name);
                var uriEscaped = Uri.EscapeDataString(uri);

                Navigation.NavigateTo(
                    $"Culture/Set?culture={cultureEscaped}&redirectUri={uriEscaped}",
                    forceLoad: true);
            }
        }
    }
}
