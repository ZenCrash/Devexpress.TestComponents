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
      RuleFor(x => x.GoesToBedAt)
        .Must((x , field) => DateTimeGreaterThenCheck(x.WakesUpAt, x.GoesToBedAt))
        ;
    }

    public bool DateTimeGreaterThenCheck(DateTime? startDate, DateTime? endDate)
    {
      if (startDate != null && endDate != null && startDate < endDate)
      {
        return true;
      }
      return true;
    }
  }
}
