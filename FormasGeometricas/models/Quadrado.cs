class Quadrado : Forma{
    public double Lado{ get; set; }

    public Quadrado(string nome, double lado) : base(nome){
        Lado = lado;
    }

    public override double Area()
    {
        return Lado * Lado;
    }
}