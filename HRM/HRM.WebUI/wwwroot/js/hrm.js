///<reference path="../lib/jquery/dist/jquery.min.js">
(function(window){
    var hrm = {};

    hrm.domain = {};
    hrm.domain.user = function(){
        this.id = "";
        this.name = "";
        this.loginNmae = "";
        this.pwd = "";

        this.AfterGetOne = function(){

        };
    }

    hrm.service = {};

    hrm.service.userService ={
        getOne:function(user){
            $.ajax({
                url:"/User/GetOneByNameWithPwd",
                contentType:"application/x-www-form-urlencoded",
                type:"post",
                data:{ loginName:user.loginName,pwd:user.pwd },
                dataType:"json",
                success:function(data){
                    user.id = data.id;
                    user.name = data.name;
                    user.loginName = data.loginName;
                    user.AfterGetOne();
                },
                error:function(data){
                    console.log(data);
                }
            });
        }
    }

    window.hrm = hrm;
})(window);