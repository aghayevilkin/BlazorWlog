window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, 'Succesful')
    }
    if (type === "error") {
        toastr.error(message, 'Failed')
    }
    if (type === "info") {
        toastr.info(message, 'Info')
    }
    if (type === "warning") {
        toastr.warning(message, 'Warning')
    }
}

window.ShowSwal = (type, message) => {
    if (type === "success") {
        Swal.fire(
            'Success Notfication',
            message,
            'success'
        )
    }
    if (type === "error") {
        Swal.fire(
            'Error Notfication',
            message,
            'error'
        )
    }

}



function ShowDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('hide');
}



$(document).ready(function () {
    $("#categoryId").change(function () {
        $("#subcategoryId").empty();
        $.ajax({
            type: 'GET',
            url: '@Url.Action("LoadSubCategory")',

            dataType: 'json',

            data: { id: $("#categoryId").val() },

            success: function (subcategories) {
                $("#subcategoryId").append('<option value="' + 0 + '">' + "Select Sub Category" + '</option>');

                $.each(subcategories, function (i, subcategory) {
                    $("#subcategoryId").append('<option value="' + subcategory.value + '">' + subcategory.text + '</option>');
                });
            },
            /*error: function*/
        });
        return false;
    })
})