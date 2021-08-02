using FluentValidation;
using Store.Core.Contracts.Enums;
using Store.Core.Services.Sellers.Queries.CreateSeller;

namespace Store.Core.Common.Validations.CommandValidation.Sellers
{
    public class CreateSellerCommandValidator : AbstractValidator<CreateSellerCommand>
    {
        public CreateSellerCommandValidator()
        {
            RuleFor(x => x.Name).ValidateName();
            RuleForEach(x => x.RecordType).NotEmpty()
                .WithMessage("Seller should have at least one RecordType!");
            
            RuleForEach(x => x.RecordType).IsInEnum();
            RuleForEach(x => x.RecordType).NotEqual(RecordType.Undefined)
                .WithMessage("Can't have undefined recordType!");
        }
    }
}