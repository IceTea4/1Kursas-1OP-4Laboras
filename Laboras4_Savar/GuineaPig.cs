using System;

namespace Laboras4_Savar
{
	class GuineaPig : Animal
	{
        private static int VaccinationDuration = 2;

        public GuineaPig(string name, string breed, string owner, string phone, DateTime vaccinationDate) : base(name, breed, owner, phone, vaccinationDate)
        {
        }

        public GuineaPig(string data) : base(data)
        {
        }

        /// <summary>
        /// Implementation of abstract method of Animal class
        /// </summary>
        /// <returns></returns>
        public override bool isVaccinationExpired()
        {
            return VaccinationDate.AddYears(VaccinationDuration).CompareTo(DateTime.Now) > 0;
        }

        public override String ToString()
        {
            return String.Format("|{0,-3}|{1,-20}|{2,-9}|{3,-10} ({4})|{5:yyyy-MM-dd}|", "---", Breed, Name, Owner, Phone, VaccinationDate);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as GuineaPig); //call to type-specific method in the same class
        }

        public bool Equals(GuineaPig guineaPig)
        {
            return base.Equals(guineaPig); //call to base class Animal Equals method
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
	}
}

