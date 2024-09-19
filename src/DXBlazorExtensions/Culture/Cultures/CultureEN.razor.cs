using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXBlazorExtensions.Culture.Cultures
{
    public partial class CultureEN : ICultureItem
    {
        [Parameter]
        public bool Visible { get; set; } = false;

        [Parameter]
        public string Label { get; set; } = string.Empty;

        [Parameter]
        public string AriaLabel { get; set; } = string.Empty;


        [CascadingParameter]
        public Func<string, Task> SetCultureMethod { get; set; }

    }
}
