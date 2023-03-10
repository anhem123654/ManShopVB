@ModelType ManShop.Web.ManShop.Web.Models.ProductViewModel
@Code
    ViewBag.Title = Model.Name
    ViewBag.MetaKeyword = Model.MetaKeyword
    ViewBag.MetaDescription = Model.MetaDescription
    Layout = "~/Views/Shared/Layouts.vbhtml"
End Code
<link href="~/Assets/client/css/etalage.css" rel="stylesheet" />
@section footerJS
    <script type="text/javascript" src="/Assets/client/js/jquery.flexisel.js"></script>
    <script src="/Assets/client/js/jquery.etalage.min.js"></script>
    <script>
        jQuery(document).ready(function ($) {
            $("#flexiselDemo1").flexisel({
                visibleItems: 5,
                animationSpeed: 1000,
                autoPlay: true,
                autoPlaySpeed: 3000,
                pauseOnHover: true,
                enableResponsiveBreakpoints: true,
                responsiveBreakpoints: {
                    portrait: {
                        changePoint: 480,
                        visibleItems: 1
                    },
                    landscape: {
                        changePoint: 640,
                        visibleItems: 2
                    },
                    tablet: {
                        changePoint: 768,
                        visibleItems: 3
                    }
                }
            });
            $('#etalage').etalage({
                thumb_image_width: 300,
                thumb_image_height: 400,
                source_image_width: 900,
                source_image_height: 1200,
                show_hint: true,
                click_callback: function (image_anchor, instance_id) {
                    alert('Callback example:\nYou clicked on an image with the anchor: "' + image_anchor + '"\n(in Etalage instance: "' + instance_id + '")');
                }
            });
        });
    </script>
End Section
<div class="single_top">
    <div class="single_grid">
        <div class="grid images_3_of_2">

            <ul id="etalage">
                <li>
                    <a href="#">
                        <img class="etalage_thumb_image img-responsive" src="@Model.Image" />
                        <img class="etalage_source_image img-responsive" src="@Model.Image" title="" />
                    </a>
                </li>
                @code
                    Dim moreImages = CType(ViewBag.MoreImages, List(Of String))
                    If (moreImages.Count > 0) Then
                        For Each image In moreImages
                            @<li>
                                <img class="etalage_thumb_image img-responsive" src="@image" />
                                <img class="etalage_source_image img-responsive" src="@image" title="" />
                            </li>
                        Next
                    End If
                End Code
            </ul>
            <div class="clearfix"> </div>
        </div>
        <div class="desc1 span_3_of_2">
            <h4>@Model.Name</h4>
            <div class="cart-b">
                <div class="left-n ">@(If(Model.Price = 0, "Liên hệ", Model.Price.ToString("N0")))</div>
                <a class="now-get get-cart-in btnAddToCart" href="#" data-id="@Model.ID">Thêm vào giỏ hàng</a>
                <div class="clearfix"></div>
            </div>
            <h6>@Model.Quantity sản phẩm trong kho</h6>
            <p>@Model.Description</p>
            <div class="tag">
                <h5>Tag :</h5>
                <ul class="taglist">
                    @For Each tag In CType(ViewBag.Tags, IEnumerable(Of ManShop.Web.ManShop.Web.Models.TagViewModel))
                        @<li><a href="/tag/@(tag.ID).html">@(tag.Name), </a></li>
                    Next
                </ul>
            </div>
            <div class="clearfix"></div>
            <div class="share">
                <h5>Chia sẻ :</h5>
                <ul class="share_nav">
                    <li><a href="#"><img src="/Assets/client/images/facebook.png" title="facebook"></a></li>
                    <li><a href="#"><img src="/Assets/client/images/twitter.png" title="Twiiter"></a></li>
                    <li><a href="#"><img src="/Assets/client/images/rss.png" title="Rss"></a></li>
                    <li><a href="#"><img src="/Assets/client/images/gpluse.png" title="Google+"></a></li>
                </ul>
            </div>
        </div>
        <div class="clearfix"> </div>
    </div>
    @Code
        Dim relatedProducts = CType(ViewBag.RelatedProducts, IEnumerable(Of ManShop.Web.ManShop.Web.Models.ProductViewModel))
    End Code
    <ul id="flexiselDemo1">
        @for each product In relatedProducts
            @<li><img src="@product.Image" /><div class="grid-flex"><a href="/@(product.Alias).p-@(product.ID).html">@product.Name</a><p>@product.Price</p></div></li>
        Next
    </ul>
    <div class="toogle">
        <h3 class="m_3">Chi tiết sản phẩm</h3>
        <p class="m_text">@Html.Raw(Model.Content)</p>
    </div>
</div>

