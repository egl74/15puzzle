using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15Puzzle
{
    public class PuzzleGrid
    {
        private const int EmptySlotValue = 0;

        public PuzzleGrid(int sideLength)
        {

            Randomize();
        }

        public int GetSlotValue(int slotNumber)
        {
            return 0;
        }

        public void Randomize()
        {

        }

        public void MoveSlot(int slotNumber)
        {

        }

        public bool IsPuzzleSolved()
        {
            return false;
        }
    }
}
