using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class AppUsers
{
    public int Id { get; set; }
    public string Name { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
}