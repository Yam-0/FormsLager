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

using MongoDB.Driver;
using MongoDB.Bson;

namespace Lager
{
	public partial class Lager : Form
	{

		public IMongoDatabase database;
		public TextBox[] textBoxes;

		public Lager()
		{
			InitializeComponent();
			ItemLabel.Text = "Item: ";
			ErrorBox.Text = "";
			textBoxes = new TextBox[] { NameBox, CountBox, PriceBox };

			string STAGING_USER_PASSWORD = "ntiuser"; //Safety tips
			string atlasString = "mongodb+srv://staging-user:" + STAGING_USER_PASSWORD + "@varor.igatz.mongodb.net/test";
			MongoClient databaseClient = new MongoClient(atlasString);
			var databases = databaseClient.ListDatabases().ToList();
			Console.WriteLine("Databases: ");
			foreach (var database in databases)
			{
				Console.WriteLine(database);
			}

			string databaseName = "Varor-Database";
			database = databaseClient.GetDatabase(databaseName);
			var command = new BsonDocument { { "dbstats", 1 } };
			var result = database.RunCommand<BsonDocument>(command);

			Console.WriteLine(result);

			CreateMyListView();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		public void CreateMyListView()
		{
			Varor.Scrollable = true;
			Varor.MultiSelect = true;
			Varor.View = View.Details;

			var dbVaror = database.GetCollection<BsonDocument>("Varor");
			var documents = dbVaror.Find(new BsonDocument()).ToList();
			foreach (BsonDocument vara in documents)
			{
				string name = vara.GetValue(1).ToString();
				string price = vara.GetValue(2).ToString();
				string count = vara.GetValue(3).ToString();
				string adress = vara.GetValue(4).ToString();

				ListViewItem item = new ListViewItem(name, 0);
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
					/*
					if (File.Exists(adress))
					{
						Bitmap Placeholder = Properties.Resources.Ping;
						pictureBox1.Image = Placeholder;
						GC.Collect();
						GC.WaitForPendingFinalizers();
						File.Delete(adress);
					}
					*/

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

		private void ClearButton_Click(object sender, EventArgs e)
		{
			NameBox.Text = "";
			CountBox.Text = "";
			PriceBox.Text = "";
			ErrorBox.Text = "";
			Varor.Items[Varor.SelectedItems[0].Index].SubItems[3].Text = "-";
			Bitmap Placeholder = Properties.Resources.Ping;

			if (Varor.SelectedItems.Count > 0)
			{
				var item = Varor.SelectedItems[0];

				pictureBox1.Image = Properties.Resources.Ping;
				string adress = Varor.Items[Varor.SelectedItems[0].Index].SubItems[3].Text;
				if (File.Exists(adress))
				{
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
					Varor.Items[Varor.SelectedItems[0].Index].SubItems[3].Text = newAdress;
				}
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Saving");
			SetDatabase();
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
					if (e.Control)
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

				case Keys.Escape:
					Varor.Select();
					if (Varor.Items.Count > 0 && Varor.SelectedItems.Count <= 0) { Varor.Items[0].Selected = true; }
					e.SuppressKeyPress = true;
					break;

				case Keys.Up:
				case Keys.Down:
					for (int i = 0; i < textBoxes.Length; i++)
					{
						if (textBoxes[i].Focused)
						{
							if (e.KeyCode == Keys.Up)
							{
								if (i != 0)
								{
									textBoxes[i - 1].Focus();
								}
								else
								{
									ClearButton.Focus();
								}
							}
							else
							{
								if (i != 2)
								{
									textBoxes[i + 1].Focus();
								}
								else
								{
									ApplyButton.Focus();
								}
							}
							break;
						}
					}
					break;
			}
		}

		private void Button_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Escape:
					Varor.Select();
					if (Varor.Items.Count > 0 && Varor.SelectedItems.Count <= 0) { Varor.Items[0].Selected = true; }
					e.SuppressKeyPress = true;
					break;
			}

			e.Handled = true;
		}

		private void Box_Enter(object sender, EventArgs e)
		{
			if (NameBox.Focused)
			{
				NameBox.SelectAll();
			}
			if (CountBox.Focused)
			{
				CountBox.SelectAll();
			}
			if (PriceBox.Focused)
			{
				PriceBox.SelectAll();
			}
		}

		public void SetDatabase()
		{
			var dbVaror = database.GetCollection<BsonDocument>("Varor");
			var documents = dbVaror.Find(new BsonDocument()).ToList();
			foreach (BsonDocument vara in documents)
			{
				dbVaror.DeleteOne(vara);
			}

			List<BsonDocument> varor = new List<BsonDocument>();

			foreach (ListViewItem item in Varor.Items)
			{
				string name = item.SubItems[0].Text;
				string count = item.SubItems[1].Text;
				string price = item.SubItems[2].Text;
				string adress = item.SubItems[3].Text;

				var vara = new BsonDocument
				{
					{"name", name},
					{"count", count},
					{"price", price},
					{"adress", adress}
				};

				varor.Add(vara);
			}

			dbVaror.InsertMany(varor);
		}

		private void ReloadButton_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in Varor.Items)
			{
				Varor.Items.Remove(item);
			}


			var dbVaror = database.GetCollection<BsonDocument>("Varor");
			var documents = dbVaror.Find(new BsonDocument()).ToList();
			foreach (BsonDocument vara in documents)
			{
				string name = vara.GetValue(1).ToString();
				string price = vara.GetValue(2).ToString();
				string count = vara.GetValue(3).ToString();
				string adress = vara.GetValue(4).ToString();

				ListViewItem item = new ListViewItem(name, 0);
				item.SubItems.Add(count);
				item.SubItems.Add(price);
				item.SubItems.Add(adress);

				Varor.Items.Add(item);
			}
		}
	}
}

