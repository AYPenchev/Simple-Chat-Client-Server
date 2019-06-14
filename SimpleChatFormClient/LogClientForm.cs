/**************************************************
 *               Simple server - Server
 *               
 * This project is made in process of learning about threads and socket implementation.
 * Here are the steps I have taken in the process of creating this app.
 * 
 * Steps I took:
 * 1 Create Listener
 * 2 Start the Listener
 * 3 While the Listener is up
 *  - Declare client 
 *  - Accept client 
 *  - (Client app creating in separate Console project and implementing client connect)
 *  - Add the Chat thread and start of the the thread
 * 4 Provide the method that handles client
 *  - Network streaming - receiving data
 *  - (Client app - Network streaming - sending data)
 * 5 Provide the method that handles broadcasting
 * 6 Client Socket Shutdown 
 * 7 Added dictionary that containes clients
 * 8 Thread for client handling added
 * 9 Edited HandleClient method - use dictionary data for clients
 * 10 Edited Broadcast method - use dictionary data for clients
 * ***********************************************
 * To be added:     
 *      See if additional changes are needed for the threads and possible locks
 *      Creating Forms for the Client
 *      
 *      
 * ***********************************************/

using System;
using System.IO;
public static class LogClientForm
{
    static int errorId = 0;
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
