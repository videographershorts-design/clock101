
using UnityEngine;
using System;
public class Clock : UnityEngine.MonoBehaviour
{
  [SerializeField]
   Transform hoursPivot;

   [SerializeField]
   Transform minutesPivot;

   [SerializeField]
   Transform secondsPivot;

 
 void Start()
{

  

} 
 
  void Update () 
  {
    
    Debug.Log(DateTime.Now);
    hoursPivot.localRotation = Quaternion.Euler(0,0,-30f * DateTime.Now.Hour);
    minutesPivot.localRotation = Quaternion.Euler(0,0,-6f * DateTime.Now.Minute);
   secondsPivot.localRotation = Quaternion.Euler(0,0,-6f * DateTime.Now.Second);
  }
}


