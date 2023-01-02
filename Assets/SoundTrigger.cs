using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundTrigger : MonoBehaviour
{
    public AudioSource myAudio;
    public SkinnedMeshRenderer meshChar;
    public bool isDone;
    // Start is called before the first frame update
    void Start()
    {
        isDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (meshChar.enabled == true && isDone == false)
        {
            myAudio.Play();
            myAudio.loop = true;
            isDone = true;
        }
        else if (meshChar.enabled == false)
        {
            myAudio.loop = false;
            isDone = false;
        }
        
    }
}
