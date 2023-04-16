using UnityEngine;

public class XAxisProxy : IUserInputProxy
{
    public float GetAxis()
    {
        return Input.GetAxis("Horizontal");
    }
}



public class ZAxisProxy : IUserInputProxy
{
    public float GetAxis()
    {
        return Input.GetAxis("Vertical");
    }
}
