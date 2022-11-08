externo ao sist nunca confia

problema validar só no front end - usuário consegue manipular o código da página
mas ent existe validação no front ainda é pra melhorar a experiência do usuário

forma rudimentar - usar ifs

ModelState - propriedade do controller; coloca erros de validação, realizando alterações

atributos validação - coloca no model; notação em cada atributo, logo acima
na View: asp-validation-for; pode usar span, p, ...; class= text-danger; colocar o mais próx possível do campo

Controller
if(!ModelState.isValid)

return View computer

_context.C..Add
_context.Save..

return Rediirect...


View Model - atributos sem Id, qnd é gerado aleatoriamente

https://learn.microsoft.com/pt-br/aspnet/core/mvc/models/validation?view=aspnetcore-6.0