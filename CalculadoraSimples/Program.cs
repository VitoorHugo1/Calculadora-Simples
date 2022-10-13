namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("__________________________");
            Console.WriteLine("|       CALCULADORA      |");
            Console.WriteLine("|________________________|");
            Console.WriteLine("|    1 - ADIÇÃO          |");
            Console.WriteLine("|    2 - SUBTRAÇÃO       |");
            Console.WriteLine("|    3 - DIVISÃO         |");
            Console.WriteLine("|    4 - MULTIPLICAÇÃO   |");
            Console.WriteLine("|________________________|");

            Console.Write("OQUE DESEJA REALIZAR ?: ");
            int OpcaoEscolhida = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (OpcaoEscolhida)
            {
                case 1: Adicao(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
            }
        }

        public static void Adicao()
        {
            Console.Clear();
            Console.WriteLine("SOMA");
            Console.WriteLine();
            Console.Write("PRIMEIRO NUMERO:");
            double PrimeiroNumero = double.Parse(Console.ReadLine());
            Console.Write("SEGUNDO NUMERO: ");
            double SegundoNumero = double.Parse(Console.ReadLine());

            double Soma = PrimeiroNumero + SegundoNumero;

            Console.WriteLine($"{PrimeiroNumero} + {SegundoNumero} = {Soma}");

            Saida();

        }

        public static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine();
            Console.Write("PRIMEIRO NUMERO: ");
            double PrimeiroNumero = double.Parse(Console.ReadLine());
            Console.Write("SEGUNDO NUMERO: ");
            double SegundoNumero = double.Parse(Console.ReadLine());

            double Subtracao = PrimeiroNumero - SegundoNumero;

            Console.WriteLine($"{PrimeiroNumero} - {SegundoNumero} = {Subtracao}");

            Saida();

        }

        public static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("DIVISÃO");
            Console.WriteLine();
            Console.Write("PRIMEIRO NUMERO: ");
            double PrimeiroNumero = double.Parse(Console.ReadLine());
            Console.Write("SEGUNDO NUMERO: ");
            double SegundoNumero = double.Parse(Console.ReadLine());

            double Divisao = PrimeiroNumero / SegundoNumero;

            Console.WriteLine($"{PrimeiroNumero} / {SegundoNumero} = {Divisao}");

            Saida();

        }

        public static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine();
            Console.Write("PRIMEIRO NUMERO: ");
            double PrimeiroNumero = double.Parse(Console.ReadLine());
            Console.Write("SEGUNDO NUMERO: ");
            double SegundoNumero = double.Parse(Console.ReadLine());

            double Multiplicacao = PrimeiroNumero * SegundoNumero;

            Console.WriteLine($"{PrimeiroNumero} x {SegundoNumero} = {Multiplicacao}");

            Saida();

        }

        public static void Saida()
        {
            Console.WriteLine(" ____________________________");
            Console.WriteLine("|     OPERAÇÃO FINALIZADA    |");
            Console.WriteLine("|____________________________|");
            Console.WriteLine("|     1  -  SAIR             |");
            Console.WriteLine("|     2  - NOVA OPERAÇÃO     |");
            Console.WriteLine("|____________________________|");

            Console.Write("OQUE DESEJA REALIZAR : ");
            int Finalizar = int.Parse(Console.ReadLine());

            switch (Finalizar)
            {
                case 1: Environment.ExitCode = 0; break;
                case 2: Console.Clear(); Menu(); break;
            }
        }
    }
}
