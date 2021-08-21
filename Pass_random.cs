using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Passwarder
{
    public partial class Pass_random : Form
    {
        readonly string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Projects\Passwarder\Passdata.mdf;Integrated Security=True";

        string Userstring;
        public Pass_random()
        {
            InitializeComponent();
        }
        public void Numberget(string Numberb)
        {
            Userstring = Numberb.ToString();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
