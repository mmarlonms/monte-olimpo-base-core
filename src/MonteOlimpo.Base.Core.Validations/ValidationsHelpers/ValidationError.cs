using MonteOlimpo.Base.CoreException;

namespace MonteOlimpo.Base.Core.Validations.ValidationsHelpers
{
    public class ValidationError  : ModelValidationError
    {
        public ValidationError(string key, string message) : base(key, message)
        {
        }
    }
}