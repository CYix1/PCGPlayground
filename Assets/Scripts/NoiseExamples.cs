using UnityEngine;

public class NoiseExamples : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public static float[,] GetRandomValues(Vector2Int dimensions)
    {
        float[,] result=new float[dimensions.x,dimensions.y];
        for (int i = 0; i < dimensions.x; i++)
        {
            for (int j = 0; j < dimensions.y; j++)
            {
                result[i, j] = Random.Range(-1.0f, 1.0f);
            }
        }

        return result;
    }
    
    //apply it in one dimesion
    public static float[] GetRandomValuesFlat(Vector2Int dimensions)
    {
        float[] result=new float[dimensions.x*dimensions.y];
        for (int i = 0; i < dimensions.x; i++)
        {
            for (int j = 0; j < dimensions.y; j++)
            {
                result[i + dimensions.y * j] = Random.Range(-1.0f, 1.0f);
            }
        }

        return result;
    }
}
