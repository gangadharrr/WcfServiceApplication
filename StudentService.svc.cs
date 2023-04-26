using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceApplication.Models;

namespace WcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        public StudentDBEntities1 entity = new StudentDBEntities1();
        public void AddOrUpdateStudent(Student student)
        {
            entity.Students.AddOrUpdate(student); 
            entity.SaveChanges();
        }
        public List<Student> GetStudents() 
        {
            return entity.Students.ToList();
        }
        public Student GetStudentById(int Id) 
        {
            return entity.Students.Find(Id);
        }
        public void DeleteStudentId(int Id) 
        {
             entity.Students.Remove(GetStudentById(Id));
        } 
    }
}
