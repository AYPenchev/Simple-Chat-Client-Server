using System;
using System.IO;

public static class LogServer
{
    private static int errorId = 0;

    public static void Error(Exception message)
    {
        errorId++;
        StreamWriter logChatMessageSW = null;
        logChatMessageSW = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFileErrors.txt", true);
        logChatMessageSW.WriteLine("[{0}] [{1}] Error:  {2}", DateTime.Now.ToString().Trim(), errorId, message.Message);
        logChatMessageSW.WriteLine("[{0}] [{1}] Error Source:  {2}", DateTime.Now.ToString().Trim(), errorId, message.Source);
        logChatMessageSW.WriteLine("[{0}] [{1}] Target Site:  {2}", DateTime.Now.ToString().Trim(), errorId, message.TargetSite);
        logChatMessageSW.WriteLine("[{0}] [{1}] Stack Trace:  {2}", DateTime.Now.ToString().Trim(), errorId, message.StackTrace);
        logChatMessageSW.Flush();
        logChatMessageSW.Close();
    }

    public static void Message(string message)
    {
        StreamWriter logChatMessageSW = null;
        logChatMessageSW = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFileMessages.txt", true);
        logChatMessageSW.WriteLine("[" + DateTime.Now.ToString().Trim() + "]  " + message);
        logChatMessageSW.Flush();
        logChatMessageSW.Close();
    }
}
