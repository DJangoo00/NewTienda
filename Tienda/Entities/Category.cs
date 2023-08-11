namespace Tienda.Entities;
public class Category
{
    int id { get; set; }
    string description { get; set; }

    public Category(){}
    public Category(int id, string description)
    {
        this.id = id;
        this.description = description;
    }
    public static void AddCategory()
    {
        Category cat = new Category();
        Console.Write("Ingrese el Id de la categoria");
        cat.id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre de la categoria");
        cat.id = int.Parse(Console.ReadLine());
        Env.TiendaCampus.Categories.Add(cat);
    }
    public IEnumerable<Category> ListaCategorias ()
    {
        return from cat in Env.TiendaCampus.Categories
            select cat;
    } 
}