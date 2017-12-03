function callFunction(selectedGenre) {
    $("#list").empty();//Clear old data before ajax

    $.ajax({
        url: "/Artists/GetGenre",
        type: "POST",
        data: { genre : selectedGenre },
        success: function (data) {
            console.log(data);
            data.arr.forEach(function (item) {
                $('#list').append(item);
            });
        },
        error: function () {
            alert('There was an error.');
        }
    });
}