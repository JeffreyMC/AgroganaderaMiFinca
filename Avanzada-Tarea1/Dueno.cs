using System;
namespace AvanzadaTarea1
{
    public class Dueno : Persona
    {
        public Dueno(int id, string nombre, string primerApellido, string segundoApellido,
                     string correo, int numeroCelular, Finca fincaAsociada)
        {
            Id = id;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Correo = correo;
            NumeroCelular = numeroCelular;
            FincaAsociada = fincaAsociada;
        }

        public Dueno() { }

        public string Correo { get; set; }
        public int NumeroCelular { get; set; }
        public Finca FincaAsociada { get; set; }
    }
}
