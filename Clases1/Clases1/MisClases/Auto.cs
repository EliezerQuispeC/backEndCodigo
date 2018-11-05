using System;
using System.Collections.Generic;
using System.Text;

namespace Clases1.MisClases
{
    class Auto : Vehiculo
    {
        protected int nroPuertas;
        public Auto(string placa, enumColores color, string nroSerie, int nroPuertas)
        :base(placa,color,nroSerie){
            this.nroPuertas = nroPuertas;
        }
    }
}
