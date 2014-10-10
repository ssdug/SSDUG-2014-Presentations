var Utils;
(function (Utils) {
    /**
    * Creates a deep copy if the source object. Note: only data is copied.
    */
    function clone(source) {
        var js = angular.toJson(source);
        var result = angular.fromJson(js);
        return result;
    }
    Utils.clone = clone;
    ;

    /*
    * Returns true if any object in data caused the callback to return true.
    */
    function any(data, callback) {
        if (data && callback) {
            for (var i = 0; i < data.length; i++) {
                if (callback(data[i])) {
                    return true;
                }
            }
        }
        return false;
    }
    Utils.any = any;
    ;

    /*
    * Returns true if all the items in data cause the callback to only return true.
    */
    function all(data, callback) {
        if (data && callback) {
            for (var i = 0; i < data.length; i++) {
                if (!callback(data[i])) {
                    return false;
                }
            }
        }
        return true;
    }
    Utils.all = all;
    ;

    /*
    * All data items are returned that cause the callback to return true.
    */
    function where(data, callback) {
        var list = [];
        if (data && callback) {
            for (var i = 0; i < data.length; i++) {
                if (callback(data[i])) {
                    list.push(data[i]);
                }
            }
        }
        return list;
    }
    Utils.where = where;

    /*
    * Iterates data items, compiling an array of whatever object the callback returns.
    */
    function select(data, callback) {
        var list = [];
        if (data && callback) {
            for (var i = 0; i < data.length; i++) {
                list.push(callback(data[i]));
            }
        }
        return list;
    }
    Utils.select = select;

    /*
    * Returns the sum of values passed back from the callback.
    */
    function sum(data, callback) {
        if (!data || !callback) {
            return 0;
        }

        var result = 0;
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
    Utils.sum = sum;

    /*
    * Returns the last item in data that causes the callback to return true.
    * If the callback is not provided, then the last item in data is returned.
    */
    function lastOrNull(data, callback) {
        if (!data) {
            return null;
        }

        if (!callback) {
            if (data.length < 1) {
                return null;
            }
            return data[data.length - 1];
        }

        var list = [];
        for (var i = 0; i < data.length; i++) {
            if (callback(data[i])) {
                list.push(data[i]);
            }
        }

        return data[data.length - 1];
    }
    Utils.lastOrNull = lastOrNull;

    /*
    * Returns the first item in data that caused the callback to return true.
    * If the callback is missing, then the first item in data is returned.
    */
    function firstOrNull(data, callback) {
        var result = null;

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
    Utils.firstOrNull = firstOrNull;

    /*
    * each item in data that causes the callback to return true is removed from data.
    */
    function remove(data, callback) {
        if (data) {
            for (var i = data.length - 1; i > 0; i--) {
                if (callback(data[i])) {
                    data.splice(i, 1);
                }
            }
        }
    }
    Utils.remove = remove;

    /*
    * Each item in data is passed to the callback.
    */
    function each(data, callback) {
        if (!data) {
            return null;
        }
        for (var i = 0; i < data.length; i++) {
            callback(data[i]);
        }
    }
    Utils.each = each;

    /*
    * Similar to the .Net String.Format function.
    * Replaces each '{?}' with the parameter item passed.
    * Example: Utils.format("Hello, {0}.{2}","World","blah") => "Hello, World.blah"
    */
    function format(formatStr) {
        var args = Array.prototype.slice.call(arguments, 1);
        return formatStr.replace(/{(\d+)}/g, function (match, number) {
            return typeof args[number] != 'undefined' ? args[number] : match;
        });
    }
    Utils.format = format;
})(Utils || (Utils = {}));
//# sourceMappingURL=utils.js.map
