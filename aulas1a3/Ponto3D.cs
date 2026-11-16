using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulas1a3
{
    
        public class Ponto3D : Ponto2D
        {
            public double Z { get; set; }

            // Construtor vazio
            public Ponto3D() : base()
            {
                this.Z = 0;
            }

            // Construtor com parâmetros
            public Ponto3D(double X, double Y, double Z) : base(X, Y)
            {
                this.Z = Z;
            }

            // Sobrescrever o método da classe Ponto2D
            public override string EscreverPonto()
            {
                return "Ponto 3D -> X = " + X +
                       ", Y = " + Y +
                       ", Z = " + Z;
            }
        }

    }

