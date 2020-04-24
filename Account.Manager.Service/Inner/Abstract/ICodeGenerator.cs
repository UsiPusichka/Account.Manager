namespace Account.Manager.Service.Inner.Abstract
{
    public interface ICodeGenerator
    {
        /// <summary>
        /// Generate code for sms or similar
        /// </summary>
        /// <param name="salt"></param>
        /// <returns></returns>
        string Generate4DigitCode(int salt);
    }
}
