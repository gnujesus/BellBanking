<<<<<<< HEAD
﻿using BellBanking.Core.Application.Interfaces.Services;
using BellBanking.Core.Application.Services;
=======
﻿using BellBanking.Core.Application.Interfaces.Repositories;
>>>>>>> a58eeb483568444a291baf8740922793058765f9
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
=======

>>>>>>> a58eeb483568444a291baf8740922793058765f9
namespace BellBanking.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            #region Services
            //services.AddTransient(typeof(IGenericService<,,>) typeof(GenericService<,,>));
            //services.AddTransient(IProductRepository, ProductService());
            //services.AddTransient(IBeneficiaryRepository, BeneficiaryService());
            //services.AddTransient(ITransactionRepository, TransactionService());
<<<<<<< HEAD
            services.AddTransient<IUserService, UserService>(); ;
=======
>>>>>>> a58eeb483568444a291baf8740922793058765f9
            #endregion
        }
    }
}
