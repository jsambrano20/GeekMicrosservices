using GeekShopping.Email.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.Email.Model
{
    [Table("email_log")]
    public class EmailLog : BaseEntity
    {
        [Column("email")]
        public string email { get; set; }

        [Column("Log")]
        public string log { get; set; }

        [Column("sent_date")]
        public DateTime SentDate{ get; set; }
    }
}
