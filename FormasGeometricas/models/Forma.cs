public abstract class Forma{
    public string Nome { get; set; }
     public Forma(string nome)
    {
        Nome = nome;
    }

    public abstract double Area();

}