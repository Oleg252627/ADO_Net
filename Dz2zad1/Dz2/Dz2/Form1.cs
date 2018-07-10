using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Dz2
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter da = null;
        private DataSet set = null;
        SqlCommandBuilder command=null;
        private DataTable ds = null;
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            listView1.MouseDoubleClick += ListView1_MouseDoubleClick;
            button1_Add.Click += Button1_Add_Click;
            this.bunifuImageButton1.Click += BunifuImageButton1_Click;
            Show_Baze();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Add_Click(object sender, EventArgs e)
        {
           Form2_Add A=new Form2_Add(this,ds,count);
            if (A.ShowDialog() == DialogResult.OK)
            {
                Show_Baze();
            }
        }

        private void Show_Baze()
        {
            count = 0;
            listView1.Items.Clear();
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string sqlzaproc = "SELECT * FROM Polzovateli WHERE Administrator = 1";
            set = new DataSet();
            da = new SqlDataAdapter(sqlzaproc, connection);
            command = new SqlCommandBuilder(da);
            da.Fill(set);
            ds = set.Tables[0];
            string[] row = new string[ds.Columns.Count];
            ListViewItem itm;
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                count++;
                for (int j = 0; j < ds.Columns.Count; j++)
                {
                    row[j] = ds.Rows[i][j].ToString();
                }
                itm = new ListViewItem(row);
                listView1.Items.Add(itm);

            }
        }
        public void Updete_teble(DataTable table)
        {
            set = table.DataSet;
            da.Update(set);
        }

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Form2_Rename A=new Form2_Rename(this,ds,listView1.FocusedItem.Index);
                if (A.ShowDialog() == DialogResult.OK)
                {
                    Show_Baze();
                }
            }
        }
    }
}
