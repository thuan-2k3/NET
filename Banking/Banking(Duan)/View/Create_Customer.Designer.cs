namespace Banking.View
{
    partial class Create_Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridViewcus = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.textcuspass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textcussdt = new System.Windows.Forms.TextBox();
            this.textcustp = new System.Windows.Forms.TextBox();
            this.textcusdc = new System.Windows.Forms.TextBox();
            this.textcusemail = new System.Windows.Forms.TextBox();
            this.textcustenkh = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textcusid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin tài khoản";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.textcusid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.dataGridViewcus);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.textcuspass);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textcussdt);
            this.panel1.Controls.Add(this.textcustp);
            this.panel1.Controls.Add(this.textcusdc);
            this.panel1.Controls.Add(this.textcusemail);
            this.panel1.Controls.Add(this.textcustenkh);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 526);
            this.panel1.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(303, 461);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 44);
            this.delete.TabIndex = 16;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // dataGridViewcus
            // 
            this.dataGridViewcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcus.Location = new System.Drawing.Point(33, 221);
            this.dataGridViewcus.Name = "dataGridViewcus";
            this.dataGridViewcus.RowHeadersWidth = 51;
            this.dataGridViewcus.RowTemplate.Height = 24;
            this.dataGridViewcus.Size = new System.Drawing.Size(678, 224);
            this.dataGridViewcus.TabIndex = 15;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(458, 461);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(99, 44);
            this.save.TabIndex = 14;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // textcuspass
            // 
            this.textcuspass.Location = new System.Drawing.Point(540, 143);
            this.textcuspass.Name = "textcuspass";
            this.textcuspass.Size = new System.Drawing.Size(171, 22);
            this.textcuspass.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mật khẩu";
            // 
            // textcussdt
            // 
            this.textcussdt.Location = new System.Drawing.Point(199, 129);
            this.textcussdt.Name = "textcussdt";
            this.textcussdt.Size = new System.Drawing.Size(145, 22);
            this.textcussdt.TabIndex = 11;
            // 
            // textcustp
            // 
            this.textcustp.Location = new System.Drawing.Point(540, 105);
            this.textcustp.Name = "textcustp";
            this.textcustp.Size = new System.Drawing.Size(171, 22);
            this.textcustp.TabIndex = 10;
            // 
            // textcusdc
            // 
            this.textcusdc.Location = new System.Drawing.Point(540, 68);
            this.textcusdc.Name = "textcusdc";
            this.textcusdc.Size = new System.Drawing.Size(171, 22);
            this.textcusdc.TabIndex = 9;
            // 
            // textcusemail
            // 
            this.textcusemail.Location = new System.Drawing.Point(199, 165);
            this.textcusemail.Name = "textcusemail";
            this.textcusemail.Size = new System.Drawing.Size(145, 22);
            this.textcusemail.TabIndex = 8;
            // 
            // textcustenkh
            // 
            this.textcustenkh.Location = new System.Drawing.Point(199, 91);
            this.textcustenkh.Name = "textcustenkh";
            this.textcustenkh.Size = new System.Drawing.Size(145, 22);
            this.textcustenkh.TabIndex = 7;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(616, 461);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(95, 44);
            this.close.TabIndex = 6;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thành phố";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Customer id";
            // 
            // textcusid
            // 
            this.textcusid.Location = new System.Drawing.Point(199, 55);
            this.textcusid.Name = "textcusid";
            this.textcusid.Size = new System.Drawing.Size(145, 22);
            this.textcusid.TabIndex = 18;
            // 
            // Create_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banking.Properties.Resources.istockphoto_2165303586_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "Create_Customer";
            this.Size = new System.Drawing.Size(898, 582);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textcussdt;
        private System.Windows.Forms.TextBox textcustp;
        private System.Windows.Forms.TextBox textcusdc;
        private System.Windows.Forms.TextBox textcusemail;
        private System.Windows.Forms.TextBox textcustenkh;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textcuspass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridViewcus;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textcusid;
        private System.Windows.Forms.Label label8;
    }
}