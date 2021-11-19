using Auction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction.Web.ViewsModels
{
    public class AuctionsListingViewModels : PageViewModels
    {
        public List<Auction.Entities.Auction> Auctions { get; set; }
    }
    public class AuctionsViewModels : PageViewModels
    {
        public List<Auction.Entities.Auction> AllAuctions { get; set; }
        public List<Auction.Entities.Auction> PromotedAuctions { get; set; }
    }

    public class AuctionsDetailsViewModels : PageViewModels
    {
        public Auction.Entities.Auction Auction { get; set; }
    }

    public class CreateAuctionViewModels : PageViewModels
    {
        public int CategoryID { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal ActualAmount { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public string AuctionPictures { get; set; }

        public List<Category> Categories { get; set; }
        public int ID { get; set; }
        public List<AuctionPicture> AuctionPicturesList { get; set; }
    }
}