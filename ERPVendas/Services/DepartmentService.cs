using ERPVendas.Data;
using ERPVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPVendas.Services
{
    public class DepartmentService
    {
        private readonly ERPVendasContext _context; 

        public DepartmentService(ERPVendasContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
