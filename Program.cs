using Tareas;
List<Tarea> miLista= new List<Tarea>();
int n, x, y;
var random= new Random(Environment.TickCount);

Console.WriteLine("ingrese la cantidad de tarea");
int.TryParse(Console.ReadLine(),out n);

for (int i = 0; i < n; i++)
{
    x=random.Next(0, 3);
    y=random.Next(10, 100);
    miLista.Add(new Tarea(i+1,x,y));
}
Console.WriteLine("la lista de tareas es: ");
foreach (var item in miLista)
{
    Console.WriteLine(item.TareaID);
    Console.WriteLine(item.Descripcion);
    Console.WriteLine(item.Duracion);
}