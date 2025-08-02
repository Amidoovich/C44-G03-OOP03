namespace S3
{
    internal class Employee
    {


        #region Attributes
        //private int Id;
        //private string? Name;
        //private Security SecurityLevel;
        //private decimal Salary;
        //private HiringDate HireDate;
        //private Gender Gender;


        #endregion

        #region Properties
        public int Id { get; set; }

        public string?  Name { get; set; }

        public Security SecurityLevel { get; set; }

        public decimal Salary { get; set; }

        public HiringDate HireDate { get; set; }

        public Gender  Gender { get; set; }

        #endregion
        #region Constructors
        public Employee(int id, string? name, Security securityLevel, decimal salary, HiringDate hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        //public Employee(int id, string? name, Security securityLevel, decimal salary, HiringDate hireDate, Gender gender)
        //{
        //    SetId(id);
        //    SetName(name);
        //    SetSecurityLevel(securityLevel);
        //    SetSalary(salary);
        //    SetHireDate(hireDate);
        //    SetGender(gender);
        //}

        #endregion




        #region Getters and Setters
        //public void SetId (int id)
        //{ 
        //    this.Id = id; 
        //}
        //public int GetId ()
        //{
        //    return this.Id;
        //}

        //public void SetName (string? name)
        //{
        //    this.Name = name;
        //}

        //public string GetName()
        //{
        //    return this.Name;
        //}

        //public void SetSecurityLevel (Security SecurityLevel)
        //{
        //    this.SecurityLevel = SecurityLevel;
        //}

        //public Security GetSecurityLevel()

        //{
        //    return this.SecurityLevel;
        //}
        //public void SetHireDate (HiringDate hiringDate)
        //{
        //    this.HireDate = hiringDate;
        //}

        //public HiringDate GetHiringDate()
        //{
        //    return this.HireDate;
        //}

        //public void SetSalary(decimal Salary)
        //{
        //    this.Salary = Salary;
        //}

        //public decimal GetSalary()
        //{
        //    return this.Salary;
        //}

        //public void SetGender(Gender gender)
        //{
        //    this.Gender = gender;
        //}

        //public Gender GetGender()
        //{ 
        //    return this.Gender; 
        //}


        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("Id : {0}\nName : {1}\nSecurity Level : {2}\nSalary : {3:C}\nHire Date : {4}\nGender : {5}",Id,Name,SecurityLevel,Salary,HireDate,Gender);
        }
        #endregion


    }
}
