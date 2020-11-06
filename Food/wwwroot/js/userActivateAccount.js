const redirectButton = document.querySelector('.but-redirect');

bindEvents();

function bindEvents() {
    redirectButton.onclick = goToLoginPage;
}

function goToLoginPage() {
    window.location.href = "\Index";
}