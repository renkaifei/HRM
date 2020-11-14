using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace HRM.Domain
{
    public class EmployeeDomain:UserDomain
    {
        private string sex;
        [Description("性别")]
        [Required(ErrorMessage="性别不能为空")]
        public string Sex
        {
            get{ return sex; }
            set
            {
                if(sex == value) return;
                sex = value;
            }
        }
    
        private DateTime birthDate;
        [Description("出生日期")]
        [Required(ErrorMessage="出生日期不能为空")]
        public DateTime BirthDate
        {
            get{ return birthDate; }
            set
            {
                if(birthDate == value) return;
                birthDate = value;
            }
        }

        private DateTime timeOfDesignInstitute;
        [Required(ErrorMessage ="入院时间不能为空")]
        [Description("入院时间")]
        public DateTime TimeOfDesignInstitute
        {
            get{ return timeOfDesignInstitute; }
            set
            {
                if(timeOfDesignInstitute == value) return;
                timeOfDesignInstitute = value;
            }
        }
    
        private DateTime timeOfWorking;
        [Required(ErrorMessage="入职时间不能为空")]
        [Description("入职时间")]
        public DateTime TimeOfWorking
        {
            get{ return timeOfWorking; }
            set
            {
                if(timeOfWorking == value) return;
                timeOfWorking = value;
            }
        }

        private DateTime timeOfResearchInstitute;
        [Required(ErrorMessage="入所时间不能为空")]
        [Description("入所时间")]
        public DateTime TimeOfResearchInstitute
        {
            get { return timeOfResearchInstitute; }
            set
            {
                if(timeOfResearchInstitute == value) return;
                timeOfResearchInstitute = value;
            }
        }

        private string technicalTitle;
        [Required(ErrorMessage="技术职称不能为空")]
        [Description("技术职称")]
        public string TechnicalTitle
        {
            get{ return technicalTitle; }
            set
            {
                if(technicalTitle == value) return;
                technicalTitle = value;
            }
        }

        private DateTime timeOfTechnicalTitle;
        [Required(ErrorMessage="职称获取时间不能为空")]
        [Description("职称获取时间")]
        public DateTime TimeOfTechnicalTitle
        {
            get{ return timeOfTechnicalTitle; }
            set
            {
                if(timeOfTechnicalTitle == value) return;
                timeOfTechnicalTitle = value;
            }
        }

        private string jobTitle;
        [Required(ErrorMessage="职务不能为空")]
        [Description("职务")]
        public string JobTitle
        {
            get{ return jobTitle; }
            set
            {
                if(jobTitle == value) return;
                jobTitle = value;
            }
        }

        private string education;
        [Required(ErrorMessage="学历不能为空")]
        [Description("学历")]
        public string Education
        {
            get{ return education; }
            set
            {
                if(education == value) return;
                education = value;
            }
        }

        private string political;
        [Required(ErrorMessage="政治面貌不能为空")]
        [Description("政治面貌")]
        public string Political
        {
            get{return political;}
            set
            {
                if(political == value) return;
                political = value;
            }
        }

        private string telephone;
        [Required(ErrorMessage="电话不能为空")]
        [Description("电话")]
        public string Telephone
        {
            get{ return telephone; }
            set
            {
                if(telephone == value) return;
                telephone = value;
            }
        }

        private string cellphone;
        [Required(ErrorMessage="手机号不能为空")]
        [Description("手机号")]
        public string Cellphone
        {
            get{ return cellphone; }
            set
            {
                if(cellphone == value) return;
                cellphone = value;
            }
        }

        private string email;
        [Required(ErrorMessage="邮箱不能为空")]
        [Description("电子邮箱")]
        public string Email
        {
            get{ return email;}
            set
            {
                if(email == value) return;
                email = value;
            }
        }

        private string wx;
        [Required(ErrorMessage="微信号不能为空")]
        [Description("微信号")]
        public string WX
        {
            get{ return wx; }
            set
            {
                if(wx == value) return;
                wx = value;
            }
        }

        private string dingding;
        [Required(ErrorMessage="钉钉号不能为空")]
        [Description("钉钉号")]
        public string DingDing
        {
            get{ return dingding; }
            set
            {
                if(dingding == value) return;
                dingding = value;
            }
        }

        private string employType;
        [Required(ErrorMessage="用工性质不能为空")]
        [Description("用工性质")]
        public string EmployType
        {
            get{return employType;}
            set
            {
                if(employType == value) return;
                employType = value;
            }
        }
    }
}