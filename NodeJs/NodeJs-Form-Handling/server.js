const http = require('http');

const requestHandler = require('./routes');

const server = http.createServer(requestHandler);

const port = 8000;

server.listen(port);