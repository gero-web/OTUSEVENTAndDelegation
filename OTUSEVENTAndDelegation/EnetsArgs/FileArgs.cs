namespace OTUSEVENTAndDelegation.EnetsArgs
{
    internal class FileArgs(string fileName) : EventArgs
    {
        public string FileName { get; set; } = fileName;
    }
}
