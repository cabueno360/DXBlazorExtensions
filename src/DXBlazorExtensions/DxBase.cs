using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXBlazorExtensions
{
    public class DxBase : ComponentBase
    {
        public bool IsXSmallScreen { get; set; }
        public bool IsVisibleSmallScreen(bool isVisibleSmallScren = true) =>
            isVisibleSmallScren
               ? true
               : !IsXSmallScreen;
    }
}
