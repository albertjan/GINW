var map;
var marker;

$(function () {
    findLocation();
    var id;
    $("#header-container").css('height', $(document).outerHeight());
    //$("#header-container").css('line-height', $(document).outerHeight());
    $("header h1").css('position', 'absolute');
    $("header h1").css('left', $(document).width() / 2 - ($("header h1").width() / 2));
    $("header h1").css('top', $(window).height() / 2 - ($("header h1").height() / 2));
    setTimeout(function () {
        $("#header-container").animate({ 'height': '12%' }, 500);
        $("header h1").animate({ 'left': '5%', 'top': '0px' }, 500);

    }, 1000);
    
    $('.category').click(function () {
        id = $(this).attr('id');
        $("#what").keyup(function () {
            var category = $('#' + id).html();
            if ($(this).val() != "") {
                $.getJSON("/data/filter/" + category + "/" + $(this).val(), function(data) {
                    var sugs = "";
                    $.each(data, function(i, item) {
                        sugs = sugs + item + "<br>";
                    });
                    $(".what-sugestions").html(sugs);
                });
            } else {
                $(".what-sugestions").html("");
            }
        });
        
        $('.category').each(function () {
            if ($(this).attr('id') != id) {
                $(this).animate({'opacity': '0.5'});
            } 
        });
        $(this).animate({ 'opacity': '1' });

        $('#nav-header-container-2').fadeIn(500);


        var myOptions = {
            //zoom: 15,lat: "53.2176002",
            //longi: "6.5556452"
            center: new google.maps.LatLng(53.2176002, 6.5556452),
            zoom: 14,
            mapTypeControl: false,
            //mapTypeControlOptions: { style: google.maps.MapTypeControlStyle.DROPDOWN_MENU },
            navigationControl: false,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);
        var center;
        
        $.getJSON("/data/location", function(data) {
            center = new google.maps.LatLng(data.lat, data.longi);
            marker = new google.maps.Marker({
                position: center,
                map: map,
                title: "You are here"
            });

            marker.setMap(map);
        });
        

        //var ZoomPanControl = new missouristate.web.ZoomPanControl(map);
        //ZoomPanControl.index = -1;
        //map.controls[google.maps.ControlPosition.TOP_LEFT].push(ZoomPanControl);
       

    });
});

function findLocation() {
    navigator.geolocation.getCurrentPosition(foundLocation, noLocation);
}
function foundLocation(position) {
    var lat = position.coords.latitude;
    var longi = position.coords.longitude;
    
    $.post('/data/location', {
        lat: lat,
        longi: longi
    });

}
function noLocation() {
    alert('Could not find location');
}