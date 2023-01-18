@ModelType ManShop.Web.ManShop.Web.Models.ExternalLoginListViewModel
@Imports Microsoft.Owin.Security
<h4>Đăng nhập bằng mạng xã hội</h4>
<hr />
@Code
    Dim loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes()
    If (loginProviders.Any()) Then
        Using (Html.BeginForm("ExternalLogin", "Account", New With {.ReturnUrl = Model.ReturnUrl}))
            @Html.AntiForgeryToken()
            @<div id="socialLoginList">
                <p>
                    @for each p As AuthenticationDescription In loginProviders
                        @<button type="submit" Class="btn" id="@p.AuthenticationType" name="provider" value="@p.AuthenticationType" title="Log in using your @p.Caption account"><i Class="fa fa-@p.AuthenticationType.ToLower()"></i> @p.AuthenticationType</button>
                    Next
                </p>
            </div>
        End Using
    End If
End Code