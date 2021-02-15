using System;
namespace AvanzadaTarea1
{
    public class Finca
    {
        public Finca(int numero, string nombre, Double tamanio, string direccion, string telefono)
        {
            NoFinca = numero;
            Nombre = nombre;
            Tamanio = tamanio;
            Direccion = direccion;
            Telefono = telefono;
        }

        public int NoFinca { get; set; }
        public string Nombre { get; set; }
        public Double Tamanio { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
