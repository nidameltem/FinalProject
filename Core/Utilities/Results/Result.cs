using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
      

        public Result(bool success, string message): this(success) //bunu yaptığım an aşağıdaki tek parametreli constructor da çalışacak
        {
            Message = message;
           
        }
        public Result(bool success)
        {
            
            Success = success;
        }



        public bool Success { get; }

        public string Message { get; }
    }
}
