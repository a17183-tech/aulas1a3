using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulas1a3
{
    
        public class Ponto2D
        {
            public double X { get; set; }
            public double Y { get; set; }

            // Construtor vazio
            public Ponto2D()
            {
                this.X = 0;
                this.Y = 0;
            }

            // Construtor com parâmetros
            public Ponto2D(double X, double Y)
            {
                this.X = X;
                this.Y = Y;
            }

            // Método virtual
            public virtual string EscreverPonto()
            {
                return "Ponto 2D -> X = " + X + ", Y = " + Y;
            }
        }

    }

