public class Transform
{
    public int x;
    public int y;

    public Transform(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                y += 1;
                break;
            case Direction.Down:
                y -= 1;
                break;
            case Direction.Left:
                x -= 1;
                break;
            case Direction.Right:
                x += 1;
                break;
        }
    }

    public void Follow(Transform other)
    {
        int distanceX = other.x - x;
        int distanceY = other.y - y;

        if (Math.Abs(distanceX) >= Math.Abs(distanceY))
        {
            if (distanceX > 0)
            {
                Move(Direction.Right);
            }
            else
            {
                Move(Direction.Left);
            }
        }
        else
        {
            if (distanceY > 0)
            {
                Move(Direction.Up);
            }
            else
            {
                Move(Direction.Down);
            }
        }
    }

    public int Distance(Transform other)
    {
        return Math.Abs(other.x - x) + Math.Abs(other.y - y);
    }
}