using DevelopmentCamp.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentCamp.DAL.Handlers
{
    public static class ArtistasHandler
    {
        public static bool CreateArtista()
        {
            try
            {
                using (var context = new Model.DevelopmentCampEntities())
                {

                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Artista> ReadArtistas()
        {
            try
            {
                using (var context = new Model.DevelopmentCampEntities())
                {
                    List<Artista> artistas = context.Artistas
                        .ToList();

                    return artistas;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool CreateProductoArtista(int idArtista, int idProducto)
        {
            try
            {
                using (var context = new Model.DevelopmentCampEntities())
                {
                    ProductoArtista pa = new ProductoArtista
                    {
                        idArtista = idArtista,
                        idProducto = idProducto
                    };

                    context.ProductoArtistas.Add(pa);

                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
