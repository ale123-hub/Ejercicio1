using System;
using Unity;

namespace DependecyInjection3
{
    class Program
    {

        static ManagePay managePay;
        static void Main(string[] args)
        {
            Init();
            //ManagePay managePay = new ManagePay(new PaypalPayment());
            Console.WriteLine("Enviando Pago!");
            Console.WriteLine(managePay.MakePay(new DTO.Sale { Anount = 10, CardNumero = "123456789" }));
            //ManagePay managePay = new ManagePay(new CardCreditPayment());
            Console.WriteLine(managePay.MakePay(new DTO.Sale { Anount = 30, CardNumero = "823456789" }));
            Console.ReadKey();
        }
        static void Init()
        {
            var _container = new UnityContainer();
            _container.RegisterType<IPay, CreditCard>();
            managePay = _container.Resolve<ManagePay>();
        }
    }
}
