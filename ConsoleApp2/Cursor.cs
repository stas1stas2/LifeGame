namespace LifeGame
{
    internal class Cursor
    {
        private readonly int maxXPosition;
        private readonly int maxYPosition;
        private int xPosition;
        private int yPosition;

        public Cursor(int maxXCursorPosition, int maxYCursorPosition)
        {
            maxXPosition = maxXCursorPosition;
            maxXPosition = maxYCursorPosition;

            xPosition = 0;
            yPosition = 0;
        }

        public int XPosition
        {
            get
            {
                return xPosition;
            }
            set
            {
                if (value > 0 && maxXPosition > value)
                {
                    xPosition = value;
                }
            }
        }
        public int YPosition
        {
            get
            {
                return yPosition;
            }
            set
            {
                if (value > 0 && maxYPosition > value)
                {
                    yPosition = value;
                }
            }
        }
    }
}
