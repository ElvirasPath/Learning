//imports
const logEvents = require("./logEvents");
const EventEmitter = require("events");

class TheEmitter extends EventEmitter{};
const emitter = new TheEmitter();

//Emit "log" event
emitter.on("log", (msg) => logEvents(msg))

setTimeout(() =>
{
    emitter.emit("log", "Something changed!")
},2000);