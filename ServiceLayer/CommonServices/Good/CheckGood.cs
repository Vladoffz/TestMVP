using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CommonServices
{
    public class CheckGood
    {
        public void ValidateModel<TGoodModel>(TGoodModel goodModel)
        {
            ICollection<ValidationResult> validationResultList = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(goodModel, null, null);
            StringBuilder stringBuilder = new StringBuilder();
            if (!Validator.TryValidateObject(goodModel, validationContext, validationResultList,
                validateAllProperties: true))
            {
                foreach (ValidationResult validationResult in validationResultList)
                {
                    stringBuilder.Append(validationResult.ErrorMessage).AppendLine();
                }
            }

            if (validationResultList.Count > 0)
            {
                throw new ArgumentException(stringBuilder.ToString());
            }
        }
    }
}