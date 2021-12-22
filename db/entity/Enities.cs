using SqlSugar;

namespace wfemail.db.entity
{
    [SugarTable("account")]
    public class Account
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int a_id { get; set; }
        public string a_account { get; set; }
        public string a_pass { get; set; }
        public string a_smtp { get; set; }
        public int a_smtp_port { get; set; }
        public string a_imap { get; set; }
        public int a_imap_port { get; set; }
    }

    [SugarTable("config")]
    public class Config
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string co_id { get; set; }
        public string co_value { get; set; }
    }
}