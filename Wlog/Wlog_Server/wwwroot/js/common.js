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


function ShowNewsDetailsModal() {
    $('#newsModal').modal('show');
}

function HideNewsDetailsModal() {
    $('#newsModal').modal('hide');
}