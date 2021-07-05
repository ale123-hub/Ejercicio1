using System;
using DependecyInjection3.DTO;

namespace DependecyInjection3
{
    public class ManagePay
    {
        IPay _Pay;
        public ManagePay(IPay Pay)
        {
            _Pay = Pay;
        }

        public string MakePay(Sale _data)
        {
            return _Pay.Pay(_data);
        }
    }
}