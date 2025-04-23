using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    static void Main()
    {
        TcpListener server = new TcpListener(IPAddress.Any, 5000);
        server.Start();
        Console.WriteLine("Servidor aguardando conexão...");

        TcpClient client = server.AcceptTcpClient();
        NetworkStream stream = client.GetStream();

        byte[] buffer = new byte[1024];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        string msgRecebida = Encoding.UTF8.GetString(buffer, 0, bytesRead);

        Console.WriteLine("Mensagem recebida: " + msgRecebida);

        string resposta = "Mensagem recebida com sucesso!";
        byte[] respostaBytes = Encoding.UTF8.GetBytes(resposta);
        stream.Write(respostaBytes, 0, respostaBytes.Length);

        client.Close();
        server.Stop();
    }
}
