using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositoreis.UserRepository
{
    public  class UserRepo:Repository<User>,IUserRepo
    {
        private readonly DataBaseContext _Context;
        private readonly DbContextOptions<DataBaseContext> _contextOptions;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IServiceProvider _serviceProvider;
        public UserRepo(DataBaseContext dataBaseContext,
         DbContextOptions<DataBaseContext> contextOptions,
         IServiceProvider serviceProvider,
         IServiceScopeFactory scopeFactory)
         : base(dataBaseContext, contextOptions, serviceProvider, scopeFactory)
        {
            _Context = dataBaseContext;
            _scopeFactory = scopeFactory;
            _serviceProvider = serviceProvider;
            _contextOptions = contextOptions;
        }
    }
}
