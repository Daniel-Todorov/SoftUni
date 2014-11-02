function calcCircleArea(r) {
    var area = Math.PI * r * r;

    document.write('r = ' + r + '; area = ' + area);
}

calcCircleArea(7);
document.write('<br />');
calcCircleArea(1.5);
document.write('<br />');
calcCircleArea(20);