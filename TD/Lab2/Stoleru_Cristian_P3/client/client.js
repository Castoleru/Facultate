var socket = io.connect('localhost:8000');

function printValue(divId,value)
{
document.getElementById(divId).innerHTML = value;
}

var list = [];
var textarea = document.getElementById("my_messages");

try {

    socket.on('connect', function (data) {
        //socket.emit("message-from-client", "Hello to everyone from " + checkBrowser());
		//console.log("client started");
    });

    socket.on('message-from-server', function (message) {
        console.log("received message: "+message);

        list.push("Mesaj primit: " + message);
        textarea.value = list.join('\n');

    
        printValue("my_messages",textarea);
		
    });

}
catch (err) {
    alert('ERROR: socket.io encountered a problem:\n\n' + err);
}

function checkBrowser() {
    var browser = 'Noname browser';
    if (navigator.userAgent.search("Chrome") > -1) {
        browser = "Chrome";
    }
    if (navigator.userAgent.search("Firefox") > -1) {
        browser = "Firefox";
    }
    return browser;
}

document.getElementById("send").addEventListener("click", sendMessage);
document.getElementById("clear").addEventListener("click", clear);


function sendMessage() {
    var message = document.getElementById("message").value;
    socket.emit("message-from-client", message);
	console.log("sent message: "+message);
document.getElementById("message").value = "";
    list.push("Mesaj trimis: " + message);
    textarea.value = list.join('\n');

    
    printValue("my_messages",textarea);
	
	}

function clear()
{
textarea.value = "";
list = [];
}

document.getElementById("message").addEventListener("keyup", function(event) {
    event.preventDefault();
    if (event.keyCode === 13) {
        document.getElementById("send").click();
    }
});
