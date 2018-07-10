using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz2
{
    public partial class Form2_Add : Form
    {
        private DataTable dataTable = null;
        private Form1 Form = null;
        private int number_Rows = 0;
        public Form2_Add(Form1 form, DataTable table, int number)
        {
            InitializeComponent();
            dataTable = table;
            Form = form;
            number_Rows = number;
            button1_Add.Click += Button1_Add_Click;
            bunifuImageButton1.Click += BunifuImageButton1_Click;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Add_Click(object sender, EventArgs e)
        {
            if (textBox1_logo.Text == "" || textBox1_adres.Text == "" || textBox1_password.Text == "" ||
                textBox1_phone.Text == "")
            {
                MessageBox.Show("Заполните все поля для изменения!", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][1].ToString().Equals(textBox1_logo.Text))
                {
                    MessageBox.Show("В таблице такой ЛОГИН существует!", "Предупреждение", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }
            DataRow row = dataTable.NewRow();
            row["Id"] = number_Rows;
            row["Loginn"] = textBox1_logo.Text;
            row["Passwordd"] = textBox1_password.Text;
            row["Adres"] = textBox1_adres.Text;
            row["Telefon"] = textBox1_phone.Text;
            if (comboBox1_Admin.SelectedIndex == 0)
            {
                row["Administrator"] = "True";
            }
            else
            {
                row["Administrator"] = "False";
            }

            dataTable.Rows.Add(row);
            Form.Updete_teble(dataTable);
            this.DialogResult = DialogResult.OK;
        }
    }
}
