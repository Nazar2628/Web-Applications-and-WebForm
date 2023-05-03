using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class teacherDAL
    {
        dbcon con;
        string constring= "Data Source=COGNINE-L30\\NEWDB;Initial Catalog=master;Integrated Security=True";

        public teacherDAL()
        {
            con = new dbcon(constring);
        }

        public bool TeacherInsertDAL(teachers s)
        {
            string query = "insert into teachers values('" + s.Tid + "','" + s.Name + "','" + s.Email + "','" + s.Password + "','" + s.Age + "','" + s.University + "','" + s.Degree + "')";
            return con.UDI(query);
        }

        public bool TeacherUpdateDAL(teachers s)
        {
            string query = "update teachers set name='" + s.Name + "',email='" + s.Email + "',password='" + s.Password + "',age='" + s.Age + "',university='" + s.University + "',degree='" + s.Degree + "' where sid='" + s.Tid + "'";
            return con.UDI(query);
        }

        public bool TeacherDeleteDAL(teachers s)
        {
            string query = "delete from teachers where sid='" + s.Tid + "'";
            return con.UDI(query);
        }

        public DataTable TeacherReadDAL(teachers s)
        {
            string query = "select * from teachers where sid='" + s.Tid + "'";
            return con.search(query);
        }

        public DataTable TeacherAllDAL(teachers s)
        {
            string query = "select * from teachers";
            return con.search(query);
        }
    }
}
