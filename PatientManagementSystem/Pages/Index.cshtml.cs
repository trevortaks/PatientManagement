using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using Persistence;

namespace PatientManagementSystem.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PatientManagementContext _context;

        public IndexModel(PatientManagementContext context)
        {
            _context = context;
        }

        public IList<Patient> Patient { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Patient != null)
            {
                Patient = await _context.Patient.ToListAsync();
            }
        }
    }
}
