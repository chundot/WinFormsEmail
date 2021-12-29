using SqlSugar;
using System;
using System.IO;
using wfemail.db.entity;

namespace wfemail
{
    public class DB
    {
        public SqlSugarClient db;
        public SimpleClient<Account> acnt;

        public DB()
        {
            db = newClient();
            acnt = new SimpleClient<Account>(db);
        }

        public SqlSugarClient newClient()
        {
            string db = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\.mailc\\mail.db";
            var client = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = $"Datasource={db}",
                DbType = DbType.Sqlite,
                IsAutoCloseConnection = true
            });
            if (!File.Exists(db))
                newDb(client);
            return client;
        }

        public void newDb(SqlSugarClient client)
        {
            client.DbMaintenance.CreateDatabase();
            Type[] arr = { typeof(Account), typeof(Config) };
            client.CodeFirst.InitTables(arr);
        }
    }
}