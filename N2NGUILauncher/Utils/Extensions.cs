using N2NGUILauncher.Dialogs;
using System;
using System.Threading.Tasks;

namespace N2NGUILauncher.Utils {
    public static class Extensions {
        public static async Task HandleExceptionWithContentDialogAsync(this Exception ex) {
            using var dialog = new DisposableContentDialog {
                Title = nameof(N2NGUILauncher),
                Content = ex.Message,
                PrimaryButtonText = @"OK"
            };
            await dialog.ShowAsync();
        }
    }
}
