using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour 
{
    public GameObject hitAudio;
    public GameObject fireAudio;

    void Start()
    {
        // We create an instance of the fireAudio object, so that we can have 
        // control over the properties of the sound.
        var soundObject = Instantiate(fireAudio, transform.position, Quaternion.identity)
            as GameObject;
        AudioSource soundSource = soundObject.GetComponent<AudioSource>();
        soundSource.PlayOneShot(soundSource.clip);
    }

    void OnCollisionEnter(Collision collision)
    {
        // We create an instance of the hitAudio object, so that we can have 
        // control over the properties of the sound.
        var soundObject = Instantiate(hitAudio, transform.position, Quaternion.identity)
            as GameObject;
        AudioSource soundSource = soundObject.GetComponent<AudioSource>();
        soundSource.PlayOneShot(soundSource.clip); 
        Destroy(this.gameObject);
    }
}