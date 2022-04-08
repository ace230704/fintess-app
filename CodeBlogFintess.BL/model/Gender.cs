using System;

namespace CodeBlogFintess.BL.model
{
    /// <summary>
    /// gender
    /// </summary>
    public class Gender
    { 
        public string Name { get; }

        public Gender(string name) 
        {
            /// <summary>
            ///  gender's value
            /// </summary>
            /// <param name="name"></param>
            if (string.IsNullOrWhiteSpace(name)) 
            {
                throw new ArgumentNullException("Name field can not be empty",nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
