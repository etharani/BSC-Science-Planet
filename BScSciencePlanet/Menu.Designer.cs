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
            this.labeltittle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.coder = new System.Windows.Forms.PictureBox();
            this.teacher = new System.Windows.Forms.PictureBox();
            this.engineer = new System.Windows.Forms.PictureBox();
            this.doctor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(0, 251);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(1108, 477);
            this.dgv1.TabIndex = 0;
            this.dgv1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_RowHeaderMouseDoubleClick);
            // 
            // addnew
            // 
            this.addnew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addnew.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnew.ForeColor = System.Drawing.SystemColors.InfoText;
            this.addnew.Location = new System.Drawing.Point(237, 130);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(169, 37);
            this.addnew.TabIndex = 1;
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
            // labeltittle
            // 
            this.labeltittle.AutoSize = true;
            this.labeltittle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltittle.Location = new System.Drawing.Point(401, 83);
            this.labeltittle.Name = "labeltittle";
            this.labeltittle.Size = new System.Drawing.Size(254, 35);
            this.labeltittle.TabIndex = 6;
            this.labeltittle.Text = "All Student Details";
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
            this.update.Location = new System.Drawing.Point(437, 130);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(169, 37);
            this.update.TabIndex = 36;
            this.update.Text = "Update Student Details";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(638, 130);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(169, 37);
            this.delete.TabIndex = 37;
            this.delete.Text = "Delete Student Details";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(261, 184);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(328, 27);
            this.txtsearch.TabIndex = 42;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsearch.ImageKey = "(none)";
            this.btnsearch.Location = new System.Drawing.Point(606, 178);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(108, 37);
            this.btnsearch.TabIndex = 43;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // coder
            // 
            this.coder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.coder.Image = global::BScSciencePlanet.Properties.Resources.developer;
            this.coder.Location = new System.Drawing.Point(22, 134);
            this.coder.Name = "coder";
            this.coder.Size = new System.Drawing.Size(49, 50);
            this.coder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coder.TabIndex = 41;
            this.coder.TabStop = false;
            // 
            // teacher
            // 
            this.teacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.teacher.Image = global::BScSciencePlanet.Properties.Resources.teacher;
            this.teacher.Location = new System.Drawing.Point(8, 83);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(49, 50);
            this.teacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacher.TabIndex = 40;
            this.teacher.TabStop = false;
            // 
            // engineer
            // 
            this.engineer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.engineer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.engineer.Image = global::BScSciencePlanet.Properties.Resources.architec;
            this.engineer.Location = new System.Drawing.Point(53, 99);
            this.engineer.Name = "engineer";
            this.engineer.Size = new System.Drawing.Size(49, 50);
            this.engineer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.engineer.TabIndex = 39;
            this.engineer.TabStop = false;
            // 
            // doctor
            // 
            this.doctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.doctor.Image = global::BScSciencePlanet.Properties.Resources.doctor;
            this.doctor.Location = new System.Drawing.Point(63, 155);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(49, 42);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::BScSciencePlanet.Properties.Resources.search__1_;
            this.pictureBox2.Location = new System.Drawing.Point(680, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::BScSciencePlanet.Properties.Resources.stack_of_books;
            this.pictureBox3.Location = new System.Drawing.Point(872, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(213, 138);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1109, 777);
            this.Controls.Add(this.pictureBox3);
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
            this.Controls.Add(this.labeltittle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addnew);
            this.Controls.Add(this.dgv1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button addnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeltittle;
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
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}