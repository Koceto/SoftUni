// Write a JS function that takes three numbers as input and outputs their sum.
// The input comes as three number arguments passed to your function.
// The output should be printed to the console.

function sum(a, b, c){
    return a + b + c;
}

// Write a JS function that sums a variable number of prices and calculates their VAT (Value Add Tax, 20%).
// The input comes as an array of numbers. The number of elements will be different every time.
// The output should be printed to the console on a new line for every entry.

function sum(array){
    let sum = array.reduce((a, b) => a + b);
    let vat = sum * 0.20;
    let total = sum + vat;

    console.log('sum = ' + sum);
    console.log('vat = ' + vat);
    console.log('total = ' + total);
}

// Write a JS function that counts how many times a specific letter occurs in a given string.
// The input comes two string arguments. The first element is the string to check and the second element is the letter to count.
// The output should be returned as a result of your function.

function findOccurrences(string, char){
    let occurrences = 0;

    for (let index = 0; index < string.length; index++) {
        let element = string[index];
        
        if (element === char) {
            occurrences++;
        }
    }

    return occurrences;
}

// Write a JS function that stores the name and age of two persons in objects and then filters them by minimum age.
// The input comes as five arguments. The first element is the minimum age.
// The second and third elements are the name and age of the first person and the fourth and fifth elements – the name and age of the second person. The three age parameters will be numbers, the names will be strings.
// The output should be printed to the console.

function filterByAge(ageFilter, firstName, firstAge, secondName, secondAge){
    let people = [
        { name: firstName, age: firstAge },
        { name: secondName, age: secondAge }
    ];

    for (let person of people) {
        if (person.age >= ageFilter) {
            console.log(person);
        }
    }
}

// Write a JS function that read a number n as input and prints all numbers from 1 to n, concatenated as a single string.
// The input comes as one string element that needs to be parsed as a number.
// The output should be returned as a result of your function.

function printNumbers(number){
    let result = '';

    for (let index = 1; index <= number; index++) {
             result = "" + result + index;   
    }

    return result;
}

// Write a JS function that calculates the area of the figure on the right by given values for w, h, W and H.
// The lower right corner is always common for the two rectangles.
// The input comes as four number parameters w, h, W and H.
// The output should be returned as a result of your function.

function findArea(firstWidth, firstHeight, secondWidth, secondHeight){
    let squares = [
        {width: firstWidth, height: firstHeight},
        {width: secondWidth, height: secondHeight}
    ]

    function calculateArea(width, height){
        return width * height;
    }

    let totalArea = calculateArea(squares[0].width, squares[0].height) + calculateArea(squares[1].width, squares[1].height);
    let overflowArea = calculateArea(Math.min(squares[0].width, squares[1].width), Math.min((squares[0].height), squares[1].height));

    return totalArea - overflowArea;
}

// Write a JS function that calculates the date of the next day by given year, month and day.
// The input comes as three number parameters. The first element is the year, the second is the month and the third is the day.
// The output should be returned as a result of your function.

function calculateNextDay(year, month, day){
    let date = new Date(year, month - 1, day);
    date.setDate(date.getDate() + 1);

    return date.getFullYear() + '-' + (date.getMonth() + 1) + '-' + date.getDate();
}

// Write a JS function that calculates the distance between two points by given x and y coordinates. Use objects to store the two points.
// The input comes as four number elements in the format x1, y1, x2, y2. Each pair of elements are the coordinates of a point in 2D space.
// The output should be returned as a result of your function.

function lengthOfSection(firstX, firstY, secondX, secondY){
    return Math.sqrt(Math.pow(secondX - firstX, 2) + Math.pow(secondY - firstY, 2));
}