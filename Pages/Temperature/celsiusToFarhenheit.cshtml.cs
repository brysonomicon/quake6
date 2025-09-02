using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Quake6.Pages.Temperature
{
    public class celsiusToFarhenheitModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            ViewData["Result"] = $"{celsius}°C is {fahrenheit}°F";
            return Page();
        }
    }
}
