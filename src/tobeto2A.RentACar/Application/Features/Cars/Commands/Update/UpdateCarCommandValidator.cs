using FluentValidation;

namespace Application.Features.Cars.Commands.Update;

public class UpdateCarCommandValidator : AbstractValidator<UpdateCarCommand>
{
    public UpdateCarCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.BrandId).NotEmpty();
        RuleFor(c => c.MyProperty).NotEmpty();
    }
}