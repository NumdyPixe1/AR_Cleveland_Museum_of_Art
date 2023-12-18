using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public Object nagaEnthronedBuddha;
    public GameObject[] obj;
    public GameObject[] buttonUI;
    public bool[] selectObj;
    public GameObject[] buddhaPart;
    public GameObject[] popUp;

    //    [SerializeField] private bool[] isActive;
    private void Awake()
    {
         for(int i = 0; i <= 2; i++)
         { 
            buddhaPart[i].SetActive(nagaEnthronedBuddha.isActive[i] = true);
         }
        // for(int i = 0;i <= 3; i++)
        //{
        //    obj[i].SetActive(selectObj[i] = false);
        //    buttonUI[i].SetActive(selectObj[i] = false);
        //}
    }
    //public void Naga()
    //{
    //    if (selectObj[0])
    //    {
    //        obj[0].SetActive(true);
    //        buttonUI[0].SetActive(true);
    //    }
    //    else if (selectObj[0]) 
    //    {
    //        obj[0].SetActive(false);
    //        buttonUI[0].SetActive(true);
    //    }
       
    //}
    public void Hood()
     {
         if (nagaEnthronedBuddha.isActive[0])
        {
            nagaEnthronedBuddha.isActive[0] = false;
       }else if(!nagaEnthronedBuddha.isActive[0])
      {
            nagaEnthronedBuddha.isActive[0] =true;
       }
        buddhaPart[0].SetActive(nagaEnthronedBuddha.isActive[0]);
    }
     public void Body()
     {
        if (nagaEnthronedBuddha.isActive[1])
        {
            nagaEnthronedBuddha.isActive[1] = false;
        }
        else if (!nagaEnthronedBuddha.isActive[1])
         {
            nagaEnthronedBuddha.isActive[1] = true;
         }
       buddhaPart[1].SetActive(nagaEnthronedBuddha.isActive[1]);
    }
     public void Base()
     {
        if (nagaEnthronedBuddha.isActive[2])
        {
            nagaEnthronedBuddha.isActive[2] = false;
        }
       else if (!nagaEnthronedBuddha.isActive[2])
        {
            nagaEnthronedBuddha.isActive[2] = true;
        }
          
        buddhaPart[2].SetActive(nagaEnthronedBuddha.isActive[2]);
    }
    public void PopUp()
    {
            if (nagaEnthronedBuddha.isActive[3])
            {
                nagaEnthronedBuddha.isActive[3] = false;
            }
            else if (!nagaEnthronedBuddha.isActive[3])
            {
                nagaEnthronedBuddha.isActive[3] = true;
            }
            popUp[0].SetActive(nagaEnthronedBuddha.isActive[3]);
         
      
    }

}

    
 
