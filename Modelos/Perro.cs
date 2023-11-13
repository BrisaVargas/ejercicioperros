namespace Modelos
{
    public class Perro
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string raza { get; set; }
        public int peso { get; set; }

        public Perro(int id, string nombre, string apellido, string raza, int peso) {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.raza = raza;
            this.peso = peso;
        }

        public Perro() { }
    }
}