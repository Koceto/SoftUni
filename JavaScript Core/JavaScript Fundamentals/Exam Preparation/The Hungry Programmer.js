function kitchenStaff(meals, commands){
    let serve = meals => { 
        if (meals.length <= 0) {
            return;
        }
        return [`${meals.pop()} served!`];
    }
    let add = (meals, params) => { 
        if (params.length < 1) {
            return;
        }
        meals.unshift(params[0]);
    }
    let shift = (meals, params) => { 
        if (params[0] < 0 || 
            params[1] >= meals.length ||
            params[1] <= params[0]) {
            return;
        }

        let temp = meals[params[0]]; 

        meals[params[0]] = meals[params[1]]; 
        meals[params[1]] = temp; 
    }
    let eat = meals => {
        if (meals.length <= 0) {
            return;
        }
        return [`${meals.shift()} eaten`, 1] 
    }
    let consume = (meals, params) => {
        if (params[0] < 0 || 
            params[1] >= meals.length ||
            params[1] <= params[0]) {
            return;
        }

        let totalElementsRemoved = params[1] - params[0] + 1;

        meals.splice(params[0], totalElementsRemoved); 

        return ['Burp!', totalElementsRemoved];
    }

    const listOfCommands = {
        Serve: serve,
        Add: add,
        Shift: shift,
        Eat: eat,
        Consume: consume,
    }

    let result = '';
    let mealsEaten = 0;

    for (let command of commands) {
        command = command.split(' ');

        if (command == 'End') {
            break;
        }
        let execResult = listOfCommands[command[0]](meals, command.slice(1));

        result += execResult != undefined ? execResult[0] + '\n' : '';
        mealsEaten += execResult != undefined && Number(execResult[1]) ? Number(execResult[1]) : 0;
    }

    let mealsLeft = meals.length > 0 ? `Meals left: ${meals.join(', ')}` : 'The food is gone';
    mealsEaten = `Meals eaten: ${mealsEaten}`;
    return `${result}${mealsLeft}\n${mealsEaten}`;
}

//console.log(kitchenStaff(['chicken', 'steak', 'eggs'],['Serve', 'Eat', 'End', 'Consume 0 1']));
//console.log(kitchenStaff(['fries', 'fish', 'beer', 'chicken', 'beer', 'eggs'], ['Add spaghetti', 'Shift 0 1', 'Consume 1 4', 'End']));
//console.log(kitchenStaff(['carrots', 'apple', 'beet'], ['Consume 0 2', 'End',]));
//console.log(kitchenStaff(['soup', 'spaghetti', 'eggs'], ['Consume 0 2', 'Eat', 'Eat', 'Shift 0 1', 'End', 'Eat']));
console.log(kitchenStaff(['bacon', 'veggies', 'chicken'], ['Add', 'End']));