using Assing1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week1.Controllers;

namespace Assing1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirlineController : ControllerBase
    {


        Result _result = new Result();
        List<Airplane> staticList = new List<Airplane>();
        DBOperations DbOpp = new DBOperations();

        [HttpGet]
        public List<Airplane> GetAirplanes()
        {
            return DbOpp.GetAirplanes();
        }

        [HttpGet("{id}")]
        public Airplane GetById(int id)
        {
            //staticList = new List<Airplane>();
            ////staticList = AddAirplane();

            //Airplane resultObject = new Airplane();
            //resultObject = staticList.FirstOrDefault(x => x.airplane_id == id);
            Airplane resultObject = DbOpp.GetAirplane(id);
            return resultObject;
        }


        [HttpPost]
        public Result Post(Airplane airplane)
        {

            //staticList = new List<Airplane>();
            //staticList = AddAirplane();
            

            //var airplaneCheck = staticList.FirstOrDefault(x => x.airplane_id == airplane.airplane_id);
            
            var airplaneList= DbOpp.GetAirplanes();
            var airplaneCheck = airplaneList.FirstOrDefault(x => x.airplane_id == airplane.airplane_id);
            if (airplaneCheck == null)
            {
                DbOpp.AddModel(airplane);
                airplaneList.Add(airplane);
                _result.Status = 1;
                _result.Message = "Yeni eleman listeye eklendi.";
                _result.AirplaneList = airplaneList;
            }

            else
            {
                _result.Status = 0;
                _result.Message = "Eleman zaten listede var.";

            }
            return _result;
        }


        [HttpPut]
        public Result Update(Airplane newValue)
        {
            //staticList = AddAirplane();
            var airplaneList = DbOpp.GetAirplanes();
            Airplane? oldValue = airplaneList.Find(o => o.airplane_models == newValue.airplane_models && o.airplane_type==newValue.airplane_type);

            if (oldValue != null)
            {
                _result.Status = 1;
                _result.Message = "Başarıyla güncellendi.";
                DbOpp.Update(newValue, oldValue);
                _result.AirplaneList = DbOpp.GetAirplanes();

            }

            else
            {
                _result.Status = 0;
                _result.Message = "Bu eleman listede yok.";

            }
            return _result;
        }
        [HttpDelete("{id}")]
        public Result Delete(int id)
        {
            //staticList = AddAirplane();
            var airplaneList = DbOpp.GetAirplanes();
            Airplane? oldValue = airplaneList.Find(o => o.airplane_id== id);

            if (oldValue != null)
            {
                _result.Status = 1;
                _result.Message = "Kulllanıcı başarıyla silindi.";

                DbOpp.Delete(oldValue);
                _result.AirplaneList= DbOpp.GetAirplanes();

            }

            else
            {
                _result.Status = 0;
                _result.Message = "Kullanıcı bu listede yok.";

            }

            return _result;
        }




        //public List<Airplane> AddAirplane()
        //{

        //    //staticList.Add(new Models.Airplane { airplane_id = 1, total_number_of_seats = 220, airplane_models= "Airbus",airplane_type= "A350-900"});
        //    //staticList.Add(new Models.Airplane { airplane_id = 2, total_number_of_seats = 110, airplane_models = "Airbus", airplane_type = "A330-300", leg_number = 2, flight_number = 2 });
        //    //staticList.Add(new Models.Airplane { airplane_id = 3, total_number_of_seats = 130, airplane_models = "Airbus", airplane_type = "A350-200", leg_number = 1, flight_number = 3 });

        //    //staticList.Add(new Models.Airplane { airplane_id = 4, total_number_of_seats = 130, airplane_models = "Boeing", airplane_type = "787-9", leg_number = 1, flight_number = 4 });
        //    //staticList.Add(new Models.Airplane { airplane_id = 5, total_number_of_seats = 110, airplane_models = "Boeing", airplane_type = "737-800", leg_number = 2, flight_number = 6 });
        //    //staticList.Add(new Models.Airplane { airplane_id = 6, total_number_of_seats = 240, airplane_models = "Boeing", airplane_type = "737-900ER", leg_number = 1, flight_number = 8 });
        //    //return staticList;
        //}

    }
}
