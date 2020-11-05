namespace Lager
{
    partial class Lager
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
			this.Varor = new System.Windows.Forms.ListView();
			this.AddButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.ItemLabel = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ErrorBox = new System.Windows.Forms.RichTextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ApplyButton = new System.Windows.Forms.Button();
			this.ClearButtom1 = new System.Windows.Forms.Button();
			this.PriceLabel = new System.Windows.Forms.Label();
			this.CountLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.CountBox = new System.Windows.Forms.TextBox();
			this.PriceBox = new System.Windows.Forms.TextBox();
			this.ClearButton2 = new System.Windows.Forms.Button();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.FindButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Varor
			// 
			this.Varor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Varor.CheckBoxes = true;
			this.Varor.FullRowSelect = true;
			this.Varor.HideSelection = false;
			this.Varor.Location = new System.Drawing.Point(11, 11);
			this.Varor.Margin = new System.Windows.Forms.Padding(2);
			this.Varor.Name = "Varor";
			this.Varor.Size = new System.Drawing.Size(222, 398);
			this.Varor.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.Varor.TabIndex = 1;
			this.Varor.UseCompatibleStateImageBehavior = false;
			this.Varor.SelectedIndexChanged += new System.EventHandler(this.Varor_SelectedIndexChanged);
			this.Varor.Click += new System.EventHandler(this.Varor_Click);
			this.Varor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Varor_KeyDown);
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(9, 418);
			this.AddButton.Margin = new System.Windows.Forms.Padding(2);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(56, 27);
			this.AddButton.TabIndex = 2;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(177, 418);
			this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(56, 27);
			this.RemoveButton.TabIndex = 3;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// ItemLabel
			// 
			this.ItemLabel.AutoSize = true;
			this.ItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemLabel.Location = new System.Drawing.Point(239, 11);
			this.ItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ItemLabel.Name = "ItemLabel";
			this.ItemLabel.Size = new System.Drawing.Size(158, 36);
			this.ItemLabel.TabIndex = 4;
			this.ItemLabel.Text = "Item: Item4";
			// 
			// NameBox
			// 
			this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameBox.Location = new System.Drawing.Point(72, 2);
			this.NameBox.Margin = new System.Windows.Forms.Padding(2);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(185, 28);
			this.NameBox.TabIndex = 5;
			this.NameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Box_KeyDown);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.ErrorBox);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.ClearButton2);
			this.panel1.Controls.Add(this.FindButton);
			this.panel1.Controls.Add(this.BrowseButton);
			this.panel1.Location = new System.Drawing.Point(245, 59);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(407, 349);
			this.panel1.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = global::Lager.Properties.Resources.Ping;
			this.pictureBox1.Location = new System.Drawing.Point(270, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(134, 134);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.ClearButton2_Click);
			// 
			// ErrorBox
			// 
			this.ErrorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.ErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.ErrorBox.ForeColor = System.Drawing.Color.Maroon;
			this.ErrorBox.HideSelection = false;
			this.ErrorBox.Location = new System.Drawing.Point(2, 141);
			this.ErrorBox.Name = "ErrorBox";
			this.ErrorBox.ReadOnly = true;
			this.ErrorBox.Size = new System.Drawing.Size(263, 205);
			this.ErrorBox.TabIndex = 8;
			this.ErrorBox.Text = "";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.NameBox);
			this.panel2.Controls.Add(this.ApplyButton);
			this.panel2.Controls.Add(this.ClearButtom1);
			this.panel2.Controls.Add(this.PriceLabel);
			this.panel2.Controls.Add(this.CountLabel);
			this.panel2.Controls.Add(this.NameLabel);
			this.panel2.Controls.Add(this.CountBox);
			this.panel2.Controls.Add(this.PriceBox);
			this.panel2.Location = new System.Drawing.Point(2, 2);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(263, 134);
			this.panel2.TabIndex = 7;
			// 
			// ApplyButton
			// 
			this.ApplyButton.Location = new System.Drawing.Point(201, 101);
			this.ApplyButton.Margin = new System.Windows.Forms.Padding(2);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new System.Drawing.Size(56, 27);
			this.ApplyButton.TabIndex = 7;
			this.ApplyButton.Text = "Apply";
			this.ApplyButton.UseVisualStyleBackColor = true;
			this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
			// 
			// ClearButtom1
			// 
			this.ClearButtom1.Location = new System.Drawing.Point(2, 101);
			this.ClearButtom1.Margin = new System.Windows.Forms.Padding(2);
			this.ClearButtom1.Name = "ClearButtom1";
			this.ClearButtom1.Size = new System.Drawing.Size(56, 27);
			this.ClearButtom1.TabIndex = 6;
			this.ClearButtom1.Text = "Clear";
			this.ClearButtom1.UseVisualStyleBackColor = true;
			this.ClearButtom1.Click += new System.EventHandler(this.ClearButton1_Click);
			// 
			// PriceLabel
			// 
			this.PriceLabel.AutoSize = true;
			this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriceLabel.Location = new System.Drawing.Point(2, 66);
			this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.Size = new System.Drawing.Size(58, 24);
			this.PriceLabel.TabIndex = 6;
			this.PriceLabel.Text = "Price:";
			// 
			// CountLabel
			// 
			this.CountLabel.AutoSize = true;
			this.CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CountLabel.Location = new System.Drawing.Point(2, 34);
			this.CountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.CountLabel.Name = "CountLabel";
			this.CountLabel.Size = new System.Drawing.Size(65, 24);
			this.CountLabel.TabIndex = 6;
			this.CountLabel.Text = "Count:";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameLabel.Location = new System.Drawing.Point(2, 2);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(66, 24);
			this.NameLabel.TabIndex = 6;
			this.NameLabel.Text = "Name:";
			// 
			// CountBox
			// 
			this.CountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CountBox.Location = new System.Drawing.Point(72, 34);
			this.CountBox.Margin = new System.Windows.Forms.Padding(2);
			this.CountBox.Name = "CountBox";
			this.CountBox.Size = new System.Drawing.Size(185, 28);
			this.CountBox.TabIndex = 5;
			this.CountBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Box_KeyDown);
			// 
			// PriceBox
			// 
			this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriceBox.Location = new System.Drawing.Point(72, 66);
			this.PriceBox.Margin = new System.Windows.Forms.Padding(2);
			this.PriceBox.Name = "PriceBox";
			this.PriceBox.Size = new System.Drawing.Size(185, 28);
			this.PriceBox.TabIndex = 5;
			this.PriceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Box_KeyDown);
			// 
			// ClearButton2
			// 
			this.ClearButton2.Location = new System.Drawing.Point(270, 142);
			this.ClearButton2.Margin = new System.Windows.Forms.Padding(2);
			this.ClearButton2.Name = "ClearButton2";
			this.ClearButton2.Size = new System.Drawing.Size(56, 27);
			this.ClearButton2.TabIndex = 9;
			this.ClearButton2.Text = "Clear";
			this.ClearButton2.UseVisualStyleBackColor = true;
			this.ClearButton2.Click += new System.EventHandler(this.ClearButton2_Click);
			// 
			// BrowseButton
			// 
			this.BrowseButton.Location = new System.Drawing.Point(351, 142);
			this.BrowseButton.Margin = new System.Windows.Forms.Padding(2);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(56, 27);
			this.BrowseButton.TabIndex = 10;
			this.BrowseButton.Text = "Browse";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(596, 418);
			this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(56, 27);
			this.SaveButton.TabIndex = 12;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(515, 418);
			this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(56, 27);
			this.CloseButton.TabIndex = 11;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "Item Image";
			// 
			// FindButton
			// 
			this.FindButton.Location = new System.Drawing.Point(351, 173);
			this.FindButton.Margin = new System.Windows.Forms.Padding(2);
			this.FindButton.Name = "FindButton";
			this.FindButton.Size = new System.Drawing.Size(56, 27);
			this.FindButton.TabIndex = 10;
			this.FindButton.Text = "Find";
			this.FindButton.UseVisualStyleBackColor = true;
			this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
			// 
			// Lager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 456);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ItemLabel);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.Varor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximumSize = new System.Drawing.Size(679, 495);
			this.MinimumSize = new System.Drawing.Size(679, 495);
			this.Name = "Lager";
			this.Text = "Lager";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Varor;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.RichTextBox ErrorBox;
		private System.Windows.Forms.Button ClearButtom1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button ClearButton2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button ApplyButton;
		private System.Windows.Forms.Button FindButton;
	}
}

