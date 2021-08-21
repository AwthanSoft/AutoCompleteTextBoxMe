using System.Collections;

namespace AutoCompleteTextBoxMe.Editors
{
    public interface ISuggestionProvider
    {

        #region Public Methods

        IEnumerable GetSuggestions(string filter);

        #endregion Public Methods

    }
}
