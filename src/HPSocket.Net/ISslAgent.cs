﻿using System;
using HPSocket.Ssl;

namespace HPSocket
{
    /// <summary>
    /// ssl agent
    /// </summary>
    public interface ISslAgent : ISsl, ITcpAgent
    {

        /// <summary>
        /// 启动 SSL 握手，当通信组件设置为非自动握手时，需要调用本方法启动 SSL 握手
        /// </summary>
        /// <param name="connId"></param>
        /// <returns></returns>
        bool StartHandShake(IntPtr connId);

        /// <summary>
        /// 获取指定类型的 SSL WebSocketSession 信息（输出类型参考：SslSessionInfo）
        /// </summary>
        /// <param name="connId"></param>
        /// <param name="info"></param>
        /// <param name="sessionInfo"></param>
        /// <returns></returns>
        bool GetSessionInfo(IntPtr connId, SslSessionInfo info, out IntPtr sessionInfo);
    }
}