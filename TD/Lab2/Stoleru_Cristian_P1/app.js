var app = new Vue({
    el: '#app',
    data: {
        message: ''
    },
    methods: {
        process: function(){
			var a = 123;
			if(this.message == a){
				
            alert("Mesajul este egal cu :" + this.message);}
			else{
				alert(this.message);
			}
			
        }
    }
})