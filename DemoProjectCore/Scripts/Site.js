$(document).ready(function () {
    $("#btnShow").mousedown(function () {
        $("#Password").attr("type", "text");
    });
    $("#btnShow").on("mouseleave", function () {
        $("#Password").attr("type", "password");
    });
});

$(document).ready(function () {
    $("#btnHide").mousedown(function () {
        $("#Confirm_Password").attr("type", "text");
    });
    $("#btnHide").on("mouseleave", function () {
        $("#Confirm_Password").attr("type", "password");
    });
});

$(document).ready(function () {
    $("#btnSH").mousedown(function () {
        $("#Password").attr("type", "text");
    });
    $("#btnSH").on("mouseleave", function () {
        $("#Password").attr("type", "password");
    });
});

