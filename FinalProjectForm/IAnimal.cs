using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm
{
    public interface IAnimal
    {
        Guid Num { get; set; }
        String Type { get; set; }
        int Id { get; set; }
        DateTime DateOfBirth { get; set; }
        String Gender { get; set; }

    }
}
