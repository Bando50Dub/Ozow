using System;

namespace GameOfLife
{
    public class LifeGame
    {
        private int _columns;
        private int _rows;
        private bool[,] _cells;

        public LifeGame(int columns, int rows)
        {
            _columns = columns;
            _rows = rows;
            _cells = new bool[columns, rows];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            Random generator = new Random();
            int number;
            for (int i = 0; i < _columns; i++)
            {
                for (int j = 0; j < _rows; j++)
                {
                    number = generator.Next(2);
                    _cells[i, j] = number != 0;
                }
            }
        }

        private void StartTheGame()
        {
            for (int i = 0; i < _columns; i++)
            {
                for (int j = 0; j < _rows; j++)
                {
                    Console.Write(_cells[i, j] ? "*" : " ");
                    if (j == _rows - 1) Console.WriteLine("\r");
                }
            }
            Console.SetCursorPosition(0, Console.WindowTop);
        }

        public void DrawAndGrow()
        {
            StartTheGame();
            AddNeighbour();
        }

        private void AddNeighbour()
        {
            for (int i = 0; i < _columns; i++)
            {
                for (int j = 0; j < _rows; j++)
                {
                    int numOfAliveNeighbors = GetNeighbors(i, j);

                    if (_cells[i, j])
                    {
                        if (numOfAliveNeighbors < 2)
                        {
                            _cells[i, j] = false;
                        }

                        if (numOfAliveNeighbors > 3)
                        {
                            _cells[i, j] = false;
                        }
                    }
                    else
                    {
                        if (numOfAliveNeighbors == 3)
                        {
                            _cells[i, j] = true;
                        }
                    }
                }
            }
        }

        private int GetNeighbors(int x, int y)
        {
            int NumOfAliveNeighbors = 0;

            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if (!((i < 0 || j < 0) || (i >= _columns || j >= _rows)))
                    {
                        if (_cells[i, j] == true) NumOfAliveNeighbors++;
                    }
                }
            }
            return NumOfAliveNeighbors;
        }
    }
}
