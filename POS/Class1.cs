using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class Sendfileerver
    {
        static void Sendfileserver(string[] args)
        {
            // 서버 설정
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 4563;

            // 클라이언트 연결 대기
            TcpListener listener = new TcpListener(ipAddress, port);
            listener.Start();

            Console.WriteLine("서버가 시작되었습니다. 클라이언트의 연결을 기다립니다...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("클라이언트가 연결되었습니다.");

                // 클라이언트와 파일 전송 시작
                SendFileToClient(client);

                client.Close();
                Console.WriteLine("클라이언트 연결이 종료되었습니다.");
            }
        }

        static void SendFileToClient(TcpClient client)
        {
            string filePath = "파일 경로"; // 전송할 파일 경로
            byte[] buffer = new byte[1024];
            NetworkStream stream = client.GetStream();

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                int bytesRead;
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    stream.Write(buffer, 0, bytesRead);
                }
            }

            Console.WriteLine("파일 전송이 완료되었습니다.");

            // 전송 후 파일 삭제
            File.Delete(filePath);
            Console.WriteLine("전송한 파일을 삭제했습니다.");
        }
    }
    public class Receivefileserver
    {
        private IPAddress ipAddress;
        private int port;

        public Receivefileserver(string ipAddressString, int port)
        {
            ipAddress = IPAddress.Parse(ipAddressString);
            this.port = port;
        }

        public void ConnectAndReceive()
        {
            TcpClient client = new TcpClient();

            try
            {
                client.Connect(ipAddress, port);
                Console.WriteLine("서버에 연결되었습니다.");

                ReceiveFileFromServer(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine("연결 중 오류 발생: " + ex.Message);
            }

            client.Close();
            Console.WriteLine("서버 연결이 종료되었습니다.");
        }

        private void ReceiveFileFromServer(TcpClient client)
        {
            string savePath = "파일 저장 경로"; // 파일을 저장할 경로 및 파일 이름
            byte[] buffer = new byte[1024];
            NetworkStream stream = client.GetStream();

            using (FileStream fileStream = new FileStream(savePath, FileMode.Create, FileAccess.Write))
            {
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fileStream.Write(buffer, 0, bytesRead);
                }
            }

            Console.WriteLine("파일 수신이 완료되었습니다.");
        }
    }
}
