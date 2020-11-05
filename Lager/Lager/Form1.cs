using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lager
{
	public partial class Lager : Form
	{
		public Lager()
		{
			InitializeComponent();
			CreateMyListView();
			itemLabel.Text = "Item: ";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		public void CreateMyListView()
		{
			int itemCount = 20;

			ListViewItem[] items = new ListViewItem[itemCount];

			varor.Scrollable = true;
			varor.MultiSelect = true;
			varor.View = View.Details;
			Random random = new Random();

			for (int i = 0; i < items.Length; i++)
			{
				ListViewItem item = new ListViewItem("Item" + i, 0);
				string price = random.Next(0, 100).ToString();
				string count = random.Next(0, 1000).ToString();
				item.SubItems.Add(count);
				item.SubItems.Add(price);

				varor.Items.Add(item);
			}

			varor.Sorting = SortOrder.Ascending;

			varor.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
			varor.Columns.Add("Count", -2, HorizontalAlignment.Left);
			varor.Columns.Add("Price", -2, HorizontalAlignment.Left);
		}

		private void varor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (varor.SelectedItems.Count > 0)
			{
				var item = varor.SelectedItems[0];

				itemLabel.Text = "Item: " + item.Text;

				var name = varor.Items[varor.SelectedItems[0].Index].SubItems[0].Text;
				var count = varor.Items[varor.SelectedItems[0].Index].SubItems[1].Text;
				var price = varor.Items[varor.SelectedItems[0].Index].SubItems[2].Text;
				nameBox.Text = name;
				countBox.Text = count;
				priceBox.Text = price;

				item.Checked = true;
			}
			else
			{
				itemLabel.Text = "Item:";
				nameBox.Text = "";
				countBox.Text = "";
				priceBox.Text = "";
			}

			UpdateSelection();
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in varor.Items)
			{
				if (item.Checked)
				{
                    int i = item.Index-1;
                    if (i < 0) { i = 1; }
                    if (varor.Items.Count == 1) { i = 0; }

                    if(varor.Items.Count >= 1)
                    {
                        varor.Items.Remove(item);
					    varor.Items[i].Selected = true;
                        varor.Items[i].Focused = true;
                    }

                    varor.Select();
					UpdateSelection();
				}
			}
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			ListViewItem item = new ListViewItem("Item" + varor.Items.Count, 0);
			string price = random.Next(0, 100).ToString();
			string count = random.Next(0, 1000).ToString();
			item.SubItems.Add(count);
			item.SubItems.Add(price);
			varor.Items.Add(item);
			varor.Items[item.Index].Selected = true;
			varor.Select();
			UpdateSelection();
		}

		private void varor_Click(object sender, EventArgs e)
		{
			UpdateSelection();
		}

		private void applyButton_Click(object sender, EventArgs e)
		{
			var name = nameBox.Text;
			var count = countBox.Text;
			var price = priceBox.Text;
			if (varor.SelectedItems.Count > 0)
			{
				varor.Items[1].Name = name;
				varor.Items[varor.SelectedItems[0].Index].SubItems[0].Text = name;
				varor.Items[varor.SelectedItems[0].Index].SubItems[1].Text = count;
				varor.Items[varor.SelectedItems[0].Index].SubItems[2].Text = price;
			}
		}

		public void UpdateSelection()
		{
			foreach (ListViewItem item in varor.Items)
			{
				{
					item.Checked = false;
				}
			}
			foreach (ListViewItem item in varor.SelectedItems)
			{
				{
					item.Checked = true;
				}
			}
		}
	}
}
