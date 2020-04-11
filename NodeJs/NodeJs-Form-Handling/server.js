const http = require('http');

const server = http.createServer(requestHandler);

const port = 8000;

server.listen(port);