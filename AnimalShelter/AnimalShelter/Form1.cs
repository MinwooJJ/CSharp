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

			CusPetInfo.Text = "";
			foreach (Pet pet in cus.MyPets)
			{
				CusPetInfo.Text += pet.name + ": " + pet.MakeSound();

				if (pet is Cat)
				{
					CusPetInfo.Text += ":" + (pet as Cat).Scratch();
				}
				else if (pet is Dog)
				{
					CusPetInfo.Text += ":" + (pet as Dog).Bite();
				}

				CusPetInfo.Text += Environment.NewLine;
			}
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

			Customer cus = new Customer("m", "w", new DateTime(1989, 1, 2));

			Cat cat = new Cat(1, "No", "white", "male");
			cus.Adopt(cat);
			Cat cat2 = new Cat(3, "Mid", "Red", "male");
			cus.Adopt(cat2);

			Dog dog = new Dog(2, "Yes", "black", "female", DogBreed.Mixed);
			cus.Adopt(dog);

			customers.Add(cus);
			CusList.Rows.Add(cus.firstName, cus.Age, cus.IsQualified);
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			CusNewPanel.Show();
			CusDetailPanel.Hide();
		}
	}
}
