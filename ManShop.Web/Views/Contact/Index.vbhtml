@ModelType ManShop.Web.ManShop.Web.Models.FeedbackViewModel
@Imports BotDetect.Web.Mvc
@Code
    ViewBag.Title = "Liên hệ"
    ViewBag.MetaKeyword = "liên hệ"
    ViewBag.MetaDescription = "Thông tin liên hệ của MAN SHOP"
    Layout = "~/Views/Shared/Layouts.vbhtml"
End Code
@section footerJS
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAk3Eeu6MXm1Y6qil2hO6j89kckY5nnSTo"></script>
    <script src="~/Assets/client/js/controllers/contact.js"></script>
End Section
<style>
    #map {
        height: 100%;
    }
</style>
<link href="@BotDetect.Web.CaptchaUrls.Absolute.LayoutStyleSheetUrl" rel="stylesheet" type="text/css" />
<input type="hidden" id="hidAddress" value="@Model.ContactDetail.Name<br />Điện thoại:@Model.ContactDetail.Phone <br>Địa chỉ: @Model.ContactDetail.Address" />
<input type="hidden" id="hidLat" value="@Model.ContactDetail.Lat" />
<input type="hidden" id="hidLng" value="@Model.ContactDetail.Lng" />
<input type="hidden" id="hidName" value="@Model.ContactDetail.Name" />
<div class="main">
    <div class="reservation_top">
        <div class="contact_right">
            <h3>Thông tin liên hệ</h3>
            <address class="address">
                <p>@Model.ContactDetail.Address</p>
                <dl>
                    <dt> </dt>
                    <dd>Điện thoại:<span> @Model.ContactDetail.Phone</span></dd>
                    <dd>E-mail:&nbsp; <a href="mailto:@(Model.ContactDetail.Email)">@(Model.Email)</a></dd>
                </dl>
            </address>
            <div class="clearfix"></div>
            <div id="map"></div>
        </div>
    </div>
    <div class="reservation_top">
        <div class="contact_right">
            <h3>Gửi thông tin liên hệ</h3>
            <div class="contact-form">
                @using (Html.BeginForm("SendFeedback", "Contact", FormMethod.Post))
                    @If ViewData("SuccessMsg") IsNot Nothing Then
                        @<div class="alert alert-success" role="alert">
                            <strong>Chúc mừng bạn! </strong> gửi phản hồi thành công.
                            <br />Chúng tôi sẽ liên hệ lại sớm nhất có thể.
                        </div>
                    End If
                    @Html.ValidationSummary(False, "", New With {.class = "error"})
                    @Html.TextBoxFor(Function(Model) Model.Name, New With {.class = "textbox"})
                    @Html.TextBoxFor(Function(Model) Model.Email, New With {.class = "textbox"})
                    @Html.TextAreaFor(Function(Model) Model.Message)
                    Dim contactCaptcha As MvcCaptcha = New MvcCaptcha("contactCaptcha")
                    @Html.Captcha(contactCaptcha)
                    @Html.TextBox("CaptchaCode")

                    @<input type="submit" value="Gửi đi">
                    @<div Class="clearfix"> </div>
                End Using
            </div>
        </div>
    </div>
</div>
