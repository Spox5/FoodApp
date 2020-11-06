async function loadScripts() {
    if (document.querySelector('.manage-ingredient')) {
        await import('./manageIngredients.js')
    }
    if (document.querySelector('.manage-meals-container')) {
        await import('./manageMeals.js')
    }
    if (document.querySelector('.manage-user')) {
        await import('./manageUser.js')
    }
    if (document.querySelector('.search-meal-container')) {
        await import('./searchMeal.js')
    }
    if (document.querySelector('.navigation')) {
        await import('./layout.js')
    }
    if (document.querySelector('.user-activate-account')) {
        await import('./userActivateAccount.js')
    }
    if (document.querySelector('.user-forgot-password')) {
        await import('./userForgotPassword.js')
    }
    if (document.querySelector('.user')) {
        await import('./user.js')
    }
}

loadScripts()
