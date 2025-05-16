using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;

namespace Portfolio.Pages;

public class ContactModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public ContactModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public ContactFormViewModel Form { get; set; }

    public void OnGet() { }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
            return Page();

        var message = new DAL.Models.ContactMessage
        {
            Name = Form.Name,
            Email = Form.Email,
            Message = Form.Message
        };

        _context.ContactMessages.Add(message);
        await _context.SaveChangesAsync();

        TempData["Feedback"] = "Thank you for the message!";
        return Redirect("/Index#kontakt");
    }
}
