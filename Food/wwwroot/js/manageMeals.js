const alertAdd = document.querySelector('.alert-add-meal');
const alertDelete = document.querySelector('.alert-delete-meal');
const mealAddInfo = document.querySelector('.register-form-info');

const mealsOther = document.querySelector('.meals-other');

const allIngredientsCategoriesButtons = document.querySelectorAll('.but-ingredient-family');
//const divShowIngredientsOther = Array.from(allIngredientsCategoriesButtons).find(button => button.textContent == 'Użytkownika').nextSibling.nextSibling
const divShowIngredientsOther = document.querySelector('.div-show-ingredients-other');

const ingredientsData = JSON.parse(document.querySelector('.manage-meals-container').dataset.ingredients)
const mealsData = JSON.parse(document.querySelector('.manage-meals-container').dataset.meals)

const ingredientsEditMealContainer = document.querySelector('.meal-name-form');
const ingredientsContainer = document.querySelector('.ingredients')
const addButton = document.querySelector('.add-button')
const addMealName = document.querySelector('.input-field')
const addMealRecipe = document.querySelector('.input-meal-recipe-field')
const editButton = document.querySelector('.edit-button')
const deleteButton = document.querySelector('.delete-button')
const editInput = document.querySelector('.meal-name-input')
const editInputRecipe = document.querySelector('.meal-recipe-input')
const editForm = document.querySelector('.meal-name-form')
const saveButton = document.querySelector('.save-button')
const editFormCheckboxes = document.querySelectorAll('.edit-meal-checkboxes input')

const userId = parseInt(window.localStorage.getItem("userId"));

getMeals();

editForm.style.display = 'none'
bindEvents();


function bindEvents() {

    addButton.onclick = () => {
        hideInfos();
        addMeal();
    }

    editButton.onclick = displayOrHideEditForm

    saveButton.onclick = updateMeal

    deleteButton.onclick = () => {
        hideInfos();
        deleteMeal();
    }

    for (const button of allIngredientsCategoriesButtons) {
        button.nextSibling.nextSibling.style.display = 'none'
        displayIngredientsGroupAfterClick(button, button.nextSibling.nextSibling)
    }

    displayMessageIfUserIngredientsAreEmpty(divShowIngredientsOther)

}

function displayMessegeIfDivIsEmpty(checkedDiv, message) {
    if (checkedDiv.children.length <= 0) {
        checkedDiv.innerHTML = message;
        deleteButton.style.display = 'none';
        editButton.style.display = 'none';
    }
    else {
        editButton.style.display = 'block';
        editButton.className = "edit-button but but-edit-meal m-1 mx-auto";
        deleteButton.style.display = 'block';
        deleteButton.className = "delete-button but but-delete m-1 mx-auto";
    }
}

function displayMessageIfUserIngredientsAreEmpty(checkedDiv) {
    if (checkedDiv.children.length <= 0) {
        checkedDiv.innerHTML = "Brak własnych składników";
    }
}

function displayIngredientsGroupAfterClick(button, divOfIngredients) {

    button.onclick = () => {
        if (divOfIngredients.style.display == 'none') {
            divOfIngredients.style.display = 'block';
        }
        else if (divOfIngredients.style.display == 'block') {
            divOfIngredients.style.display = 'none'
        }
    }
}

function addMeal() {
    const ingredients = Array.from(ingredientsContainer.querySelectorAll('.ingredients-checkboxes'));
    const selectedIngredients = ingredients
        .filter(ingredient => ingredient.checked)
        .map(ingredient => parseInt(ingredient.value))
    const meal = {
        name: addMealName.value,
        userId: parseInt(window.localStorage.getItem("userId")),
        recipe: addMealRecipe.value,
        categoryId: 6,
        mealIngredients: selectedIngredients.map(ingredient => ({ ingredientId: ingredient }))
    }

    fetch("/ManageMeals/Add", {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(meal)
    })

        .then(response => response.json())
        .then(isAdded => {
            if (isAdded == 0) {
                addMealName.value = "";
                addMealRecipe.value = "";
                alertAdd.classList.remove('unseen');
            }

            else if (isAdded == 1) {
                mealAddInfo.innerHTML = "Posiłek o nazwie \"" + meal.name + "\" już istnieje. Dodaj inny."
            }

            else if (isAdded == 2) {
                mealAddInfo.innerHTML = "Nazwa posiłku musi posiadać co najmniej jedną literę."
            }

            else if (isAdded == 3) {
                mealAddInfo.innerHTML = "Przepis na posiłek musi posiadać co najmniej jedną literę."
            }
            getMeals();
        })
}


