namespace Banking.View
{
    partial class Create_Account
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImport_Click = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addacc = new System.Windows.Forms.Button();
            this.textidcus = new System.Windows.Forms.TextBox();
            this.textdate = new System.Windows.Forms.TextBox();
            this.textbalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textidacc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnImport_Click);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.addacc);
            this.panel1.Controls.Add(this.textidcus);
            this.panel1.Controls.Add(this.textdate);
            this.panel1.Controls.Add(this.textbalance);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textidacc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 551);
            this.panel1.TabIndex = 0;
            // 
            // btnImport_Click
            // 
            this.btnImport_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport_Click.Location = new System.Drawing.Point(178, 463);
            this.btnImport_Click.Name = "btnImport_Click";
            this.btnImport_Click.Size = new System.Drawing.Size(90, 53);
            this.btnImport_Click.TabIndex = 18;
            this.btnImport_Click.Text = "import";
            this.btnImport_Click.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(609, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(128, 405);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(475, 27);
            this.txtFilePath.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "File name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 147);
            this.dataGridView1.TabIndex = 12;
            // 
            // addacc
            // 
            this.addacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addacc.Location = new System.Drawing.Point(444, 463);
            this.addacc.Name = "addacc";
            this.addacc.Size = new System.Drawing.Size(147, 53);
            this.addacc.TabIndex = 11;
            this.addacc.Text = "Tạo tài khoản";
            this.addacc.UseVisualStyleBackColor = true;
            this.addacc.Click += new System.EventHandler(this.addacc_Click);
            // 
            // textidcus
            // 
            this.textidcus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textidcus.Location = new System.Drawing.Point(356, 107);
            this.textidcus.Name = "textidcus";
            this.textidcus.Size = new System.Drawing.Size(310, 30);
            this.textidcus.TabIndex = 8;
            // 
            // textdate
            // 
            this.textdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdate.Location = new System.Drawing.Point(356, 149);
            this.textdate.Name = "textdate";
            this.textdate.Size = new System.Drawing.Size(310, 30);
            this.textdate.TabIndex = 7;
            // 
            // textbalance
            // 
            this.textbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbalance.Location = new System.Drawing.Point(356, 194);
            this.textbalance.Name = "textbalance";
            this.textbalance.Size = new System.Drawing.Size(310, 30);
            this.textbalance.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số dư";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày mở thẻ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã tài khoản";
            // 
            // textidacc
            // 
            this.textidacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textidacc.Location = new System.Drawing.Point(356, 67);
            this.textidacc.Name = "textidacc";
            this.textidacc.Size = new System.Drawing.Size(310, 30);
            this.textidacc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo tài khoản ngân hàng";
            // 
            // Create_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banking.Properties.Resources.istockphoto_2165303586_612x612;
            this.Controls.Add(this.panel1);
            this.Name = "Create_Account";
            this.Size = new System.Drawing.Size(908, 648);
            this.Load += new System.EventHandler(this.Create_Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textidacc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textidcus;
        private System.Windows.Forms.TextBox textdate;
        private System.Windows.Forms.TextBox textbalance;
        private System.Windows.Forms.Button addacc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImport_Click;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFilePath;
        //private ADGV.AdvancedDataGridView adDataGridViewacc;
    }
}