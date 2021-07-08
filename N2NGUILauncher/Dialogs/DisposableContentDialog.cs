using ModernWpf.Controls;
using System;

namespace N2NGUILauncher.Dialogs {
    public class DisposableContentDialog : ContentDialog, IDisposable {
        public void Dispose() {
            Hide();
        }
    }
}
