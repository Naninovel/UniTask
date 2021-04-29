// Using standalone UniTask v2 by default.
using Cysharp.Threading.Tasks;
using Naninovel;
using Naninovel.Commands;

public class UniTaskCommand : Command
{
    // This method uses embedded UniTask v1.
    public override async UniRx.Async.UniTask ExecuteAsync (CancellationToken cancellationToken = default)
    {
        var message = await WaitAndReturnMessageAsync();
        await new PrintText { Text = message }.ExecuteAsync();
    }

    // This method uses standalone UniTask v2.
    private async UniTask<string> WaitAndReturnMessageAsync ()
    {
        await UniTask.DelayFrame(100);
        return "Hello from UniTask v2!";
    }
}
