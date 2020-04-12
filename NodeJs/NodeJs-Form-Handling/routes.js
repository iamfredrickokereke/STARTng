
const form = `

            <!DOCTYPE html>
            <html lang="en">
            <head>
                <meta charset="UTF-8">
                <meta name="viewport" content="width=device-width, initial-scale=1.0">
                <meta http-equiv="X-UA-Compatible" content="ie=edge">
                <title> Send us a Message</title>
            </head>
            <body>
                <form action="/message" method="post">  
                    <input type="text" name="input-box" id="">
                    <input type="button" value="Send">
                </form>
            </body>
            </html>

`


const requestHandler = (request, response) => {

        const url = request.url;
        const method = request.method;
        const body = request.body;
    
        if(url === "/"){
            response.write(form)            
        }

        if ( url === "/message" && method === "POST") {
            
        }
    response.end();
    
}


module.exports = requestHandler; 