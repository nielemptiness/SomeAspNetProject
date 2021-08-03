using FluentValidation;
using Store.Core.Common.Validations.CustomValidators;
using Store.Core.Services.Records.Queries.UpdateRecord;

namespace Store.Core.Common.Validations.CommandValidation.Records
{
    public class UpdateRecordCommandValidator : AbstractValidator<UpdateRecordCommand>
    {
        public UpdateRecordCommandValidator()
        {
            RuleFor(x => x.Price)
                .ValidateRecordPrice();

            RuleFor(x => x.Name)
                .ValidateName();
        }
    }
}