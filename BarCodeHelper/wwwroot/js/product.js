var dataTable;
$(document).ready(function () {
    loadDataTable();
});
function loadDataTable() {
    dataTable = $('#productTblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'serialNumber', "width": "20%" },
            { data: 'name', "width": "20%" },
            { data: 'category', "width": "20%" },
            {
                data: 'serialNumber',
                "render": function (data) {
                    return `<div class="w-100 btn-group" role="group">
                    <a href="/admin/product/edit?serialNumber=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                    <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`
                },
                "width": "40%"
            }
        ]
    });
}

function Delete (url)
{
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
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    });
}