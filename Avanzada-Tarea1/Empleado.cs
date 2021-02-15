using System;
namespace AvanzadaTarea1
{
    public class Empleado : Persona
    {
        public Empleado(int id, string nombre, string primerApellido, string segundoApellido,
                        Double salario)
        {
            Id = id;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Salario = salario;
        }

        public Empleado() { }

        public Double Salario { get; set; }
    }
}
