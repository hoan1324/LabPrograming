$("#create-student-form").validate({
    rules: {
        Name: {
            required: true,
            minlength: 2
        },
        Email: {
            email: true,
            required: true,
        },
       
        DateOfBorth: {
            required: true
        }
    },
    messages: {
        Name: {
            required: "Tên không được để trống",
            minlength: "Tên có từ 2 kí tự trở lên"
        },
        Email: {
            email: "Email không đúng định dạng",
            required: "Email không được để trống",
        },
       
        DateOfBorth: {
            required: "Ngày sinh không được để trống"
        }
    },
    submitHandler: function (form) {
        form.submit();
    }
});