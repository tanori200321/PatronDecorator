using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator
{
    public class LecheDecorator : ICafe
    {
        private ICafe _cafe;

        public LecheDecorator(ICafe cafe)
        {
            _cafe = cafe;
        }

        public string ObtenerDescripcion()
        {
            return _cafe.ObtenerDescripcion() + ", con leche";
        }

        public double ObtenerCosto()
        {
            return _cafe.ObtenerCosto() + 0.5;
        }
    }
}
