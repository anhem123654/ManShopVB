﻿@modeltype ManShop.Web.ManShop.Web.Models.FooterViewModel

<div class="footer">
    <div class="footer-top">
        <div class="container">
            <div class="latter">
                <h6>Đăng ký nhận thư</h6>
                <div class="sub-left-right">
                    <form>
                        <input type="text" placeholder="Nhập email tại đây" />
                        <input type="submit" value="Gửi" />
                    </form>
                </div>
                <div class="clearfix"> </div>
            </div>
            <div class="latter-right">
                <p>Theo dõi:</p>
                <ul class="face-in-to">
                    <li><a href="#"><span> </span></a></li>
                    <li><a href="#"><span class="facebook-in"> </span></a></li>
                    <div class="clearfix"> </div>
                </ul>
                <div class="clearfix"> </div>
            </div>
            <div class="clearfix"> </div>
        </div>
    </div>
    <div class="footer-bottom">
        <div class="container">
            @Html.Raw(Model.Content)
        </div>
    </div>
</div>