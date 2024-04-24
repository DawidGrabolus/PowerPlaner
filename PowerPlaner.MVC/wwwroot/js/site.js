$(document).ready(function () {
    //NAVBAR
    $('#toggleSidebar').click(function () {
        $('.left-bar').toggleClass('collapsed');
        $(".list-group").slideUp(200);
    });


    $("#v-pills-home-tab, #v-pills-profile-tab, #v-pills-settings-tab").click(function () {
        $(".list-group").slideUp("slow");
    });   
});
