﻿using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Data.Entity
{
    namespace MvcMusicStore.Models
    {
        public class MusicStoreEntities : DbContext
        {
            public MusicStoreEntities()
                : base("MusicStoreConnection")
            {
            }
            public DbSet<Genre> Genres { get; set; }
            public DbSet<Album> Albums { get; set; }
            public DbSet<Artist> Artists { get; set; }
        }
    }
}