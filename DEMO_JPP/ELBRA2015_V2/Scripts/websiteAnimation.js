
$(document).ready(function () {
    $('#to-top').hide();
    //Check to see if the window is top if not then display button
    $(window).scroll(function () {
        if ($(this).scrollTop() > 200) {
            $('#to-top').fadeIn();
        } else {
            $('#to-top').fadeOut();
        }
   
      

    });
    window.onload=function () {
        var lastPart = window.location.href.split("/").pop();
        //var value = '#' + lastPart.toLowerCase() + 'Wrapper';

        if (lastPart == 'Register' || lastPart == 'ForgotPassword' || lastPart=="Login" || lastPart=="Diensten" || lastPart.substring(0, 12)=="ConfirmEmail") {
            $('html, body').animate({ scrollTop: $('#mainWrapper').offset().top -80});
        }
    

    };
 
    //Click event to scroll to top
    $('#to-top').click(function () {
        $('html, body').animate({ scrollTop: 0 }, 800);
        return false;
    });
    $('#centraleButton').click(function () {
        $('html, body').animate({ scrollTop: $("#mainWrapper").offset().top - 100 }, 800);
        return false;
    });
    $('#menuItem1').click(function () {
        $('html, body').animate({ scrollTop: 0 }, 800);
        return false;
    });
    $('#menuItem3').click(function () {
        $('html, body').animate({ scrollTop: $("#wrapper4").offset().top }, 800);
        return false;
    });
    $('#menuItem4').click(function () {
        $('html, body').animate({ scrollTop: $("#extraWrapper").offset().top - 100 }, 800);
        return false;
    });

});