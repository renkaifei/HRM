using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.Domain
{
    public class UserDomain
    {
        private int userID;
        [Required]
        public int UserID
        {
            get{ return userID;}
            set
            {
                if(userID == value) return;
                userID = value;
            }
        }

        private string name;
        [Required]
        [StringLength(60, ErrorMessage="用户名不能超过60字符")]
        public string Name
        {
            get{ return name;}
            set
            {
                if(name == value) return;
                name = value;
            }
        }
    
        private string pwd;
        [Required]
        [StringLength(60, ErrorMessage = "密码长度不能超过60字符")]
        public string Pwd
        {
            get{ return pwd; }
            set
            {
                if(pwd == value) return;
                pwd = value;
            }
        }
    }
}