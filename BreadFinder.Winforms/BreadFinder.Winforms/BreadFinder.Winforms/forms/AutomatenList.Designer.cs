namespace BreadFinder.Winforms.forms
{
    partial class AutomatenList
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
            this.textboxPlaatsnaam = new System.Windows.Forms.TextBox();
            this.labelPlaatsNaam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxPlaatsnaam
            // 
            this.textboxPlaatsnaam.Location = new System.Drawing.Point(463, 134);
            this.textboxPlaatsnaam.Name = "textboxPlaatsnaam";
            this.textboxPlaatsnaam.Size = new System.Drawing.Size(349, 35);
            this.textboxPlaatsnaam.TabIndex = 0;
            this.textboxPlaatsnaam.Text = "Ade";
            // 
            // labelPlaatsNaam
            // 
            this.labelPlaatsNaam.AutoSize = true;
            this.labelPlaatsNaam.Location = new System.Drawing.Point(178, 140);
            this.labelPlaatsNaam.Name = "labelPlaatsNaam";
            this.labelPlaatsNaam.Size = new System.Drawing.Size(236, 29);
            this.labelPlaatsNaam.TabIndex = 1;
            this.labelPlaatsNaam.Text = "Zoek op plaatsnaam:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(878, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(2127, 934);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zoek op provincie: ";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1321, 97);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(365, 51);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add an automate";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel.Location = new System.Drawing.Point(1327, 234);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(596, 36);
            this.editLabel.TabIndex = 7;
            this.editLabel.Text = "double click on a row to edit an automate";
            this.editLabel.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alle provincies",
            "Brussel (19 gemeenten)",
            "Henegouwen",
            "Limburg",
            "Luik",
            "Luxemburg",
            "Namen",
            "Oost-Vlaanderen",
            "Vlaams-Brabant",
            "Waals-Brabant",
            "West-Vlaanderen"});
            this.comboBox1.Location = new System.Drawing.Point(463, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(349, 37);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // AutomatenList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2188, 1258);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPlaatsNaam);
            this.Controls.Add(this.textboxPlaatsnaam);
            this.Name = "AutomatenList";
            this.Text = "BreadFinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxPlaatsnaam;
        private System.Windows.Forms.Label labelPlaatsNaam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

