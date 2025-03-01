using System;

namespace Laboras4_Savar
{
	class AnimalMarked : Animal
	{
        public int ChipId { get; set; }

        public AnimalMarked(string name, string breed, string owner, string phone, DateTime vaccinationDate, int chipId) : base(name, breed, owner, phone, vaccinationDate)
        {
            Name = name;
            ChipId = chipId;
            Breed = breed;
            Owner = owner;
            Phone = phone;
            VaccinationDate = vaccinationDate;
        }

        public AnimalMarked(string data) : base(data)
        {
            SetData(data);
        }

        public override void SetData(string line)
        {
            base.SetData(line);

            string[] values = line.Split(',');
            ChipId = int.Parse(values[2]);
        }

        //?
        public override bool isVaccinationExpired()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as AnimalMarked);
        }

        public bool Equals(AnimalMarked animal)
        {
            if (Object.ReferenceEquals(animal, null))
            {
                return false;
            }

            if (this.GetType() != animal.GetType())
            {
                return false;
            }

            return ChipId == animal.ChipId;
        }

        public override int GetHashCode()
        {
            return ChipId.GetHashCode();
        }

        public override int CompareTo(object a1)
        {
            return ChipId.CompareTo((a1 as AnimalMarked).ChipId);
        }
    }
}

