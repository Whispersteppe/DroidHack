using DroidHack.Common.Model;

namespace DroidHack.Common.Interface;

public interface IWorldServer
{
    public Task SubmitDroid(Droid droid);

    //  could do realtime or generate a script that show everything that happened for playback.
    public Task RunSimulation();

}
