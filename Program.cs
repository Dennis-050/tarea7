using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Introduce un número entero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++) {
            for (int j = 1; j <= i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}