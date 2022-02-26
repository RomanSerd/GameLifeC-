using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLive
{
   
    public class EngineGameLive
    {
        private int rows;
        private int cols;
        private bool[,] field;
        public EngineGameLive(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
        }
        public void CreateField(int Density)
        {
            field = new bool[cols, rows];
            Random rand = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = rand.Next(25-Density) == 0;
                }
            }
        }
        public bool[,] GetField()
        {
            bool[,] newfield = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    newfield[x, y] = field[x, y];
                }
            }

            return newfield;
        }
        public void NextGeneration()
        {

            bool[,] newField = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int neighboursCount = CountNeighbours(x, y);
                    bool HasLive = field[x, y];

                    if (!HasLive && neighboursCount == 3)
                        newField[x, y] = true;
                    else if (HasLive && (neighboursCount < 2 || neighboursCount > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];
                }
            }
            field = newField;

        }
        public void ChangeCell(int x, int y, bool value)
        {
            field[x, y] = value;
        }
        public void CreateNullField()
        {
            field = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = false;

                }
            }

        }
        private int CountNeighbours(int x, int y)
        {
            int Count = 0;
            for (int k = -1; k < 2; k++)
            {
                for (int j = -1; j < 2; j++)
                {
                    bool isSelfChecking = x + k == x && y + j == y;
                    bool hasLive = field[(cols + x + j) % cols, (rows + y + k) % rows];
                    if (hasLive && !isSelfChecking)
                        Count++;
                }
            }
            return Count;
        }
    }
}
