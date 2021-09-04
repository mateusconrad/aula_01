using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Calcular área de terreno!");
            Console.WriteLine("-------------------------\n");
            
            Console.WriteLine("Informe a largura do terreno: ");
            int largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o  comprimento do terreno: ");
            int comprimento = Convert.ToInt32(Console.ReadLine());

            calcularArea(largura,comprimento);
        }
                    
        
        static void calcularArea(int largura, int comprimento)
        {
            int area = largura * comprimento;
            
            Console.WriteLine(@$"Área = {area} m² "); 
            
        }
    }
}
