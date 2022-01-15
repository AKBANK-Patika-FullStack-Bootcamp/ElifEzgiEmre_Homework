using Assing1.Models;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week1.Controllers
{
    public class DBOperations
    {
        private AirlineContext _airlineContext = new AirlineContext();

       
        public void AddModel(Airplane airplane)
        {
            _airlineContext.Airplanes.Add(airplane);
            _airlineContext.SaveChanges();

        }
        public List<Airplane> GetAirplanes()
        {
            List<Airplane> airplaneList = new List<Airplane>();
            //userList = AddUser();
            airplaneList = _airlineContext.Airplanes.OrderBy(m => m.airplane_id).ToList();
            return airplaneList;

        }

        public Airplane GetAirplane(int id)
        {
            //List<User> userList = new List<User>();
            //userList = AddUser();

            //User resultObject = new User();
            //resultObject = userList.FirstOrDefault(x => x.Id == id);
            //return resultObject;
            return _airlineContext.Airplanes.FirstOrDefault(x => x.airplane_id == id);
        }

        public List<Airplane> Update(Airplane newValue,Airplane oldValue)
        {


            _airlineContext.Airplanes.Remove(oldValue);
            _airlineContext.Airplanes.Add(newValue);
            _airlineContext.SaveChanges();



            return GetAirplanes();
        }
        public void Delete(Airplane oldValue)
        {
            _airlineContext.Airplanes.Remove(oldValue);
            _airlineContext.SaveChanges();

        }

    }
}
