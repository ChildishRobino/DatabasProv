using CaseManagerApp.MVVM.Models;
using CaseManagerApp.MVVM.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace CaseManagerApp.Contexts;

internal class DataContext : DbContext
{

    private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Robin\Desktop\DatabasProv\CaseManagerApp\Contexts\Sql_db_assignment.mdf;Integrated Security=True;Connect Timeout=30"; 

    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }

    public DbSet<TenantEntity> Tenants { get; set; } = null!;

    public DbSet<AddressEntity> Addresses { get; set; } = null!;

    public DbSet<CaseEntity> Cases { get; set; } = null!;

    public DbSet<CaseCommentEntity> CaseComments { get; set; } = null!;




}
