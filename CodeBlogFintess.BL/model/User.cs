using System;

namespace CodeBlogFintess.BL.model
{
    /// <summary>
    /// user
    /// </summary>
    public class User
    {
        #region properties
        /// <summary>
        /// create new user
        /// </summary>
        public string Name { get; }

        public Gender Gender { get; }

        public DateTime BirthDate { get; }

        public double Weight { get; set; }

        public double Height { get; set; }
        #endregion

        public User(string name,Gender gender,DateTime birthDate,double weight,double height) 
        {

            #region checking exception
            if (string.IsNullOrWhiteSpace(name)) 
            {
                throw new ArgumentNullException("Name field can not be empty",nameof(name));
            }

            if (gender == null) 
            {
                throw new ArgumentNullException("Gender field can not be null",nameof(gender));
            }

            if (birthDate <DateTime.Parse("01.01.1900")  || BirthDate>=DateTime.Now) 
            {
                throw new ArgumentException("Wrong birghdate value",nameof(birthDate));
            }

            if (weight <= 0) 
            {
                throw new ArgumentException("Wrong weith value",nameof(weight));
            }

            if (height <= 0) 
            {
                throw new ArgumentException("Wrong heith value",nameof(height));
            }
            #endregion


            name = Name;
            gender = Gender;
            birthDate = BirthDate;
            weight = Weight;
            height = Height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
