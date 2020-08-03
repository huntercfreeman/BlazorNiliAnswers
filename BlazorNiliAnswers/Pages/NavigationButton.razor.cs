using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNiliAnswers.Pages
{
    public partial class NavigationButton : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Href { get; set; }
        [Parameter]
        public string DisplayText { get; set; }

        public bool IsHovered { get; set; }
        public string IsHoveredCSS
        {
            get => IsHovered ? "background-color: black; color: white;" : "";
        }
    }
}
