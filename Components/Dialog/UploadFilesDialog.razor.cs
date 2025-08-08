namespace InvProject.Components.Dialog
{
    public partial class UploadFilesDialog
    {
        private List<string> categories = new List<string>();

        #region Binding Values
        private string Username;
        private string SelectedCategory;
        private DateTime? uploadDate;
        #endregion

        protected override Task OnInitializedAsync()
        {
            uploadDate = DateTime.UtcNow;
            categories = new List<string>()
            {
                "Movies",
                "Photos",
                "Videos",
                "Document"
            };
            return base.OnInitializedAsync();
        }

        private void OnCategoryChanged(object value)
        {
            var category = value?.ToString();
            if (!string.IsNullOrWhiteSpace(category) && !categories.Contains(category, StringComparer.OrdinalIgnoreCase))
            {
                categories.Add(category);
                SelectedCategory = category;
                InvokeAsync(StateHasChanged);
            }
        }
    }
}
