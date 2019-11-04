$(function () {
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
                console.log(data);
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