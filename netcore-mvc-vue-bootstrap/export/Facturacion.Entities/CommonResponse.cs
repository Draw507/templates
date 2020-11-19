using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$
{
    public enum CommonResponseTypeStatus
    {
        success,
        warning,
        error
    }

    public class CommonResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class CommonResponse<T> : CommonResponse
    {
        public T Data { get; set; }

    }
}
