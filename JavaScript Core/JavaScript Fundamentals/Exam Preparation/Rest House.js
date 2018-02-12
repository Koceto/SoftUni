function addFeaturesToRooms(rooms) {
    for (const room of rooms) {
        room['freeBeds'] = room.type == 'triple' ? 3 : 2;
        room['guests'] = [];
    }
}

function findRoom(rooms, couple, roomType) {
    function pushCouple(room, couple) {
        room.guests.push(couple.first);
        room.guests.push(couple.second);
        room.freeBeds -= 2;
        return 2;
    }
    function pushSingle(room, person) {
        room.guests.push(person);
        room.freeBeds -= 1;
        return 1;
    }

    let peopleLeft = 2;

    for (const room of rooms.filter(r => r.type == roomType)) {
        if (room.freeBeds === 0 || peopleLeft === 0) {
            continue;
        }

        if (roomType == 'double-bedded') {
            peopleLeft -= pushCouple(room, couple);
            return peopleLeft;
        }

        if (room.freeBeds < 3 && room.guests[0].gender != couple.first.gender) {
            continue;
        }

        if (room.freeBeds > 1 && peopleLeft === 2) {
            peopleLeft -= pushCouple(room, couple);
            return peopleLeft;
        } else {
            if (peopleLeft === 2) {
                peopleLeft -= pushSingle(room, couple.first);
            } else {
                peopleLeft -= pushSingle(room, couple.second);
                return peopleLeft;
            }
        }
    }

    return peopleLeft;
}

function manageRooms(rooms, couples) {
    addFeaturesToRooms(rooms);
    let peopleLeft = 0;

    for (const couple of couples) {
        // Same sex couple go in triple bedded room
        if (couple.first.gender == couple.second.gender) {
            let roomType = 'triple';
            peopleLeft += findRoom(rooms, couple, roomType);
        } else {
            let roomType = 'double-bedded';
            peopleLeft += findRoom(rooms, couple, roomType);
        }
    }

    let result = '';

    for (const room of rooms.sort((a, b) => a.number < b.number ? -1 : a.number > b.number ? 1 : 0)) {
        result += `Room number: ${room.number}\n`
        
        for (const person of room.guests.sort((a, b) => b.name < a.name)) {
            result += `--Guest Name: ${person.name}\n--Guest Age: ${person.age}\n`;
        }
        
        result += `Empty beds in the room: ${room.freeBeds}\n`;
    }
    
    result += `Guests moved to the tea house: ${peopleLeft}`;

    return result;
}



// console.log(manageRooms([ { number: '206', type: 'double-bedded' },
//                           { number: '311', type: 'triple' } ],
//                         [ { first: { name: 'Tanya Popova', gender: 'female', age: 24 },
//                             second: { name: 'Miglena Yovcheva', gender: 'female', age: 23 } },
//                           { first: { name: 'Katerina Stefanova', gender: 'female', age: 23 },
//                             second: { name: 'Angel Nachev', gender: 'male', age: 22 } },
//                           { first: { name: 'Tatyana Germanova', gender: 'female', age: 23 },
//                             second: { name: 'Boryana Baeva', gender: 'female', age: 22 } } ]));

// console.log(manageRooms([ { number: '101A', type: 'double-bedded' },
// { number: '104', type: 'triple' },
// { number: '101B', type: 'double-bedded' },
// { number: '102', type: 'triple' } ],
// [ { first: { name: 'Sushi & Chicken', gender: 'female', age: 15 },
// second: { name: 'Salisa Debelisa', gender: 'female', age: 25 } },
// { first: { name: 'Daenerys Targaryen', gender: 'female', age: 20 },
// second: { name: 'Jeko Snejev', gender: 'male', age: 18 } },
// { first: { name: 'Pesho Goshov', gender: 'male', age: 20 },
// second: { name: 'Gosho Peshov', gender: 'male', age: 18 } },
// { first: { name: 'Conor McGregor', gender: 'male', age: 29 },
// second: { name: 'Floyd Mayweather', gender: 'male', age: 40 } } ]));

console.log(manageRooms(
[{"number":"428","type":"triple"},
{"number":"161","type":"triple"},
{"number":"242","type":"double-bedded"},
{"number":"537","type":"triple"}], 
[{"first":{"name":"Nina Diaz","gender":"female","age":29},"second":{"name":"Carol Hansen","gender":"female","age":6}},
{"first":{"name":"Georgia Thomas","gender":"female","age":38},"second":{"name":"Freddie Harmon","gender":"male","age":46}},
{"first":{"name":"Freddie Harmon","gender":"male","age":30},"second":{"name":"Jesus Terry","gender":"male","age":64}},
{"first":{"name":"Tracy Reid","gender":"male","age":41},"second":{"name":"Jordan Garner","gender":"male","age":16}},
{"first":{"name":"Kara Burns","gender":"female","age":7},"second":{"name":"Marjorie Butler","gender":"female","age":28}}]));