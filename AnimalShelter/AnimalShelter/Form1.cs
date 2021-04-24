using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace AnimalShelter
{
	public partial class Form1 : Form
	{
		public List<Customer> customers = new List<Customer>();

		public Form1()
		{
			InitializeComponent();
		}

		private void CusNewButton_Click(object sender, EventArgs e)
		{
			Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
			cus.address = CusNewAddress.Text;
			cus.description = CusNewDescription.Text;

			CusList.Rows.Add(cus.firstName, cus.Age, cus.IsQualified);

			customers.Add(cus);

			ClearCusNew();
		}

		public void ClearCusNew()
		{
			CusNewFirstName.Text = "";
			CusNewLastName.Text = "";
			CusNewBirthday.Text = "";
			CusNewAddress.Text = "";
			CusNewDescription.Text = "";
		}

		public void ShowDetails(Customer cus)
		{
			CusFullName.Text = cus.firstName + " " + cus.lastName;
			CusAge.Text = cus.Age.ToString();
			CusAddress.Text = cus.address;
			CusDescription.Text = cus.description;
			CusIsQualified.Text = cus.IsQualified.ToString();
		}

		private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string firstname = (String)CusList.Rows[e.RowIndex].Cells[0].Value;

			foreach (var cus in customers)
			{
				if (cus.firstName == firstname)
				{
					ShowDetails(cus);
					break;
				}
			}

			CusDetailPanel.Show();
			CusNewPanel.Hide();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CusListPanel.Dock = DockStyle.Fill;
			CusDetailPanel.Dock = DockStyle.Right;
			CusNewPanel.Dock = DockStyle.Right;
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			CusNewPanel.Show();
			CusDetailPanel.Hide();
		}
	}
}