function updateMeal() {

    const selectedMeal = Array.from(document.querySelectorAll('.meal-input')).find(meal => meal.checked);

    const ingredients = Array.from(ingredientsEditMealContainer.querySelectorAll('.ingredients-checkboxes-edit-meal'));

    const selectedIngredients = ingredients
        .filter(ingredient => ingredient.checked)
        .map(ingredient => parseInt(ingredient.value));

    const meal = {
        id: parseInt(selectedMeal.value),
        name: editInput.value,
        userId: parseInt(window.localStorage.getItem("userId")),
        recipe: editInputRecipe.value,
        categoryId: 6,
        mealIngredients: selectedIngredients.map(ingredient => ({ ingredientId: ingredient, mealid: parseInt(selectedMeal.value) }))

    }

    fetch("/ManageMeals/Update", {
        method: 'PATCH',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(meal)
    })

    setTimeout(function () {
        window.location.reload();
    }, 500);
}


function deleteMeal() {
    const selectedMeal = Array.from(document.querySelectorAll('.meal-input')).find(meal => meal.checked);

    const meal = {
        id: parseInt(selectedMeal.value),
        name: '',
        userId: parseInt(window.localStorage.getItem("userId")),
        categoryId: 6
    }

    fetch("/ManageMeals/Delete", {
        method: 'DELETE',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(meal)
    })
        .then(() => {
            alertDelete.classList.remove('unseen');
            getMeals()
        })

}


function displayOrHideEditForm() {
    if (editForm.style.display == 'none') {
        editForm.style.display = 'block'
        initializeEditFormCheckboxes()
        initializeEditFormInputs()
    }
    else if (editForm.style.display == 'block') {
        editForm.style.display = 'none'
    }
}

function initializeEditFormCheckboxes() {

    const selectedMealId = Array.from(document.querySelectorAll('.meal-input')).find(meal => meal.checked).value
    const mealIngredientsIds = mealsData.find(meal => meal.id == selectedMealId).mealIngredients.map(mealIngredient => mealIngredient.ingredientId)

    for (const checkbox of editFormCheckboxes) {
        if (mealIngredientsIds.some(mealIngredient => mealIngredient == checkbox.value)) {
            checkbox.checked = true
        }
        else {
            checkbox.checked = false
        }
    }
}

function initializeEditFormInputs() {
    selectedMealId = Array.from(document.querySelectorAll('.meal-input')).find(meal => meal.checked).value;

    editInput.value = mealsData.find(meal => meal.id == selectedMealId).name;
    editInputRecipe.value = mealsData.find(meal => meal.id == selectedMealId).recipe;
}

function getMeals() {
    fetch(`/ManageMeals/GetMeals?userId=${userId}`, {
        method: 'GET'
    })
        .then(response => response.json())
        .then(meals => {
            const divOthers = document.querySelector('.meals-other');

            divOthers.innerHTML = "";

            for (const meal of meals) {
                const label = document.createElement('label');
                const radioButton = document.createElement('input');
                radioButton.setAttribute("type", "radio");
                radioButton.className = "meal-input m-1";
                radioButton.value = meal.id;
                radioButton.name = "meal";
                label.className = "btn btn-outline-primary m-1";
                label.innerHTML = meal.name;
                label.appendChild(radioButton);

                divOthers.appendChild(label);
            }
            displayMessegeIfDivIsEmpty(mealsOther, "Brak własnych posiłków.")
        }
        )
}

function hideInfos() {
    alertAdd.classList.add('unseen');
    alertDelete.classList.add('unseen');
    mealAddInfo.innerHTML = "";
}