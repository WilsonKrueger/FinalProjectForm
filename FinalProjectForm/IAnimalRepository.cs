using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm
{
    public interface IAnimalRepository
    {
        List<IAnimal> getAllAnimal();
        void addAnimal(IAnimal animal);
        IAnimal getOneAnimal(int index);
    }
}
