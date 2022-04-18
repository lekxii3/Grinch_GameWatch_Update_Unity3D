using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int CurrentGiftCatch = 0;
    public int CurrentLife =3;



    void OnEnable() 
   {
       Shape.SignalShapeLaunch += GiftDeposite;
       Gift.SignalGiftLaunch += LifeLost;
   }

   void OnDisable() 
   {
       Shape.SignalShapeLaunch -= GiftDeposite;
       Gift.SignalGiftLaunch -= LifeLost;
   }


    


    public void GiftDeposite()
    {
        CurrentGiftCatch ++;       
    }

    public void LifeLost()
    {
        CurrentLife --;
    }

}
