using System;
using System.Collections.Generic;

namespace MarsRoverStudy
{
    public class Move
    {
        int pointX = 0;
        int pointY = 0;
        Direction direction = Direction.N;

        public Move(int _x, int _y,  string _direction)
        {
            pointX = _x;
            pointY = _y;
            direction = (Direction)Enum.Parse(typeof(Direction), _direction);
        }
        public string DoAction(List<int> topPoint, string actions)
        { 
            foreach (var action in actions)
            {
                switch (action)
                {
                    case 'M':
                        GoStraight();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'L':
                        TurnLeft();
                        break;

                    default:
                        Console.WriteLine("Sorry, Invalid Direction!");
                        break;
                }

                if (pointX > topPoint[0] || pointY > topPoint[1] || pointX < 0 || pointY < 0)
                {
                    throw new Exception("Crash! Plateau Limits Reached");
                }
            }

            return pointX + " " + pointY + " " + direction;
        }

        private void TurnRight()
        {
            switch (direction)
            {
                case Direction.E:
                    direction = Direction.S;
                    break;
                case Direction.W:
                    direction = Direction.N;
                    break;
                case Direction.N:
                    direction = Direction.E;
                    break;
                case Direction.S:
                    direction = Direction.W;
                    break;

                default:
                    break;
            }
        }

        private void TurnLeft()
        {
            switch (direction)
            {
                case Direction.E:
                    direction = Direction.N;
                    break;
                case Direction.W:
                    direction = Direction.S;
                    break;
                case Direction.N:
                    direction = Direction.W;
                    break;
                case Direction.S:
                    direction = Direction.E;
                    break;

                default:
                    break;
            }
        }

        private void GoStraight()
        {
            switch (direction)
            {
                case Direction.E:
                    pointX += 1;
                    break;
                case Direction.W:
                    pointX -= 1;
                    break;
                case Direction.N:
                    pointY += 1;
                    break;
                case Direction.S:
                    pointY -= 1;
                    break;

                default:
                    break;
            }
        }
    }
}
