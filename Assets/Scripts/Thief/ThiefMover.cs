using UnityEngine;

[RequireComponent(typeof(ThiefDirectionChanger))]
public class ThiefMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private ThiefDirectionChanger _thiefDirectionChanger;

    private void Start()
    {
        _thiefDirectionChanger = GetComponent<ThiefDirectionChanger>();
    }

    private void Update()
    {
        if (transform.position.x != _thiefDirectionChanger.TargetPoint.position.x)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector3(_thiefDirectionChanger.TargetPoint.position.x, transform.position.y), Time.deltaTime * _moveSpeed);
        }
    }
}
