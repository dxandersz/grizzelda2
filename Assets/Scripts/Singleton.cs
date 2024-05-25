using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class is generic, which means that you can create multiple versions
// of it that vary depending on what type you specify for 'T'.
// In this case, we're also adding a type constraint, which means that 'T'
// must be a MonoBehaviour subclass.
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    // The instance. This property only has a getter, which means that
    // other parts of the code won't be able to modify it.
    public static T instance {
        get {
            // If we don't have an instance ready, get one by either finding or creating
            if (_instance == null) {
                _instance = FindOrCreateInstance();
            }
        return _instance;
        }      
    }
    // variable below stores actual instance. created if not already present
    private static T _instance;

    // Searches for instance of this singleton and creates if one doesn't exist
    private static T FindOrCreateInstance() {
        // Search for instance
        var instance = GameObject.FindObjectOfType<T>();
        if (instance != null) {
            return instance;
        }

        var name = typeof(T).Name + "Singleton";
        var containerGameObject = new GameObject(name);
        var singletonComponent = containerGameObject.AddComponent<T>();

        return singletonComponent;
    }
}
