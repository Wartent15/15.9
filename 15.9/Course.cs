using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Course
{
    [Key]
    public int ID { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; }

    public string Description { get; set; }

    public int DurationHours { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    public ICollection<Instructor> Instructors { get; set; }

    public ICollection<Review> Reviews { get; set; }
