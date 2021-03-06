using OpenQA.Selenium;
using System;
using System.Runtime.Serialization;

namespace Riganti.Utils.Testing.SeleniumCore.Exceptions
{
    [Serializable]
    public class InvalidRedirectException : WebDriverException
    {
        public InvalidRedirectException()
        {
        }

        public InvalidRedirectException(string message) : base(message)
        {
        }

        public InvalidRedirectException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidRedirectException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}