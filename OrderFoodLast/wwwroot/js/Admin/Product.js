$('ul.pagination > li').addClass('page-item');
$('ul.pagination > li > span').addClass('page-link');
$('ul.pagination > li.active').addClass('active');
$('ul.pagination > li > a').addClass('page-link');
$(function () {
//var selectedVal = $("#inputState option:selected").val();
//alert(selectedVal);
    $("#inputState").on("change",function () {
        var valueSelected = this.value;
        $.ajax({
            url: "/Admin/Product/SelectCategory",
            type: "GET",
            data: {
                page: 1,
                metaTitle: valueSelected
            },
            success: function (data) {
                $(".bodyContent").html("");
                $(".bodyContent").html(data);
            }
        });
    });
    $(".sua-loai").click(function () {
        var maLoai = $(this).data("maloai");
        
        $.ajax({
            url: "/Admin/Product/CreateOrEdit",
            type: "GET",
            data: { id: maLoai },
            success: function (data) {
                $("#modal-body").html("");
                $("#modal-body").html(data);
                $("#myModal").modal("show");
                //$("#divScript").html(data.scriptContent);

            }
        });
    });
});