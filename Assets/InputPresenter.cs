using UnityEngine;

internal class InputPresenter : IExecute
{
    private IInputReaization _inputRealization;

    private Vector3 _inputVector;
    private float _deltaTime;
    public Vector3 InputVector { get => _inputVector; }
    public float DeltaTime { get => _deltaTime; }

    public InputPresenter(IInputReaization inputInitialisation)
    {
        _inputRealization = inputInitialisation;
    }

    public void Execute(float deltaTime)
    {
        _inputVector = _inputRealization.GetInput();
        _deltaTime = deltaTime;
    }
}
