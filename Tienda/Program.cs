using Newtonsoft.Json;
using Tienda;
using Tienda.Entities;
using Tienda.View;

internal class Program
{
    public static void Main(string[] args)
    {
        int option;
        if ( Env.ValidarFile(Env.FileName) == false)
        {
            File.WriteAllText(Env.FileName, "");
        }else 
        {
            Env.LoadDataProducts(Env.FileName);
        }
        Env.ImprimirData("dddddd", Env.TiendaCampus.Categories);
        do
        {
            option = MenuView.MainMenu();
            switch (option)
            {
                case 1:
                    break;
                case 2:
                    Category.AddCategory();
                    string json = JsonConvert.SerializeObject(Env.TiendaCampus, Formatting.Indented);
                    File.WriteAllText(Env.FileName, json);
                    break;
                default:
                    break;
            }
        }while(option != 3);
    }
}