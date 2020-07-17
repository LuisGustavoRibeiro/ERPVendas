using System;

namespace ERPVendas.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base (message)
        {

        }
    }
}
