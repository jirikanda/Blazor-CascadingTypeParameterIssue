using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [CascadingTypeParameter(nameof(TItem))]
    public class HxGrid<TItem> : ComponentBase
    {
        [Parameter] public RenderFragment Columns { get; set; }
    }
}
