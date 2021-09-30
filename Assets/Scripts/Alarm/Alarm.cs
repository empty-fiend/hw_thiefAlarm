using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private int _volumeChangeSpeed;
    [SerializeField] private float _maxVolume;

    [SerializeField] private Thief _thief;

    private float _requaredVolume = 0;
    private bool _isAlarmActive;

    private AudioSource _audioSource;

    public bool IsAlarmActive => _isAlarmActive;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (_audioSource.isPlaying)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _requaredVolume, Time.deltaTime / _volumeChangeSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == _thief.gameObject)
        {
            _audioSource.Play();
            _requaredVolume = _maxVolume;
            _isAlarmActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == _thief.gameObject)
        {
            _requaredVolume = 0;
            _isAlarmActive = false;
        }
    }
}
