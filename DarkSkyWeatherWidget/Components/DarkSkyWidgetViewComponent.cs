using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DarkSky.Models;
using Microsoft.AspNetCore.Mvc;

namespace DarkSkyWeatherWidget.Components
{
	public class DarkSkyWidgetViewComponent: ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			OptionalParameters param = new OptionalParameters();
			param.LanguageCode = "tr";
			param.MeasurementUnits = "si";
			var darkSky = new DarkSky.Services.DarkSkyService("KEY");
			DarkSkyResponse forecast = await darkSky.GetForecast(40.1766256, 28.7582773, param);
			return View("DarkSkyWidget", forecast);
		}
	}
}
