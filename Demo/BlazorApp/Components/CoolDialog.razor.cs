using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components
{
    public class CoolDialogBase: ComponentBase
    {
        protected bool Open { set; get; }

        public void OnClose()
        {
            Open = false;

            StateHasChanged();
        }

        public void OnOpen()
        {
            Open = true;

            StateHasChanged();
        }
    }
}
