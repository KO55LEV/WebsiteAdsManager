using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webUI.Models
{
    public class ServiceAd
    {
        public int Id { get; set; }
        public Guid SecureId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Caption { get; set; }
        public string Body { get; set; }
        public string Tags { get; set; }
        public int DateCreated { get; set; }
    }
}
