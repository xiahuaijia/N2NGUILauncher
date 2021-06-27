using System;
using System.Collections.Generic;

namespace STUN.Message.Attributes {
    /// <summary>
    /// 无法理解的属性
    /// </summary>
    public class UselessAttribute : IAttribute {
        public IEnumerable<byte> Bytes => _bytes;

        private byte[] _bytes = Array.Empty<byte>();

        public bool TryParse(byte[] bytes) {
            _bytes = bytes;
            return true;
        }
    }
}
