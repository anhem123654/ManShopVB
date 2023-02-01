@modelType IEnumerable(Of ManShop.Web.ManShop.Web.Models.ProductCategoryViewModel)
<div class="sub-cate">
    <div class="top-nav rsidebar span_1_of_left">
        <h3 class="cate">Danh mục sản phẩm</h3>
        <ul class="menu">
            @For Each category In Model.Where(Function(x) x.ParentID Is Nothing)
                Dim url = "/" & category.[Alias] & ".pc-" & category.ID & ".html"
                Dim childCategories = Model.Where(Function(x) x.ParentID = category.ID)
                @<li>
                    @If childCategories.Count() > 0 Then
                        @<a href="@url">
                            @category.Name<img class="arrow-img" src="/Assets/client/images/arrow1.png" alt="" />
                        </a>
                    Else
                        @<a href="@url">
                            @category.Name
                        </a>
                    End If
                    @If childCategories.Count() > 0 Then
                        @<ul Class="cute">
                            @For Each childCategory In childCategories
                                Dim childUrl = "/" & childCategory.[Alias] & ".pc-" & childCategory.ID & ".html"
                            Next
                        </ul>
                    End If
                </li>
            Next
        </ul>
    </div>
    <div class="chain-grid menu-chain">
        <a href="single.html"><img class="img-responsive chain" src="/Assets/client/images/wat.jpg" alt="" /></a>
        <div class="grid-chain-bottom chain-watch">
            <span class="actual dolor-left-grid">300$</span>
            <span class="reducedfrom">500$</span>
            <h6><a href="single.html">Lorem ipsum dolor</a></h6>
        </div>
    </div>
    <a class="view-all all-product" href="product.html">VIEW ALL PRODUCTS<span> </span></a>
</div>
