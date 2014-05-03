using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler11
{
    enum Direction
    {
        Left, Right, Up, Down,
        DiagonalUpperLeft, DiagonalLowerLeft,
        DiagonalUpperRight, DiagonalLowerRight
    }

    class Grid
    {
        private Cell<int>[,] cells;
        public Cell<int> this[int row, int column]
        {
            get { return cells[row, column]; }
        }

        public Grid(int sizeY, int sizeX, params int[] numbers)
        {
            cells = new Cell<int>[sizeY, sizeX];
            int m = 0;

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j] = new Cell<int>(new Position(i, j), numbers[m++]);
                }
            }
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return cells.GetEnumerator();
        }

        public List<int> GetNeighbours(Cell<int> cell, Direction direction, int neighboursToGet)
        {
            return GetNeighbours(cell, direction, neighboursToGet, new List<int>());
        }

        public List<int> GetNeighbours(Cell<int> cell, Direction direction, int neighboursToGet, List<int> neighbours)
        {
            if (neighboursToGet > 0)
            {
                int x = 0;
                int y = 0;
                Cell<int> neighbour;

                switch (direction)
                {
                    case Direction.Left:
                        x = cell.Position.Column - 1;
                        break;
                    case Direction.Right:
                        x = cell.Position.Column + 1;
                        break;
                    case Direction.Up:
                        y = cell.Position.Row - 1;
                        break;
                    case Direction.Down:
                        y = cell.Position.Row + 1;
                        break;
                    case Direction.DiagonalLowerLeft:
                        y = cell.Position.Row + 1;
                        x = cell.Position.Column - 1;
                        break;
                    case Direction.DiagonalUpperLeft:
                        y = cell.Position.Row - 1;
                        x = cell.Position.Column - 1;
                        break;
                    case Direction.DiagonalLowerRight:
                        y = cell.Position.Row + 1;
                        x = cell.Position.Column + 1;
                        break;
                    case Direction.DiagonalUpperRight:
                        y = cell.Position.Row - 1;
                        x = cell.Position.Column + 1;
                        break;
                }

                //Check so there are more cells to get
                if (x < cells.GetLowerBound(0) || x > cells.GetUpperBound(0) || y < cells.GetLowerBound(0) || y > cells.GetUpperBound(0))
                {
                    return neighbours;
                }

                neighbour = cells[y, x];
                neighbours.Add(neighbour.Value);
                GetNeighbours(neighbour, direction, neighboursToGet - 1, neighbours);
            }
            return neighbours;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    if (cells[j, i].Value < 10)
                    {
                        sb.Append("0" + cells[j, i].Value + " ");
                    } 
                    else
                    {
                        sb.Append(cells[j, i].Value + " ");
                    }
                }
                sb.AppendLine(); // Line break here
            }
            return sb.ToString();
        }

    }
}
