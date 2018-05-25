using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeKeeperAPI.Data;
using TimeKeeperAPI.Models;

namespace TimeKeeperAPI.Repositories
{
    public interface IMemoryRepository : IRepository<Memory>
    {

    }
    public class MemoryRepository : Repository<Memory>, IMemoryRepository
    {
        public MemoryRepository(TimeKeeperContext context) : base(context)
        {
        }
        public TimeKeeperContext Context
        {
            get { return Context as TimeKeeperContext; }
        }
    }
}