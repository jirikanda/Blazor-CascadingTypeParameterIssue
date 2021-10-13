using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class HxColumn<TItem> : ComponentBase
    {
        [Parameter] public RenderFragment<HeaderContext> HeaderTemplate { get; set; }
    }
}
