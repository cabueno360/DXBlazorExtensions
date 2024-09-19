using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXBlazorExtensions.Grid.Columns
{
    public partial class ColumnText
    {
        [Parameter]
        public string FieldName { get; set; }

        [Parameter]
        public string Caption { get; set; }

        [Parameter]
        public int MinWidth { get; set; }

        [Parameter]
        public bool VisibleSmallScreen { get; set; } = true;

        [CascadingParameter]
        public Func<bool, bool> IsVisibleSmallScreen { get; set; }

    }
}
