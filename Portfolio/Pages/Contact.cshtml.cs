using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Pages
{
    public class ContactFormModel
    {
        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }

    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactFormModel ContactForm { get; set; }

        public string FeedbackMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                FeedbackMessage = "Formul�ret �r inte korrekt ifyllt.";
                return Page();
            }

            // H�r kan du skicka e-post, spara till databas, etc.
            FeedbackMessage = "Tack f�r ditt meddelande!";
            ModelState.Clear();
            return Page();
        }
    }

}
