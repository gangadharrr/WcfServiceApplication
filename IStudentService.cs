using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceApplication.Models;

namespace WcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        void AddOrUpdateStudent(student studentq);
        [OperationContract]
        List<student> GetStudents();
        [OperationContract]
        student GetStudentById(int Id);
        [OperationContract]
        void DeleteStudentId(int Id);

    }
}
