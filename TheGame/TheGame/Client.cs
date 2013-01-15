using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace TheGame
{
    class Client
    {
        public static Socket sender;
        public static string fHP;
        public static string sHP;


        public static void StartClient() {
      // Буфер данных для входящих данных.
        
 
        // Подключение к удаленному устройству.
        try {
          
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPHostEntry fdfd = Dns.Resolve("92.42.30.43");
            IPAddress qwe = fdfd.AddressList[0];
            //IPAddress ipAddress = ipHostInfo.AddressList[0]; // 
            IPEndPoint remoteEP = new IPEndPoint(qwe,11000);

            //Console.WriteLine(ipAddress);
 
            // Создаем TCP / IP сокет.
            sender = new Socket(AddressFamily.InterNetwork, 
                SocketType.Stream, ProtocolType.Tcp );
 
           // Подключение розетки в удаленную конечную точку. Поймать ошибки.
            try {
                sender.Connect(remoteEP);
 
                Console.WriteLine("Socket connected to {0}",
                    sender.RemoteEndPoint.ToString());
 
               // Кодировать данные строки в массив байтов.


                
            } catch (ArgumentNullException ane) {
                Console.WriteLine("Исключение аргументов Null : {0}",ane.ToString());
            } catch (SocketException se) {
                Console.WriteLine("SocketException : {0}",se.ToString());
            } catch (Exception e) {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
 
        } catch (Exception e) {
            Console.WriteLine( e.ToString());
        }
    }
        public static int bytesRec;
        public static void SendMSG(string resp)
        {
            byte[] bytes = new byte[1024];
            byte[] msg = Encoding.ASCII.GetBytes(resp);

            int bytesSent = sender.Send(msg);

            // Получение ответа от удаленного устройства.
            bytesRec = sender.Receive(bytes);
            string rec = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            if (resp != "!")
            {
                fHP = rec.Substring(0, rec.IndexOf(";"));
                sHP = rec.Substring(fHP.Length + 1);
            }
            bytes = null;
            // Освободить сокет.
            //sender.Shutdown(SocketShutdown.Both);
            //sender.Close();
        }
        public static void RecieveVOID()
        {
            
            bytesRec = 0;
           
            
        }

        public static int Start()
        {
            StartClient();
            return 0;
        }

    }
}
