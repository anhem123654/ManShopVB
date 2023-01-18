@ModelType ManShop.Web.ManShop.Web.Infrastructure.Core.PaginationSet(Of ManShop.Web.ManShop.Web.Models.ProductViewModel)
@Code
    Dim tag = CType(ViewBag.Tag, ManShop.Web.ManShop.Web.Models.TagViewModel)
    Dim pageIndex = Model.Page
    ViewBag.Title = If(pageIndex = 1, "Kết quả tìm kiếm cho tag " & tag.Name, "Kết quả tìm kiếm cho tag " & tag.Name & " - Trang " & pageIndex)
    ViewBag.MetaKeyword = If(pageIndex = 1, "Kết quả tìm kiếm cho tag " & tag.Name, "Kết quả tìm kiếm cho tag " & tag.Name & " - Trang " & pageIndex)
    ViewBag.MetaDescription = If(pageIndex = 1, "Kết quả tìm kiếm cho tag " & tag.Name, "Kết quả tìm kiếm cho tag " & tag.Name & " - Trang " & pageIndex)
    Layout = "~/Views/Shared/Layouts.vbhtml"
End Code
<div class="women-product">
    @If Model.Count > 0 Then
        @<div class="w_content">
            <div class="women">
                <a href=""><h4>Tag: @tag.Name - <span>@Model.TotalCount sản phẩm</span> </h4></a>

                <div class="clearfix"> </div>
            </div>
        </div>
        @<div class="grid-product">
            @for each product In Model.Items
                Dim url = "/" & product.Alias & ".p-" & product.ID
                @<div class="product-grid">
                    <div class="content_box">
                        <a href="@url">
                            <div class="left-grid-view grid-view-left">
                                <img src="@product.Image" class="img-responsive watch-right" alt="@product.Name" />
                                <div class="mask">
                                    <div class="info">Xem nhanh</div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <h4><a href="@url">@product.Name</a></h4>
                    <p>@product.Description</p>
                    @(If(product.Price = 0, "Liên hệ", product.Price.ToString("N2")))
                </div>
            Next
            <div class="clearfix"> </div>
            @If (Model.TotalPages > 1) Then
                Dim startPageIndex = Math.Max(1, Model.Page - Model.MaxPage / 2)
                Dim endPageIndex = Math.Min(Model.TotalPages, Model.Page + Model.MaxPage / 2)
                @<nav>
                    <ul Class="pagination">
                        @if (Model.Page > 1) Then
                            @<li>
                                <a href="?page=1" aria-label="First">
                                    <i Class="fa fa-angle-double-left"></i>
                                </a>
                            </li>
                            @<li>
                                <a href="?page=@(Model.Page - 1)" aria-label="Previous">
                                    <i Class="fa fa-angle-double-left"></i>
                                </a>
                            </li>
                        End If
                        @if (Model.Page < Model.TotalPages) Then
                            @<li>
                                <a href="?page=@(Model.Page + 1)" aria-label="Next">
                                    <i Class="fa fa-angle-double-right"></i>
                                </a>
                            </li>
                            @<li>
                                <a href="?page=@Model.TotalPages" aria-label="Last">
                                    <i Class="fa fa-angle-double-right"></i>
                                </a>
                            </li>
                        End If
                    </ul>
                </nav>
            End If
        </div>
    Else
        @<div class="text-center">Không có bản ghi nào được tìm thấy.</div>
    End If
</div>