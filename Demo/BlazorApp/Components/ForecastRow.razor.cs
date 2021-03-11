using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Components
{
    public class ForecastRowBase: ComponentBase
    {
        [Parameter]
        public Dictionary<string, object> InputAttributes { get; set; } =
            new Dictionary<string, object>()
            {
                { "Region", "" },
                { "City", "" },
                { "State", "" },
                { "Day", "" },
                { "Month", "" },
                { "Year", "" }
            };

        [Parameter]
        public WeatherForecast Forecast { get; set; }

        protected WeatherExtras Extras { get; set; }   

        [Inject]
        public WeatherExtrasService ExtrasService { get; set; }

        [Parameter]
        public EventCallback<bool> OnShowHide { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Extras = await ExtrasService.GetExtrasAsync(Forecast);
        }

        public void CheckboxChanged(ChangeEventArgs e)
        {
            var n = (bool)e.Value;
            Forecast.ShowExtras = n;
        }

        public void CheckboxClicked()
        {
            OnShowHide.InvokeAsync(Forecast.ShowExtras);
        }

        protected override Task OnParametersSetAsync()
        {
            return base.OnParametersSetAsync();
        }

        public override Task SetParametersAsync(ParameterView parameters)
        {
            return base.SetParametersAsync(parameters);
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            return base.OnAfterRenderAsync(firstRender);
        }

        protected override bool ShouldRender()
        {
            return base.ShouldRender();
        }
    }
}
