var MongoClient = require('mongodb').MongoClient;
//Append the Database name you want to connect to (/slackname), to the base URL.
var url = "mongodb://localhost:27017/kelly_eric";
var Admin = "Kelly";

// create a client to mongodb
MongoClient.connect( url, {useNewUrlParser: true, useUnifiedTopology: true}, function(err, db) {

  // db object that points to the database "kelly_eric"  and store in dbo

  var dbo = db.db("kelly_eric");

 //check if error
  
  if (err) throw err;
  console.log("Database created! by " + Admin);

  // db pointing to kelly_eric
  console.log("Switched to "+dbo.databaseName+" database");

  // create 'users' collection in newdb database
  dbo.createCollection("interns", function(err, result) {
      if (err) throw err;
      console.log("Interns Collection has been created!");
      // close the connection to db when you are done with it
      db.close();
  });

});




 
// make client connect to mongo service
MongoClient.connect(url, function(err, db) {
    if (err) throw err;
    
});