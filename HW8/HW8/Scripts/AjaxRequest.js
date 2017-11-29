
$(document).ready(function () {

    function callFunction(genre) {
        $("#list").empty();//Clear old data before ajax
        console.log('clicked');
        $.ajax({
            url: "Artists/GetGenre/",
            type: 'POST',
            data: { genre: genre },
            success: function (data) {
                console.log('success?');
                var table = $("#list");
                returnData.arr.forEach(data, function (elem) {
                    $('#list').append(item);
                });
            },
            error: function () {
                alert('There was an error.');
            }
        });
   }
});
