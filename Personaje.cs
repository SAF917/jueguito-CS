abstract class Personaje
{
    public const int VidaMaxima = 100;

    public string Nombre { get; }
    public int Vida { get; private set; }
    public bool EstaVivo => Vida > 0;

    protected Personaje(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = Math.Clamp(vida, 0, VidaMaxima);
    }

    public void RecibirDano(int dano)
    {
        Vida = Math.Max(0, Vida - dano);
    }

    public void Curar(int puntos)
    {
        if (!EstaVivo) return;
        Vida = Math.Min(VidaMaxima, Vida + puntos);
    }

    public abstract bool Atacar(Personaje objetivo);

    public abstract string ToLinea();

    public static Personaje? DesdeLinea(string linea)
    {
        string[] partes = linea.Split(';');
        if (partes.Length != 4) return null;
        if (!int.TryParse(partes[2], out int vida)) return null;
        if (!int.TryParse(partes[3], out int extra)) return null;

        return partes[0] switch
        {
            "Guerrero" => new Guerrero(partes[1], vida, extra),
            "Mago" => new Mago(partes[1], vida, extra),
            _ => null
        };
    }
}