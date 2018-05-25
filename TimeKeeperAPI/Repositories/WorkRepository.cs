using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeKeeperAPI.Data;
using TimeKeeperAPI.Models;

namespace TimeKeeperAPI.Repositories
{
    public interface IWorkRepository : IRepository<Work>
    {

    }
    public class WorkRepository : Repository<Work>, IWorkRepository
    {
        public WorkRepository(TimeKeeperContext context) : base(context)
        {
        }
        public TimeKeeperContext Context
        {
            get { return context as TimeKeeperContext; }
        }
    }
}