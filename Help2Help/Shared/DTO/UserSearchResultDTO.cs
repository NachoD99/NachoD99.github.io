using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help2Help.Shared.DTO
{
    public class UserSearchResultDTO
    {
        public string Name  { get; set; } = string.Empty;
        public string ProfilePicture  { get; set; } = string.Empty;
        public int UserId  { get; set; }   
        public bool IsONGVerified { get; set; }   

    }
}
