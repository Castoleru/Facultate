var api = require('./api.js').app;
var users = require('./users.json');

api.get('/', function(request, response) {
  response.json("node.js backend");
});

api.get('/users', function(request, response) {
  response.json(users);
});

api.put('/users', function(request, response) {

  if ( request.body.index === -1){
  users[users.length] = { name: request.body.name, city:request.body.city};
  response.json('User was saved succesfully');
  }
  else {
    users[request.body.index] = { name: request.body.name, city:request.body.city};
    response.json('User was updated succesfully');
  }
});


api.delete('/users/:index', function(request, response) {
  console.log(request.params.index);
  users.splice(request.params.index, 1);
  response.json('User with index ' + request.params.index + ' was deleted');
});

api.listen(3002, function(){
  console.log('CORS-enabled web server is listening on port 3002...');
});
