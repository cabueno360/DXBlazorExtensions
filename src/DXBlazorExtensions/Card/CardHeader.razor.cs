using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXBlazorExtensions.Card
{
    public partial class CardHeader
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
