using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _15Puzzle
{
    public partial class Form1 : Form
    {
        private const int sideLength = 4;
        PuzzleGrid puzzle;

        public Form1()
        {
            InitializeComponent(); //do not delete InitializeComponent()
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            puzzle = new PuzzleGrid(sideLength);

            Draw();
        }

        private void Draw()
        {
            output.Text = string.Empty;

            button1.Text = puzzle.GetSlotValue(0).ConvertZeroToEmpty();
            button2.Text = puzzle.GetSlotValue(1).ConvertZeroToEmpty();
            button3.Text = puzzle.GetSlotValue(2).ConvertZeroToEmpty();
            button4.Text = puzzle.GetSlotValue(3).ConvertZeroToEmpty();
            button5.Text = puzzle.GetSlotValue(4).ConvertZeroToEmpty();
            button6.Text = puzzle.GetSlotValue(5).ConvertZeroToEmpty();
            button7.Text = puzzle.GetSlotValue(6).ConvertZeroToEmpty();
            button8.Text = puzzle.GetSlotValue(7).ConvertZeroToEmpty();
            button9.Text = puzzle.GetSlotValue(8).ConvertZeroToEmpty();
            button10.Text = puzzle.GetSlotValue(9).ConvertZeroToEmpty();
            button11.Text = puzzle.GetSlotValue(10).ConvertZeroToEmpty();
            button12.Text = puzzle.GetSlotValue(11).ConvertZeroToEmpty();
            button13.Text = puzzle.GetSlotValue(12).ConvertZeroToEmpty();
            button14.Text = puzzle.GetSlotValue(13).ConvertZeroToEmpty();
            button15.Text = puzzle.GetSlotValue(14).ConvertZeroToEmpty();
            button16.Text = puzzle.GetSlotValue(15).ConvertZeroToEmpty();
        }

        #region Button Click Handlers

        private void button1_Click(object sender, EventArgs e)
        {
            processClick(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processClick(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            processClick(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            processClick(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            processClick(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            processClick(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            processClick(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            processClick(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            processClick(8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            processClick(9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            processClick(10);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            processClick(11);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            processClick(12);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            processClick(13);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            processClick(14);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            processClick(15);
        }

        #endregion

        private void randomize_Click(object sender, EventArgs e)
        {
            puzzle.Randomize();
            Draw();
        }

        private void processClick(int i)
        {
            directions dir = puzzle.CanSwapSlot(i);
            if (dir != directions.nulldirection) puzzle.SwapSlot(i, dir);
            Draw();
            if (puzzle.IsPuzzleSolved()) output.Text = "You win! <3";
        }

    }
}
