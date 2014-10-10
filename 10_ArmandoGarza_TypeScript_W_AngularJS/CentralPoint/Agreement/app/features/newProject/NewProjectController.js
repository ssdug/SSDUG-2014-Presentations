app.addController({
    name: "NewProjectController",
    inject: ["$scope"],
    init: function () {
        this.$scope.projectName = "Developer";
    },
    watch: {
        projectName: function (newValue, oldValue) {
            console.info(oldValue + " -> " + newValue);
        }
    },
    projectName: "",
    //Controller actions
    click: function () {
        alert("hello!");
    }
});
//# sourceMappingURL=NewProjectController.js.map
