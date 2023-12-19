using UnityEngine;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

public class UDP_Server{

    int MAXBUF = 1024;

    int server_sockfd =0 ,client_sockfd =0 ,clint_len =0 ,n=0;

    public string _IpAddr = "127.0.0.1";
    public int _Port =50002;

}
