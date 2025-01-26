using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    public AudioClip newMusic;
    private AudioController AC;
    private CameraController CC;
    public Vector2 MinPos;
    public Vector2 MaxPos;
    void Start()
    {
        AC = FindObjectOfType<AudioController>();
        CC.maxPosition = MaxPos;
        CC.minPosition = MinPos;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            if(newMusic != null){
                AC.changeMusic(newMusic);

            }
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player"){
            AC.resetMusic();
        }
    }
}
