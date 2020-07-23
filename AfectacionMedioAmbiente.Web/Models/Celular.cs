namespace AfectacionMedioAmbiente.Web.Models
{
    public class Celular
    {
        public Celular() { }
        public Celular(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

    }
}
