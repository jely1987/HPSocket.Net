using System;
using System.Collections.Generic;

namespace HPSocket
{
    /// <summary>
    /// tcp pack agent
    /// </summary>
    public interface ITcpPackAgent : ITcpAgent
    {
        #region 服务器属性

        /// <summary>
        /// 读取或设置数据包最大长度，有效数据包最大长度不能超过 4194303/0x3FFFFF 字节，默认：262144/0x40000
        /// </summary>
        uint MaxPackSize { get; set; }

        /// <summary>
        /// 读取或设置包头标识，有效包头标识取值范围  0 ~ 1023/0x3FF，当包头标识为 0 时不校验包头，默认：0
        /// </summary>
        ushort PackHeaderFlag { get; set; }

        [Obsolete("tcp pack agent 不支持设置代理", true)]
        new List<IProxy> ProxyList { get; }

        #endregion
    }
}
