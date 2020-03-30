var MongoClient = require('mongodb').MongoClient;
var url = "mongodb://localhost:27017/kelly_eric";
MongoClient.connect(url,{useNewUrlParser: true, useUnifiedTopology: true}, function(err, db) {
  if (err) throw err;
  console.log("Database created!");
  db.close();
});