using Autenticacion.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autenticacion.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() 
        {
          Console.WriteLine("User: " + User.Email + "Password: " + User.Password);
        }
    }

}
