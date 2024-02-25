using Project.CONF.Options;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClass
{
    public class MyContext :DbContext
    {
        public MyContext() : base ("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new RoomConfiguration());
            modelBuilder.Configurations.Add(new LandViewRoomConfiguration());
            modelBuilder.Configurations.Add(new SuitRoomConfiguration());
            modelBuilder.Configurations.Add(new WithASeaViewRoomConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new ProfileConfiguration());
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<LandViewRoom> LandViewRooms { get; set; }
        public DbSet<SuitRoom> SuitRooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<WithASeaViewRoom> WithASeaViewRooms { get; set; }

    }
}
