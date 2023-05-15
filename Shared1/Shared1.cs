namespace MyNamespace
{
    struct MyStruct
    {
        private int x;
        private int y;
        private int z;

        public MyStruct(out int x, int y, int z)
        {
            x = 1;
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}