using System.ComponentModel.DataAnnotations;

public class Review
{
    [Key]
    public int ID { get; set; }

    public int CourseID { get; set; }
    public Course Course { get; set; }

    public int StudentID { get; set; }
    public Student Student { get; set; }

    [Range(0, 10)]
    public int Rating { get; set; }
}
