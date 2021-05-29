
var vm = new Vue({
    el: "#layout",
    methods: {
        cambiarClase: function () {
            var botones = document.querySelectorAll(".container button");
            console.log("botones");
        }
    }
})