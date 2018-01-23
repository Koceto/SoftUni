// Write a JS function that can receive a name as input and print a greeting to the console.
// The input comes as a single string that is the name of the person.
// The output should be printed to the console.

function greet(name){
    return `Hello, ${name}, I am JavaScript!`;
}

// Write a JS function that calculates the area and perimeter of a rectangle by given two sides.
// The input comes as 2 numbers that are the lengths of the 2 sides of the rectangle (sideA and sideB)
// The output should be printed to the console on two lines.

function calculateAreaAndPerimeter(a, b){
    return `${a * b}\n${2 * (a + b)}`;
}

// Two objects start from point A and travel in the same direction at constant speeds V1 and V2 for a period T.
// Write a JS function that calculates the distance between the two object at the end of the period.
// The input comes as array of numbers.
// The first two elements are the speeds to the two objects in km/h and the third element is the time in seconds.
// The output should be printed to the console. Calculate the distance in meters.

function calculateObjectDistance(arr){
    let firstObject = { speed: arr[0] };
    let secondObject = { speed: arr[1] };
    let timeInHours = arr[2] / 60 / 60;

    return Math.abs(firstObject.speed * timeInHours - secondObject.speed * timeInHours) * 1000;
}

// Write a JS function that calculates the distance between the two points in 3D by given coordinates.
// The input comes as an array of numbers. The first three elements are the x, y and z coordinates for the first point and
// the second set of arguments are the coordinates of the other point.
// The output should be printed to the console.
// d = ((x2 - x1)2 + (y2 - y1)2 + (z2 - z1)2)1/2

function calculateDistanceIn3D(arr){
    let firstObject = { X: arr[0], Y: arr[1], Z: arr[2] };
    let secondObject = { X: arr[3], Y: arr[4], Z: arr[5] };

    return Math.pow(
        Math.pow(secondObject.X - firstObject.X, 2) +
        Math.pow(secondObject.Y - firstObject.Y, 2) +
        Math.pow(secondObject.Z - firstObject.Z, 2), 1/2);
}

// Land surveyors use grads (also known as gon, 400 grads in a full turn) in their documents.
// Grads are rather unwieldy though, so you need to write a JS function that converts from grads to degrees.
// In addition, your program needs to constrain the results within the range 0° ≤ x < 360°,
// so if you arrive at a value like -15°, it needs to be converted to 345° and 420° becomes 60°.
// The input comes as single number.
// The output should be printed to the console.

function gradsToDegrees(grad){
    let result = (grad * 0.9) % 360;

    return result < 0 ? 360 + result : result;
}

// Write a JS function that calculates the total accumulated value for a monetary deposit
// by given principal sum, interest rate, compounding frequency and overall length.
// The input comes as an array of numbers. The first value is the principal sum, the second is the interest rate in percent,
// the third is the compounding period in months and the final value is the total timespan, given in years.
// The output should be printed to the console, with two decimal places.

function calculateDeposit(arr){
    let balance = arr[0];
    let interestRate = arr[1];
    let frequencyInMonths = arr[2];
    let timeInYears = arr[3];
    let compoundFrequency = 12 * 1.0 / frequencyInMonths;

    let result = balance * Math.pow(1 + (interestRate / 100) / compoundFrequency,
        compoundFrequency * timeInYears);

    return result.toFixed(2);
}

// Write a JS function that rounds numbers to specific precision.
// The input comes as an array of two numbers.
// The first value is the number to be rounded and the second is the precision (significant decimal places).
// If a precision is passed, that is more than 15 it should automatically be reduced to 15.
// The output should be printed to the console. Do not print insignificant decimals.

function roundNumbers(arr){
    let number = arr[0];
    let precision = arr[1] > 15 ? 15 : arr[1];

    return +number.toFixed(precision);
}

// Imperial units are confusing, but still in use in some backwards countries.
// They are so confusing in fact, that native users struggle to convert between them.
// Write a JS function that converts from inches to feet and inches. There are 12 inches in a foot. See the example for formatting details.
// The input comes as a single number.
// The output should be printed to the console.

function convertInchesToFeet(inches){
    const inchesInOneFoot = 12;
    let feet = Math.floor(inches / inchesInOneFoot);
    let leftOverInches = inches % inchesInOneFoot;

    return `${feet}'-${leftOverInches}"`;
}

