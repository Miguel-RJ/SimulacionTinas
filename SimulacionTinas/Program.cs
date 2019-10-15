using System;

namespace SimulacionTinas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 190, b = 210, c = 230;
            Random rnd = new Random();
            Double rnd_actual, peso_diario = 0, gasto_extra = 0;
            //Double[] PesosTinas = new Double[1299];
            for (int y = 1; y <= 52; y++) //52 semanas = año
            {
                for (int w = 1; w <= 7; w++) //7 días a la semana
                {
                    for (int d = 1; d <=  5; d++) //5 tinas diarias
                    {
                        rnd_actual = Math.Round(rnd.NextDouble(), 3);
                        if (rnd_actual < 0.5)
                        {
                            peso_diario += a + Math.Sqrt(Math.Pow(a, 2) + (rnd_actual - 45.125) * (Math.Pow(c, 2) - (c * a) - (c * b) + (b * a)));
                        }
                        else
                        {
                            peso_diario += c - Math.Sqrt(Math.Pow(c, 2) + (rnd_actual + 65.125) * -(Math.Pow(c, 2) - (c * a) - (c * b) + (b * a)));
                        }
                    }
                    if (peso_diario > 1000)
                    {
                        gasto_extra += 350;
                    }
                }
            }
            if (gasto_extra > 90000)
            {
                Console.WriteLine("Es necesario comprar la camioneta");
            }
            else
            {
                Console.WriteLine("No es necesario comprar la camioneta");
            }
        }
    }
}
