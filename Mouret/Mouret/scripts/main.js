$(document).ready(function () {

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
    );
});