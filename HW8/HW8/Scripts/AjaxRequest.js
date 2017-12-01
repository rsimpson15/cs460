function callFunction(genre) {
    $("#list").empty();//Clear old data before ajax

    $.ajax({
        url: 'Artists/GetGenre',
        type: 'POST',
        data: { 'Name': 'Tesselation' },
        success: function (data) {
            console.log('success?');
            var table = $("#list");
            $.each(data, function (elem) {
                $('#list').append(item);
            });
        },
        error: function () {
            alert('There was an error.');
        }
    });

};