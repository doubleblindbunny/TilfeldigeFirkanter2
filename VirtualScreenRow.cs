
using System;
using System.Linq;

namespace TilfeldigeFirkanter2
{
    public class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;
        private int _width;
        private int _startX;

        public VirtualScreenRow(int width, int startX)
        {
            _startX = startX;
            _width = width;
            _cells = new VirtualScreenCell[width];
            for (int i = 0; i < width; i++)
            {
                _cells[i] = new VirtualScreenCell();
            }


        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddUpperLeftCorner();
            for (int i = 1; i < boxWidth - 1; i++)
            {
                _cells[boxX + i].AddHorizontal();
            }

            _cells[boxX + boxWidth - 1].AddUpperRightCorner();
        }

        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddLowerLeftCorner();
            for (int i = 1; i < boxWidth - 1; i++)
            {
                _cells[boxX + i].AddHorizontal();
            }

            _cells[boxX + boxWidth - 1].AddLowerRightCorner();

        }

        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddVertical();
            _cells[boxX + boxWidth -1].AddVertical();

        }

        public void Show()
        {
            Console.CursorLeft = _startX;
            var array = _cells.Select(kurt => kurt.GetCharacter()).ToArray();
            Console.WriteLine(array);
        }
    }
}
