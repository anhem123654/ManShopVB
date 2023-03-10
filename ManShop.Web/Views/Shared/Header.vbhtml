@Imports Microsoft.AspNet.Identity
<div class="header">
    <div class="top-header">
        <div class="container">
            <div class="top-header-left">
                <ul class="support">
                    <li> <a href="#"><label> </label></a></li>
                    <li> <a href="#"> 24x7 live<span class="live"> support</span></a></li>
                </ul>
                <ul class="support">
                    <li class="van"><a href="#"><label> </label></a></li>
                    <li> <a href="#"> Free shipping <span class="live">on order over 500</span></a></li>
                </ul>
                <ul class="support">
                    <li> <a href="#"><label> </label></a></li>
                    <li> <a href="/gioi-thieu.html"> Giới thiệu</a></li>
                </ul>
                <ul class="support">
                    <li> <a href="#"><label> </label></a></li>
                    <li> <a href="/lien-he.html"> Liên hệ</a></li>
                </ul>
                <div class="clearfix"> </div>
            </div>
            <div class="top-header-right">
                <div class="down-top">
                    <select class="in-drop">
                        <option value="English" class="in-of">English</option>
                        <option value="Japanese" class="in-of">Japanese</option>
                        <option value="French" class="in-of">French</option>
                        <option value="German" class="in-of">German</option>
                    </select>
                </div>
                <div class="down-top top-down">
                    <select class="in-drop">

                        <option value="Dollar" class="in-of">Dollar</option>
                        <option value="Yen" class="in-of">Yen</option>
                        <option value="Euro" class="in-of">Euro</option>
                    </select>
                </div>
                <!---->
                <div class="clearfix"> </div>
            </div>
            <div class="clearfix"> </div>
        </div>
    </div>
    <div class="bottom-header">
        <div class="container">
            <div class="header-bottom-left">
                <div class="logo">
                    <a href="/"><img src="/Assets/client/images/logo.png" alt="" /></a>
                </div>
                <div class="search">
                    <form method="get" action="/tim-kiem.html">
                        <input type="text" id="txtKeyword" name="keyword" placeholder="Từ khóa">
                        <input type="submit" value="Tìm kiếm" id="btnSearch">
                    </form>
                </div>
                <div class="clearfix"> </div>
            </div>
            <div class="header-bottom-right">
                @using (Html.BeginForm("LogOut", "Account", FormMethod.Post, New With {.id = "frmLogout"}))
                    @If Request.IsAuthenticated Then
                        @Html.AntiForgeryToken()
                        @<ul class="login">
                            <li><a href="/tai-khoan.html"><span> </span>Xin chào: @User.Identity.GetUserName()</a></li> |
                            <li><a href="#" id="btnLogout">Thoát</a></li>
                        </ul>
                    Else
                        @<ul class="login">
                            <li><a href="/dang-nhap.html"><span> </span>ĐĂNG NHẬP</a></li> |
                            <li><a href="/dang-ky.html">ĐĂNG KÝ</a></li>
                        </ul>
                    End If
                End Using
                <div Class="cart"><a href="/gio-hang.html"><span> </span>GIỎ HÀNG</a></div>
                <div Class="clearfix"> </div>
            </div>
            <div Class="clearfix"> </div>
        </div>
    </div>
</div>
