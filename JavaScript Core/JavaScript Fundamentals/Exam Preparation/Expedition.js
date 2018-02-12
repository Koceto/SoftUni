function xor(a,b) { return a ^ b; }

function overlayMatrix(matrix, overlay, start) {
    let mRow = start[0];
    for (let row = 0; row < overlay.length; row++, mRow++) {        

        let mCol = start[1];
        for (let col = 0; col < overlay[row].length; col++, mCol++) {
            if (mRow < 0 ||
                mRow >= matrix.length ||
                mCol < 0 ||
                mCol >= matrix[mRow].length) {
                    break;
            }

            matrix[mRow][mCol] = xor(matrix[mRow][mCol], overlay[row][col]);
        }
    }
}

function findFreeSpace(matrix, currentPos, posHistory) {
    let newPos = [currentPos[0], currentPos[1]];
    let oldPos = posHistory.length > 1 ? posHistory.slice(-2, -1)[0] : [];

    let x1 = currentPos[0] + 1;
    let x2 = currentPos[0] - 1;
    let y1 = currentPos[1] + 1;
    let y2 = currentPos[1] - 1;

    let deadEnd = true;

    if (matrix[x1][currentPos[1]] == 0 &&
        x1 != oldPos[0] && deadEnd) {
        newPos[0] = x1;
        deadEnd = false;
    } else if (matrix[x2][currentPos[1]] == 0 &&
        x2 != oldPos[0] && deadEnd) {
        newPos[0] = x2;
        deadEnd = false;
    }

    if (matrix[currentPos[0]][y1] == 0 &&
        y1 != oldPos[1] && deadEnd) {
        newPos[1] = y1;
        deadEnd = false;
    } else if (matrix[currentPos[0]][y2] == 0 &&
        y2 != oldPos[1] && deadEnd) {
        newPos[1] = y2;
        deadEnd = false;
    }
    
    if (deadEnd) {
        if (currentPos[0] + 1 <= matrix.length / 2) {
            if (currentPos[1] + 1 > matrix[0].length / 2) {
                return 'Dead end 1'
            }
            return 'Dead end 2'
        }
        
        if (currentPos[0] + 1 > matrix.length / 2) {
            if (currentPos[1] + 1 <= matrix[0].length / 2) {
                return 'Dead end 3'
            }
            return 'Dead end 4'
        }
    }
    return newPos;
}

function move(matrix, currentPos, posHistory) {
    let x = currentPos[0];
    let y = currentPos[1];

    if (posHistory.length > 1) {
        if (x >= matrix.length - 1) {
            return 'Bottom';
        } else if (x <= 0) {
            return 'Top';
        } else if (y >= matrix[x].length - 1) {
            return 'Right';
        } else if (y <= 0) {
            return 'Left';
        }
    }

    return findFreeSpace(matrix, currentPos, posHistory);
}

function findTheWay(matrix, secondaryMatrix, overlayCoordinates, startCoordinates) {
    for (let i = 0; i < overlayCoordinates.length; i++) {
        const coords = overlayCoordinates[i];
        overlayMatrix(matrix, secondaryMatrix, coords);
    }

    let movesCounter = 0;
    let currentPos = startCoordinates;
    let posHistory = [];

    while (true) {
        posHistory.push([currentPos[0], currentPos[1]]);        
        currentPos = move(matrix, currentPos, posHistory);
        movesCounter++;

        if (currentPos.length != 2) {
            break;
        }
    }

    return movesCounter + '\n' + currentPos;
}

// console.log(findTheWay([[1, 1, 0, 1, 1, 1, 1, 0],
//                         [0, 1, 1, 1, 0, 0, 0, 1],
//                         [1, 0, 0, 1, 0, 0, 0, 1],
//                         [0, 0, 0, 1, 1, 0, 0, 1],
//                         [1, 0, 0, 1, 1, 1, 1, 1],
//                         [1, 0, 1, 1, 0, 1, 0, 0]],
//                         [[0, 1, 1],
//                         [0, 1, 0],
//                         [1, 1, 0]],
//                         [[1, 1], [2, 3], [5, 3]],
//                         [0, 2]));

// console.log(findTheWay([[1, 1, 0, 1],
//                         [0, 1, 1, 0],
//                         [0, 0, 1, 0],
//                         [1, 0, 1, 0]],
//                         [[0, 0, 1, 0, 1],
//                         [1, 0, 0, 1, 1],
//                         [1, 0, 1, 1, 1],
//                         [1, 0, 1, 0, 1]],
//                         [[0, 0],
//                         [2, 1],
//                         [1, 0]],
//                         [2, 0]));

console.log(findTheWay([[1, 1, 0, 1, 0, 1],
                        [0, 0, 1, 0, 0, 1],
                        [1, 1, 1, 0, 1, 1],
                        [1, 0, 1, 1, 0, 0],
                        [1, 0, 0, 1, 1, 0],
                        [1, 0, 0, 1, 0, 1],
                        [1, 0, 1, 0, 1, 0],
                        [1, 0, 0, 1, 0, 1],
                        [1, 0, 0, 0, 0, 1],
                        [1, 1, 1, 1, 1, 1]], [[1, 0, 1],
                                              [1, 0, 0],
                                              [0, 1, 1],
                                              [1, 0, 0]], [[4, 2],
                                                           [0, 2],
                                                           [3, 5]], [1, 0]));

