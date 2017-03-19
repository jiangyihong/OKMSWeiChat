﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OKMS.WeiChat.Model.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string UserPass { get; set; }

        public string Email { get; set; }

        public DateTime PostTime { get; set; }
    }
}
