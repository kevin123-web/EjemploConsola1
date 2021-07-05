using System;
using DependecyInjection2.DTO;

namespace DependecyInjection2
{
    public class CreditoTarjeta:IPago
    {
        public string Pagar(Venta _data)
        {
            return $"Pago con tarjeta {_data.NumeroTarjeta} exitoso, monto{_data.Monto}";
        }
    }
}
