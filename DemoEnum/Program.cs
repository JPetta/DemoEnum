using System;

namespace DemoEnum
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegistersteredAirMail,
        Express
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method);

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
