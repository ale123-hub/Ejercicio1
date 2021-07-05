using System;
using DependecyInjection3.DTO;

namespace DependecyInjection3
{
    class CreditCard:IPay
    {
        public string Pay(Sale _data)
        {
            return $"Pago con la tarjeta {_data.CardNumero} exitoso, monto {_data.Anount}";
        }
    }
}