// // const fs = require('fs');

fs.writeFile("message.txt", "it worked!", 'utf-8', (err) => {
    if(err) throw err;
    console.log("Data is saved");
})

// var fs = require("fs");
// var http = require("http");

// function handleRequest(req, res) {
//   res.writeHead(200, {
//     "Content-Type": "text/html"
//   });
//   fs.readFile("./index.html", null, function(err, data) {
//     if (err) {
//       res.writeHead(404);
//       res.write("Error! File not found!");
//     } else {
//       res.write(data);
//     }
//     res.end();
//   });
//   req.on("data", function(data) {
//     var decodedData = decodeURI(data)
//       .replace(/\+/, " ")
//       .replace("message=", "");
//     fs.writeFile("./message.txt", decodedData, function(err) {
//       if (err) throw err;
//     });
//   });
// }
// http.createServer(handleRequest).listen(8080);

var http = require('http')
var fs = require('fs');

var form = `
<html>
  <body>
    <h3>Please enter a message below:</h3>
    <form method='POST' action='/message'>
      <label>Message: </label><br>
      <input type='text' name='message'><br>
      <input type='submit'>
    </form>
  </body>
</html>`

http.createServer((req, res) => {
  if (req.method === 'POST'){
    var body = '';
    req.on('data', data => {
      body += `${data} \n`
    });
    req.on('end', () => {
      fs.writeFile('message.txt', body, err => {
        if (err) throw err;
      });
      res.write(form);
      res.end()
    });
  } else {
      res.writeHead(200, { "Content-Type": "text/html" });
      res.write(form);
      res.end();
    }
}).listen(8080);
