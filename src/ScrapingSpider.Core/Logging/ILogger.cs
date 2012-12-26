//============================================================
//
//    �ļ�������ILogger.cs
//    ������������־��¼�ӿ�
//    ������ʶ��StanZhai 2012/12/23
//    �ļ��汾��1.0.0.0
//
//============================================================

using System;

namespace ScrapingSpider.Core.Logging
{
    public interface ILogger
    {
        /// <summary>
        /// ���Info������־
        /// </summary>
        /// <param name="msg">��־��Ϣ</param>
        void Info(string msg);

        /// <summary>
        /// ���WARN������־
        /// </summary>
        /// <param name="msg">��־��Ϣ</param>
        void Warn(string msg);

        /// <summary>
        /// ���ERROR������־
        /// </summary>
        /// <param name="msg">��־��Ϣ</param>
        void Error(string msg);

        /// <summary>
        /// ���ERROR������־����¼�쳣��Ϣ
        /// </summary>
        /// <param name="ex">�쳣ʵ��</param>
        void Error(Exception ex);
    }
}