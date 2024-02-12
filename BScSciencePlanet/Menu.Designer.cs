namespace BScSciencePlanet
{
    partial class Menu
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.addnew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnPhysics = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnbio = new System.Windows.Forms.Button();
            this.btntech = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.coder = new System.Windows.Forms.PictureBox();
            this.teacher = new System.Windows.Forms.PictureBox();
            this.engineer = new System.Windows.Forms.PictureBox();
            this.doctor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(501, 79);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(607, 654);
            this.dgv1.TabIndex = 0;
            this.dgv1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_RowHeaderMouseDoubleClick);
            // 
            // addnew
            // 
            this.addnew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addnew.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnew.ForeColor = System.Drawing.SystemColors.InfoText;
            this.addnew.Location = new System.Drawing.Point(12, 175);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(259, 37);
            this.addnew.TabIndex = 1;
            this.addnew.Tag = "3";
            this.addnew.Text = "Add New Student";
            this.addnew.UseVisualStyleBackColor = false;
            this.addnew.Click += new System.EventHandler(this.Showdetails_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1109, 83);
            this.label1.TabIndex = 2;
            this.label1.Text = "BSC Science Planet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(0, 731);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1109, 46);
            this.label3.TabIndex = 35;
            this.label3.Text = "Continuous practice and unremitting effort is the way to success...!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(11, 238);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(259, 37);
            this.update.TabIndex = 36;
            this.update.Tag = "4";
            this.update.Text = "Update Student Details";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(8, 304);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(263, 37);
            this.delete.TabIndex = 37;
            this.delete.Tag = "5";
            this.delete.Text = "Delete Student Details";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtsearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(125, 114);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(360, 27);
            this.txtsearch.TabIndex = 42;
            this.txtsearch.Tag = "2";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsearch.ImageKey = "(none)";
            this.btnsearch.Location = new System.Drawing.Point(11, 108);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(108, 37);
            this.btnsearch.TabIndex = 43;
            this.btnsearch.Tag = "1";
            this.btnsearch.Text = "Search";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnPhysics
            // 
            this.btnPhysics.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPhysics.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhysics.Location = new System.Drawing.Point(12, 372);
            this.btnPhysics.Name = "btnPhysics";
            this.btnPhysics.Size = new System.Drawing.Size(259, 37);
            this.btnPhysics.TabIndex = 46;
            this.btnPhysics.Tag = "6";
            this.btnPhysics.Text = "Physical Science Student Details";
            this.btnPhysics.UseVisualStyleBackColor = false;
            this.btnPhysics.Click += new System.EventHandler(this.btnPhysics_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(12, 567);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(210, 37);
            this.btncancel.TabIndex = 47;
            this.btncancel.Tag = "9";
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnbio
            // 
            this.btnbio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbio.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbio.Location = new System.Drawing.Point(12, 438);
            this.btnbio.Name = "btnbio";
            this.btnbio.Size = new System.Drawing.Size(255, 37);
            this.btnbio.TabIndex = 48;
            this.btnbio.Tag = "7";
            this.btnbio.Text = "Biological Science Student Details";
            this.btnbio.UseVisualStyleBackColor = false;
            this.btnbio.Click += new System.EventHandler(this.btnbio_Click);
            // 
            // btntech
            // 
            this.btntech.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntech.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntech.Location = new System.Drawing.Point(12, 502);
            this.btntech.Name = "btntech";
            this.btntech.Size = new System.Drawing.Size(255, 37);
            this.btntech.TabIndex = 49;
            this.btntech.Tag = "8";
            this.btntech.Text = "Technology Student Details";
            this.btntech.UseVisualStyleBackColor = false;
            this.btntech.Click += new System.EventHandler(this.btntech_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::BScSciencePlanet.Properties.Resources.search__1_;
            this.pictureBox2.Location = new System.Drawing.Point(85, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // coder
            // 
            this.coder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.coder.Image = global::BScSciencePlanet.Properties.Resources.developer;
            this.coder.Location = new System.Drawing.Point(284, 578);
            this.coder.Name = "coder";
            this.coder.Size = new System.Drawing.Size(106, 88);
            this.coder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coder.TabIndex = 41;
            this.coder.TabStop = false;
            // 
            // teacher
            // 
            this.teacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.teacher.Image = global::BScSciencePlanet.Properties.Resources.teacher;
            this.teacher.Location = new System.Drawing.Point(284, 438);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(114, 105);
            this.teacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacher.TabIndex = 40;
            this.teacher.TabStop = false;
            // 
            // engineer
            // 
            this.engineer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.engineer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.engineer.Image = global::BScSciencePlanet.Properties.Resources.architec;
            this.engineer.Location = new System.Drawing.Point(381, 506);
            this.engineer.Name = "engineer";
            this.engineer.Size = new System.Drawing.Size(102, 98);
            this.engineer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.engineer.TabIndex = 39;
            this.engineer.TabStop = false;
            this.engineer.Click += new System.EventHandler(this.engineer_Click);
            // 
            // doctor
            // 
            this.doctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doctor.Image = global::BScSciencePlanet.Properties.Resources.doctor;
            this.doctor.Location = new System.Drawing.Point(371, 633);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(112, 90);
            this.doctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doctor.TabIndex = 38;
            this.doctor.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::BScSciencePlanet.Properties.Resources.PNG____BSC_SCIENCE_PLANET_LOGO_BY_PIRAGALANATHAN;
            this.pictureBox1.Location = new System.Drawing.Point(297, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1109, 777);
            this.Controls.Add(this.btntech);
            this.Controls.Add(this.btnbio);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnPhysics);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.coder);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.engineer);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addnew);
            this.Controls.Add(this.dgv1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button addnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.PictureBox doctor;
        private System.Windows.Forms.PictureBox engineer;
        private System.Windows.Forms.PictureBox teacher;
        private System.Windows.Forms.PictureBox coder;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPhysics;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnbio;
        private System.Windows.Forms.Button btntech;
    }
}