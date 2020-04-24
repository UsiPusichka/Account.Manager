using Account.Manager.Service.Inner.Abstract;
using System;

namespace Account.Manager.Service.Inner.Concrete
{
    public class CodeGenerator : ICodeGenerator
    {
        public string Generate4DigitCode(int salt)
        {
            var rand = new Random();
            var randInt = (rand.Next(0, 10000) * (salt + 1)) % 10000;
            return $"{randInt:0000}";
        }
    }
}
