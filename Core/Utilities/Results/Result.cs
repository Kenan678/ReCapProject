using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool issuccess,string message):this(issuccess)
        {
            Message = message;  
        }
        public Result(bool issuccess)
        {
            IsSuccess= issuccess;   
        }
        public string Message { get; }

        public bool IsSuccess { get; }
    }
}
