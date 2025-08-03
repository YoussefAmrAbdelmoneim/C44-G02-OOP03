using System.Globalization;

namespace Assignment_3
{
    internal class Employees
    {
        #region Attributes
        private int id;
        private string? name;
        private SecurityLevel security;
        private decimal salary;
        private HiringDate hireDate;
        private char gender;
        #endregion
        #region Constructor
        public Employees(int id, string? name, SecurityLevel security, decimal salary, HiringDate hireDate, char gender)
        {
            this.id = id;
            this.name = name;
            this.security = security;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;
        }
        #endregion
        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public SecurityLevel Security
        {
            get { return security; }
            set { security = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value >= 0 ? value : 0; }
        }

        public HiringDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value ; }
        }

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
        #endregion
        #region Methods
        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetName(string name)
        {
            if (name is not null)
            {
                this.name = name;
            }
            else
            {
                Console.WriteLine("Invalid, Because of Null");
            }
        }

        public string? GetName()
        {
            return name;
        }

        public void SetSecurity(SecurityLevel security)
        {
            this.security = security;
        }

        public SecurityLevel GetSecurity()
        {
            return security;
        }

        public void SetSalary(decimal salary)
        {
            if (salary >= 0)
                this.salary = salary;
            else
                Console.WriteLine("Invalid Because of negative");
        }

        public decimal GetSalary()
        {
            return salary;
        }

        public void SetHireDate(HiringDate hiringDate)
        {
                this.hireDate = hiringDate;
        }

        public HiringDate GetHireDate()
        {
            return hireDate;
        }

        public void SetGender(char gender)
        {
            if (gender == 'M' || gender == 'F')
                this.gender = gender;
            else
                Console.WriteLine("Gender must be M or F ");
        }

        public char GetGender()
        {
            return gender;
        }

        public override string ToString()
        {
            return $"Id={id}\nName={name}\nGender={gender}\nSecurity={security}\nSalary={string.Format(CultureInfo.CurrentCulture, "{0:C}", salary)}\nHireDate={hireDate}";
        }
        #endregion
    }
}
