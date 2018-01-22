// Write a JS function that calculates the product of two numbers.
// The input comes as two number arguments.
// The output should be the returned as a result of your function.

function multiply(a, b){
    return a * b;
}

// Write a JS function to calculate how many boxes will be needed to fit n bottles if each box fits k bottles.
// The input comes as two number arguments. The first element is the number of bottles and the second is the capacity of a single box.
// The output should be printed to the console.

function bottlesInBoxes(bottles, boxSize){
    let totalBoxes = Math.ceil(bottles / boxSize);

    return totalBoxes;
}

// Write a JS function to check whether a year is leap. Leap years are either divisible by 4 but not by 100 or are divisible by 400.
// The input comes as a single number argument.
// The output should be printed to the console. Print yes if the year is leap and no otherwise.

function checkLeapYear(year){
    if (year % 400 == 0 || 
        year % 4 == 0 && 
        year % 100 != 0) {            
        return 'yes';
    }
    return 'no';
}

// Write a JS function that calculates circle area by given radius.
// Print the area as it is calculated and then print it rounded to two decimal places.
// The input comes as a single number argument.
// The output should be printed to the console on a new line for each result.

function calculateAreaOfCircle(r){
    let area = Math.PI * (r * r);

    return area + '\n' + area.toFixed(2);
}

// Write a JS function that calculates a triangle’s area by its 3 sides.
// The input comes as three number arguments, representing one side of a triangle.
// The output should be printed to the console.

function calculateAreaOfTriangle(a, b, c){
    let s = (a + b + c) / 2;
    
    return Math.sqrt(s * (s - a) * (s - b) * (s - c));
}

// Write a JS function to calculate a cone’s volume and surface area by given height and radius at the base.
// The input comes as two number arguments. The first element is the cone’s radius and the second is its height.
// The output should be printed to the console on a new line for every result.
// Volume of a cone:
// V = (1/3)πr2h
// Total surface area of a cone:
// A = πr(r + √(r2 + h2))

function calculateAreaAndVolumeOfCone(r, h){
    let volume = (1/3)*(Math.PI * Math.pow(r, 2) * h)
    let area = Math.PI * r * (r + Math.sqrt(r * r + h * h));

    return 'volume = ' + volume.toFixed(4) + '\n' + 'area = ' + area.toFixed(4) ;
}

// Write a JS function to check if a number is odd or even or invalid (fractions are neither odd nor even).
// The input comes as a single number argument.
// The output should be printed to the console.
// Print odd for odd numbers, even for even number and invalid for numbers that contain decimal fractions.

function EvenOrOddChecker(number){
    if (number % 1 != 0) {
        return 'invalid';
    }
    return number % 2 == 0 ? 'even' : 'odd';
}

// Write a JS function to print "fruit", "vegetable" or "unknown" depending on the input string.
// •	Fruits are: banana, apple, kiwi, cherry, lemon, grapes, peach
// •	Vegetable are: tomato, cucumber, pepper, onion, garlic, parsley
// •	All others are unknown
// The input comes as a single string argument, the name of the fruit.
// The output should be printed to the console.

function fruitOrVegetable(item){
    let fruits = [ 'banana', 'apple', 'kiwi', 'cherry', 'lemon', 'grapes', 'peach' ];
    let vegetables = [ 'tomato', 'cucumber', 'pepper', 'onion', 'garlic', 'parsley' ];

    return fruits.indexOf(item) >= 0 ? 'fruit' : vegetables.indexOf(item) >= 0 ? 'vegetable' : 'unknown';
}

// Write a JS function to print the numbers from 1 to n.
// Return a string holding HTML list with the odd lines in blue and even lines in green. See the example for more information.
// The input comes as a single number argument n.
// The output should be returned as a result of your function in the form of a string.

function printNumbersInColour(n){
    let result = '<ul>\n';

    for (let index = 1; index <= n; index++) {   
        let colour = 'green';

        if (index % 2 == 0) {
            colour = 'blue';
        }
        result += `\t<li><span style=\'color:${colour}>${index}</span></li>\n`;
    }

    result += '</ul>'
    return result;
}

// Write a JS function to print a chessboard of size n X n. See the example for more information.
// The input comes as a single number argument n.
// The output should be returned as a result of your function in the form of a string.

function printChessBoard(size){
    let board = '<div class="chessboard">\n';
    let colour = '';

    for (let index = 0; index < size; index++) {
        board += '\t<div>\n';

        for (let innerIndex = 0; innerIndex < size; innerIndex++) {
            colour = (index + innerIndex) % 2 == 0 ? 'black' : 'white';
            board += `\t<span class="${colour}"></span>\n`;                  
        }

        board += '\t</div>\n';
    }

    board += '</div>';    
    return board;
}


// Write a JS function that prints the binary logarithm (log2 x) for each number in the input.
// The input comes as an array of number elements.
// The output should be printed to the console, on a new line for each number.

function printBinaryLog(numbers){
    let result = '';

    for (let number of numbers) {
        result += Math.log2(number) + '\n';
    }

    return result;
}

// Write a JS function to check if a number is prime (only wholly divisible by itself and one).
// The input comes as a single number argument.
// The output should be the return value of your function. Return true for prime number and false otherwise.

function primeCheck(number){
    if (number < 2) {
        return false;
    }

    for (let index = 2; index < number; index++) {
        if (number % index == 0) {
            return false;
        }
    }

    return true;
}