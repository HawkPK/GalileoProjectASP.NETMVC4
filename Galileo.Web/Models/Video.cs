using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galileo.Web.Models
{
    public class Video
    {
        public virtual int Id { get; set; }
        public virtual String Name { get; set; }
        public virtual int Length { get; set; }
    }
}
