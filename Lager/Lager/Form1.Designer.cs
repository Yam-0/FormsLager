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
			this.CopyButton = new System.Windows.Forms.Button();
			this.ItemLabel = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.ReloadButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.PriceBox = new System.Windows.Forms.TextBox();
			this.CountBox = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.CountLabel = new System.Windows.Forms.Label();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.PriceLabel = new System.Windows.Forms.Label();
			this.ApplyButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ErrorBox = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.Varor.Size = new System.Drawing.Size(222, 402);
			this.Varor.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.Varor.TabIndex = 1;
			this.Varor.UseCompatibleStateImageBehavior = false;
			this.Varor.SelectedIndexChanged += new System.EventHandler(this.Varor_SelectedIndexChanged);
			this.Varor.Click += new System.EventHandler(this.Varor_Click);
			this.Varor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Varor_KeyDown);
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(11, 418);
			this.AddButton.Margin = new System.Windows.Forms.Padding(2);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(56, 27);
			this.AddButton.TabIndex = 2;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// CopyButton
			// 
			this.CopyButton.Location = new System.Drawing.Point(71, 418);
			this.CopyButton.Margin = new System.Windows.Forms.Padding(2);
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(56, 27);
			this.CopyButton.TabIndex = 3;
			this.CopyButton.Text = "Copy";
			this.CopyButton.UseVisualStyleBackColor = true;
			this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// ItemLabel
			// 
			this.ItemLabel.AutoSize = true;
			this.ItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemLabel.Location = new System.Drawing.Point(240, 11);
			this.ItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ItemLabel.Name = "ItemLabel";
			this.ItemLabel.Size = new System.Drawing.Size(158, 36);
			this.ItemLabel.TabIndex = 4;
			this.ItemLabel.Text = "Item: Item4";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(409, 418);
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
			this.CloseButton.Location = new System.Drawing.Point(349, 418);
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
			// ReloadButton
			// 
			this.ReloadButton.Location = new System.Drawing.Point(289, 418);
			this.ReloadButton.Margin = new System.Windows.Forms.Padding(2);
			this.ReloadButton.Name = "ReloadButton";
			this.ReloadButton.Size = new System.Drawing.Size(56, 27);
			this.ReloadButton.TabIndex = 10;
			this.ReloadButton.Text = "Reload";
			this.ReloadButton.UseVisualStyleBackColor = true;
			this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(177, 418);
			this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(56, 27);
			this.RemoveButton.TabIndex = 4;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// PriceBox
			// 
			this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriceBox.Location = new System.Drawing.Point(321, 121);
			this.PriceBox.Margin = new System.Windows.Forms.Padding(2);
			this.PriceBox.Name = "PriceBox";
			this.PriceBox.Size = new System.Drawing.Size(144, 28);
			this.PriceBox.TabIndex = 5;
			this.PriceBox.Enter += new System.EventHandler(this.Box_Enter);
			this.PriceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Box_KeyDown);
			// 
			// CountBox
			// 
			this.CountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CountBox.Location = new System.Drawing.Point(321, 89);
			this.CountBox.Margin = new System.Windows.Forms.Padding(2);
			this.CountBox.Name = "CountBox";
			this.CountBox.Size = new System.Drawing.Size(144, 28);
			this.CountBox.TabIndex = 5;
			this.CountBox.Enter += new System.EventHandler(this.Box_Enter);
			this.CountBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Box_KeyDown);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameLabel.Location = new System.Drawing.Point(242, 57);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(66, 24);
			this.NameLabel.TabIndex = 6;
			this.NameLabel.Text = "Name:";
			// 
			// CountLabel
			// 
			this.CountLabel.AutoSize = true;
			this.CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CountLabel.Location = new System.Drawing.Point(242, 89);
			this.CountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.CountLabel.Name = "CountLabel";
			this.CountLabel.Size = new System.Drawing.Size(65, 24);
			this.CountLabel.TabIndex = 6;
			this.CountLabel.Text = "Count:";
			// 
			// BrowseButton
			// 
			this.BrowseButton.Location = new System.Drawing.Point(369, 164);
			this.BrowseButton.Margin = new System.Windows.Forms.Padding(2);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(96, 27);
			this.BrowseButton.TabIndex = 6;
			this.BrowseButton.Text = "Browse";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			this.BrowseButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button_KeyDown);
			// 
			// PriceLabel
			// 
			this.PriceLabel.AutoSize = true;
			this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriceLabel.Location = new System.Drawing.Point(242, 121);
			this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.Size = new System.Drawing.Size(58, 24);
			this.PriceLabel.TabIndex = 6;
			this.PriceLabel.Text = "Price:";
			// 
			// ApplyButton
			// 
			this.ApplyButton.Location = new System.Drawing.Point(369, 255);
			this.ApplyButton.Margin = new System.Windows.Forms.Padding(2);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new System.Drawing.Size(96, 27);
			this.ApplyButton.TabIndex = 8;
			this.ApplyButton.Text = "Apply";
			this.ApplyButton.UseVisualStyleBackColor = true;
			this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
			this.ApplyButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button_KeyDown);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(369, 195);
			this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(96, 27);
			this.ClearButton.TabIndex = 7;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			this.ClearButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button_KeyDown);
			// 
			// NameBox
			// 
			this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameBox.Location = new System.Drawing.Point(321, 57);
			this.NameBox.Margin = new System.Windows.Forms.Padding(2);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(144, 28);
			this.NameBox.TabIndex = 5;
			this.NameBox.Enter += new System.EventHandler(this.Box_Enter);
			this.NameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Box_KeyDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = global::Lager.Properties.Resources.Ping;
			this.pictureBox1.Location = new System.Drawing.Point(246, 164);
			this.pictureBox1.MaximumSize = new System.Drawing.Size(118, 118);
			this.pictureBox1.MinimumSize = new System.Drawing.Size(118, 118);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(118, 118);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// ErrorBox
			// 
			this.ErrorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.ErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.ErrorBox.ForeColor = System.Drawing.Color.Maroon;
			this.ErrorBox.HideSelection = false;
			this.ErrorBox.Location = new System.Drawing.Point(246, 288);
			this.ErrorBox.Name = "ErrorBox";
			this.ErrorBox.ReadOnly = true;
			this.ErrorBox.Size = new System.Drawing.Size(219, 125);
			this.ErrorBox.TabIndex = 9;
			this.ErrorBox.Text = "";
			this.ErrorBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ErrorBox_KeyDown);
			// 
			// Lager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 456);
			this.Controls.Add(this.ErrorBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.ItemLabel);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.ReloadButton);
			this.Controls.Add(this.ApplyButton);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.PriceLabel);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.BrowseButton);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.CountLabel);
			this.Controls.Add(this.CopyButton);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.CountBox);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.PriceBox);
			this.Controls.Add(this.Varor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximumSize = new System.Drawing.Size(492, 495);
			this.MinimumSize = new System.Drawing.Size(492, 495);
			this.Name = "Lager";
			this.Text = "Lager";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Varor;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button ReloadButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.TextBox PriceBox;
		private System.Windows.Forms.TextBox CountBox;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label CountLabel;
		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.Label PriceLabel;
		private System.Windows.Forms.Button ApplyButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox ErrorBox;
	}
}

