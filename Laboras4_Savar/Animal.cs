using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Laboras4_Savar
{
	abstract class Animal
	{
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Owner { get; set; }
        public string Phone { get; set; }
        public DateTime VaccinationDate { get; set; }

        public Animal(string name, string breed, string owner, string phone, DateTime vaccinationDate)
        {
            Name = name;
            Breed = breed;
            Owner = owner;
            Phone = phone;
            VaccinationDate = vaccinationDate;
        }

        public Animal(string data)
        {
            SetData(data);
        }

        public virtual void SetData(string line)
        {
            string[] values = line.Split(',');
            Name = values[1];

            if (values.Length == 6)
            {
                Breed = values[2];
                Owner = values[3];
                Phone = values[4];
                VaccinationDate = DateTime.Parse(values[5]);
            }
            else
            {
                Breed = values[3];
                Owner = values[4];
                Phone = values[5];
                VaccinationDate = DateTime.Parse(values[6]);
            }
        }

        abstract public bool isVaccinationExpired();

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Animal);
        }

        public bool Equals(Animal animal)
        {
            if (Object.ReferenceEquals(animal, null))
            {
                return false;
            }

            if (this.GetType() != animal.GetType())
            {
                return false;
            }

            return Name == animal.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public virtual int CompareTo(object a1)
        {
            return Name.CompareTo((a1 as Animal).Name);
        }
    }
}

