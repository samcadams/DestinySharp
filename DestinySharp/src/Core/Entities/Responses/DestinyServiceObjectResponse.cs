using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinySharp.Core
{
    public class DestinyServiceObjectResponse<T>
    {
        public Response<T> Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public MessageData MessageData { get; set; }
    }
    public class Response<T>
    {
        public T data { get; set; }
    }

    public class MessageData
    {
        dynamic data { get; set; }
    }

}
