using System;
namespace CustomException
{
    public class AgeUnderTwelveException : Exception{
        public AgeUnderTwelveException(String message):base(message){}
    }
}