// Write a JS function that displays information about the currently playing musical track.
// The input comes as an array of string elements.
// The first element is the name of the track, the second is the name of the artist performing
// and the third is the duration in minutes and seconds.
// The output should be printed to the console in the following format:
// Now Playing: {artist name} - {track name} [{duration}]

function displaySongInfo(arr){
    let songName = arr[0];
    let author = arr[1];
    let duration = arr[2];

    return `Now Playing: ${author} - ${songName} [${duration}]`;
}

// Write a JS function that composes an HTML image tag.
// The input comes as an array of string elements. The first element is the location of the file and the second is the alternate text.
// The output should be printed to the console in the following format:
// <img src="{file location}" alt="{alternate text}">

function composeImageTag(arr){
    let imageLocation = arr[0];
    let text = arr[1];

    return `<img src="${imageLocation}" alt="${text}">`;
}

// Write a JS function that reads an 8-bit binary number and converts it to a decimal.
// The input comes as one string element, representing a binary number.
// The output should be printed to the console.

function convertBinaryToDec(binary){
    return parseInt(binary, 2)
}

// Write a JS function that composes an object by given properties.
// There will be 3 sets of property-value pairs (a total of 6 elements).
// Assign each value to its respective property of an object and return the object as a result of the function.
// The input comes as an array of string elements.
// The output should be returned as a value.

function assignProperties(arr){
    let object = {
        [arr[0]]: arr[1],
        [arr[2]]: arr[3],
        [arr[4]]: arr[5]
    };

    return object;
}

// Write a JS function that receives a date as array of strings containing day, month and year in that order.
// Your task is to print the last day of previous month (the month BEFORE the given date).
// Check the examples to better understand the problem.
// The input comes as an array of numbers.
// The output should be a single number representing the last day of the previous month.

function getLastDayOfMonth(arr){
    let month = arr[1];
    let year = arr[2];
    let date = new Date(`${month} ${1} ${year}`);
    
    date.setDate(date.getDate() - 1);
    return date.getDate();
}

// Write a JS function that finds the biggest of 3 numbers.
// The input comes as array of 3 numbers.
// The output is the biggest from the input numbers.

function getBiggest(arr){
    let biggest = arr[0];

    for (const number of arr) {
        if (number > biggest) {
            biggest = number;
        }
    }

    return biggest;
}

// Write a JS function that takes as input 6 numbers x, y, xMin, xMax, yMin, yMax and prints whether the point {x, y} is inside the rectangle
// or outside of it. If the point is at the rectangle border, it is considered inside.
// The input comes as array of numbers. Its holds the representations of x, y, xMin, xMax, yMin, yMax.
// All numbers will in the range [-1 000 000 … 1 000 000]. It is guaranteed that xMin < xMax and yMin < yMax.
// The output is a single line holding “inside” or “outside”.

function isPointInRectangle(arr){
    let point = { X: arr[0], Y: arr[1] };
    let rectangle = { xMin: arr[2], xMax: arr[3], yMin: arr[4], yMax: arr[5] };

    if (point.X <= rectangle.xMax == point.X >= rectangle.xMin &&
        point.Y <= rectangle.yMax == point.Y >= rectangle.yMin) {
        return 'inside';
    }
    return 'outside';
}

// Write a JS function that reads an integer n and prints all odd numbers from 1 to n.
// The input comes as a single number n. The number n will be an integer in the range [1 … 100 000].
// The output should hold the expected odd numbers, each at a separate line.

function printOdd(n){
    let result = '';

    for (let index = 1; index <= n; index++) {
        if (index % 2 != 0) {
            result += index + '\n';
        }
    }

    return result;
}

// Write a JS function that prints a triangle of n lines of “$” characters like shown in the examples.
// The input comes as a single number n (0 < n < 100).
// The output consists of n text lines like shown below.

function printTriangle(n){
    let result = '';

    for (let index = 1; index <= n; index++) {
        result += '$'.repeat(index) + '\n';      
    }

    return result;
}

// Movie ticket prices in a big retro-cinema depend on the movie title and on the day of week as shown below: 
// Movie Title	        Monday	Tuesday     Wednesday   Thursday	Friday	Saturday	Sunday
// The Godfather	    12  	10	        15	        12.50	    15	    25	        30
// Schindler's List 	8.50	8.50    	8.50	    8.50	    8.50	15	        15
// Casablanca	        8	    8           8	        8	        8	    10          10
// The Wizard of Oz 	10	    10      	10          10	        10	    15          15
// Write a JS function that calculate the ticket price by movie title and day of week.
// The input comes as array of 2 strings. The first string holds the movie title. The second string holds the day of week.
// The output should hold the ticket price or “error” if the title or day of week is invalid.

