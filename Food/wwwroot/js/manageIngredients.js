export default function () {
    const alertAdd = document.querySelector('.alert-add-ingredient');
    const alertDelete = document.querySelector('.alert-delete-ingredient');
    const ingredientAddInfo = document.querySelector('.register-form-info');

    const ingredientsOther = document.querySelector('.ingredients-other');
    const addButton = document.querySelector('.add-button');
    const addIngredientName = document.querySelector('.input-field');
    const deleteButton = document.querySelector('.delete-button');
    const updateButton = document.querySelector('.update-button');
    const editInput = document.querySelector('.ingredient-name-input');
    const editForm = document.querySelector('.ingredient-name-form');
    const saveButton = document.querySelector('.save-button');

    const userId = parseInt(window.localStorage.getItem("userId"));

    getIngredients();

    bindEvents();

    function bindEvents() {

        //displayMessegeIfDivIsEmpty(ingredientsOther);

        addButton.onclick = () => {
            hideInfos();
            addIngredient();
        }
        deleteButton.onclick = () => {
            hideInfos();
            deleteIngredient();
        }
    }

    function displayMessegeIfDivIsEmpty(checkedDiv) {
        if (checkedDiv.children.length <= 0) {
            checkedDiv.innerHTML = "Brak własnych składników.";
            deleteButton.style.display = 'none';
        }
        else {

            deleteButton.style.display = 'block';
            deleteButton.className = "delete-button but but-delete mx-auto";
        }
    }

    function addIngredient() {
        var ingredient = {
            //tu działa parser małe litery pierwsze na wielkie
            name: addIngredientName.value,
            userId: parseInt(window.localStorage.getItem("userId")),
            categoryId: 9
        };

        fetch("/ManageIngredients/AddIngredient", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(ingredient)

        })
            .then(response => response.json())
            .then(isAdded => {
                if (isAdded == 0) {
                    alertAdd.classList.remove('unseen');
                    addIngredientName.value = "";
                }

                else if (isAdded == 1) {
                    ingredientAddInfo.innerHTML = "Składnik o nazwie \"" + ingredient.name + "\" już istnieje. Dodaj inny."
                }

                else if (isAdded == 2) {
                    ingredientAddInfo.innerHTML = "Nazwa składnika musi posiadać co najmniej jedną literę."
                }
                getIngredients();

            })

    }

    function deleteIngredient() {
        const selectedIngredient = Array.from(document.querySelectorAll('.ingredient-input')).find(ingredient => ingredient.checked);

        const ingredient = {
            id: parseInt(selectedIngredient.value),
            name: '',
            userId: parseInt(window.localStorage.getItem("userId")),
            categoryId: 9
        }

        fetch('/ManageIngredients/DeleteIngredient', {
            method: 'DELETE',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(ingredient)
        })
            .then(() => {
                getIngredients();

                alertDelete.classList.remove('unseen');
            })

    }

    function getIngredients() {
        fetch(`/ManageIngredients/GetIngredients?userId=${userId}`, {
            method: 'GET'
        })
            .then(response => response.json())
            .then(ingredients => {
                const divOthers = document.querySelector('.ingredients-other');

                divOthers.innerHTML = "";

                for (const ingredient of ingredients) {
                    const label = document.createElement('label');
                    const radioButton = document.createElement('input');
                    radioButton.setAttribute("type", "radio");
                    radioButton.className = "ingredient-input m-1";
                    radioButton.value = ingredient.id;
                    radioButton.name = "ingredient";
                    label.className = "btn btn-outline-primary m-1";
                    label.innerHTML = ingredient.name;
                    label.appendChild(radioButton);

                    divOthers.appendChild(label);
                }
                displayMessegeIfDivIsEmpty(ingredientsOther)
            }
            )
    }

    function hideInfos() {
        alertAdd.classList.add('unseen');
        alertDelete.classList.add('unseen');
        ingredientAddInfo.innerHTML = "";
    }
}