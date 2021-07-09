using ReactiveUI.Fody.Helpers;
using STUN.Enums;

namespace N2NGUILauncher.Models {
    public class STUNConfig {
        [Reactive]
        public string StunServer { get; set; } = @"stun.syncthing.net";

        [Reactive]
        public ProxyType ProxyType { get; } = ProxyType.Plain;

        [Reactive]
        public string ProxyServer { get; } = @"127.0.0.1:1080";

        [Reactive]
        public string? ProxyUser { get; }

        [Reactive]
        public string? ProxyPassword { get; }
    }
}
