

module Utils {
    /**
     * Creates a deep copy if the source object. Note: only data is copied.
     */
    export function clone<T>(source: T): T {
        var js = angular.toJson(source);
        var result = angular.fromJson(js);
        return result;
    };

    /*
     * Returns true if any object in data caused the callback to return true.
     */
    export function any<T>(data: Array<T>, callback: (item:T) => boolean): boolean {
        if (data && callback) {
            for (var i = 0; i < data.length; i++) {
                if (callback(data[i])) {
                    return true;
                }
            }
        }
        return false;
    };

    /*
     * Returns true if all the items in data cause the callback to only return true.
     */
    export function all<T>(data: Array<T>, callback: (item:T) => boolean) {
        if (data && callback) {
            for (var i = 0; i < data.length; i++) {
                if (!callback(data[i])) {
                    return false;
                }
            }
        }
        return true;
    };

    /*
     * All data items are returned that cause the callback to return true.
     */
    export function where<T>(data: Array<T>, callback: (item: T) => boolean): Array<T> {
        var list: Array<T> = [];
        if (data && callback) {
            for (var i = 0; i < data.length; i++) {
                if (callback(data[i])) {
                    list.push(data[i]);
                }
            }
        }
        return list;
    }

    /*
     * Iterates data items, compiling an array of whatever object the callback returns.
     */
    export function select<T>(data: Array<T>, callback: (item: T) => any): Array<any> {
        var list = [];
        if (data && callback) {
            for (var i = 0; i < data.length; i++) {
                list.push(callback(data[i]));
            }
        }
        return list;
    }

    /*
     * Returns the sum of values passed back from the callback.
     */
    export function sum<T>(data: Array<T>, callback: (item: T) => number): number {
        if (!data || !callback) {
            return 0;
        }

        var result: number = 0;
        for (var i = 0; i < data.length; i++) {
            var value = callback(data[i]);
            if (angular.isNumber(value)) {
                result += value;
            } else {
                throw "Not a number.";
            }
        }
        return result;
    }

    /*
     * Returns the last item in data that causes the callback to return true.
     * If the callback is not provided, then the last item in data is returned.
     */
    export function lastOrNull<T>(data: Array<T>, callback?: (item: T) => boolean): T {
        if (!data) {
            return null;
        }

        if (!callback) {
            if (data.length < 1) {
                return null;
            }
            return data[data.length - 1];
        }

        var list: Array<T> = [];
        for (var i = 0; i < data.length; i++) {
            if (callback(data[i])) {
                list.push(data[i]);
            }
        }

        return data[data.length - 1];
    }

    /*
     * Returns the first item in data that caused the callback to return true.
     * If the callback is missing, then the first item in data is returned.
     */
    export function firstOrNull<T>(data: Array<T>, callback?: (item: T) => boolean): T {
        var result: T = null;

        if (!data) {
            return null;
        }

        if (callback) {
            for (var i = 0; i < data.length; i++) {
                if (callback(data[i])) {
                    result = data[i];
                    break;
                }
            }
        } else {
            if (data.length > 0) {
                result = data[0];
            }
        }
        return result;
    }

    /*
     * each item in data that causes the callback to return true is removed from data.
     */
    export function remove<T>(data: Array<T>, callback: (item: T) => boolean): void {
        if (data) {
            for (var i = data.length - 1; i > 0; i--) {
                if (callback(data[i])) {
                    data.splice(i, 1);
                }
            }
        }
    }

    /*
     * Each item in data is passed to the callback.
     */
    export function each<T>(data: Array<T>, callback: (item: T) => void): void {
        if (!data) {
            return null;
        }
        for (var i = 0; i < data.length; i++) {
            callback(data[i]);
        }
    }

    /*
     * Similar to the .Net String.Format function. 
     * Replaces each '{?}' with the parameter item passed.
     * Example: Utils.format("Hello, {0}.{2}","World","blah") => "Hello, World.blah"
     */
    export function format(formatStr: string): string {
        var args = Array.prototype.slice.call(arguments, 1);
        return formatStr.replace(/{(\d+)}/g, function (match, number) {
            return typeof args[number] != 'undefined'
                ? args[number]
                : match
                ;
        });
    }

}