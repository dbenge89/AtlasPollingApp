using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasPollingApp.API.Models
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }
        public Guid UserGuid { get; set; }
    }
}
