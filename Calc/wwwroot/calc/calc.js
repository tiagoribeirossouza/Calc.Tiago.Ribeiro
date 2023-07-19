var calc = (function () {

    function Init() {
    }

    $('#btncalculer').on("click", function () {

        var num = $('#txtnumber').val();

        $.ajax({
            type: 'POST',
            url: '/Home/PostResultado',            
            data: { numbers: $('#txtnumber').val() },
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            dataType: "json",
            success: function (result) {
                $("#txtnumber").val(result);
                console.log(result);
            },
            error: function () {
                alert('Failed to receive the Data');
                console.log('Failed ');
            }
        })
    });

    $('#btn1').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btn1').val()));
    });

    $('#btn2').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btn2').val()));
    });

    $('#btn3').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btn3').val()));
    });

    $('#btn4').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btn4').val()));
    });

    $('#btn5').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btn5').val()));
    });

    $('#btn6').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btn6').val()));
    });

    $('#btn7').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btn7').val()));
    });

    $('#btn8').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btn8').val()));
    });

    $('#btn9').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btn9').val()));
    });

    $('#btn0').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btn0').val()));
    });

    $('#btnMais').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btnMais').val()));
    });

    $('#btnMenos').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btnMenos').val()));
    });

    $('#btnmult').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btnmult').val()));
    });

    $('#btndiv').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btndiv').val()));
    });

    $('#btnvirgule').on("click", function () {
        $("#txtnumber").val($('#txtnumber').val().concat($('#btnvirgule').val()));
    });

    $('#btnclear').on("click", function () {
        $("#txtnumber").val('');
    });
    

}());