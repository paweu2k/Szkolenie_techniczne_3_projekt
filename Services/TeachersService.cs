using System.Collections.Generic;
using System.Linq;
using Szkolenie_techniczne_3_projekt.Data;
using Szkolenie_techniczne_3_projekt.Models;
using Szkolenie_techniczne_3_projekt.Services.Interfaces;

namespace Szkolenie_techniczne_3_projekt.Services
{
    public class TeachersService : ITeachersService
    {

        private readonly ProjectDbContext _context;
        public TeachersService(ProjectDbContext context) { 
            _context = context; 
        }

        public int Delete(int id)
        {
            var teacher = _context.Teachers.Find(id);
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
            return id;
        }

        public Teachers Get(int id)
        {
            var teachers = _context.Teachers.Find(id);
            return teachers;
        }

        public List<Teachers> GetAll()
        {
            var teachers = _context.Teachers.ToList();
            return teachers;
        }

        public int Save(Teachers teachers)
        {
            _context.Teachers.Add(teachers);
            if(_context.SaveChanges() > 0)
            {
                System.Console.WriteLine("Zapisano");
            };
            return teachers.id;
        }

    }
}
