Imports System.Web.Script.Serialization
Imports AutoMapper
Imports ManShop.Common.ManShop.Common
Imports ManShop.Model.ManShop.Model.Models
Imports ManShop.Service.ManShop.Service
Imports ManShop.Web.ManShop.Web.Infrastructure.Core
Imports ManShop.Web.ManShop.Web.Models

Namespace ManShop.Web.Controllers
    Public Class ProductController
        Inherits Controller

        Private _productService As IProductService
        Private _productCategoryService As IProductCategoryService

        Public Sub New(ByVal productService As IProductService, ByVal productCategoryService As IProductCategoryService)
            Me._productService = productService
            Me._productCategoryService = productCategoryService
        End Sub

        Public Function Detail(ByVal productId As Integer) As ActionResult
            Dim productModel = _productService.GetById(productId)
            Dim viewModel = Mapper.Map(Of Product, ProductViewModel)(productModel)
            Dim relatedProduct = _productService.GetReatedProducts(productId, 6)
            ViewBag.RelatedProducts = Mapper.Map(Of IEnumerable(Of Product), IEnumerable(Of ProductViewModel))(relatedProduct)
            Dim listImages As List(Of String) = New JavaScriptSerializer().Deserialize(Of List(Of String))(viewModel.MoreImages)
            ViewBag.MoreImages = listImages
            ViewBag.Tags = Mapper.Map(Of IEnumerable(Of Tag), IEnumerable(Of TagViewModel))(_productService.GetListTagByProductId(productId))
            Return View(viewModel)
        End Function

        Public Function Category(ByVal id As Integer, ByVal Optional page As Integer = 1, ByVal Optional sort As String = "") As ActionResult
            Dim pageSize As Integer = Integer.Parse(ConfigHelper.GetByKey("PageSize"))
            Dim totalRow As Integer = 0
            Dim productModel = _productService.GetListProductByCategoryIdPaging(id, page, pageSize, sort, totalRow)
            Dim productViewModel = Mapper.Map(Of IEnumerable(Of Product), IEnumerable(Of ProductViewModel))(productModel)
            Dim totalPage As Integer = CInt(Math.Ceiling(CDbl(totalRow) / pageSize))

            Dim ccategory = _productCategoryService.GetById(id)
            ViewBag.Category = Mapper.Map(Of ProductCategory, ProductCategoryViewModel)(ccategory)
            Dim paginationSet = New PaginationSet(Of ProductViewModel)() With {
                .Items = productViewModel,
                .MaxPage = Integer.Parse(ConfigHelper.GetByKey("MaxPage")),
                .Page = page,
                .TotalCount = totalRow,
                .TotalPages = totalPage
            }
            Return View(paginationSet)
        End Function

        Public Function Search(ByVal keyword As String, ByVal Optional page As Integer = 1, ByVal Optional sort As String = "") As ActionResult
            Dim pageSize As Integer = Integer.Parse(ConfigHelper.GetByKey("PageSize"))
            Dim totalRow As Integer = 0
            Dim productModel = _productService.Search(keyword, page, pageSize, sort, totalRow)
            Dim productViewModel = Mapper.Map(Of IEnumerable(Of Product), IEnumerable(Of ProductViewModel))(productModel)
            Dim totalPage As Integer = CInt(Math.Ceiling(CDbl(totalRow) / pageSize))
            ViewBag.Keyword = keyword
            Dim paginationSet = New PaginationSet(Of ProductViewModel)() With {
                .Items = productViewModel,
                .MaxPage = Integer.Parse(ConfigHelper.GetByKey("MaxPage")),
                .Page = page,
                .TotalCount = totalRow,
                .TotalPages = totalPage
            }
            Return View(paginationSet)
        End Function

        Public Function ListByTag(ByVal tagId As String, ByVal Optional page As Integer = 1) As ActionResult
            Dim pageSize As Integer = Integer.Parse(ConfigHelper.GetByKey("PageSize"))
            Dim totalRow As Integer = 0
            Dim productModel = _productService.GetListProductByTag(tagId, page, pageSize, totalRow)
            Dim productViewModel = Mapper.Map(Of IEnumerable(Of Product), IEnumerable(Of ProductViewModel))(productModel)
            Dim totalPage As Integer = CInt(Math.Ceiling(CDbl(totalRow) / pageSize))
            ViewBag.Tag = Mapper.Map(Of Tag, TagViewModel)(_productService.GetTag(tagId))
            Dim paginationSet = New PaginationSet(Of ProductViewModel)() With {
                .Items = productViewModel,
                .MaxPage = Integer.Parse(ConfigHelper.GetByKey("MaxPage")),
                .Page = page,
                .TotalCount = totalRow,
                .TotalPages = totalPage
            }
            Return View(paginationSet)
        End Function

        Public Function GetListProductByName(ByVal keyword As String) As JsonResult
            Dim model = _productService.GetListProductByName(keyword)
            Return Json(New With {Key .data = model
            }, JsonRequestBehavior.AllowGet)
        End Function
    End Class
End Namespace
