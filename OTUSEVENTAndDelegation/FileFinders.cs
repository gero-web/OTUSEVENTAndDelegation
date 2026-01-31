using OTUSEVENTAndDelegation.EnetsArgs;

namespace OTUSEVENTAndDelegation
{
    internal class FileFinders
    {
        public event EventHandler<FileArgs> FileHangler;

        public void SearchFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("Путь не может быть пустым");
            }

            DirectoryInfo dir = new(path);
            if (!dir.Exists)
            {
                throw new ArgumentNullException($"Пути не существует {path}");
            }

            var files = dir.GetFiles("*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                var args = new FileArgs(fileName: file.Name);
                FileHangler?.Invoke(this, args);
                if (args.Cansel)
                {
                    return;
                }
            }

        }
    }
}
