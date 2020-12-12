using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm
{
    public class AnimalRepository : IAnimalRepository
    {
        List<IAnimal> animalList = new List<IAnimal>();

        public List<IAnimal> getAllAnimal()
        {
            return animalList;
        }

        public void addAnimal(IAnimal animal)
        {
            animalList.Add(animal);
        }

        public IAnimal getOneAnimal(int index)
        {
            return animalList[index];
        }
    }
}
