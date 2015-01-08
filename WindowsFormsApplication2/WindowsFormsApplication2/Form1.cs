using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.VastariAPIServiceClient client = new ServiceReference1.VastariAPIServiceClient();
            var response = client.Login("yusuke", "shibainu48");
            if (response != null && !string.IsNullOrEmpty(response.UserName))
            {
                MessageBox.Show("login suceess");
            }
            else
            {
                MessageBox.Show("fail");
            }
        }
    }
}
