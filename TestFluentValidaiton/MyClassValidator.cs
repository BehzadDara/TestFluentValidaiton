using FluentValidation;

namespace TestFluentValidaiton
{
    public class MyClassValidator : AbstractValidator<MyClass>
    {
        public MyClassValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please specify a first name");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please specify a last name");
            RuleFor(x => x.Age).InclusiveBetween(1, 120).WithMessage("Please specify a valid age between 1 and 120");
        }
    }
}
