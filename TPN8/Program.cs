using System.IO;

//Console.WriteLine("Ingrese una direccion: ");
//string ingresoDireccion = Console.ReadLine();

string direccionArchivos = @"C:\Users\santiago\Desktop\Facultad\Taller_de_lenguaje_1\TPN8\tp08-2022-SantiagoECastillo\Archivos_prueba";
DirectoryInfo direccion = new DirectoryInfo(direccionArchivos);
Console.WriteLine("Los archivos del direcctorio ingresados son:");
foreach (var archivo in direccion.GetFiles())
{
    Console.WriteLine(archivo.Name);    
}