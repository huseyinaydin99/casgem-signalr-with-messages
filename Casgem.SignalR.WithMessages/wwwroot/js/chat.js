"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/messageHubSender").build();

//Disable the send button until connection is established.
document.getElementById("sendMessage").disabled = true;
connection.on("Channel_huseyin_1", function (user, message) {
    var span = document.createElement("span");
    var hr = document.createElement("hr");
    document.getElementById("messagesList").appendChild(span);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    span.textContent = `${user} ${message}`;
    document.getElementById("messagesList").appendChild(hr);
    document.getElementById("messagesList").appendChild(br);
    
});

connection.start().then(function () {
    document.getElementById("sendMessage").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendMessage").addEventListener("click", function (event) {
    var user = document.getElementById("person").value;
    var message = document.getElementById("message").value;
    connection.invoke("SendChatMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});