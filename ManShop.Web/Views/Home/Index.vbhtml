@modeltype ManShop.Web.ManShop.Web.Models.HomeViewModel
@code
    ViewBag.Title = Model.Title
    ViewBag.MetaKeyword = Model.MetaKeyword
    ViewBag.MetaDescription = Model.MetaDescription
    Layout = "~/Views/Shared/Layouts.vbhtml"
End Code
@section footerJs
    <script src="/Assets/client/js/jquery.wmuSlider.js"></script>
    <script>
        $('.example1').wmuSlider();
    </script>
End Section
<div class="shoes-grid">
    <div class="wrap-in">
        <div class="wmuSlider example1 slide-grid">
            <div class="wmuSliderWrapper">
                @For Each slide In Model.Slides
                    @<article style="position: absolute; width: 100%; opacity: 0;">
                        <div class="banner-matter">
                            <div class="col-md-5 banner-bag">
                                <img class="img-responsive " src="@slide.Image" alt="@slide.Name" />
                            </div>
                            <div class="col-md-7 banner-off">
                                @Html.Raw(slide.Content)
                            </div>
                            <div class="clearfix"> </div>
                        </div>
                    </article>
                Next
            </div>
            <ul class="wmuSliderPagination">
                @For i As Integer = 0 To Model.Slides.Count() - 1
                    @<li><a href="#" Class="">i</a></li>
                Next
            </ul>
        </div>
    </div>
    <div class="products">
        <h5 class="latest-product">Sản phẩm mới nhất</h5>
        <a class="view-all" href="san-pham.html">Xem tất cả<span> </span></a>
    </div>
    <div class="product-left">
        @For Each product In Model.LastestProducts
            Dim url = "/" & product.[Alias] & ".p-" & product.ID & ".html"
            @<div class="col-md-4 chain-grid grid-top-chain">
                <a href="@url"><img class="img-responsive chain" src="@product.Image" /></a>
                <span class="star"> </span>
                <div class="grid-chain-bottom">
                    <h6><a href="@url">@product.Name</a></h6>
                    <div class="star-price">
                        <div class="dolor-grid">
                            @If product.PromotionPrice.HasValue Then
                                @<span class="actual">@product.PromotionPrice.Value.ToString("N0")</span>
                            End If
                            <span class="reducedfrom">@product.Price.ToString("N0")</span>
                            <span class="rating">
                                <input type="radio" class="rating-input" id="rating-input-1-5" name="rating-input-1">
                                <label for="rating-input-1-5" class="rating-star1"> </label>
                                <input type="radio" class="rating-input" id="rating-input-1-4" name="rating-input-1">
                                <label for="rating-input-1-4" class="rating-star1"> </label>
                                <input type="radio" class="rating-input" id="rating-input-1-3" name="rating-input-1">
                                <label for="rating-input-1-3" class="rating-star"> </label>
                                <input type="radio" class="rating-input" id="rating-input-1-2" name="rating-input-1">
                                <label for="rating-input-1-2" class="rating-star"> </label>
                                <input type="radio" class="rating-input" id="rating-input-1-1" name="rating-input-1">
                                <label for="rating-input-1-1" class="rating-star"> </label>
                            </span>
                        </div>
                        <a class="now-get get-cart btnAddToCart" href="#" data-id="@product.ID">Mua hàng</a>
                        <div class="clearfix"> </div>
                    </div>
                </div>
            </div>
        Next
        <div class="clearfix"> </div>
    </div>
    <div class="products">
        <h5 class="latest-product">Sản phẩm bán chạy</h5>
        <a class="view-all" href="san-pham-ban-chay.html">Xem tất cả<span> </span></a>
    </div>
    <div class="product-left">
        @For Each product In Model.TopSaleProducts
            Dim url = "/" & product.[Alias] & ".p-" & product.ID & ".html"
            @<div Class="col-md-4 chain-grid grid-top-chain">
                <a href="@url"><img class="img-responsive chain" src="@product.Image" /></a>
                <span class="star"> </span>
                <div class="grid-chain-bottom">
                    <h6><a href="@url">@product.Name</a></h6>
                    <div class="star-price">
                        <div class="dolor-grid">
                            @if (product.PromotionPrice.HasValue) Then
                                @<span class="actual">@product.PromotionPrice.Value.ToString("N0")</span>
                            End If
                            <span class="reducedfrom">@product.Price.ToString("N0")</span>
                            <span class="rating">
                                <input type="radio" class="rating-input" id="rating-input-1-5" name="rating-input-1">
                                <label for="rating-input-1-5" class="rating-star1"> </label>
                                <input type="radio" class="rating-input" id="rating-input-1-4" name="rating-input-1">
                                <label for="rating-input-1-4" class="rating-star1"> </label>
                                <input type="radio" class="rating-input" id="rating-input-1-3" name="rating-input-1">
                                <label for="rating-input-1-3" class="rating-star"> </label>
                                <input type="radio" class="rating-input" id="rating-input-1-2" name="rating-input-1">
                                <label for="rating-input-1-2" class="rating-star"> </label>
                                <input type="radio" class="rating-input" id="rating-input-1-1" name="rating-input-1">
                                <label for="rating-input-1-1" class="rating-star"> </label>
                            </span>
                        </div>
                        <a class="now-get get-cart btnAddToCart" href="#" data-id="@product.ID">Mua hàng</a>
                        <div class="clearfix"> </div>
                    </div>
                </div>
            </div>
        Next
        <div class="clearfix"> </div>
    </div>
</div>
