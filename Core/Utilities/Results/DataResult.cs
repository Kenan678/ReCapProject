using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {


        public DataResult(T data, bool issuccess, string message) : base(issuccess, message)
        {
            Data = data;
        }
        public DataResult(T data, bool issuccess) : base(issuccess)
        {

        }
        public T Data { get; }
    }
}
