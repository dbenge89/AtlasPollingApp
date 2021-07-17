using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AtlasPollingApp.API.Models
{
    public class PollOption
    {
        [Required]
        public string ChoiceDescription { get; set; }
        public int PollId { get; set; }
        [ForeignKey(nameof(PollId))]
        public virtual Poll Poll { get; set; }
    }
}
