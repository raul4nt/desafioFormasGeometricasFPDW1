class Circulo : Forma{
    public double Raio{ get; set; }

    public Circulo(string nome, double raio) : base(nome){
        Raio = raio;
    }

    public override double Area()
    {
        return Math.PI * Raio * Raio;
    }

}