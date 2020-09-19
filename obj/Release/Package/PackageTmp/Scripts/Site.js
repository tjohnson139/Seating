//function HiddenValue() {

//    document.getElementById('NotActive').value = "true";
//}


//<script src="~/Scripts/jquery-3.4.1.min.js"></script>
//<script src="~/Scripts/jquery.unobtrusive-ajax.min.js"></script>
//<script src="https://cdn.jsdelivr.net/npm/sweetalert2@9"></script>

//$(document).ready(function () {
//    $("#submit-form").click(function () {
//        var model = {};
//        model.EmployeeID = Number($("#employeeId").val());
//        console.log("model", model);
//        $.ajax({
//            type: "HttpPost",
//            url: "/Home/CreateData",
//            dataType: 'json',
//            data: JSON.stringify(model),
//            contentType: "application/json; charset=utf-8",
//            success: function (data) {
//                if (data.success)
//                    window.location.href = "/Home/Index";
//                else
//                    alert("Error: Break not submitted");
//            },
//            error: function () {
//                alert("Error: Break not submitted");
//            }
//        });
//    });



//});

//$(".empName").click(function () {
//    Swal.fire({
//        title: 'Are you sure?',
//        text: "Remove from the break list?",
//        icon: 'warning',
//        showCancelButton: true,
//        confirmButtonColor: '#3085d6',
//        cancelButtonColor: '#d33',
//        confirmButtonText: 'Yes'
//    }).then((result) => {
//        if (result.value) {
//            $.ajax({
//                type: "Post",
//                url: "/Home/DeleteBreaks",
//                dataType: 'json',
//                data: { "breakID": $(this).closest("tr").find(".hiddenBreaksID").val() },
//                success: function (data) {

//                    if (data == true) {
//                        Swal.fire({
//                            icon: 'success',
//                            title: 'Successfully Removed!',
//                            showConfirmButton: false,
//                            timer: 1000,

//                        })
//                        setTimeout(function () {
//                            location.reload();
//                        }, 2000);
//                    }
//                    else {
//                        Swal.fire({
//                            icon: 'error',
//                            title: 'Failure!',
//                            showConfirmButton: false,
//                            timer: 2000
//                        })
//                    }
//                },
//                error: function () {
//                    alert("Something went wrong. What is this? Tritech?");
//                }
//            });
//        }
//    })


//});

////DTH JQuery

//$(document).ready(function () {
//$("#Dthsubmit-form").click(function () {
//    var model = {};
//    model.EmployeeID = Number($("#dthemployeeId").val());
//    console.log("model", model);
//    $.ajax({
//        type: "HttpPost",
//        url: "/Home/CreateDth",
//        dataType: 'json',
//        data: JSON.stringify(model),
//        contentType: "application/json; charset=utf-8",
//        success: function (data) {
//            if (data.success)
//                window.location.href = "/Home/Index";
//            else
//                alert("Error: DTH not submitted");
//        },
//        error: function () {
//            alert("Error: DTH not submitted");
//        }
//    });
//});



//});

//$(".empNameDth").click(function () {
//    Swal.fire({
//        title: 'Are you sure?',
//        text: "Remove from the DTH list?",
//        icon: 'warning',
//        showCancelButton: true,
//        confirmButtonColor: '#3085d6',
//        cancelButtonColor: '#d33',
//        confirmButtonText: 'Yes'
//    }).then((result) => {
//        if (result.value) {
//            $.ajax({
//                type: "Post",
//                url: "/Home/DeleteDth",
//                dataType: 'json',
//                data: { "dthID": $(this).closest("tr").find(".hiddenDthID").val() },
//                success: function (data) {

//                    if (data == true) {
//                        Swal.fire({
//                            icon: 'success',
//                            title: 'Successfully Removed!',
//                            showConfirmButton: false,
//                            timer: 1000,

//                        })
//                        setTimeout(function () {
//                            location.reload();
//                        }, 2000);
//                    }
//                    else {
//                        Swal.fire({
//                            icon: 'error',
//                            title: 'Failure!',
//                            showConfirmButton: false,
//                            timer: 2000
//                        })
//                    }
//                },
//                error: function () {
//                    alert("Something went wrong. What is this? Tritech?");
//                }
//            });
//        }
//    })


//});
