using System;

namespace Shopper.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}