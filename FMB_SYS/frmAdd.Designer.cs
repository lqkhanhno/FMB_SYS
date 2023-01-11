namespace FMB_SYS
{
    partial class frmAdd
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbInformation = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbError = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.Location = new System.Drawing.Point(978, 227);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(150, 65);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.Red;
            this.btnOut.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOut.Location = new System.Drawing.Point(1550, 25);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(300, 100);
            this.btnOut.TabIndex = 11;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(278, 227);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(650, 65);
            this.txtID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã xe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbInformation);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(88, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1720, 300);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbInformation.Location = new System.Drawing.Point(50, 60);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(76, 46);
            this.lbInformation.TabIndex = 0;
            this.lbInformation.Text = "____";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbError);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(88, 681);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1720, 300);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Báo lỗi";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(50, 60);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(90, 46);
            this.lbError.TabIndex = 0;
            this.lbError.Text = "_____";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(1157, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 242);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 92);
            this.label2.TabIndex = 0;
            this.label2.Text = "B1: Quét mã xe \r\nB2: Quét mã lab";
            // 
            // frmAdd
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOut;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.txtID);
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
    }
}