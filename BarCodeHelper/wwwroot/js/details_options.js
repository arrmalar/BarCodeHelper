var oldCategory;
var oldName;

function save(barCode) {
    $.ajax({
        url: '/Employee/Options/Save',
        type: 'POST',
        data: { barCode: barCode },
        success: function (response) {
            finishEdit();
        },
        error: function (xhr, status, error) {
            console.error("An error occurred: " + status + " " + error);
        }
    });
}

function startEdit() {
    setButtons("Save", "Cancel");

    document.getElementById('inputFieldProductName').readOnly = false;
    document.getElementById('productCategory').disabled = false;
}

function finishEdit() {
    oldCategory = document.getElementById('productCategory').value;
    oldName = document.getElementById('inputFieldProductName').value;

    setButtons("Edit", "Back");

    document.getElementById('productCategory').disabled = true;
    document.getElementById('inputFieldProductName').readOnly = true;
}

function cancelEdit() {
    document.getElementById('productCategory').value = oldCategory;
    document.getElementById('inputFieldProductName').value = oldName;

    setButtons("Edit", "Back");

    document.getElementById('productCategory').disabled = true;
    document.getElementById('inputFieldProductName').readOnly = true;
}

function setButtons(editButton, cancelButton) {
    document.getElementById('editButton').innerHTML = editButton;
    document.getElementById('cancelButton').innerHTML = cancelButton;
}

function initBarcodeDetails(model) {
    
    console.log('Model:', model);

    oldCategory = model.product.category;
    oldName = model.product.name;

    document.getElementById('productCategory').value = model.product.category;
    document.getElementById('inputFieldProductName').value = model.product.name;

    document.getElementById('editButton').addEventListener('click', function () {
        var inner = this.innerHTML;

        if (inner.trim() === "Edit") {
            startEdit();
        } else {

            var sss = $('#detailsForm').validate();

            if (!$('#detailsForm').validate()) {
                return;
            }

            model.product.category = document.getElementById('productCategory').value;
            model.product.name = document.getElementById('inputFieldProductName').value;
            save(model);
        }
    });
    document.getElementById('cancelButton').addEventListener('click', function () {
        var inner = this.innerHTML;

        if (inner.trim() === "Back") {
            location.href = '/Employee/Options/OptionsPanel'; // do poprawy, trzeba przekazać model na nowo
        } else {
            cancelEdit();
        }
    });

    $.ajax({
        url: '/employee/options/getallcategories',
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
}