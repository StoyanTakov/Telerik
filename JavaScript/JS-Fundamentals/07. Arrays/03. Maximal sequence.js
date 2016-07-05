function solve(args) {
    var array = (args + "").split('\n').map(Number),
        counter = 1,
        max = 0,
        prev = +args[0];

    for (var i = 1; i < array.length; i++) {
        if (array[i] === prev) {
            counter += 1;
        } else {
            if (counter > max) {
                max = counter;
            }
            counter = 1;
        }
        prev = array[i];
    }
    if (counter > max) {
        max = counter;
    }
    console.log(max);
}
