using System;
using System.IO;
using System.Net.Sockets;
class TcpClientTest
{
    static void Main(string[] args)
    {
        TcpClient client = null;
        try
        {
            client = new TcpClient();
            client.Connect("192.168.0.35", 5001);
            NetworkStream stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };
            string dataToSend = Console.ReadLine();
            while (true)
            {
                writer.WriteLine(dataToSend);
                if (dataToSend.IndexOf("<EOF>") > -1) break;
                dataToSend = Console.ReadLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            client.Close();
        }
    }
}
