namespace Tareas;

public class Tarea
{
    private int tareaID;
    private string? descripcion;
    private int duracion;

    private string[] Descripciones = {"tarea de Algebra", "tarea de calculo", "tarea de Laboratorio", "tarea de Logica"};

    public int TareaID { get => tareaID; set => tareaID = value; }
    public Tarea(int TareaID, int r, int d){
        tareaID=TareaID;
        descripcion=Descripciones[r];
        duracion=d;
    }
    
    public string? Descripcion { get => descripcion;
    }

    public int Duracion { get => duracion; 
    }

}