/*
Realizado por: Jorge Barreto
Fecha de creación: 1/11/2024
ID: 000484006

*/
//Este taller se soluciona de modo Tradicional sin Linq
// Ejercicio 1: Filtrar números pares
// Dada una lista de enteros, obtener solo los números pares.
// Ejemplo: List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
// Resultado esperado: {2, 4, 6}

using System;

class fIltracion
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6 };
        int[] pares = FiltrarPares(numeros);
        foreach (int numero in pares)
        {
            Console.WriteLine(numero);
        }
    }

    static int[] FiltrarPares(int[] numeros)
    {
        int cantidadPares = ContarPares(numeros);
        int[] pares = new int[cantidadPares];
        int indicePares = 0;
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                pares[indicePares] = numero;
                indicePares++;
            }
        }
        return pares;
    }

    static int ContarPares(int[] numeros)
    {
        int cantidadPares = 0;
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                cantidadPares++;
            }
        }
        return cantidadPares;
    }
}


// Ejercicio 2: Obtener palabras que empiecen con una letra específica
// Dada una lista de palabras, obtener las palabras que comiencen con una letra en específico.
// Ejemplo: List<string> palabras = new List<string> { "apple", "banana", "cherry", "avocado" };
// Resultado esperado para la letra 'a': { "apple", "avocado" }

class palabras_sabias
{
    static void Main()
    {
        string[] palabras = { "apple", "banana", "cherry", "avocado" };
        string letra = "a";
        string[] palabrasConLetra = FiltrarPalabrasConLetra(palabras, letra);
        foreach (string palabra in palabrasConLetra)
        {
            Console.WriteLine(palabra);
        }
    }

    static string[] FiltrarPalabrasConLetra(string[] palabras, string letra)
    {
        int cantidadPalabrasConLetra = ContarPalabrasConLetra(palabras, letra);
        string[] palabrasConLetra = new string[cantidadPalabrasConLetra];
        int indicePalabrasConLetra = 0;
        foreach (string palabra in palabras)
        {
            if (palabra.StartsWith(letra))
            {
                palabrasConLetra[indicePalabrasConLetra] = palabra;
                indicePalabrasConLetra++;
            }
        }
        return palabrasConLetra;
    }

    static int ContarPalabrasConLetra(string[] palabras, string letra)
    {
        int cantidadPalabrasConLetra = 0;
        foreach (string palabra in palabras)
        {
            if (palabra.StartsWith(letra))
            {
                cantidadPalabrasConLetra++;
            }
        }
        return cantidadPalabrasConLetra;
    }
}

// Ejercicio 3: Calcular el promedio de una lista de números
// Dada una lista de números, calcular el promedio.
// Ejemplo: List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
// Resultado esperado: 3

class promedio
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        double promedio = CalcularPromedio(numeros);
        Console.WriteLine(promedio);
    }

    static double CalcularPromedio(int[] numeros)
    {
        int suma = 0;
        foreach (int numero in numeros)
        {
            suma += numero;
        }
        return (double)suma / numeros.Length;
    }
}

// Ejercicio 4: Agrupar palabras por longitud
// Dada una lista de palabras, agruparlas por la cantidad de letras que tienen.
// Ejemplo: List<string> palabras = new List<string> { "apple", "banana", "car", "dog" };
// Resultado esperado: { 3: ["car", "dog"], 5: ["apple"], 6: ["banana"] }

using System.Collections.Generic;
class agrupaciOn
{
    static void Main()
    {
        string[] palabras = { "apple", "banana", "car", "dog" };
        Dictionary<int, List<string>> agrupacion = AgruparPorLongitud(palabras);
        foreach (KeyValuePair<int, List<string>> grupo in agrupacion)
        {
            Console.WriteLine($"{grupo.Key}: {string.Join(", ", grupo.Value)}");
        }
    }

    static Dictionary<int, List<string>> AgruparPorLongitud(string[] palabras)
    {
        Dictionary<int, List<string>> agrupacion = new Dictionary<int, List<string>>();
        foreach (string palabra in palabras)
        {
            int longitud = palabra.Length;
            if (!agrupacion.ContainsKey(longitud))
            {
                agrupacion[longitud] = new List<string>();
            }
            agrupacion[longitud].Add(palabra);
        }
        return agrupacion;
    }
}

// Ejercicio 5: Seleccionar propiedades de una lista de objetos
// Dada una lista de objetos Empleado con propiedades Nombre y Salario, obtener solo el nombre de los empleados con salario superior a un valor dado.
// Ejemplo: List<Empleado> empleados = new List<Empleado> { new Empleado("Ana", 5000), new Empleado("Luis", 7000) };
// Resultado esperado para salario mayor a 6000: { "Luis" }

using System.Collections.Generic;
using System;


