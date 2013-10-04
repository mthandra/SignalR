$(function () {
    var proxy = $.connection.chatHub;
    proxy.client.logMessage = function (message) {
        console.log(message);
    };

    $.connection.hub.logging = true;

    $.connection.hub.connectionSlow(function () {
        console.log('We are currently experiencing difficulties with the connection.')
    });

    $.connection.hub.error(function (error) {
        console.log('SignalR error: ' + error)
    });

    $.connection.hub.start({ transport: 'longPolling' }).done(function () {
        console.log("Started");
    });
});