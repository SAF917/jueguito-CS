class Guerrero : Personaje
{
    public int Fuerza { get; }

    public Guerrero(string nombre, int vida, int fuerza) : base(nombre, vida)
    {
        Fuerza = fuerza;
    }

    public override bool Atacar(Personaje objetivo)
    {
        if (!EstaVivo) return false;
        objetivo.RecibirDano(Fuerza);
        return true;
    }

    public override string ToLinea() => $"Guerrero;{Nombre};{Vida};{Fuerza}";
}