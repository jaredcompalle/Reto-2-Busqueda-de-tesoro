using System.Collections.Generic;

public class ListaSimple
{
    public Nodo Inicio { get; private set; }

    public ListaSimple()
    {
        Inicio = null;
    }

    public bool Insertar(int id, string nombre, string pista, int peligro)
    {
        if (Buscar(id) != null)
        {
            return false;
        }

        Nodo nuevoNodo = new Nodo(id, nombre, pista, peligro);

        if (Inicio == null)
        {
            Inicio = nuevoNodo;
        }
        else
        {
            Nodo actual = Inicio;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }

        return true; 
    }

    public List<Nodo> Recorrer()
    {
        List<Nodo> nodosParaVista = new List<Nodo>();
        Nodo actual = Inicio;

        while (actual != null)
        {
            nodosParaVista.Add(actual);
            actual = actual.Siguiente;
        }

        return nodosParaVista;
    }

    public Nodo Buscar(int id)
    {
        Nodo actual = Inicio; 

        while (actual != null)
        {
            if (actual.Id == id)
            {
                return actual; 
            }
            actual = actual.Siguiente; 
        }

        return null;
    }

    public bool Modificar(int id, string nuevoNombre, string nuevaPista, int nuevoPeligro)
    {
        Nodo actual = Inicio;

        while (actual != null)
        {
            if (actual.Id == id)
            {
                actual.Nombre = nuevoNombre;
                actual.Pista = nuevaPista;
                actual.Peligro = nuevoPeligro;
                return true; 
            }
            actual = actual.Siguiente; 
        }

        return false;
    }

    public bool Eliminar(int id)
    {
        if (Inicio == null)
        {
            return false;
        }

        if (Inicio.Id == id)
        {
            Inicio = Inicio.Siguiente;
            return true;
        }

        Nodo actual = Inicio;

        while (actual.Siguiente != null)
        {
            if (actual.Siguiente.Id == id)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
                return true;
            }
            actual = actual.Siguiente;
        }

        return false;
    }
}