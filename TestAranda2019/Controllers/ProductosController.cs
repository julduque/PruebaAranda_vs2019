using System;
using System.Linq;
using System.Web.Http;
using TestArandaDataBase;
using ArandaInterface;
using ArandaController;

using Newtonsoft.Json;

namespace TestAranda2019.Controllers
{
    public class ProductosController : ApiController
    {
                // GET api/Productos
        public IHttpActionResult Get()
        {
            string json = string.Empty;
            using (var context = new PruebaArandaDBEntities())
            {
                var query = context.Producto.Where(p => p.Categoria > 0).ToList<Producto>();
                json = JsonConvert.SerializeObject(query); 
            }

            return Ok(json);
        }

        // GET api/Productos/id
        public IHttpActionResult Get(int id)
        {
            string json = string.Empty;
            using (var context = new PruebaArandaDBEntities())
            {
                var query = context.Producto.Where(p => p.IdProducto == id).ToList<Producto>();
                json = JsonConvert.SerializeObject(query);
            }

            return Ok(json);
        }

        // POST api/Productos
        public IHttpActionResult Post([FromBody] PostRequest value)
        {
            try
            {
                var result = new ProductoAction().PostAction(value);
                if (result.Contains("ERROR:"))
                {
                    return BadRequest(result);
                }
                else
                {
                    return Ok(result);
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }     

    }
}