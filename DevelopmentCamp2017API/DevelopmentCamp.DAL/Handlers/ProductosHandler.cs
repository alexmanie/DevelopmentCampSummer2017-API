using DevelopmentCamp.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentCamp.DAL.Handlers
{
    public static class ProductosHandler
    {
        public static bool CreateProducto()
        {
            try
            {
                using (var context = new Model.DevelopmentCampEntities())
                {
                    Producto p = new Producto
                    {
                        Nombre = $"Titulo CD {DateTime.Now.Millisecond}",
                        IdTipoProducto = 1,
                        FechaLanzamiento = DateTime.Now
                        //IdProducto
                        //TipoProducto
                        //ProductoArtistas
                    };

                    context.Productoes.Add(p);

                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Producto> GetAll()
        {
            try
            {
                using (var context = new Model.DevelopmentCampEntities())
                {
                    context.Configuration.ProxyCreationEnabled = false;
                    var productos = context.Productoes
                        .Include("TipoProducto")
                        .ToList();

                    return productos;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Producto GetProductDetail(int idProducto)
        {
            try
            {
                using (var context = new Model.DevelopmentCampEntities())
                {
                    Producto prod = context.Productoes
                        .Where(p => p.IdProducto.Equals(idProducto))
                        .FirstOrDefault();

                    return prod;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateProductFechaLanzamiento(int idProducto, DateTime date)
        {
            try
            {
                using (var context = new Model.DevelopmentCampEntities())
                {
                    Producto prod = context.Productoes
                       .Where(p => p.IdProducto.Equals(idProducto))
                       .FirstOrDefault();

                    if (prod != null)
                        prod.FechaLanzamiento = date;

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
