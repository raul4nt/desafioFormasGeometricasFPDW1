using System;

// Desafio Formas Geométricas:
// Precisamos implementar um sistema para calcular a área de algumas formas geométricas, 
// barbadinha, não?
// Consulte o diagrama de classe anexo para usar como base.

// Para facilitar o cálculo da área do triângulo, considere um triângulo retângulo, 
// onde serão usados apenas dois parâmetros para o cálculo da área.
// O calculo da área desse tipo de triângulo é  calculada usando o comprimento da base 
// e o comprimento da altura:
// área = (base*altura) / 2​



class Program
{
    static void Main(string[] args)
    {
        Circulo circulo1 = new Circulo("Círculo1", 5);
        Quadrado quadrado1 = new Quadrado("Quadrado1", 10);
        TrianguloRetangulo triangulo1 = new TrianguloRetangulo("Triangulo1", 5, 12);

        Console.WriteLine("Calculando área!");
        Console.WriteLine($"A área do círculo é de: {circulo1.Area()} unidades quadradas");
        Console.WriteLine($"A área do quadrado é de: {quadrado1.Area()} unidades quadradas");
        Console.WriteLine($"A área do triângulo é de: {triangulo1.Area()} unidades quadradas");
    }
}