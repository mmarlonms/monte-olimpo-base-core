using MonteOlimpo.Base.Core.DataAnnotations;
using MonteOlimpo.Base.CoreException;
using System.Collections.Generic;
using System.Linq;

namespace MonteOlimpo.Base.Core.Validations.ValidationsHelpers
{
    public  class ValidationHelper
    { /// <summary>
      /// Valida as propriedades do modelo informado e dispara uma ValidationException caso não seja valido.
      /// </summary>
      /// <typeparam name="T">Tipo do modelo que sera validado</typeparam>
      /// <param name="model">Instancia do modelo que sera validado</param>
      /// <exception cref="ModelValidationException" />
        public static void ThrowValidationExceptionIfNotValid<T>(T model)
        {
            if (!ModelValidator.TryValidate(model, out IEnumerable<ValidationResult> errors))
            {
                throw new ModelValidationException(
                    errors.Select(e =>
                        new ModelValidationError(e.ErrorKey, e.ErrorMessage)).ToArray());
            }
        }
    }
}