/*
 * Reto #3
 * ¿ES UN NÚMERO PRIMO?
 * Enunciado: Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */

for (int i = 1; i <= 100; i++)
{
    if (calcularPrimo(i))
    {
        Console.WriteLine($"{i} es Primo");
        continue;
    }

    Console.WriteLine($"{i} no es Primo");
    continue;
}

bool calcularPrimo(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        return false;
    }

    return true;
}
