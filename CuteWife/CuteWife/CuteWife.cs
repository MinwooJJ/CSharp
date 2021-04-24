namespace CuteWife
{
	class CuteWife
	{
		private string wifeName = "";
		private string husbandName = "";
		private int happiness = 50;

		public CuteWife(string wifeName, string husbandName)
		{
			this.wifeName = wifeName;
			this.husbandName = husbandName;
		}

		public void Hug()
		{
			happiness += 100;

			if (happiness >= 100)
				happiness = 100;
		}

		public void Kiss()
		{
			happiness += 20;

			if (happiness >= 100)
				happiness = 100;
		}

		public void Feed()
		{
			happiness += 10;

			if (happiness >= 100)
				happiness = 100;
		}

		public void GetBoard()
		{
			happiness -= 20;
		}

		public string Feeling()
		{
			string message = "";

			if (happiness >= 90)
				message = husbandName + "'s wife " + wifeName + " is extremely Happy!";
			else if (happiness >= 70)
				message = husbandName + "'s wife " + wifeName + " is Happy!";
			else if (happiness >= 50)
				message = husbandName + "'s wife " + wifeName + " is so so";
			else if (happiness >= 30)
				message = husbandName + "'s wife " + wifeName + " is board...";
			else
				message = husbandName + "'s wife " + wifeName + " is sad...";

			return message;
		}
	}
}
