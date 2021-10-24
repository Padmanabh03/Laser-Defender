using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingCilp;
    [SerializeField] [Range(0f,1f)] float shootingVolume = 1f;

    [Header("Damage")]
    [SerializeField] AudioClip damageCilp;
    [SerializeField] [Range(0f,1f)] float damageVolume = 1f;

    static AudioPlayer instance;

    void Awake()
    {
        ManageSingleton();
    }

    void ManageSingleton()
    {

        if(instance!= null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlayShootingClip()
    {
        if(shootingCilp != null)
        {
            AudioSource.PlayClipAtPoint(shootingCilp,Camera.main.transform.position,shootingVolume);
        }
    }

    public void PlayDamageClip()
    {
        if(shootingCilp != null)
        {
            AudioSource.PlayClipAtPoint(damageCilp,Camera.main.transform.position,damageVolume);
        }
    }
}
