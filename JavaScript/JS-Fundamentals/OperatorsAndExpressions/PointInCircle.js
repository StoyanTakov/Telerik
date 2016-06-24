function CheckPointInCircle(args) {
    var x = +args[0],
        y = +args[1];
    var point = (x * x) + (y * y),
        IsInCircle = point <= (2 * 2),
        distance = Math.sqrt(point);
    if (IsInCircle) {
        console.log('yes ' + distance.toFixed(2));
    } else if (point == 0) {
        return console.log('0');
    } else {
        return console.log('no ' + distance.toFixed(2));
    }
}
