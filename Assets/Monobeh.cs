using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monobeh : MonoBehaviour
{
    [SerializeField] private PlayerMove player;
    private IInputReaization keys;
    private InputPresenter presenter;
    void Start()
    {
        keys = new KeyInput();
        presenter = new InputPresenter(keys);

        player.Presenter = presenter;
    }

    void Update()
    {
        presenter.Execute(Time.deltaTime);
    }
}
