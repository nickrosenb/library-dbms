﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using library_dbms.Models;

namespace library_dbms.Pages.LtsStaffs
{
    public class CreateModel : PageModel
    {
        private readonly library_dbms.Models.InventoryContext _context;

        public CreateModel(library_dbms.Models.InventoryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "FirstName");
            return Page();
        }

        [BindProperty]
        public LtsStaff LtsStaff { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.LtsStaff.Add(LtsStaff);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
