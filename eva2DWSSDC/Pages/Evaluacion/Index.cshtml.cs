using DAL.dbFirst;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eva2DWSSDC.Pages.Evaluacion
{
    public class IndexModel : PageModel
    {
        private readonly DAL.dbFirst.bd_evaluacionContext _context;

        public CreateModel(DAL.dbFirst.bd_evaluacionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EvaCatEvaluacion EvaCatEvaluacion { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EvaCatEvaluacion.Add(TEvaCatEvaluacion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
