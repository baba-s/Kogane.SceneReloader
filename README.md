# Kogane Scene Reloader

現在のシーンをリロードするクラス

## 使用例

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Space ) )
        {
            SceneReloader.ReloadScene();
        }
    }
}
```