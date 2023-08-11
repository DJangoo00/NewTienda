namespace Tienda.Entities;
public class TiendaCampus
{
    private List<Product> products = new List<Product>();
    private List<Category> categories = new List<Category>();
    public List<Category> Categories
    {
        get { return categories;}
        set { categories = value;}
    }
    public List<Product> Products
    {
        get { return products;}
        set { products = value;}
    }
    public TiendaCampus(){}
}