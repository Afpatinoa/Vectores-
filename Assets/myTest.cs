using UnityEngine;

public class myTest : MonoBehaviour
{
    [SerializeField]Vector vector1 = new Vector(2, 2);
    [SerializeField]Vector vector2 = new Vector(-3, 3);
    [SerializeField][Range(0,1)] float escalarEscalado = 1;
    Vector vectorSum;
    Vector vectorSub;
    Vector vectorMulti;
    Vector vector1Nor;
    Vector vector2Nor;
    float magnitud1, magnitud2;

    private void Update()
    {

        vectorSum = vector1 + vector2;
        vectorSub = vector1-vector2;
        var vectorScale = vectorSub * escalarEscalado;
        vector1.Draw();
        vector2.Draw();
        vectorScale.Draw(vector2);
    }
}
