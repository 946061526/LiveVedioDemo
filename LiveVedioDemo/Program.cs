using System;
using System.Collections.Generic;
using System.Linq;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Live.Model.V20161101;

namespace LiveVedioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ILiveVedio liveVedio = LiveVedioFactory.CreateLiveVedio();
            string result = liveVedio.GetOnlineList();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
