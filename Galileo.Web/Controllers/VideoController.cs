using Galileo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Galileo.Web.Controllers
{
    public class VideoController : ApiController
    {

        private VideoDB _videoDB;

        public VideoController()
        {
            _videoDB = new VideoDB();
            _videoDB.Configuration.ProxyCreationEnabled = false;
        }
         
        public class Video
        {
            public int Id { get; set; }
            public String Name { get; set; }
        }

        // GET: api/Video
        public IEnumerable<Video> Get()
        {
            return _videoDB.Videos;
        }

        // GET: api/Video/5
        public String Get(int id)
        {
            return "value";
        }

        // POST: api/Video
        public Video Post([FromBody] Video value)
        {
            return value;
        }

        // PUT: api/Video/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Video/5
        public void Delete(int id)
        {
        }
    }
}
