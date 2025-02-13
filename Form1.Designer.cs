namespace ASP_task1
{
    partial class student_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label_StudentId = new Label();
            label_StudentName = new Label();
            button_Search = new Button();
            button_Cancel = new Button();
            textbox_StudentId = new TextBox();
            textbox_StudentName = new TextBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vitalik_nqyK3NuwC6E_unsplash;
            pictureBox1.Location = new Point(68, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label_StudentId
            // 
            label_StudentId.AutoSize = true;
            label_StudentId.ForeColor = Color.Indigo;
            label_StudentId.Location = new Point(368, 159);
            label_StudentId.Name = "label_StudentId";
            label_StudentId.Size = new Size(98, 17);
            label_StudentId.TabIndex = 1;
            label_StudentId.Text = "Student ID";
            // 
            // label_StudentName
            // 
            label_StudentName.AutoSize = true;
            label_StudentName.Location = new Point(368, 226);
            label_StudentName.Name = "label_StudentName";
            label_StudentName.Size = new Size(116, 17);
            label_StudentName.TabIndex = 2;
            label_StudentName.Text = "Student Name";
            // 
            // button_Search
            // 
            button_Search.Location = new Point(368, 323);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(94, 29);
            button_Search.TabIndex = 3;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(551, 323);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(94, 29);
            button_Cancel.TabIndex = 4;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // textbox_StudentId
            // 
            textbox_StudentId.Location = new Point(368, 179);
            textbox_StudentId.Name = "textbox_StudentId";
            textbox_StudentId.PlaceholderText = "1234";
            textbox_StudentId.Size = new Size(277, 26);
            textbox_StudentId.TabIndex = 5;
            // 
            // textbox_StudentName
            // 
            textbox_StudentName.Location = new Point(368, 246);
            textbox_StudentName.Name = "textbox_StudentName";
            textbox_StudentName.PlaceholderText = "Ola Nordnann";
            textbox_StudentName.Size = new Size(277, 26);
            textbox_StudentName.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(402, 416);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(197, 17);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Contact Administrator";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // student_Login
            // 
            AcceptButton = button_Search;
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            CancelButton = button_Cancel;
            ClientSize = new Size(736, 513);
            Controls.Add(linkLabel1);
            Controls.Add(textbox_StudentName);
            Controls.Add(textbox_StudentId);
            Controls.Add(button_Cancel);
            Controls.Add(button_Search);
            Controls.Add(label_StudentName);
            Controls.Add(label_StudentId);
            Controls.Add(pictureBox1);
            Font = new Font("Miriam Mono CLM", 9F, FontStyle.Regular, GraphicsUnit.Point, 177);
            ForeColor = Color.Indigo;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "student_Login";
            Text = "Student Enrollment Search";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label_StudentId;
        private Label label_StudentName;
        private Button button_Search;
        private Button button_Cancel;
        private TextBox textbox_StudentId;
        private TextBox textbox_StudentName;
        private LinkLabel linkLabel1;
    }
}
