Imports AutoMapper
Imports BotDetect.Web.Mvc
Imports ManShop.Common.ManShop.Common
Imports ManShop.Model.ManShop.Model.Models
Imports ManShop.Service.ManShop.Service
Imports ManShop.Service.TeduShop.Service
Imports ManShop.Web.ManShop.Web.Infrastructure.Extensions
Imports ManShop.Web.ManShop.Web.Models

Namespace ManShop.Web.Controllers
    Public Class ContactController
        Inherits Controller

        Private _contactDetailService As IContactDetailService
        Private _feedbackService As IFeedbackService

        Public Sub New(ByVal contactDetailService As IContactDetailService, ByVal feedbackService As IFeedbackService)
            Me._contactDetailService = contactDetailService
            Me._feedbackService = feedbackService
        End Sub

        Public Function Index() As ActionResult
            Dim viewModel As FeedbackViewModel = New FeedbackViewModel()
            viewModel.ContactDetail = GetDetail()
            Return View(viewModel)
        End Function

        <HttpPost>
        <CaptchaValidation("CaptchaCode", "contactCaptcha", "Mã xác nhận không đúng")>
        Public Function SendFeedback(ByVal feedbackViewModel As FeedbackViewModel) As ActionResult
            If ModelState.IsValid Then
                Dim newFeedback As Feedback = New Feedback()
                newFeedback.UpdateFeedback(feedbackViewModel)
                _feedbackService.Create(newFeedback)
                _feedbackService.Save()
                ViewData("SuccessMsg") = "Gửi phản hồi thành công"
                Dim content As String = System.IO.File.ReadAllText(Server.MapPath("/Assets/client/template/contact_template.html"))
                content = content.Replace("{{Name}}", feedbackViewModel.Name)
                content = content.Replace("{{Email}}", feedbackViewModel.Email)
                content = content.Replace("{{Message}}", feedbackViewModel.Message)
                Dim adminEmail = ConfigHelper.GetByKey("AdminEmail")
                MailHelper.SendMail(adminEmail, "Thông tin liên hệ từ website", content)
                feedbackViewModel.Name = ""
                feedbackViewModel.Message = ""
                feedbackViewModel.Email = ""
            End If

            feedbackViewModel.ContactDetail = GetDetail()
            Return View("Index", feedbackViewModel)
        End Function

        Private Function GetDetail() As ContactDetailViewModel
            Dim model = _contactDetailService.GetDefaultContact()
            Dim contactViewModel = Mapper.Map(Of ContactDetail, ContactDetailViewModel)(model)
            Return contactViewModel
        End Function
    End Class
End Namespace
