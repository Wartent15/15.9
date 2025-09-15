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

    // Длительность в часах
    public int DurationHours { get; set; }

    // Цена в валюте вашей БД (например, USD)
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    // Навигация: один ко многим к преподавателям (множество преподавателей могут привязаться к курсу)
    public ICollection<Instructor> Instructors { get; set; }

    // Навигация: отзывы по курсу
    public ICollection<Review> Reviews { get; set; }