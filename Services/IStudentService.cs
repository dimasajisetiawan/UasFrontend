using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>>GetAll();
        Task<Student> GetById(int id);

        Task Delete(int id);

        Task<Student> Add(Student student);

        Task<Student> Update(Student student);
    }
}