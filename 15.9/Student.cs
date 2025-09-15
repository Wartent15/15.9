using System.ComponentModel.DataAnnotations;

public class Student
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

    [EmailAddress]
    public string Email { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public ICollection<Review> Reviews { get; set; }
    
}
