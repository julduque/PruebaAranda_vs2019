using System;
using System.Linq;
using ArandaInterface;
using TestArandaDataBase;
using Newtonsoft.Json;

namespace ArandaController
{
    public class ProductoAction : IProducto
    {  
        public string PostAction(PostRequest value)
        {
            var result = string.Empty;
            var prod = value.prod;
            switch (value.action)
            {
                case "Insert":
                    { result = InsertProducto(prod); break; }
                case "Edit":
                    { result = EditProducto(prod); break; }
                case "Delete":
                    { result = DeleteProducto(prod); break; }
                case "Search": 
                    { result = SearchByProducto(prod, value.page_size, value.page_number);
                        break;
                    }

                default:
                    break;
            }

            return result;
        }

        private string InsertProducto(Producto value)
        {
            try
            {
                string json = string.Empty;

                using (var context = new PruebaArandaDBEntities())
                {
                    var query = context.ProductoInsert(value.NombreProducto, value.Descripcion, value.Categoria, value.ImagenProducto);
                    context.SaveChanges();
                    return query.ToString();
                }
            }
            catch (Exception ex)
            {
                return "ERROR:" + ex.Message;
            }
        }

        private string EditProducto(Producto value)
        {
            try
            {
                string json = string.Empty;

                using (var context = new PruebaArandaDBEntities())
                {
                    var prequery = context.Producto.Where(p => p.IdProducto == value.IdProducto).ToList<Producto>();

                    if (prequery == null)
                    {
                        return "ERROR: No encontrado";
                    }

                    var query = context.ProductoEdit(value.IdProducto, value.NombreProducto, value.Descripcion, value.Categoria, value.ImagenProducto);
                    context.SaveChanges();
                    return query.ToString();
                }
            }
            catch (Exception ex)
            {
                return "ERROR:" + ex.Message;
            }
        }

        private string DeleteProducto(Producto value)
        {
            try
            {
                using (var context = new PruebaArandaDBEntities())
                {
                    context.ProductoDelete(value.IdProducto);
                    context.SaveChanges();
                }

                return value.IdProducto.ToString();
            }
            catch (Exception ex)
            {
                return "ERROR:" + ex.Message;
            }
        }

        private string SearchByProducto(Producto prod, int? page_size, int? page_number)
        {
            string json = string.Empty;
            using (var context = new PruebaArandaDBEntities())
            {
                var query = context.ProductoConsulta(prod.NombreProducto, prod.Descripcion, prod.Categoria, page_size, page_number);
                json = JsonConvert.SerializeObject(query);
            }

            return json;
        }
    }
}