class empleado
{
    public string Nombre { get; set; }
    public int Salario { get; set; }
    public Empleado(string nombre, int salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
}

class programa
{
    static void Main()
    {
        
        List<Empleado> empleados = new List<Empleado> { 
            new Empleado("Ana", 5000), 
            new Empleado("Luis", 7000) 
        };

       
        int salarioMinimo = 6000;

        
        List<string> nombresEmpleados = new List<string>();

        
        foreach (Empleado emp in empleados)
        {
            if (emp.Salario > salarioMinimo)
            {
                nombresEmpleados.Add(emp.Nombre);
            }
        }

        
        Console.WriteLine("Empleados con salario mayor a " + salarioMinimo + ":");
        Console.WriteLine(string.Join(", ", nombresEmpleados));
    }
}

// Ejercicio 6: Ordenar productos por precio descendente
// Dada una lista de productos con Nombre y Precio, ordenarlos en orden descendente por precio.
// Ejemplo: List<Producto> productos = new List<Producto> { new Producto("Laptop", 1000), new Producto("Phone", 600) };
// Resultado esperado: { ("Laptop", 1000), ("Phone", 600) }

class Producto
{
    public string Nombre { get; set; }
    public int Precio { get; set; }
    
    public Producto(string nombre, int precio)  
    {
        Nombre = nombre;
        Precio = precio;
    }
}

class Programa
{
    static void Main()
    {
        List<Producto> productos = new List<Producto> { 
            new Producto("Laptop", 1000), 
            new Producto("Phone", 600) 
        };

        // Ordenar productos por precio descendente
        productos.Sort((p1, p2) => p2.Precio.CompareTo(p1.Precio));

        
        foreach (Producto producto in productos)
        {
            Console.WriteLine($"({producto.Nombre}, {producto.Precio})");
        }
    }
}


// Ejercicio 7: Contar elementos que cumplen una condición
// Dada una lista de números, contar cuántos de ellos son mayores que un valor específico.
// Ejemplo: List<int> numeros = new List<int> { 1, 5, 8, 10, 12 };
// Resultado esperado para mayor a 7: 3


class Contar_elementos
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 5, 8, 10, 12 };
        int valor = 7;
        int cantidad = ContarMayoresQue(numeros, valor);
        Console.WriteLine(cantidad);
    }

    static int ContarMayoresQue(List<int> numeros, int valor)
    {
        int cantidad = 0;
        foreach (int numero in numeros)
        {
            if (numero > valor)
            {
                cantidad++;
            }
        }
        return cantidad;
    }
}


// Ejercicio 8: Obtener el nombre del estudiante con la nota más alta
// Dada una lista de estudiantes con Nombre y Nota, encontrar el nombre del estudiante con la nota más alta.
// Ejemplo: List<Estudiante> estudiantes = new List<Estudiante> { new Estudiante("Juan", 75), new Estudiante("Ana", 95) };
// Resultado esperado: "Ana"

class Estudiante
{
    public string Nombre { get; set; }
    public int Nota { get; set; }
    
    public Estudiante(string nombre, int nota)
    {
        Nombre = nombre;
        Nota = nota;
    }
}

class Programa
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante> { 
            new Estudiante("Juan", 75), 
            new Estudiante("Ana", 95) 
        };

        string nombreMejorEstudiante = ObtenerMejorEstudiante(estudiantes);
        Console.WriteLine(nombreMejorEstudiante);
    }

    static string ObtenerMejorEstudiante(List<Estudiante> estudiantes)
    {
        string nombreMejorEstudiante = "";
        int notaMaxima = 0;
        foreach (Estudiante estudiante in estudiantes)
        {
            if (estudiante.Nota > notaMaxima)
            {
                nombreMejorEstudiante = estudiante.Nombre;
                notaMaxima = estudiante.Nota;
            }
        }
        return nombreMejorEstudiante;
    }
}

// Ejercicio 9: Sumar los precios de todos los productos
// Dada una lista de productos con Nombre y Precio, sumar el precio de todos los productos.
// Ejemplo: List<Producto> productos = new List<Producto> { new Producto("Laptop", 1000), new Producto("Phone", 600) };
// Resultado esperado: 1600


class Producto
{
    public string Nombre { get; set; }
    public int Precio { get; set; }
    
    public Producto(string nombre, int precio)  
    {
        Nombre = nombre;
        Precio = precio;
    }
}

class Programa
{
    static void Main()
    {
        List<Producto> productos = new List<Producto> { 
            new Producto("Laptop", 1000), 
            new Producto("Phone", 600) 
        };

        int total = SumarPrecios(productos);
        Console.WriteLine(total);
    }

    static int SumarPrecios(List<Producto> productos)
    {
        int total = 0;
        foreach (Producto producto in productos)
        {
            total += producto.Precio;
        }
        return total;
    }
}


// Ejercicio 10: Generar una lista de cuadrados de números
// Dada una lista de números, generar una nueva lista con los cuadrados de cada número.
// Ejemplo: List<int> numeros = new List<int> { 2, 3, 4 };
// Resultado esperado: {4, 9, 16}


class Programa
{
    static void Main()
    {
        List<int> numeros = new List<int> { 2, 3, 4 };
        List<int> cuadrados = GenerarCuadrados(numeros);
        foreach (int cuadrado in cuadrados)
        {
            Console.WriteLine(cuadrado);
        }
    }

    static List<int> GenerarCuadrados(List<int> numeros)
    {
        List<int> cuadrados = new List<int>();
        foreach (int numero in numeros)
        {
            cuadrados.Add(numero * numero);
        }
        return cuadrados;
    }
}
