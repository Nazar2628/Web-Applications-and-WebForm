using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
using DAL;
using System.Data;

namespace BLL
{
    public class StudentBLL
    {
        studentDAL stDAL = new studentDAL();

        public bool StudentInsertBLL(students s)
        {
            return stDAL.StudentInsertDAL(s);
        }

        public bool StudentUpdateBLL(students s)
        {
            return  stDAL.StudentUpdateDAL(s);
        }

        public bool StudentDeleteBLL(students s)
        {
            return stDAL.StudentDeleteDAL(s);
        }

        public DataTable StudentReadBLL(students s) 
        {
            return  stDAL.StudentReadDAL(s);
        }

        public DataTable StudentALLBLL(students s)
        {
            return stDAL.StudentAllDAL(s);
        }
    }
}
