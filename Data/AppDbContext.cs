using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {}

    public DbSet<User> Users { get; set; }

    public DbSet<WorkProgress> WorkProgresses { get; set; }

}
/*
| 程式碼            | 意義                               |
| -------------- | -------------------------------- |
| `AppDbContext` | 資料庫的進入點，管理資料存取                   |
| `DbSet<User>`  | 對應一張資料表（Table），這裡會產生 `Users` 資料表 |
| `options`      | 用來設定資料庫（之後會設定成 SQLite）           |
*/