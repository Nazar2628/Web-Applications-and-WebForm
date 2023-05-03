using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DAL
{
    public class studentDAL
    {
        dbcon con;
        string constring= "Data Source=COGNINE-L30\\NEWDB;Initial Catalog=master;Integrated Security=True";
        
        public studentDAL() 
        {
            con = new dbcon(constring);
        }

        public bool StudentInsertDAL(students s)
        {
            string query = "insert into students values('" + s.Sid + "','" + s.Name + "','" + s.Email + "','" + s.Password + "','" + s.Age + "','" + s.University + "','" + s.Degree + "')";
            return con.UDI(query);
        }

        public bool StudentUpdateDAL(students s)
        {
            string query = "update students set name='" + s.Name + "',email='" + s.Email + "',password='" + s.Password + "',age='" + s.Age + "',university='" + s.University + "',degree='" + s.Degree + "' where sid='" + s.Sid + "'";
            return con.UDI(query);
        }

        public bool StudentDeleteDAL(students s)
        {
            string query = "delete from students where sid='" + s.Sid + "'";
            return con.UDI(query);
        }

        public DataTable StudentReadDAL(students s)
        {
            string query = "select * from students where sid='" + s.Sid + "'";
            return con.search(query);
        }

        public  DataTable StudentAllDAL(students s)
        {
            string query = "select * from students";
            return con.search(query);
        }
    }
}
