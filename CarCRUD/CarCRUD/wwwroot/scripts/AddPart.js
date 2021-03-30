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