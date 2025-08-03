using System.Globalization;

namespace Assignment_3
{
    internal class Employees
    {
        private char gender;
        public int ID { get; set; }
        public string? Name { get; set; }
        public SecurityLevel Security { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public char Gender
        {
            get { return gender; }
            set {
                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("Gender must be M or F ");
                }
            }
        }
        public override string ToString()
        {
            return $"Id={ID}\nName={Name}\nGender={gender}\nSecurity={Security}\nSalary={string.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}\nHireDate={HireDate}";
        }

    }
}
