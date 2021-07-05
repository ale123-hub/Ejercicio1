using System;
using DependecyInjection3.DTO;

namespace DependecyInjection3
{
    public class PaypalPayment : IPay
    {
        public string Pay(Sale _data)
        {
            return $"Pago con Paypal {_data.CardNumero}, monto {_data.Anount}";
        }
    }
}
