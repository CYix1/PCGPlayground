using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TextureHelper : MonoBehaviour
{
    public Vector2Int dimension;

    private Texture texture;
    public RawImage rawImage;
    private void Start()
    {
        texture = new Texture2D(dimension.x, dimension.y);
        //new Texture2D(dimension.x,dimension.y).SetPixels(ScriptTemplate.FloatToCols(NoiseExamples.GetRandomValuesFlat(dimension)));
        rawImage.texture = texture;
        
        rawImage.SetNativeSize();
    }
    
    
}
