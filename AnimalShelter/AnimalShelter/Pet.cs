namespace AnimalShelter
{
	public class Pet
	{
		public int petId;
		public string name;
		public string color;
		public string gender;
		public string description;

		public Pet(int petId, string name, string color, string gender)
		{
			this.petId = petId;
			this.name = name;
			this.color = color;
			this.gender = gender;
		}

		public virtual string MakeSound()
		{
			return "";
		}
	}
}
