$(function () {
    $("#header-container").css('height', $(document).outerHeight());
    //$("#header-container").css('line-height', $(document).outerHeight());
    $("header h1").css('position', 'absolute');
    $("header h1").css('left', $(document).width() / 2 - ($("header h1").width() / 2));
    $("header h1").css('top', $(window).height() / 2 - ($("header h1").height() / 2));
    setTimeout(function () {
        $("#header-container").animate({ 'height': '70px' }, 500);
        $("header h1").animate({ 'left': '120px', 'top': '0px' }, 500);

    }, 1000);
    
    $('.category').click(function () {
        var id = $(this).attr('id');
        $('.category').each(function () {
            if ($(this).attr('id') != id) {
                $(this).slideUp(400);
            } else {
                $(this).animate({ 'width': '57%' });
            }
        });
    });
});