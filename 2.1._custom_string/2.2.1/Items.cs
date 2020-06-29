using System;

namespace _2._2._1
{
    public abstract class Items
    {
        protected int x;
        protected int y;

        public void SetItem(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected bool CheckField(int x, int y)
        {
            if (this.x == x && this.y == y)
            {
                return true;
            }

            return false;
        }

        public abstract int GetEffect(int x, int y);
    }
}
