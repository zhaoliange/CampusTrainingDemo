using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesContacts.Models;
using RazorPagesDemo.Data;

namespace RazorPagesDemo.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly CustomerDbContext _context;
        public IndexModel(CustomerDbContext context)
        {
            _context = context;
        }

        public IList<Customer>? Customers { get; set; }

        public async Task OnGetAsync()
        {
            Customers = await _context.Customer.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var contact = await _context.Customer.FindAsync(id);

            if (contact != null)
            {
                _context.Customer.Remove(contact);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}