using System;
using Newtonsoft.Json;
namespace Tienda.Entities;
public class Product
{
    private string idProduct;
    private string name;
    private int stock;
    private int stockMin;
    private int stockMax;
    private int soldPrice;
    private int buyPrice;
    private int idCategory;

    public Product()  
    {
        if (!File.Exists(Env.FileName))
        {
            File.WriteAllText(Env.FileName, "");
        }
    }
    public string IdProduct
    {
        get {return idProduct;}
        set {idProduct = value;}
    }
    public string Name
    {
        get {return name;}
        set {name = value;}
    }
    public int Stock
    {
        get {return stock;}
        set {stock = value;}
    }
    public int StockMin
    {
        get {return stockMin;}
        set {stockMin = value;}
    }
    public int StockMax
    {
        get {return stockMax;}
        set {stockMax = value;}
    }
    public int SoldPrice
    {
        get {return soldPrice;}
        set {soldPrice = value;}
    }
    public int BuyPrice
    {
        get {return buyPrice;}
        set {buyPrice = value;}
    }
    public int IdCategory
    {
        get {return idCategory;}
        set {idCategory = value;}
    }
    public void AddProduct()
    {
        Product p = new Product();
        Console.WriteLine("\tIngrese el codigo de producto");
        p.IdProduct = Console.ReadLine();
        Console.WriteLine("\tIngrese el nombre de producto");
        p.Name = Console.ReadLine();
        Console.WriteLine("\tIngrese el stock de producto");
        p.Stock = int.Parse(Console.ReadLine());
        Console.WriteLine("\tIngrese el sotck minimo de producto");
        p.StockMin = int.Parse(Console.ReadLine());
        Console.WriteLine("\tIngrese el sotck maximo de producto");
        p.StockMax = int.Parse(Console.ReadLine());
        Console.WriteLine("\tIngrese el precio de venta de producto");
        p.SoldPrice = int.Parse(Console.ReadLine());
        Console.WriteLine("\tIngrese el precio de compra de producto");
        p.BuyPrice = int.Parse(Console.ReadLine());
        Console.WriteLine("\tIngrese el id de categoria");
        p.IdCategory = int.Parse(Console.ReadLine());
        Env.TiendaCampus.Products.Add(p);
    }
}