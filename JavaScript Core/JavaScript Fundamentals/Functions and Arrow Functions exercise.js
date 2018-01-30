// Write a JS function that determines whether a point is inside the volume, defined by the box, shown on the right.
// The input comes as an array of numbers. Each set of 3 elements are the x, y and z coordinates of a point.
// The output should be printed to the console on a new line for each point.
// Print inside if the point lies inside the volume and outisde otherwise.

function inVolume(arr){
    let cube = { x1: 10, y1: 20, z1: 15, x2: 50, y2: 80, z2: 50 }
    let result = '';

    function checkCoordinates(x, y , z){
        if (x >= cube.x1 === x <= cube.x2 &&
            y >= cube.y1 === y <= cube.y2 &&
            z >= cube.z1 === z <= cube.z2) {
            return true;
        }
        return false;
    }

    for (let index = 0; index < arr.length; index += 3) {
        if (checkCoordinates(arr[index],
                            arr[index + 1],
                            arr[index + 2])) {
            result += 'inside\r\n';
        } else {
            result += 'outside\r\n';
        }
    }
    return result;
}

// Write a JS function that determines whether a driver is within the speed limit.
// You will receive his speed and the area where he’s driving.
// Each area has a different limit: on the motorway the limit is 130 km/h, on the interstate the limit is 90,
// inside a city the limit is 50 and within a residential area the limit is 20 km/h. If the driver is within the limits,
// your function prints nothing. If he’s over the limit however, your function prints the severity of the infraction.
// For speeds up to 20 km/h over the limit, he’s speeding; for speeds up to 40 over the limit,
// the infraction is excessive speeding and for anything else, reckless driving.
// The input comes as an array of elements. The first element is the current speed (as number),
// the second element is the area where the vehicle is driving.
// The output should be printed to the console. Note in certain cases there will be no output.

function speedCamera(args){
    let speedLimit = {
        motorway: 130,
        interstate: 90,
        city: 50,
        residential: 20
    }
    let speed = args[0];
    let location = args[1];

    let speedOverTheLimit = speed - speedLimit[location];

    if (speedOverTheLimit <= 0) {
        return;
    } else if (speedOverTheLimit <= 20) {
        return 'speeding';
    } else if (speedOverTheLimit <= 40) {
        return 'excessive speeding';
    } else if (speedOverTheLimit > 40 ) {
        return 'reckless driving';
    }
}

// Write a JS program that receives data about a quiz and prints it formatted as an XML document.
// The data comes as pairs of question-answer entries.

function applyXMLTemplateForQuiz(args){
    const newLine = '\r\n';
    let result = '<?xml version="1.0" encoding="UTF-8"?>' + newLine;
    
    function converQuestion(question, answer){
        return `  <question>${newLine}    ${question}${newLine}  </question>${newLine}  <answer>${newLine}    ${answer}${newLine}  </answer>`;
    }

    result += '<quiz>' + newLine;

    for (let index = 0; index < args.length; index += 2) {
        result += `${converQuestion(args[index], args[index + 1])}${newLine}`;
    }

    result += '</quiz>' + newLine;
    
    return result;
}

// Write a JS program that receives a number and a list of five operations.
// Perform the operations in sequence,
// start with the input number and using the result of every operation as starting point for the next.
// Print the result of every operation in order. The operations can be one of the following:
// •	chop – divide the number by two
// •	dice – square root of number
// •	spice – add 1 to number
// •	bake – multiply number by 3
// •	fillet – subtract 20% from number
// The input comes as an array of 6 string elements. The first element is your starting point and must be parsed to a number.
// The remaining 5 elements are the names of operations to be performed.
// The output should be printed on the console.

function numberOperator(arr){
    let operations = {
        chop: a => a / 2,
        dice: a => Math.sqrt(a),
        spice: a => a + 1,
        bake: a => a * 3,
        fillet: a => a * 0.80
    }
    let number = arr[0];
    let result = '';
    
    for (let index = 1; index < arr.length; index++) {
        const operation = arr[index];

        number = operations[operation](number);
        result += number + '\r\n';
    }

    return result;
}

// Write a JS program that modifies a number until the average value of all of its digits is higher than 5.
// In order to modify the number, your program should append a 9 to the end of the number,
// when the average value of all of its digits is higher than 5 the program should stop appending.
// If the number’s average value of all of its digits is already higher than 5, no appending should be done.
// The input is a single number.
// The output should consist of a single number - the final modified number which has an average value of all of its digits higher than 5.
// The output should be printed on the console.

function modifyAverage(number){
    function checkAverage(a){
        let numberString = a.toString().split('');
        let numberSum = numberString.map(Number).reduce((a, b) => a + b);

        return numberSum / numberString.length;
    }
    
    while (checkAverage(number) <= 5) {
        number += 9 + '';
    }

    return number;
}

// Write a JS program that receives two points in the format [x1, y1, x2, y2] and checks
// if the distances between each point and the start of the cartesian coordinate system (0, 0) and between the points themselves is valid.
// A distance between two points is considered valid, if it is an integer value.
// In case a distance is valid write "{x1, y1} to {x2, y2} is valid", in case the distance is invalid write "{x1, y1} to {x2, y2} is invalid". 
// The order of comparisons should always be first {x1, y1} to {0, 0}, then {x2, y2} to {0, 0} and finally {x1, y1} to {x2, y2}. 
// The input consists of two points given as an array of numbers.
// For each comparison print on the output either "{x1, y1} to {x2, y2} is valid" if the distance between them is valid,
// or "{x1, y1} to {x2, y2} is invalid"- if it’s invalid.

