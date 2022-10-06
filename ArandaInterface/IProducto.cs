using TestArandaDataBase;

namespace ArandaInterface
{
    public class PostRequest
    {
        public string action;
        public Producto prod;
        public int page_size;
        public int page_number;
    }
    public interface IProducto
    {
        string PostAction(PostRequest value);
    }
}
