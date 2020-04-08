
// Array of objects created
let data=[

    {principal: "2500", time: "1.8"},
    {principal: "1000", time: "5"},
    {principal: "3000", time: "1"},
    {principal: "2000", time: "3"}

];


// creating the function

function interestCalculator(array) {
   
    for (let index = 0; index < array.length; index++) {
        if(array[index].principal >= 2500 && array[index].time > 1 && array[index].time < 3 )
        {
            rate = 3;
        } 

        else if (array[index].principal >= 2500 && array[index].time >= 3 ) {
            rate = 4;
        }

        else if (array[index].principal >= 2500 || array[index].time <= 1 ) {
            rate = 2;
        }
        else{
            rate = 1;
        }


        let interest = (array[index].principal * array[index].rate * array[index].time) / 100;

        let interestData = [];

        interestData.push(
                {
                principal: array[index].Principal,
                rate: rate,
                time: array[index].time,
                interest: interest
                }
        )

    }    

    console.log(interestData);

	return interestData;

}    

interestCalculator(data)