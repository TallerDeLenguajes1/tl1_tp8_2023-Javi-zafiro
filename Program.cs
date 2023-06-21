using Tareas;
string? buscar;
Tarea encontrada=null;
List<Tarea> pendientes= new List<Tarea>();
List<Tarea> realizadas= new List<Tarea>();
int n, x, y, i;
char respuesta;
var random= new Random(Environment.TickCount);

Console.WriteLine("ingrese la cantidad de tarea");
int.TryParse(Console.ReadLine(),out n);

for ( i = 0; i < n; i++)
{
    x=random.Next(0, 3);
    y=random.Next(10, 100);
    pendientes.Add(new Tarea(i+1,x,y));
}
Console.WriteLine("listemos las tareas y veamos si se realizaron o no");
i = 0;
while (i < pendientes.Count)
{
    Console.WriteLine(pendientes[i].TareaID);
    Console.WriteLine(pendientes[i].Descripcion);
    Console.WriteLine(pendientes[i].Duracion);
    var item = pendientes[i];
    Console.WriteLine("¿Esta tarea se realizó? (Y/N)");
    char.TryParse(Console.ReadLine(), out respuesta);
    if (respuesta == 'Y' || respuesta == 'y')
    {
        pendientes.Remove(item);
        realizadas.Add(item);
    }
    else
    {
        i++; 
    }
}

Console.WriteLine("lista de pendientes");
foreach (var item in pendientes)
{
    Console.WriteLine(item.TareaID);
    Console.WriteLine(item.Descripcion);
    Console.WriteLine(item.Duracion);
}

Console.WriteLine("lista de realizadas");
foreach (var item in realizadas)
{
    Console.WriteLine(item.TareaID);
    Console.WriteLine(item.Descripcion);
    Console.WriteLine(item.Duracion);
}

 Console.WriteLine("Ingrese una descripción para buscar tareas pendientes:");
buscar = Console.ReadLine();
foreach (var item in pendientes)
{
    string descripcion=item.Descripcion;
    if (buscar == descripcion)
    {
        encontrada= item;
    }
}
if (encontrada!=null)
{
    Console.WriteLine("se encontro la tarea");
    Console.WriteLine(encontrada.TareaID);
    Console.WriteLine(encontrada.Descripcion);
    Console.WriteLine(encontrada.Duracion);
}else
{
    Console.WriteLine("no se encontro la tarea");
}
int sumatoria=0;
foreach (var item in realizadas)
{
    sumatoria=+item.Duracion;
}
using (StreamWriter sw= new StreamWriter("sumatoria.txt"))
{
    sw.WriteLine(sumatoria);
}