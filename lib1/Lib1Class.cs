using Lib2;

namespace Lib1
{
    public class Lib1Class
    {
        private readonly Lib2Class _lib2Class = new Lib2Class();

        public int ReturnRandomValueFromLib2()
        {
            return _lib2Class.ReturnRandomValue();
        }
    }
}
