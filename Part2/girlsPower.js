const array = [2, 3, 4];

const girlsPowerFunc= (n) => {
    return (n/2) + 3;
}

const girlsPower = (array) => { return array.map(girlsPowerFunc);};

console.log(`[${array}] ==> [${girlsPower(array)}]`);