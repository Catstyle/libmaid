﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Net;
using maid;
using maid.example;

namespace Example
{
    class Program
    {

        static void Main(string[] args)
        {
            Channel channel = new Channel();
            HelloService service = new HelloService();
            channel.AddMethod<HelloRequest, HelloSerializer>("maid.example.HelloService.HelloNotify", service.HelloNotify);
            channel.AddMethod<HelloRequest, HelloSerializer, HelloResponse, HelloSerializer>("maid.example.HelloService.HelloRpc", service.HelloRpc);
            channel.Connect("192.168.0.99", 5555);

            while (true)
            {
                HelloRequest request = new HelloRequest();
                request.message = "this message from protobuf-net";
                try
                {
                    channel.CallMethod("maid.example.HelloService.HelloNotify", request);
                    channel.CallMethod("maid.example.HelloService.HelloRpc", request);
                }
                catch (Exception ){ }
                if (!channel.Connected && channel.Connecting)
                {
                    Console.WriteLine("断线了，重连中");
                }

                channel.Update();
            }
        }
    }

    class HelloService
    {
        public void HelloRpc(Controller controller, HelloRequest request, HelloResponse response)
        {
            Console.WriteLine("request: " + request.message + " response: " + response.message);
        }

        public void HelloNotify(Controller controller, HelloRequest request)
        {
            Console.WriteLine("notify: " + request.message);
        }
    }
}
