using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class loginform : Form
    {
        
        
        public loginform()
        {
            InitializeComponent();
        }

        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string sql = @"select * from userinfo where id = '" + this.txtid.Text + "' and password = '" + this.txtpassword.Text + "';";

            DataAccess da = new DataAccess();//Connecting DB
            DataSet ds = da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Login approved for " + ds.Tables[0].Rows[0][1].ToString());
                OrderForm of = new OrderForm();
                of.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Invalid");
            }

        }


    }
}
