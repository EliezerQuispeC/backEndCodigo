using System;
using System.Collections.Generic;
using System.Text;

namespace Clases1.MisClases
{
    class Moto : Vehiculo
    {
        protected string cilindrada;
        public Moto(string placa, enumColores color, string nroSerie, string cilindrada)
        :base(placa,color,nroSerie){
            this.cilindrada = cilindrada;
        }
    }
}
