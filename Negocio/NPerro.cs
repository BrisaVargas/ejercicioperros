using ejercicioperros;
using Modelos;

namespace Negocio
{
    public class NPerro
    {
        public static void InsertarPerro(string nombre, string apellido, string raza, int peso)
        {
            try
            {
                DPerro.Insert(nombre, apellido, raza, peso);
            }catch(Exception ex)
            {
                throw;
            }
        }

        public static void UpdatePerro(int id,string nombre, string apellido, string raza, int peso)
        {
            try
            {
                DPerro.Update(id,nombre, apellido, raza, peso);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void DeletePerro( int id)
        {
            try
            {
                DPerro.Delete(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<Perro> GetAllPerros()
        {
            try
            {
                return DPerro.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}