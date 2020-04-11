

const requestHandler = (request, response) => {

    console.log(request.url);
    response.end();
    
}


module.exports = requestHandler; 