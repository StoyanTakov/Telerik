function solve(numbers){
  var a = +numbers[0],
      b = +numbers[1],
      c;
  if (a>b) {
    c=a;
    a=b;
    b=c;
    console.log(a+" "+b);
  }else {
    console.log(a+" "+b);
  }
}
