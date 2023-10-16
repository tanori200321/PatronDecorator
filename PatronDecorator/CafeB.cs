using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator
{
    public class CafeBa : ICafe
    {
        public string ObtenerDescripcion()
        {
            return "Café básico";
        }

        public double ObtenerCosto()
        {
            return 2.0;
        }
    }
}
