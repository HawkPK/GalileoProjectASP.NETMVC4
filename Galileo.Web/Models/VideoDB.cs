using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galileo.Web.Models
{
    public class VideoDB : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}
