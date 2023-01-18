@Code
    ViewBag.Title = "Giỏ hàng và thanh toán"
    Layout = "~/Views/Shared/Layouts.vbhtml"
End Code
@section footerJS
    <script src="~/Assets/client/js/controllers/shoppingCart.js"></script>
End Section
<div class="single_top">
    <div class="single_grid">
        <div id="cartContent">
            <table class="table">
                <thead>
                    <tr>
                        <td>STT</td>
                        <td>Tên sản phẩm</td>
                        <td>Hình ảnh</td>
                        <td>Giá</td>
                        <td>Số lượng</td>
                        <td>Thành tiền</td>
                        <td>#</td>
                    </tr>
                </thead>
                <tbody id="cartBody"></tbody>
            </table>
            <button class="btn btn-success" id="btnContinue">Tiếp tục mua hàng</button>
            <button class="btn btn-danger" id="btnDeleteAll">Xóa giỏ hàng</button>
            <button class="btn btn" id="btnCheckout">Thanh toán</button>
            <div class="pull-right">
                Tổng tiền: <span id="lblTotalOrder"></span>
            </div>
        </div>
        <div id="divCheckout" style="display:none;">
            <div class="reservation_top">
                <div class="contact_right">
                    <h3>Thanh toán</h3>
                    <div class="contact-form">
                        <form method="post" id="frmPayment">
                            @if (Request.IsAuthenticated) Then
                                @<label>
                                    <input type="checkbox" id="chkUserLoginInfo" />
                                    Sử dụng thông tin đăng nhập
                                </label>
                            End if
                            <input type="text" Class="textbox" id="txtName" name="name" placeholder="Họ tên">
                            <input type="text" Class="textbox" id="txtAddress" name="address" placeholder="Địa chỉ">
                            <input type="text" Class="textbox" id="txtEmail" name="email" placeholder="Email">
                            <input type="text" Class="textbox" id="txtPhone" name="phone" placeholder="Điện thoại">

                            <label><input type="radio" id="rdoCash" name="paymentMethod" value="CASH" checked="checked" /> Tiền mặt</label>
                            <label><input type="radio" id="rdoNL" name="paymentMethod" value="NL" /> TK Ngân Lượng</label>

                            <label><input type="radio" id="rdoBank" value="ATM_ONLINE" name="paymentMethod" /> Thẻ Ngân hàng nội địa</label>

                            <label><input type="radio" id="rdoVisa" name="paymentMethod" value="VISA" /> VISA</label>
                            <div id="bankContent" Class="boxContent" style="display:none;">
                                Danh sách ngân hàng nội địa:
                                <ul Class="cardList clearfix">

                                    <li Class="bank-online-methods ">
                                        <Label for="vcb_ck_on">
                                            <i Class="VCB" title="Ngân hàng TMCP Ngoại Thương Việt Nam"></i>
                                            <input type="radio" ID="VCB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="vnbc_ck_on">
                                            <i Class="DAB" title="Ngân hàng Đông Á"></i>
                                            <input type="radio" ID="DAB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="tcb_ck_on">
                                            <i Class="TCB" title="Ngân hàng Kỹ Thương"></i>
                                            <input type="radio" ID="TCB" GroupName="bankcode" />
                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_mb_ck_on">
                                            <i Class="MB" title="Ngân hàng Quân Đội"></i>
                                            <input type="radio" ID="MB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="shb_ck_on">
                                            <i Class="SHB" title="Ngân hàng Sài Gòn - Hà Nội"></i>
                                            <input type="radio" ID="SHB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_vib_ck_on">
                                            <i Class="VIB" title="Ngân hàng Quốc tế"></i>
                                            <input type="radio" ID="VIB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_vtb_ck_on">
                                            <i Class="ICB" title="Ngân hàng Công Thương Việt Nam"></i>
                                            <input type="radio" ID="ICB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_exb_ck_on">
                                            <i Class="EXB" title="Ngân hàng Xuất Nhập Khẩu"></i>
                                            <input type="radio" ID="EXB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_acb_ck_on">
                                            <i Class="ACB" title="Ngân hàng Á Châu"></i>
                                            <input type="radio" ID="ACB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_hdb_ck_on">
                                            <i Class="HDB" title="Ngân hàng Phát triển Nhà TPHCM"></i>
                                            <input type="radio" ID="HDB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_msb_ck_on">
                                            <i Class="MSB" title="Ngân hàng Hàng Hải"></i>
                                            <input type="radio" ID="MSB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_nvb_ck_on">
                                            <i Class="NVB" title="Ngân hàng Nam Việt"></i>
                                            <input type="radio" ID="NVB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_vab_ck_on">
                                            <i Class="VAB" title="Ngân hàng Việt Á"></i>
                                            <input type="radio" ID="VAB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_vpb_ck_on">
                                            <i Class="VPB" title="Ngân Hàng Việt Nam Thịnh Vượng"></i>
                                            <input type="radio" ID="VPB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_scb_ck_on">
                                            <i Class="SCB" title="Ngân hàng Sài Gòn Thương tín"></i>
                                            <input type="radio" ID="SCB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="ojb_ck_on">
                                            <i Class="OJB" title="Ngân hàng Đại Dương"></i>
                                            <input type="radio" ID="OJB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="bnt_atm_pgb_ck_on">
                                            <i Class="PGB" title="Ngân hàng Xăng dầu Petrolimex"></i>
                                            <input type="radio" ID="PGB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="bnt_atm_gpb_ck_on">
                                            <i Class="GPB" title="Ngân hàng TMCP Dầu khí Toàn Cầu"></i>
                                            <input type="radio" ID="GPB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="bnt_atm_agb_ck_on">
                                            <i Class="AGB" title="Ngân hàng Nông nghiệp &amp; Phát triển nông thôn"></i>
                                            <input type="radio" ID="AGB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="bnt_atm_sgb_ck_on">
                                            <i Class="SGB" title="Ngân hàng Sài Gòn Công Thương"></i>
                                            <input type="radio" ID="SGB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="bnt_atm_nab_ck_on">
                                            <i Class="NAB" title="Ngân hàng Nam Á"></i>
                                            <input type="radio" ID="NAB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                    <li Class="bank-online-methods ">
                                        <Label for="sml_atm_bab_ck_on">
                                            <i Class="BAB" title="Ngân hàng Bắc Á"></i>
                                            <input type="radio" ID="BAB" GroupName="bankcode" />

                                        </Label>
                                    </li>

                                </ul>
                            </div>
                            <div id="nganluongContent" Class="boxContent" style="display:none;">
                                <p>
                                    Thanh toán trực tuyến AN TOÀN và ĐƯỢC BẢO VỆ, sử dụng thẻ ngân hàng trong và ngoài nước hoặc nhiều hình thức tiện lợi khác.
                                    Được bảo hộ & cấp phép bởi NGÂN HÀNG NHÀ NƯỚC, ví điện tử duy nhất được cộng đồng ƯA THÍCH NHẤT 2 năm liên tiếp, Bộ Thông tin Truyền thông trao giải thưởng Sao Khuê
                                    <br />Giao dịch. Đăng ký ví NgânLượng.vn miễn phí <a href="https://www.nganluong.vn/?portal=nganluong&amp;page=user_register" target="_blank">tại đây</a>
                                </p>
                            </div>
                            <textarea value="" id="txtMessage" rows="5"></textarea>
                            <div Class="alert alert-danger" id="divMessage" style="display:none;"></div>
                            <input type="button" id="btnCreateOrder" value="Thanh toán">
                            <div Class="clearfix"> </div>
                        </form>

                    </div>
                </div>
            </div>
        </div>
        <div Class="clearfix"> </div>
    </div>

</div>

<Script id="tplCart" type="x-tmpl-mustache">
                  <tr>                                                                                                                                                                                                <td>{{ProductId}}</td>
                    <td>{{ProductName}}</td>
                    <td> <img src = "{{Image}}" height="50" /></td>
                    <td>{{PriceF}}</td>
                    <td> <input type = "number" data-id="{{ProductId}}" data-price="{{Price}}" value="{{Quantity}}" Class="input txtQuantity" /></td>
                    <td id = "amount_{{ProductId}}" > {{Amount}}</td>
                    <td> <Button Class="btn btn-danger btnDeleteItem" data-id="{{ProductId}}"><i class="fa fa-close"></i></button></td>
                  </tr>
</Script>
