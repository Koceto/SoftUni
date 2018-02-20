function result(id) {
    const regex = /[^(]+\((.+?)\)/g;
    const content = document.getElementById(id).textContent;
    let match = regex.exec(content);
    let result = [];

    while (match) {
        result.push(match[1]);
        match = regex.exec(content);
    }

    return result.join(';');
}

console.log(extract('test'));