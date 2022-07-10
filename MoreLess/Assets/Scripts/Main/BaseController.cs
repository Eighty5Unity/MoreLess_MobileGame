using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class BaseController : IDisposable
{
    private List<BaseController> _baseControllers = new List<BaseController>();
    private List<GameObject> _gameObjects = new List<GameObject>();
    private bool _isDisposed;

    protected void AddController(BaseController controller)
    {
        _baseControllers.Add(controller);
    }

    protected void AddGameObject(GameObject gameObject)
    {
        _gameObjects.Add(gameObject);
    }

    public void Dispose()
    {
        if (_isDisposed)
        {
            return;
        }

        _isDisposed = true;

        foreach(var controller in _baseControllers)
        {
            controller?.Dispose();
        }
        _baseControllers.Clear();

        foreach(var gameObject in _gameObjects)
        {
            Object.Destroy(gameObject);
        }
        _gameObjects.Clear();

        OnDispose();
    }

    protected virtual void OnDispose()
    {

    }
}
