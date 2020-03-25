

let name = "Kelly Eric";

let courses = ["Html", "Css", "JavaScript", "Csharp", "NodeJs"];

console.log(`my name is ${name}, and my courses are :`);

courses.forEach((course, index) => console.log(`${index + 1} - ${course}`));

console.log(`My total course is ${courses.length}, and an odd number`);


for (let index = 0; index < 200; index++) {
    
    if(index % 2 !== 0 ){
        console.log(index);
    }
    
}