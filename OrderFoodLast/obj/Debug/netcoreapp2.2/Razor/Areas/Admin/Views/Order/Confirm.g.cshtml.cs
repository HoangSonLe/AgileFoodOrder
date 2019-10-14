#pragma checksum "D:\AgileFoodOrder\OrderFoodLast\Areas\Admin\Views\Order\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d794644b94064a92a12b36b9c1d99844ac5d103"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Confirm), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Confirm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Order/Confirm.cshtml", typeof(AspNetCore.Areas_Admin_Views_Order_Confirm))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d794644b94064a92a12b36b9c1d99844ac5d103", @"/Areas/Admin/Views/Order/Confirm.cshtml")]
    public class Areas_Admin_Views_Order_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 12842, true);
            WriteLiteral(@"<nav>
    <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
        <a class=""nav-item nav-link active"" id=""nav-home-tab"" data-toggle=""tab"" href=""#nav-home"" role=""tab"" aria-controls=""nav-home"" aria-selected=""true"">Thông tin</a>
        <a class=""nav-item nav-link"" id=""nav-profile-tab"" data-toggle=""tab"" href=""#nav-profile"" role=""tab"" aria-controls=""nav-profile"" aria-selected=""false"">Xác nhận</a>
        <a class=""nav-item nav-link"" id=""nav-contact-tab"" data-toggle=""tab"" href=""#nav-contact"" role=""tab"" aria-controls=""nav-contact"" aria-selected=""false"">In và đóng gói</a>
    </div>
</nav>
<div class=""tab-content"" id=""nav-tabContent"">
    <!-- thong tin -->
    <div class=""tab-pane fade show active"" id=""nav-home"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">
        <h1 class=""m-3"">Thông tin hóa đơn</h1>
        <h3 class=""text-danger"">Lý Cẩm Minh - 120 Tà rụt tà nông cu lông cu Hà nội</h3>
        <div class=""card"" style=""width: 18rem;"">
            <img src=""https://via.placeholder.com/150x15");
            WriteLiteral(@"0"" class=""card-img-top"" alt=""food"">
            <div class=""card-body"">
                <h5 class=""card-title"">DH: 12362</h5>
                <p class=""card-text"">Bánh mì sài gòn nhưng nhân hà nội.</p>
            </div>
            <ul class=""list-group list-group-flush"">
                <li class=""list-group-item"">Giá: 20000 vnd</li>
            </ul>
            
        </div>
    </div>
    <!-- end thong tin -->
    <!-- xac nhan -->
    <div class=""tab-pane fade ml-3 mb-3 mr-3"" id=""nav-profile"" role=""tabpanel"" aria-labelledby=""nav-profile-tab"">

        <nav class=""mt-3"">
            <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                <a class=""nav-item nav-link active"" id=""nav-home-tab"" data-toggle=""tab"" href=""#nav-hvc"" role=""tab"" aria-controls=""nav-home"" aria-selected=""true"">Dùng hãng vận chuyển</a>
                <a class=""nav-item nav-link"" id=""nav-profile-tab"" data-toggle=""tab"" href=""#nav-tvc"" role=""tab"" aria-controls=""nav-profile"" aria-selected=""false"">Tự vận");
            WriteLiteral(@" chuyển</a>

            </div>
        </nav>
        <div class=""tab-content"" id=""nav-tabContent"">
            <!-- dung hang van chuyen -->
            <div class=""tab-pane fade show active"" id=""nav-hvc"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">
                <div class=""row"">
                    <div class=""col-8"">
                        <div class=""row"">
                            <div class=""col-6 mt-3"">
                                <div class=""form-group"">
                                    <h4 class=""text-danger"">Đơn hàng <i class=""fas fa-arrow-down""></i></h4>
                                </div>
                                <div class=""form-group row"">
                                    <label class=""col-sm-4 col-form-label"">Cửa hàng</label>
                                    <div class=""col-sm-8"">
                                        <select class=""form-control"">
                                            <option>Kho Ultimate</option>
                     ");
            WriteLiteral(@"                   </select>
                                    </div>
                                </div>
                                <div class=""form-group row"">
                                    <label class=""col-sm-4 col-form-label"">Nguồn đơn hàng</label>
                                    <div class=""col-sm-8"">
                                        <select class=""form-control"">
                                            <option>Nguồn</option>
                                        </select>
                                    </div>
                                </div>
                                <div class=""form-group row"">
                                    <label class=""col-sm-4 col-form-label"">Ghi chú của CSKH</label>
                                    <div class=""col-sm-8"">
                                        <textarea class=""form-control"" cols=""5"" rows=""3""></textarea>
                                    </div>
                                </div>
      ");
            WriteLiteral(@"                          <div class=""form-group row"">
                                    <label class=""col-sm-4 col-form-label"">Nhân viên bán hàng</label>
                                    <div class=""col-sm-8"">
                                        <input type=""text"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""form-group row"">
                                    <label class=""col-sm-4 col-form-label"">Trạng thái</label>
                                    <div class=""col-sm-8"">
                                        <select class=""form-control"">
                                            <option>Khách hủy</option>
                                            <option>Đã xác nhận</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div c");
            WriteLiteral(@"lass=""col-6 mt-3"">
                                <div class=""form-group"">
                                    <h4 class=""text-danger"">Khách hàng <i class=""fas fa-arrow-down""></i></h4>
                                </div>
                                <div class=""form-group row"">
                                    <label class=""col-sm-4 col-form-label"">Họ và tên</label>
                                    <div class=""col-sm-8"">
                                        <input type=""text"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""form-group row"">
                                    <label class=""col-sm-4 col-form-label"">Điện thoại</label>
                                    <div class=""col-sm-8"">
                                        <input type=""text"" class=""form-control"">
                                    </div>
                                </div>
                              ");
            WriteLiteral(@"  <div class=""form-group row"">
                                    <label class=""col-sm-4 col-form-label"">Địa chỉ</label>
                                    <div class=""col-sm-8"">
                                        <input type=""text"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""form-group row"">
                                    <label class=""col-sm-4 col-form-label"">Ghi chú của Khách</label>
                                    <div class=""col-sm-8"">
                                        <textarea class=""form-control"" cols=""5"" rows=""3""></textarea>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-sm-3 col-form-label text-danger"">Sản phẩm</label>
                            <div class=""col-s");
            WriteLiteral(@"m-9"">
                                <input type=""text"" placeholder=""Nhập thông tin sản phẩm và click chọn từ danh sách gợi ý"" readonly class=""form-control"">
                            </div>
                        </div>
                        <table class=""table"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th scope=""col"">SP</th>
                                    <th scope=""col"">KG(gr)</th>
                                    <th scope=""col"">SL</th>
                                    <th scope=""col"">Giá</th>
                                    <th scope=""col"">T.tiền</th>
                                    <th scope=""col"">C.chấu</th>
                                    <th scope=""col"">-</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th>bánh plant đậu</th>
 ");
            WriteLiteral(@"                                   <td>
                                        <input type=""text"" class=""form-control"" value=""1"">
                                    </td>
                                    <td>
                                        <input type=""text"" class=""form-control"" value=""10"">
                                    </td>
                                    <td>
                                        <input type=""text"" class=""form-control"" value=""500.000"">
                                    </td>
                                    <td>500000</td>
                                    <td>
                                        <input type=""text"" class=""form-control"" value=""0%"">
                                    </td>
                                    <td>
                                        <a href=""""><i class=""fas fa-times-circle""></i></a>
                                    </td>
                                </tr>
                            </tbody>
  ");
            WriteLiteral(@"                      </table>
                    </div>
                    <div class=""col-4 mt-3"">
                        <div class=""form-group"">
                            <h4 class=""text-danger"">Thanh toán <i class=""fas fa-arrow-down""></i></h4>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-sm-4 col-form-label"">Chiết chấu</label>
                            <div class=""col-sm-8"">
                                <select class=""form-control"">
                                    <option>Tiền mặt</option>
                                </select>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-sm-4 col-form-label"">Đặt cọc</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control"">
                            </div>
   ");
            WriteLiteral(@"                     </div>
                        <div class=""form-group row"">
                            <label class=""col-sm-4 col-form-label"">Tài khoản tiền mặt</label>
                            <div class=""col-sm-8"">
                                <select class=""form-control"">
                                    <option>Tài khoản tiền mặt</option>
                                </select>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-sm-4 col-form-label"">Chuyển khoản</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-sm-4 col-form-label"">Sau khi lưu dữ liệu</label>
                            <div class=""col-sm-8 form-group""");
            WriteLiteral(@">
                                <div class=""form-check"">
                                    <input type=""checkbox"" class=""form-check-input"">
                                    <label class=""form-check-label"">Tiếp tục thêm dữ liệu</label>
                                </div>
                                <div class=""form-check"">
                                    <input type=""checkbox"" class=""form-check-input"">
                                    <label class=""form-check-label"">Về danh sách đơn hàng</label>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <button type=""button"" class=""btn btn-secondary mr-1""><i class=""fas fa-save""></i> Lưu</button>
                            <button type=""button"" class=""btn btn-secondary""><i class=""fas fa-print""></i> Lưu và in</button>
                        </div>
                    </div>
                </div>
");
            WriteLiteral(@"
            </div>
            <!-- end dung hang van chuyen -->
            <!-- tu van chuyen -->
            <div class=""tab-pane fade"" id=""nav-tvc"" role=""tabpanel"" aria-labelledby=""nav-profile-tab"">

                <h3 class=""text-danger"">Chưa khả dụng</h3>

            </div>
            <!-- end tu van chuyen -->
        </div>

    </div>
    <!-- end xac nhan -->
    <!-- dong goi -->
    <div class=""tab-pane fade"" id=""nav-contact"" role=""tabpanel"" aria-labelledby=""nav-contact-tab"">...</div>
    <!-- end dong goi -->
</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
