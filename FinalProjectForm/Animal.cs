using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm
{
    public class Animal : IAnimal
    {
        Guid num;
        int id;
        String type;
        String gender;
        DateTime dateOfBirth;

        public Animal()
        {
            num = Guid.NewGuid();
            id = 0;
            type = "";
            gender = "";
            dateOfBirth = new DateTime();
        }

        public Animal(Guid inNum, int inId, String inType, string inGender, DateTime inDateOfBirth)
        {
            num = inNum;
            id = inId;
            type = inType;
            gender = inGender;
            dateOfBirth = inDateOfBirth;
        }

        public String Display
        {
            get => type + ", " + Id + ", " + dateOfBirth.ToString("MM/dd/yyyy") + ", " + gender;
        }

        public Guid Num
        {
            get => num;
            set => num = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public String Type
        {
            get => type;
            set => type = value;
        }
        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }

        public override string ToString()
        {
            return type + ", " + Id + ", " + dateOfBirth.ToString("MM/dd/yyyy") + ", " + gender;
        }
    }
}
