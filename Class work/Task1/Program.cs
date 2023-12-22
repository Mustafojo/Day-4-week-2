public class Book
{
    public string Title;
    public string Author;
    public int Year;

    public Book(string title, string author,int year)
    {
        this.Title = title;
        this.Author = author;
        this.Year = year;
    } 
    public string GetInfo()
    {
        return $"{Title}  Агар ҷавонӣ медонисt {Author} Barotov Mustafo, Соли нашр: {Year}";
    }
    public void IsPublishedRecently()
    {
        if(Year >= 2010)
        {
            System.Console.WriteLine("True");
        }
        else if(Year < 2010)
        {
            System.Console.WriteLine("False");
        }
    }
}
