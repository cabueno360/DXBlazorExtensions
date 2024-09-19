using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXBlazorExtensions.Validation
{
    public partial class ValidationCard
    {
        [Parameter]
        public List<string> Messages { get; set; }

        [Parameter]
        public bool IsValid { get; set; } = true;

        [Parameter]
        public string AriaLable { get; set; } 


    }
}
