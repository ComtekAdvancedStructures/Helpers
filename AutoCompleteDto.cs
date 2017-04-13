namespace Comtek.Helpers
{
    /// <summary>
    ///     An object to use when returning results from a JQuery UI Autocomplete lookup
    /// </summary>
    public class AutoCompleteDto
    {
        /// <summary>
        ///     What is shown to the user in the drop down list and what populates the text box once selected
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        ///     This can be used as an Id
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        ///     Extra information about the item returned
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Used to sort items into categories on display
        /// </summary>
        public string Category { get; set; }
    }
}