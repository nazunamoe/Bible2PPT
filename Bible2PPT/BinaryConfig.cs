using System.IO;

namespace Bible2PPT
{
    abstract class BinaryConfig
    {
        protected string path;
        protected int size;

        public BinaryConfig(string path, int size)
        {
            this.path = path;
            this.size = size;
            Reload();
        }

        public void Save()
        {
            using var fs = File.OpenWrite(path);
            fs.Write(Serialize(), 0, size);
        }

        public void Reload()
        {
            try
            {
                using var fs = File.OpenRead(path);
                var data = new byte[size];
                // 이전 버전의 짧은 설정 파일이면 나머지는 0으로 둠
                fs.ReadAtLeast(data, size, throwOnEndOfStream: false);
                Deserialize(data);
            }
            catch (FileNotFoundException)
            {
                // noop
            }
        }

        protected abstract byte[] Serialize();
        protected abstract void Deserialize(byte[] s);
    }
}
