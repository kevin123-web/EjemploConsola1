using System;
using DependecyInjection2.DTO;

namespace DependecyInjection2
{
    public class BCNPago:IPago
    {
        public string Pagar(Venta _data)
        {
            return $"Pago con BCN exitoso , cuenta{_data.NumeroTarjeta} monto{_data.Monto}";
        }
    }
}
