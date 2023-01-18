@ModelType ManShop.Web.ManShop.Web.Models.LoginViewModel
@Code
    ViewBag.Title = "Login"
    Layout = "~/Views/Shared/Layouts.vbhtml"
End Code
<div class="account_grid">
    <div class="login-right">
        <h3>Đăng nhập</h3>
        @Using (Html.BeginForm("Login", "Account", New With {.returnUrl = ViewBag.ReturnUrl}, FormMethod.Post))
            @Html.ValidationSummary(False, "", New With {.class = "error"})
            @<div>
                <span>Tài khoản<label>*</label></span>
                @Html.TextBoxFor(Function(Model) Model.UserName)
            </div>
            @<div>
                <span>Password<label>*</label></span>
                @Html.PasswordFor(Function(Model) Model.Password)
            </div>
            @<div>
                @Html.CheckBoxFor(Function(Model) Model.RememberMe)
                Nhớ mật khẩu?
            </div>
            @<a Class="forgot" href="#">Forgot Your Password?</a>
            @<input type="submit" value="Login">
        End Using
        @Html.Partial("_ExternalLoginsListPartial", New ManShop.Web.ManShop.Web.Models.ExternalLoginListViewModel With {.ReturnUrl = ViewBag.ReturnUrl})
    </div>
    <div class="login-left">
        <h3>Chưa có tài khoản</h3>
        <p>Nếu bạn chưa có tài khoản vui lòng đăng ký tại link dưới đây:</p>
        <a class="acount-btn" href="/dang-ky.html">Đăng ký thành viên</a>
    </div>
    <div class="clearfix"> </div>
</div>