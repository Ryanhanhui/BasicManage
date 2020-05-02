String.prototype.padLeft =
    Number.prototype.padLeft = function (total, pad) {
        return (Array(total).join(pad || 0) + this).slice(-total);
    }
function getConvertDatePart(datetimestr,splitor) {
    datestr = datetimestr.split(splitor)[0];
    return datestr;
}