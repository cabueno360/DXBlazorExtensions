using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXBlazorExtensions.Culture
{
    public interface ICultureItem
    {

        string Label { get; set; }

        string AriaLabel { get; set; }

        [CascadingParameter]
        public Func<string, Task> SetCultureMethod { get; set; }
    }
}
