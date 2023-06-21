Console.WriteLine("Ingrese la ruta de la carpeta:");
string carpeta = Console.ReadLine();

string[] archivos = Directory.GetFiles(carpeta); //matriz de los archivos que estan en el path
Console.WriteLine("Listado de archivos:");
foreach (string archivo in archivos) //recorre el arreglo y lo lista
{
    Console.WriteLine(archivo);
}

string archivoCSV = Path.Combine(carpeta, "index.csv");

using (StreamWriter escritor = new StreamWriter(archivoCSV))
{
    escritor.WriteLine("Índice,Nombre,Extensión");

    for (int i = 0; i < archivos.Length; i++)
    {
        string nombreArchivo = Path.GetFileName(archivos[i]);
        string extensionArchivo = Path.GetExtension(archivos[i]);

        escritor.WriteLine($"{i + 1},{nombreArchivo},{extensionArchivo}");
    }
}

Console.WriteLine("Listado de archivos guardado en index.csv");