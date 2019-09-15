using System.Collections.Generic;

namespace MonteOlimpo.Base.Core.DataAnnotations
{
    public interface IValidatableObject
    {
        IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
    }
}