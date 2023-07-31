using DependencyInjectionDatabaseExample.Context;

namespace DependencyInjectionDatabaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDbContext appDbContext = new AppDbContext();
            DBOptionsCenter optionsCenter = new DBOptionsCenter(appDbContext);
            optionsCenter.AddEntities();
        }
    }
}