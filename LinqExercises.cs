/*
Realizado por: Jorge Barreto
Fecha de creación: 1/11/2024
ID: 000484006

*/
//Realizar los siguientes ejercicios utilizando LINQ en C#.
// Ejercicio 1: Filtrar números pares
// Dada una lista de enteros, obtener solo los números pares.
// Ejemplo: List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
// Resultado esperado: {2, 4, 6}
using System;
using System.Collections.Generic;
using System.Linq;

class numero
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
        
        Func<List<int>, List<int>> obtenerPares = lista => lista.Where(n => n % 2 == 0).ToList();
        
        List<int> pares = obtenerPares(numeros);
        
        foreach (int numero in pares)
        {
            Console.WriteLine(numero);
        }
    }
}

// Ejercicio 2: Obtener palabras que empiecen con una letra específica
// Dada una lista de palabras, obtener las palabras que comiencen con una letra en específico.
// Ejemplo: List<string> palabras = new List<string> { "apple", "banana", "cherry", "avocado" };
// Resultado esperado para la letra 'a': { "apple", "avocado" }

class palabra
{
    static void Main()
    {
        List<string> palabras = new List<string> { "apple", "banana", "cherry", "avocado" };
        
        Func<List<string>, char, List<string>> obtenerPalabras = (lista, letra) => lista.Where(p => p.StartsWith(letra.ToString())).ToList();
        
        List<string> palabrasConA = obtenerPalabras(palabras, 'a');
        
        foreach (string palabra in palabrasConA)
        {
            Console.WriteLine(palabra);
        }
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
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
        
        Func<List<int>, double> calcularPromedio = lista => lista.Average();
        
        double promedio = calcularPromedio(numeros);
        
        Console.WriteLine(promedio);
    }
}

// Ejercicio 4: Agrupar palabras por longitud
// Dada una lista de palabras, agruparlas por la cantidad de letras que tienen.
// Ejemplo: List<string> palabras = new List<string> { "apple", "banana", "car", "dog" };
// Resultado esperado: { 3: ["car", "dog"], 5: ["apple"], 6: ["banana"] }

class longitud
{
    static void Main()
    {
        List<string> palabras = new List<string> { "apple", "banana", "car", "dog" };
        
        Func<List<string>, Dictionary<int, List<string>>> agruparPorLongitud = lista => lista.GroupBy(p => p.Length).ToDictionary(g => g.Key, g => g.ToList());
        
        Dictionary<int, List<string>> palabrasAgrupadas = agruparPorLongitud(palabras);
        
        foreach (KeyValuePair<int, List<string>> grupo in palabrasAgrupadas)
        {
            Console.WriteLine($"{grupo.Key}: {string.Join(", ", grupo.Value)}");
        }
    }
}


// Ejercicio 5: Seleccionar propiedades de una lista de objetos
// Dada una lista de objetos Empleado con propiedades Nombre y Salario, obtener solo el nombre de los empleados con salario superior a un valor dado.
// Ejemplo: List<Empleado> empleados = new List<Empleado> { new Empleado("Ana", 5000), new Empleado("Luis", 7000) };
// Resultado esperado para salario mayor a 6000: { "Luis" }

class empleado
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado> { new Empleado("Ana", 5000), new Empleado("Luis", 7000) };
        
        Func<List<Empleado>, double, List<string>> obtenerNombres = (lista, salario) => lista.Where(e => e.Salario > salario).Select(e => e.Nombre).ToList();
        
        List<string> nombres = obtenerNombres(empleados, 6000);
        
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}

class Empleado
{
    public string Nombre { get; set; }
    public double Salario { get; set; }
    
    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
}



// Ejercicio 6: Ordenar productos por precio descendente
// Dada una lista de productos con Nombre y Precio, ordenarlos en orden descendente por precio.
// Ejemplo: List<Producto> productos = new List<Producto> { new Producto("Laptop", 1000), new Producto("Phone", 600) };
// Resultado esperado: { ("Laptop", 1000), ("Phone", 600) }

class producto
{
    static void Main()
    {
        List<Producto> productos = new List<Producto> { new Producto("Laptop", 1000), new Producto("Phone", 600) };
        
        Func<List<Producto>, List<Producto>> ordenarPorPrecio = lista => lista.OrderByDescending(p => p.Precio).ToList();
        
        List<Producto> productosOrdenados = ordenarPorPrecio(productos);
        
        foreach (Producto producto in productosOrdenados)
        {
            Console.WriteLine($"({producto.Nombre}, {producto.Precio})");
        }
    }
}

class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    
    public Producto(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

// Ejercicio 7: Contar elementos que cumplen una condición
// Dada una lista de números, contar cuántos de ellos son mayores que un valor específico.
// Ejemplo: List<int> numeros = new List<int> { 1, 5, 8, 10, 12 };
// Resultado esperado para mayor a 7: 3


class contar
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 5, 8, 10, 12 };
        
        Func<List<int>, int, int> contarMayores = (lista, valor) => lista.Count(n => n > valor);
        
        int cantidad = contarMayores(numeros, 7);
        
        Console.WriteLine(cantidad);
    }
}



// Ejercicio 8: Obtener el nombre del estudiante con la nota más alta
// Dada una lista de estudiantes con Nombre y Nota, encontrar el nombre del estudiante con la nota más alta.
// Ejemplo: List<Estudiante> estudiantes = new List<Estudiante> { new Estudiante("Juan", 75), new Estudiante("Ana", 95) };
// Resultado esperado: "Ana"

class estudiante
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante> { new Estudiante("Juan", 75), new Estudiante("Ana", 95) };
        
        Func<List<Estudiante>, string> encontrarMejorEstudiante = lista => lista.OrderByDescending(e => e.Nota).First().Nombre;
        
        string mejorEstudiante = encontrarMejorEstudiante(estudiantes);
        
        Console.WriteLine(mejorEstudiante);
    }
}
class Estudiante
{
    public string Nombre { get; set; }
    public double Nota { get; set; }
    
    public Estudiante(string nombre, double nota)
    {
        Nombre = nombre;
        Nota = nota;
    }
}

// Ejercicio 9: Sumar los precios de todos los productos
// Dada una lista de productos con Nombre y Precio, sumar el precio de todos los productos.
// Ejemplo: List<Producto> productos = new List<Producto> { new Producto("Laptop", 1000), new Producto("Phone", 600) };
// Resultado esperado: 1600

class sumar
{
    static void Main()
    {
        List<Producto> productos = new List<Producto> { new Producto("Laptop", 1000), new Producto("Phone", 600) };
        
        Func<List<Producto>, double> sumarPrecios = lista => lista.Sum(p => p.Precio);
        
        double total = sumarPrecios(productos);
        
        Console.WriteLine(total);
    }
}
class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    
    public Producto(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

// Ejercicio 10: Generar una lista de cuadrados de números
// Dada una lista de números, generar una nueva lista con los cuadrados de cada número.
// Ejemplo: List<int> numeros = new List<int> { 2, 3, 4 };
// Resultado esperado: {4, 9, 16}

class cuadrado
{
    static void Main()
    {
        List<int> numeros = new List<int> { 2, 3, 4 };
        
        Func<List<int>, List<int>> obtenerCuadrados = lista => lista.Select(n => n * n).ToList();
        
        List<int> cuadrados = obtenerCuadrados(numeros);
        
        foreach (int cuadrado in cuadrados)
        {
            Console.WriteLine(cuadrado);
        }
    }
}

