// Wait for Page Load
$(document).ready(function () {

    // Run Query on click of Search button
    $('#Search').on('click', function () {

        var api = 'http://api.giphy.com/v1/gifs/search?q='; //API url & end pt
        var userInput = $('#userQuery').val().trim(); //User Query
        userInput = userInput.replace(/ /g, "+"); //Convert
        var limit = '&limit=24'; //Display Limit
        var key = '&api_key=szNwzXJMm8DEiyzh7v71vG5V0e3rXwpw'; //API Key --> Replace with ViewBag.apiKey when I solve this error

        // Create the data string (API Url + Query + API Key + Data Limit)
        var queryURL = api + userInput + key + limit;
        console.log(queryUrl);
        // Part 2 - Use AJAX to call GIPHY API 
        $.ajax({
            url: queryURL, //Url 
            method: 'GET', //Method Type
            dataType: 'json', //Type Gotten Back
            success: function (giphy) { //On Success, Return Images
                giphy.data.forEach(function (gif) {
                    $('#searchResults').append('<img src="${gif.images.fixed_height.url}">');
                });
            },
            error: errorReport
        });
    });

    function errorReport() {
        console.log("Something has gone wrong, better luck next time!");
        return false;
    }
});