function validateDistance(arr){
    let firstPoint = {
        x: arr[0],
        y: arr[1]
    }
    let secondPoint = {
        x: arr[2],
        y: arr[3]
    }
    let startPoint = {
        x: 0,
        y: 0
    }

    function getDistanceBetweenPoints(firstPoint, secondPoint){
        return Math.sqrt(Math.pow(secondPoint.x - firstPoint.x, 2) + Math.pow(secondPoint.y - firstPoint.y, 2));
    }

    function getResultString(firstResultPoint, secondResultPoint){
        return `{${firstResultPoint.x}, ${firstResultPoint.y}} to {${secondResultPoint.x}, ${secondResultPoint.y}}`;
    }

    let firstResult = getDistanceBetweenPoints(firstPoint, startPoint);
    let secondResult = getDistanceBetweenPoints(secondPoint, startPoint);
    let thirdResult = getDistanceBetweenPoints(firstPoint, secondPoint);
    
    firstResult = firstResult % 1 === 0 ? `valid` : 'invalid';
    secondResult = secondResult % 1 === 0 ? `valid` : 'invalid';
    thirdResult = thirdResult % 1 === 0 ? `valid` : 'invalid';
    return `${getResultString(firstPoint, startPoint)} is ${firstResult}\r\n${getResultString(secondPoint, startPoint)} is ${secondResult}\r\n${getResultString(firstPoint, secondPoint)} is ${thirdResult}`
}

// You will be given a series of coordinates, leading to a buried treasure.
// Use the map to the right to write a program that locates on which island it is.
// After you find where all the treasure chests are, compose a list and print it on the console.
// If a chest is not on any of the islands, print “On the bottom of the ocean” to inform your treasure-hunting team to bring diving gear.
// If the location is on the shore (border) of the island, it’s still considered to lie inside.
// The input comes as an array with a variable number of elements that are numbers.
// Each pair is the coordinates to a buried treasure chest.
// The output is a list of the locations of every treasure chest, either the name of an island or “On the bottom of the ocean”,
// printed on the console.

function findTreasure(arr){
    function checkIslands(islands, point){
        for (let index = 0; index < islands.length; index++) {
            const island = islands[index];
            
            if (point.x >= island.x1 == point.x <= island.x2 &&
                point.y >= island.y1 == point.y <= island.y2) {
                return island.name;
            }
        }
        return 'On the bottom of the ocean';
    }

    let islands = [{    
            x1: 8,
            x2: 9,
            y1: 0,
            y2: 1,
            name: 'Tokelau'
        }, {
            x1: 1,
            x2: 3,
            y1: 1,
            y2: 3,
            name: 'Tuvalu'
        }, {
            x1: 5,
            x2: 7,
            y1: 3,
            y2: 6,
            name: 'Samoa'
        }, {
            x1: 0,
            x2: 2,
            y1: 6,
            y2: 8,
            name: 'Tonga'
        }, {
            x1: 4,
            x2: 9,
            y1: 7,
            y2: 8,
            name: 'Cook'
        },
    ]

    let result = '';

    for (let index = 0; index < arr.length; index += 2) {
        let point = {
            x: arr[index],
            y: arr[index + 1]
        }

        result += checkIslands(islands, point) + '\r\n';
    }

    return result;
}

// You will be given the coordinates of 3 points on a 2D plane.
// Write a program that finds the two shortest segments that connect them (without going back to the starting point).
// When determining the listing order, use the order with the lowest numerical value (see the figure in the hints for more information).
// The input comes as an array of 6 numbers. The order is [x1, y1, x2, y2, x3, y3].
// The output is the return value of your program as a string,
// representing the order in which the three points must be visited and the final distance between them.

function calculateMinimumDistance(arr){
    function getDistance(firstPoint, secondPoint){
        return Math.sqrt(Math.pow(secondPoint.x - firstPoint.x, 2) + Math.pow(secondPoint.y - firstPoint.y, 2));
    }

    let firstPoint = {
        x: arr[0],
        y: arr[1]
    }
    let secondPoint = {
        x: arr[2],
        y: arr[3]
    }
    let thirdPoint = {
        x: arr[4],
        y: arr[5]
    }

    let firstDistance = getDistance(firstPoint, secondPoint);
    let secondDistance = getDistance(secondPoint, thirdPoint);
    let thirdDistance = getDistance(thirdPoint, firstPoint);

    let starAtFirst = firstDistance + secondDistance;
    let starAtSecond = secondDistance + thirdDistance;
    let startAtThird = thirdDistance + firstDistance;

    return starAtFirst <= starAtSecond && starAtFirst <= startAtThird
        ? `1->2->3: ${starAtFirst}`
        : starAtSecond <= startAtThird
        ? `1->3->2: ${starAtSecond}`
        : `2->1->3: ${startAtThird}`;

    return getDistance(firstPoint, secondPoint);
}