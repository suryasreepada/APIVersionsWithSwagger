using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string UserId { get; set; }
    }

    public class UserModelV2: UserModel
    {
        public DateTime StartDate { get; set; }
    }
}
