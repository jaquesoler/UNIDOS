using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance = null;
    public static AudioManager Instance{
        get{return instance;}
    }

    void Awake(){
        if(instance != null && instance != this){
            Destroy(this.gameObject);
            return;
        } else {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
