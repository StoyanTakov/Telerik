function solve(args) {
    var lines = (args[0] + '')
        .split('\n'),
        numbers = lines[1]
        .split(' ')
        .map(Number)
        .filter(function(a) {
            return +a === +lines[2];
        }).length;
    console.log(numbers);
}
