using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
	public class Customer
	{
		public string firstName;
		public string lastName;
		private DateTime _birthday;
		private bool _isQualified;
		public string address;
		public string description;

		public Customer(string firstName, string lastName, DateTime birthday)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this._birthday = birthday;

			this._isQualified = DateTime.Now.Year - birthday.Year >= 18;
		}

		public DateTime Birthday
		{ 
			get { return _birthday; }
			set
			{
				_birthday = value;
				_isQualified = DateTime.Now.Year - value.Year >= 18;
			}
		}

		public int Age
		{
			get { return DateTime.Now.Year - _birthday.Year; }
		}

		public bool IsQualified
		{
			get { return _isQualified; }
		}
	}
}
