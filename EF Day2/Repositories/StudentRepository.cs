using System.Collections.Generic;
using System.Linq;
using WinForms_EF_CF.Data;
using WinForms_EF_CF.Models;

namespace WinForms_EF_CF.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly UniversityContext _context;

        public StudentRepository()
        {
            _context = new UniversityContext();
            _context.Database.EnsureCreated();
        }

        public IEnumerable<Student> GetAll() => _context.Students.ToList();

        public Student GetById(int id) => _context.Students.Find(id);

        public void Add(Student entity)
        {
            _context.Students.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Student entity)
        {
            _context.Students.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
