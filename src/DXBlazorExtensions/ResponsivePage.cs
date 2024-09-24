using Microsoft.AspNetCore.Components;

namespace DXBlazorExtensions
{

    public class ResponsivePage : ComponentBase
    {
        public bool IsXSmallScreen { get; set; }

        public bool IsLoading { get; set; } = true;

        public bool IsVisibleSmallScreen(bool isVisibleSmallScren = true) =>
            isVisibleSmallScren
               ? true
               : !IsXSmallScreen;
    }
}

