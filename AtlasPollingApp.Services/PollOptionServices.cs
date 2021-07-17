using AtlasPollingApp.API.Data;
using AtlasPollingApp.API.Models;
using AtlasPollingApp.Models.PollOptionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasPollingApp.Services
{
    public class PollOptionServices
    {
        private readonly int _pollID;
        public PollOptionServices(int pollID)
        {
            _pollID = pollID;
        }
        public bool CreatePollOption(PollOptionCreate model)
        {
            var entity = new PollOption()
            {
                PollId = _pollID,
                ChoiceDescription = model.ChoiceDescription
            };

            return false;
        }
    }
}

      