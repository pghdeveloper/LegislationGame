﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace com.nordstrands.games.Legislation.Models
{
    [Table("Bill_Vote")]
    public class Bill_Vote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Bill_VoteID { get; set; }
        public int BillID { get; set; }
        public int PlayerID { get; set; }
        public char vote { get; set; }
    }
}
