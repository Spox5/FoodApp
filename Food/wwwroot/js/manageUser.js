const alertEditUser = document.querySelector('.alert-edit-user');

const newUsername = document.querySelector('.input-field-username');
const editButtonUsername = document.querySelector('.edit-button-username');
const editUsernameInfo = document.querySelector('.username-edit-info');

const editEmailInput = document.querySelector('.input-field-email');
const editButtonEmail = document.querySelector('.edit-button-email');
const editEmailInfo = document.querySelector('.email-edit-info');

const editPasswordInput = document.querySelector('.input-field-password');
const editPasswordShowButton = document.querySelector('.show-password-button');
const editPasswordConfirmationInput = document.querySelector('.input-field-password-confirmation');
const editPasswordConfirmationShowButton = document.querySelector('.show-confirm-password-button');
const editButtonPassword = document.querySelector('.edit-button-password');
const editPasswordInfo = document.querySelector('.password-edit-info');

const userId = parseInt(window.localStorage.getItem("userId"));
const dataUser = document.querySelector('.main');

bindEvents();

function bindEvents() {

    editPasswordShowButton.onclick = () => {
        showHidePassword(editPasswordInput);
    }

    editPasswordConfirmationShowButton.onclick = () => {
        showHidePassword(editPasswordConfirmationInput);
    }

    editButtonUsername.onclick = () => {
        hideInfos();
        editUsername();
    }

    editButtonEmail.onclick = () => {
        hideInfos();
        editEmail();
    }

    editButtonPassword.onclick = () => {
        hideInfos();
        editPassword();
    }
}


function editUsername() {

    const user = {
        id: parseInt(window.localStorage.getItem("userId")),
        name: newUsername.value,
        //isActive: '@Model.IsActive' == 'True'
        //isActive: dataUser.dataset.user.isActive

        }

fetch(`/ManageUser/UpdateUsername?id=${user.id}&username=${user.name}`, {
    method: 'PATCH',
    headers: {
        'Content-Type': 'application/json'
    },
    body: JSON.stringify(user)
})
    .then(response => response.json())
    .then(editErrors => {
        if (editErrors == 0) {
            alertEditUser.classList.remove('unseen');
            newUsername.value = "";
        }
        else if (editErrors == 1) {
            editUsernameInfo.innerHTML = "Nazwa użytkownika musi zawierać minimum jedną literę";
        }

        else if (editErrors == 2) {
            editUsernameInfo.innerHTML = "Nie zmieniłeś nazwy użytkownika.";
        }
        else if (editErrors == 3) {
            editUsernameInfo.innerHTML = "Taka nazwa użytkownika jest już zajęta.";
        }
        getUser();
    })
}

function editEmail() {

    const user = {
        id: parseInt(window.localStorage.getItem("userId")),
        email: editEmailInput.value
    }

    fetch(`/ManageUser/UpdateUserEmail?id=${user.id}&email=${user.email}`, {
        method: 'PATCH',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(user)
    })
        .then(response => response.json())
        .then(editErrors => {
            if (editErrors == 0) {
                alertEditUser.classList.remove('unseen');
                editEmailInput.value = "";
            }
            else if (editErrors == 1) {
                editEmailInfo.innerHTML = "Wpisz adres email.";
            }
            else if (editErrors == 2) {
                editEmailInfo.innerHTML = "Adres email jest taki sam jak ostatnio.";
            }
            else if (editErrors == 3) {
                editEmailInfo.innerHTML = "Użytkownik o takim adresie email już istnieje.";
            }
            getUser();
        })
}

function editPassword() {
    const newPassword = editPasswordInput.value;
    const newPasswordConfirmation = editPasswordConfirmationInput.value;

    if (newPassword === newPasswordConfirmation) {

        const user = {
            id: parseInt(window.localStorage.getItem("userId")),
            password: newPassword
        };

        fetch(`/ManageUser/UpdateUserPassword?id=${user.id}&password=${user.password}`, {
            method: 'PATCH',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        })
            .then(response => response.json())
            .then(editErrors => {
                if (editErrors == 0) {
                    alertEditUser.classList.remove('unseen');
                }
                else if (editErrors == 1) {
                    editPasswordInfo.innerHTML = "Hasło musi zawierać co najmniej 5 znaków w tym jedną cyfrę.";
                }
            })
    }
    else
        editPasswordInfo.innerHTML = "Hasła w obu polach nie pokrywają się. Sprawdź, czy dokładnie powtórzyłeś hasło.";

}

function getUser() {
    fetch(`/ManageUser/GetUser?userId=${userId}`, {
        method: 'GET'
    })
        .then(response => response.json())
        .then(user => {
            const title = document.querySelector('.title');
            const actualName = document.querySelector('.actualUsername');
            const actualEmail = document.querySelector('.actualEmail');

            title.innerHTML = `Edytuj dane użytkownika ${user.name}`;
            actualName.innerHTML = `Edytuj nazwę użytkownika (dotychczasowa nazwa: ${user.name})`;
            actualEmail.innerHTML = `Edytuj email użytkownika (dotychczasowy email: ${user.email})`;
        })
}

function showHidePassword(passwordInput) {
    if (passwordInput.type === "password") {
        passwordInput.type = "text";
    }
    else
        passwordInput.type = "password";
}

function hideInfos() {
    alertEditUser.classList.add('unseen');
    editUsernameInfo.innerHTML = "";
    editPasswordInfo.innerHTML = "";
}