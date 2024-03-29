﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entitites;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Users\tiago\www\nlw-expert-cs\RocketseatAuction\leilaoDbNLW.db");
    }
}
