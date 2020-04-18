
function fetchCatlog(){
    console.log("Fetching catalog");

    $.ajax({
        type: 'GET',
        url: '/Catalog/GetCatalog',
        success: function(res){
            console.log("From server", res);

            for(var i=0; i<res.lenght; i++){
                var car = res[i];
                displayCar(res[i]);
            }
        },
        error: function(details){
            console.log("Error",details);
            
        }
    })
}

function displayCar(car){

    var template=
    `<div class="item">
        ${car.model}
        ${car.year}
        ${car.dailyPrice}
    </div>`;

    var container = $("#catalog");

    container.append(template);
}

function init(){
    console.log("Catalog page!");

    fetchCatlog();   
}

window.onload = init;