using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimeKeeperAPI.Data;
using TimeKeeperAPI.Repositories;

namespace TimeKeeperAPI.Controllers
{
    [Authorize]
    public class MemoriesController : ApiController
    {
        private IUnitOfWork _unitOfWork;

        public MemoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Memory> GetAll()
        {
            return _unitOfWork.Memories.GetAll();
        }
    }
}
