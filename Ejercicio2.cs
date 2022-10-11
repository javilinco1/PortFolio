/*
 * Reto #1
 * ¿ES UN ANAGRAMA?
 * Enunciado: Escribe una función que reciba dos palabras (String) y retorne verdadero (1) o falso (0) (Boolean) según sean o no anagramas.
 * Un Anagrama consiste en formar una palabra reordenando TODAS las letras de otra palabra inicial.
 * NO hace falta comprobar que ambas palabras existan.
 * Dos palabras exactamente iguales no son anagrama.
 */

string[] palabras = {"roma","amor"};
Console.WriteLine(esAnagrama(palabras[0], palabras[1]));
return;

bool esAnagrama(string pal1, string pal2)
{
    var pal1Order = Sort(pal1);
    var pal2Order = Sort(pal2);
    if (pal1Order == pal2Order)
    {
        return true;
    }

    return false;
}

string Sort(string input)
{
    char[] chars = input.ToCharArray();
    Array.Sort(chars);
    return new String(chars);
}
