using System.Collections;


namespace AutoCompleteTextBoxMe.Editors
{
    public interface IComboSuggestionProvider
    {

        #region Public Methods

        IEnumerable GetSuggestions(string filter);
        IEnumerable GetFullCollection();

        #endregion Public Methods
    }
}
