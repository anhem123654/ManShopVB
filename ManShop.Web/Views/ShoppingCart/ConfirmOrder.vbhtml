@Code
    ViewBag.Title = "ConfirmOrder"
    Layout = "~/Views/Shared/Layouts.vbhtml"
End Code
<div class="single_top">
    <div class="single_grid">
        <h1>Kết quả giao dịch</h1>
        @Code
            Dim success = CType(ViewBag.IsSuccess, Boolean)
        End Code
        @if (success) Then
            @<div class="alert alert-success">@ViewBag.Result Vui lòng <a href="/">click vào đây</a> để về trang chủ.</div>
        Else
            @<div class="alert alert-danger">@ViewBag.Result. Vui lòng <a href="/">click vào đây</a> để về trang chủ.</div>
        End If
        <div class="clearfix"> </div>
    </div>
</div>
