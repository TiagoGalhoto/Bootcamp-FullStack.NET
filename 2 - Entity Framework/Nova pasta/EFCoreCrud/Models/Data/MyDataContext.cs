using Microsoft.EntityFrameworkCore;
using EfCoreCrud.Models;



namespace EFCoreCrud.Data;

public class MyDataContext : DbContext
{
    /*public MyDataContext(DbContextOptions<MyDataContext> options)
    : base(options)
    {

    }*/

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
       options.UseInMemoryDatabase(databaseName:"todos");
        
    }
    public DbSet<Todo> todos { get; set; }
}
