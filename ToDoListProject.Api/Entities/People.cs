using System.Text.RegularExpressions;

namespace ToDoList.Project.Entities
{
    public class People : BaseEntity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MobileNumber { get; private set; }
        public string? Email { get; private set; }
        public People(
            string firstName,
            string lastName,
            string mobileNumber,
            string email = ""
            )
        {
            FullNameValidation(firstName, lastName);
            MobileNumberValidation(mobileNumber);
            if (!string.IsNullOrEmpty(email))
                EmailValidation(email);
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            Email = email;
        }

        #region ValidateInpouts

        private void FullNameValidation(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new Exception("FirstName Is Requierd");

            if (string.IsNullOrEmpty(lastName))
                throw new Exception("LastName Is Requierd");
        }
        public void MobileNumberValidation(string phoneNumber)
        {
            if (phoneNumber.Length != 11)
                throw new Exception("");

            string pattern = @"^0(9[0-9]{9})$";
            if (!Regex.IsMatch(phoneNumber, pattern))
                throw new Exception();
        }
        public void EmailValidation(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (!Regex.IsMatch(email, pattern))
                throw new Exception();
        }


        #endregion

        #region Update People

        public void UpdatePeople(string firstName, string lastName, string mobileNumber, string email = "")
        {
            FullNameValidation(firstName, lastName);
            MobileNumberValidation(mobileNumber);
            if (!string.IsNullOrEmpty(email))
                EmailValidation(email);
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            Email = email;
        }

        #endregion


    }

}