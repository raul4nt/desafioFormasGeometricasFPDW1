public class TrianguloRetangulo : Forma
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public TrianguloRetangulo(string nome, double baseTriangulo, double altura) : base(nome)
    {
        Base = baseTriangulo;
        Altura = altura;
    }

    public override double Area()
    {
        return Base * Altura / 2;
    }
}

// class Triangulo : Forma{
//     public double LadoA{ get; set; }
//     public double LadoB{ get; set; }
//     public double LadoC{ get; set; }

//     public Triangulo(string nome, double ladoA, double ladoB, double ladoC) : base(nome){
//         LadoA = ladoA;
//         LadoB = ladoB;
//         LadoC = ladoC;
//     }

//     public override double Area()
//     {
//         return LadoA;
//     }
// }