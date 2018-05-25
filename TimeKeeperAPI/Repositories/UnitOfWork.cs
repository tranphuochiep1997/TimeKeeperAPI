using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeKeeperAPI.Models;

namespace TimeKeeperAPI.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IMemoryRepository Memories { get; }
        IWorkRepository Works { get; }
        ITimeItemRepository TimeItems { get; }
        void Save();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TimeKeeperContext context;
        private IMemoryRepository memoryRepository;
        private IWorkRepository workRepository;
        private ITimeItemRepository timeItemRepository;

        public UnitOfWork(TimeKeeperContext context)
        {
            this.context = context;
        }
        public IMemoryRepository Memories
        {
            get
            {
                if (memoryRepository == null)
                {
                    memoryRepository = new MemoryRepository(context);
                }
                return memoryRepository;
            }
        }
        public IWorkRepository Works
        {
            get
            {
                if (workRepository == null)
                {
                    workRepository = new WorkRepository(context);
                }
                return workRepository;
            }
        }
        public ITimeItemRepository TimeItems
        {
            get
            {
                if (timeItemRepository == null)
                {
                    timeItemRepository = new TimeItemRepository(context);
                }
                return timeItemRepository;
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}