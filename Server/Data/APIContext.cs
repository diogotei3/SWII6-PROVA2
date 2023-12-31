﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class ServerContext : DbContext
    {
        public ServerContext(DbContextOptions<ServerContext> options) : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; } = default!;

        public DbSet<Produto> Produto { get; set; } = default!;
    }
}
