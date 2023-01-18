@ModelType ManShop.Web.ManShop.Web.Models.ExternalLoginConfirmationViewModel
@Code
    ViewBag.Title = "ExternalLoginConfirmation"
    Layout = "~/Views/Shared/Layouts.vbhtml"
End Code
<div class="account_grid">
    <div class="login-right">
        <h3>Liên kết với tài khoản @ViewBag.LoginProvider của bạn.</h3>
        @Using (Html.BeginForm("ExternalLoginConfirmation", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"}))
            @Code
                @Html.AntiForgeryToken()
                @<h4>Form nhập thông tin</h4>
                @<hr />
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                @<p Class="text-info">
                    Bạn vừa chứng thực thành công với <strong>@ViewBag.LoginProvider</strong>.
                    Xin hãy nhập tên tài khoản mà bạn muốn đăng ký trên TEDU dưới đây để kết thúc quá trình login. Những lần sau bạn sẽ không phải thực hiện bước này.

                </p>@<div Class="form-group">
                    @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-2 control-label"})
                    <div Class="col-md-10">
                        @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
                    </div>
                </div>
                @<div Class="form-group">
                    <div Class="col-md-offset-2 col-md-10">
                        <input type="submit" Class="btn btn-default" value="Đăng ký" />
                    </div>
                </div>
            End Code
        End Using
    </div>
</div>