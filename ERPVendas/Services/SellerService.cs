using ERPVendas.Data;
using ERPVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPVendas.Services
{
    public class SellerService
    {
        private readonly ERPVendasContext _context;

        public SellerService(ERPVendasContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
