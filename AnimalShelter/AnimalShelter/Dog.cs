using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
	public enum DogBreed { Mixed, Bulldog, Jindo, Yorkshire };

	public class Dog : Pet
	{
		public DogBreed breed;

		public Dog(int petId, string name, string color, string gender, DogBreed breed)
			: base(petId, name, color, gender)
		{
			this.breed = breed;
		}

		public override string MakeSound()
		{
			return "멍멍";
		}

		public string Bite()
		{
			return "물어뜯기";
		}
	}
}
