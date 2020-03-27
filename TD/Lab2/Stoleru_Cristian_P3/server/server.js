const io = require("socket.io");
const server = io.listen(8000);
let connectedClients = new Map();

// event fired every time a new client connects
server.on("connection", (socket) => {
    console.info(`Client connected [id=${socket.id}]`);
    connectedClients.set(socket);

    // when socket disconnects, remove it from the list
    socket.on("disconnect", () => {
        connectedClients.delete(socket);
        console.info(`Client [id=${socket.id}] disconnected` );
    });

    socket.on("message-from-client", (payload) => {
        sendMessageToAllOtherClients(socket, payload);
    });

});

function sendMessageToAllOtherClients(sender, message) {
    for (const [client, sequenceNumber] of connectedClients.entries()) {
        if (sender.id != client.id) client.emit("message-from-server", message);
    }
}