function calculateMoviePrice(arr){
    let movie = arr[0].toLowerCase();
    let dayOfWeek = arr[1].toLowerCase();
    let priceList = {
        ['the godfather']: {
            monday: 12,
            tuesday: 10,
            wednesday: 15,
            thursday: 12.50,
            friday: 15,
            saturday: 25,
            sunday: 30,
         },
        ['schindler\'s list']: {
            monday: 8.50,
            tuesday: 8.50,
            wednesday: 8.50,
            thursday: 8.50,
            friday: 8.50,
            saturday: 15,
            sunday: 15,
        },
        ['casablanca']: {
            monday: 8,
            tuesday: 8,
            wednesday: 8,
            thursday: 8,
            friday: 8,
            saturday: 10,
            sunday: 10,
        },
        ['the wizard of oz']: {
            monday: 10,
            tuesday: 10,
            wednesday: 10,
            thursday: 10,
            friday: 10,
            saturday: 15,
            sunday: 15,
        }
    };

    let price = priceList[movie][dayOfWeek];

    return price == undefined ? 'error' : price;
}

// Write a JS function to solve a quadratic equation by given in standard form as its coefficients: a, b, c.
// You may learn more about quadratic equations here: https://www.mathsisfun.com/algebra/quadratic-equation.html.
// The input comes as 3 numbers a, b and c. The value of a will be non-zero.
// The output depends on the equation:
// •	It holds two numbers x1 and x2 if the equation has two different solutions (roots): x1 and x2.
// o	First print the smaller root, then the greater.
// •	It holds a single number x if the equation has only one solution (root): x.
// •	It holds the text “No” if the equation has no solutions (no real roots).

function solveEquation(a, b, c){
    let result = '';
    let discriminant = Math.pow(b, 2) - 4 * a * c;

    if (discriminant > 0) { // The equation has two answers
        let firstAnswer = (-b + Math.sqrt(discriminant)) / (2 * a);
        let secondAnswer = (-b - Math.sqrt(discriminant)) / (2 * a);

        result = firstAnswer < secondAnswer ? `${firstAnswer}\n${secondAnswer}` : `${secondAnswer}\n${firstAnswer}`
    }
    else if (discriminant == 0) { // The equation has a single answer
        result = -b / (2 * a);
    }
    else { // the equation has not answers
        result = 'No';
    }
    return result;
}

// Write a JS function to print a math multiplication table of size n, formatted as HTML table.
// The input comes as a single number n (0 < n < 100).
// The output consists of n+3 text lines.

function printMathMultiplicationtable(n){
    let table = '<table border="1">\n';

    table += '<tr><th>x</th>';
    for (let index = 1; index <= n; index++) {
        table += `<th>${index}</th>`;
    }
    table += '</tr>\n'

    for (let row = 1; row <= n; row++) {
        table += '<tr>';
        for (let index = 0; index <= n; index++) {

            if (index == 0) {
                table += `<th>${row}</th>`;
            }
            else {
                table += `<td>${row * index}</td>`;
            }
        }
        table += '</tr>\n';       
    }
    table += '</table>';

    return table;
}

// Write a JS function to print a figure of 4 squares of size n.
// The input is an integer number n in the range [2 … 200].
// The output consists of n lines for odd n and n-1 lines for even n.
// Each line holds 2*n-1 characters (+ or | or space) as shown in the examples.
// The figure is fully symmetric (horizontally and vertically).

function drawSquare(n){
    let height = n % 2 != 0 ? n : n - 1;
    let result = '';

    function printSingleLineUsing(symbolA, symbolB){
        let middle = symbolB.repeat(n - 2);

        return `${symbolA}${middle}${symbolA}${middle}${symbolA}\n`;
    }

    for (let index = 1; index <= height; index++) {
        if (index == 1 ||
            index == height ||
            index == Math.ceil(height / 2)) {
            result += printSingleLineUsing('+', '-');
        }
        else {
            result += printSingleLineUsing('|', ' ');
        }
    }

    return result;
}