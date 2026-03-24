using Application.Activities.Commands;
using Application.Activities.DTOs;

namespace Application.Activities.Validators;

public sealed class CreateActivityValidator : BaseActivityValidator<CreateActivity.Command, CreateActivityDto>
{
    public CreateActivityValidator() : base(x => x.ActivityDto)
    {

    }
}