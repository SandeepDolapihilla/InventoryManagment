using InventoryManagment.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
namespace InventoryManagment.Models;

public class MyDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("Server=108.60.206.36, 14331;Initial Catalog=schedule_db_new;Persist Security Info=False;User ID=sa;Password=ab@03BDDG123#498@1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
        optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sande\\source\\repos\\InventoryManagment\\InventoryManagment\\InventoryDB.mdf;Integrated Security=True");
    }
    
    public MyDBContext()
    {
    }
    public virtual DbSet<Details> Details { get; set; }
    
}