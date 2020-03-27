function users() {

    get = function() {
        return axios.get("http://localhost:3002/users");
    };

    remove = function(i) {
        return axios.delete("http://localhost:3002/users/{id}",{params:{'id':i}});
    };

    return {
        get: get
    }
}
