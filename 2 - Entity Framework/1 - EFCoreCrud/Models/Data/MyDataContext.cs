using Microsoft.EntityFrameworkCore;
using EfCoreCrud.Models;

namespace EfCoreCrud.Data;

public class MyDataContext : DbContext
{
    /*public MyDataContext(DbContextOptions<MyDataContext> options)
    : base(options)
    {

    }*/
    /*Banco De Dados em memória, aplicação finalizou pede os dados.*/
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseInMemoryDatabase(databaseName: "todos");

    }
    public DbSet<Todo> Todos { get; set; }
}
