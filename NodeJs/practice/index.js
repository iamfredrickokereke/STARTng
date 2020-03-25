// import core http and file system core modules 

const http = require('http');
const fs = require('fs');

// create server and listen on port 8080

const app = http
               .createServer( function(request,response){

                   // Create read stream to read file from path
                   var readStream = fs.createReadStream('./index.html');
                   response.writeHead(200, {"Content-type" : "text/html"});
                   readStream.pipe(response);

                   //  check visited route and respond
                   if(request.url == '/message'){

                   response.end("File submitted");
                   // Store form data
                   var data = request.body;
                   // check data and write to new file
                   request.on("data", function(data) {
                            var decodedData = decodeURI(data)
                                .replace(/\+/, " ")
                                .replace("message=", "");
                            fs.writeFile("./message.txt", decodedData, function(err) {
                                if (err) throw err;
                            });
                            });
                    }
                
                })
            // server running port
            .listen(8080);