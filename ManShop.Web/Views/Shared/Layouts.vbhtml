﻿<!--A Design by W3layouts
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title</title>
    <meta name="description" content="@ViewBag.MetaKeyword">
    <meta name="keywords" content="@ViewBag.MetaDescription">

    @*<link href="/Assets/client/css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
        <link href="~/Assets/client/font-awesome-4.6.3/css/font-awesome.css" rel="stylesheet" />
        <link href="~/Assets/admin/libs/jquery-ui/themes/smoothness/jquery-ui.min.css" rel="stylesheet" />
        <link href="/Assets/client/css/style.css" rel="stylesheet" type="text/css" media="all" />
        <link href="~/Assets/client/css/custom.css" rel="stylesheet" />*@
    @Styles.Render("~/css/base")
    <!--//theme-style-->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!--fonts-->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800' rel='stylesheet' type='text/css'>
    <!--//fonts-->
    <style>
        .ui-autocomplete {
            z-index: 1000;
        }
    </style>
</head>
<body>
    <!--header-->
    @code
        Html.RenderAction("Header", "Home")
    End Code
    <!---->
    <div class="container">
        @RenderBody()
        @code
            Html.RenderAction("Category", "Home")
        End Code
    </div>

    @code
        Html.RenderAction("Footer", "Home")
    End Code
    <div class="clearfix"> </div>

    @*<script src="/Assets/client/js/jquery.min.js"></script>
        <script src="~/Assets/admin/libs/jquery-ui/jquery-ui.min.js"></script>
        <script src="~/Assets/admin/libs/mustache/mustache.js"></script>
        <script src="~/Assets/admin/libs/numeral/numeral.js"></script>
        <script src="~/Assets/admin/libs/jquery-validation/dist/jquery.validate.js"></script>
        <script src="~/Assets/admin/libs/jquery-validation/dist/additional-methods.min.js"></script>
        <script src="~/Assets/client/js/common.js"></script>*@

    <!--script-->
    @Scripts.Render("~/js/jquery")
    @Scripts.Render("~/js/plugins")
    @RenderSection("footerJS", required:=False)
</body>
</html>