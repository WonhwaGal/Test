using UnityEngine;

internal class KeyInput : IInputReaization
{
    private float XInput;
    private float ZInput;

    private readonly IUserInputProxy xAxis = new XAxisProxy();
    private readonly IUserInputProxy zAxis = new ZAxisProxy();

    public Vector3 GetInput()
    {
        XInput = xAxis.GetAxis();
        ZInput = zAxis.GetAxis();
        return new Vector3(XInput, 0, ZInput);
    }
}