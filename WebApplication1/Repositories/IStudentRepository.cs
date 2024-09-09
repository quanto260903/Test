using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentByIdAsync(int id);
        Task<IEnumerable<Student>> GetStudentsAsync(string sortOrder, string searchString, int page, int pageSize);
        Task AddStudentAsync(Student student);
        Task UpdateStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
        Task<bool> StudentExistsAsync(int id);
    }
}
