using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
   public Color[] colors;
   public int lastseason;
    // Start is called before the first frame update
    void Start()
    {
      lastseason = 2;
    }

    // Update is called once per frame
    void Update()
    {
      if (LevelManager.LM.timestage != lastseason) {
         SpriteRenderer[] sprites = GetComponentsInChildren<SpriteRenderer>();
         foreach (SpriteRenderer sprite in sprites) {
            sprite.color = colors[LevelManager.LM.timestage];
         }
         lastseason = LevelManager.LM.timestage;
      }
    }
}
