function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    toastr.success(data.message, data.success ? "Success" : "Error", {
                        positionClass: "toast-top-right",
                        closeButton: true,
                        progressBar: true,
                        timeOut: 5000,
                    });
                },
                error: function (xhr, status, error) {
                    toastr.error("An error occurred while deleting the item.", "Error", {
                        positionClass: "toast-top-right",
                        closeButton: true,
                        progressBar: true,
                        timeOut: 5000
                    });
                }
            });
        }
    });
}