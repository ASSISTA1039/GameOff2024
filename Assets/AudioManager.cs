using UnityEngine;

public class AudioManager : MonoBehaviour


{
    // Start is called before the first frame update

    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Source ----------")]
    public AudioClip Background;
    public AudioClip OpenDoor;
    public AudioClip Pickup1;
    public AudioClip Pickup2;
    public AudioClip MagicSound;
    public AudioClip StongGateOpen;
    public AudioClip ClockTicking;
    public AudioClip Book;
    public AudioClip WindAmbiance;

    private void Start()
    {
        musicSource.clip = Background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}
