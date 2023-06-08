using Tareas;
List<Tarea> pendientes= new List<Tarea>();
List<Tarea> realizadas= new List<Tarea>();
int n, x, y;
char respuesta;
var random= new Random(Environment.TickCount);

Console.WriteLine("ingrese la cantidad de tarea");
int.TryParse(Console.ReadLine(),out n);

for (int i = 0; i < n; i++)
{
    x=random.Next(0, 3);
    y=random.Next(10, 100);
    pendientes.Add(new Tarea(i+1,x,y));
}
Console.WriteLine("listemos las tareas y veamos si se realizaron o no");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(pendientes[i].TareaID);
    Console.WriteLine(pendientes[i].Descripcion);
    Console.WriteLine(pendientes[i].Duracion);
    var item=pendientes[i];
    Console.WriteLine("esta tarea se realizo? (Y/N)");
    char.TryParse(Console.ReadLine(), out respuesta);
    if (respuesta=='Y' || respuesta=='y')
    {
        pendientes.Remove(item);
        realizadas.Add(item);
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