$(document).ready(function () {

    /*
    $('.group1').colorbox(
        {
            rel: '.group1',
            maxHeight: "80%",
            maxWidth: "80%",
            transition: "none",
            title: function () {

                var title = "";
                var titleText = $(this).attr('title')
                if (titleText != "") {
                    title = $(this).attr('title');
                }
                return title;
            }
        }
    );*/

    var numberOfProducts = $('.product').length;

    console.log("Number of products:" + numberOfProducts);

    for (var i = 1; i <= numberOfProducts; i++) {

        var imageColorboxSelector = '.group' + i;
        var relSelector = '.group' + i;

        $(imageColorboxSelector).colorbox({
            rel: relSelector,
            maxHeight: "80%",
            maxWidth: "80%",
            transition: "none",
            title: function () {

                var title = "";
                var titleText = $(this).attr('title')
                if (titleText != "") {
                    title = $(this).attr('title');
                }
                return title;
            }
        });
    }
});