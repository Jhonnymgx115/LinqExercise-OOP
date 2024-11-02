//!--------------------------------------------Recursividad--------------------------------------------

/*

Realizado por: Jorge Barreto
Fecha de creación: 1/11/2024
ID: 000484006
OOP

*/
/*
1- Crea una función "Potencia" que reciba dos parámetros: número y potencia.
El resultado debe ser el número elevado a esa potencia. Por ejemplo: Potencia(2,3) = 8   porque 2*2*2 = 8
Deben usar recursividad.
Solo se puede usar multiplicación simple.
*/

using System;

class Potencia
{
    static void Main()
    {
        Console.WriteLine(Potencia(2, 3));
    }

    static int Potencia(int numero, int potencia)
    {
        if (potencia == 0)
        {
            return 1;
        }
        return numero * Potencia(numero, potencia - 1);
    }
}



/*
2- Crea una función factorial.
Dado un número, calcular su factorial. (😅)
El factorial de un número se representa con un !
Por lo tanto, el factorial de n sería n!
n! = n * (n-1) * (n-2) * ... * 1
3! = 3 * 2 * 1 => 6 
*/

class FuncionFactorial
{
    static void Main()
    {
        Console.WriteLine(Factorial(3));
    }

    static int Factorial(int numero)
    {
        if (numero == 0)
        {
            return 1;
        }
        return numero * Factorial(numero - 1);
    }
}

/*
3- Crea una función que reverse un texto: Reverse("hola") = aloh
No se debe alterar el texto inicial, sino retornar uno nuevo.
Se debe usar recursividad. 
Apóyense del método Substring.
Tip: Agarrar el primer caracter del texto y sumarlo al final de los caracteres restantes:
Hola -> ola + h. (primer paso)
*/
class Reverso_creo

{
    static void Main()
    {
        Console.WriteLine(Reverse("hola"));
    }

    static string Reverse(string texto)
    {
        if (texto.Length == 0)
        {
            return "";
        }
        return texto.Substring(texto.Length - 1) + Reverse(texto.Substring(0, texto.Length - 1));
    }
}

/*
4- Crea una función que valide si una palabra es o no un palíndromo.
Un palíndromo es una palabra que se escribe igual al derecho y al revés.
ana
arenera
acurruca
reconocer

La función debe retornar true o false dependiendo de si la palabra es o no un palíndromo.
*/

class paliondromo
{
    static void Main()
    {
        Console.WriteLine(EsPalindromo("arenera"));
    }

    static bool EsPalindromo(string palabra)
    {
        if (palabra.Length <= 1)
        {
            return true;
        }
        if (palabra[0] != palabra[palabra.Length - 1])
        {
            return false;
        }
        return EsPalindromo(palabra.Substring(1, palabra.Length - 2));
    }
}

/*
5- Crea una función que encuentre el número más grande de una lista de números.
Necesito iterar sobre la lista y estar comparando la posición actual con la siguiente.
Además, debo tener una variable que esté almacenando el valor mayor de cada comparación.
Se necesitan: La lista de números, el valor máximo actual y el índice.

Se crearán dos funciones:
- Una se llama solo con la lista de números y es encargada de invocar a la función que realiza la iteración
- La otra se encarga de la comparación de valores y de iterar sobre ella misma.

Reto: Creen la primera función como una variable de tipo función.
*/


using System.Collections.Generic; // Se me olvidó agregar esta libreria.


class El_nUmero_grde 
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 5, 8, 10, 12 };
        
        
        Func<List<int>, int> encontrarMayor = (lista) => {
            return NumeroMasGrande(lista, lista[0], 0);
        };
        
        Console.WriteLine(encontrarMayor(numeros));
    }

    static int NumeroMasGrande(List<int> numeros, int valorMaximo, int indice)
    {
        //Aqui tuve multiples problemas al momento de hacer la recursividad y casi que no lo hago
        if (indice == numeros.Count - 1)
        {
            return valorMaximo;
        }
        
        
        if (numeros[indice + 1] > valorMaximo)
        {
            valorMaximo = numeros[indice + 1];
        }
        
        return NumeroMasGrande(numeros, valorMaximo, indice + 1);
    }
}


//!--------------------------------------------Funciones de primera clase--------------------------------------------

/*
6- Crea una función, factory, que toma un número como parámetro y retorna otra función.

La función retornada debe tomar una lista de números como parámetro, y retornar una lista con esos números multiplicados por el numero que se le dió a la primera función.

Aquí usaremos linq. Select.
*/


using System.Linq; //Se agrega esta libreria, tambien se me habia olvidado 

class Funcion 
{
    static void Main() 
    {
        
        Func<int, Func<List<int>, List<int>>> factory = numero => 
            numeros => numeros.Select(n => n * numero).ToList();

        
        Func<List<int>, List<int>> multiplicarPor2 = factory(10);

        
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

        
        List<int> resultado = multiplicarPor2(numeros);

        
        Console.WriteLine(string.Join(", ", resultado));
    }
}