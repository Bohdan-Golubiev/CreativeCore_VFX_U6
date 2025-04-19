using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Swords_Toggle : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;

    public ParticleSystem fireParticle;

    bool isPlaying = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if (isPlaying)
            {
                fireParticle.Stop();
                isPlaying = false;
            }
            else
            {
                fireParticle.Play();
                isPlaying = true;
            }
        }
    }
}
