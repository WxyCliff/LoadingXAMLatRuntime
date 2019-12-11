using System;

namespace DomainModel
{

    public class Response
    {
        public string Status { get; set; }

        public string ReturnCode { get; set; }

        public string Message { get; set; }

        public string ResponseTo { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
    }


    public class Response<T> : Response
    {
        public T Result { get; set; }
        public Response(T result, Response resp = (Response)default)
        {
            this.Result = result;
            this.ReturnCode = resp != null ? resp.ReturnCode : "500";
            this.Status = resp != null ? resp.Status:"error";
            this.Message = resp != null ? resp.Message : "error";
            this.ResponseTo = resp != null ? resp.ResponseTo : "user";
        }
    }
}
