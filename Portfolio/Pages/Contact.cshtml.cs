using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages;

public class ContactModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public ContactModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty] public string Name { get; set; } = string.Empty;
    [BindProperty] public string Email { get; set; } = string.Empty;
    [BindProperty] public string Message { get; set; } = string.Empty;

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
            return Page();

        var contact = new ContactMessage
        {
            Name = Name,
            Email = Email,
            Message = Message,
            SentAt = DateTime.Now
        };

        _context.ContactMessages.Add(contact);
        await _context.SaveChangesAsync();

        TempData["Feedback"] = "Tack! Ditt meddelande har skickats.";
        return RedirectToPage();
    }
}
