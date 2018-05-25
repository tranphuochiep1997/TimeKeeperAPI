using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TimeKeeperAPI.Data;
using TimeKeeperAPI.Models;

namespace TimeKeeperAPI.Repositories
{
    public interface ITimeItemRepository : IRepository<TimeItem>
    {
    }
    public class TimeItemRepository : Repository<TimeItem>, ITimeItemRepository
    {
        public TimeItemRepository(TimeKeeperContext context) : base(context)
        {
        }
        public TimeKeeperContext Context
        {
            get { return Context as TimeKeeperContext; }
        }
    }
}