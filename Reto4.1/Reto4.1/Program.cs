using System;

namespace Reto4._1
{
    class Program
    {
        class MisMetodos
        {
            public float division(float a, float b)
            {
                float operacion = a / b;
                return operacion;
            }
        }
            static void Main(string[] args)
        {
            MisMetodos metodo = new MisMetodos();
            float imprimir = metodo.division(10, 2);
            Console.WriteLine(imprimir);
        }
    }
}
