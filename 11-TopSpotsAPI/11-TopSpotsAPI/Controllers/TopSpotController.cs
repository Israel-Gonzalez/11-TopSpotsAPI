using _11_TopSpotsAPI.App_Start;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using static System.Net.WebRequestMethods;

namespace _11_TopSpotsAPI.Controllers
{
    [EnableCors(origins: "http://127.0.0.1:8080", headers: "*", methods: "*")]   

    public class TopSpotController : ApiController
    {
        // GET: api/TopSpot
        public IEnumerable<TopSpots> Get()
        {
          
            string json = System.IO.File.ReadAllText("c://topspots.json");
            var objects = JsonConvert.DeserializeObject<List<TopSpots>>(json);
            return objects;
        }

        // GET: api/TopSpot/5
        public string Get(int id)
        {
            return "objects";
        }

        // POST: api/TopSpot
        public IEnumerable<TopSpots> Post() 
        {
            string json = System.IO.File.ReadAllText("c://topspots.json");
            var objects = JsonConvert.DeserializeObject<List<TopSpots>>(json);
            return objects;

        }

        // PUT: api/TopSpot/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpot/5
        public void Delete(int id)
        {
        }
    }
}


