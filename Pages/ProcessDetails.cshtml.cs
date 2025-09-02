using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Quake6.Pages
{
    public class ProcessDetailsModel : PageModel
    {
        public void OnGet(int id)
        {
            Process? process = Process.GetProcessById(id);
            if (process != null)
            {
                ViewData["ProcessInfo"] = process;
            }
        }
    }
}
