export default function () {
    const alertSuccess = document.querySelector('.alert');

    const loginButton = document.querySelector('.login-button');
    const usernameOrEmailInput = document.querySelector('.username-or-email-input');
    const usernameLoginInfo = document.querySelector('.username-login-info');
    const passwordInput = document.querySelector('.password-input');
    const showPasswordLoginButton = document.querySelector('.show-password-login-button');
    const passwordLoginInfo = document.querySelector('.password-login-info');

    const registerButton = document.querySelector('.register-button');
    const usernameRegisterInput = document.querySelector('.username-register-input');
    const usernameRegisterInfo = document.querySelector('.username-register-info');
    const emailRegisterInput = document.querySelector('.email-register-input');
    const emailRegisterInfo = document.querySelector('.email-register-info');
    const passwordRegisterInput = document.querySelector('.password-register-input');
    const showPasswordRegisterButton = document.querySelector('.show-password-register-button');
    const passwordRegisterInfo = document.querySelector('.password-register-info');

    var typingTimer;
    var doneTypingInterval = 2000;

    bindEvents();

    function bindEvents() {

        alertSuccess.style.display = 'none';

        loginButton.onclick = () => {
            hideInfos();
            login();
        }

        showPasswordLoginButton.onclick = () => {
            showHidePassword(passwordInput);
        }

        showPasswordRegisterButton.onclick = () => {
            showHidePassword(passwordRegisterInput);
        }

        registerButton.onclick = () => {
            hideInfos();
            register();

        }
        ///////////////
        //usernameRegisterInput.oninput = validateUsername
        waitUntilTypeAndCheck(usernameRegisterInput, usernameRegisterInfo, validateUsername);
        waitUntilTypeAndCheck(emailRegisterInput, emailRegisterInfo, validateEmail);
    }

    function waitUntilTypeAndCheck(inputToCheck, fieldToClear, functionToExecute) {
        inputToCheck.addEventListener('keyup', () => {
            clearTimeout(typingTimer);
            if (inputToCheck.value) {
                fieldToClear.innerHTML = "";
                typingTimer = setTimeout(functionToExecute, doneTypingInterval);
            }
        });
    }

    function login() {
        var user = {
            //tu działa parser małe litery pierwsze na wielkie
            name: usernameOrEmailInput.value,
            password: passwordInput.value
        };

        fetch(`/User/Login?usernameOrEmail=${user.name}&password=${user.password}`, {
            method: 'GET'
        })
            .then(response => response.json())
            .then(user => {
                if (user.success) {
                    localStorage.setItem('token', user.token);
                    localStorage.setItem('userId', user.id);
                    localStorage.setItem('userName', user.name);

                    window.location.href = "\searchmeal"
                }
                else {
                    if (user.errorCode == 1) {
                        usernameLoginInfo.innerHTML = "Brak użytkownika o takiej nazwie.";
                    }
                    else if (user.errorCode == 2) {
                        usernameLoginInfo.innerHTML = "Wpisz nazwę użytkownika.";
                    }
                    else if (user.errorCode == 3) {
                        passwordLoginInfo.innerHTML = "Wpisz hasło.";
                    }
                    else if (user.errorCode == 4) {
                        passwordLoginInfo.innerHTML = "Użytkownik nieaktywny.";
                    }
                    else if (user.errorCode == 5) {
                        passwordLoginInfo.innerHTML = "Nieprawidłowe hasło";
                    }
                }
            })
    }

    function register() {
        var user = {
            //tu działa parser małe litery pierwsze na wielkie
            name: usernameRegisterInput.value,
            email: emailRegisterInput.value,
            password: passwordRegisterInput.value
        };

        fetch(`/User/Register?username=${user.name}&password=${user.password}&email=${user.email}`, {
            method: 'POST'
        })
            .then(response => response.json())
            .then(isRegistered => {
                if (isRegistered == 0) {
                    alertSuccess.style.display = 'block';
                    usernameRegisterInput.value = "";
                    emailRegisterInput.value = "";
                    passwordRegisterInput.value = "";
                    window.scrollTo(0, 0);
                }
                else if (isRegistered == 1) {
                    usernameRegisterInfo.innerHTML = "Użytkownik o nazwie \"" + usernameRegisterInput.value + "\" już istnieje.";
                }
                else if (isRegistered == 2) {
                    emailRegisterInfo.innerHTML = "Użytkownik o adresie e-mail \"" + emailRegisterInput.value + "\" już istnieje.";
                }
                else if (isRegistered == 3) {
                    passwordRegisterInfo.innerHTML = "Hasło musi zawierać co najmniej 5 znaków w tym jedną cyfrę";
                }
                else if (isRegistered == 4) {
                    usernameRegisterInfo.innerHTML = "Nazwa użytkownika musi zawierać minimum jedną literę";
                }
                else if (isRegistered == 5) {
                    emailRegisterInfo.innerHTML = "Wpisz adres e-mail.";
                }
                else if (isRegistered == 6) {
                    emailRegisterInfo.innerHTML = "Adres e-mail jest niepoprawny.";
                }

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
        alertSuccess.style.display = 'none';
        usernameLoginInfo.innerHTML = "";
        passwordLoginInfo.innerHTML = "";
        usernameRegisterInfo.innerHTML = "";
        emailRegisterInfo.innerHTML = "";
        passwordRegisterInfo.innerHTML = "";
    }

    function validateUsername() {
        fetch(`/User/ValidateUsername?username=${usernameRegisterInput.value}`)
            .then(response => response.text())
            .then(isValid => {
                if (isValid == 'false') {
                    usernameRegisterInfo.innerHTML = "Taki użytkownik już istnieje.";
                }
            })
    }

    function validateEmail() {
        fetch(`/User/ValidateEmail?email=${emailRegisterInput.value}`)
            .then(response => response.text())
            .then(isValid => {
                if (isValid == 'false') {
                    emailRegisterInfo.innerHTML = "Użytkownik o takim adresie e-mail już istnieje.";
                }
            })
    }
}