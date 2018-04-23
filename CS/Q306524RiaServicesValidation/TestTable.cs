using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Q306524RiaServicesValidation.Web {
    partial class TestTable : IDataErrorInfo {
        #region IDataErrorInfo Members
        string IDataErrorInfo.Error {
            get { return string.Empty; }
        }

        string IDataErrorInfo.this[string columnName] {
            get {
                if(!HasValidationErrors)
                    return string.Empty;
                StringBuilder sb = new StringBuilder();
                foreach(ValidationResult validationResult in ValidationErrors) {
                    if(validationResult.MemberNames.Contains<string>(columnName))
                        sb.Append(validationResult.ErrorMessage);
                }
                return sb.ToString();
            }
        }
        #endregion
    }
}
