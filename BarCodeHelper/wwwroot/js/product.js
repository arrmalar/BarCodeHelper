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
                    <a onClick=Delete('/admin/product/delete?serialNumber=${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
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

$.ajax({
    url: '/admin/product/getallcategories',
    type: 'GET',
    success: function (response) {
        console.log('Categories AJAX response:', response);
        if (response && Array.isArray(response.data)) {
            const categoriesDropdown = $('#productCategory');
            categoriesDropdown.empty();
            categoriesDropdown.append('<option value="">Select a category</option>');

            for (const category of response.data) {
                categoriesDropdown.append(`<option value="${category}">${category}</option>`);
            }

            categoriesDropdown.selectpicker('refresh');
        } else {
            console.error('Unexpected response structure or data is not an array.');
        }
    },
    error: function (xhr, status, error) {
        console.error("An error occurred while fetching categories: " + status + " " + error);
    }
});

$(document).ready(function () {
    document.getElementById('serialNumberInput').addEventListener("input", function () {
        var serialNumber = $(this).val();

        $.ajax({
            type: "POST",
            url: '/admin/product/checkserialnumberexists',
            data: { serialNumber: serialNumber },
            success: function (response) {
                if (response.exists) {
                    $("#serialNumberError").text("A product with this serial number already exists.");
                } else {
                    $("#serialNumberError").text("");
                }
            },
            error: function () {
                console.log("Error in AJAX request");
            }
        });
    });
 });
