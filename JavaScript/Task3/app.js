// declaring function
const yuGiOh = int => {

	// changing parameter to Integer type 
	Number.parseInt(int);

	// declaring empty array
	let arr = [];

	// iterating over each value in chosen range
	for (let i = 1; i <= int; i++) {

		// divisible by 2,3 & 5
		if (i % 2 === 0 && i % 3 === 0 && i % 5 === 0) {
			arr.push("yu-gi-oh");
		} 
		// divisible by 3 & 5
		else if (i % 3 === 0 && i % 5 === 0) {
			arr.push("gi-oh");
		} 
		// divisible by 2 & 5
		else if (i % 2 === 0 && i % 5 === 0) {
			arr.push("yu-oh");
		} 
		// divisible by 2 & 3
		else if (i % 2 === 0 && i % 3 === 0) {
			arr.push("yu-gi");
		} 
		// divisible by 5
		else if (i % 5 === 0) {
			arr.push("oh");
		} 
		// divisible by 3
		else if (i % 3 === 0) {
			arr.push("gi");
		} 
		// divisible by 2
		else if (i % 2 === 0) {
			arr.push("yu");
		} 
		// this will display divisible by none of 2,3 & 5
		else {
			arr.push(i);
		}
	}
	// returning array of new values from range after iteration
	return arr;
};


console.log(yuGiOh(10));
