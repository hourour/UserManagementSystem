using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementSystem.Models;

[Table("WorkProgress")]
public class WorkProgress
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User? User { get; set; }  // 對應到使用者

    [Required]
    public string TaskName { get; set; } = "";

    [Required]
    public string Urgency { get; set; } = ""; // 例如：「緊急」、「一般」、「不急」

    public DateTime? Deadline { get; set; } // 可為 NULL

    [Required]
    public string ProgressStage { get; set; } = ""; // 例如：「開始」、「進行中」、「主管審核」、「上線測試」、「完成」
}

