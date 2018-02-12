// In the era of heroes, every hero has his own items which make him unique.
// Create a function which creates a register for the heroes, with their names, level, and items, if they have such.
// The register should accept data in a specified format, and return it presented in a specified format. 
// The input comes as array of strings. Each element holds data for a hero, in the following format:
// “{heroName} / {heroLevel} / {item1}, {item2}, {item3}...” 
// You must store the data about every hero. The name is a string, the level is a number and the items are all strings.
// The output is a JSON representation of the data for all the heroes you’ve stored. The data must be an array of all the heroes.

function heroInformation(data){
    let heroRegister = [];

    for (let hero of data) {
        hero = hero.split(/\s*\/\s*/);
        let heroObject = { 
            name: hero[0], 
            level: Number(hero[1]), 
            items: hero.length > 2 ? hero[2].split(/,\s*/) : undefined
        };

        heroRegister.push(heroObject);
    }

    return JSON.stringify(heroRegister);
}

// JSON’s Table is a magical table which turns JSON data into an HTML table. 
// You will be given JSON strings holding data about employees, including their name, position and salary. 
// You need to parse that data into objects, and create an HTML table which holds the data for each employee on a different row, as columns. 
// The name and position of the employee are strings, the salary is a number.
// The input comes as array of strings. Each element is a JSON string which represents the data for a certain employee.

function jsonToHtml(data){
    let result = '<table>\n';
    
    for (let dataEntry of data) {
        dataEntry = JSON.parse(dataEntry);
        result += '\t<tr>\n'
        result += Object.values(dataEntry).map(e => `\t\t<td>${e}</td>`).join('\n');
        result += '\n\t</tr>\n'
    }

    result += '</table>';
    return result;
}

// You will be given different bottles, as strings. You will also receive quantity as a number.
// If you receive a juice, you already have, you must sum the current quantity of that juice, with the given one. When a juice reaches 1000 quantity, it produces a bottle. 
// You must store all produced bottles and you must print them at the end.
// Note: 1000 quantity of juice is one bottle. If you happen to have more than 1000, you must make as much bottles as you can, and store what is left from the juice.
// Example: You have 2643 quantity of Orange Juice – this is 2 bottles of Orange Juice and 643 quantity left.
// The input comes as array of strings. Each element holds data about a juice and quantity in the following format:
// “{juiceName} => {juiceQuantity}”
// The output is the produced bottles. The bottles are to be printed in order of obtaining the bottles.

function juicer(data) {
    function bottler(bottle, juice, quantity){
        let bottlesToAdd = Math.floor(quantity / 1000);
        juices[juice] -= bottlesToAdd * 1000;
        
        if (bottles.get(juice)) {            
            bottles.set(juice, bottles.get(juice) + bottlesToAdd);
        } else {
            bottles.set(juice, bottlesToAdd);
        }
    }

    let bottles = new Map();
    let juices = {};

    for (let juiceInfo of data) {
        juiceInfo = juiceInfo.split(/\s*=>\s*/);
        let juiceType = juiceInfo[0];
        let juiceQuantity = Number(juiceInfo[1]);

        if (juices[juiceType]) {
            juices[juiceType] += juiceQuantity;
        } else {
            juices[juiceType] = juiceQuantity;
        }

        if (juices[juiceType] >= 1000) {
            bottler(bottles, juiceType, juices[juiceType]);
        }
    }

    return [...bottles]
        .map(e => `${e[0]} => ${e[1]}`)
        .join('\n');
}

// You have to create a sorted catalogue of store products. You will be given the products’ names and prices. You need to order them by alphabetical order. 
// The input comes as array of strings. Each element holds info about a product in the following format:
// “{productName} : {productPrice}”
// The product’s name will be a string, which will always start with a capital letter, and the price will be a number. 
// You can safely assume there will be NO duplicate product input. The comparison for alphabetical order is case-insensitive.
// As output you must print all the products in a specified format. They must be ordered exactly as specified above. 
// The products must be divided into groups, by the initial of their name. 
// The group’s initial should be printed, and after that the products should be printed with 2 spaces before their names. For more info check the examples.

function storeCatalogue(data) {
    function addProductToCatalogue(catalogue, product, price) {
        let header = product.slice(0,1);

        if (!catalogue[header]) {
            catalogue[header] = [];
        }
        
        catalogue[header].push({ product, price });
    }

    let catalogue = {};

    for (const productInfo of data.sort()) {
        let [product, price] = productInfo.split(/\s*:\s*/);

        addProductToCatalogue(catalogue, product, price);
    }

    let result = '';

    for (const category in catalogue) {
        result += category + '\n';
        
        for (const item of catalogue[category]) {
            result += `\t${item.product}: ${item.price}\n`;
        }
    }

    return result;
}

// You are tasked to create a register for a company that produces cars. You need to store how many cars have been produced from a specified model of a specified brand.
// The input comes as array of strings. Each element holds information in the following format:
// “{carBrand} | {carModel} | {producedCars}”
// The car brands and models are strings, the produced cars are numbers. 
// If the car brand you’ve received already exists, just add the new car model to it with the produced cars as its value. 
// If even the car model exists, just add the given value to the current one.
// As output you need to print – for every car brand, the car models, and number of cars produced from that model. 
// The output format is:
// “{carBrand}
//   ###{carModel} -> {producedCars}
//   ###{carModel2} -> {producedCars}
//   ...”
// The order of printing is the order in which the brands and models first appear in the input.
//  The first brand in the input should be the first printed and so on. For each brand, the first model received from that brand, should be the first printed and so on. 

