var http = require('http');
var fs = require('fs');


var app = http
                .createServer( function(request,response){

                    var readStream = fs.createReadStream('./index.html');
                    response.writeHead(200, {"Content-type" : "text/html"});
                    readStream.pipe(response);

                    if(request.url == '/message'){

                        response.end("File submitted");

                        var data = request.body;

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
                .listen(7500);