namespace WindowsFormsApp3
{
    partial class Form1
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtstdname2 = new System.Windows.Forms.TextBox();
            this.txtenrolled2 = new System.Windows.Forms.TextBox();
            this.txtstartdate = new System.Windows.Forms.TextBox();
            this.txtstdname1 = new System.Windows.Forms.TextBox();
            this.txtenrolled1 = new System.Windows.Forms.TextBox();
            this.txtcoursename2 = new System.Windows.Forms.TextBox();
            this.txtclasstype = new System.Windows.Forms.TextBox();
            this.txtcoursenumber = new System.Windows.Forms.ComboBox();
            this.txtdateTime1 = new System.Windows.Forms.DateTimePicker();
            this.txtradioButton1 = new System.Windows.Forms.RadioButton();
            this.txtradioButton2 = new System.Windows.Forms.RadioButton();
            this.txtset = new System.Windows.Forms.Button();
            this.txtget = new System.Windows.Forms.Button();
            this.txtexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "no. of courses enrolled";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Class Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "No. of courses taken";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Student Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(774, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Class Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(774, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Course Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(774, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Class Type";
            // 
            // txtstdname2
            // 
            this.txtstdname2.Location = new System.Drawing.Point(1127, 133);
            this.txtstdname2.Name = "txtstdname2";
            this.txtstdname2.Size = new System.Drawing.Size(100, 26);
            this.txtstdname2.TabIndex = 10;
            // 
            // txtenrolled2
            // 
            this.txtenrolled2.Location = new System.Drawing.Point(1127, 50);
            this.txtenrolled2.Name = "txtenrolled2";
            this.txtenrolled2.Size = new System.Drawing.Size(100, 26);
            this.txtenrolled2.TabIndex = 11;
            // 
            // txtstartdate
            // 
            this.txtstartdate.Location = new System.Drawing.Point(1127, 219);
            this.txtstartdate.Name = "txtstartdate";
            this.txtstartdate.Size = new System.Drawing.Size(100, 26);
            this.txtstartdate.TabIndex = 12;
            // 
            // txtstdname1
            // 
            this.txtstdname1.Location = new System.Drawing.Point(252, 120);
            this.txtstdname1.Name = "txtstdname1";
            this.txtstdname1.Size = new System.Drawing.Size(100, 26);
            this.txtstdname1.TabIndex = 13;
            // 
            // txtenrolled1
            // 
            this.txtenrolled1.Location = new System.Drawing.Point(252, 47);
            this.txtenrolled1.Name = "txtenrolled1";
            this.txtenrolled1.Size = new System.Drawing.Size(100, 26);
            this.txtenrolled1.TabIndex = 14;
            // 
            // txtcoursename2
            // 
            this.txtcoursename2.Location = new System.Drawing.Point(1127, 309);
            this.txtcoursename2.Name = "txtcoursename2";
            this.txtcoursename2.Size = new System.Drawing.Size(100, 26);
            this.txtcoursename2.TabIndex = 15;
            this.txtcoursename2.TextChanged += new System.EventHandler(this.txtcoursename2_TextChanged);
            // 
            // txtclasstype
            // 
            this.txtclasstype.Location = new System.Drawing.Point(1127, 414);
            this.txtclasstype.Name = "txtclasstype";
            this.txtclasstype.Size = new System.Drawing.Size(100, 26);
            this.txtclasstype.TabIndex = 16;
            // 
            // txtcoursenumber
            // 
            this.txtcoursenumber.FormattingEnabled = true;
            this.txtcoursenumber.Location = new System.Drawing.Point(252, 307);
            this.txtcoursenumber.Name = "txtcoursenumber";
            this.txtcoursenumber.Size = new System.Drawing.Size(121, 28);
            this.txtcoursenumber.TabIndex = 17;
            // 
            // txtdateTime1
            // 
            this.txtdateTime1.Location = new System.Drawing.Point(252, 220);
            this.txtdateTime1.Name = "txtdateTime1";
            this.txtdateTime1.Size = new System.Drawing.Size(200, 26);
            this.txtdateTime1.TabIndex = 18;
            // 
            // txtradioButton1
            // 
            this.txtradioButton1.AutoSize = true;
            this.txtradioButton1.Location = new System.Drawing.Point(252, 415);
            this.txtradioButton1.Name = "txtradioButton1";
            this.txtradioButton1.Size = new System.Drawing.Size(79, 24);
            this.txtradioButton1.TabIndex = 19;
            this.txtradioButton1.TabStop = true;
            this.txtradioButton1.Text = "Hybrid";
            this.txtradioButton1.UseVisualStyleBackColor = true;
            // 
            // txtradioButton2
            // 
            this.txtradioButton2.AutoSize = true;
            this.txtradioButton2.Location = new System.Drawing.Point(456, 413);
            this.txtradioButton2.Name = "txtradioButton2";
            this.txtradioButton2.Size = new System.Drawing.Size(88, 24);
            this.txtradioButton2.TabIndex = 20;
            this.txtradioButton2.TabStop = true;
            this.txtradioButton2.Text = "In class";
            this.txtradioButton2.UseVisualStyleBackColor = true;
            // 
            // txtset
            // 
            this.txtset.Location = new System.Drawing.Point(252, 550);
            this.txtset.Name = "txtset";
            this.txtset.Size = new System.Drawing.Size(79, 39);
            this.txtset.TabIndex = 21;
            this.txtset.Text = "Set";
            this.txtset.UseVisualStyleBackColor = true;
            this.txtset.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtget
            // 
            this.txtget.Location = new System.Drawing.Point(854, 550);
            this.txtget.Name = "txtget";
            this.txtget.Size = new System.Drawing.Size(84, 39);
            this.txtget.TabIndex = 22;
            this.txtget.Text = "Get";
            this.txtget.UseVisualStyleBackColor = true;
            this.txtget.Click += new System.EventHandler(this.txtget_Click);
            // 
            // txtexit
            // 
            this.txtexit.Location = new System.Drawing.Point(566, 682);
            this.txtexit.Name = "txtexit";
            this.txtexit.Size = new System.Drawing.Size(86, 32);
            this.txtexit.TabIndex = 23;
            this.txtexit.Text = "Exit";
            this.txtexit.UseVisualStyleBackColor = true;
            this.txtexit.Click += new System.EventHandler(this.txtexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 759);
            this.Controls.Add(this.txtexit);
            this.Controls.Add(this.txtget);
            this.Controls.Add(this.txtset);
            this.Controls.Add(this.txtradioButton2);
            this.Controls.Add(this.txtradioButton1);
            this.Controls.Add(this.txtdateTime1);
            this.Controls.Add(this.txtcoursenumber);
            this.Controls.Add(this.txtclasstype);
            this.Controls.Add(this.txtcoursename2);
            this.Controls.Add(this.txtenrolled1);
            this.Controls.Add(this.txtstdname1);
            this.Controls.Add(this.txtstartdate);
            this.Controls.Add(this.txtenrolled2);
            this.Controls.Add(this.txtstdname2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtclasstype;
        private System.Windows.Forms.TextBox txtcoursename2;
        private System.Windows.Forms.TextBox txtenrolled1;
        private System.Windows.Forms.TextBox txtstdname1;
        private System.Windows.Forms.TextBox txtstartdate;
        private System.Windows.Forms.TextBox txtenrolled2;
        private System.Windows.Forms.TextBox txtstdname2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton txtradioButton2;
        private System.Windows.Forms.RadioButton txtradioButton1;
        private System.Windows.Forms.DateTimePicker txtdateTime1;
        private System.Windows.Forms.ComboBox txtcoursenumber;
        private System.Windows.Forms.Button txtexit;
        private System.Windows.Forms.Button txtget;
        private System.Windows.Forms.Button txtset;
    }
}

