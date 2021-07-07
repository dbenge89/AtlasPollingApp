using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasPollingApp.API.Models
{
    public class Poll
    {
        public Guid AuthorGuid { get; set; }
        public int Id { get; set; }
        public List<Vote> Votes { get; set; }
        public bool IsPublished { get; set; }

    }
}
