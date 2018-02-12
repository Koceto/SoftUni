function pollutionMeter(matrix, days) {
    let breeze = (matrix, value) => {
        const breezeValue = 15;
        matrix[value] = matrix[value].map(e => Math.max(e -= breezeValue), 0);
    }
    let gale = (matrix, value) => {
        const galeValue = 20;
        matrix.map(e => Math.max(e[value] -= galeValue), 0);
    }
    let smog = (matrix, value) => {
        //matrix.map(row => row.map(col => col += Number(value)));
        for (let i = 0; i < matrix.length; i++) {
            matrix[i] = matrix[i].map(e => Math.max(e += Number(value), 0));
        }
    }

    matrix = matrix.map(row => row.split(/\s+/).map(Number));

    for (const dayInfo of days) {
        let [type, value] = dayInfo.split(/\s+/);

        switch (type) {
            case 'breeze':
                breeze(matrix, value);
                break;

            case 'gale':
                gale(matrix, value);
                break;

            case 'smog':
                smog(matrix, value);
                break;

            default:
                break;
        }
    }

    let result = [];

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            if (matrix[row][col] >= 50) {
                result.push(`[${row}-${col}]`);
            }            
        }
        
    }

    if (result.length == 0) {
        result = 'No polluted areas';
    } else {
        result = 'Polluted areas: ' + result.join(', ')
    }

    return result;
}



console.log(pollutionMeter(["5 7 72 14 4",
"41 35 37 27 33",
"23 16 27 42 12",
"2 20 28 39 14",
"16 34 31 10 24",],
["breeze 1", "gale 2", "smog 25"]));

console.log(pollutionMeter(["5 7 2 14 4",
"21 14 2 5 3",
"3 16 7 42 12",
"2 20 8 39 14",
"7 34 1 10 24"],
["breeze 1", "gale 2", "smog 35"]));



