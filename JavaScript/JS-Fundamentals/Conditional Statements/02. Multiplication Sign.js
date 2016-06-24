function solve(numbers) {
    var firstNumber = +numbers[0],
        secondNumber = +numbers[1],
        thirdNumber = +numbers[2];
    if (numbers[0] === 0 || numbers[1] === 0 || numbers[2] === 0) {
        console.log("0");
    } else if (numbers[0] < 0) {
        if (numbers[1] < 0) {
            if (numbers[2] < 0) {
                console.log("-")
            } else {
                console.log("+")
            }
        } else if (numbers[1] > 0) {
            if (numbers[2] > 0) {
                console.log("-")
            } else {
                console.log("+")
            }
        } else if (numbers[0] > 0) {
            if (numbers[1] < 0) {
                if (numbers[2] < 0) {
                    console.log("+")
                } else {
                    console.log("-")
                }
            } else if (numbers[1] > 0) {
                if (numbers[2] > 0) {
                    console.log("+")
                } else {
                    console.log("-")
                }
            }
        }
    }
}
