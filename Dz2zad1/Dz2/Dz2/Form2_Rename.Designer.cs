namespace Dz2
{
    partial class Form2_Rename
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1_logo = new System.Windows.Forms.TextBox();
            this.textBox1_password = new System.Windows.Forms.TextBox();
            this.textBox1_adres = new System.Windows.Forms.TextBox();
            this.textBox1_phone = new System.Windows.Forms.TextBox();
            this.comboBox1_Admin = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1_Ranem = new System.Windows.Forms.Button();
            this.button1_Delete = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_logo
            // 
            this.textBox1_logo.Location = new System.Drawing.Point(100, 121);
            this.textBox1_logo.Name = "textBox1_logo";
            this.textBox1_logo.Size = new System.Drawing.Size(176, 20);
            this.textBox1_logo.TabIndex = 0;
            // 
            // textBox1_password
            // 
            this.textBox1_password.Location = new System.Drawing.Point(100, 162);
            this.textBox1_password.Name = "textBox1_password";
            this.textBox1_password.Size = new System.Drawing.Size(176, 20);
            this.textBox1_password.TabIndex = 1;
            // 
            // textBox1_adres
            // 
            this.textBox1_adres.Location = new System.Drawing.Point(100, 206);
            this.textBox1_adres.Name = "textBox1_adres";
            this.textBox1_adres.Size = new System.Drawing.Size(176, 20);
            this.textBox1_adres.TabIndex = 2;
            // 
            // textBox1_phone
            // 
            this.textBox1_phone.Location = new System.Drawing.Point(100, 252);
            this.textBox1_phone.Name = "textBox1_phone";
            this.textBox1_phone.Size = new System.Drawing.Size(176, 20);
            this.textBox1_phone.TabIndex = 3;
            // 
            // comboBox1_Admin
            // 
            this.comboBox1_Admin.FormattingEnabled = true;
            this.comboBox1_Admin.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь"});
            this.comboBox1_Admin.Location = new System.Drawing.Point(100, 301);
            this.comboBox1_Admin.Name = "comboBox1_Admin";
            this.comboBox1_Admin.Size = new System.Drawing.Size(176, 21);
            this.comboBox1_Admin.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 42);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(12, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Admin*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Phone*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Address*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.button1_Ranem);
            this.panel2.Controls.Add(this.button1_Delete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 62);
            this.panel2.TabIndex = 24;
            // 
            // button1_Ranem
            // 
            this.button1_Ranem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_Ranem.FlatAppearance.BorderSize = 0;
            this.button1_Ranem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Ranem.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Ranem.ForeColor = System.Drawing.Color.White;
            this.button1_Ranem.Image = global::Dz2.Properties.Resources.Rename;
            this.button1_Ranem.Location = new System.Drawing.Point(86, 0);
            this.button1_Ranem.Name = "button1_Ranem";
            this.button1_Ranem.Size = new System.Drawing.Size(100, 59);
            this.button1_Ranem.TabIndex = 5;
            this.button1_Ranem.Text = "Изменить";
            this.button1_Ranem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1_Ranem.UseVisualStyleBackColor = true;
            // 
            // button1_Delete
            // 
            this.button1_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_Delete.FlatAppearance.BorderSize = 0;
            this.button1_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Delete.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Delete.ForeColor = System.Drawing.Color.White;
            this.button1_Delete.Image = global::Dz2.Properties.Resources.Delete;
            this.button1_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1_Delete.Location = new System.Drawing.Point(192, 0);
            this.button1_Delete.Name = "button1_Delete";
            this.button1_Delete.Size = new System.Drawing.Size(100, 59);
            this.button1_Delete.TabIndex = 6;
            this.button1_Delete.Text = "Удалить";
            this.button1_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1_Delete.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Dz2.Properties.Resources.form_delete;
            this.pictureBox3.Location = new System.Drawing.Point(297, 301);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dz2.Properties.Resources.form_rename;
            this.pictureBox2.Location = new System.Drawing.Point(12, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::Dz2.Properties.Resources.close22;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(330, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 19;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dz2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form2_Rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(369, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1_Admin);
            this.Controls.Add(this.textBox1_phone);
            this.Controls.Add(this.textBox1_adres);
            this.Controls.Add(this.textBox1_password);
            this.Controls.Add(this.textBox1_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2_Rename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2_Rename";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_logo;
        private System.Windows.Forms.TextBox textBox1_password;
        private System.Windows.Forms.TextBox textBox1_adres;
        private System.Windows.Forms.TextBox textBox1_phone;
        private System.Windows.Forms.ComboBox comboBox1_Admin;
        private System.Windows.Forms.Button button1_Ranem;
        private System.Windows.Forms.Button button1_Delete;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}