﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DataAccess.Repository.IRepository
{
	public interface IUnitOfWork
	{
		ICategoryRepository Category { get; }
		ICoverRepository Cover { get; }
		IProductRepository Product { get; }
		ICompanyRepository Company { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IShoppingCartRepository ShoppingCart { get; }
		IOrderHeaderRepository OrderHeader { get; }
		IOrderDetailRepository OrderDetail { get; }
		void Save();
	}
}
