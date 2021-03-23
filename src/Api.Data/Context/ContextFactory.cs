using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado par acriar as migrações
            var connectionstring = "Server=localhost;Port=5403;Database=CourseAPI;Uid=root;Pwd=123456";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            optionBuilder.UseSqlServer(connectionstring);
            return new MyContext(optionBuilder.Options);
        }
    }
}