using InvProject.Components.Dialog;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace InvProject.Components.Pages
{
    public partial class UploadFile
    {
        [Inject] DialogService DialogService { get; set; }


        private async void UploadFileButton()
        {
            var edit = await DialogService.OpenAsync<UploadFilesDialog>(
                "Upload Dialog",
                new Dictionary<string, object>{},
                new DialogOptions
                {
                    Width = "600px",
                    Height = "400px",
                    Resizable = true,
                    ShowClose = true,
                    Draggable = true
                }
            );
        }


    }
}
