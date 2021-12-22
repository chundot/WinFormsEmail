using SqlSugar;
using System;
using System.Collections.Generic;
using System.IO;
using wfemail.db.entity;

namespace wfemail
{
    public class DB
    {
        public static SqlSugarClient newClient()
        {
            string db = string.Format("{0}\\.mailc\\mail.db", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            if (!File.Exists(db))
                System.Diagnostics.Debug.Write("db not exist!");
            return new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = string.Format("Datasource={0}", db),
                DbType = DbType.Sqlite,
                IsAutoCloseConnection = true
            });
        }
        public static List<Account> getAccounts()
        {
            return newClient().Queryable<Account>().ToList();
        }
    }
}