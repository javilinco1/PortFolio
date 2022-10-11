/*
 * Reto #2
 * LA SUCESIÓN DE FIBONACCI
 * Enunciado: Escribe un programa que imprima los 50 primeros números de la sucesión de Fibonacci empezando en 0.
 * La serie Fibonacci se compone por una sucesión de números en la que el siguiente siempre es la suma de los dos anteriores.
 * 0, 1, 1, 2, 3, 5, 8, 13...
 */

int num1 = 0;
int num2 = 1;

for (int i = 0; i <= 50; i++)
{
    Console.WriteLine(num1);

    var fib = num1 + num2;
    num1 = num2;
    num2 = fib;
}
