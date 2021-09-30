using UnityEngine;

[RequireComponent(typeof(AlarmThiefSearcher))]
[RequireComponent(typeof(AudioSource))]
public class AlarmVolumeChanger : MonoBehaviour
{
    [SerializeField] private int _volumeChangeSpeed;
    [SerializeField] private float _maxVolume;

    private float _requaredVolume = 0;

    private AudioSource _audioSource;
    private AlarmThiefSearcher _alarmThiefSearcher;

    private void Start()
    {
        _alarmThiefSearcher = GetComponent<AlarmThiefSearcher>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _requaredVolume, Time.deltaTime / _volumeChangeSpeed);

        if (_alarmThiefSearcher.IsAlarmActive && _audioSource.isPlaying == false)
        {
            _audioSource.Play();
            _requaredVolume = _maxVolume;
        }
        else if (_alarmThiefSearcher.IsAlarmActive == false && _audioSource.isPlaying)
        {
            _requaredVolume = 0;
        }
    }
}
