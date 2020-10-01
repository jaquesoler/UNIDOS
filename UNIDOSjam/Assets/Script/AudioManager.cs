using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance = null;
    public static AudioManager Instance{
        get{return instance;}
    }

    //private GameObject musicmanager;

    void Awake(){
        GameObject musicmanager = GameObject.FindGameObjectWithTag("MusicManager");
        if(musicmanager){return;}
        if(instance != null && instance != this){
            Destroy(this.gameObject);
            return;
        } else {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
