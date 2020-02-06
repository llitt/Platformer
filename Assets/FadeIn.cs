using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
   Material filter;
   Color targetColor;
   public Color[] seasonfilters;
   float maxalpha;
    // Start is called before the first frame update
    void Start()
    {
      filter = GetComponent<MeshRenderer>().material;
      maxalpha = filter.color.a;
      filter.color = new Color(filter.color.r, filter.color.g, filter.color.b, 0f);
    }

    // Update is called once per frame
    void Update()
    {
      filter.color=Color.Lerp(filter.color, targetColor, .05f);
      targetColor = seasonfilters[LevelManager.LM.timestage];
      
   }
}
