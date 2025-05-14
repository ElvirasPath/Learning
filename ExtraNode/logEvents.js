//imports
const fs = require("fs");
const fsPromises = require("fs").promises;
const path = require("path");
const {format} = require("date-fns");
const {v4: uuid} = require("uuid");

//logging
const logEvents = async(message) =>
{
    const dateTime = `${format(new Date(), "dd.MM.yyyy\tHH:mm:ss")}`;
    const theLog = `${dateTime}\t${uuid()}\t${message}\n`;
    console.log(theLog);

    try
    {
        if(!fs.existsSync(path.join(__dirname, "logs")))
        {
            await fsPromises.mkdir(path.join(__dirname, "logs"))
        }
        await fsPromises.appendFile(path.join(__dirname, "logs", "eventLog.txt"), theLog);
    }
    catch(err)
    {
        console.log(err);
    }
}

module.exports = logEvents;