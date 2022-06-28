namespace TilfeldigeFirkanter
{
    class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        public char GetCharacter()
        {
            char character = '┼';
            if (!Up && !Down && !Left && !Right == true) character = ' ';
            else if (!Up && !Down && Left && Right == true) character = '─';
            else if (Up && Down && !Left && !Right == true) character = '│';
            else if (!Up && Down && Left && !Right == true) character = '┐';
            else if (!Up && Down && !Left && Right == true) character = '┌';
            else if (Up && !Down && Left && !Right == true) character = '┘';
            else if (Up && !Down && !Left && Right == true) character = '└';
            else if (Up && Down && !Left && Right == true) character = '├';
            else if (Up && Down && Left && !Right == true) character = '┤';
            else if (!Up && Down && Left && Right == true) character = '┬';
            else if (Up && !Down && Left && Right == true) character = '┴';
            return character;            
        }

        public void AddHorizontal() { Left = true; Right = true; }
        public void AddVertical() { Up = true; Down = true; }
        public void AddLowerLeftCorner() { Up = true; Right = true; }
        public void AddUpperLeftCorner() { Down = true; Right = true; }
        public void AddUpperRightCorner() { Down = true; Left = true; }
        public void AddLowerRightCorner() { Left = true; Up = true; }
    }
}
