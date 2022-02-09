using UnityEngine;

[System.Serializable]
public class Vector
{
    public float x, y, magnitud;


    public Vector(float xVec, float yVec)
    {
        x = xVec;
        y = yVec;
    }
    public static Vector operator +(Vector a, Vector b)
    {    return new Vector(a.x + b.x, a.y + b.y);  }
    public static Vector operator -(Vector a, Vector b)
    {    return new Vector(a.x - b.x, a.y - b.y);  }
    public static Vector operator *(Vector a, float b)
    {    return new Vector(a.x * b, a.y * b);      }
    public static Vector operator *(float b, Vector a)
    {    return new Vector(a.x * b, a.y * b);      }
    public static Vector operator/(Vector a, float b)
    {    return new Vector(a.x / b, a.y / b);      }
    public Vector Lerp(Vector other, float escalar)
    {    Vector result = new Vector((x*(1- escalar)+ (other.x*escalar)), (y*(1-escalar)+ (other.y * escalar)));
         return result;   }
    public float Magni()
    {    float result = Mathf.Sqrt((x * x) + (y * y));
        return result;    }
    public Vector Normal()
    {    magnitud = Mathf.Sqrt((x * x) + (y * y));
        Vector result = new Vector(x / magnitud, y / magnitud);
        return result;       
    }
    public void Draw(Vector origin = null)
    {    if (origin == null)
        {
            Debug.DrawLine(new Vector2(0, 0), new Vector2(x, y),Color.green);
            return;
        }
        Debug.DrawLine(new Vector2(origin.x, origin.y), new Vector2(x + origin.x, y + origin.y),Color.yellow);
        Debug.DrawLine(new Vector2(0, 0), new Vector2((x + origin.x + origin.x),(y + origin.y + origin.y)), Color.red);
    }
}
