class Mago : Personaje
{
    public const int CostoMana = 10;
    public const int DanoMagico = 25;

    public int Mana { get; private set; }

    public Mago(string nombre, int vida, int mana) : base(nombre, vida)
    {
        Mana = Math.Max(0, mana);
    }

    public override bool Atacar(Personaje objetivo)
    {
        if (!EstaVivo || Mana < CostoMana) return false;
        Mana -= CostoMana;
        objetivo.RecibirDano(DanoMagico);
        return true;
    }

    public override string ToLinea() => $"Mago;{Nombre};{Vida};{Mana}";
}