using ERPVendas.Data;
using ERPVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ERPVendas.Services
{
    public class DepartmentService
    {
        private readonly ERPVendasContext _context; 

        public DepartmentService(ERPVendasContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
