using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagementSystem.Models;

public class User
{
    public int Id { get; set; }//使用者編號，資料表的主鍵
    public string Name { get; set; } = "";//使用者名稱
    public string Email { get; set; } = "";//使用者信箱
    public string Account { get; set; } = "";
    public string Password { get; set; } = "";

}
