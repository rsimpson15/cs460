function searchResults() {
    var searchTerms = document.getElementById('userQuery').value.trim();
    var output = document.getElementById('searchResults');

    if (searchTerms !== null || searchTerms !== "") {
        var rating = null;
        var element = null;
        var termString = searchTerms.split(" ").join('+'); //change spaces to - as Giphy does on their site
        console.log(termString);

        // get the rating value
        rating = $("#rating").val();

        // Clear the html before appending new results
        $('#searchResults').html(null);

        $.ajax({
            url: "/Search/",
            type: "POST",
            data: { termString: termString, topResult: topResult, rating: rating },
            success: function (returnData) { //On Success, Return Images into a grid 
                returnData.data.forEach(function (item) {
                    $('#searchResults').append(`<div class="col-lg-4 imgDiv"><img src="${item.images.fixed_height.url}" class="col-lg -4 imgClass"></div>`);
                }
                );
            }
        });
    }
}