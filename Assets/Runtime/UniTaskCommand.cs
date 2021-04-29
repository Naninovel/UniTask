using System;
using Naninovel;
using Cysharp.Threading.Tasks;
using UnityEngine;

[CommandAlias("uniTask")]
public class UniTaskCommand : Command
{
    [ParameterAlias(NamelessParameterAlias), RequiredParameter]
    public StringParameter Message;

    public override async UniRx.Async.UniTask ExecuteAsync (CancellationToken cancellationToken = default)
    {
        var message = await WaitAndReturnMessageAsync();
        Debug.Log(message);
    }

    private async UniTask<string> WaitAndReturnMessageAsync ()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(1));
        return Message;
    }
}
