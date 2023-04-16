using UnityEngine;

internal class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 500;
    public InputPresenter Presenter { get; set; }
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        var direction = Presenter.InputVector;
        _rb.AddForce(direction * speed * Presenter.DeltaTime, ForceMode.Impulse);
    }
}
