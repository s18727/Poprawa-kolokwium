using Poprawa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poprawa.Services
{
    public interface IDbService
    {

        PetDTO GetPets(int id);

    }
}
