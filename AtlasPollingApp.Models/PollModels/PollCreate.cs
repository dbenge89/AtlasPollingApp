using AtlasPollingApp.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasPollingApp.Models.PollModels
{
    public class PollCreate
    {
        [Required]
        public Guid AuthorGuid { get; set; }
        public string Description { get; set; }
        public List<PollOption> PollOptions { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateEdited { get; set; }
        public DateTime PollStartDate { get; set; }
        public DateTime PollEndDate { get; set; }
        public List<Vote> Votes { get; set; }
        public bool IsPublished { get; set; }
    }
}
