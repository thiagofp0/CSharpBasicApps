using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNumbers();
        }

        static void GetNumbers(){
            Console.WriteLine("---------------- Calculadora em C# -----------------");
            double [] numbers = new double [2];
            
            Console.WriteLine("Insira um número:");
            numbers[0] = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira outro número:");
            numbers[1] = int.Parse(Console.ReadLine());
            
            ShowOptions();
            int option = int.Parse(Console.ReadLine());
            
            double result = SwitchOption(option, numbers);
            Console.WriteLine("O resultado é: " + result);
            
        }

        static void ShowOptions()
        {
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");
        }

        static double SwitchOption(int option, double [] numbers)
        {
            switch (option)
            {
                case 1:
                    return Soma(numbers[0], numbers[1]);
                case 2:
                    return Subtrai(numbers[0], numbers[1]);
                case 3:
                    return Multiplica(numbers[0], numbers[1]);
                case 4:
                    return Divide(numbers[0], numbers[1]);
            }

            return 0;
        }

        static double Soma(double fristNumber, double secondNumber){
            double result = fristNumber + secondNumber;
            return result;
        }

        static double Subtrai(double fristNumber, double secondNumber){
            double result = fristNumber - secondNumber;
            return result;
        }

        static double Divide(double fristNumber, double secondNumber){
            double result = fristNumber / secondNumber;
            return result;
        }

        static double Multiplica(double fristNumber, double secondNumber){
            double result = fristNumber * secondNumber;
            return result;
        }
    }
}