using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15Puzzle


{
    public class PuzzleGrid
    {
        private const int EmptySlotValue = 0;

        int[] slots;


        private int size, length;

        public PuzzleGrid(int sideLength)
        {
            length = sideLength;
            size = sideLength*sideLength;
            slots = new int[size];
            do
            {
                Randomize();
            } while (!isSolveable(slots));
        }

        public int GetSlotValue(int slotNumber)
        {
            return slots[slotNumber];
        }

        public void Randomize()
        {
            for (int i = 0; i < size; i++)
            {
                slots[i] = 0;
            }

            for (int i = 1; i < size; i++)
            {
                int x;
                do
                {
                    x = size.Random();
                } while (slots[x] != 0);

                slots[x] = i;
            }

        }


        public bool IsPuzzleSolved()
        {
            bool solved = true;
            for (int i = 0; i < 15; i++)
            {
                if (slots[i] != i+1) solved = false;
            }
            return solved;
        }

        int SlotNumberToCol(int num)
        {
            return (num % length);
        }

        int SlotNumberToRow(int num)
        {
            //int width = size - 1;
            if (num >= 0 && num <= 3) return 0;
            else if (num >= 4 && num <= 7) return 1;
            else if (num >= 8 && num <= 11) return 2;
            else if (num >= 12 && num <= 15) return 3;
            else return -1;
        }

        int RowColToSlot(int row, int col)
        {
            return (row * length + col);
        }

        public directions CanSwapSlot(int slot)
        {
            int row = SlotNumberToRow(slot);
            int col = SlotNumberToCol(slot);

            //check above
            if (row > 0)
            {
                int newslot = RowColToSlot(row - 1, col);
                if (slots[newslot]==0) return directions.up;
            }

            //check below
            if (row < 3)
            {
                int newslot = RowColToSlot(row + 1, col);
                if (slots[newslot]==0) return directions.down;
            }

            //check left
            if (col >0)
            {
                int newslot = RowColToSlot(row, col-1);
                if (slots[newslot] == 0) return directions.left;
            }

            //check right
            if (col < 3)
            {
                int newslot = RowColToSlot(row, col + 1);
                if (slots[newslot] == 0) return directions.right;
            }

            return directions.nulldirection;
        }


        public void SwapSlot(int slot, directions dir)
        {
            int row = SlotNumberToRow(slot);
            int col = SlotNumberToCol(slot);

            int newrow=0;
            int newcol=0;

            switch (dir)
            {
                case directions.up:
                    newrow = row - 1;
                    newcol = col;
                    break;

                case directions.right:
                    newrow = row;
                    newcol = col + 1;
                    break;

                case directions.down:
                    newrow = row + 1;
                    newcol = col;
                    break;

                case directions.left:
                    newrow = row;
                    newcol = col - 1;
                    break;
            }

            int newslot = RowColToSlot(newrow, newcol);

            slots[newslot] = slots[slot];
            slots[slot] = 0;

        }

        public bool isSolveable(int[] slots)
        {

            // see http://www.cs.bham.ac.uk/~mdr/teaching/modules04/java2/TilesSolvability.html
            // for the reasoning behind this code.
            int inversions = 0;
            int blankrow=0;

            for (int i = 1; i <= 15; i++)
            {
                if (slots[i] == 0) blankrow = SlotNumberToRow(i);
                for (int j = i; j <= 5; j++)
                {
                    if (slots[i] > slots[j]) inversions++;
                }
            }

            if ((inversions % 2) == 1 && (blankrow % 2) == 0) return true;
            else if ((inversions % 2) == 0 && (blankrow % 2) == 1) return true;
            else return false;
        }

    }
}
