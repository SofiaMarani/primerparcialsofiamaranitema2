namespace primerparcialsofiamaranitema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora para pirámide Cuadrada");
            

            int contadordepiramides = 0;

            while (true)
            {
             Console.WriteLine("Ingrese el lado de la base (0 valor nulo):");
             double ladoBase = LeerDoublePositivo();

                if (ladoBase == 0)
                break;

                Console.WriteLine("Ingrese la altura:");
                double altura = LeerDoublePositivo();

                double area = CalcularArea(ladoBase, altura);
                double volumen = CalcularVolumen(ladoBase, altura);
                double arista = CalcularArista(ladoBase, altura);

                Console.WriteLine("Área de la pirámide: " + area);
                Console.WriteLine("Volumen de la pirámide: " + volumen);
                Console.WriteLine("Arista de la pirámide: " + arista);
                
                contadordepiramides++;
            }

            Console.WriteLine("Cantidad de pirámides ingresadas: " + contadordepiramides);
        }

        static double CalcularArista(double ladoBase, double altura)
        {
        double arista = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(ladoBase, 2)) / 2;
        return arista;
        }

        static double CalcularArea(double ladoBase, double altura)
        {
        double area = ladoBase * (ladoBase + Math.Sqrt(4 * Math.Pow(altura, 2) + Math.Pow(ladoBase, 2))) / 2;
        return area;
        }

        static double CalcularVolumen(double ladoBase, double altura)
        {
        double volumen = (Math.Pow(ladoBase, 2) * altura) / 3;
        return volumen;
        }

        static double LeerDoublePositivo()
        {
        double valor;
        while (true)
            {
          if (double.TryParse(Console.ReadLine(), out valor) && valor >= 0)
                    break;
                Console.WriteLine("Error: Ingrese un valor numérico positivo válido.");
            }
            return valor;
        }
    }
}