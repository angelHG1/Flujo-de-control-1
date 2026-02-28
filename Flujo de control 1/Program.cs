using static System.Net.Mime.MediaTypeNames;

namespace Flujo_de_control_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario_B;
            Console.Write("Ingrese el salario del empleado: ");
            salario_B = double.Parse(Console.ReadLine());
            var isr = impuesto(salario_B);

            if (isr == 0)
            { 
                Console.WriteLine($"El ISR para el salario de {salario_B}$ es: N/A");
                return;
            }
            Console.WriteLine($"El ISR para el salario de {salario_B}$ es: {isr}$");

        }

        static double impuesto(double salario)
        {
            if (salario < 34685)
            { return 0; }
            else if (salario > 34685.01 && salario <= 52027.42)
            {
                return (salario - 34685) * 0.15;
            }

            else if (salario > 52027.42 && salario <= 72260.25)
            {
                return (salario - 52027.43) * 0.2 + 2601.33;
            }

            else
            {
                return (salario - 72260.26) * 0.25 + 6648.00;
            }   
        }
    }
}