// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var radio = 0d;
var resultado = 0d;

Console.WriteLine("Calculemos un Circulo!  ");
// pi * radio * radio

Console.WriteLine("Ingrse el valor de radio Circulo!  ");

radio = Convert.ToDouble(Console.ReadLine());

resultado = Math.PI * radio * radio;

Console.WriteLine("El area del circulo es: " + resultado + " m2 ");

