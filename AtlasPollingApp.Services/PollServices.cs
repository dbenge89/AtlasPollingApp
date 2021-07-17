using AtlasPollingApp.API.Data;
using AtlasPollingApp.API.Models;
using AtlasPollingApp.Models.PollModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasPollingApp.Services
{
    public class PollServices
    {
        private readonly Guid _userId;
        private readonly AtlasPollingAppAPIContext _db;
        public PollServices(Guid userId)
        {
            _userId = userId;
        }
        public PollServices(AtlasPollingAppAPIContext db)
        {
            _db = db;
        }
        public bool CreatePoll(PollCreate model)
        {
            var entity = new Poll()
            {
                AuthorGuid = _userId,
                Description = model.Description,
                PollOptions = model.PollOptions,
                IsPublished = model.IsPublished
            };
            _db.Polls.AddAsync(entity);
            return _db.SaveChanges() == 1;

        }

        public IEnumerable<PollList> GetPolls()
        {
            var query = _db.Polls
                    .Where(e => e.AuthorGuid == _userId)
                    .Select(
                        e => new PollList
                        {
                            Id = e.Id,
                            Description = e.Description,
                            PollOptions = e.PollOptions,
                            Votes = e.Votes,
                            DateCreated = e.DateCreated,
                            PollStartDate = e.PollStartDate,
                            PollEndDate = e.PollEndDate,
                            DateEdited = e.DateEdited,
                            IsPublished = e.IsPublished
                        });

            return query.ToArray();
        }

        public PollDetail GetPollById(int id)
        {
            var entity = _db.Polls
                .Single(e => e.Id == id && e.AuthorGuid == _userId);
            return
                new PollDetail
                {
                    Id = entity.Id,
                    Description = entity.Description,
                    PollOptions = entity.PollOptions
                };
        }
        public bool UpdatePoll(PollEdit model)
        {

            var entity = _db.Polls
                    .Single(e => e.Id == model.Id && e.AuthorGuid == _userId);

            entity.Description = model.Description;
            entity.PollStartDate = model.PollStartDate;
            entity.PollEndDate = model.PollEndDate;
            entity.DateEdited = DateTime.Now;
            entity.IsPublished = model.IsPublished;

            return _db.SaveChanges() == 1;

        }

        public bool DeletePoll(int postId)
        {
            var entity = _db.Polls
                    .Single(e => e.Id == postId && e.AuthorGuid == _userId);

            _db.Polls.Remove(entity);

            return _db.SaveChanges() == 1;
        }
    }
}
