$(function () {
    var pageNumber = parseInt($("#inputPagination").val()) - 1;
    if (pageNumber < 0) $(".Pre").addClass("disabled");
//var selectedVal = $("#inputState option:selected").val();
//alert(selectedVal);
    $("#inputPagination").on("change", function () {
       
        var pageNumber = this.value;        
        var metaTitle = $("#inputState option:selected").val();
        $.ajax({
            url: "/Admin/Product/SelectProduct",
            type: "GET",
            data: {
                page: pageNumber,
                metaTitle: metaTitle
            },
            success: function (data) {
                $(".bodyContent").html("");
                $(".bodyContent").html(data);
                $(".Pre").addClass("disabled");
            }
        });
    });
    $(".btnNext").on("click", function (e) {
        e.preventDefault();
        var pageNumber = parseInt($("#inputPagination").val()) + 1;
        
        var metaTitle = $("#inputState option:selected").val();
        $.ajax({
            url: "/Admin/Product/SelectProduct",
            type: "GET",
            data: {
                page: pageNumber,
                metaTitle: metaTitle
            },
            success: function (data) {
                $(".bodyContent").html("");
                $(".bodyContent").html(data);

            }
        });
    });
    $(".btnPrevious").on("click", function (e) {
        e.preventDefault();
        var pageNumber = parseInt($("#inputPagination").val()) - 1;
        $(".Pre").attr("disabled", true);
        var metaTitle = $("#inputState option:selected").val();
        if (pageNumber >= 0) {
            $.ajax({
                url: "/Admin/Product/SelectProduct",
                type: "GET",
                data: {
                    page: pageNumber,
                    metaTitle: metaTitle
                },
                success: function (data) {
                    $(".bodyContent").html("");
                    $(".bodyContent").html(data);
                }
            });
        }
        else {
            Swal.fire('Đã tới trang 1 !');
        }
        
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