using System;

namespace bolascoloridas
{
    class Program
    {
        static void Main(string[] args)
        {
                private int red;
                private int green;
                private int blue;
                private int alpha;

            public Cor(int red, int green, int blue, int alpha)
                {
                    this.red = red;
                    this.green = green;
                    this.blue = blue;
                    this.alpha = alpha;
                }

            public Cor(int red, int green, int blue)
            {   
                this.red = red;
                this.green = green;
                this.blue = blue;
                this.alpha = 255;
            }

            public int Red
            {
            get { return red; }
            set { red = value; }
            }

            public int Green
            {
            get { return green; }
            set { green = value; }
            }

            public int Blue
            {
            get { return blue; }
            set { blue = value; }
            }

            public int Alpha
            {
                get{ return alpha; }
                set { alpha = value; }
            }

            public int GrauCinza
            {
                get { return (red + green + blue) / 3; }
            }
        }    
    }

    public class Bola
    {
    private Cor cor;
    private int raio;
    private int vezesAtirada;

    public Bola(Cor cor, int raio)
    {
        this.cor = cor;
        this.raio = raio;
        this.vezesAtirada = 0;
    }

    public Bola(int red, int green, int blue, int alpha, int raio)
        : this(new Cor(red, green, blue, alpha), raio)
    {
    }

    public void Pop()
    {
        raio = 0;
    }

    public void Atirar()
    {
        if (raio > 0)
            vezesAtirada++;
    }

    public int VezesAtirada
    {
        get { return vezesAtirada; }
    }

    public void ImprimirEstado()
        {
        Console.WriteLine($"Cor: R={cor.Red}, G={cor.Green}, B={cor.Blue}, A={cor.Alpha}");
        Console.WriteLine($"Raio: {raio}");
        Console.WriteLine($"Vezes Atirada: {vezesAtirada}");
        Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
        
            Bola bola1 = new Bola(255, 0, 0, 255, 10);
            Bola bola2 = new Bola(0, 255, 0, 255, 15);
         Bola bola3 = new Bola(0, 0, 255, 255, 20);

       
            bola1.Atirar();
            bola1.Atirar();
            bola2.Atirar();
            bola3.Atirar();
            bola3.Atirar();
            bola3.Atirar();

        
            bola1.Pop();
            bola3.Pop();

      
            bola1.ImprimirEstado();
            bola2.ImprimirEstado();
            bola3.ImprimirEstado();
        }
    }
}
