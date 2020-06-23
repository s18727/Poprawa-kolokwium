using Poprawa.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poprawa.Services
{
    public class DbService : IDbService
    {

        public PetDTO GetPets(int id)
        {
            try
            {
                var db = new MyContext();


                var pet = new Pet()
                { 
                    
                };



                return pet;
            }
            catch
            {
                throw new Exception("zla data");
            }

        }

        public PetDTO GetPets(DateTime DateRegistered)
        {
            throw new NotImplementedException();
        }
    }
}