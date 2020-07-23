
using System;
using System.Buffers.Text;
using System.Runtime.CompilerServices;

namespace SolucionAppLogica
{
   public  class Lavadora : ProductoElectrodomestico
    {
        public float Peso { get; set; }
        public string TipoDeLavado { get; set; }
        public float ConsumoElectrico { get; set; }
        public Lavadora():base()
        {}
        public Lavadora(string modelo,string marca, float costo)
        {
            Modelo = modelo;
            Marca = marca;
            Costo = costo;
        }
        public new string Encender()
        {
            return $"{this.Modelo} {this.Marca} {base.Encender()} ";
        }
        public new string Apagar()
        {
            return $"{this.Modelo} {base.Apagar()} {base.Apagar()}";
        }
        public string Usar(string lavado )
        {
            return $"La lavadora esta {lavado}";
        }
        public virtual string Describir()
        {
            Random consumo = new Random();
            int numeroConsumo = consumo.Next(30, 60);
            int numeroPeso = consumo.Next(40, 70);
            ConsumoElectrico = numeroConsumo;
            Peso = numeroPeso;
            return $"Su equipo de lavado {this.Modelo} {this.Marca} " +
                $"tiene un peso de {this.Peso} Kg, con un consumo electrico al mes de {this.ConsumoElectrico} kWh y tiene un costo de: {this.Costo}";
        }
    }
}
