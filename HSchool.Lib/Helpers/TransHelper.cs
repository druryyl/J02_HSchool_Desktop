using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Intersolusi.Helper
{
    public static class TransHelper
    {
        public static TransactionScope NewScope(System.Transactions.IsolationLevel isolationLevel)
        {
            return new TransactionScope(TransactionScopeOption.Required,
                new TransactionOptions
                {
                    IsolationLevel = isolationLevel
                });
        }

        public static TransactionScope NewScope()
        {
            return new TransactionScope(TransactionScopeOption.Required,
                new TransactionOptions
                {
                    IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted
                });
        }
    }
}
