using System.Collections.Generic;
using EfCoreCrud.Data;

namespace Conexao
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MyDataContext();
            context.Todos.ToList();
            context.Dispose();
        }
    }
}


