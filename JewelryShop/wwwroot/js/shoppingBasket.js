let shoppingBasket = [];

const removeButton = document.getElementById('removeButton');
const addButton = document.getElementById('addButton');

removeButton.addEventListener('click',
    function(event) {

    })

addButton.addEventListener('click',
    function (event) {
        addToBasket();
    })


addToBasket = function (int) {
    for (let i = 0; i < shoppingBasket.length; i++) {
        if (shoppingBasket[i].id == int) {
            shoppingBasket[i].quantity++;
            return;
        }
    }
    shoppingBasket.push(new Item(int, 1));
}