function carCatalogue(data){
    function addToCatalogue(catalogue, make, model, quantity){
        if (!catalogue.get(make)) {
            catalogue.set(make, new Map());
        }

        if (!catalogue.get(make).get(model)) {
            catalogue.get(make).set(model, 0)
        }
        catalogue.get(make).set(model, catalogue.get(make).get(model) + Number(quantity))
    }

    let catalogue = new Map();

    for (const dataEntry of data) {
        let [make, model, quantity] = dataEntry.split(/\s*\|\s*/);
        
        addToCatalogue(catalogue, make, model, quantity);
    }

    return [...catalogue].map(e => e[0] + '\n' + [...e[1]].map(e => `###${e[0]} -> ${e[1]}`).join('\n')).join('\n')
}

// You will be given a register of systems with components and subcomponents. 
// You need to build an ordered database of all the elements that have been given to you.
// The elements are registered in a very simple way. 
// When you have processed all of the input data, you must print them in a specific order. 
// For every System you must print its components in a specified order, and for every Component, you must print its Subcomponents in a specified order.

// The Systems you’ve stored must be ordered by amount of components, in descending order, as first criteria, and by alphabetical order as second criteria.
// The Components must be ordered by amount of Subcomponents, in descending order.

// The input comes as array of strings. 
// Each element holds data about a system, a component in that system, and a subcomponent in that component. 
// If the given system already exists, you should just add the new component to it. 
// If even the component exists, you should just add the new subcomponent to it. 
// The subcomponents will always be unique. The input format is:
// “{systemName} | {componentName} | {subcomponentName}” 
// All of the elements are strings, and can contain any ASCII character. The string comparison for the alphabetical order is case-insensitive.
// As output you need to print all of the elements, ordered exactly in the way specified above. The format is:
// “{systemName}
//  |||{componentName}
//  |||{component2Name}
//  ||||||{subcomponentName}
//  ||||||{subcomponent2Name}
//  {system2Name} 
//  ...”

function sortSystems(data){
    // The Systems you’ve stored must be ordered by amount of components, in descending order, as first criteria, and by alphabetical order as second criteria.    
    let mainSort = (a, b) => { return a[1].size !== b[1].size ? b[1].size - a[1].size : 
                               a[0] > b[0] ? 1 : 
                               a[0] < b[0] ? -1 :
                                0 };
    // The Components must be ordered by amount of Subcomponents, in descending order.
    let secondarySort = (a, b) => { return b[1].length - a[1].length };

    function AddSystemToCatalogue(systemCatalogue, system, component, subcomponent){
        if (!systemCatalogue.get(system)) {
            systemCatalogue.set(system, new Map());
        }
        if (!systemCatalogue.get(system).get(component)) {
            systemCatalogue.get(system).set(component, []);
        }

        systemCatalogue.get(system).get(component).push(subcomponent);
    }
    
    let systemCatalogue = new Map();

    for (const dataEntry of data) {
    let [system, component, subcomponent] = dataEntry.split(/\s*\|\s*/)
        AddSystemToCatalogue(systemCatalogue, system, component, subcomponent);
    }

    return [...systemCatalogue]
            .sort(mainSort)
            .map(e => e[0] + '\n' + [...e[1]]
                                    .sort(secondarySort)
                                    .map(e => `|||${e[0]}\n` + [...e[1]]
                                                                .sort((a, b) => a - b)
                                                                .map(e => `||||||${e}`)
                                                                .join('\n'))
                                    .join('\n'))
            .join('\n');
}

// You are tasked to create a catalogue of usernames. The usernames will be strings that may contain any ASCII character. 
// You need to order them by their length, in ascending order, as first criteria, and by alphabetical order as second criteria. 
// The input comes as array of strings. Each element represents a username. Sometimes the input may contain duplicate usernames. 
// Make it so that there are NO duplicates in the output.
// The output is all of the usernames, ordered exactly as specified above – each printed on a new line.

function sortUsernames(data){
    // Order by length, in ascending order, as first criteria, and by alphabetical order as second criteria.     
    let mainSort = (a, b) => { return a.length !== b.length ? a.length - b.length :
                                a > b ? 1 :
                                a < b ? -1 :
                                0};

    let result = new Set(data);
    return [...result].sort(mainSort).join('\n');
}

// You are tasked with storing sequences of numbers. 
// You will receive an unknown amount of arrays containing numbers from which you must store only the unique arrays (duplicate arrays should be discarded). 
// An array is considered the same (NOT unique) if it contains the same numbers as another array, regardless of their order. 
// After storing all arrays, your program should print them back in ascending order based on their length, 
// if two arrays have the same length they should be printed in order of being received from the input. 
// Each individual array should be printed in descending order in the format "[a1, a2, a3,… an]". Check the examples bellow.
// The input comes as an array of strings where each entry is a JSON representing an array of numbers.
// The output should be printed on the console - each array printed on a new line in the format "[a1, a2, a3,… an]" , following the above mentioned ordering.

function getUniqueNumberArrays(data){
    let result = new Set();

    for (const arr of data) {
        let numbers = JSON.parse(arr);
        result.add(numbers.map(Number).sort((a, b) => b - a).join('&'));
    }

    return [...result].map(e => `[${e.split(/\s*\&\s*/).join(', ')}]`).sort((a, b) => a.length - b.length).join('\n');
}

console.log(getUniqueNumberArrays(['[-3, -2, -1, 0, 1, 2, 3, 4]', '[10, 1, -17, 0, 2, 13]', '[4, -3, 3, -2, 2, -1, 1, 0]']));
console.log('SECOND TEST --------------------------------------------');
console.log(getUniqueNumberArrays(['[7.14, 7.180, 7.339, 80.099]', '[7.339, 80.0990, 7.140000, 7.18]', '[7.339, 7.180, 7.14, 80.099]']));