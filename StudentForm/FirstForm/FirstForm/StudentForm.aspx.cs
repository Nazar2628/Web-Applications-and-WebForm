using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppProps;
using BLL;

namespace FirstForm
{
    public partial class StudentForm : System.Web.UI.Page
    {
        StudentBLL sBLL = new StudentBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void s_inserted(object sender, EventArgs e)
        {
            students st = new students();
            st.Sid = id.Text;
            st.Name = sname.Text;
            st.Email= email.Text;
            st.Password = pass.Text;
            st.Age = age.Text;
            st.University=uni.Text;
            st.Degree=Degree.Text;

            if (sBLL.StudentInsertBLL(st))
                status.Text = "Insert was Successful";
            else
                status.Text = "Insert was Not Successful";



        }

        protected void s_updated(object sender, EventArgs e)
        {
            students st = new students();
            st.Sid = id.Text;
            st.Name = sname.Text;
            st.Email = email.Text;
            st.Password = pass.Text;
            st.Age = age.Text;
            st.University = uni.Text;
            st.Degree = Degree.Text;

            if (sBLL.StudentUpdateBLL(st))
                status.Text = "Update was Successful";
            else
                status.Text = "Update was Not Successful";

        }

        protected void s_deleted(object sender, EventArgs e)
        {
            students st = new students();
            st.Sid = id.Text;
            st.Name = sname.Text;
            st.Email = email.Text;
            st.Password = pass.Text;
            st.Age = age.Text;
            st.University = uni.Text;
            st.Degree = Degree.Text;

            if (sBLL.StudentDeleteBLL(st))
                status.Text = "Delete was Successful";
            else
                status.Text = "Delete was Not Successful";
        }

        protected void s_read(object sender, EventArgs e)
        {
            students st = new students();
            st.Sid = id.Text;
            DataTable dt = new DataTable();
            dt=sBLL.StudentReadBLL(st);

            if(dt.Rows.Count > 0)
            {
                status.Text = "Read was Successful";
                sname.Text= dt.Rows[0]["name"].ToString();
                email.Text= dt.Rows[0]["email"].ToString();
                pass.Text= dt.Rows[0]["password"].ToString();
                age.Text= dt.Rows[0]["age"].ToString();
                uni.Text= dt.Rows[0]["university"].ToString();
                Degree.Text= dt.Rows[0]["degree"].ToString();
            }
            else
            {
                status.Text = "Read was Not Successful ";
            }
        }

        protected void s_all(object sender, EventArgs e)
        {
            students st = new students();
            st.Sid = id.Text;
            DataTable dt = new DataTable();
            dt=sBLL.StudentALLBLL(st);
            s_grid.DataSource = dt;
            s_grid.DataBind();

        }
    }
}