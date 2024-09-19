using DevExpress.Blazor;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DXBlazorExtensions.Localization;

namespace DXBlazorExtensions.Grid
{
    public static class DxGridExt
    {

        public static string GetEmptyMessage(this IGrid grid, IStringLocalizer<CultureLibrary> localization)
        {
            var hasFilter = !object.ReferenceEquals(grid.GetFilterCriteria(), null) || !string.IsNullOrEmpty(grid.SearchText);
            var waitingForData = !grid.WaitForDataLoadAsync().IsCompleted;

            if (grid.Data == null) // Checks whether the Grid contains data
                return localization[TanslationLibraryKeys.GridConfigure];
            if (waitingForData) // Checks whether data is loading
                return localization[TanslationLibraryKeys.LoadingData];
            if ((grid.Data as IEnumerable<object>).Count() == 0)
                return localization[TanslationLibraryKeys.EmptyDataSource];
            if (hasFilter) // Checks whether all items are hidden by the filter
                return localization[TanslationLibraryKeys.SearchNoMatch];

            return localization[TanslationLibraryKeys.NoDataToDisplay];
        }
    }
}
