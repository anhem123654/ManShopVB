﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Trang quản trị</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <!-- Bootstrap 3.3.5 -->
    <link href="~/Assets/admin/libs/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <!-- Theme style -->
    <link href="~/Assets/admin/libs/toastr/toastr.css" rel="stylesheet" />
    <link href="~/Assets/admin/libs/angular-loading-bar/build/loading-bar.css" rel="stylesheet" />
    <link href="~/Assets/admin/libs/angular-chart.js/dist/angular-chart.css" rel="stylesheet" />
    <link href="~/Assets/admin/libs/angular-ui-select/dist/select.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="/Assets/admin/css/AdminLTE.min.css">
    <link href="~/Assets/admin/css/custom.css" rel="stylesheet" />
    <!-- AdminLTE Skins. Choose a skin from the css/skins
         folder instead of downloading all of them to reduce the load. -->
    <link rel="stylesheet" href="/Assets/admin/css/skins/_all-skins.min.css">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body class="hold-transition skin-blue sidebar-mini" ng-app="manshop" ng-controller="rootController">
    <div ui-view></div>
    <!-- Site wrapper -->
    <!-- jQuery 2.1.4 -->
    <script src="~/Assets/admin/libs/jquery/dist/jquery.js"></script>
    <!-- Bootstrap 3.3.5 -->
    <script src="~/Assets/admin/libs/bootstrap/dist/js/bootstrap.js"></script>
    <!-- SlimScroll -->
    <script src="~/Assets/admin/libs/slimScroll/jquery.slimscroll.js"></script>
    <!-- FastClick -->
    <script src="~/Assets/admin/libs/fastclick/lib/fastclick.js"></script>
    <!-- Begin embed angularJS -->
    <script src="~/Assets/admin/libs/angular/angular.js"></script>
    <script src="~/Assets/admin/libs/angular-ui-router/release/angular-ui-router.js"></script>
    <script src="~/Assets/admin/libs/angular-sanitize/angular-sanitize.min.js"></script>
    <script src="~/Assets/admin/libs/toastr/toastr.js"></script>
    <script src="~/Assets/admin/libs/bootbox/bootbox.js"></script>
    <script src="~/Assets/admin/libs/ckeditor/ckeditor.js"></script>
    <script src="~/Assets/admin/libs/ckfinder/ckfinder.js"></script>
    <script src="~/Assets/admin/libs/ngBootbox/ngBootbox.js"></script>
    <script src="~/Assets/admin/libs/ng-ckeditor/ng-ckeditor.js"></script>
    <script src="~/Assets/admin/libs/angular-local-storage/dist/angular-local-storage.js"></script>
    <script src="~/Assets/admin/libs/angular-loading-bar/build/loading-bar.js"></script>
    <script src="~/Assets/admin/libs/checklist-model/checklist-model.js"></script>
    <script src="~/Assets/admin/libs/Chart.js/Chart.js"></script>
    <script src="~/Assets/admin/libs/angular-chart.js/dist/angular-chart.js"></script>
    <script src="~/Assets/admin/libs/angular-ui-select/dist/select.min.js"></script>

    <script src="~/app/shared/modules/manshop.common.js"></script>
    <script src="~/app/shared/filters/statusFilter.js"></script>
    <script src="~/app/shared/services/apiService.js"></script>
    <script src="~/app/shared/directives/pagerDirective.js"></script>
    <script src="~/app/shared/directives/asDateDirective.js"></script>
    <script src="~/app/shared/directives/fileUpload.directive.js"></script>
    <script src="~/app/shared/services/notificationService.js"></script>
    <script src="~/app/shared/services/authData.js"></script>
    <script src="~/app/shared/services/authenticationService.js"></script>
    <script src="~/app/shared/services/loginService.js"></script>
    <script src="~/app/shared/services/commonService.js"></script>
    <script src="~/app/components/products/products.module.js"></script>
    <script src="~/app/components/product_categories/productCategories.module.js"></script>
    <script src="~/app/components/application_groups/applicationGroups.module.js"></script>
    <script src="~/app/components/application_roles/applicationRoles.module.js"></script>
    <script src="~/app/components/application_users/applicationUsers.module.js"></script>
    <script src="~/app/components/statistic/statistic.module.js"></script>
    <script src="~/app/app.js"></script>
    <script src="~/app/components/home/rootController.js"></script>
    <script src="~/app/components/product_categories/productCategoryListController.js"></script>
    <script src="~/app/components/product_categories/productCategoryAddController.js"></script>
    <script src="~/app/components/products/productAddController.js"></script>
    <script src="~/app/components/products/productImportController.js"></script>
    <script src="~/app/components/product_categories/productCategoryEditController.js"></script>
    <script src="~/app/components/products/productListController.js"></script>
    <script src="~/app/components/home/homeController.js"></script>
    <script src="~/app/components/products/productEditController.js"></script>
    <script src="~/app/components/login/loginController.js"></script>
    <script src="~/app/components/application_groups/applicationGroupListController.js"></script>
    <script src="~/app/components/application_groups/applicationGroupEditController.js"></script>
    <script src="~/app/components/application_groups/applicationGroupAddController.js"></script>
    <script src="~/app/components/application_roles/applicationRoleAddController.js"></script>
    <script src="~/app/components/application_roles/applicationRoleEditController.js"></script>
    <script src="~/app/components/application_roles/applicationRoleListController.js"></script>
    <script src="~/app/components/application_users/applicationUserAddController.js"></script>
    <script src="~/app/components/application_users/applicationUserEditController.js"></script>
    <script src="~/app/components/application_users/applicationUserListController.js"></script>
    <script src="~/app/components/statistic/revenueStatisticController.js"></script>
</body>
</html>