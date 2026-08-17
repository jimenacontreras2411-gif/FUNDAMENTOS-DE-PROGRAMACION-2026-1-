// See https://aka.ms/new-console-template for more information

Console.Write("Hello,");
Console.Write(" ");
Console.Write("Mena!");

Console.Write("\n\n\n");
//Generar un programa que muestre atributos en forma de tabla
Console.WriteLine("Estadisticas en forma de tabla");
Console.WriteLine("/ Greg  \"El mago\" /");
Console.WriteLine("\\------------------\\");
Console.WriteLine("/ Hp\tt100       /");
Console.WriteLine("/    MP\tt50        \\");

Console.Write("\n\n\n");

//Ejercicio 2: modificar tabla
Console.WriteLine("Ejercicio 2: modificar tabla");
Console.WriteLine("/ Greg   \"El mago\" \t\t/");
Console.WriteLine("\\------------------------------\\");
Console.WriteLine("/ HP\t100\t\t\t/");
Console.WriteLine("/ MP\t50\t\t\t\\");
Console.WriteLine("/ GOLD\t1799\t\t\t\\");
Console.WriteLine("/ EXP\t268\t\t\t\\");

Console.Write("\n\n\n");
// Bandera de México en texto

Console.WriteLine("Bandera de México en texto");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("ME");
Console.ForegroundColor = ConsoleColor.White;
Console.Write("XI");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("CO");

Console.ResetColor();
Console.WriteLine();

// Bandera de México en Fondo
Console.WriteLine("Bandera de México en texto");

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Black;
Console.Write("ME");
Console.BackgroundColor = ConsoleColor.White;
Console.Write("XI");
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.Write("CO");

Console.ResetColor();







