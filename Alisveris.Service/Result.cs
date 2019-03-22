using System;

namespace Alisveris.Service
{
    public class Result
    {
        public Result()
        {

        }
        public Result(string message)
        {
            Message = message;
        }
        public Result(string message, bool hasError)
        {
            Message = message;
            HasError = hasError;
        }
        public Result(dynamic value, bool tokenStatus, string message)
        {
            Message = message;
            Value = value;
            TokenStatus = tokenStatus;
        }
        public Result(dynamic value, bool tokenStatus, string message, bool hasError, string stackTrace)
        {
            Message = message;
            Value = value;
            TokenStatus = tokenStatus;
            HasError = hasError;
            StackTrace = stackTrace;
        }
        public Result(dynamic value, bool tokenStatus, string message, bool hasError)
        {
            Message = message;
            Value = value;
            TokenStatus = tokenStatus;
            HasError = hasError;
        }
        public Result(dynamic value, bool tokenStatus, string message, bool hasError, long totalRecordCount)
        {
            Message = message;
            Value = value;
            TokenStatus = tokenStatus;
            HasError = hasError;
            TotalRecordCount = totalRecordCount;
        }
        public Result(dynamic value, long totalRecordCount, string message)
        {
            Message = message;
            Value = value;
            TotalRecordCount = totalRecordCount;
        }

        public dynamic Value { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; }
        public long TotalRecordCount { get; set; }
        public bool TokenStatus { get; set; }
        public string StackTrace { get; set; }
    }
}
