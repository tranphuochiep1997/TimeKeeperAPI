namespace TimeKeeperAPI.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TimeKeeperAPI.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeKeeperAPI.Data.TimeKeeperContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TimeKeeperAPI.Data.TimeKeeperContext context)
        {
            var users = new List<User>
            {
                new User
                {
                    ID = Guid.NewGuid(),
                    FullName = "Tran Phuoc Hiep",
                    Phone = "01264572058",
                    Email = "tranphuochiep1997@gmail.com",
                    Password = "tranphuochiep1997"
                },
                new User
                {
                    ID = Guid.NewGuid(),
                    FullName = "Nguyen Cong Danh",
                    Phone = "01234567892",
                    Email = "nguyencongdanh@gmail.com",
                    Password = "nguyencongdanh1997"
                },
            };
            users.ForEach(u => context.Users.AddOrUpdate(s => s.ID, u));
            context.SaveChanges();

            var memories = new List<Memory>
            {
                new Memory
                {
                    ID = Guid.NewGuid(),
                    UserID = (Guid)users.Single(s => s.FullName.Equals("Tran Phuoc Hiep")).ID,
                    FileName = "HaLongBay",
                    Location = "Ha long",
                    CreatedAt = DateTimeOffset.Now
                },
                new Memory
                {
                    ID = Guid.NewGuid(),
                    UserID = (Guid)users.Single(s => s.FullName.Equals("Tran Phuoc Hiep")).ID,
                    FileName = "HoiAn",
                    Location = "HoiAn",
                    CreatedAt = DateTimeOffset.Now
                },
            };
            memories.ForEach(s => context.Memories.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();

            var works = new List<Work>
            {
                new Work
                {
                    ID = Guid.NewGuid(),
                    Color = Color.color1,
                    UserID = (Guid)users.Single(s => s.FullName.Equals("Tran Phuoc Hiep")).ID,
                    WorkName = "Highland Waiter",
                }
            };
            works.ForEach(s => context.Works.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();

            var timeItems = new List<TimeItem>
            {
                new TimeItem
                {
                    ID = Guid.NewGuid(),
                    StartAt = DateTimeOffset.Now,
                    EndAt = DateTimeOffset.Now.AddHours(4),
                    Description = "Ngay dau tien di lam",
                    WorkID = (Guid)works.FirstOrDefault(s => s.WorkName.Equals("Highland Waiter")).ID
                },
                new TimeItem
                {
                    ID = Guid.NewGuid(),
                    StartAt = DateTimeOffset.Now.AddHours(6),
                    EndAt = DateTimeOffset.Now.AddHours(9),
                    Description = "",
                    WorkID = (Guid)works.FirstOrDefault(s => s.WorkName.Equals("Highland Waiter")).ID
                }
            };
            timeItems.ForEach(s => context.TimeItems.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();
        }
    }
}
