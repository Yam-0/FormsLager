using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Lager
{
	public partial class Lager : Form
	{
		public TextBox[] textBoxes;
		public Lager()
		{
			InitializeComponent();
			CreateMyListView();
			ItemLabel.Text = "Item: ";
			ErrorBox.Text = "";
			textBoxes = new TextBox[] { NameBox, CountBox, PriceBox };
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		public void CreateMyListView()
		{
			int itemCount = 20;

			ListViewItem[] items = new ListViewItem[itemCount];

			Varor.Scrollable = true;
			Varor.MultiSelect = true;
			Varor.View = View.Details;
			Random random = new Random();

			for (int i = 0; i < items.Length; i++)
			{
				ListViewItem item = new ListViewItem("Item" + i, 0);
				string price = random.Next(0, 100).ToString();
				string count = random.Next(0, 1000).ToString();
				string adress = "-";
				item.SubItems.Add(count);
				item.SubItems.Add(price);
				item.SubItems.Add(adress);

				Varor.Items.Add(item);
			}

			Varor.Sorting = SortOrder.Ascending;

			Varor.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
			Varor.Columns.Add("Count", -2, HorizontalAlignment.Left);
			Varor.Columns.Add("Price", -2, HorizontalAlignment.Left);
			Varor.Columns.Add("Image", -2, HorizontalAlignment.Left);
		}

		private void Varor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Varor.SelectedItems.Count > 0)
			{
				var item = Varor.SelectedItems[0];

				var name = Varor.Items[Varor.SelectedItems[0].Index].SubItems[0].Text;
				var count = Varor.Items[Varor.SelectedItems[0].Index].SubItems[1].Text;
				var price = Varor.Items[Varor.SelectedItems[0].Index].SubItems[2].Text;
				var adress = Varor.Items[Varor.SelectedItems[0].Index].SubItems[3].Text;

				ItemLabel.Text = "Item: " + item.Text;
				NameBox.Text = name;
				CountBox.Text = count;
				PriceBox.Text = price;

				Bitmap bitmap;

				if (File.Exists(adress))
				{
					bitmap = new Bitmap(adress);
				}
				else
				{
					bitmap = Properties.Resources.Ping;
				}

				pictureBox1.Image = bitmap;

				item.Checked = true;
			}
			else
			{
				ItemLabel.Text = "Item:";
				NameBox.Text = "";
				CountBox.Text = "";
				PriceBox.Text = "";
				pictureBox1.Image = Properties.Resources.Ping;
			}

			ErrorBox.Text = "";
			UpdateSelection();
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			Remove();
		}

		public void Remove()
		{
			int firstIndex = -1;

			foreach (ListViewItem item in Varor.Items)
			{
				if (item.Checked)
				{
					if (firstIndex == -1)
					{
						firstIndex = item.Index;
					}
					
					string adress = Varor.Items[Varor.SelectedItems[0].Index].SubItems[3].Text;
					if (File.Exists(adress))
					{
						Bitmap Placeholder = Properties.Resources.Ping;
						pictureBox1.Image = Placeholder;
						GC.Collect();
						GC.WaitForPendingFinalizers();
						File.Delete(adress);
					}

					Varor.Items.Remove(item);
				}
			}

			foreach (ListViewItem selectedItem in Varor.SelectedItems)
			{
				selectedItem.Selected = false;
			}

			if (firstIndex != -1)
			{
				int i = firstIndex - 1;
				if (i < 0) { i = 0; }

				if (Varor.Items.Count != 0)
				{
					Varor.Items[i].Selected = true;
					Varor.Items[i].Focused = true;

					Varor.Select();
					UpdateSelection();
				}
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			ListViewItem item = new ListViewItem("Item" + Varor.Items.Count, 0);
			string price = random.Next(0, 100).ToString();
			string count = random.Next(0, 1000).ToString();
			string adress = "-";
			item.SubItems.Add(count);
			item.SubItems.Add(price);
			item.SubItems.Add(adress);
			Varor.Items.Add(item);

			foreach (ListViewItem selectedItem in Varor.SelectedItems)
			{
				selectedItem.Selected = false;
			}

			Varor.Items[item.Index].Selected = true;
			Varor.Select();
			UpdateSelection();
		}

		private void Varor_Click(object sender, EventArgs e)
		{
			UpdateSelection();
		}

		private void ApplyButton_Click(object sender, EventArgs e)
		{
			Apply();
		}

		public void Apply()
		{
			var name = NameBox.Text;
			var count = CountBox.Text;
			var price = PriceBox.Text;

			List<string> errors = new List<string>();

			if (name == "" || name == null) { errors.Add("Name empty!"); }
			if (count == "" || count == null) { errors.Add("Count empty!"); }
			if (price == "" || price == null) { errors.Add("Price empty!"); }

			if (name.Length > 20) { errors.Add("Name too long!"); }
			if (count.Length > 20) { errors.Add("Count too long!"); }
			if (price.Length > 20) { errors.Add("Price too long!"); }

			if (!(double.TryParse(count, out double countValue))) { errors.Add("'" + count + "' count not a number!"); }
			if (!(double.TryParse(price, out double priceValue))) { errors.Add("'" + price + "' price not a number!"); }

			if (Varor.SelectedItems.Count <= 0)
			{
				errors.Clear();
				errors.Add("Nothing selected!");
			}

			if (errors.Count > 0)
			{
				ErrorBox.Text = "";

				ErrorBox.Lines = errors.ToArray();

				return;
			}
			else
			{
				ErrorBox.Text = "";
			}

			if (Varor.SelectedItems.Count > 0)
			{
				ItemLabel.Text = "Item: " + name;
				Varor.Items[Varor.SelectedItems[0].Index].Name = name;
				Varor.Items[Varor.SelectedItems[0].Index].SubItems[0].Text = name;
				Varor.Items[Varor.SelectedItems[0].Index].SubItems[1].Text = count;
				Varor.Items[Varor.SelectedItems[0].Index].SubItems[2].Text = price;
			}
		}

		public void UpdateSelection()
		{
			foreach (ListViewItem item in Varor.Items)
			{
				{
					//item.Selected = false;
					item.Checked = false;
				}
			}
			foreach (ListViewItem item in Varor.SelectedItems)
			{
				{
					//item.Selected = false;
					item.Checked = true;
				}
			}
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ClearButton1_Click(object sender, EventArgs e)
		{
			NameBox.Text = "";
			CountBox.Text = "";
			PriceBox.Text = "";
		}

		private void ClearButton2_Click(object sender, EventArgs e)
		{
			if(Varor.SelectedItems.Count > 0)
			{
				var item = Varor.SelectedItems[0];

				pictureBox1.Image = Properties.Resources.Ping;
				string adress = Varor.Items[Varor.SelectedItems[0].Index].SubItems[3].Text;
				if (File.Exists(adress))
				{
					Bitmap Placeholder = Properties.Resources.Ping;
					pictureBox1.Image = Placeholder;
					GC.Collect();
					GC.WaitForPendingFinalizers();
					File.Delete(adress);
				}
			}
		}

		private void BrowseButton_Click(object sender, EventArgs e)
		{
			if (Varor.SelectedItems.Count > 0)
			{
				openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
				if (openFileDialog1.ShowDialog() == DialogResult.OK && Varor.SelectedItems.Count > 0)
				{
					var item = Varor.SelectedItems[0];
					Image image = Image.FromFile(openFileDialog1.FileName);
					pictureBox1.Image = image;
					Bitmap bmp = (Bitmap)image;
					Directory.CreateDirectory("./ImageList");
					string newAdress = "./ImageList/img" + item.Index.ToString() + ".png";
					bmp.Save(newAdress, ImageFormat.Png);
					Varor.Items[Varor.SelectedItems[0].Index].SubItems[3].Text = newAdress;
				}
			}
		}

		private void FindButton_Click(object sender, EventArgs e)
		{
			if (Varor.SelectedItems.Count > 0)
			{
				string adress = System.IO.Directory.GetCurrentDirectory() + @"\" + "ImageList";
				openFileDialog1.InitialDirectory = adress;
				openFileDialog1.Filter = "*.png;)|*.png;";
				openFileDialog1.RestoreDirectory = true;

				if (openFileDialog1.ShowDialog() == DialogResult.OK && Varor.SelectedItems.Count > 0)
				{
					var item = Varor.SelectedItems[0];
					Image image = Image.FromFile(openFileDialog1.FileName);
					pictureBox1.Image = image;
					Bitmap bmp = (Bitmap)image;
					string newAdress = openFileDialog1.FileName;
					ErrorBox.Text = newAdress;
					Varor.Items[Varor.SelectedItems[0].Index].SubItems[3].Text = newAdress;
				}
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{

		}

		private void Varor_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Right:
				case Keys.Enter:
					if (Varor.SelectedItems.Count > 0)
					{
						NameBox.Select();
						e.SuppressKeyPress = true;
					}
					break;

				case Keys.A:
					if(e.Control)
					{
						foreach (ListViewItem item in Varor.Items)
						{
							item.Selected = true;
						}
					}
					break;

				case Keys.Back:
				case Keys.Delete:
					Remove();
					break;
			}
		}

		private void Box_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Enter:
					Apply();
					e.SuppressKeyPress = true;
					break;

				case Keys.Left:
				case Keys.Escape:
					Varor.Select();
					if(Varor.Items.Count > 0 && Varor.SelectedItems.Count <= 0) { Varor.Items[0].Selected = true; }
					e.SuppressKeyPress = true;
					break;

				case Keys.Up:
				case Keys.Down:
					for (int i = 0; i < textBoxes.Length; i++)
					{
						if(textBoxes[i].Focused)
						{
							if(e.KeyCode == Keys.Up)
							{
								if(i != 0) { textBoxes[i - 1].Focus(); }
							}
							else
							{
								if (i != 2) { textBoxes[i + 1].Focus(); }
							}
							break;
						}
					}
					break;

			}

			e.Handled = true;
		}
	}
}

