function solve(numbers) {
    var firstNumber = +numbers[0],
        secondNumber = +numbers[1],
        thirdNumber = +numbers[2];
    if (firstNumber >= secondNumber) {
        if (firstNumber >= thirdNumber) {
            console.log(firstNumber)
        } else {
            console.log(thirdNumber)
        }
    } else {
        if (secondNumber >= thirdNumber) {
            console.log(secondNumber);
        } else {
            console.log(thirdNumber);
        }
    }
}
