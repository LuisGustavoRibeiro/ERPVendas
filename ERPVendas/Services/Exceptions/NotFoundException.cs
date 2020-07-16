using System;

namespace ERPVendas.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base (message)
        {

        }
    }
}
