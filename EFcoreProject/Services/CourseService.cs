using EFcoreProject.Data;
using EFcoreProject;
using Microsoft.EntityFrameworkCore;

public class CourseService
{
    private readonly AppDbContext _context;

    public CourseService(AppDbContext context)
    {
        _context = context;
    }

    // Create
    public void AddCourse(Course course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();
    }

    // Read
    public List<Course> GetAllCourses()
    {
        return _context.Courses
            .Include(c => c.Instructor)
            .Include(c => c.Department)
            .ToList();
    }

    public Course? GetCourseById(int id)
    {
        return _context.Courses
            .Include(c => c.Instructor)
            .Include(c => c.Department)
            .FirstOrDefault(c => c.Id == id);
    }

    // Update
    public void UpdateCourse(Course course)
    {
        _context.Courses.Update(course);
        _context.SaveChanges();
    }

    // Delete
    public void DeleteCourse(int id)
    {
        var course = _context.Courses.Find(id);
        if (course != null)
        {
            _context.Courses.Remove(course);
            _context.SaveChanges();
        }
    }
}