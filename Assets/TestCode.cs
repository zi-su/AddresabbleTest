using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
public class TestCode : MonoBehaviour
{
    UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> handle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            handle = Addressables.LoadAssetAsync<GameObject>("prefabB");
            handle.Completed += onComplete;

        }
    }

    void onComplete(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> h)
    {
        if(h.Status == UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus.Succeeded)
        {
            Instantiate(h.Result);
        }
    }
}
