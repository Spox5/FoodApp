#pragma checksum "C:\Users\mateu\source\repos\Food\Food\Views\SearchMeal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb83be23fc67ff57dc0fd3305c2f23866844a07c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SearchMeal_Index), @"mvc.1.0.view", @"/Views/SearchMeal/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb83be23fc67ff57dc0fd3305c2f23866844a07c", @"/Views/SearchMeal/Index.cshtml")]
    public class Views_SearchMeal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Food.Data.Models.Ingredient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"search-meal-container\" data-ingredients=\'");
#nullable restore
#line 3 "C:\Users\mateu\source\repos\Food\Food\Views\SearchMeal\Index.cshtml"
                                                Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>\n\n    <div>Co masz w lodówce?</div>\n\n    <div class=\"ingredients\">\n\n");
#nullable restore
#line 9 "C:\Users\mateu\source\repos\Food\Food\Views\SearchMeal\Index.cshtml"
         foreach (var ingredient in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\n\n            </div>\n");
#nullable restore
#line 14 "C:\Users\mateu\source\repos\Food\Food\Views\SearchMeal\Index.cshtml"
       Write(ingredient.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input");
            BeginWriteAttribute("value", " value=\"", 330, "\"", 352, 1);
#nullable restore
#line 14 "C:\Users\mateu\source\repos\Food\Food\Views\SearchMeal\Index.cshtml"
WriteAttributeValue("", 338, ingredient.Id, 338, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\">\n");
#nullable restore
#line 15 "C:\Users\mateu\source\repos\Food\Food\Views\SearchMeal\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <button class=""search-button"" type=""button"">Wyszukaj</button>

    </div>

    <div class=""meal-result-container""></div>

</div>


<script>
    //const searchButton = document.querySelector('.search-button');
    //const ingredientsContainer = document.querySelector('.ingredients');
    //const mealResultContainer = document.querySelector('.meal-result-container');
    //const ingredientsData = JSON.parse(document.querySelector('.search-meal-container').dataset.ingredients);

    //bindEvents();

    //function bindEvents() {
    //    searchButton.onclick = () => {

    //        const ingredients = Array.from(ingredientsContainer.querySelectorAll('input'));
    //        const selectedIngredients = ingredients
    //            .filter(ingredient => ingredient.checked)
    //            .map(ingredient => parseInt(ingredient.value))

    //        getMealsByIngredients(selectedIngredients)
    //}

    //function displayMealResult(meals) {
    //    for (const meal of meals) {

    //        const ");
            WriteLiteral(@"mealElement = document.createElement('div');
    //        mealElement.innerHTML = `${meal.name}. Skladniki: ${getMealIngredients(meal)}`;
    //        mealResultContainer.appendChild(mealElement);

    //    }
    //}

    //function getMealsByIngredients(selectedIngredients) {
    //    const requestData = {
    //        ingredientIds: selectedIngredients
    //    }
    //}


    //      fetch(""/SearchMeal/Search"", {
    //        method: 'POST',
    //        headers: {
    //            'Content-Type': 'application/json'
    //        },
    //        body: JSON.stringify(requestData)
    //    })
    //        .then(response => response.json())
    //        .then(displayMealResult);
    //}

    //function getMealIngredients(meal) {
    //    const ingredients = meal.mealIngredients.map(mi => getIngredientNameById(mi.ingredientId))

    //    return ingredients.toString();
    //}

    //function getingredientNameById(id) {
    //    return ingredientsData.find(ingredient => ingredient.id === id).nam");
            WriteLiteral(@"e
    //}

        const searchButton = document.querySelector('.search-button');
        const ingredientsContainer = document.querySelector('.ingredients');
        const mealResultContainer = document.querySelector('.meal-result-container');
        const ingredientsData = JSON.parse(document.querySelector('.search-meal-container').dataset.ingredients)



        bindEvents()



    function bindEvents() {
            searchButton.onclick = () => {
                const ingredients = Array.from(ingredientsContainer.querySelectorAll('input'));
                const selectedIngredients = ingredients
                    .filter(ingredient => ingredient.checked)
                    .map(ingredient => parseInt(ingredient.value))


                mealResultContainer.innerHTML = """";
                getMealsByIngredients(selectedIngredients)
            }
        }



    function displayMealResult(meals) {
        for (const meal of meals) {



            const mealElement = document.createElement('div');
     ");
            WriteLiteral(@"       mealElement.innerHTML = `${meal.name}. Skladniki: ${getMealIngredients(meal)}`;
            mealResultContainer.appendChild(mealElement);
        }
    }



    function getMealsByIngredients(selectedIngredients) {
        const requestData = {
            ingredientIds: selectedIngredients
        }



        fetch(""/SearchMeal/Search"", {
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

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Food.Data.Models.Ingredient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
