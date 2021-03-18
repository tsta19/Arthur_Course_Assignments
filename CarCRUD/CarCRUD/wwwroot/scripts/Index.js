function add() {
    window.location.href = "/car-parts/create/";
}

function edit(id) {
    window.location = "https://localhost:5001/car-parts/edit/"+ id;

}



function list() {
    var registries = listCarparts();
    for (i = 0; i < registries.length; i++) {
        addRow(registries[i]);
    }
}
function get() {
    var id = parseInt($("#Search").val());
    var registry = getCarpart(id);
    var id = getRowId();
    $('table-content').append(
        $('<tr>').append(
            $('<th scope="col">ID</th>').append(
                $('<th scope="col">' + registry.name + '</th>').append(
                    $('<th scope="col">' + registry.price + '</th>').append(
                        $('<th scope="col">' + registry.deatils + '</th>')
                    ).append(
                        $('<div class="col-3">').append(
                            $('<div class="row">').append(
                                $('<button id="row-edit-' + id + '" class="btn btn-warning" onclick="edit(' + id + ');" editing=false >Edit</button>')

                            ).append(
                                $('<button id="row-delete-' + id + '" class="btn btn-danger" onclick="_delete(' + id + ')"  >_delete</button>')
                            )
                        )
                    )
                )
            )

        )
    )
}
function addRow(registry) {
    var id = GetRowId();
    $('table-content').append(
        $('<tr>').append(
            $('<th scope="col">ID</th>').append(
                $('<th scope="col">' + registry.name + '</th>').append(
                    $('<th scope="col">' + registry.price + '</th>').append(
                        $('<th scope="col">' + registry.deatils + '</th>')
                    ).append(
                        $('<div class="col-3">').append(
                            $('<div class="row">').append(
                                $('<button id="row-edit-' + id + '" class="btn btn-warning" onclick="edit(' + id + ');" editing=false >Edit</button>')

                            ).append(
                                $('<button id="row-delete-' + id + '" class="btn btn-danger" onclick="_delete(' + id + ')"  >Delete</button>')
                            )
                        )
                    )
                )
            )

        )
    )
}
function getNameInput(id) {
    return $('#row-name-' + id);
}

function getPriceInput(id) {
    return $('#row-price-' + id);
}

function getdetails(id) {
    return $('#row-details-' + id);
}

function editButton(id) {
    return $('#row-edit-' + id);
}

function getRowId() {
    var Table = $('#Table');
    var count = Table.children().length;
    var id = count + 1;

    while (getRow(id)[0] != null) {
        id++;
    } return id;
}

function getRow(id) {
    return $('#row-' + id);
}


function _delete(id) {
    getRow(id).remove();
    deleteCarpart(id);
}

function disable(element) {
    element.attr('disabled', true);
}

function enable(element) {
    element.attr('disabled', false);
}
function getCarPartFromForm() {
    var name = $('#name').val();
    var price = $('#price').val();
    var details = $('#details').val();
    return {
        name: name,
        price: price,
        details: details
    }
}

function createCarPart() {
    var response = null;
    console.log(getCarPartFromForm());
    console.log(JSON.stringify(getCarPartFromForm()));
    $.ajax({
        url: "https://localhost:5001/api/CarParts/create",
        contentType: "application/json",
        method: "POST",
        async: false,
        data: JSON.stringify(getCarPartFromForm()),
        success: function (data) {
            response = data;
        },
        error: function (er) {
            alert("error")
            console.log(er)

        }
    });
    return response;
}

function deleteCarPart(id) {
    var response = null;
    $.ajax({
        url: "https://localhost:5001/api/CarParts/delete?id=" + id,
        method: "DELETE",
        async: false,
        success: function (data) {
            response = data;
        },
        error: function (er) {
            alert("error")
            console.log(er)

        }
    });
    return response;
}

function listCarParts() {
    var response = null;
    $.ajax({
        url: "https://localhost:5001/api/CarParts/list",
        method: "GET",
        async: false,
        success: function (data) {
            response = data;
        },
        error: function (er) {
            alert("error")
            console.log(er)

        }
    });
    return response;
}

function updateCarPart(id) {
    var response = null;
    $.ajax({
        url: "https://localhost:5001/api/CarParts/update?id=" + id,
        method: "PUT",
        data: getCarPartFromForm(),
        async: false,
        success: function (data) {
            response = data;
        },
        error: function (er) {
            alert("error")
            console.log(er)

        }
    });
    return response;
}

function getCarpart(id) {
    var response = null;
    $.ajax({
        url: "https://localhost:5001/api/CarParts/get?id=" + id,
        method: "GET",
        async: false,
        success: function (data) {
            response = data;
        },
        error: function (er) {
            alert("error")
            console.log(er)

        }
    });
    return response;
}