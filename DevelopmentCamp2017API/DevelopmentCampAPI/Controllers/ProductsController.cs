using DevelopmentCamp.DAL.Handlers;
using DevelopmentCamp.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevelopmentCampAPI.Controllers
{
    public class ProductsController : ApiController
    {
        [ActionName("GetAll")]
        public List<Producto> GetAll()
        {
            return ProductosHandler.GetAll();
        }

        [ActionName("GetDeleted")]
        public List<Producto> GetDeleted()
        {
            return ProductosHandler.GetAll()
                .Where(p=>p.IdProducto.Equals(1)).ToList();
        }
    }
}
