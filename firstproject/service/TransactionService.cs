using firstproject.Context;
using firstproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstproject.service
{
	public class TransactionService
	{
		private DatabaseContext _db;
		public TransactionService(DatabaseContext db)
		{
			_db = db;
		}
		public void Add(Transaction transaction) {
			transaction.Date = DateTime.Now;
			_db.Transactions.Add(transaction);
			_db.SaveChanges();
		}
		public List<Transaction> GetTransactions()
        {
			return _db.Transactions.ToList();

        }
	}
}
