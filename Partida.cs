static class Partida
{
    public static void Guardar(List<Personaje> personajes, string ruta)
    {
        using var escritor = new StreamWriter(ruta);
        foreach (Personaje p in personajes)
        {
            escritor.WriteLine(p.ToLinea());
        }
    }

    public static List<Personaje> Cargar(string ruta)
    {
        var personajes = new List<Personaje>();
        if (!File.Exists(ruta)) return personajes;

        using var lector = new StreamReader(ruta);
        string? linea;
        while ((linea = lector.ReadLine()) != null)
        {
            Personaje? p = Personaje.DesdeLinea(linea);
            if (p != null) personajes.Add(p);
        }
        return personajes;
    }
}