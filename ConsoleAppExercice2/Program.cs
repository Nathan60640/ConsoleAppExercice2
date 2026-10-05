namespace ConsoleAppExercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un nombre entier positif ou nul : ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("La factorielle n'est pas définie pour un nombre négatif.");
                return;
            }

            long factorielle = 1;

            for (int i = 2; i <= n; i++)
            {
                factorielle *= i;
            }

            Console.WriteLine($"{n} = {factorielle}");
        }
    }
}
