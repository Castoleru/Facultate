var app = new Vue({
    el: '#app',
    data: {
        users: [],
        usersService: null,
        name:'',
        city:'',
        index:-1
    },
    created: function () {
        usersService = users();
        usersService.get().then(response => (this.users = response.data));
    },
    methods: {
        add: function(Name,City,Index){
              console.log(Index);
                return axios.put("http://localhost:3002/users",
              {
                name: Name,
                city: City,
                index: Index
              })
        },
        removeUser: function(index)
        {
          //console.log("http://localhost:3002/users/"+(index));
          return axios.delete("http://localhost:3002/users/"+(index));
        }
    }



})
