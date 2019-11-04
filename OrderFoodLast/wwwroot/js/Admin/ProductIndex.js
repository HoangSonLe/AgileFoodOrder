$(function () {
    //var selectedVal = $("#inputState option:selected").val();
    //alert(selectedVal);
    $("#inputState").on("change", function () {
        var metaTitle = this.value;
        $.ajax({
            url: "/Admin/Product/SelectProduct",
            type: "GET",
            data: {
                page: 0,
                metaTitle: metaTitle
            },
            success: function (data) {
                $(".bodyContent").html("");
                $(".bodyContent").html(data);
            }
        });
    });
    $(".btnTimKiem").click(function () {
        var nameProduct = $(".inputFindName").val();
        if (nameProduct != "") {
            var metaTitle = $("#inputState option:selected").val()
            $.ajax({
                url: "/Admin/Product/SearchByName",
                type: "get",
                data: {
                    page: 0,
                    ProductName: nameProduct,
                    metaTitle: metaTitle
                },
                success: function (data) {
                    $(".bodyContent").html("");
                    $(".bodyContent").html(data);
                    //$("#divscript").html(data.scriptcontent);

                }
            });
        }
        else {
            Swal.fire('Nhập tên cần tìm!!!')
        }
    });
    $(".btnRefresh").click(function () {
        var metaTitle = $("#inputState option:selected").val()
        $.ajax({
            url: "/Admin/Product/SelectProduct",
            type: "get",
            data: {
                page: 0,
                metaTitle: metaTitle
            },
            success: function (data) {
                $(".bodyContent").html("");
                $(".bodyContent").html(data);
                $(".inputFindName").val("");

            }
        });
        
    });
});