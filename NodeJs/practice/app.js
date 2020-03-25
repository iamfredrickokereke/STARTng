const fs = require('fs');

fs.writeFile("message.txt", "it worked!", 'utf-8', (err) => {
    if(err) throw err;
    console.log("Data is saved");
})

