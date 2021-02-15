using System;
namespace AvanzadaTarea1
{
    public class Raza
    {
        public Raza(int codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
