function ThirdBit(number) {
    var position = 3,
        mask = 1 << position,
        nAndMask = mask & number,
        bit = nAndMask >> position;
    console.log(bit);

}
