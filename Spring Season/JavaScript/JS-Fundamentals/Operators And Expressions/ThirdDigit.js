function CheckThirdDigit(number) {
    var digit = (number / 100) % 10 | 0,
        check = digit == 7;
    console.log(check == true? "true" : "false " + digit);

}
