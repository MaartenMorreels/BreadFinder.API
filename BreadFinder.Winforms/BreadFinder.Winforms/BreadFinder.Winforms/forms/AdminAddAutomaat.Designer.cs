using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BreadFinder.Winforms.forms
{
    partial class AdminAddAutomaat
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.automaatGroupBox = new System.Windows.Forms.GroupBox();
            this.addAutomaatButton = new System.Windows.Forms.Button();
            this.eigenaarIdTextBox = new System.Windows.Forms.TextBox();
            this.plaatsIdTextBox = new System.Windows.Forms.TextBox();
            this.huisNrTextBox = new System.Windows.Forms.TextBox();
            this.straatTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.plaatsIdGroupBox = new System.Windows.Forms.GroupBox();
            this.plaatsIdLabel = new System.Windows.Forms.Label();
            this.plaatsnaamTextBox = new System.Windows.Forms.TextBox();
            this.plaatsIdButton = new System.Windows.Forms.Button();
            this.plaatsenDataGrid = new System.Windows.Forms.DataGridView();
            this.eigenaarIdGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eigenaarTextBox = new System.Windows.Forms.TextBox();
            this.eigenaarIdButton = new System.Windows.Forms.Button();
            this.eigenaarsDataGrid = new System.Windows.Forms.DataGridView();
            this.automaatIdLabel = new System.Windows.Forms.Label();
            this.automaatGroupBox.SuspendLayout();
            this.plaatsIdGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plaatsenDataGrid)).BeginInit();
            this.eigenaarIdGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eigenaarsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "PlaatsId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Straat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "HuisNr:";
            // 
            // automaatGroupBox
            // 
            this.automaatGroupBox.Controls.Add(this.automaatIdLabel);
            this.automaatGroupBox.Controls.Add(this.addAutomaatButton);
            this.automaatGroupBox.Controls.Add(this.eigenaarIdTextBox);
            this.automaatGroupBox.Controls.Add(this.plaatsIdTextBox);
            this.automaatGroupBox.Controls.Add(this.huisNrTextBox);
            this.automaatGroupBox.Controls.Add(this.straatTextBox);
            this.automaatGroupBox.Controls.Add(this.label5);
            this.automaatGroupBox.Controls.Add(this.label1);
            this.automaatGroupBox.Controls.Add(this.label2);
            this.automaatGroupBox.Controls.Add(this.label4);
            this.automaatGroupBox.Controls.Add(this.label3);
            this.automaatGroupBox.Location = new System.Drawing.Point(21, 144);
            this.automaatGroupBox.Name = "automaatGroupBox";
            this.automaatGroupBox.Size = new System.Drawing.Size(694, 1036);
            this.automaatGroupBox.TabIndex = 5;
            this.automaatGroupBox.TabStop = false;
            this.automaatGroupBox.Text = "Please input automaat data:";
            // 
            // addAutomaatButton
            // 
            this.addAutomaatButton.Location = new System.Drawing.Point(267, 466);
            this.addAutomaatButton.Name = "addAutomaatButton";
            this.addAutomaatButton.Size = new System.Drawing.Size(275, 55);
            this.addAutomaatButton.TabIndex = 11;
            this.addAutomaatButton.Text = "Add Automaat";
            this.addAutomaatButton.UseVisualStyleBackColor = true;
            this.addAutomaatButton.Click += new System.EventHandler(this.addAutomaatButton_Click);
            // 
            // eigenaarIdTextBox
            // 
            this.eigenaarIdTextBox.Location = new System.Drawing.Point(267, 352);
            this.eigenaarIdTextBox.Name = "eigenaarIdTextBox";
            this.eigenaarIdTextBox.Size = new System.Drawing.Size(386, 35);
            this.eigenaarIdTextBox.TabIndex = 10;
            // 
            // plaatsIdTextBox
            // 
            this.plaatsIdTextBox.Location = new System.Drawing.Point(267, 283);
            this.plaatsIdTextBox.Name = "plaatsIdTextBox";
            this.plaatsIdTextBox.Size = new System.Drawing.Size(386, 35);
            this.plaatsIdTextBox.TabIndex = 9;
            // 
            // huisNrTextBox
            // 
            this.huisNrTextBox.Location = new System.Drawing.Point(267, 210);
            this.huisNrTextBox.Name = "huisNrTextBox";
            this.huisNrTextBox.Size = new System.Drawing.Size(386, 35);
            this.huisNrTextBox.TabIndex = 7;
            // 
            // straatTextBox
            // 
            this.straatTextBox.Location = new System.Drawing.Point(267, 143);
            this.straatTextBox.Name = "straatTextBox";
            this.straatTextBox.Size = new System.Drawing.Size(386, 35);
            this.straatTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "EigenaarId:";
            // 
            // plaatsIdGroupBox
            // 
            this.plaatsIdGroupBox.Controls.Add(this.plaatsenDataGrid);
            this.plaatsIdGroupBox.Controls.Add(this.plaatsIdButton);
            this.plaatsIdGroupBox.Controls.Add(this.plaatsnaamTextBox);
            this.plaatsIdGroupBox.Controls.Add(this.plaatsIdLabel);
            this.plaatsIdGroupBox.Location = new System.Drawing.Point(760, 144);
            this.plaatsIdGroupBox.Name = "plaatsIdGroupBox";
            this.plaatsIdGroupBox.Size = new System.Drawing.Size(1374, 474);
            this.plaatsIdGroupBox.TabIndex = 6;
            this.plaatsIdGroupBox.TabStop = false;
            this.plaatsIdGroupBox.Text = "Lookup PlaatsId:";
            // 
            // plaatsIdLabel
            // 
            this.plaatsIdLabel.AutoSize = true;
            this.plaatsIdLabel.Location = new System.Drawing.Point(16, 65);
            this.plaatsIdLabel.Name = "plaatsIdLabel";
            this.plaatsIdLabel.Size = new System.Drawing.Size(255, 29);
            this.plaatsIdLabel.TabIndex = 0;
            this.plaatsIdLabel.Text = "Search by plaatsnaam:";
            // 
            // plaatsnaamTextBox
            // 
            this.plaatsnaamTextBox.Location = new System.Drawing.Point(307, 65);
            this.plaatsnaamTextBox.Name = "plaatsnaamTextBox";
            this.plaatsnaamTextBox.Size = new System.Drawing.Size(427, 35);
            this.plaatsnaamTextBox.TabIndex = 1;
            // 
            // plaatsIdButton
            // 
            this.plaatsIdButton.Location = new System.Drawing.Point(777, 65);
            this.plaatsIdButton.Name = "plaatsIdButton";
            this.plaatsIdButton.Size = new System.Drawing.Size(142, 47);
            this.plaatsIdButton.TabIndex = 2;
            this.plaatsIdButton.Text = "Go";
            this.plaatsIdButton.UseVisualStyleBackColor = true;
            this.plaatsIdButton.Click += new System.EventHandler(this.plaatsIdButton_Click);
            // 
            // plaatsenDataGrid
            // 
            this.plaatsenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plaatsenDataGrid.Location = new System.Drawing.Point(21, 131);
            this.plaatsenDataGrid.Name = "plaatsenDataGrid";
            this.plaatsenDataGrid.RowTemplate.Height = 37;
            this.plaatsenDataGrid.Size = new System.Drawing.Size(1335, 320);
            this.plaatsenDataGrid.TabIndex = 3;
            // 
            // eigenaarIdGroupBox
            // 
            this.eigenaarIdGroupBox.Controls.Add(this.eigenaarsDataGrid);
            this.eigenaarIdGroupBox.Controls.Add(this.eigenaarIdButton);
            this.eigenaarIdGroupBox.Controls.Add(this.eigenaarTextBox);
            this.eigenaarIdGroupBox.Controls.Add(this.label6);
            this.eigenaarIdGroupBox.Location = new System.Drawing.Point(760, 656);
            this.eigenaarIdGroupBox.Name = "eigenaarIdGroupBox";
            this.eigenaarIdGroupBox.Size = new System.Drawing.Size(1374, 524);
            this.eigenaarIdGroupBox.TabIndex = 7;
            this.eigenaarIdGroupBox.TabStop = false;
            this.eigenaarIdGroupBox.Text = "Lookup EigenaarId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search by eigenaarnaam:";
            // 
            // eigenaarTextBox
            // 
            this.eigenaarTextBox.Location = new System.Drawing.Point(325, 79);
            this.eigenaarTextBox.Name = "eigenaarTextBox";
            this.eigenaarTextBox.Size = new System.Drawing.Size(409, 35);
            this.eigenaarTextBox.TabIndex = 1;
            // 
            // eigenaarIdButton
            // 
            this.eigenaarIdButton.Location = new System.Drawing.Point(777, 79);
            this.eigenaarIdButton.Name = "eigenaarIdButton";
            this.eigenaarIdButton.Size = new System.Drawing.Size(142, 47);
            this.eigenaarIdButton.TabIndex = 2;
            this.eigenaarIdButton.Text = "Go";
            this.eigenaarIdButton.UseVisualStyleBackColor = true;
            this.eigenaarIdButton.Click += new System.EventHandler(this.eigenaarIdButton_Click);
            // 
            // eigenaarsDataGrid
            // 
            this.eigenaarsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eigenaarsDataGrid.Location = new System.Drawing.Point(26, 156);
            this.eigenaarsDataGrid.Name = "eigenaarsDataGrid";
            this.eigenaarsDataGrid.RowTemplate.Height = 37;
            this.eigenaarsDataGrid.Size = new System.Drawing.Size(1330, 344);
            this.eigenaarsDataGrid.TabIndex = 3;
            // 
            // automaatIdLabel
            // 
            this.automaatIdLabel.AutoSize = true;
            this.automaatIdLabel.Location = new System.Drawing.Point(267, 82);
            this.automaatIdLabel.Name = "automaatIdLabel";
            this.automaatIdLabel.Size = new System.Drawing.Size(420, 29);
            this.automaatIdLabel.TabIndex = 12;
            this.automaatIdLabel.Text = "new Id will appear after succesful add ";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2197, 1269);
            this.Controls.Add(this.eigenaarIdGroupBox);
            this.Controls.Add(this.plaatsIdGroupBox);
            this.Controls.Add(this.automaatGroupBox);
            this.Name = "Admin";
            this.Text = "AddAutomaat";
            this.automaatGroupBox.ResumeLayout(false);
            this.automaatGroupBox.PerformLayout();
            this.plaatsIdGroupBox.ResumeLayout(false);
            this.plaatsIdGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plaatsenDataGrid)).EndInit();
            this.eigenaarIdGroupBox.ResumeLayout(false);
            this.eigenaarIdGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eigenaarsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox automaatGroupBox;
        private System.Windows.Forms.Button addAutomaatButton;
        private System.Windows.Forms.TextBox eigenaarIdTextBox;
        private System.Windows.Forms.TextBox plaatsIdTextBox;
        private System.Windows.Forms.TextBox huisNrTextBox;
        private System.Windows.Forms.TextBox straatTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox plaatsIdGroupBox;
        private System.Windows.Forms.DataGridView plaatsenDataGrid;
        private System.Windows.Forms.Button plaatsIdButton;
        private System.Windows.Forms.TextBox plaatsnaamTextBox;
        private System.Windows.Forms.Label plaatsIdLabel;
        private System.Windows.Forms.GroupBox eigenaarIdGroupBox;
        private System.Windows.Forms.DataGridView eigenaarsDataGrid;
        private System.Windows.Forms.Button eigenaarIdButton;
        private System.Windows.Forms.TextBox eigenaarTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label automaatIdLabel;
    }
}