
// A variable to store name

let name = "Kelly Eric";

// An array to store list of courses

let courses = ["Html", "Css", "JavaScript", "Csharp", "NodeJs"];

// Display name

console.log(`my name is ${name}, and my courses are :`);

// Loop through Courses and display them

courses.forEach((course, index) => console.log(`${index + 1} - ${course}`));

// Display course length

console.log(`My total course is ${courses.length}, and an odd number`);


// Show Odd number of course length within 1-200 range

for (let index = 0; index < 200; index++) {
    
    if(index % 2 !== 0 ){
        console.log(index);
    }
    
}