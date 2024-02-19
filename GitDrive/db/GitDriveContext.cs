using GitDrive.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace GitDrive.Db;

public class GitDriveContext : DbContext
{
    public DbSet<Repository> Repositories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=GitDrive.db");
}