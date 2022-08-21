namespace FitnessCenterManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lb__close = new System.Windows.Forms.Label();
            this.btn_addMember = new System.Windows.Forms.Button();
            this.btn_ViewMember = new System.Windows.Forms.Button();
            this.btn_updateDelete = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb__close
            // 
            this.lb__close.AutoSize = true;
            this.lb__close.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb__close.ForeColor = System.Drawing.Color.Firebrick;
            this.lb__close.Location = new System.Drawing.Point(923, 9);
            this.lb__close.Name = "lb__close";
            this.lb__close.Size = new System.Drawing.Size(24, 30);
            this.lb__close.TabIndex = 1;
            this.lb__close.Text = "x";
            this.lb__close.Click += new System.EventHandler(this.lb__close_Click);
            // 
            // btn_addMember
            // 
            this.btn_addMember.BackColor = System.Drawing.Color.Firebrick;
            this.btn_addMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMember.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_addMember.ForeColor = System.Drawing.Color.White;
            this.btn_addMember.Location = new System.Drawing.Point(202, 23);
            this.btn_addMember.Name = "btn_addMember";
            this.btn_addMember.Size = new System.Drawing.Size(156, 43);
            this.btn_addMember.TabIndex = 8;
            this.btn_addMember.Text = "Add Member";
            this.btn_addMember.UseVisualStyleBackColor = false;
            this.btn_addMember.Click += new System.EventHandler(this.btn_addMember_Click);
            // 
            // btn_ViewMember
            // 
            this.btn_ViewMember.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ViewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewMember.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewMember.ForeColor = System.Drawing.Color.White;
            this.btn_ViewMember.Location = new System.Drawing.Point(375, 23);
            this.btn_ViewMember.Name = "btn_ViewMember";
            this.btn_ViewMember.Size = new System.Drawing.Size(163, 43);
            this.btn_ViewMember.TabIndex = 9;
            this.btn_ViewMember.Text = "View Member";
            this.btn_ViewMember.UseVisualStyleBackColor = false;
            this.btn_ViewMember.Click += new System.EventHandler(this.btn_ViewMember_Click);
            // 
            // btn_updateDelete
            // 
            this.btn_updateDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_updateDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateDelete.ForeColor = System.Drawing.Color.White;
            this.btn_updateDelete.Location = new System.Drawing.Point(553, 23);
            this.btn_updateDelete.Name = "btn_updateDelete";
            this.btn_updateDelete.Size = new System.Drawing.Size(163, 43);
            this.btn_updateDelete.TabIndex = 10;
            this.btn_updateDelete.Text = "Update/ Delete";
            this.btn_updateDelete.UseVisualStyleBackColor = false;
            this.btn_updateDelete.Click += new System.EventHandler(this.btn_updateDelete_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Firebrick;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(731, 23);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(130, 43);
            this.btnPayment.TabIndex = 11;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-3, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(966, 458);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btn_updateDelete);
            this.Controls.Add(this.btn_ViewMember);
            this.Controls.Add(this.btn_addMember);
            this.Controls.Add(this.lb__close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb__close;
        private System.Windows.Forms.Button btn_addMember;
        private System.Windows.Forms.Button btn_ViewMember;
        private System.Windows.Forms.Button btn_updateDelete;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}