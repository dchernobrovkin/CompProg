using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;
namespace SF
{
    class ThreadedServer
    {
        private Socket _serverSocket;
        private int _port;

        public static string data = null;

        public static string one=null, two=null;
        public static string param1 = null, param2 = null;

        public static string at1, at2, def1, def2;

        public ThreadedServer(int port) { _port = port; }

        private class ConnectionInfo
        {
            public Socket Socket;
            public Thread Thread;
        }

        private Thread _acceptThread;
        private List<ConnectionInfo> _connections =
            new List<ConnectionInfo>();

        public void Start()
        {
            SetupServerSocket();
            _acceptThread = new Thread(AcceptConnections);
            _acceptThread.IsBackground = true;
            _acceptThread.Start();
        }

        private void SetupServerSocket()
        {
            // Получаем информацию о локальном компьютере
            IPHostEntry localMachineInfo =
                Dns.Resolve(Dns.GetHostName());
            IPHostEntry fdfd = Dns.Resolve("92.42.30.43");
            IPAddress qwe = fdfd.AddressList[0];
            IPEndPoint myEndpoint = new IPEndPoint(qwe, _port);
            //localMachineInfo.AddressList[0]
            // Создаем сокет, привязываем его к адресу
            // и начинаем прослушивание
            _serverSocket = new Socket(
                myEndpoint.Address.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Bind(myEndpoint);
            _serverSocket.Listen(2);
        }
       
        private void AcceptConnections()
        {
            while (true)
            {
                // Принимаем соединение
                Socket socket = _serverSocket.Accept();
                ConnectionInfo connection = new ConnectionInfo();
                connection.Socket = socket;

                // Создаем поток для получения данных
                connection.Thread = new Thread(ProcessConnection);
                connection.Thread.IsBackground = true;
                connection.Thread.Start(connection);
                
                // Сохраняем сокет
                lock (_connections) _connections.Add(connection);
            }
        }

        private void ProcessConnection(object state)
        {
            ConnectionInfo connection = (ConnectionInfo)state;
            byte[] buffer = new byte[255];
            
            try
            {
                while (true)
                {
                    data = null;
                    if (one != null && two != null)
                    {
                        one = null;
                        two = null;
                    }
                    int bytesRead = connection.Socket.Receive(
                        buffer);
                    if (bytesRead > 0)
                    {
                        lock (_connections)
                        {
                                foreach (ConnectionInfo conn in
                                    _connections)
                                {
                                    if (conn != connection)
                                    {

                                        // conn.Socket.Send(
                                        //   buffer, bytesRead,
                                        // SocketFlags.None);
                                        //if (conn.Thread.Name == null) 
                                        //{
                                        //    i++;
                                        //    conn.Thread.Name = i.ToString(); 

                                    }
                                    else
                                    {

                                        Console.WriteLine();
                                        data += Encoding.ASCII.GetString(buffer, 0, bytesRead);

                                        if (data.IndexOf("!") > -1)
                                        {
                                            processing.SelectChar();
                                            byte[] msg = Encoding.ASCII.GetBytes(processing.selectCHAR);
                                            conn.Socket.Send(msg);
                                            Console.WriteLine(processing.selectCHAR);
                                        }
                                        else
                                        {

                                            if (data.IndexOf(";") > -1)
                                            {
                                                if (_connections[0] == connection)
                                                {
                                                    param1 = data;
                                                }
                                                else param2 = data;
                                            }

                                            if (_connections[0] == connection)
                                            {
                                                one = data;
                                            }
                                            else two = data;

                                            if (param1 != null && param2 != null)
                                            {
                                                processing.InitializeBattle(param1, param2);
                                                param1 = param2 = null;
                                            }

                                            if (one != null && two != null)
                                            {
                                                if (one.IndexOf(";") == -1 && two.IndexOf(";") == -1)
                                                {
                                                    at1 = one.Substring(0, one.IndexOf("|"));
                                                    def1 = one.Substring(at1.Length + 1);
                                                    at2 = two.Substring(0, one.IndexOf("|"));
                                                    def2 = two.Substring(at2.Length + 1);
                                                }
                                                processing.OneRound(at1, def1, at2, def2);
                                                byte[] msg = Encoding.ASCII.GetBytes(processing.char1[1].ToString() + ";" + processing.char2[1].ToString());
                                                _connections[0].Socket.Send(msg);
                                                _connections[1].Socket.Send(msg);
                                                // var e = new processing();
                                                // e.Proc();
                                                Console.WriteLine(connection.Thread.ManagedThreadId);
                                                Console.WriteLine(data);
                                                Console.WriteLine("one" + one);
                                                Console.WriteLine("two" + two);

                                                //  bytesRead = 0;
                                                // msg = null;
                                                //  data = null;
                                                //buffer = null;
                                                //}
                                            }
                                        }
                                    }
                                }
                        }
                    }
                    else if (bytesRead == 0) return;
                }
                //connection.Thread.
                
              

            }
            catch (SocketException exc)
            {
                Console.WriteLine("Socket exception: " +
                    exc.SocketErrorCode);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception: " + exc);
            }
            //finally
            //{
            //    connection.Socket.Close();
            //    lock (_connections) _connections.Remove(
            //        connection);
            //}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreadedServer ts = new ThreadedServer(11000);
            ts.Start();
            Console.ReadLine();
        }
    }
}
