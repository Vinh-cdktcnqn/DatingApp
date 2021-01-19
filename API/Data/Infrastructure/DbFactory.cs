using System;

namespace API.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        DataContext Init();
    }

    public class DbFactory : Disposable, IDbFactory
    {
        private DataContext _db;

        public DataContext Init()
        {
            return _db ?? (_db = new DbContextFactory().CreateDbContext());
        }

        protected override void DisposeCore()
        {
            if (_db != null)
                _db.Dispose();
        }
    }
}