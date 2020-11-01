export default function () {
    const alertSuccess = document.querySelector('.alert');

    const info = document.querySelector('.email-forgot-password-info');
    const redirectButton = document.querySelector('.but-redirect');

    alertSuccess.style.display = 'none';
    info.innerHTML = "";

    redirectButton.onclick = sendNewPassword;

    function sendNewPassword() {

        const email = document.querySelector('.email-forgot-password-input').value;

        fetch(`/User/ForgotPasswordSendNewPassword?email=${email}`, {
            method: 'PATCH',
            headers: {
                'Content-Type': 'application/json'
            },
        })
            .then(response => response.json())
            .then(error => {
                if (error == 0) {
                    alertSuccess.style.display = 'block';
                    email.value = "";
                }
                else if (error == 1) {
                    info.innerHTML = "Wpisz adres email.";
                }
                else if (error == 2) {
                    info.innerHTML = "Adres email jest niepoprawny.";
                }
                else if (error == 3) {
                    info.innerHTML = "Brak użytkownika o takim adresie email.";
                }
            })
    }

    function hideInfos() {
        alertSuccess.style.display = 'none';
        info.innerHTML = "";
    }
}