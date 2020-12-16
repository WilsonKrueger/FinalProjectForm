using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm
{
    public class Animal : IAnimal
    {
        String type;
        int id;
        DateTime dateOfBirth;
        String gender;

        public Animal()
        {
            type = "";
            id = 0;
            dateOfBirth = new DateTime(2000, 1, 1);
            gender = "";
        }

        public Animal(String inType, int inId, DateTime inDateOfBirth, string inGender)
        {
            type = inType;
            id = inId;
            dateOfBirth = inDateOfBirth;
            gender = inGender;
        }

        public String Type
        {
            get => type;
            set => type = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }

        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        public override string ToString()
        {
            return type + ", " + Id + ", " + dateOfBirth.ToString("MM/dd/yyyy") + ", " + gender;
        }
    }
}
