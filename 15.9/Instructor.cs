using System.ComponentModel.DataAnnotations;

public class Instructor
{
    [Key]
    public int ID { get; set; }

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    [MaxLength(100)]
    public string Patronymic { get; set; }

    // Email и телефон
    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    public string Phone { get; set; }

    // Связь с курсом: внешний ключ к курсу
    public int? CourseID { get; set; }
    public Course Course { get; set; }
}