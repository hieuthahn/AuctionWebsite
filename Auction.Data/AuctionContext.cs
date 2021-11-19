using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auction.Entities;

namespace Auction.Data
{
    public class AuctionContext : DbContext
    {
        public AuctionContext() : base("name=AuctionConnectionString")
        {
        }

        public DbSet<Auction.Entities.Category> Categories { get; set; }
        public DbSet<Auction.Entities.Auction> Auctions { get; set; }
        public DbSet<Auction.Entities.Picture> Pictures { get; set; }
        public DbSet<Auction.Entities.AuctionPicture> AuctionPictures { get; set; }
    }
}
