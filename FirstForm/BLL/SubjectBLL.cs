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
    public class SubjectBLL
    {
        subjectDAL stDAL = new subjectDAL();

        public bool SubjectInsertBLL(subjects s)
        {
            return stDAL.SubjectInsertDAL(s);
        }

        public bool SubjectUpdateBLL(subjects s)
        {
            return stDAL.SubjectUpdateDAL(s);
        }

        public bool SubjectDeleteBLL(subjects s)
        {
            return stDAL.SubjectDeleteDAL(s);
        }

        public DataTable SubjectReadBLL(subjects s)
        {
            return stDAL.SubjectReadDAL(s);
        }

        public DataTable SubjectALLBLL(subjects s)
        {
            return stDAL.SubjectAllDAL(s);
        }
    }
}
