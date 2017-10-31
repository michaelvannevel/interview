using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTestProject.Models;
using InterviewTestProject.Repositories;
using System.Web.Http;

namespace InterviewTestProject.Controllers
{
    public class ValuesController : ApiController
    {
        private BikeRepository _bikeRepository;

        public ValuesController(BikeRepository bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        /// <summary>
        /// Gets a list of all bikes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public IEnumerable<BikeDc> GetAll(int itemNumber)
        {
            return null;
        }
    }
}
