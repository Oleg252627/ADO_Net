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
    public partial class Form2_Rename : Form
    {
        private DataTable dataTable = null;
        private Form1 Form = null;
        private int number_Rows = 0;
        public Form2_Rename(Form1 form, DataTable table, int number)
        {
            InitializeComponent();
            Form = form;
            dataTable = table;
            number_Rows = number;
            this.button1_Ranem.Click += Button1_Ranem_Click;
            this.button1_Delete.Click += Button1_Delete_Click;
            this.textBox1_logo.Text = table.Rows[number][1].ToString();
            this.textBox1_password.Text = table.Rows[number][2].ToString();
            this.textBox1_adres.Text = table.Rows[number][3].ToString();
            this.textBox1_phone.Text = table.Rows[number][4].ToString();
            if (table.Rows[number][5].ToString() == "True")
            {
                comboBox1_Admin.SelectedIndex = 0;
            }
            else
            {
                comboBox1_Admin.SelectedIndex = 1;
            }
        }

        private void Button1_Delete_Click(object sender, EventArgs e)
        {
            dataTable.Rows[number_Rows].Delete();
            Form.Updete_teble(dataTable);
            this.DialogResult = DialogResult.OK;
        }

        private void Button1_Ranem_Click(object sender, EventArgs e)
        {
            if (textBox1_logo.Text == "" || textBox1_adres.Text == "" || textBox1_password.Text == "" ||
                textBox1_phone.Text == "")
            {
                MessageBox.Show("Заполните все поля для изменения!", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    if (dataTable.Rows[i][1].ToString().Equals(textBox1_logo.Text))
            //    {
            //        MessageBox.Show("В таблице такой ЛОГИН существует!", "Предупреждение", MessageBoxButtons.OK,
            //            MessageBoxIcon.Warning);
            //        return;
            //    }
            //}

            dataTable.Rows[number_Rows][1] = textBox1_logo.Text.ToString();
            dataTable.Rows[number_Rows][2] = textBox1_password.Text.ToString();
            dataTable.Rows[number_Rows][3] = textBox1_adres.Text.ToString();
            dataTable.Rows[number_Rows][4] = textBox1_phone.Text.ToString();
            if (comboBox1_Admin.SelectedIndex == 0)
            {
                dataTable.Rows[number_Rows][5] = "True";
            }
            else
            {
                dataTable.Rows[number_Rows][5] = "False";
            }
            Form.Updete_teble(dataTable);
            this.DialogResult = DialogResult.OK;
        }
    }
}
