using AtlasPollingApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasPollingApp.Models.PollModels
{
    public class PollDetail
    {
        public int Id { get; set; }
        public Guid AuthorGuid { get; set; }
        public string Description { get; set; }
        public List<PollOption> PollOptions { get; set; }
        public List<Vote> Votes { get; set; }
        public bool IsPublished { get; set; }
    }
}
