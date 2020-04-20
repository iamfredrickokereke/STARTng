
const yuGiOh = function(int) {

	// changing parameter to Integer type 
	Number.parseInt(int);

	
	let arr = [];

	for (let i = 1; i <= int; i++) {

		// divisible by 2,3 & 5
		if (i % 2 === 0 && i % 3 === 0 && i % 5 === 0) {
			arr.push("yu-gi-oh");
		} 
		else if (i % 3 === 0 && i % 5 === 0) {
			arr.push("gi-oh");
		} 
		else if (i % 2 === 0 && i % 5 === 0) {
			arr.push("yu-oh");
		} 
		else if (i % 2 === 0 && i % 3 === 0) {
			arr.push("yu-gi");
		} 
		else if (i % 5 === 0) {
			arr.push("oh");
		} 
		else if (i % 3 === 0) {
			arr.push("gi");
		} 
		else if (i % 2 === 0) {
			arr.push("yu");
		} 
		else {
			arr.push(i);
		}
	}
	// return array result
	return arr;
};


console.log(yuGiOh(10));
