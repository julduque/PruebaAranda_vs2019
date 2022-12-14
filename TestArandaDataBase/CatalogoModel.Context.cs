//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestArandaDataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class PruebaArandaDBEntities : DbContext
    {
        public PruebaArandaDBEntities()
            : base("name=PruebaArandaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public DbSet<Producto> Producto { get; set; }
    
        public virtual int ProductoDelete(Nullable<int> idProd)
        {
            var idProdParameter = idProd.HasValue ?
                new ObjectParameter("idProd", idProd) :
                new ObjectParameter("idProd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProductoDelete", idProdParameter);
        }
    
        public virtual int ProductoEdit(Nullable<int> idProd, string nombreP, string descrip, Nullable<int> cat, byte[] imagen)
        {
            var idProdParameter = idProd.HasValue ?
                new ObjectParameter("idProd", idProd) :
                new ObjectParameter("idProd", typeof(int));
    
            var nombrePParameter = nombreP != null ?
                new ObjectParameter("nombreP", nombreP) :
                new ObjectParameter("nombreP", typeof(string));
    
            var descripParameter = descrip != null ?
                new ObjectParameter("descrip", descrip) :
                new ObjectParameter("descrip", typeof(string));
    
            var catParameter = cat.HasValue ?
                new ObjectParameter("cat", cat) :
                new ObjectParameter("cat", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("imagen", imagen) :
                new ObjectParameter("imagen", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProductoEdit", idProdParameter, nombrePParameter, descripParameter, catParameter, imagenParameter);
        }
    
        public virtual int ProductoInsert(string nombreP, string descrip, Nullable<int> cat, byte[] imagen)
        {
            var nombrePParameter = nombreP != null ?
                new ObjectParameter("nombreP", nombreP) :
                new ObjectParameter("nombreP", typeof(string));
    
            var descripParameter = descrip != null ?
                new ObjectParameter("descrip", descrip) :
                new ObjectParameter("descrip", typeof(string));
    
            var catParameter = cat.HasValue ?
                new ObjectParameter("cat", cat) :
                new ObjectParameter("cat", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("imagen", imagen) :
                new ObjectParameter("imagen", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProductoInsert", nombrePParameter, descripParameter, catParameter, imagenParameter);
        }
    
        public virtual ObjectResult<ProductoGet_Result> ProductoGet(string nombreP, string descrip, Nullable<int> cat, Nullable<int> pagesize, Nullable<int> pagenum)
        {
            var nombrePParameter = nombreP != null ?
                new ObjectParameter("nombreP", nombreP) :
                new ObjectParameter("nombreP", typeof(string));
    
            var descripParameter = descrip != null ?
                new ObjectParameter("descrip", descrip) :
                new ObjectParameter("descrip", typeof(string));
    
            var catParameter = cat.HasValue ?
                new ObjectParameter("cat", cat) :
                new ObjectParameter("cat", typeof(int));
    
            var pagesizeParameter = pagesize.HasValue ?
                new ObjectParameter("pagesize", pagesize) :
                new ObjectParameter("pagesize", typeof(int));
    
            var pagenumParameter = pagenum.HasValue ?
                new ObjectParameter("pagenum", pagenum) :
                new ObjectParameter("pagenum", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProductoGet_Result>("ProductoGet", nombrePParameter, descripParameter, catParameter, pagesizeParameter, pagenumParameter);
        }
    
        public virtual ObjectResult<ProductoGet_Result> ProductoConsulta(string nombreP, string descrip, Nullable<int> cat, Nullable<int> pagesize, Nullable<int> pagenum)
        {
            var nombrePParameter = nombreP != null ?
                new ObjectParameter("nombreP", nombreP) :
                new ObjectParameter("nombreP", typeof(string));
    
            var descripParameter = descrip != null ?
                new ObjectParameter("descrip", descrip) :
                new ObjectParameter("descrip", typeof(string));
    
            var catParameter = cat.HasValue ?
                new ObjectParameter("cat", cat) :
                new ObjectParameter("cat", typeof(int));
    
            var pagesizeParameter = pagesize.HasValue ?
                new ObjectParameter("pagesize", pagesize) :
                new ObjectParameter("pagesize", typeof(int));
    
            var pagenumParameter = pagenum.HasValue ?
                new ObjectParameter("pagenum", pagenum) :
                new ObjectParameter("pagenum", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProductoGet_Result>("ProductoConsulta", nombrePParameter, descripParameter, catParameter, pagesizeParameter, pagenumParameter);
        }
    
        public virtual int ProductoGetByIdProduct(string nombreP, string descrip, Nullable<int> cat, Nullable<int> pagesize, Nullable<int> pagenum)
        {
            var nombrePParameter = nombreP != null ?
                new ObjectParameter("nombreP", nombreP) :
                new ObjectParameter("nombreP", typeof(string));
    
            var descripParameter = descrip != null ?
                new ObjectParameter("descrip", descrip) :
                new ObjectParameter("descrip", typeof(string));
    
            var catParameter = cat.HasValue ?
                new ObjectParameter("cat", cat) :
                new ObjectParameter("cat", typeof(int));
    
            var pagesizeParameter = pagesize.HasValue ?
                new ObjectParameter("pagesize", pagesize) :
                new ObjectParameter("pagesize", typeof(int));
    
            var pagenumParameter = pagenum.HasValue ?
                new ObjectParameter("pagenum", pagenum) :
                new ObjectParameter("pagenum", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProductoGetByIdProduct", nombrePParameter, descripParameter, catParameter, pagesizeParameter, pagenumParameter);
        }
    }
}
