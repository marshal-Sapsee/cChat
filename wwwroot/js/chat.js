"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    message = message.replace(/^\s+|\s+$/g, '')
    if (message)
    {

        //document.getElementById("hiddenStatus").value = user;

        var date = new Date();
        var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
        var encodedMsg = user + "\n" + date.toLocaleString() + "\n" + "" + msg;
        var tbl = document.getElementById("drop-area");

        if (user == document.getElementById("hiddenName").value) {
            if (document.getElementById("hiddenStatus").value == document.getElementById("hiddenName").value) {
                var messagedocument = tbl.insertRow();
                var messagesList = document.createElement("ul");
                messagesList.className = "from-me-twice";
                messagesList.textContent = message;
                messagesList.id = "lastMessageLi";
                messagedocument.id = "lastMessage";
                messagedocument.appendChild(messagesList);
                document.getElementById("drop-area").appendChild(messagedocument);
                document.getElementById("hiddenStatus").value = user;
        }
        else {
            var messagedocument = tbl.insertRow();
            var messagesList = document.createElement("li");
                messagesList.className = "from-me";
                messagesList.textContent = encodedMsg;
                messagesList.id = "lastMessageLi";
                messagedocument.id = "lastMessage";
                messagedocument.appendChild(messagesList);
                document.getElementById("drop-area").appendChild(messagedocument);
                document.getElementById("hiddenStatus").value = user;
        }
    }
        else {
            if (document.getElementById("hiddenStatus").value == document.getElementById("hiddenName").value || document.getElementById("hiddenStatus").value=="Empty") {
                var messagedocument = tbl.insertRow();
                var messagesList = document.createElement("li");
                messagesList.className = "from-them";
                messagesList.textContent = encodedMsg;
                messagesList.id = "lastMessageLi";
                messagedocument.id = "lastMessage";
                messagedocument.appendChild(messagesList);
                document.getElementById("drop-area").appendChild(messagedocument);
                document.getElementById("hiddenStatus").value = user;
            }
            else {
                var messagedocument = tbl.insertRow();
                var messagesList = document.createElement("ul");
                messagesList.className = "from-them-twice";
                messagesList.textContent = message;
                messagesList.id = "lastMessageLi";
                messagedocument.id = "lastMessage";
                messagedocument.appendChild(messagesList);
                document.getElementById("drop-area").appendChild(messagedocument);
                document.getElementById("hiddenStatus").value = user;
            }
        }
        window.scrollTo(pageXOffset, 9999);
    }
})

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.addEventListener('keydown', function (event) {
    if (event.code == 'Enter' && (event.ctrlKey || event.metaKey)) {
        var userst = document.getElementById("hiddenName").value;
        var message = document.getElementById("messageInput").value;
        document.getElementById("messageInput").value = "";

        connection.invoke("SendMessage", userst, message).catch(function (err) {
            return console.error(err.toString());
        });

        event.preventDefault();
    }
});

connection.on('Notify', function (message) {
    let notifyElem = document.createElement("b");
    notifyElem.appendChild(document.createTextNode(message));
    let elem = document.createElement("p");
    elem.appendChild(notifyElem);
    var firstElem = document.getElementById("messageList").firstChild;
    document.getElementById("messageList").insertBefore(elem, firstElem);
});

document.getElementById("sendButton").addEventListener("click", function (event) {

    //var user = ;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

let dropArea = document.getElementById('drop-area')

    ;['dragenter', 'dragover', 'dragleave', 'drop'].forEach(eventName => {
        dropArea.addEventListener(eventName, preventDefaults, false)
    })
function preventDefaults(e) {
    e.preventDefault()
    e.stopPropagation()
}

;['dragenter', 'dragover'].forEach(eventName => {
    dropArea.addEventListener(eventName, highlight, false)
})
    ;['dragleave', 'drop'].forEach(eventName => {
        dropArea.addEventListener(eventName, unhighlight, false)
    })
function highlight(e) {
    dropArea.classList.add('highlight')
}
function unhighlight(e) {
    dropArea.classList.remove('highlight')
}

dropArea.addEventListener('drop', handleDrop, false)
function handleDrop(e) {
    let dt = e.dataTransfer
    let files = dt.files
    handleFiles(files)
}

function handleFiles(files) {
    ([...files]).forEach(uploadFile)
}


