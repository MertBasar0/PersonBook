using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AppUser : IdentityUser<int>
    {
        private DateTime _createTime = DateTime.Now;

        public DateTime createTime { get => _createTime; set => _createTime = value; }

        public DateTime deleteTime { get; set; }

        public DateTime updateTime { get; set; }

        private UserStatus _status = UserStatus.Active;

        public UserStatus status { get => _status; set => _status = value; }
    }
}
