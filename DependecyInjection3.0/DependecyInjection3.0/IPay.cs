using System;
using DependecyInjection3.DTO;

namespace DependecyInjection3
{
    public interface IPay
    {
        string Pay(Sale _data);
    }
}