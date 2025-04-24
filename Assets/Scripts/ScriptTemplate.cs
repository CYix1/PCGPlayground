
using UnityEngine;

public class ScriptTemplate
{
    public static Color FloatToCol(float value)
    {
        return new Color(value, value, value);
    }

    public static Color[] FloatToCols(float[] values)
    {
        Color[] result = new Color[values.Length];
        for (int i = 0; i < values.Length; i++)
        {
            result[i] = FloatToCol(values[i]);
        }

        return result;
    }
}
