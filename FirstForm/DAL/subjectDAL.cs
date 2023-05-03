using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class subjectDAL
    {
        dbcon con;
        string constring= "Data Source=COGNINE-L30\\NEWDB;Initial Catalog=master;Integrated Security=True";

        public subjectDAL()
        {
            con = new dbcon(constring);
        }

        public bool SubjectInsertDAL(subjects s)
        {
            string query = "insert into subjects values('" + s.Sid + "','" + s.Sname + "','" + s.Cr + "','" + s.Degree + "','" + s.Marks + "')";
            return con.UDI(query);
        }

        public bool SubjectUpdateDAL(subjects s)
        {
            string query = "update subjects set name='" + s.Sname + "',cr='" + s.Cr + "',degree='" + s.Degree + "',marks='" + s.Marks + "' where sid='" + s.Sid + "'";
            return con.UDI(query);
        }

        public bool SubjectDeleteDAL(subjects s)
        {
            string query = "delete from subjects where sid='" + s.Sid + "'";
            return con.UDI(query);
        }

        public DataTable SubjectReadDAL(subjects s)
        {
            string query = "select * from subjects where sid='" + s.Sid + "'";
            return con.search(query);
        }

        public DataTable SubjectAllDAL(subjects s)
        {
            string query = "select * from subjects";
            return con.search(query);
        }
    }
}
