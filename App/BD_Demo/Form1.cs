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

namespace BD_Demo
{
    public partial class Form1 : Form
    {
        public SqlConnection sqlConnection;
        public Form1()
        {
            try
            {
                sqlConnection = new SqlConnection(@"Data Source=DBSRV\DEMO;Initial Catalog=DemoVolhinMP007sb1;Integrated Security=True");

                sqlConnection.Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());

            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(@"Data Source=DBSRV\DEMO;Initial Catalog=DemoVolhinMP007sb1;Integrated Security=True");

                sqlConnection.Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());

            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }           
            }
        }

    }
}
