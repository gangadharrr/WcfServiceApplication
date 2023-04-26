﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceApplication.Models;

namespace WcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        PracticeDatabaseEntities entitity=new PracticeDatabaseEntities();
        public List<Employee> GetDetails()
        {
            return entitity.Employees.ToList();
        }
        public void AddEmployee(Employee emp)
        {
             entitity.Employees.Add(emp);
            entitity.SaveChanges(); 
        }
    }
}
