using Cysharp.Threading.Tasks;
using Naninovel;
using UnityEngine;

public class InitializeWithUniTask : MonoBehaviour
{
    // ReSharper disable once Unity.IncorrectMethodSignature
    private async UniTaskVoid Start ()
    {
        await RuntimeInitializer.InitializeAsync();
    }
}
