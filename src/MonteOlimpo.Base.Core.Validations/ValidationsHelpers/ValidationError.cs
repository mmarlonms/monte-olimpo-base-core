using MonteOlimpo.Base.CoreException;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonteOlimpo.Base.Core.Validations.ValidationsHelpers
{
    public class ValidationError  : ModelValidationError
    {
        public ValidationError(string key, string message) : base(key, message)
        {
        }
    }
}
