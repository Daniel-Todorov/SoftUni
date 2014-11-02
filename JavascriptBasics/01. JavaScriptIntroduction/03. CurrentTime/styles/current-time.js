//Write a JavaScript program current-time.js that prints on the console the current time in format hours:minutes. 
//The hours should be printed without leading zeroes. 
//The minutes should be printed as two-digit number with a leading zero when needed. 

var currentTime = new Date(),
    hour = currentTime.getHours(),
    minutes = currentTime.getMinutes();

if (minutes < 10) {
    minutes = '0' + minutes.toString();
}

console.log(hour + ':' + minutes);