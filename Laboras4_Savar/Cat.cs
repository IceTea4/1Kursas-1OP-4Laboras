namespace Laboras4_Savar
{
	class Cat : AnimalMarked
	{
        private static int VaccinationDurationMonths = 6;

        public Cat(string name, string breed, string owner, string phone, DateTime vaccinationDate, int chipId) : base(name, breed, owner, phone, vaccinationDate, chipId)
        {
        }

        public Cat(string data) : base(data)
        {
            // Base class calls to SetData()
        }

        /// <summary>
        /// Implementation of abstract method of Animal class
        /// </summary>
        /// <returns></returns>
        public override bool isVaccinationExpired()
        {
            return VaccinationDate.AddMonths(VaccinationDurationMonths).CompareTo(DateTime.Now) > 0;
        }

        public override String ToString()
        {
            return String.Format("|{0,-3}|{1,-20}|{2,-9}|{3,-10} ({4})|{5:yyyy-MM-dd}|", ChipId, Breed, Name, Owner, Phone, VaccinationDate);
        }

        public override int CompareTo(object lhs)
        {
            if (lhs is Cat)
            {
                return ChipId.CompareTo((lhs as Cat).ChipId);
            }
            else
            {
                return -1; // when cat and not cat meet
            }
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Cat);
        }

        public bool Equals(Cat cat)
        {
            return base.Equals(cat);
        }

        public override int GetHashCode()
        {
            return ChipId.GetHashCode();
        }
    }
}

