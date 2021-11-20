using Auction.Data;
using Auction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Services
{
    public class BidsService
    {

        public bool AddBid(Bid bid)
        {
            AuctionContext context = new AuctionContext();

            context.Bids.Add(bid);
            return context.SaveChanges() > 0;
        }

    }

}
