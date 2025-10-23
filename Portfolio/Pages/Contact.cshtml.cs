using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


public class ContactModel : PageModel
{
    [BindProperty] public string Name { get; set; } = string.Empty;
    [BindProperty] public string Email { get; set; } = string.Empty;
    [BindProperty] public string Message { get; set; } = string.Empty;


    public IActionResult OnPost()
    {
        // TODO: spara/skicka mail etc.
        return Page();
    }
}