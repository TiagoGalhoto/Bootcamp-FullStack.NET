namespace EfCoreCrud.Models;
public class Todo
{
    public int Id {get; set;}
    public string Title {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public bool Done {get; set;}
}