using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entitites;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new RocketseatAuctionDbContext();

        return repository.Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => DateTime.UtcNow >= auction.Starts && DateTime.UtcNow <= auction.Ends);
    }
}
