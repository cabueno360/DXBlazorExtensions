using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXBlazorExtensions.Grid
{
    public partial class GridLoader
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool IsLoading { get; set; }

        [Parameter]
        public object Data { get; set; }

        [Parameter]
        public int PageSize { get; set; } = 10;


        [Parameter]
        public bool IsXSmallScreen { get; set; }

        bool IsVisibleSmallScreen(bool isVisibleSmallScren) =>
            isVisibleSmallScren
                ? true
                : !IsXSmallScreen;
    }
}
