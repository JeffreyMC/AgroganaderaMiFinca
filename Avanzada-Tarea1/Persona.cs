using System;
namespace AvanzadaTarea1
{
    public class Persona
    {

        public Persona(int id, string nombre, string primerApellido, string segundoApellido)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
        }

        public Persona() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
    }
}
