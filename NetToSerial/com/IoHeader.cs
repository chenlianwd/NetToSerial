﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com
{
    public interface IoHeader
    {
        /// <summary>
        /// 用于串口或者网络服务的关闭
        /// </summary>
        /// <param name="session"></param>
        void SessionClosed(IoSession session);

        /// <summary>
        /// 用于串口或者网络服务的关闭
        /// </summary>
        /// <param name="session"></param>
        void SessionOpened(IoSession session);

        /// <summary>
        /// 用于网络服务接收的新连接
        /// </summary>
        /// <param name="state"></param>
        void ConnectOpened(IoState state);

        /// <summary>
        /// 用于网络服务接收的新连接
        /// </summary>
        /// <param name="state"></param>
        void ConnectClosed(IoState state);

        /// <summary>
        /// 收到消息
        /// </summary>
        /// <param name="state"></param>
        /// <param name="message"></param>
        void MessageReceived(IoState state, byte[] message);

        /// <summary>
        /// 发送完成
        /// </summary>
        /// <param name="state"></param>
        /// <param name="message"></param>
        void MessageSent(IoState state, byte[] message);

        /// <summary>
        /// 异常消息,会话与状态异常消息
        /// </summary>
        /// <param name="o"></param>
        /// <param name="ex"></param>
        void SessionException(Object o, Exception ex); 

    }
}