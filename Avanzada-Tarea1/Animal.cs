using System;
namespace AvanzadaTarea1
{
    public class Animal
    {
        public Animal(int id, string nombre, Finca finca, Raza raza, DateTime fechaNacimiento,
                        int sexo, string padre, string madre)
        {
            Id = id;
            Nombre = nombre;
            FincaAsociada = finca;
            RazaAnimal = raza;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            Padre = padre;
            Madre = madre;
        }

        public Animal() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Finca FincaAsociada { get; set; }
        public Raza RazaAnimal { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Sexo { get; set; }
        public string Padre { get; set; }
        public string Madre { get; set; }

    }
}
