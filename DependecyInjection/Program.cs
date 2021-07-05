using System;
using Unity;

namespace DependecyInjection2
{
    class MainClass
    {
        static Pagos _pagoTarjeta;
        public static void Main(string[] args)
        {
            Init();
            //_pagoTarjeta = new Pagos(new BCNPago());
            Console.WriteLine("Enviando Pago ");
            Console.WriteLine(_pagoTarjeta.HacerPago(new DTO.Venta { Monto = 200, NumeroTarjeta = "172708875748569"}));

            //_pagoTarjeta = new Pagos(new CreditoTarjeta());
            Console.WriteLine(_pagoTarjeta.HacerPago(new DTO.Venta { Monto = 200, NumeroTarjeta = "572708875748469" }));
            Console.ReadKey();
        }
        static void Init()
        {
            var _container = new UnityContainer();
            _container.RegisterType<IPago, CreditoTarjeta>();
            _pagoTarjeta = _container.Resolve<Pagos>();
        }
    }
}
