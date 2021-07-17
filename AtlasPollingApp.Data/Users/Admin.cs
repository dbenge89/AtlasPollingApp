using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasPollingApp.API.Models
{
    public class Admin : User
    {
        public List<Poll> Polls { get; set; }
    }
}
