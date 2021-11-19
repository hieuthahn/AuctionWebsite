using Auction.Data;
using Auction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Services
{
    public class SharedService
    {
        public int SavePicture(Auction.Entities.Picture picture)
        {
            AuctionContext context = new AuctionContext();

            context.Pictures.Add(picture);

            context.SaveChanges();

            return picture.ID;
        }
    }
}
