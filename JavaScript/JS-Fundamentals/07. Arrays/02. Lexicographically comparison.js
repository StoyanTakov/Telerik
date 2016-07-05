function solve(args) {
    var arrayA = (args[0] + "").split('\n'),
        arrayB = (args[1] + "").split('\n'),
        found = false,
        len = 0;
    if (arrayA.length >= arrayB.length) {
        len = arrayB.length;
    } else {
        len = arrayA.length;
    }

    for (var index = 0; index < len; index += 1) {
        if (arrayA[index] < arrayB[index]) {
            console.log('<');
            found = true;
            break;
        } else if (arrayA[index] > arrayB[index]) {
            console.log('>');
            found = true;
            break;
        }
    }

    if (!found) {
        if (arrayA.length > arrayB.length) {
            console.log('>');
        } else if (arrayA.length === arrayB.length) {
            console.log('=');
        } else {
            console.log('<');
        }
    }
}
