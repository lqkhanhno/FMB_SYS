namespace FMB_SYS
{
    partial class frmBacknew
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbInformation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbError);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(76, 654);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1720, 300);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Báo lỗi";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(50, 60);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(96, 38);
            this.lbError.TabIndex = 0;
            this.lbError.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbInformation);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(76, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1720, 300);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbInformation.Location = new System.Drawing.Point(50, 60);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(96, 38);
            this.lbInformation.TabIndex = 0;
            this.lbInformation.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(136, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã xe";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.Location = new System.Drawing.Point(976, 204);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(150, 65);
            this.btnEnter.TabIndex = 24;
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
            this.btnOut.TabIndex = 23;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(276, 204);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(650, 65);
            this.txtID.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBacknew
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOut;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.txtID);
            this.Name = "frmBacknew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBacknew";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Timer timer1;
    }
}