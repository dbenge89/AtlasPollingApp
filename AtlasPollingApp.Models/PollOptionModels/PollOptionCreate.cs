using AtlasPollingApp.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasPollingApp.Models.PollOptionModels
{
    public class PollOptionCreate
    {
        public int PollId { get; set; }
        [Required]
        public string ChoiceDescription { get; set; }
    }
}
