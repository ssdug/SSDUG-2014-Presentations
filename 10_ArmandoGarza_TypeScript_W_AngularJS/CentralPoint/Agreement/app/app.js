var cp;
(function (cp) {
    var Module = (function () {
        function Module(name, requires) {
            this.app = null;
            this.routesLoaded = false;
            this.routes = [
                {
                    path: "/home",
                    templateUrl: "app/features/dashboard/home.html",
                    defaultRoute: true
                },
                {
                    path: "/project/new",
                    templateUrl: "app/features/newproject/newProject.html"
                },
                {
                    path: "/project/edit",
                    templateUrl: "app/features/editproject/editProject.html"
                }
            ];
            this.app = angular.module(name, requires);
        }
        Module.prototype.init = function () {
            var _this = this;
            var defer = $.Deferred();

            this.app.config([
                "$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {
                    _this.loadRoutes($routeProvider, $locationProvider);
                    defer.resolve();
                }]);

            return defer.promise();
        };

        Module.prototype.addController = function (ctrl) {
            var xfn = function () {
                this.__init = function () {
                    for (var ndx = 0; ndx < ctrl.inject.length; ndx++) {
                        this[ctrl.inject[ndx]] = arguments[ndx];
                    }

                    //determine right binding
                    var dest = this;
                    var scopeIndex = ctrl.inject.indexOf("$scope");
                    if (scopeIndex > -1) {
                        dest = arguments[scopeIndex];
                    }

                    for (var key in ctrl) {
                        if (ctrl.hasOwnProperty(key)) {
                            if (key[0] !== "_" && Module.reserved.indexOf(key) === -1) {
                                dest[key] = ctrl[key];
                            }
                        }
                    }

                    //add watches
                    if (ctrl.watch) {
                        for (key in ctrl.watch) {
                            if (angular.isFunction(ctrl.watch[key])) {
                                dest.$watch(key, ctrl.watch[key]);
                            } else {
                                dest.$watch(key, ctrl[ctrl.watch[key]]);
                            }
                        }
                    }

                    //call init
                    if (ctrl.init) {
                        ctrl.init.apply(this, arguments);
                    }
                };
            };

            var build = [];
            if (ctrl.inject) {
                for (var i = 0; i < ctrl.inject.length; i++) {
                    build.push(ctrl.inject[i]);
                }
            }
            build.push(function () {
                var fn = new xfn();
                fn.__init.apply(fn, arguments);
                return fn;
            });

            this.app.controller(ctrl.name, build);
        };

        Module.prototype.loadRoutes = function (routeProvider, locationProvider) {
            var defaultRoute = Utils.firstOrNull(this.routes, function (item) {
                return item.defaultRoute;
            });
            if (!defaultRoute) {
                defaultRoute = Utils.firstOrNull(this.routes);
            }

            var rp = routeProvider;

            Utils.each(this.routes, function (item) {
                rp = rp.when(item.path, {
                    caseInsensitiveMatch: true,
                    templateUrl: item.templateUrl || null
                });
            });

            rp.otherwise({ redirectTo: defaultRoute.path });
            locationProvider.html5Mode(true);
        };
        Module.reserved = ["name", "inject", "init", "watch"];
        return Module;
    })();
    cp.Module = Module;
})(cp || (cp = {}));

var app = new cp.Module("cp", ["ngRoute"]);

$.when(app.init()).done(function () {
    //alert("loaded");
});
//# sourceMappingURL=app.js.map
