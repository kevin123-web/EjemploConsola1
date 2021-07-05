using System;
using DependecyInjection2.DTO;

namespace DependecyInjection2
{
    public class Pagos
    {
        IPago _Pagar;
        public Pagos(IPago Pagar)
        {
            _Pagar = Pagar;
        }

        public string HacerPago(Venta _data)
        {
            return _Pagar.Pagar(_data);
        }
    }
}
