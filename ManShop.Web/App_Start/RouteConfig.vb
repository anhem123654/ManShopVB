Imports System.Web.Mvc
Imports System.Web.Routing

Namespace ManShop.Web
    Public Class RouteConfig
        Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
            routes.IgnoreRoute("{*botdetect}", New With {Key .botdetect = "(.*)BotDetectCaptcha\.ashx"
            })
            routes.MapRoute(name:="Confirm Order", url:="xac-nhan-don-hang.html", defaults:=New With {Key .controller = "ShoppingCart", Key .action = "ConfirmOrder", Key .id = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="Cancel Order", url:="huy-don-hang.html", defaults:=New With {Key .controller = "ShoppingCart", Key .action = "CancelOrder", Key .id = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="Contact", url:="lien-he.html", defaults:=New With {Key .controller = "Contact", Key .action = "Index", Key .id = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="Search", url:="tim-kiem.html", defaults:=New With {Key .controller = "Product", Key .action = "Search", Key .id = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="Login", url:="dang-nhap.html", defaults:=New With {Key .controller = "Account", Key .action = "Login", Key .id = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="Register", url:="dang-ky.html", defaults:=New With {Key .controller = "Account", Key .action = "Register", Key .id = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="Cart", url:="gio-hang.html", defaults:=New With {Key .controller = "ShoppingCart", Key .action = "Index", Key .id = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="Checkout", url:="thanh-toan.html", defaults:=New With {Key .controller = "ShoppingCart", Key .action = "Index", Key .id = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="Page", url:="trang/{alias}.html", defaults:=New With {Key .controller = "Page", Key .action = "Checkout", Key .[alias] = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="Product Category", url:="{alias}.pc-{id}.html", defaults:=New With {Key .controller = "Product", Key .action = "Category", Key .id = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="Product", url:="{alias}.p-{productId}.html", defaults:=New With {Key .controller = "Product", Key .action = "Detail", Key .productId = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="TagList", url:="tag/{tagId}.html", defaults:=New With {Key .controller = "Product", Key .action = "ListByTag", Key .tagId = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
            routes.MapRoute(name:="Default", url:="{controller}/{action}/{id}", defaults:=New With {Key .controller = "Home", Key .action = "Index", Key .id = UrlParameter.[Optional]
            }, namespaces:=New String() {"ManShop.Web.Controllers"})
        End Sub
    End Class
End Namespace
