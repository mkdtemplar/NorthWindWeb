using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NorthWindWeb.Pages
{
    public class index : PageModel
    {
        public string DayName { get; set; }
        public void OnGet()
        {
            DayName = DateTime.Now.ToString("dddd");
        }
    }
}