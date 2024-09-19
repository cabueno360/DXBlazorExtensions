using Microsoft.AspNetCore.Components;

namespace DXBlazorExtensions.Card
{
    public partial class Card
    {
        [Parameter] 
        public RenderFragment ChildContent { get; set; }


        [Parameter]
        public bool IsLoading { get; set; } = false;

    }
}
