///<reference  path="../lib/jquery/dist/jquery.min.js">
///<reference path="hrm.js">
$(document).ready(function(){
    pageInit();
});

function pageInit(){
    $("#btnLogin").click(function(){
         var user = new hrm.domain.user();
         user.loginName = $("#userName").val();
         user.pwd = $("#pwd").val();
         user.AfterGetOne = function(){
             alert("登录成功");
         }
         hrm.service.userService.getOne(user);
    });
}