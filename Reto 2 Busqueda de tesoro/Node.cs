public class Nodo
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Pista { get; set; }
    public int Peligro { get; set; } // Nivel del 1 al 10

    public Nodo Siguiente { get; set; } // Referencia al siguiente nodo

    public Nodo(int id, string nombre, string pista, int peligro)
    {
        Id = id;
        Nombre = nombre;
        Pista = pista;
        Peligro = peligro;
        Siguiente = null; // Todo nuevo nodo apunta a null inicialmente
    }
}