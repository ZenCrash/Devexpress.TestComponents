using Devexpress.TestComponents.Data.Models;
using FluentValidation;

namespace Devexpress.TestComponents.Data.Validation
{
  public class PersonValidator : AbstractValidator<Person>
  {
    public PersonValidator()
    {
      RuleFor(x => x.isMarried)
        .NotNull();
        ;

      RuleFor(x => x.WakesUpAt)
        .NotNull()
        ;

      RuleFor(x => x.GoesToBedAt)
        .NotNull()
        .Must((x , field) => DateTimeGreaterThenCheck(x.WakesUpAt, x.GoesToBedAt))
          .WithMessage("'Goes To Bed At' must be greater then 'Wakes Up At'")
        ;
    }

    public bool DateTimeGreaterThenCheck(DateTime? startDate, DateTime? endDate)
    {
      if (startDate != null && endDate != null && startDate < endDate)
      {
        return true;
      }
      return false;
    }
  }
}
