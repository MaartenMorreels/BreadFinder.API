namespace BreadFinder.Winforms.forms
{
    partial class Start
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
            this.userSectionButton = new System.Windows.Forms.Button();
            this.adminSectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to BreadFinder! ";
            // 
            // userSectionButton
            // 
            this.userSectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSectionButton.Location = new System.Drawing.Point(504, 398);
            this.userSectionButton.Name = "userSectionButton";
            this.userSectionButton.Size = new System.Drawing.Size(373, 72);
            this.userSectionButton.TabIndex = 1;
            this.userSectionButton.Text = "To Users Section";
            this.userSectionButton.UseVisualStyleBackColor = true;
            this.userSectionButton.Click += new System.EventHandler(this.userSectionButton_Click);
            // 
            // adminSectionButton
            // 
            this.adminSectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminSectionButton.Location = new System.Drawing.Point(504, 518);
            this.adminSectionButton.Name = "adminSectionButton";
            this.adminSectionButton.Size = new System.Drawing.Size(373, 72);
            this.adminSectionButton.TabIndex = 2;
            this.adminSectionButton.Text = "To Admin Section";
            this.adminSectionButton.UseVisualStyleBackColor = true;
            this.adminSectionButton.Click += new System.EventHandler(this.adminSectionButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 785);
            this.Controls.Add(this.adminSectionButton);
            this.Controls.Add(this.userSectionButton);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userSectionButton;
        private System.Windows.Forms.Button adminSectionButton;
    }
}