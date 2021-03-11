using Microsoft.AspNetCore.Components;
using Skclusive.Core.Component;

namespace BlazorApp.Components
{
    public class TestButtonBase: ComponentBase
    {
        protected string
            TxtValue { get; set; } = "Using TestButtonBase :)";

        protected Color 
            ColorValue { get; set; } = Color.Primary;

        protected void TestButtonClick()
        {
            ColorValue = (ColorValue == Color.Primary) 
                ? Color.Secondary : Color.Primary;
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
