

using System.Collections.Generic;

namespace AfectacionMedioAmbiente.Web.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List <Celular> Celulares { get; set; }

        public Celular CrearCelular()
        {
            string marca = "Samsung";
            string modelo = "S7";

            Celular celular = new Celular(marca, modelo);
            Celulares.Add(celular);
            return celular;


        }
    }
}
