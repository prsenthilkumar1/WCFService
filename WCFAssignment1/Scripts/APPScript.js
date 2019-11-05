$(document).ready(function () {
    $("#btnGetHTTPMessage").click(function () {
        $.ajax({
            contentType: "application/json; charset=utf-8",
            url: '/Home/GetHelloMessage',
            data: { name: $('#MessageModel_Name').val() },
            dataType: 'json',
            type: 'GET',
            success: function (e) {
                $('#MessageModel_Message').val(e);
            }
        });
    });


    $("#btnGetTCPMessage").click(function () {
        $.ajax({
            contentType: "application/json; charset=utf-8",
            url: '/Home/GetTodayProgram',
            data: { User: $('#MessageModel_User').val() },
            success: function (e) {
                $('#MessageModel_UserMessage').val(e);
            }
        });
    });


    $("#btnGetJobByRole").click(function () {
        $.ajax({
            contentType: "application/json; charset=utf-8",
            url: '/Home/GetJobByRole',
            data: { Role: $('#JobModel_JobRole').val() },
            type: 'GET',
            success: function (e) {
                $("#detailsDiv").html(e);
            }
        });
    });

    $("#btnAddition").click(function () {
        $.ajax({
            contentType: "application/json; charset=utf-8",
            url: '/Home/Addition',
            data:
            {
                firstnumber: $('#CalculatorModel_FirstNumber').val(),
                secondnumber: $('#CalculatorModel_SecondNumber').val(),
            },
            success: function (e) {
                $('#CalculatorModel_Result').val(e);
            }
        });
    });

    $("#btnSubtraction").click(function () {
        $.ajax({
            contentType: "application/json; charset=utf-8",
            url: '/Home/Subtraction',
            data:
            {
                firstnumber: $('#CalculatorModel_FirstNumber').val(),
                secondnumber: $('#CalculatorModel_SecondNumber').val(),
            },
            success: function (e) {
                $('#CalculatorModel_Result').val(e);
            }
        });
    });
}); 
