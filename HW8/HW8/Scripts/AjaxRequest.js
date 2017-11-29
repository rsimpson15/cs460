
$(document).ready(function () {

    function callFunction(genre) {
        $("#list").empty();//Clear old data before ajax
        console.log('clicked');

        $.ajax({
            url: '@URL.Action("GetGenre")',
            type: 'POST',
            data: {'Name': 'Tesselation' },
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

    };

});
