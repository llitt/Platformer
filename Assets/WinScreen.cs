using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
   // Start is called before the first frame update
   public void LoadBonusLevel() {
      SceneManager.LoadScene(22);
   }
   public void QuitButton()
   {
      Application.Quit(0);
   }
}
