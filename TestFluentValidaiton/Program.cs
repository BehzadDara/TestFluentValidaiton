using TestFluentValidaiton;

var myClass = new MyClass
{
    FirstName = "",
    LastName = "",
    Age = 0
};

var validator = new MyClassValidator();
var validationResult = validator.Validate(myClass);

if (!validationResult.IsValid)
{
    foreach (var error in validationResult.Errors)
    {
        Console.WriteLine(error.ErrorMessage);
    }
}