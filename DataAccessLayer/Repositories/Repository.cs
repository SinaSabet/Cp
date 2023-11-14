using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositoreis
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DataBaseContext _Context;
        private readonly DbContextOptions<DataBaseContext> _contextOptions;
        private new readonly IServiceScopeFactory _scopeFactory;
        private readonly IServiceProvider _serviceProvider;

        public Repository(DataBaseContext dataBaseContext,
            DbContextOptions<DataBaseContext> contextOptions,
            IServiceProvider serviceProvider,
            IServiceScopeFactory scopeFactory)
        {
            _Context = dataBaseContext;
            _scopeFactory = scopeFactory;
            _serviceProvider = serviceProvider;
            _contextOptions = contextOptions;
        }

        public async Task<bool> Delete(int Id)
        {
            var entity = await _Context.Set<T>().FindAsync(Id);
            _Context.Set<T>().Remove(entity);
            return Convert.ToBoolean(_Context.SaveChangesAsync().Result);

        }

        public async Task<T> Get(int Id)
        {
            return await _Context.Set<T>().FindAsync(Id);
        }

        public async Task<List<T>> GetList()
        {
            return await _Context.Set<T>().ToListAsync();
        }


        public async Task<bool> Insert(T Entity)
        {
            await _Context.Set<T>().AddAsync(Entity);
            return Convert.ToBoolean(_Context.SaveChangesAsync().Result);
        }

        public async Task<bool> Attach(T Entity)
        {
            _Context.Set<T>().Attach(Entity);
            return Convert.ToBoolean(await _Context.SaveChangesAsync());
        }
        public async Task<bool> Update(T Entity)
        {
            _Context.Set<T>().Update(Entity);
            return Convert.ToBoolean(await _Context.SaveChangesAsync());
        }






        public async Task<bool> Delete_WithNewContext(int Id)
        {
            var scope = _scopeFactory.CreateScope();
            var scopedContext = scope.ServiceProvider.GetRequiredService<DataBaseContext>();
            var entity = await scopedContext.Set<T>().FindAsync(Id);
            _Context.Set<T>().Remove(entity);
            return Convert.ToBoolean(scopedContext.SaveChangesAsync().Result);
        }

        public async Task<T> Get_WithNewContext(int Id)
        {
            var scope = _scopeFactory.CreateScope();
            var scopedContext = scope.ServiceProvider.GetRequiredService<DataBaseContext>();
            return await scopedContext.Set<T>().FindAsync(Id);
        }

        public async Task<List<T>> GetList_WithNewContext()
        {
            var scope = _scopeFactory.CreateScope();
            var scopedContext = scope.ServiceProvider.GetRequiredService<DataBaseContext>();
            return await scopedContext.Set<T>().ToListAsync();
        }


        public async Task<bool> Insert_WithNewContext(T Entity)
        {
            var scope = _scopeFactory.CreateScope();
            var scopedContext = scope.ServiceProvider.GetRequiredService<DataBaseContext>();
            await scopedContext.Set<T>().AddAsync(Entity);
            return Convert.ToBoolean(scopedContext.SaveChangesAsync().Result);
        }

        public async Task<bool> Attach_WithNewContext(T Entity)
        {
            var scope = _scopeFactory.CreateScope();
            var scopedContext = scope.ServiceProvider.GetRequiredService<DataBaseContext>();
            scopedContext.Set<T>().Attach(Entity);
            return Convert.ToBoolean(await scopedContext.SaveChangesAsync());
        }
        public async Task<bool> Update_WithNewContext(T Entity)
        {
            var scope = _scopeFactory.CreateScope();
            var scopedContext = scope.ServiceProvider.GetRequiredService<DataBaseContext>();
            scopedContext.Set<T>().Update(Entity);
            return Convert.ToBoolean(await scopedContext.SaveChangesAsync());
        }

    }

}
