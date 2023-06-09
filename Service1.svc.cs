﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceApplication.Models;

namespace WcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public List<LMS_BOOK_DETAILS> GetBooks()
        {
            Learning_Management_SystemEntities lmsEntity=new Learning_Management_SystemEntities();
            List<LMS_BOOK_DETAILS> ListBooks= lmsEntity.LMS_BOOK_DETAILS.ToList();
            foreach (var item in ListBooks)
            {
                Console.WriteLine(item.SUPPLIER_ID);
            }
            
            return ListBooks;

        }
        public List<student> GetStd()
        {
            mouleasDBEntities mDBEntity=new mouleasDBEntities();
            return mDBEntity.students.ToList();
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
