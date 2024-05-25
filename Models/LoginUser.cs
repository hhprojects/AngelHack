namespace AngelHack.Models;

public class LoginUser
{
    [Required(ErrorMessage = "Enter User ID")]
    public string UserId { get; set; } = null!;

    [Required(ErrorMessage = "Enter Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    public int Id { get; set; }
    public string UserName { get; set; } = null!;
}
