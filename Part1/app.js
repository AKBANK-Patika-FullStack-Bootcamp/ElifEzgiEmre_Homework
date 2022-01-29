const {hex} = require('./kopek.js');
const {Temizle, kopekBakımSaati} = require('./kopekBakımUtility.js');

console.log(`Adi: ${hex.name}\t Cinsi: ${hex.breed}`);
console.log(Temizle());

console.log('köpek ile ${kopekBakımSaati} ilgilenildi.');
