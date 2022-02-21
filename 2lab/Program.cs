using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2lab
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Instance.Start();
        }
    }
}
public class Menu
{
    public void Start()//старт выбора
    {
        Console.WriteLine
            (
            "Выберите документ:" +
            "1-Excel" +
            "2-Word" +
            "3-PDF" +
            "4-Txt" +
            "5-Html"
            );
        int Number = Convert.ToInt32(Console.ReadLine());//номер выбора
        switch (Number)//Сам выбор
        {
            case 1:
                Menu.Instance.Excel();
                break;
            case 2:
                Menu.Instance.MsWord();
                break;
            case 3:
                Menu.Instance.PDF();
                break;
            case 4:
                Menu.Instance.Txt();
                break;
            case 5:
                Menu.Instance.Html();
                break;
        }
    }
    public static Menu Instance
    {
        get//Как я понял - это синглтон
        {
            if (instance == null) instance = new Menu();
            return instance;
        }
    }
    private Menu() { }//и это
    private static Menu instance;//это тоже
    public void Excel() //Данные экзель
    {
        var Excel = new 
        { 
            Name = "doc1.exl", 
            Author = "bjiake", 
            Keywords = "table1", 
            Subject = "information", 
            PathFile = "c:\\" 
        };
        Console.WriteLine(Excel);
    }
    public void MsWord()//Данные ворда
    {
        var Word = new
        {
            Name = "doc2.exl",
            Author = "bjiake",
            Keywords = "Doc1",
            Subject = "informa",
            PathFile = "c:\\"
        };
        Console.WriteLine(Word);
    }
    public void PDF()//Данные пдф
    {
        var Pdf = new
        {
            Name = "aristotel.pdf",
            Author = "bjiake",
            Keywords = "pdf1",
            Subject = "Filos",
            PathFile = "c:\\"
        };
        Console.WriteLine(Pdf);
    }
    public void Txt()//Данные тхт
    {
        var txt = new
        {
            Name = "txt.txt",
            Author = "bjiake",
            Keywords = "text",
            Subject = "inf",
            PathFile = "c:\\"
        };
        Console.WriteLine(txt);
    }
    public void Html()//Данные хтмл
    {
        var html = new
        {
            Name = "site.html",
            Author = "bjiake",
            Keywords = "var",
            Subject = "Low",
            PathFile = "c:\\"
        };
        Console.WriteLine(html);
    }
    
}

