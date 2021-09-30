using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(AlarmThiefSearcher))]
public class AlarmAnimator : MonoBehaviour
{
    private Animator _animator;
    private AlarmThiefSearcher _alarmThiefSearcher;

    private void Start()
    {
        _alarmThiefSearcher = GetComponent<AlarmThiefSearcher>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.SetBool("IsAlarmActive", _alarmThiefSearcher.IsAlarmActive);
    }
}
