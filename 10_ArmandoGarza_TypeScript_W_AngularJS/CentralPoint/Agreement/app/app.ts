
interface IInjectable {
    name: string;
    inject?: Array<string>;
    init? (): any;
    watch?: any;
}

interface IAppRoute {
    path: string;
    template?: string;
    templateUrl?: string;
    defaultRoute?: boolean;
    controller?: string;
    controllerUrl?: string;
}

module cp {

    export class Module {
        private static reserved = ["name", "inject", "init", "watch"];
        private app: ng.IModule = null;
        private routesLoaded: boolean = false;

        constructor(name: string, requires: Array<string>) {
            this.app = angular.module(name, requires);
        }

        init() {
            var defer = $.Deferred();

            this.app.config(["$routeProvider", "$locationProvider", ($routeProvider, $locationProvider) => {
                this.loadRoutes($routeProvider, $locationProvider);
                defer.resolve();
            }]);

            return defer.promise();
        }

        addController(ctrl: IInjectable) {

            var xfn = function () {
                this.__init = function () {

                    //copy arguments
                    for (var ndx: number = 0; ndx < ctrl.inject.length; ndx++) {
                        this[ctrl.inject[ndx]] = arguments[ndx];
                    }

                    //determine right binding 
                    var dest = this;
                    var scopeIndex = ctrl.inject.indexOf("$scope");
                    if (scopeIndex > -1) {
                        dest = arguments[scopeIndex];
                    }

                    //copy props/functions
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
        }

        private loadRoutes(routeProvider, locationProvider): void {

            var defaultRoute = Utils.firstOrNull<IAppRoute>(this.routes, (item) => { return item.defaultRoute; });
            if (!defaultRoute) {
                defaultRoute = Utils.firstOrNull<IAppRoute>(this.routes);
            }

            var rp = routeProvider;

            Utils.each<IAppRoute>(this.routes, (item) => {
                rp = rp.when(item.path, {
                    caseInsensitiveMatch: true,  
                    templateUrl: item.templateUrl || null                    
                });
            });

            rp.otherwise({ redirectTo: defaultRoute.path });
            locationProvider.html5Mode(true);
        }


        private routes: Array<IAppRoute> = [
            { 
                path: "/home",
                templateUrl: "app/features/dashboard/home.html",
                defaultRoute: true,
                
            },
            {
                path: "/project/new",
                templateUrl: "app/features/newproject/newProject.html"
            },
            {
                path: "/project/edit",
                templateUrl: "app/features/editproject/editProject.html",
            }
        ];

    }
}

var app: cp.Module = new cp.Module("cp", ["ngRoute"]);

$.when(app.init()).done(function () {
    //alert("loaded");
});
