
jQuery.validator.addMethod("dategreaterthan", function (value, element, startdate) {
    return Date.parse(value) > Date.parse($(startdate).val());
});

jQuery.validator.unobtrusive.adapters.add("dategreaterthan", ["startdate"], function (options) {
    options.rules["dategreaterthan"] = "#" + options.params.startdate;
    options.messages["dategreaterthan"] = options.message;
});


    jQuery.validator.addMethod('validbirthdate', function (value, element) {
        var currentDate = new Date();
        if (Date.parse(value) > currentDate) {
            return false;
        }
        return true;
    }, '');

    jQuery.validator.unobtrusive.adapters.add('validbirthdate', function (options) {
        options.rules['validbirthdate'] = {};
        options.messages['validbirthdate'] = options.message;
    });

