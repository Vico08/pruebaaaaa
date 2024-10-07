
public class Program
{
    private static void Main(string[] args)
    {
        double num1, num2;
        int opcion;
        double resultado = 0;
        bool continuar = true;

        do
        {
            Console.Write("Ingresar el primer numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("---Seleccione una operacion aritmetica--");
            Console.WriteLine("---1. Sumar                          ---");
            Console.WriteLine("---2. Restar                          --");
            Console.WriteLine("---3. Multiplicar                    ---");
            Console.WriteLine("---4. Dividir                        ---");
            Console.WriteLine("---0. Salir                          ---");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {


                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"Suma: {num1} + {num2} = {resultado}");
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"Resta: {num1} - {num2} = {resultado}");
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"Multiplicacion: {num1} * {num2} = {resultado}");
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Division: {num1} / {num2} = {resultado}");
                    }
                    else
                    {

                        Console.WriteLine("Error: NO se puede dividir por cero");
                    }
                    break;

                case 0;
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
        while (continuar);
    }

}
