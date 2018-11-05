using System;
using System.Collections.Generic;
using System.Text;

namespace Clases1.MisClases
{
    class Vehiculo
    {
        public string placa;
        public enumColores color;
        private string nroSerie;
        public enumEstados estado;

        public Vehiculo(string placa, enumColores color, string nroSerie)
        {
            this.placa      = placa;
            this.color      = color;
            this.nroSerie   = nroSerie;
            estado     = enumEstados.APAGADO;
        }

        public string Encender()
        {
            if(estado == enumEstados.APAGADO)
            {
                estado = enumEstados.ENCENDIDO;
                return "Vehículo encendido!";
            }
            else
            {
                return "El vehículo debe estar apagado";
            }

        }
        public string Frenar()
        {
            if (estado == enumEstados.ENMARCHA)
            {
                estado = enumEstados.DETENIDO;
                return "Vehículo detenido!";
            }
            else
            {
                return "El vehículo debe estar en marcha";
            }
        }
        public string Girar(enumDirecciones direccion)
        {
            if (estado == enumEstados.ENMARCHA)
            {
                return "Vehiculo girando a la " + direccion;
            }
            else
            {
                return "El vehículo debe estar en marcha";
            }
        }
    }
}
