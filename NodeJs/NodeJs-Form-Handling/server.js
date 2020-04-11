const http = require('http');

const server = http.createServer(requestHandler);

server.listen(port);