using System.ComponentModel.DataAnnotations;

public class Review
{
    [Key]
    public int ID { get; set; }

    // Внешние ключи: курс и студент
    public int CourseID { get; set; }
    public Course Course { get; set; }

    public int StudentID { get; set; }
    public Student Student { get; set; }

    // Рейтинг от 0 до 10
    [Range(0, 10)]
    public int Rating { get; set; }
}