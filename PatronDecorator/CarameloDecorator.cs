using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator
{
    public class CarameloDecorator : ICafe
    {
        private ICafe _cafe;

        public CarameloDecorator(ICafe cafe)
        {
            _cafe = cafe;
        }

        public string ObtenerDescripcion()
        {
            return _cafe.ObtenerDescripcion() + ", con caramelo";
        }

        public double ObtenerCosto()
        {
            return _cafe.ObtenerCosto() + 1.0;
        }
    }
}
