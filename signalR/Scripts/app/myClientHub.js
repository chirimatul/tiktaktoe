
var chatHub;
$(document).ready(function () {

    chatHub = $.connection.chatHub;

    chatHub.client.addMessage = function (msg) {
        debugger
        $("#divMyMessages").append("<label >" + msg + "</label></br>");
    }

    // Start Hub
    $.connection.hub.start().done(function () {
       // debugger
        //chatHub.server.send("my test");

    });
});

function sendMyMessage() {
    debugger
    var msg = $('#txtMessage').val();
    $('#txtMessage').val("");
    $("#divMyMessages").append("<label >" + msg + "</label></br>");
    chatHub.server.send(msg);
}

