@ModelType ManShop.Web.ManShop.Web.Models.RegisterViewModel
@Imports BotDetect.Web.Mvc
@Code
    ViewBag.Title = "Register"
    Layout = "~/Views/Shared/Layouts.vbhtml"
End Code
<link href="@BotDetect.Web.CaptchaUrls.Absolute.LayoutStyleSheetUrl" rel="stylesheet" type="text/css" />
<div class="register">
    @Using (Html.BeginForm("Register", "Account", FormMethod.Post))
        @Html.AntiForgeryToken()
        @Html.ValidationSummary(False, "", New With {.class = "error"})
        @If ViewData("SuccessMsg") IsNot Nothing Then
            @<div class="alert alert-success" role="alert">
                <strong>Chúc mừng bạn! </strong> đã đăng ký thành công.
                <br />Vui lòng click <a href="/dang-nhap.html">vào đây </a>để đăng nhập.
            </div>
        End If
        @<div Class="register-top-grid">
            <h3> Thông tin cá nhân</h3>
            <div Class="mation">
                <Span> Họ tên<label>*</label></Span>
                @Html.TextBoxFor(Function(model) model.FullName)
                <Span> Email<label>*</label></Span>
                @Html.TextBoxFor(Function(model) model.Email)
                <Span> Địa chỉ<label>*</label></Span>
                @Html.TextBoxFor(Function(model) model.Address)
                <Span> Số điện thoại<label>*</label></Span>
                @Html.TextBoxFor(Function(model) model.PhoneNumber)
                <Span> Tài khoản<label>*</label></Span>
                @Html.TextBoxFor(Function(model) model.UserName)
                <Span> Mật khẩu<label>*</label></Span>
                @Html.PasswordFor(Function(model) model.Password)
                @Code
                    Dim registerCaptcha As MvcCaptcha = New MvcCaptcha("registerCaptcha")
                End code
                @Html.Captcha(registerCaptcha)
                @Html.TextBox("CaptchaCode")
            </div>
            <div Class="clearfix"> </div>
        </div>
        @<div Class="clearfix"> </div>
        @<div Class="register-but">
            <input type="submit" value="submit">
            <div Class="clearfix"> </div>
        </div>
    End Using
</div>
