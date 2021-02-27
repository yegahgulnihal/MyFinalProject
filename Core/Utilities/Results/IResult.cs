using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }//başarılı(true) ya da başarısız(false)
        string Message { get; }
    }
}
