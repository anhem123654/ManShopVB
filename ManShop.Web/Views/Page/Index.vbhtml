@ModelType ManShop.Web.ManShop.Web.Models.PageViewModel
@Code
    ViewBag.Title = Model.Name
    ViewBag.MetaKeyword = Model.Name
    ViewBag.MetaDescription = Model.Name
    Layout = "~/Views/Shared/Layouts.vbhtml"
End Code
<div class="single_top">
    <div class="single_grid">
        <h1>@Model.Name</h1>
        @Html.Raw(Model.Content)
        <div class="clearfix"> </div>
    </div>
</div>