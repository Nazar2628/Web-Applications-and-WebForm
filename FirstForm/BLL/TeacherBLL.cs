using AppProps;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TeacherBLL
    {
        teacherDAL stDAL = new teacherDAL();

        public bool TeacherInsertBLL(teachers s)
        {
            return stDAL.TeacherInsertDAL(s);
        }

        public bool TeacherUpdateBLL(teachers s)
        {
            return stDAL.TeacherUpdateDAL(s);
        }

        public bool TeacherDeleteBLL(teachers s)
        {
            return stDAL.TeacherDeleteDAL(s);
        }

        public DataTable TeacherReadBLL(teachers s)
        {
            return stDAL.TeacherReadDAL(s);
        }

        public DataTable TeacherALLBLL(teachers s)
        {
            return stDAL.TeacherAllDAL(s);
        }
    }
}
