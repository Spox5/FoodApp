var logoutLink = document.querySelector('.logout-link')
logoutLink.innerText = "Wyloguj (" + localStorage.getItem('userName') + ")"