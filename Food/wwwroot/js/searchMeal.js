const allIngredientsCategoriesButtons = document.querySelectorAll('.but-ingredient-family');

const divShowIngredientsOther = document.querySelector('.div-show-ingredients-other');

const searchButton = document.querySelector('.search-button');
const ingredientsContainer = document.querySelector('.ingredients');

const mealResultContainer = document.querySelector('.meal-result-container');

const ingredientsData = JSON.parse(document.querySelector('.search-meal-container').dataset.ingredients)

bindEvents()

function bindEvents() {

    displayMessegeIfDivIsEmpty(divShowIngredientsOther, "Brak własnych składników");

    searchMealsAfterClick();

    for (const button of allIngredientsCategoriesButtons) {
        //button.nextSibling.nextSibling.style.display = 'none'
        displayIngredientsGroupAfterClick(button, button.nextSibling.nextSibling)
    }

}

function displayMessegeIfDivIsEmpty(checkedDiv, message) {
    if (checkedDiv && checkedDiv.children.length <= 0) {
        checkedDiv.innerHTML = message;
    }
}

function searchMealsAfterClick() {
    searchButton.onclick = () => {
        const ingredients = Array.from(ingredientsContainer.querySelectorAll('input'));
        const selectedIngredients = ingredients
            .filter(ingredient => ingredient.checked)
            .map(ingredient => parseInt(ingredient.value))

        var str = "Wyszukane posiłki: ";

        mealResultContainer.innerHTML = str.bold();

        mealResultContainer.style.visibility = 'block';
        mealResultContainer.className = "border-dark border-top m-4 pt-4";

        getMealsByIngredients(selectedIngredients)
    }
}

function displayIngredientsGroupAfterClick(button, divOfIngredients) {

    button.onclick = () => {
        if (divOfIngredients.classList.contains("unseen")) {
            divOfIngredients.classList.remove("unseen");
        }
        else {
            divOfIngredients.classList.add("unseen");
        }
    }
}


function displayMealResult(meals) {
    for (const meal of meals) {

        const mealElementNameDiv = document.createElement('div');
        const mealElementNameButton = document.createElement('button');
        mealElementNameButton.className = "btn btn-outline-info m-2";
        const mealElementIngredients = document.createElement('div');
        const mealElementRecipe = document.createElement('div');

        mealElementNameButton.innerHTML = `${meal.name}.`;
        mealElementNameDiv.appendChild(mealElementNameButton);
        //mealElementIngredients.innerHTML = `Skladniki: ${getMealIngredients(meal)}.`;
        mealElementIngredients.innerHTML = `Skladniki: ${meal.ingredients}.`;
        mealElementRecipe.innerHTML = `Przepis: ${meal.recipe}`;

        mealResultContainer.appendChild(mealElementNameDiv);
        mealResultContainer.appendChild(mealElementIngredients);
        mealResultContainer.appendChild(mealElementRecipe);

        mealElementIngredients.style.display = 'none';
        mealElementRecipe.style.display = 'none';

        mealElementNameButton.onclick = () => {

            if (mealElementIngredients.style.display == 'none') {
                mealElementIngredients.style.display = 'block';
                mealElementRecipe.style.display = 'block';
            }
            else if (mealElementIngredients.style.display == 'block') {
                mealElementIngredients.style.display = 'none'
                mealElementRecipe.style.display = 'none'
            }
        }
    }
}


function getMealsByIngredients(selectedIngredients) {
    const requestData = {
        ingredientIds: selectedIngredients
    }

    fetch("/SearchMeal/Search", {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(requestData)
    })
        .then(response => response.json())
        .then(displayMealResult);
}


function getMealIngredients(meal) {
    const ingredients = meal.mealIngredients.map(mi => getIngredientNameById(mi.ingredientId))
    return ingredients.toString()
}


function getIngredientNameById(id) {
    return ingredientsData.find(ingredient => ingredient.id === id).name
}
