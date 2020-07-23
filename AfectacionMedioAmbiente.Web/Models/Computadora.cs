

namespace SolucionAppLogica
{
    public class Computadora:ProductoTecnologico

    {
        public string Almacenamiento { get; set; }
        public string Generacion { get; set; }

        public Computadora():base()
        { }

        public Computadora(string modelo, string marca, string almacenamiento, string generacion, float costo)
        {
            Modelo = modelo;
            Marca = marca;
            Almacenamiento = almacenamiento;
            Generacion = generacion;
            Costo = costo;
        }
        public virtual string VideoLlamada()
        {
            return "El dispositivo se esta conectando a una videollamada..";
        }
        public virtual string DescargarArchivos()
        {
            return "Sus archivos han sido descargados";
        }
        public virtual string Describir()
        {
            return $"Su equipo portatil {this.Modelo} {this.Marca}" +
                $"{this.Almacenamiento} de almacenamiento y {this.Generacion} de memoria Ram, y tiene un costo de: {this.Costo}";
        }
        public new string Encender()
        {
            return $"{this.Modelo} {this.Marca} {base.Encender()} ";
        }
        public new string Apagar()
        {
            return $"{this.Modelo} {base.Apagar()} {base.Apagar()}";
        }
    }
}
