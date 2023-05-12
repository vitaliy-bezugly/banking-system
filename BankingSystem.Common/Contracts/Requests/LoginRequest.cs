using System.ComponentModel.DataAnnotations;

namespace BankingSystem.Common.Contracts.Requests;

public class LoginRequest
{
    [Required, MinLength(6)] 
    public string Username { get; set; } = String.Empty;
    [Required, DataType(DataType.Password)]
    public string Password { get; set; } = String.Empty;
}