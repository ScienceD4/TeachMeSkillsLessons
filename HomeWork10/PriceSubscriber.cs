using HomeWork10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10;
internal class PriceSubscriber : Subscriber
{
    public void Update(Data data)
    {
        if (data.IsLowPrice)
        {
            Console.WriteLine($"Low Price from PriceSubscriber: {data.Price:### ###.## RUB}");
        }
        else
        {
            //Console.WriteLine($"Price from PriceSubscriber: {data.Price:0.00}");
        }
    }
}
