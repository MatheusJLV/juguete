using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReact : MonoBehaviour
{
    public AudioClip newTrack;
    private AudioManager audioManager;
    public Light lightobj;
    public Color colorselect;


    // Start is called before the first frame update
    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        lightobj = FindObjectOfType<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        {
            if (newTrack != null)
            {
                audioManager.changeBGMusic(newTrack);
            }
            lightobj.color = colorselect;
        }
    }


}
