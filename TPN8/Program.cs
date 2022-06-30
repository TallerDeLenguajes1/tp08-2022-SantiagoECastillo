using System.IO;


Console.WriteLine("Ingrese la ruta del archivo");
string? ruta = @"" + Console.ReadLine();

if(Directory.Exists(ruta)){
    List<string> listaDeArchivos = Directory.GetDirectories(ruta).ToList();

    Console.WriteLine("\n ARCHIVOS:");
    foreach(string archivos in listaDeArchivos){
        Console.WriteLine(archivos);
    }
}else{
    Console.WriteLine("No se encontro el archivo");
}