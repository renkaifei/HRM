using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace HRM.Domain
{
    public class UserDomain
    {
        private int userID;
        [Required]
        [Description("用户ID")]
        [JsonProperty("id")]
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
        [Required(ErrorMessage="用户名不能为空")]
        [StringLength(256, ErrorMessage="用户名不能超过60字符")]
        [JsonProperty("name")]
        public string Name
        {
            get{ return name;}
            set
            {
                if(name == value) return;
                name = value;
            }
        }
    
        private string loginName;
        [Required(ErrorMessage="登录名不能为空")]
        [StringLength(256,ErrorMessage="登录名长度不能超过60字符")]
        [JsonProperty("loginName")]
        public string LoginName
        {
            get{ return loginName;}
            set
            {
                if(loginName == value) return;
                loginName = value;
            }
        }

        private string pwd;
        [Required(ErrorMessage="密码不能为空")]
        [StringLength(256, ErrorMessage = "密码长度不能超过60字符")]
        [JsonIgnore]
        public string Pwd
        {
            get{ return pwd; }
            set
            {
                if(pwd == value) return;
                pwd = value;
            }
        }
    
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}